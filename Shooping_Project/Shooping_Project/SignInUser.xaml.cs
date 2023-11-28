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
    /// Interaction logic for SignInUser.xaml
    /// </summary>
    public partial class SignInUser : Page
    {
        public SignInUser()
        {
            InitializeComponent();
        }
        Shooping_cartEntities db=new Shooping_cartEntities();
        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            var ad = db.UserTables.FirstOrDefault(x => x.UserName == UserName.Text && x.Password == Password.Password);
            if (ad != null)
            {
                UserPage page = new UserPage();
                this.NavigationService.Navigate(page);
            }
            else
            {
                MessageBox.Show("incorrect username or password");
            }
        }

        private void SignUpBtn_Click(object sender, RoutedEventArgs e)
        {
            SignUpUser page=new SignUpUser();
            this.NavigationService.Navigate(page);
        }

        private void ForgetPassowrd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ForgetPassowrd_Click(object sender, object e)
        {
            ForgetPassowrdUser user=new ForgetPassowrdUser();
            this.NavigationService.Navigate(user);
        }
    }
}
