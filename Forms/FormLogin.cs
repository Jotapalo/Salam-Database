using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Salam_Database.Services;

namespace Salam_Database.Forms
{
    public partial class FormLogin : Form
    {

        FormSingup formSingup;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            int res = LoginService.Login(textBoxUser.Text, textBoxPassword.Text);

            if (res > 0)
            {
                Console.WriteLine("Login successful. User ID: " + res);
                FormMainView formMainView = new FormMainView();
                formMainView.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }

        }

        private void buttonOpenSingupForm_Click(object sender, EventArgs e)
        {
            formSingup = new FormSingup();
            formSingup.ShowDialog();
        }


        private void FormLogin_Shown(object sender, EventArgs e)
        {
            // DEBUG
            LoginService.Login("JP", "123");
            FormMainView formMainView = new FormMainView();
            formMainView.Show();
            Hide();
            // FIN DEBUG
        }
    }
}
