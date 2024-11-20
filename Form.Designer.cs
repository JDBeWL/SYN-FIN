namespace SYN_FIN
{
    partial class Form
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.endIPAddr = new System.Windows.Forms.TextBox();
            this.startIPAddr = new System.Windows.Forms.TextBox();
            this.lastIPADDR = new System.Windows.Forms.Label();
            this.firstIPADDR = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tip1 = new System.Windows.Forms.Label();
            this.SpecificPorts = new System.Windows.Forms.TextBox();
            this.partPortRadio = new System.Windows.Forms.RadioButton();
            this.allPortRadio = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.delayTime = new System.Windows.Forms.TextBox();
            this.timeForDelay = new System.Windows.Forms.Label();
            this.threads = new System.Windows.Forms.TextBox();
            this.setThread = new System.Windows.Forms.Label();
            this.scanIP = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusLabel = new System.Windows.Forms.Label();
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IPAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.endIPAddr);
            this.groupBox1.Controls.Add(this.startIPAddr);
            this.groupBox1.Controls.Add(this.lastIPADDR);
            this.groupBox1.Controls.Add(this.firstIPADDR);
            this.groupBox1.Location = new System.Drawing.Point(24, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(186, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IP设置";
            // 
            // endIPAddr
            // 
            this.endIPAddr.Location = new System.Drawing.Point(73, 50);
            this.endIPAddr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.endIPAddr.Name = "endIPAddr";
            this.endIPAddr.Size = new System.Drawing.Size(101, 21);
            this.endIPAddr.TabIndex = 7;
            // 
            // startIPAddr
            // 
            this.startIPAddr.Location = new System.Drawing.Point(73, 24);
            this.startIPAddr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startIPAddr.Name = "startIPAddr";
            this.startIPAddr.Size = new System.Drawing.Size(101, 21);
            this.startIPAddr.TabIndex = 6;
            // 
            // lastIPADDR
            // 
            this.lastIPADDR.AutoSize = true;
            this.lastIPADDR.Location = new System.Drawing.Point(6, 55);
            this.lastIPADDR.Name = "lastIPADDR";
            this.lastIPADDR.Size = new System.Drawing.Size(65, 12);
            this.lastIPADDR.TabIndex = 5;
            this.lastIPADDR.Text = "结束地址：";
            // 
            // firstIPADDR
            // 
            this.firstIPADDR.AutoSize = true;
            this.firstIPADDR.Location = new System.Drawing.Point(6, 26);
            this.firstIPADDR.Name = "firstIPADDR";
            this.firstIPADDR.Size = new System.Drawing.Size(65, 12);
            this.firstIPADDR.TabIndex = 4;
            this.firstIPADDR.Text = "起始地址：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tip1);
            this.groupBox2.Controls.Add(this.SpecificPorts);
            this.groupBox2.Controls.Add(this.partPortRadio);
            this.groupBox2.Controls.Add(this.allPortRadio);
            this.groupBox2.Location = new System.Drawing.Point(223, 22);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(219, 91);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "端口设置";
            // 
            // tip1
            // 
            this.tip1.AutoSize = true;
            this.tip1.Location = new System.Drawing.Point(5, 71);
            this.tip1.Name = "tip1";
            this.tip1.Size = new System.Drawing.Size(203, 12);
            this.tip1.TabIndex = 9;
            this.tip1.Text = "有多个端口用英文逗号隔开(如21,80)";
            // 
            // SpecificPorts
            // 
            this.SpecificPorts.Location = new System.Drawing.Point(89, 48);
            this.SpecificPorts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SpecificPorts.Name = "SpecificPorts";
            this.SpecificPorts.Size = new System.Drawing.Size(109, 21);
            this.SpecificPorts.TabIndex = 8;
            // 
            // partPortRadio
            // 
            this.partPortRadio.AutoSize = true;
            this.partPortRadio.Location = new System.Drawing.Point(13, 50);
            this.partPortRadio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.partPortRadio.Name = "partPortRadio";
            this.partPortRadio.Size = new System.Drawing.Size(83, 16);
            this.partPortRadio.TabIndex = 1;
            this.partPortRadio.TabStop = true;
            this.partPortRadio.Text = "部分端口：";
            this.partPortRadio.UseVisualStyleBackColor = true;
            this.partPortRadio.CheckedChanged += new System.EventHandler(this.partPortRadio_CheckedChanged);
            // 
            // allPortRadio
            // 
            this.allPortRadio.AutoSize = true;
            this.allPortRadio.Location = new System.Drawing.Point(13, 22);
            this.allPortRadio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.allPortRadio.Name = "allPortRadio";
            this.allPortRadio.Size = new System.Drawing.Size(71, 16);
            this.allPortRadio.TabIndex = 0;
            this.allPortRadio.TabStop = true;
            this.allPortRadio.Text = "所有端口";
            this.allPortRadio.UseVisualStyleBackColor = true;
            this.allPortRadio.CheckedChanged += new System.EventHandler(this.allPortRadio_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.delayTime);
            this.groupBox3.Controls.Add(this.timeForDelay);
            this.groupBox3.Controls.Add(this.threads);
            this.groupBox3.Controls.Add(this.setThread);
            this.groupBox3.Location = new System.Drawing.Point(24, 129);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(322, 46);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // delayTime
            // 
            this.delayTime.Location = new System.Drawing.Point(242, 18);
            this.delayTime.Name = "delayTime";
            this.delayTime.Size = new System.Drawing.Size(66, 21);
            this.delayTime.TabIndex = 3;
            // 
            // timeForDelay
            // 
            this.timeForDelay.AutoSize = true;
            this.timeForDelay.Location = new System.Drawing.Point(159, 21);
            this.timeForDelay.Name = "timeForDelay";
            this.timeForDelay.Size = new System.Drawing.Size(77, 12);
            this.timeForDelay.TabIndex = 2;
            this.timeForDelay.Text = "耗时（ms）：";
            // 
            // threads
            // 
            this.threads.Location = new System.Drawing.Point(72, 18);
            this.threads.Name = "threads";
            this.threads.Size = new System.Drawing.Size(65, 21);
            this.threads.TabIndex = 1;
            this.threads.Text = "10";
            // 
            // setThread
            // 
            this.setThread.AutoSize = true;
            this.setThread.Location = new System.Drawing.Point(6, 21);
            this.setThread.Name = "setThread";
            this.setThread.Size = new System.Drawing.Size(65, 12);
            this.setThread.TabIndex = 0;
            this.setThread.Text = "线程设置：";
            // 
            // scanIP
            // 
            this.scanIP.Location = new System.Drawing.Point(350, 139);
            this.scanIP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.scanIP.Name = "scanIP";
            this.scanIP.Size = new System.Drawing.Size(92, 36);
            this.scanIP.TabIndex = 2;
            this.scanIP.Text = "开始扫描";
            this.scanIP.UseVisualStyleBackColor = true;
            this.scanIP.Click += new System.EventHandler(this.scanIP_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SerialNumber,
            this.IPAddress,
            this.Port,
            this.Status});
            this.dataGridView1.Location = new System.Drawing.Point(24, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(418, 132);
            this.dataGridView1.TabIndex = 3;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(25, 183);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(53, 12);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "等待操作";
            // 
            // SerialNumber
            // 
            this.SerialNumber.HeaderText = "序号";
            this.SerialNumber.MinimumWidth = 6;
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.Width = 60;
            // 
            // IPAddress
            // 
            this.IPAddress.HeaderText = "IP地址";
            this.IPAddress.MinimumWidth = 6;
            this.IPAddress.Name = "IPAddress";
            this.IPAddress.Width = 150;
            // 
            // Port
            // 
            this.Port.HeaderText = "端口号";
            this.Port.MinimumWidth = 6;
            this.Port.Name = "Port";
            this.Port.Width = 70;
            // 
            // Status
            // 
            this.Status.HeaderText = "状态";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 90;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 346);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.scanIP);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form";
            this.ShowIcon = false;
            this.Text = "基于SYN-FIN的高级端口扫描程序";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button scanIP;
        private System.Windows.Forms.Label lastIPADDR;
        private System.Windows.Forms.Label firstIPADDR;
        private System.Windows.Forms.RadioButton partPortRadio;
        private System.Windows.Forms.RadioButton allPortRadio;
        private System.Windows.Forms.TextBox endIPAddr;
        private System.Windows.Forms.TextBox startIPAddr;
        private System.Windows.Forms.TextBox SpecificPorts;
        private System.Windows.Forms.Label setThread;
        private System.Windows.Forms.TextBox threads;
        private System.Windows.Forms.TextBox delayTime;
        private System.Windows.Forms.Label timeForDelay;
        private System.Windows.Forms.Label tip1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn IPAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Port;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}

