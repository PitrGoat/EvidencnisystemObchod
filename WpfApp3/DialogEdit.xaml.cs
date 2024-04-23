using System.Windows;
using WpfApp3;
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
 
namespace WpfApp3

{

    /// <summary>

    /// Interakční logika pro Edit.xaml

    /// </summary>

    public partial class Edit : Window
    {

        public Produkt Z { get; set; }

        public Edit(Produkt z)

        {

            Z = z;

            InitializeComponent();

            DataContext = Z;

        }

        private void Button_Click(object sender, RoutedEventArgs e)

        {

            this.Close();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)

        {

            this.Close();

        }

    }

}