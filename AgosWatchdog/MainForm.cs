using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgosWatchdog.Models;

namespace AgosWatchdog
{
    public partial class MainForm : Form
    {
        private AddProcessForm _processForm;
        private Dictionary<string, ListViewItem> listViewItems = new Dictionary<string, ListViewItem>();
        public MainForm()
        {
            InitializeComponent();

            GlobalData.fileInfoList = new List<FileInfo>();
            ConfigProcess.ReadJson();
            UIInit();

            UpdateProcessFromConfig();

            Thread processCheckThread = new Thread(CheckProcess);
            processCheckThread.Start();
        }


        private void UpdateProcessFromConfig()
        {
            foreach (var process in GlobalData.fileInfoList)
            {
                string[] listViewArr =
                    { process.NickName, process.ProcessID.ToString(), "준비", process.Description, "0" };
                ListViewItem item = new ListViewItem(listViewArr);
                
                ProcessListView.Items.Add(item); //ListView에 업데이트
                // item.Tag = process.ProcessID;
                listViewItems.Add(process.FileName,item);

                // ConfigProcess.WriteJson(GlobalData.fileInfoList); //Config에 현재 관리되는 Process정보 저장해주기.    
            }
        }

        private void Btn_AddProcess_Click(object sender, EventArgs e)
        {
            _processForm = new AddProcessForm();
            var result = _processForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                StartProcessFromAdd(GlobalData.fileInfo);
            }
        }

        private void ProcessListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var focusItem = ProcessListView.FocusedItem;
                if (focusItem != null && focusItem.Bounds.Contains(e.Location))
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        /// <summary>
        /// Process를 등록할때 자동 실행되는 로직
        /// </summary>
        /// <param name="fileInfo"></param>
        /// <returns></returns>
        private bool RunProcess(FileInfo fileInfo)
        {
            if (fileInfo.StartType)
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = fileInfo.FileName;
                startInfo.WorkingDirectory = fileInfo.Path;

                Process process = Process.Start(startInfo);
                if (process != null)
                {
                    int processId = process.Id;
                    fileInfo.ProcessID = processId;
                    fileInfo.LastRunTime = DateTime.Now;
                }
                else
                {
                    Debug.WriteLine("Process 시작 실패");
                    return false;
                }
            }

