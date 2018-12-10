using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mappie.forms
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
            pictureBox1.Controls.Add(pictureBox2);
            pictureBox1.Controls.Add(label1);
            pictureBox1.Controls.Add(label2);
            //pictureBox2.Location = new Point(0, 0);
            pictureBox2.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
private void btn_login_Click(object sender, EventArgs e)
        {
            controllers.MainController.Login(tb_userName.Text, tb_password.Text);
        }
    }  
}
