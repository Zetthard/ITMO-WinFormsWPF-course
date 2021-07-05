using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAsyncEratosfen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            int a;
            try
            {
                a = int.Parse(textBox1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Type conversion error");
                textBox1.Text = "";
                return;
            }

            string res = await Eratosfen(a);
            label1.Text = res;
        }

        private async Task<string> Eratosfen(int a)
        {
            return await Task.Run(() =>
            {
                return GoButt(a);
            });
        }

        public string GoButt(int maxValue)
        {
            StringBuilder resultText = new StringBuilder();
            if (int.TryParse(textBox1.Text, out maxValue))
            {
                for (int trial = 2; trial <= maxValue; trial++)
                {
                    bool isPrime = true;
                    for (int divisor = 2; divisor <= Math.Sqrt(trial); divisor++)
                    {
                        if (trial % divisor == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        resultText.AppendFormat("{0} ", trial);
                    }
                }
            }
            else
            {
                resultText.Append("Unable to parse maximum value.");
            }
            return resultText.ToString();
        }
    }
}
