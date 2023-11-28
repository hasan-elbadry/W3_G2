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
            UserTable user=new UserTable();
            user.UserName = UserName.Text;
            user.Password = Password.Password;
            user.Email = Email.Text;
            db.UserTables.Add(user);
            db.SaveChanges();
            MessageBox.Show("Signup successfully");
        }
    }
}
