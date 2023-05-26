using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp3
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username.Equals("admin") && password.Equals("123"))
            {
                // login success
                //MessageBox.Show("Login Success", "Thong bao", MessageBoxButtons.OK);

                //hide form login
                this.Hide();
                //show management form
                //create obj form
                Form form = new Managerment();
                form.ShowDialog();
            }
            else
            {
                // login fail
                MessageBox.Show("Login Failt", "Thong bao", MessageBoxButtons.OK);
                txtPassword.Text = "";
                txtUsername.Text = "";
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
