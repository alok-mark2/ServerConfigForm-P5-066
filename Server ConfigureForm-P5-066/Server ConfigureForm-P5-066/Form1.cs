using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using ServiceMtk_P1_066;

namespace Server_ConfigureForm_P5_066
{
    public partial class Form1 : Form
    {
        private ServiceHost Host;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Host = new ServiceHost(typeof(Matematika));

            label3.Text = "Server ON";
            label2.Text = "Klik OFF untuk Mematikan Server";
            Host.Open();
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            Host.Close();
            label2.Text = "Klik ON untuk Menjalankan Server";
            label3.Text = "Server OFF";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
