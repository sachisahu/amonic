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
    /// Interaction logic for ManageFlightSchedules.xaml
    /// </summary>
    public partial class ManageFlightSchedules : Window
    {
        public ManageFlightSchedules()
        {
            InitializeComponent();
        }

        private void EditFlight_Click(object sender, RoutedEventArgs e)
        {
            ScheduleEdit se = new ScheduleEdit();
            se.Show();
        }
    }
}
