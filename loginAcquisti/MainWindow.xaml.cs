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

namespace loginAcquisti
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtUtente.Focus();
            txtPrezzo.IsEnabled = false;
            txtQuantita.IsEnabled = false;
            cmbProdotto.IsEnabled = false;
            btnPulisci.IsEnabled = false;
            btnStampa.IsEnabled = false;
            ltbRisultato.IsEnabled = false;
            btnRimuoviSelezione.IsEnabled = false;
        }

        private const string PASSWORD = "ciao";
        private string[] prodotti = new string[] { "Felpa", "T-Shirt", "Polo", "Pantalone", "Calzini", "Mutande" };
        private string utente;

        private void btnAccedi_Click(object sender, RoutedEventArgs e)
        {
            utente = txtUtente.Text;
            string pass = txtPassword.Text;

            if(utente !="" && utente != null && pass == PASSWORD)
            {
                txtUtente.IsEnabled = false;
                txtPassword.IsEnabled = false;
                btnAccedi.IsEnabled = false;

                txtPrezzo.IsEnabled = true;
                txtQuantita.IsEnabled = true;
                cmbProdotto.IsEnabled = true;
                btnPulisci.IsEnabled = true;
                btnStampa.IsEnabled = true;
                ltbRisultato.IsEnabled = true;
                btnRimuoviSelezione.IsEnabled = true;
            }
            else if(utente == "" || utente == null)
            {
                MessageBox.Show("Inserire un utente valido","", MessageBoxButton.OK, MessageBoxImage.Error);
                txtUtente.Text = "";
                txtPassword.Text = "";
                txtUtente.Focus();
            }
            else if(pass != PASSWORD)
            {
                MessageBox.Show("Password errata", "", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                txtPassword.Text = "";
                txtPassword.Focus();
            }
        }
    }
}
