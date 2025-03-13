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
            console = new ListBox();
            btnStartServer = new Button();
            btnStopServer = new Button();
            lblStatus = new Label();
            groupBox2 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            portText = new TextBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            lstClients = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(console);
            groupBox1.Location = new Point(15, 16);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(423, 568);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Entered Clients";
            // 
            // console
            // 
            console.Dock = DockStyle.Fill;
            console.FormattingEnabled = true;
            console.Location = new Point(4, 24);
            console.Margin = new Padding(4);
            console.Name = "console";
            console.Size = new Size(415, 540);
            console.TabIndex = 4;
            // 
            // btnStartServer
            // 
            btnStartServer.Location = new Point(4, 24);
            btnStartServer.Margin = new Padding(4);
            btnStartServer.Name = "btnStartServer";
            btnStartServer.Size = new Size(141, 31);
            btnStartServer.TabIndex = 1;
            btnStartServer.Text = "서버 활성화";
            btnStartServer.UseVisualStyleBackColor = true;
            btnStartServer.Click += btnStartServer_Click;
            // 
            // btnStopServer
            // 
            btnStopServer.Enabled = false;
            btnStopServer.Location = new Point(4, 63);
            btnStopServer.Margin = new Padding(4);
            btnStopServer.Name = "btnStopServer";
            btnStopServer.Size = new Size(141, 31);
            btnStopServer.TabIndex = 2;
            btnStopServer.Text = "서버 비활성화";
            btnStopServer.UseVisualStyleBackColor = true;
            btnStopServer.Click += btnStopServer_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(4, 0);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(96, 20);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Server Status";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(flowLayoutPanel1);
            groupBox2.Location = new Point(462, 41);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(194, 148);
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
            flowLayoutPanel1.Location = new Point(4, 24);
            flowLayoutPanel1.Margin = new Padding(4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(186, 120);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // portText
            // 
            portText.Dock = DockStyle.Fill;
            portText.Location = new Point(3, 23);
            portText.Name = "portText";
            portText.PlaceholderText = "9000";
            portText.Size = new Size(153, 27);
            portText.TabIndex = 5;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(portText);
            groupBox3.Location = new Point(470, 448);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(159, 55);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "서버 포트";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lstClients);
            groupBox4.Location = new Point(470, 317);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(250, 125);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "접속 클라이언트";
            // 
            // lstClients
            // 
            lstClients.Dock = DockStyle.Fill;
            lstClients.FormattingEnabled = true;
            lstClients.Location = new Point(3, 23);
            lstClients.Name = "lstClients";
            lstClients.Size = new Size(244, 99);
            lstClients.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 600);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnStartServer;
        private Button btnStopServer;
        private Label lblStatus;
        private ListBox console;
        private GroupBox groupBox2;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox portText;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private ListBox lstClients;
    }
}
