using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chkBoxAdvanced_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxAdvanced.Checked == true)
            {
                Label lbl = new Label();
                lbl.Location = new System.Drawing.Point(16, 96);
                lbl.Size = new System.Drawing.Size(32, 23);
                lbl.Name = "labelll";
                lbl.TabIndex = 2;
                lbl.Text = "PIN2";
                grpBoxInput.Controls.Add(lbl);
                TextBox txt = new TextBox();
                txt.Location = new System.Drawing.Point(96, 96);
                txt.Size = new System.Drawing.Size(184, 20);
                txt.Name = "textboxx";
                txt.TabIndex = 1;
                txt.Text = "";
                grpBoxInput.Controls.Add(txt);
                txt.KeyPress += new KeyPressEventHandler(this.textBoxName_KeyPress);

            }
            else 
            {
                int lcv;
                lcv = grpBoxInput.Controls.Count;// определяется количество элементов
                while (lcv > 4)
                {
                    grpBoxInput.Controls.RemoveAt(lcv - 1);
                    lcv -= 1;
                }

            }
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле Name не может содежать цифры");
                errorProvider1.SetError(textBoxName, "Must be letter");
            }
        }

        private void textBoxPin_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxPin.Text == "")
            {
                e.Cancel = false;
            }
            else
            {
                try
                {
                    double.Parse(textBoxPin.Text);
                    e.Cancel = false;
                }
                catch
                {
                    e.Cancel = true;
                    MessageBox.Show("Поле PIN не может содержать буквы");
                }
            }

            //private void textBoxPin_KeyPress(object sender, KeyPressEventArgs e)
            //{
            //     if (!char.IsDigit(e.KeyChar))
            //    {
            //        e.Handled = true;
            //        MessageBox.Show("Поле PIN может содержать только цифры");
            //    }
            //}
        }
    }
}
