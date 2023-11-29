using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
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
using System.Text.RegularExpressions;

namespace Shooping_Project
{
    /// <summary>
    /// Interaction logic for UserPage.xaml
    /// </summary>
    public partial class UserPage : Page
    {
        Shooping_cartEntities db=new Shooping_cartEntities();
        static int count=0;
        static List<ProductTable> products = new List<ProductTable>();
        public UserPage()
        {
            InitializeComponent();
            
            Combo.ItemsSource = db.ProductTables.ToList().Select(x=>x.ProductName);
        }
        public void Fun()
        {
            var productname = db.ProductTables.Select(h => h.ProductName).ToList();
            InitializeComponent();
            Grid[] grid = new Grid[18];
            int x = -550;
            int y = -250;
            Label[] label = new Label[18];

            for (int i = 0; i < 4; i++)
            {
                grid[i] = new Grid();


                label[i] = new Label();
                label[i].HorizontalAlignment = HorizontalAlignment.Center;
                label[i].Content = productname[i].ToString();
                grid[i].Children.Add(label[i]);


                grid[i].Width = 150;
                grid[i].Height = 100;
                grid[i].Margin = new Thickness(x, y, 0, 0);
                grid[i].Background = Brushes.Yellow;
                x += 350;
                mygrid.Children.Add(grid[i]);
            }
            for (int i = 4; i < productname.Count; i++)
            {
                x = -550;
                grid[i] = new Grid();


                label[i] = new Label();
                label[i].HorizontalAlignment = HorizontalAlignment.Center;
                label[i].Content = productname[i].ToString();
                grid[i].Children.Add(label[i]);


                grid[i].Width = 150;
                grid[i].Height = 100;
                grid[i].Margin = new Thickness(x, 100, 0, 0);
                grid[i].Background = Brushes.Yellow;
                x += 350;
                mygrid.Children.Add(grid[i]);
            }
            Button b = new Button();

        }
        private void SelectedItembtn_Click(object sender, RoutedEventArgs e)
        {
            var text= Combo.SelectedItem.ToString().Split(' ');
            var Product = text.Last();
            var emp = db.ProductTables.First(x=>x.ProductName== Product);
            emp.productQuntity = count.ToString();
            products.Add(emp);
            DataGridd.ItemsSource = products.ToList();
        }

        private void Plusbtn_Click(object sender, RoutedEventArgs e)
        {
            count++;
            counterlbl.Content = count.ToString();
        }

        private void minusbtn_Click(object sender, RoutedEventArgs e)
        {
            if(count>0)
            {
                count--;
                counterlbl.Content = count.ToString();
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private void DeleteLastItembtn_Click(object sender, RoutedEventArgs e)
        { 
            var prod = products.Last();
            products.Remove(prod);
            DataGridd.ItemsSource = products.ToList();
        }
    }
}
