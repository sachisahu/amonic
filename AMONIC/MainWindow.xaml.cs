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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AMONIC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        AmonicDB dbo;
        public MainWindow()
        {
            InitializeComponent();
            logo.Source = new BitmapImage(new Uri("logo.png", UriKind.Relative));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dbo = new AmonicDB();
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            var row = dbo.Users.Where(c => c.Email == username && c.Password == password).FirstOrDefault();

            
            if (row == null)
            {
                MessageBox.Show("Invalid Credentials");
            }

            else
            {
                AutomationSystem autoSys = new AutomationSystem();
                autoSys.Show();
            }
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
