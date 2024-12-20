using System;
using System.Runtime.InteropServices;

namespace AgosWatchdog
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_AddProcess = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ProcessListView = new System.Windows.Forms.ListView();
            this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pidHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descriptHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastRuntimeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.정지ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tooltip_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.tooltip_preference = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(116, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "WatchDog";
            // 
            // Btn_AddProcess
            // 
            this.Btn_AddProcess.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.Btn_AddProcess, 2);
            this.Btn_AddProcess.Location = new System.Drawing.Point(3, 390);
            this.Btn_AddProcess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_AddProcess.Name = "Btn_AddProcess";
            this.Btn_AddProcess.Size = new System.Drawing.Size(170, 29);
            this.Btn_AddProcess.TabIndex = 1;
            this.Btn_AddProcess.Text = "관리 프로세스 등록";
            this.Btn_AddProcess.UseVisualStyleBackColor = true;
            this.Btn_AddProcess.Click += new System.EventHandler(this.Btn_AddProcess_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Btn_AddProcess, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ProcessListView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(818, 422);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ProcessListView
            // 
            this.ProcessListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameHeader,
            this.pidHeader,
            this.statusHeader,
            this.descriptHeader,
            this.lastRuntimeHeader});
            this.tableLayoutPanel1.SetColumnSpan(this.ProcessListView, 2);
            this.ProcessListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProcessListView.FullRowSelect = true;
            this.ProcessListView.HideSelection = false;
            this.ProcessListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.ProcessListView.Location = new System.Drawing.Point(3, 32);
            this.ProcessListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProcessListView.Name = "ProcessListView";
            this.ProcessListView.Size = new System.Drawing.Size(660, 354);
            this.ProcessListView.TabIndex = 3;
            this.ProcessListView.UseCompatibleStateImageBehavior = false;
            this.ProcessListView.View = System.Windows.Forms.View.Details;
            this.ProcessListView.DoubleClick += new System.EventHandler(this.ProcessListView_DoubleClick);
            this.ProcessListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProcessListView_MouseClick);
            // 
            // nameHeader
            // 
            this.nameHeader.Text = "이름";
            this.nameHeader.Width = 108;
            // 
            // pidHeader
            // 
            this.pidHeader.Text = "ProcessID";
            this.pidHeader.Width = 108;
            // 
            // statusHeader
            // 
            this.statusHeader.Text = "상태";
            this.statusHeader.Width = 170;
            // 
            // descriptHeader
            // 
            this.descriptHeader.Text = "설명";
            this.descriptHeader.Width = 220;
            // 
            // lastRuntimeHeader
            // 
            this.lastRuntimeHeader.Text = "마지막 실행 시간";
            this.lastRuntimeHeader.Width = 398;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.정지ToolStripMenuItem,
            this.tooltip_delete,
            this.tooltip_preference});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(99, 92);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.toolStripMenuItem1.Text = "실행";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolTip_StartProcess);
            // 
            // 정지ToolStripMenuItem
            // 
            this.정지ToolStripMenuItem.Name = "정지ToolStripMenuItem";
            this.정지ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.정지ToolStripMenuItem.Text = "정지";
            this.정지ToolStripMenuItem.Click += new System.EventHandler(this.toolTip_ProcessStop);
            // 
            // tooltip_delete
            // 
            this.tooltip_delete.Name = "tooltip_delete";
            this.tooltip_delete.Size = new System.Drawing.Size(98, 22);
            this.tooltip_delete.Text = "삭제";
            this.tooltip_delete.Click += new System.EventHandler(this.toolTip_delete);
            // 
            // tooltip_preference
            // 
            this.tooltip_preference.Name = "tooltip_preference";
            this.tooltip_preference.Size = new System.Drawing.Size(98, 22);
            this.tooltip_preference.Text = "설정";
            this.tooltip_preference.Click += new System.EventHandler(this.tooltip_preference_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(669, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(818, 422);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Agos WatchDog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ToolStripMenuItem tooltip_preference;

        #endregion
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Btn_AddProcess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView ProcessListView;
        private System.Windows.Forms.ColumnHeader nameHeader;
        private System.Windows.Forms.ColumnHeader statusHeader;
        private System.Windows.Forms.ColumnHeader descriptHeader;
        private System.Windows.Forms.ColumnHeader lastRuntimeHeader;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tooltip_delete;
        private System.Windows.Forms.ToolStripMenuItem 정지ToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader pidHeader;
        private System.Windows.Forms.Label label2;
    }
}

