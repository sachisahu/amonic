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
        public AutomationSystem()
        {
            InitializeComponent();
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
            EditRole er = new EditRole();
            er.Show();
        }
    }
}
