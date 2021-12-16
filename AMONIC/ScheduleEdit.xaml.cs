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
        Session3Entities s3db = new Session3Entities();
        public ScheduleEdit()
        {
            InitializeComponent();
        }
        public int id;
        private void SearchForFlight_Click(object sender, RoutedEventArgs e)
        {
            SearchForFlights sff = new SearchForFlights();
            sff.Show();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            
            var pri = Convert.ToDecimal(txtEcoPrice.Text);

            try
            {
                var editRow = s3db.Schedules.Where(d => d.EconomyPrice == pri).FirstOrDefault();
                
            }
            catch(Exception a)
            {
                MessageBox.Show("" + a);
            }
            finally
            {
                
                s3db.SaveChanges();
            }
        }
    }
}
