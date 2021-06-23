using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinQuestion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Мы и не сомневались!");
        }

        private void NoButton_MouseMove(object sender, MouseEventArgs e)
        {
            NoButton.Top -= e.Y;
            NoButton.Left += e.X;
            if (NoButton.Top < -10 || NoButton.Top > 100)
                NoButton.Top = 60;
            if (NoButton.Left < -80 || NoButton.Left > 250)
                NoButton.Left = 120;
        }
    }
}
