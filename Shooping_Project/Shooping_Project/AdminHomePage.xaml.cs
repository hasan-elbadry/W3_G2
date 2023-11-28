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
    /// Interaction logic for AdminHomePage.xaml
    /// </summary>
    public partial class AdminHomePage : Page
    {
        Shooping_cartEntities db = new Shooping_cartEntities();
        public AdminHomePage()
        {
            InitializeComponent();
            DataaGrid.ItemsSource = db.ProductTables.ToList();
        }

        private void RefreshData_Click(object sender, RoutedEventArgs e)
        {
            DataaGrid.ItemsSource = db.ProductTables.ToList();
        }

        private void InserDatabtn_Click(object sender, object e)
        {
            ProductTable product = new ProductTable();
            product.ProductName=productNametxt.Text;
            product.productQuntity=ProductQunititytxt.Text;
            db.ProductTables.Add(product);
            db.SaveChanges();
            DataaGrid.ItemsSource = db.ProductTables.ToList();
        }

        private void UpdateData_Click(object sender, object e)
        {
            ProductTable product = new ProductTable();
            product.ProductName = productNametxt.Text;
            product.productQuntity = ProductQunititytxt.Text;
            db.ProductTables.AddOrUpdate(product);
            db.SaveChanges();
            DataaGrid.ItemsSource = db.ProductTables.ToList();
        }

        private void DeleteData_Click(object sender, object e)
        {
            db.ProductTables.Remove(db.ProductTables.FirstOrDefault(x=>x.ProductName==productNametxt.Text));
            db.SaveChanges();
            DataaGrid.ItemsSource = db.ProductTables.ToList();
        }
    }
}
