using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAsyncMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PrintDelegateFunc = new PrintLabel(PrintFunc);
        }

        private delegate int AsyncSumm(int a, int b);
        delegate void PrintLabel(string str);
        private PrintLabel PrintDelegateFunc;

        private int Summ(int a, int b)
        {
            System.Threading.Thread.Sleep(9000);
            return a + b;
        }

        void PrintFunc(string str)
        {
            labelResult.Text = str;
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                // Преобразование типов данных.
                a = Int32.Parse(textBox1.Text);
                b = Int32.Parse(textBox2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("При выполнении преобразования типов возникла ошибка");
                textBox1.Text = textBox2.Text = "";
                return;
            }
            AsyncSumm summdelegate = new AsyncSumm(Summ);
            AsyncCallback callback = new AsyncCallback(CallbackMethod);
            summdelegate.BeginInvoke(a, b, callback, summdelegate);
        }

        private void CallbackMethod(IAsyncResult ar)
        {
            string str;
            AsyncSumm summdelegate = (AsyncSumm)ar.AsyncState;
            str = string.Format("Summ of A and B is: {0}", summdelegate.EndInvoke(ar));
            //MessageBox.Show(str, "Calculation result");
            labelResult.Invoke(PrintDelegateFunc, new object[] { str });
        }

        private void buttonWork_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Work in progress...", "Main thread task", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void buttonSubstract_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                // Преобразование типов данных.
                a = Int32.Parse(textBox1.Text);
                b = Int32.Parse(textBox2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("При выполнении преобразования типов возникла ошибка");
                textBox1.Text = textBox2.Text = "";
                return; 
            }

            int res = await Sub(a, b);
            labelResult.Text = "Diff of A and B is: " + res.ToString();
        }

        private async Task<int> Sub(int a, int b)
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(5000);
                return a - b;
            });
        }
    }
}
