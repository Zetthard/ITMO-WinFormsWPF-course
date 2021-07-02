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

namespace UserControl
{
    /// <summary>
    /// Логика взаимодействия для ShowNumberControl.xaml
    /// </summary>
    public partial class ShowNumberControl
    {
        public ShowNumberControl()
        {
            InitializeComponent();
        }

        public int PublicNumber
        {
            get { return (int)GetValue(PublicNumberProperty); }
            set { SetValue(PublicNumberProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PublicNumber.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PublicNumberProperty =
            DependencyProperty.Register("PublicNumber", typeof(int), typeof(ShowNumberControl), new UIPropertyMetadata(100, new PropertyChangedCallback(PublicNumberChanged)), new ValidateValueCallback(ValidatePublicNumber));

        public static bool ValidatePublicNumber(object value)
        {
            return Convert.ToInt32(value) >= 0 && Convert.ToInt32(value) <= 500;
        }

        private static void PublicNumberChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
        {
            ShowNumberControl show = (ShowNumberControl)dependencyObject;
            Label UserLabel = show.NumberDisplay;
            UserLabel.Content = args.NewValue.ToString();
        }
    }
}
