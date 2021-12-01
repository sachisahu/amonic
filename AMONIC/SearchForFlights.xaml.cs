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
    /// Interaction logic for SearchForFlights.xaml
    /// </summary>
    public partial class SearchForFlights : Window
    {
        public SearchForFlights()
        {
            InitializeComponent();
        }

        private void bookFlight_Click(object sender, RoutedEventArgs e)
        {
            BookingConfirmation bookc = new BookingConfirmation();
            bookc.Show();
        }
    }
}