            string[] listViewArr =
                { fileInfo.NickName, fileInfo.ProcessID.ToString(), "준비", fileInfo.Description, "0" };
            ListViewItem item = new ListViewItem(listViewArr);
            ProcessListView.Items.Add(item); //ListView에 업데이트
            listViewItems.Add(fileInfo.FileName,item);
            GlobalData.fileInfoList.Add(fileInfo); //코드레벨의 ProcessList 업데이트
            ConfigProcess.WriteJson(GlobalData.fileInfoList); //Config에 현재 관리되는 Process정보 저장해주기.
            return true;
        }


        /// <summary>
        /// 현재 프로세스가 동작중 인지 확인하는 메소드
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private bool CheckSameProcess(string fileName)
        {
            string strWMIQry = "Select * From Win32_Process";

            ManagementObjectSearcher oWMI = new ManagementObjectSearcher(strWMIQry);
            foreach (ManagementObject oItem in oWMI.Get())
            {
                Debug.WriteLine(oItem.GetPropertyValue("Name").ToString());
                if (oItem.GetPropertyValue("Name").ToString() == fileName)
                {
                    Debug.WriteLine("중복 process 동작 중...(1)");
                    return true;
                }

                // for (int j = 1; j < ProcessListView.Items.Count; j++)
                // {
                //     if (ProcessListView.Items[j].SubItems[0].Text == fileName)
                //     {
                //         Debug.WriteLine("중복 process 동작 중...(2)");
                //         return true;
                //     }
                // }
            }

            return false;
        }

        private bool CheckRunProcessForFileInfo(ManagementObjectSearcher oWMI, int processID)
        {
            if (processID == 0)
            {
                return false;
            }

            foreach (ManagementObject oItem in oWMI.Get())
            {
                if (Convert.ToInt32(oItem.GetPropertyValue("ProcessID")) == processID)
                {
                    return true;
                }
            }

            return false;
        }

        private void CheckProcess()
        {
            while (true)
            {
                string strWMIQry = "Select * From Win32_Process";
                ManagementObjectSearcher oWMI = new ManagementObjectSearcher(strWMIQry);

                for (int i = GlobalData.fileInfoList.Count - 1; i >= 0; i--)
                {
                    GlobalData.fileInfoList[i].Status =
                        CheckRunProcessForFileInfo(oWMI, GlobalData.fileInfoList[i].ProcessID);
                    if (listViewItems.ContainsKey(GlobalData.fileInfoList[i].FileName))
                    {
                        this.Invoke(new MethodInvoker(() =>
                        {
                            ListViewItem item = listViewItems[GlobalData.fileInfoList[i].FileName];
                            
                                item.SubItems[0].Text = GlobalData.fileInfoList[i].NickName;
                                item.SubItems[2].Text =
                                    GlobalData.fileInfoList[i].Status ? "실행 중" : "중지";
                                item.SubItems[3].Text = GlobalData.fileInfoList[i].Description;
                                item.SubItems[4].Text =
                                    GlobalData.fileInfoList[i].LastRunTime.ToString();
                            
                        }));
                    }
                    
                    //재시작 로직 여기에
                    //조건 : IsAutoRestart가 설정되어있고 현재 process가 동작하지 않는 경우
                    if (i < GlobalData.fileInfoList.Count())
                    {
                        if (GlobalData.fileInfoList[i].IsAutoReStart && !GlobalData.fileInfoList[i].Status)
                        {
                            // StartProcess(GlobalData.fileInfoList[i]);
                            StartProcess(GlobalData.fileInfoList[i]);
                        }
                    }


                    //  for (int j = ProcessListView.Items.Count - 1; j >= 1; j--) //TODO ListView 항목을 HashTable로 처리하면 빠를듯?
                    //  {
                    //      this.Invoke(new MethodInvoker(() =>
                    //      {
                    //          if (i < GlobalData.fileInfoList.Count())
                    //          {
                    //              if (ProcessListView.Items[j].SubItems[0].Text == GlobalData.fileInfoList[i].FileName)
                    //              {
                    //                  ProcessListView.Items[j].SubItems[2].Text =
                    //                      GlobalData.fileInfoList[i].Status ? "실행 중" : "중지";
                    //                  ProcessListView.Items[j].SubItems[3].Text = GlobalData.fileInfoList[i].Description;
                    //                  ProcessListView.Items[j].SubItems[4].Text =
                    //                      GlobalData.fileInfoList[i].LastRunTime.ToString();
                    //              }
                    //          }
                    //      }));
                    //  }
                    // //
                    // // 재시작 로직 여기에
                    // // 조건 : IsAutoRestart가 설정되어있고 현재 process가 동작하지 않는 경우
                    //  if (i < GlobalData.fileInfoList.Count())
                    //  {
                    //      if (GlobalData.fileInfoList[i].IsAutoReStart && !GlobalData.fileInfoList[i].Status)
                    //      {
                    //          // StartProcess(GlobalData.fileInfoList[i]);
                    //          StartProcess(GlobalData.fileInfoList[i]);
                    //      }
                    //  }
                }
                Thread.Sleep(1000);
            }
        }

        private void DeleteFileInfo(int idx)
        {
            for (int i = 0; i < GlobalData.fileInfoList.Count; i++)
            {
                if (GlobalData.fileInfoList[i].FileName == ProcessListView.Items[idx].SubItems[0].Text)
                {
                    GlobalData.fileInfoList.RemoveAt(i);
                    break;
                }
            }

            ProcessListView.Items[idx].Remove(); //ListView에서 삭제
            ConfigProcess.WriteJson(GlobalData.fileInfoList); //Config 업데이트
        }


        private void StartProcessFromAdd(FileInfo fileInfo)
        {
            var r = CheckSameProcess(fileInfo.FileName);
            if (r) //중복이 있는 경우
                MessageBox.Show("동일한 Process가 이미 등록 되어있습니다.", "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            else
                RunProcess(fileInfo);
        }


        /// <summary>
        /// tooltip으로 실행 할때 동작하는 로직
        /// </summary>
        /// <param name="fileFullName"></param>
        private void StartProcess(FileInfo fileInfo)
        {
            if (!fileInfo.Status)
            {
                try
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = fileInfo.FileName;
                    startInfo.WorkingDirectory = fileInfo.Path;

                    Process process = Process.Start(startInfo);
                    if (process != null)
                    {
                        var idx = GlobalData.fileInfoList.FindIndex(v => v.FileFullName == fileInfo.FileFullName);
                        GlobalData.fileInfoList[idx].ProcessID = process.Id; //실행되는 process의 id 업데이트
                        GlobalData.fileInfoList[idx].LastRunTime = DateTime.Now; //실행 시키는 시간 업데이트

                        //ListView에 업데이트.
                        this.Invoke(new MethodInvoker(() =>
                        {
                            ProcessListView.Items[idx + 1].SubItems[1].Text = process.Id.ToString();
                        }));

                        ConfigProcess.WriteJson(GlobalData.fileInfoList); //Config에 현재 관리되는 Process정보 저장해주기.
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("??");
                }
            }
        }


        private void StopProcess(int processID)
        {
            try
            {
                Process process = Process.GetProcessById(processID);
                process.Kill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Process Kill 실패");
            }
        }


        /// <summary>
        /// Tooltip 에서 삭제 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolTip_delete(object sender, EventArgs e)
        {
            if (ProcessListView.SelectedItems.Count > 0)
            {
                var r = CheckSameProcess(ProcessListView.SelectedItems[0].SubItems[0].Text);
                if (r)
                {
                    if (MessageBox.Show("현재 Process가 동작 중입니다. 프로세스를 종료 하시겠습니까?", "Warning", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var _r = ProcessListView.SelectedItems[0];
                        var idx = ProcessListView.Items.IndexOf(_r);
                        if (idx >= 0)
                        {
                            StopProcess(Convert.ToInt32(ProcessListView.Items[idx].SubItems[1].Text));
                        }

                        DeleteFileInfo(ProcessListView.Items.IndexOf(ProcessListView.SelectedItems[0]));
                    }
                }
                else
                {
                    DeleteFileInfo(ProcessListView.Items.IndexOf(ProcessListView.SelectedItems[0]));
                }
            } //ListView에서 삭제
        }

        /// <summary>
        /// tooltip 에서 정지 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolTip_ProcessStop(object sender, EventArgs e)
        {
            if (ProcessListView.SelectedItems.Count > 0)
            {
                var r = ProcessListView.SelectedItems[0];
                var idx = ProcessListView.Items.IndexOf(r);
                if (idx >= 0)
                {
                    StopProcess(Convert.ToInt32(ProcessListView.Items[idx].SubItems[1].Text));
                }
            } //ListView에서 삭제
        }

        /// <summary>
        /// tooltip 에서 실행 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolTip_StartProcess(object sender, EventArgs e)
        {
            var r = ProcessListView.SelectedItems[0];
            var idx = ProcessListView.Items.IndexOf(r);
            var fileInfoItem =
                GlobalData.fileInfoList.Find(v => v.NickName == ProcessListView.Items[idx].SubItems[0].Text);

            if (idx >= 0)
            {
                StartProcess(fileInfoItem);
            }
        }

        /// <summary>
        /// tooltip 에서 설정 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void tooltip_preference_Click(object sender, EventArgs e)
        {
            var r = ProcessListView.SelectedItems[0];
            var idx = ProcessListView.Items.IndexOf(r);
            var fileInfoItem =
                GlobalData.fileInfoList.Find(v => v.FileName == ProcessListView.Items[idx].SubItems[0].Text);

            _processForm = new AddProcessForm(fileInfoItem);
            var result = _processForm.ShowDialog();
        }


        /// <summary>
        /// ListView Double Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void ProcessListView_DoubleClick(object sender, EventArgs e)
        {
            if (ProcessListView.SelectedItems.Count == 1)
            {
                var r = ProcessListView.SelectedItems[0];
                var idx = ProcessListView.Items.IndexOf(r);
                var fileInfoItem =
                    GlobalData.fileInfoList.Find(v => v.FileName == ProcessListView.Items[idx].SubItems[0].Text);

                _processForm = new AddProcessForm(fileInfoItem);
                var result = _processForm.ShowDialog();
            }
        }
    }
}