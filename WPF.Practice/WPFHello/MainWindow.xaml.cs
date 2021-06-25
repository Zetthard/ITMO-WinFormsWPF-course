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

namespace WPFHello
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mainlabel.Content = "Good morning!";

            SetButton.IsEnabled = false;
            RetButton.IsEnabled = false;
            Top = 25;
            Left = 25;
        }

        bool isDataDirety = false;

        public SecondWindow MyWin { get; set; }

        private void SetButton_Click(object sender, RoutedEventArgs e)
        {
            System.IO.StreamWriter sw = null;
            try
            {
                sw = new System.IO.StreamWriter("username.txt");
                sw.WriteLine(SetText.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sw != null)
                    sw.Close();
            }

            isDataDirety = false;
            RetButton.IsEnabled = true;
        }

        private void RetButton_Click(object sender, RoutedEventArgs e)
        {
            System.IO.StreamReader sr = null;
            try
            {
                using (sr = new System.IO.StreamReader("username.txt"))
                    RetLabel.Content = "Very Good morning, dear " + sr.ReadToEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sr != null)
                    sr.Close();
            }
        }

        private void SetText_TextChanged(object sender, TextChangedEventArgs e)
        {
            isDataDirety = true;
            SetButton.IsEnabled = true;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (isDataDirety)
            {
                string msg = "Данные были изменены, но не сохранены!\n Зарыть окно без сохранения?";
                MessageBoxResult result = MessageBox.Show(msg, "Контроль данных.", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (result == MessageBoxResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void SecWinButton_Click(object sender, RoutedEventArgs e)
        {
            if (MyWin == null)
                MyWin = new SecondWindow();
            MyWin.Owner = this;

            var location = SecWinButton.PointToScreen(new Point(0, 0));
            MyWin.Top = location.Y;
            MyWin.Left = location.X + MyWin.Width / 2;
            MyWin.Show();
        }
    }
}
