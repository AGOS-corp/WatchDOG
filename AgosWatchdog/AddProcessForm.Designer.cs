namespace AgosWatchdog
{
    partial class AddProcessForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.btn_load_process = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_description = new System.Windows.Forms.TextBox();
            this.tb_nickName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.CB_StartType = new System.Windows.Forms.CheckBox();
            this.CB_RestartPeriod = new System.Windows.Forms.CheckBox();
            this.tb_restart_period = new System.Windows.Forms.ComboBox();
            this.CB_AutoRestart = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(5, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(18, 16, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 432);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(496, 388);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "취소";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 388);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "확인";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(5, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(590, 381);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(582, 355);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "일반";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 508F));
            this.tableLayoutPanel1.Controls.Add(this.tb_path, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_load_process, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_description, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_nickName, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(576, 351);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tb_path
            // 
            this.tb_path.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_path.Font = new System.Drawing.Font("굴림", 12.25F);
            this.tb_path.Location = new System.Drawing.Point(73, 34);
            this.tb_path.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(502, 26);
            this.tb_path.TabIndex = 4;
            // 
            // btn_load_process
            // 
            this.btn_load_process.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_load_process.Location = new System.Drawing.Point(73, 130);
            this.btn_load_process.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_load_process.Name = "btn_load_process";
            this.btn_load_process.Size = new System.Drawing.Size(89, 28);
            this.btn_load_process.TabIndex = 0;
            this.btn_load_process.Text = "불러오기";
            this.btn_load_process.UseVisualStyleBackColor = true;
            this.btn_load_process.Click += new System.EventHandler(this.btn_load_process_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "위치";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "설명";
            // 
            // tb_description
            // 
            this.tb_description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_description.Location = new System.Drawing.Point(73, 66);
            this.tb_description.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_description.Multiline = true;
            this.tb_description.Name = "tb_description";
            this.tableLayoutPanel1.SetRowSpan(this.tb_description, 2);
            this.tb_description.Size = new System.Drawing.Size(502, 60);
            this.tb_description.TabIndex = 2;
            // 
            // tb_nickName
            // 
            this.tb_nickName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_nickName.Font = new System.Drawing.Font("굴림", 12.25F);
            this.tb_nickName.Location = new System.Drawing.Point(73, 2);
            this.tb_nickName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_nickName.Name = "tb_nickName";
            this.tb_nickName.Size = new System.Drawing.Size(502, 26);
            this.tb_nickName.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(582, 355);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "설정";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 186F));
            this.tableLayoutPanel2.Controls.Add(this.CB_StartType, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.CB_RestartPeriod, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tb_restart_period, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.CB_AutoRestart, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(576, 351);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // CB_StartType
            // 
            this.CB_StartType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CB_StartType.AutoSize = true;
            this.CB_StartType.Checked = true;
            this.CB_StartType.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_StartType.Location = new System.Drawing.Point(3, 12);
            this.CB_StartType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CB_StartType.Name = "CB_StartType";
            this.CB_StartType.Size = new System.Drawing.Size(172, 16);
            this.CB_StartType.TabIndex = 0;
            this.CB_StartType.Text = "프로세스 등록 후 바로 실행";
            this.CB_StartType.UseVisualStyleBackColor = true;
            // 
            // CB_RestartPeriod
            // 
            this.CB_RestartPeriod.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CB_RestartPeriod.AutoSize = true;
            this.CB_RestartPeriod.Location = new System.Drawing.Point(3, 52);
            this.CB_RestartPeriod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CB_RestartPeriod.Name = "CB_RestartPeriod";
            this.CB_RestartPeriod.Size = new System.Drawing.Size(196, 16);
            this.CB_RestartPeriod.TabIndex = 0;
            this.CB_RestartPeriod.Text = "설정 된 주기로 프로그램 재시작";
            this.CB_RestartPeriod.UseVisualStyleBackColor = true;
            // 
            // tb_restart_period
            // 
            this.tb_restart_period.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_restart_period.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tb_restart_period.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tb_restart_period.FormattingEnabled = true;
            this.tb_restart_period.Items.AddRange(new object[] {
            "1시간",
            "6시간",
            "1일",
            "3일",
            "7일",
            "30일",
            "60일",
            "120일"});
            this.tb_restart_period.Location = new System.Drawing.Point(257, 50);
            this.tb_restart_period.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_restart_period.Name = "tb_restart_period";
            this.tb_restart_period.Size = new System.Drawing.Size(125, 20);
            this.tb_restart_period.TabIndex = 1;
            // 
            // CB_AutoRestart
            // 
            this.CB_AutoRestart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CB_AutoRestart.AutoSize = true;
            this.CB_AutoRestart.Checked = true;
            this.CB_AutoRestart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_AutoRestart.Location = new System.Drawing.Point(3, 92);
            this.CB_AutoRestart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CB_AutoRestart.Name = "CB_AutoRestart";
            this.CB_AutoRestart.Size = new System.Drawing.Size(140, 16);
            this.CB_AutoRestart.TabIndex = 2;
            this.CB_AutoRestart.Text = "프로세스 자동 재시작";
            this.CB_AutoRestart.UseVisualStyleBackColor = true;
            // 
            // AddProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(602, 451);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddProcessForm";
            this.Text = "AddProcessForm";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.CheckBox CB_AutoRestart;

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_load_process;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_description;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_nickName;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.CheckBox CB_StartType;
        private System.Windows.Forms.CheckBox CB_RestartPeriod;
        private System.Windows.Forms.ComboBox tb_restart_period;
    }
}