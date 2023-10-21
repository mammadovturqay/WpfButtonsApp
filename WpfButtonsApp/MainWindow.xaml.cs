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

namespace WpfButtonsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random random = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            ChangeButtonColor(button);
        }

        private void Button_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Button button = (Button)sender;
            int buttonIndex = Convert.ToInt32(button.Name.Substring(button.Name.Length - 1));
            
            string message = $"Button {buttonIndex} silindi!";
            MessageBox.Show(message, "Informasiya", MessageBoxButton.OK, MessageBoxImage.Information);
            ((StackPanel)button.Parent).Children.Remove(button);
        }

        private void ChangeButtonColor(Button button)
        {
            byte[] rgb = new byte[3];
            random.NextBytes(rgb);
            Color color = Color.FromRgb(rgb[0], rgb[1], rgb[2]);
            SolidColorBrush brush = new SolidColorBrush(color);
            button.Background = brush;

            int buttonIndex = Convert.ToInt32(button.Name.Substring(button.Name.Length - 1));
            string message = $"Button {buttonIndex} yeni reng verildi : R({rgb[0]}), G({rgb[1]}), B({rgb[2]})";
            MessageBox.Show(message, "Melumat", MessageBoxButton.OK, MessageBoxImage.Information);
        }



    }



}
