using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Interaction logic for ForgetPassowrdUser.xaml
    /// </summary>
    public partial class ForgetPassowrdUser : Page
    {
        public ForgetPassowrdUser()
        {
            InitializeComponent();
        }
        Shooping_cartEntities db=new Shooping_cartEntities();
        private void SignUpBtn_Click(object sender, RoutedEventArgs e)
        {
            var admin = db.UserTables.FirstOrDefault(x => x.UserName == UserName.Text);
            if (Password.Password == conformPassword.Password)
            {
                admin.Password = Password.Password;
            }
            else
            {
                MessageBox.Show("enter the same password in conform password");
            }
            db.UserTables.AddOrUpdate(admin);
            db.SaveChanges();
        }
    }
}
