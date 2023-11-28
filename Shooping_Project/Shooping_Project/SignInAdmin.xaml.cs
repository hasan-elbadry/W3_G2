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
    /// Interaction logic for SignInAdmin.xaml
    /// </summary>
    public partial class SignInAdmin : Page
    {
        public SignInAdmin()
        {
            InitializeComponent();
        }
        Shooping_cartEntities db=new Shooping_cartEntities();
        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            var ad= db.AdminTables.FirstOrDefault(x=>x.UserName==UserName.Text && x.Password==Password.Password);
            if (ad != null)
            {
                AdminHomePage page=new AdminHomePage();
                this.NavigationService.Navigate(page);
            }
            else
            {
                MessageBox.Show("incorrect username or password");
            }
        }

        private void ForgetPassowrd_Click(object sender, RoutedEventArgs e)
        {
            ForgetPassowrdAdmin forgetPassowrd = new ForgetPassowrdAdmin();
            this.NavigationService.Navigate(forgetPassowrd);
        }

        private void SignUpBtn_Click(object sender, RoutedEventArgs e)
        {
            SignUpAdmin signUpAdmin = new SignUpAdmin();
            this.NavigationService.Navigate(signUpAdmin);
        }

        
    }
}
