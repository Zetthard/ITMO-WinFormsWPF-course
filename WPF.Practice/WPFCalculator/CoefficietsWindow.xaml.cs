using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFCalculator
{
    public partial class CoefficietsWindow : Window
    {
        public CoefficietsWindow()
        {
            InitializeComponent();
        }

        private void ButtonOk_Click(object sender, RoutedEventArgs e)
        {
            MainWindow wnd1 = Owner as MainWindow;
            int a = 0;
            int b = 0;
            int c = 0;
            try
            {
                a = int.Parse(TextBoxA.Text);
                b = int.Parse(TextBoxB.Text);
                c = int.Parse(TextBoxC.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            double answer1 = CalcEngine.QuadForm(a, b, c, true);
            double answer2 = CalcEngine.QuadForm(a, b, c, false);
            wnd1.Display.Text = answer1.ToString("G3") + "  " + answer2.ToString("G3");

            // Альтернативный способ вывода корней уравнения.
            //WindowEqAnswer wnd2 = new WindowEqAnswer();
            //wnd2.TextBlockRootP.Text = "The positive root is  " + answer1.ToString("G5");
            //wnd2.TextBlockRootN.Text = "The negative root is  " + answer2.ToString("G5");
            //wnd2.Show();
            Close();
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
