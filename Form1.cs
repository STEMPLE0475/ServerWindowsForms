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
        private UdpClient udpServer; // UDP 서버
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
                Task.Run(() => ReceiveUdpMessages()); // UDP 수신 시작
            }
        }

        private void StartServer()
        {
            SetPort();
            udpServer = new UdpClient(port); // UDP 바인딩
            isRunning = true;

            lblStatus.Text = "서버 작동 중...";
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
            // 숫자와 백스페이스만 허용
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // 입력을 취소
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
                    SafeInvoke(() => console.Items.Add($"오류: {ex.Message}"));
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
            udpServer?.Close(); // 소켓 종료

            lblStatus.Text = "서버 중지됨";
            console.Items.Clear();
            btnStartServer.Enabled = true;
            btnStopServer.Enabled = false;
            portText.Enabled = true;
            //예기치 못한 서버 종료시는?
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
