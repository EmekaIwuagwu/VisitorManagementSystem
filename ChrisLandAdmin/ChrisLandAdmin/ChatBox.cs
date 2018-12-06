using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace ChrisLandAdmin
{
    public partial class Form1 : Form
    {
        Socket sock;
        EndPoint epLocal, epRemote;
        byte[] buffer;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sock.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            pc1IP.Text = GetLocalIP();
            Pc2IP.Text = GetLocalIP();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            Message.KeyDown += new KeyEventHandler(MyKeyDownFunction); // Event to open new chat window on PC
        }

        //Message.KeyDown += new KeyEventHandler(MyKeyDownFunction);
        private void MyKeyDownFunction(object sender, KeyEventArgs e)
        {
            // Open new Chat window and show chat information
        }

        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                byte[] receivedData = new byte[1500];
                receivedData = (byte[])aResult.AsyncState;
                ASCIIEncoding asc = new ASCIIEncoding();
                string recievedMsg = asc.GetString(receivedData);
                listMessage.Items.Add("Friend:" + recievedMsg);

                buffer = new byte[1500];
                sock.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.BalloonTipText = "You have Recieved a New Message";
                notifyIcon1.BalloonTipTitle = "New Chat Message!";
                notifyIcon1.ShowBalloonTip(1000);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void send_btn_Click(object sender, EventArgs e)
        {

        }


        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }

        private void Message_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //this.WindowState = FormWindowState.Normal;
                ASCIIEncoding aec = new ASCIIEncoding();
                byte[] sendingMessage = new byte[1500];
                sendingMessage = aec.GetBytes(Message.Text);
                sock.Send(sendingMessage);
                listMessage.Items.Add("Me :" + Message.Text);
                Message.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void send_btn_Click_1(object sender, EventArgs e)
        {
            ASCIIEncoding aec = new ASCIIEncoding();
            byte[] sendingMessage = new byte[1500];
            sendingMessage = aec.GetBytes(Message.Text);
            sock.Send(sendingMessage);
            listMessage.Items.Add("Me :" + Message.Text);
            Message.Text = "";
        }

        private void listMessage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.ShowInTaskbar = true;
            this.Visible = true;

            WindowState = FormWindowState.Normal;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
                ShowInTaskbar = false;
        }

        private void Message_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //this.WindowState = FormWindowState.Normal;
                ASCIIEncoding aec = new ASCIIEncoding();
                byte[] sendingMessage = new byte[1500];
                sendingMessage = aec.GetBytes(Message.Text);
                sock.Send(sendingMessage);
                listMessage.Items.Add("Me :" + Message.Text);
                Message.Text = "";
            }
        }

        private void connect_btn_Click(object sender, EventArgs e)
        {
            epLocal = new IPEndPoint(IPAddress.Parse(pc1IP.Text), Convert.ToInt32(pc1Port.Text));
            sock.Bind(epLocal);

            epRemote = new IPEndPoint(IPAddress.Parse(Pc2IP.Text), Convert.ToInt32(Pc2Port.Text));
            sock.Connect(epRemote);

            buffer = new byte[1500];

            sock.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            connect_btn.Text = "&Connected!";
            connect_btn.Enabled = false;
            toolStripStatusLabel1.Text = "Chat Connected!";
        }
    }
}
