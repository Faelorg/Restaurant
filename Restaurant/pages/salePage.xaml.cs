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

namespace Restaurant.pages
{
    /// <summary>
    /// Логика взаимодействия для salePage.xaml
    /// </summary>
    public partial class salePage : Page
    {
        private entities _context = entities.GetContext();
        public salePage()
        {
            InitializeComponent();
            dtgItems.ItemsSource = _context.Product1.ToList();
        }

        private void btnPay_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSuspend_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Global.frm.GoBack();
        }
    }
}
