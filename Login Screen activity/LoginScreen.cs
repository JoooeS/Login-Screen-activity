using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Screen_activity
{
    public partial class LoginScreen : UserControl
    {
        public static string userName;
        public static string userPassword;

        

        public LoginScreen()
        {
            InitializeComponent();

             

            //nameTextBox.Location = new Point(((LS.Width / 2) - (nameTextBox.Width / 2)), nameTextBox.Location.Y);
            //passwordTextBox.Location = new Point(((LS.Width / 2) - (passwordTextBox.Width / 2)), passwordTextBox.Location.Y);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            userName = Convert.ToString(nameTextBox.Text);
            userPassword = Convert.ToString(passwordTextBox.Text);

            if (Form1.correctName == userName && Form1.correctPassword == userPassword)
            {
                Form ls = this.FindForm();
                ls.Controls.Remove(this);
                

                Second_Screen ss = new Second_Screen();
                ls.Controls.Add(ss);
            }
            else
            {
                errorLabel.Text = "Incorrect username and/or password.";
            }
        }
    }
}
