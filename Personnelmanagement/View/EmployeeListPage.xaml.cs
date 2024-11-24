using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Policy;
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

namespace Personnelmanagement.View
{
    /// <summary>
    /// Логика взаимодействия для EmployeeListPage.xaml
    /// </summary>
    public partial class EmployeeListPage : Page
    {
        public EmployeeListPage()
        {
            InitializeComponent();
            EmployeeGrid.ItemsSource = employee;



        }

        public ObservableCollection<Employee> employee = new ObservableCollection<Employee>
        {
                new Employee {  Name="Боб", Position="Босс" },
        };




        public void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            
        }



        private void Edit(object sender, RoutedEventArgs e)
        {
            if (EmployeeGrid.SelectedItem != null)
            {
                var selectedEmployee = (Employee)EmployeeGrid.SelectedItem;
                EmployeeEditPage editPage = new EmployeeEditPage(selectedEmployee , this);
                NavigationService.Navigate(editPage);
            }
            else 
            {
                MessageBox.Show("выберите сотрудника");
            }
        }
    }
}
