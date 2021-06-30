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

namespace WPFHello
{
    /// <summary>
    /// Логика взаимодействия для SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        public SecondWindow()
        {
            InitializeComponent();
        }

        private bool IsClosed;
        MainWindow Window1 = null;

        public new void Close()
        {
            IsClosed = true;
            base.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (IsClosed) return;
            e.Cancel = true;
            Hide();
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            Window1 = Owner as MainWindow;
            if (Window1 != null)
                Window1.SetText.Text = TextBox2.Text + ListBoxSecondWindow.SelectedItem; //ну и как это сделать?
            PrintLogFile();
            Close();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Window1.MyWin = null;
        }

        private void PrintLogFile()
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter("log.txt", true))
            {
                writer.WriteLine("Внесено {0}: {1} ", TextBox2.Text, DateTime.Now.ToShortDateString() + ", время: " + DateTime.Now.ToLongTimeString());
                writer.Flush();
            }
        }

        private void ListBoxSecondWindow_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
