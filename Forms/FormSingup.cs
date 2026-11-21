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
    public partial class FormSingup : Form
    {
        public FormSingup()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            // <sumary>
            // This method is responsible for handling the user registration process.
            // </sumary>

            int res = LoginService.RegisterUser(textBoxName.Text, textBoxUser.Text, textBoxPassword.Text);


            if (res > 0 ) {
                MessageBox.Show("User registered successfully.");
            }
            else
            {
                MessageBox.Show("User registration failed.");
            }
        }
    }
}
