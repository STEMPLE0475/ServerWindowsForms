namespace ServerWindowsForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnStartServer = new Button();
            btnStopServer = new Button();
            lblStatus = new Label();
            lstClients = new ListBox();
            groupBox2 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstClients);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(329, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Entered Clients";
            // 
            // btnStartServer
            // 
            btnStartServer.Location = new Point(3, 18);
            btnStartServer.Name = "btnStartServer";
            btnStartServer.Size = new Size(110, 23);
            btnStartServer.TabIndex = 1;
            btnStartServer.Text = "서버 활성화";
            btnStartServer.UseVisualStyleBackColor = true;
            btnStartServer.Click += btnStartServer_Click;
            // 
            // btnStopServer
            // 
            btnStopServer.Enabled = false;
            btnStopServer.Location = new Point(3, 47);
            btnStopServer.Name = "btnStopServer";
            btnStopServer.Size = new Size(110, 23);
            btnStopServer.TabIndex = 2;
            btnStopServer.Text = "서버 비활성화";
            btnStopServer.UseVisualStyleBackColor = true;
            btnStopServer.Click += btnStopServer_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(3, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(77, 15);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Server Status";
            // 
            // lstClients
            // 
            lstClients.Dock = DockStyle.Fill;
            lstClients.FormattingEnabled = true;
            lstClients.ItemHeight = 15;
            lstClients.Location = new Point(3, 19);
            lstClients.Name = "lstClients";
            lstClients.Size = new Size(323, 404);
            lstClients.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(flowLayoutPanel1);
            groupBox2.Location = new Point(359, 31);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(151, 111);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "ServerManger";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lblStatus);
            flowLayoutPanel1.Controls.Add(btnStartServer);
            flowLayoutPanel1.Controls.Add(btnStopServer);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 19);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(145, 89);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnStartServer;
        private Button btnStopServer;
        private Label lblStatus;
        private ListBox lstClients;
        private GroupBox groupBox2;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
