using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
    /// Interakční logika pro Pridat.xaml
    /// </summary>
    public partial class Pridat : Window
    {
        List<Produkt> _produkt;
        public Pridat(List<Produkt> produkties)
        {
            _produkt = produkties;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private int VytvorID() => _produkt.Count + 1;

        private void (object sender, TextChangedEventArgs e)
        
            string Nazev = ProNazev.Text;
        DateOnly pridani = DateOnly.Parse(ProDatum.Text);

        Produkt Novy = new Produkt(VytvorID(), Nazev, pridani);
        _produkt.Add(Novy);
    }
}
