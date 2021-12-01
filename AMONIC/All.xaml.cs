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

namespace AMONIC
{
    /// <summary>
    /// Interaction logic for All.xaml
    /// </summary>
    public partial class All : Window
    {
        public All()
        {
            InitializeComponent();
        }

        private void searchForFlights_Click(object sender, RoutedEventArgs e)
        {
            SearchForFlights sff = new SearchForFlights();
            sff.Show();
        }

        private void bookingConfirmation_Click(object sender, RoutedEventArgs e)
        {
            BookingConfirmation bookc = new BookingConfirmation();
            bookc.Show();
        }

        private void billingConfirmation_Click(object sender, RoutedEventArgs e)
        {
            BillingConfirmation bc = new BillingConfirmation();
            bc.Show();
        }
    }
}
