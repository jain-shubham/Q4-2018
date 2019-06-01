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

namespace ExpenseIT
{
    /// <summary>
    /// Interaction logic for DemoHome.xaml
    /// </summary>
    public partial class DemoHome : Page
    {
        public DemoHome()
        {
            InitializeComponent();
        }

        private void ViewReport(object sender, RoutedEventArgs e)
        {
            // View Expense Report
            ExpenseReport expenseReportPage = new ExpenseReport(this.peopleListBox.SelectedItem);
            this.NavigationService.Navigate(expenseReportPage);

        }
    }
}
