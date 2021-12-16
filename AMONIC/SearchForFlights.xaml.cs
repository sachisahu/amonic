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
        Session3Entities dboS3= new Session3Entities();
        public SearchForFlights()
        {
            InitializeComponent();
            

        }

        private void bookFlight_Click(object sender, RoutedEventArgs e)
        {
            BookingConfirmation bookc = new BookingConfirmation();
            bookc.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Airport airport = (Airport)cbFrom.SelectedItem;
            cbFrom.ItemsSource = dboS3.Airports.ToList();
            cbFrom.DisplayMemberPath = "IATACode";
            cbFrom.SelectedValuePath = "ID";

            Airport toAirport = (Airport)cbTo.SelectedItem;
            cbTo.ItemsSource = dboS3.Airports.ToList();
            cbTo.DisplayMemberPath = "IATACode";
            cbTo.SelectedValuePath = "ID";

            Airport CabinAirport = (Airport)cbCabinType.SelectedItem;
            cbCabinType.ItemsSource = dboS3.CabinTypes.ToList();
            cbCabinType.DisplayMemberPath = "Name";
            cbCabinType.SelectedValuePath = "ID";


        }

        private void btnApply_Click(object sender, RoutedEventArgs e)
        {

            int from = Convert.ToInt32(cbFrom.SelectedValue.ToString());
            int to = Convert.ToInt32(cbTo.SelectedValue.ToString());
            string mdate = DateOutbound.SelectedDate.Value.ToString("dd/MM/yyyy");
            DateTime date = DateTime.Parse(mdate);

            //Doubt---
            string Airportform = cbFrom.SelectedItem.ToString();
            string AirportTo = cbTo.SelectedItem.ToString();

            dgReturn.ItemsSource = dboS3.Routes.Join(dboS3.Schedules, r => r.ID, s => s.RouteID, (r, s) => new
            {
                r.ArrivalAirportID,
                r.DepartureAirportID,
                r.ID,
                s.Date,
                s.Time,
                s.EconomyPrice,
                s.FlightNumber
            }).Where(x => x.ArrivalAirportID == from && x.DepartureAirportID == to && x.Date == date).Select(c => new
            {
                /* From = ,
                 To = ,*/
                Date = c.Date,
                Time = c.Time,
                FilghtNo = c.FlightNumber,
                Cabin_Price = c.EconomyPrice
            }).ToList();



            dgReturn.ItemsSource = dboS3.Routes.Join(dboS3.Schedules, r => r.ID, s => s.RouteID, (r, s) => new
            {
                r.ArrivalAirportID,
                r.DepartureAirportID,
                r.ID,
                s.Date,
                s.Time,
                s.EconomyPrice,
                s.FlightNumber
            }).Where(x => x.ArrivalAirportID == from && x.DepartureAirportID == to).Select(c => new
            {
               /* From = ,
                To = ,*/
                Date = c.Date,
                Time = c.Time,
                FilghtNo = c.FlightNumber,
                Cabin_Price = c.EconomyPrice
            }).ToList();


            
            //dgOutbound.ItemsSource = dboS3.Routes.Where(c => c.ArrivalAirportID == from && c.DepartureAirportID == to).ToList();

        }
    }
}
