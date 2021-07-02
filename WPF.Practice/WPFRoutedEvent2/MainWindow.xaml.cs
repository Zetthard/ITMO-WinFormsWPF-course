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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RoutedEvent2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            FrameworkElement FeSource = e.Source as FrameworkElement;
            double a = Double.Parse(Textbox1.Text);

            switch (FeSource.Name)
            {
                case "ButtonAdd":
                    a += a;
                    break;

                case "ButtonMult":
                    a *= a;
                    break;

                case "ButtonSqrt":
                    a = Math.Sqrt(a);
                    break;
            }
            e.Handled = true;

            Textbox1.Text = String.Format("{0:#.##}", a);
        }
    }
}
