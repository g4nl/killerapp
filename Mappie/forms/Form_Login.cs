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
    public partial class Form_Login : Form
    {
        public Form_Login()
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

        private void btn_login_Click(object sender, EventArgs e)
        {
            controllers.MainController.Login(tb_userName.Text, tb_password.Text);
        }
    }
}
