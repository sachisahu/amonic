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
    /// Interaction logic for addUser.xaml
    /// </summary>
    public partial class addUser : Window
    {
        AmonicDB dbo;
        public addUser()
        {
            InitializeComponent();
            dbo = new AmonicDB();
            cbOffice.ItemsSource = dbo.Offices.ToList();
            cbOffice.DisplayMemberPath = "Title";
            cbOffice.SelectedValuePath = "ID";
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();
            user.RoleID = 2;
            user.Active = true;
            user.Email = txtEmail.Text;
            user.FirstName = txtFName.Text;
            user.LastName = txtLName.Text;
            Office os = (Office)cbOffice.SelectedItem;
            user.OfficeID = os.ID;
            user.Birthdate = dpBirth.SelectedDate.Value;
            user.Password = txtPassword.Text;
            dbo.Users.Add(user);
            Console.WriteLine("first name :" + txtFName.Text);
            Console.WriteLine("Office Id  :" + cbOffice.SelectedIndex);
            Console.WriteLine("Birth date :" + dpBirth.SelectedDate.Value);
            dbo.SaveChanges();

            

        }
    }
}
