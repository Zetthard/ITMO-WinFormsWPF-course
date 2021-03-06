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

namespace DialogWindows
{
    /// <summary>
    /// Логика взаимодействия для TaskWindow.xaml
    /// </summary>
    public partial class TaskWindow : Window
    {
        public string ViewModel { get; set; }

        public TaskWindow()
        {
            InitializeComponent();
        }

        public void ShowViewModel()
        {
            this.Title = ViewModel;
        }

        private void ButtonSend_Click(object sender, RoutedEventArgs e)
        {
            MainWindow wnd1 = this.Owner as MainWindow;
            wnd1.ButtonMain.Content = TextBoxWind2.Text;
            wnd1.Background = new SolidColorBrush(Colors.Green);
        }
    }
}
