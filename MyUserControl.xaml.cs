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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MyUserControl.xaml
    /// </summary>
    public partial class MyUserControl : UserControl
    {
        // На складе
        public int Prod_on_stor
        {
            get { return (int)GetValue(Prod_on_storProperty); }
            set { SetValue(Prod_on_storProperty, value); }
        }

        public static readonly DependencyProperty Prod_on_storProperty =
            DependencyProperty.Register("Prod_on_stor", typeof(int), typeof(MyUserControl), new PropertyMetadata(0));

        // Название
        public string Name_prod
        {
            get { return (string)GetValue(Name_prodProperty); }
            set { SetValue(Name_prodProperty, value); }
        }

        public static readonly DependencyProperty Name_prodProperty =
            DependencyProperty.Register("Name_prod", typeof(string), typeof(MyUserControl), new PropertyMetadata("None"));

        // ИНформация
        public string Info
        {
            get { return (string)GetValue(InfoProperty); }
            set { SetValue(InfoProperty, value); }
        }

        public static readonly DependencyProperty InfoProperty =
            DependencyProperty.Register("Info", typeof(string), typeof(MyUserControl), new PropertyMetadata("None"));

        // Производитель
        public string Manufacturer
        {
            get { return (string)GetValue(ManufacturerProperty); }
            set { SetValue(ManufacturerProperty, value); }
        }

        public static readonly DependencyProperty ManufacturerProperty =
            DependencyProperty.Register("Manufacturer", typeof(string), typeof(MyUserControl), new PropertyMetadata("None"));

        // Цена
        public int Price
        {
            get { return (int)GetValue(PriceProperty); }
            set { SetValue(PriceProperty, value); }
        }

        public static readonly DependencyProperty PriceProperty =
            DependencyProperty.Register("Price", typeof(int), typeof(MyUserControl), new PropertyMetadata(0));

        // Путь к изображению
        public string Path_to_img
        {
            get { return (string)GetValue(Path_to_imgProperty); }
            set { SetValue(Path_to_imgProperty, value); }
        }

        public static readonly DependencyProperty Path_to_imgProperty =
            DependencyProperty.Register("Path_to_img", typeof(string), typeof(MyUserControl), new PropertyMetadata("img\\default.png"));

        public MyUserControl()
        {
            InitializeComponent();
        }
    }
}
