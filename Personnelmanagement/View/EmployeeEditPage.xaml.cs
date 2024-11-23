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

namespace Personnelmanagement.View
{
    /// <summary>
    /// Логика взаимодействия для EmployeeEditPage.xaml
    /// </summary>
    public partial class EmployeeEditPage : Page
    {

        private Employee employees;

        public EmployeeEditPage(Employee employee)
        {
            InitializeComponent();
            employees = employee;
            Name.Text = employees.Name;
            Position.Text = employees.Position;
            Phone.Text = Convert.ToString(employees.Phone);
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            employees.Name = Name.Text;
            employees.Position = Position.Text;
            employees.Phone = int.Parse(Phone.Text);

            this.NavigationService.GoBack();

        }
    }
}
