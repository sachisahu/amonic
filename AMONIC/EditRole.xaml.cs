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
    /// Interaction logic for EditRole.xaml
    /// </summary>
    public partial class EditRole : Window
    {
        AmonicDB amonic = new AmonicDB();
        public EditRole()
        {
            InitializeComponent();
        }

        private void Apply_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (rbUser.IsChecked == true)
                {
                    var email = txtEmail.Text;
                    var row = amonic.Users.Where(c => c.Email == email).FirstOrDefault();
                    if(row == null)
                    {
                        MessageBox.Show("User Not Found");
                    }
                    else
                    {
                        row.RoleID = 2;
                    }
                    
                }
                if (rbAdmin.IsChecked == true)
                {
                    var email = txtEmail.Text;
                    var row = amonic.Users.Where(c => c.Email == email).FirstOrDefault();
                    if (row == null)
                    {
                        MessageBox.Show("User Not Found");
                    }
                    else
                    {
                        row.RoleID = 1;
                    }

                }
            }
            catch(Exception d)
            {
                MessageBox.Show(""+d);
            }
            finally
            {
                amonic.SaveChanges();
            }
        }
    }
}
