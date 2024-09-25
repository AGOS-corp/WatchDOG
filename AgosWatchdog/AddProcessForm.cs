using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgosWatchdog
{
    public partial class AddProcessForm : Form
    {
        public FileInfo fileInfo;
        public AddProcessForm()
        {
            InitializeComponent();
            tb_restart_period.SelectedIndex = 0;
        }

        public AddProcessForm(FileInfo _fileInfo)
        {
            InitializeComponent();
            FileInfoInitialize(_fileInfo);
            
        }

        private void FileInfoInitialize(FileInfo _fileInfo)
        {
            fileInfo = _fileInfo;
            Debug.WriteLine("FileInfoInitialize");
            tabControl1.SelectedIndex = 1;

            tb_nickName.Text = fileInfo.NickName;
            tb_path.Text = fileInfo.Path;
            tb_description.Text = fileInfo.Description;

            CB_AutoRestart.Checked = fileInfo.IsAutoReStart;
            CB_StartType.Checked = fileInfo.StartType;
            CB_RestartPeriod.Checked = fileInfo.IsPeriodRestart;
            tb_restart_period.SelectedIndex = fileInfo.periodIdx;
        }
        
        
        private void btn_load_process_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //File명과 확장자
                string fileName = ofd.SafeFileName;
                //File경로와 File명
                string fileFullName = ofd.FileName;
                //File경로
                string filePath = fileFullName.Replace(fileName, "");

                fileInfo = new FileInfo() { FileName = fileName, FileFullName = fileFullName,Path = filePath, State = ProcState.terminated};
                tb_nickName.Text = fileName;
                tb_path.Text = filePath;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fileInfo != null)
            {
                fileInfo.NickName = tb_nickName.Text;
                fileInfo.Description = tb_description.Text;
                fileInfo.StartType = CB_StartType.Checked; //프로세스 등록 시 바로 시작 여부.
                fileInfo.IsPeriodRestart = CB_RestartPeriod.Checked; //주기적으로 재시작 여부 설정
                fileInfo.periodIdx = tb_restart_period.SelectedIndex; //주기적으로 재시작할 시간 idx 설정
                fileInfo.IsAutoReStart = CB_AutoRestart.Checked; //process 종료 시 재시작 여부 설정
            
                GlobalData.fileInfo = fileInfo;
            
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
