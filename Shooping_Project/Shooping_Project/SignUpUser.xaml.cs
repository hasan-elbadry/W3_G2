using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for SignUpUser.xaml
    /// </summary>
    public partial class SignUpUser : Page
    {
        public SignUpUser()
        {
            InitializeComponent();
        }
        Shooping_cartEntities db=new Shooping_cartEntities();
        private void SignUpBtn_Click(object sender, RoutedEventArgs e)
        {
            Regex r = new Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d).{8,15}$");
            if (r.IsMatch(Password.Password))
            {
                UserTable user = new UserTable();
                user.UserName = UserName.Text;
                user.Password = Password.Password;
                user.Email = Email.Text;
                db.UserTables.Add(user);
                db.SaveChanges();
                MessageBox.Show("Signup successfully");
            }
            else
            {

                MessageBox.Show("It must contain at least one lowercase letter.\r\nIt must contain at least one uppercase letter.\r\nIt must contain at least one digit.\r\nIt must be between 8 and 15 characters long.");

            }

        }
    }
}
