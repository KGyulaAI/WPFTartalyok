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
using System.IO;
using Osztalyok;

namespace TartalyWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Tartaly> tartalyok = new List<Tartaly>();
        Tartaly ujTest;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnFelvesz_Click(object sender, RoutedEventArgs e)
        {
            btnDuplaz.IsEnabled = true;
            btnLeenged.IsEnabled = true;
            ujTest = new Tartaly(txtNev.Text, Convert.ToInt32(txtAel.Text), Convert.ToInt32(txtBel.Text), Convert.ToInt32(txtCel.Text));
            tartalyok.Add(ujTest);
            lbTartalyok.Items.Refresh();
            StreamWriter streamWriter = new StreamWriter("tartaly.csv", append: true);
            streamWriter.Close();
        }

        private void btnRogzit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDuplaz_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnLeenged_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btntolt_Click(object sender, RoutedEventArgs e)
        {

        }

        private void rdoTeglatest_Checked(object sender, RoutedEventArgs e)
        {
            txtAel.Text = "";
            txtBel.Text = "";
            txtCel.Text = "";
            txtAel.IsEnabled = true;
            txtBel.IsEnabled = true;
            txtCel.IsEnabled = true;
        }

        private void rdoKocka_Checked(object sender, RoutedEventArgs e)
        {
            ujTest = new Tartaly(txtNev.Text);
            txtAel.Text = ujTest.aEl.ToString();
            txtBel.Text = ujTest.bEl.ToString();
            txtCel.Text = ujTest.cEl.ToString();
            txtAel.IsEnabled = false;
            txtBel.IsEnabled = false;
            txtCel.IsEnabled = false;
        }
    }
}
