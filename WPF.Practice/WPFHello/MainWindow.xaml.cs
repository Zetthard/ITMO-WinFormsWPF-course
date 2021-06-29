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

            SetButton.IsEnabled = false;
            RetButton.IsEnabled = false;
            Top = 25;
            Left = 25;
            CommandBinding abinding = new CommandBinding();
            abinding.Command = CustomCommands.Launch;
            abinding.Executed += new ExecutedRoutedEventHandler(Launch_Handler);
            abinding.CanExecute += new CanExecuteRoutedEventHandler(LaunchEnabled_Handler);
            this.CommandBindings.Add(abinding);
        }

        private string Filename = "username.txt";

        bool isDataDirty = false;

        public SecondWindow MyWin { get; set; }

        private void SetButtonWrite()
        {
            System.IO.StreamWriter sw2 = null;
            try
            {
                sw2 = new System.IO.StreamWriter("username.txt");
                sw2.WriteLine(SetText.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sw2 != null)
                    sw2.Close();
            }

            isDataDirty = false;
            RetButton.IsEnabled = true;
        }

        private void RetButtonRead()
        {
            System.IO.StreamReader sr2 = null;
            try
            {
                using (sr2 = new System.IO.StreamReader(Filename))
                    RetLabel.Content = "Very Good morning, dear " + sr2.ReadToEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sr2 != null)
                    sr2.Close();
            }
        }

        private void SetText_TextChanged(object sender, TextChangedEventArgs e)
        {
            isDataDirty = true;
            SetButton.IsEnabled = true;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (isDataDirty)
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

        private void Grid_Click(object sender, RoutedEventArgs e)
        {
            FrameworkElement FeSource = e.Source as FrameworkElement;
            try
            {
                switch (FeSource.Name)
                {
                    case "SetButton":
                        SetButtonWrite();
                        break;

                    case "RetButton":
                        RetButtonRead();
                        break;
                }

                e.Handled = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LaunchEnabled_Handler(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (bool)statBarCheckBox.IsChecked;
        }

        private void Launch_Handler(object sender, ExecutedRoutedEventArgs e)
        {
            if (MyWin == null)
                MyWin = new SecondWindow();
            MyWin.Owner = this;

            var location = SecWinButton.PointToScreen(new Point(0, 0));
            MyWin.Top = location.Y;
            MyWin.Left = location.X + MyWin.ActualWidth;
            MyWin.Show();
        }
    }
}
