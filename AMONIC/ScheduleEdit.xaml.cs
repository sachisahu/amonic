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
    /// Interaction logic for ScheduleEdit.xaml
    /// </summary>
    public partial class ScheduleEdit : Window
    {
        public ScheduleEdit()
        {
            InitializeComponent();
        }

        private void SearchForFlight_Click(object sender, RoutedEventArgs e)
        {
            SearchForFlights sff = new SearchForFlights();
            sff.Show();
        }
    }
}
