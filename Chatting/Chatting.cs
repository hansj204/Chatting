using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chatting
{
    public partial class Chatting : Form
    {
        public Chatting()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Server_Click_1(object sender, EventArgs e)
        {
            Server server = new Server();
            server.Show();
        }

        private void Client_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
