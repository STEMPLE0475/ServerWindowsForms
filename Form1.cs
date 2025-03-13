using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ServerWindowsForms
{
    public partial class Form1 : Form
    {
        private UdpClient udpServer; // UDP ����
        private bool isRunning = false;
        private int port; // default port : 9000
        const int DEFAULT_PORT = 9000;

        public Form1()
        {
            InitializeComponent();
            portText.PlaceholderText = DEFAULT_PORT.ToString();
        }

        private async void btnStartServer_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                StartServer();
                Task.Run(() => ReceiveUdpMessages()); // UDP ���� ����
            }
        }

        private void StartServer()
        {
            SetPort();
            udpServer = new UdpClient(port); // UDP ���ε�
            isRunning = true;

            lblStatus.Text = "���� �۵� ��...";
            btnStartServer.Enabled = false;
            btnStopServer.Enabled = true;
        }

        private void SetPort()
        {
            if (!string.IsNullOrWhiteSpace(portText.Text))
            {
                this.port = int.Parse(portText.Text);
            }
            else
            {
                port = DEFAULT_PORT;
            }
            portText.Enabled = false;
        }
        private void portText_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ���ڿ� �齺���̽��� ���
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // �Է��� ���
            }
        }

        private async void ReceiveUdpMessages()
        {
            while (isRunning)
            {
                try
                {
                    UdpReceiveResult result = await udpServer.ReceiveAsync();
                    string receivedMessage = Encoding.UTF8.GetString(result.Buffer);

                    SafeInvoke(() => console.Items.Add($"{receivedMessage}"));
                }
                catch (Exception ex)
                {
                    SafeInvoke(() => console.Items.Add($"����: {ex.Message}"));
                    break;
                }
            }
        }

        private void btnStopServer_Click(object sender, EventArgs e)
        {
            StopServer();
        }

        private void StopServer()
        {
            isRunning = false;
            udpServer?.Close(); // ���� ����

            lblStatus.Text = "���� ������";
            console.Items.Clear();
            btnStartServer.Enabled = true;
            btnStopServer.Enabled = false;
            portText.Enabled = true;
            //����ġ ���� ���� ����ô�?
        }

        private void SafeInvoke(Action action)
        {
            if (IsHandleCreated)
            {
                Invoke(new MethodInvoker(action));
            }
        }


    }
}
