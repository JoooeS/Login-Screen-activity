using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Screen_activity
{
    public partial class Form1 : Form
    {
        public static string correctName = "geoff";
        public static string correctPassword = "123abc";



        public Form1()
        {
            InitializeComponent();

            LoginScreen LS = new LoginScreen();

            this.Controls.Add(LS);
        }
    }
}
