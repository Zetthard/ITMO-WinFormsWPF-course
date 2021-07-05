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

namespace WPFCalculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static InputGestureCollection coll;
        // Output Display Constants.
        private const string oneOut = "1";
        private const string twoOut = "2";
        private const string threeOut = "3";
        private const string fourOut = "4";
        private const string fiveOut = "5";
        private const string sixOut = "6";
        private const string sevenOut = "7";
        private const string eightOut = "8";
        private const string nineOut = "9";
        private const string zeroOut = "0";

        public MainWindow()
        {
            InitializeComponent();
            Display.Text = "0";


            InputGestureCollection coll = new InputGestureCollection();
            coll.Add(new KeyGesture(Key.A, ModifierKeys.Control, "Ctrl+A"));
        }

        public static RoutedCommand HelpCmd = new RoutedCommand("About", typeof(MainWindow), coll);

        private void KeyAdd_Click(object sender, RoutedEventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eAdd);
        }

        private void KeySubstract_Click(object sender, RoutedEventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eSubtract);
        }
        private void KeyMultiply_Click(object sender, RoutedEventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eMultiply);
        }
        private void KeyDevision_Click(object sender, RoutedEventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eDivide);
        }

        private void KeyEqual_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = CalcEngine.CalcEqual();
            CalcEngine.CalcReset();
        }

        private void KeyClear_Click(object sender, RoutedEventArgs e)
        {
            CalcEngine.CalcReset();
            Display.Text = "0";
        }

        private void OutputDisplay_TextChanged(object sender, TextChangedEventArgs e)
        {
            Display.Focus();
        }

        private void CommandBinding_Executed_1(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Программа вычисления \nпростых арифметических операций", "Калькулятор", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void CommandBinding_CanExecute_1(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CommandBinding_Executed_2(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Программа вычисления \nпростых арифметических операций", "Калькулятор", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void myGrid_Click_1(object sender, RoutedEventArgs e)
        {
            FrameworkElement feSource = e.Source as FrameworkElement;
            switch (feSource.Name)
            {
                case "KeyOne":
                    Display.Text = CalcEngine.CalcNumber(oneOut);
                    break;
                case "KeyTwo":
                    Display.Text = CalcEngine.CalcNumber(twoOut);
                    break;
                case "KeyThree":
                    Display.Text = CalcEngine.CalcNumber(threeOut);
                    break;
                case "KeyFour":
                    Display.Text = CalcEngine.CalcNumber(fourOut);
                    break;
                case "KeyFive":
                    Display.Text = CalcEngine.CalcNumber(fiveOut);
                    break;
                case "KeySix":
                    Display.Text = CalcEngine.CalcNumber(sixOut);
                    break;
                case "KeySeven":
                    Display.Text = CalcEngine.CalcNumber(sevenOut);
                    break;
                case "KeyEight":
                    Display.Text = CalcEngine.CalcNumber(eightOut);
                    break;
                case "KeyNine":
                    Display.Text = CalcEngine.CalcNumber(nineOut);
                    break;
                case "KeyZero":
                    Display.Text = CalcEngine.CalcNumber(zeroOut);
                    break;
            }
            e.Handled = true;
        }

        private void MenuExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Программа вычисления \nпростых арифметических операций", "Калькулятор", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            REghZyFramework.Themes.ThemesController.SetTheme(REghZyFramework.Themes.ThemesController.ThemeTypes.Dark);
        }

        private void ListBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            REghZyFramework.Themes.ThemesController.SetTheme(REghZyFramework.Themes.ThemesController.ThemeTypes.Light);
        }

        private void ListBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            REghZyFramework.Themes.ThemesController.SetTheme(REghZyFramework.Themes.ThemesController.ThemeTypes.ColourfulLight);
        }

        private void ListBoxItem_Selected_3(object sender, RoutedEventArgs e)
        {
            REghZyFramework.Themes.ThemesController.SetTheme(REghZyFramework.Themes.ThemesController.ThemeTypes.ColourfulDark);
        }
    }
}
