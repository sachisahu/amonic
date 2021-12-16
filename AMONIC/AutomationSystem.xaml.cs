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
    /// Interaction logic for AutomationSystem.xaml
    /// </summary>
    public partial class AutomationSystem : Window
    {
        AmonicDB dbUser = new AmonicDB();
        public AutomationSystem()
        {
            AmonicDB dbo = new AmonicDB();
            InitializeComponent();
            AmonicDB dbUser = new AmonicDB();



            DateTime today = DateTime.Today;

           /* dtgGrid.ItemsSource = dbUser.UserViews.Select(c => new
            {
                Name = c.FirstName,
                LName = c.LastName,
                UserRole = c.User_Role,
                
                Email = c.Email,
                Office = c.Office


            }).ToList();*/

            Office os = (Office)cbOffice.SelectedItem;
            cbOffice.ItemsSource = dbo.Offices.ToList();
            cbOffice.DisplayMemberPath = "Title";
            cbOffice.SelectedValuePath = "ID";


            dtgGrid.ItemsSource = dbUser.Users.Join(dbUser.Offices, u => u.OfficeID, o => o.ID, (u, o) => new
            {

                FirstName = u.FirstName,
                LastName = u.LastName,
                RoleID = u.RoleID,
                Birthdate = DateTime.Now.Year - u.Birthdate.Value.Year,
                Email = u.Email,
                Office = o.Title,
                OfficeID = o.ID

            }).Select(s => new
            {
                s.FirstName,
                s.LastName,
                Age = s.Birthdate,
                s.Email,
                s.Office

            }).ToList();

            /*.Join(dbUser.Roles, u => u.RoleID, r => r.Title, (u, r) => new
             {
                 Roll = r.Title
             })*/




        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            addUser au = new addUser();
            au.Show();

        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void changeRoll_Click(object sender, RoutedEventArgs e)
        {
            EditRole er = new EditRole();
            er.Show();

        }

        private void dtgGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            EditRole er = new EditRole();
            //er.Email.Text = e.

        }

        private void dtgGrid_LoadingRow(object sender, DataGridRowEventArgs e)
        {

        }

        private void manageFlightSchedules_Click(object sender, RoutedEventArgs e)
        {
            ManageFlightSchedules mfs = new ManageFlightSchedules();
            mfs.Show();
        }

        private void cbOffice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int officeID = Convert.ToInt32(cbOffice.SelectedValue.ToString());
            Office os = (Office)cbOffice.SelectedItem;
            cbOffice.SelectedValuePath = "ID";
            DateTime today = DateTime.Today;
            dtgGrid.ItemsSource = dbUser.Users.Join(dbUser.Offices, u => u.OfficeID, o => o.ID, (u, o) => new
            {

                FirstName =u.FirstName,
                LastName =u.LastName,
                Birthdate = DateTime.Now.Year - u.Birthdate.Value.Year,
                Email =u.Email,
                Office = o.Title,
                o.ID

            }).Where(c => c.ID == officeID).Select(s => new
            {
                s.FirstName,
                s.LastName,
                Age = s.Birthdate,
                s.Email,
                s.Office
            }).ToList();
        }
        public class userD
        {
            public string Firstname { get; set; }
            public string Lastname { get; set; }

        }
        /*public List<userD> LoadUser()
        {
            AmonicDB dbUser = new AmonicDB();
            List<userD> userd = new List<userD>();
            userd.Add = dbUser.Users.ToList();




         }*/

    }
}


