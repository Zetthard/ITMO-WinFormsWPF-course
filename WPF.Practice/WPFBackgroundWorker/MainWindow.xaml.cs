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

namespace BackgroundWorker
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AWorker.WorkerSupportsCancellation = true;
            AWorker.DoWork += AWorker_DoWork;
            AWorker.RunWorkerCompleted += AWorker_RunWorkerCompleted;
        }

        System.ComponentModel.BackgroundWorker AWorker = new System.ComponentModel.BackgroundWorker();

        private void AWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
                Label2.Content = "Run Completed";
            else
                Label2.Content = "Run Cancelled";
        }

        private void AWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            for (int i = 0; i <= 50; i++)
            {
                for (int j = 1; j <= 10000000; j++)
                {
                }
                if (AWorker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                UpdateDelegate update = new UpdateDelegate(UpdateLabel);
                LableCycles.Dispatcher.BeginInvoke(
               System.Windows.Threading.DispatcherPriority.Normal, update, i);
            }
        }

        private delegate void UpdateDelegate(int i);
        private void UpdateLabel(int i)
        {
            LableCycles.Content += " " + i.ToString() + " |";
        }

        private void ButtonStart_Click(object sender, RoutedEventArgs e)
        {
            AWorker.RunWorkerAsync();
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            AWorker.CancelAsync();
        }
    }
}
