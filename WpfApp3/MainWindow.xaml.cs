using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Produkt> produkties { get; set; }
        public MainWindow()
        {
            produkties = new();
            InitializeComponent();
            List.ItemsSource = produkties;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Pridat pridat = new(produkties);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}