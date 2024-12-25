using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<MyUserControl> all_products = new List<MyUserControl>()
            {
                new MyUserControl{ Name_prod = "Иконка", Info = "Просто иконка", Manufacturer = "Icon inc", Price = 399, Path_to_img = "img\\prod1.png", Prod_on_stor = 17, Margin=new Thickness(10) },
                new MyUserControl{ Name_prod = "Варежки", Info = "Синие и тёплые", Manufacturer = "Icon inc", Price = 1999, Path_to_img = "img\\prod2.jpg", Prod_on_stor = 23, Margin=new Thickness(10) },
                new MyUserControl{ }
            };
        ObservableCollection<MyUserControl> need_products = new ObservableCollection<MyUserControl>();
        List<string> manufacturers = new List<string>();
        public MainWindow()
        {
            need_products = new ObservableCollection<MyUserControl>(all_products);
            InitializeComponent();
            Products.ItemsSource = need_products;
            List<string> manufacturers = all_products.Select(e => e.Manufacturer).Distinct().ToList();
            manufacturers.Insert(0, "Все производители");
            combobox_manu.ItemsSource = manufacturers;
        }

        private void EditListProducts(object sender, SelectionChangedEventArgs e)
        {
            filtr_products();
        }

        private void textbox_name_and_info_TextChanged(object sender, TextChangedEventArgs e)
        {
            filtr_products();
        }

        private void filtr_products()
        {
            string searchTerm = textbox_name_and_info.Text.ToLower();
            string selectedManufacturer = (string)combobox_manu.SelectedItem;
            var a = all_products.Where(p => (string.IsNullOrEmpty(searchTerm) || p.Name_prod.ToLower().Contains(searchTerm) || p.Info.ToLower().Contains(searchTerm)) && ((string.IsNullOrEmpty(selectedManufacturer) || p.Manufacturer == selectedManufacturer || selectedManufacturer == "Все производители")));
            if (combobox_price.SelectedIndex == 1)
                a = a.OrderBy(e => e.Price);
            need_products.Clear();
            foreach (var i in a)
                need_products.Add(i);
        }
    }
}