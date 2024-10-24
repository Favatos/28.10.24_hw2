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

namespace task2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MonthSale[] monthsales = { new MonthSale(300, "2024 ноябрь"), new MonthSale(100, "2024 декабрь"), new MonthSale(240, "2024 январь") };
        public MainWindow()
        {
            InitializeComponent();
      
            rect1.Height = monthsales[0].Sales;
            text1.Text = monthsales[0].Date;

            rect2.Height = monthsales[1].Sales;
            text2.Text = monthsales[1].Date;

            rect3.Height = monthsales[2].Sales;
            text3.Text = monthsales[2].Date;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}