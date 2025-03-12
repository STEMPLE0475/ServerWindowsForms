using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerWindowsForms
{

    public partial class Form1 : Form
    {
        private TcpListener server;
        private List<TcpClient> clients = new List<TcpClient>(); // ����� Ŭ���̾�Ʈ ����Ʈ
        private bool isRunning = false;
        //private DateTime serverTime;

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnStartServer_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                StartServer();
                await AcceptClients();
            }
        }

        private void StartServer()
        {
            const int port = 5000;
            server = new TcpListener(IPAddress.Any, port);
            server.Start();
            isRunning = true;
            lblStatus.Text = "���� ���� ��...";
            btnStartServer.Enabled = false;
            btnStopServer.Enabled = true;
        }

        private async Task AcceptClients()
        {
            while (isRunning)
            {
                TcpClient client = await server.AcceptTcpClientAsync();
                clients.Add(client);
                UpdateClientList();

                Task.Run(() => HandleClient(client));
            }
        }

        private async Task HandleClient(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];

            while (isRunning)
            {
                try
                {
                    int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                    if (bytesRead == 0) break;

                    string receivedMessage = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    Invoke((MethodInvoker)(() => lstClients.Items.Add($"����: {receivedMessage}")));
                }
                catch
                {
                    break;
                }
            }

            clients.Remove(client);
            client.Close();
            UpdateClientList();
        }

        private void UpdateClientList()
        {
            Invoke((MethodInvoker)(() =>
            {
                lstClients.Items.Clear();
                foreach (var client in clients)
                {
                    IPEndPoint endPoint = (IPEndPoint)client.Client.RemoteEndPoint;
                    lstClients.Items.Add($"{endPoint.Address}:{endPoint.Port}");
                }
            }));
        }


        private void btnStopServer_Click(object sender, EventArgs e)
        {
            StopServer();
        }

        private void StopServer()
        {
            isRunning = false;
            server.Stop();

            foreach (var client in clients)
            {
                client.Close();
            }
            clients.Clear();

            lblStatus.Text = "���� ������";
            lstClients.Items.Clear();
            btnStartServer.Enabled = true;
            btnStopServer.Enabled = false;
        }

        /*private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopServer();
        }*/

        private void GetServerTime(TcpClient client)
        {
            string response = $"���� �ð�: {DateTime.Now}";
            byte[] responseData = Encoding.UTF8.GetBytes(response);
            client.GetStream().Write(responseData, 0, responseData.Length); // ������ �۽�
        }
    }
}
