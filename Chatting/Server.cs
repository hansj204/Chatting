using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Chatting
{
    public partial class Server : Form
    {
        Socket server;
     

        public Server()
        {
            InitializeComponent();
        }

        private void Server_Load(object sender, EventArgs e)
        {
           

        }

        private void Server_open_Click(object sender, EventArgs e)
        {
            try
            {
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress hostIP = IPAddress.Parse(server_ip.Text);
                int port = Convert.ToInt32(server_port.Text);

                IPEndPoint ep = new IPEndPoint(hostIP, port);
                server.Blocking = true;  
                server.Listen(1);
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void Server_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
