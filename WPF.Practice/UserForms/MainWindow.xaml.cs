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
using System.Windows.Forms;

namespace UserForms
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

        List<string> PhoneNumbers = new List<string>();
        SaveFileDialog AFileDialog;

        private void Botton1_Click(object sender, RoutedEventArgs e)
        {
            MaskedTextBox aBox;
            aBox = (MaskedTextBox)WinFormsHost1.Child;
            PhoneNumbers.Add(aBox.Text);
            aBox.Clear();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            AFileDialog = new SaveFileDialog();
            AFileDialog.Filter = "Text Files | *.txt";
            AFileDialog.ShowDialog();
            System.IO.StreamWriter MySW = new System.IO.StreamWriter(AFileDialog.FileName, true);
            foreach (string number in PhoneNumbers)
                MySW.WriteLine(number);
            MySW.Close();
        }
    }
}
