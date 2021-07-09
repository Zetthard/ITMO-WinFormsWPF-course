using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
        private static Mode mode = Mode.standard;

        public enum Mode : int
        { standard = 0, scientific = 1 }

        public MainWindow()
        {
            InitializeComponent();
            Display.Text = "0";

            InputGestureCollection coll = new InputGestureCollection();
            coll.Add(new KeyGesture(Key.A, ModifierKeys.Control, "Ctrl+A"));
        }

        private void ScientificExpand(object sender, RoutedEventArgs e)
        {
            if (mode != Mode.scientific)
            {
                this.Height += row1.ActualHeight * 5;
                KeySquare.Visibility = Visibility.Visible;
                KeyCube.Visibility = Visibility.Visible;
                KeyPowX.Visibility = Visibility.Visible;
                KeySqrt.Visibility = Visibility.Visible;
                KeyCubrt.Visibility = Visibility.Visible;
                KeyOneOverX.Visibility = Visibility.Visible;
                KeyFact.Visibility = Visibility.Visible;
                KeyEquation.Visibility = Visibility.Visible;
                mode = Mode.scientific;
            }
        }

        private void ScientificCollapse(object sender, RoutedEventArgs e)
        {
            if (mode != Mode.standard)
            {
                this.Height -= row1.ActualHeight * 5;
                KeySquare.Visibility = Visibility.Collapsed;
                KeyCube.Visibility = Visibility.Collapsed;
                KeyPowX.Visibility = Visibility.Collapsed;
                KeySqrt.Visibility = Visibility.Collapsed;
                KeyCubrt.Visibility = Visibility.Collapsed;
                KeyOneOverX.Visibility = Visibility.Collapsed;
                KeyFact.Visibility = Visibility.Collapsed;
                KeyEquation.Visibility = Visibility.Collapsed;
                mode = Mode.standard;
            }
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

        //
        //Calc operations
        //
        private void KeyAdd_Click(object sender, RoutedEventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eAdd);
            e.Handled = true;
        }

        private void KeySubstract_Click(object sender, RoutedEventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eSubtract);
            e.Handled = true;
        }
        private void KeyMultiply_Click(object sender, RoutedEventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eMultiply);
            e.Handled = true;
        }
        private void KeyDevision_Click(object sender, RoutedEventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eDivide);
            e.Handled = true;
        }

        private void KeyEqual_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = CalcEngine.CalcEqual();
            CalcEngine.CalcEqualPressed();
            e.Handled = true;
        }

        private void KeyClear_Click(object sender, RoutedEventArgs e)
        {
            CalcEngine.CalcReset();
            Display.Text = "0";
            e.Handled = true;
        }

        private void KeyDecimal_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = CalcEngine.CalcDecimal();
            e.Handled = true;
        }

        private void KeySign_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = CalcEngine.CalcSign();
            e.Handled = true;
        }

        private void KeyPercent_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = CalcEngine.CalcPercent();
            e.Handled = true;
        }

        private void KeySquare_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = CalcEngine.CalcSquare();
            e.Handled = true;
        }

        private void KeyCube_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = CalcEngine.CalcCube();
            e.Handled = true;
        }

        private void KeySqrt_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = CalcEngine.CalcSqrt();
            e.Handled = true;
        }

        private void KeyOneOverX_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = CalcEngine.CalcOneOverX();
            e.Handled = true;
        }

        private void KeyPowX_Click(object sender, RoutedEventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.ePow);
            e.Handled = true;
        }

        private void KeyCubrt_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = CalcEngine.CalcCubert();
            e.Handled = true;
        }

        private void MenuExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Display_TextChanged(object sender, TextChangedEventArgs e)
        {
            Display.Focus();
        }

        public static RoutedCommand HelpCmd = new RoutedCommand("About", typeof(MainWindow), coll);

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Программа вычисления \nпростых арифметических операций", "Калькулятор", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        /*
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
        }*/

        //
        // Async factorial computation
        //
        private async void KeyFact_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = Convert.ToString(await GetFactorial());
            e.Handled = true;
        }

        private async Task<int> GetFactorial()
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(5000);
                return CalcEngine.CalcFact();
            });
        }

        private void KeyEquation_Click(object sender, RoutedEventArgs e)
        {
            CoefficietsWindow Coeffitients = new CoefficietsWindow();
            Coeffitients.Owner = this;
            Coeffitients.Show();
        }

        //
        //Theme control
        //
        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            REghZyFramework.Themes.ThemesController.SetTheme(REghZyFramework.Themes.ThemesController.ThemeTypes.Dark);
        }

        private void ListBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            REghZyFramework.Themes.ThemesController.SetTheme(REghZyFramework.Themes.ThemesController.ThemeTypes.Light);
        }
    }
}
