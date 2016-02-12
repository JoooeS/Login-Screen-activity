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
    public partial class Second_Screen : UserControl
    {
        public Second_Screen()
        {
            InitializeComponent();

            nameLabel.Text = "Welcome " + Convert.ToString(Form1.correctName);
        }
    }
}
