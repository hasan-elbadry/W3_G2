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

namespace Shooping_Project
{
    /// <summary>
    /// Interaction logic for choose.xaml
    /// </summary>
    public partial class choose : Page
    {
        public choose()
        {
            InitializeComponent();
        }

        private void AdminBtn_Click(object sender, RoutedEventArgs e)
        {
            SignInAdmin page = new SignInAdmin();
            this.NavigationService.Navigate(page);
        }

        private void Userbtn_Click(object sender, RoutedEventArgs e)
        {
            SignInUser page = new SignInUser();
            this.NavigationService.Navigate(page);
        }
    }
}
