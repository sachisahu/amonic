using System;
using System.Collections.Generic;
using System.Data;
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
        Session2Entities S3db = new Session2Entities();
        public ManageFlightSchedules()
        {
            InitializeComponent();
        }

        private void EditFlight_Click(object sender, RoutedEventArgs e)
        {
            ScheduleEdit se = new ScheduleEdit();
            
            se.lblFrom.Content = from;
            se.lblTo.Content = to;
            //se.dpDate.SetValue = date;
            se.lblAricraft.Content = aircraft;
            se.txtTime.Text = Convert.ToString(time);
            se.txtEcoPrice.Text = Convert.ToString(ePrice);
            se.dpDate.Text = date.ToString();
            se.id = tid;
            se.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Airport apFrom = (Airport)cbFrom.SelectedItem;
            cbFrom.ItemsSource = S3db.Airports.ToList();
            cbFrom.DisplayMemberPath = "IATACode";
            cbFrom.SelectedValuePath = "ID";


            Airport apTO = (Airport)cbTo.SelectedItem;
            cbTo.ItemsSource = S3db.Airports.ToList();
            cbTo.DisplayMemberPath = "IATACode";
            cbTo.SelectedValuePath = "ID";
        }
        int economyPricePrecentage = 35 / 100;
        private void btnApply_Click(object sender, RoutedEventArgs e)
        {
            Airport airportFrom = (Airport)cbFrom.SelectedItem;
            string airFrom = airportFrom.IATACode;
            int from = airportFrom.ID;

            Airport airportTo = (Airport)cbTo.SelectedItem;
            string airTo = airportTo.IATACode;

            dgFilghtsSchedule.ItemsSource = S3db.Schedules.Join(S3db.Aircrafts, s => s.AircraftID, a => a.ID, (s, a) => new
            {
                ID = s.ID,
                Date = s.Date,
                Time = s.Time,
                From = airFrom,
                To = airTo,
                FlightNumber = s.FlightNumber,
                Aircraft = a.Name,
                EconmyPrice = s.EconomyPrice,
                BusinessPrice = ((s.EconomyPrice * 35) / 100) + s.EconomyPrice,
                //FirstClassPrice = (((((s.EconomyPrice * 35) / 100) + s.EconomyPrice)*30s)/100) + ((s.EconomyPrice * 35) / 100) + s.EconomyPrice)

            }).Where(c => c.From == airFrom && c.To == airTo || c.FlightNumber == txtfligt.Text || c.Date == dtOutbound.SelectedDate).ToList().Select(s => new FlightClass(
                    s.Date,
                    s.Time,
                    airFrom,
                    airTo,
                    s.FlightNumber,
                    s.Aircraft,
                    s.EconmyPrice,
                    s.BusinessPrice,
                    s.ID
            )).ToList();

            int x = 6;
        }
        string from;
        string to;
        string aircraft;
        DateTime date;
        //DateTime date1 = Convert.ToDateTime(date);
        TimeSpan time;
        decimal ePrice;
        int tid;
        
        private void dgFilghtsSchedule_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FlightClass item = (FlightClass)dgFilghtsSchedule.SelectedItem;

            from = item.From;
            to = item.To;
            aircraft = item.Aircraft;
            date = item.Date;
            time = item.Time;
            ePrice = item.EconomyPrice;
            tid = item.ID;


            

            /*object item = dgFilghtsSchedule.SelectedItem; //probably you find this object
            from = (dgFilghtsSchedule.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
            to = (dgFilghtsSchedule.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text;
            aircraft = (dgFilghtsSchedule.SelectedCells[5].Column.GetCellContent(item) as TextBlock).Text;
            date = (dgFilghtsSchedule.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
            time = (dgFilghtsSchedule.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
            ePrice = (dgFilghtsSchedule.SelectedCells[6].Column.GetCellContent(item) as TextBlock).Text;
            strID = (dgFilghtsSchedule.SelectedCells[7].Column.GetCellContent(item) as TextBlock).Text;*/




        }


        private void dgFilghtsSchedule_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {

        }

       
    }

    internal class FlightClass
    {
        public DateTime Date { get; }
        public TimeSpan Time { get; }
        public string From { get; }
        public string To { get; }
        public string FlightNo { get; }
        public string Aircraft { get; }
        public decimal EconomyPrice { get; }
        public decimal BusinessClassPrice { get; }
        public int ID { get; }

        public FlightClass(DateTime date, TimeSpan time, string from, string to, string flightNo, string aircraft, decimal economyPrice, decimal businessClassPrice, int iD)
        {
            Date = date;
            Time = time;
            From = from;
            To = to;
            FlightNo = flightNo;
            Aircraft = aircraft;
            EconomyPrice = economyPrice;
            BusinessClassPrice = businessClassPrice;
            ID = iD;
        }

        public override bool Equals(object obj)
        {
            return obj is FlightClass other &&
                   Date == other.Date &&
                   Time.Equals(other.Time) &&
                   From == other.From &&
                   To == other.To &&
                   FlightNo == other.FlightNo &&
                   Aircraft == other.Aircraft &&
                   EconomyPrice == other.EconomyPrice &&
                   BusinessClassPrice == other.BusinessClassPrice &&
                   ID == other.ID;
        }

        public override int GetHashCode()
        {
            int hashCode = 554463147;
            hashCode = hashCode * -1521134295 + Date.GetHashCode();
            hashCode = hashCode * -1521134295 + Time.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(From);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(To);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FlightNo);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Aircraft);
            hashCode = hashCode * -1521134295 + EconomyPrice.GetHashCode();
            hashCode = hashCode * -1521134295 + BusinessClassPrice.GetHashCode();
            hashCode = hashCode * -1521134295 + ID.GetHashCode();
            return hashCode;
        }
    }
}
