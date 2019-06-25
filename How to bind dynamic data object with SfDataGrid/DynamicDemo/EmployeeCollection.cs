using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Dynamic;

namespace DynamicDemo
{
   public class EmployeeCollection
    {
       
       Random random = new Random();

       #region ItemsSource

       public EmployeeCollection()
        {
            EmployeeDetails = GetEmployeesDetails_Dynamic(50);
        }
       #endregion

       #region ItemsSource

       private ObservableCollection<dynamic> _employeeDetails;
       public ObservableCollection<dynamic> EmployeeDetails
        {
            get
            {
                return _employeeDetails;
            }
            set
            {
                _employeeDetails = value;
                RaisePropertyChanged("EmployeeDetails");
            }
        }

       #endregion

       #region Dynamic DataSource

       public ObservableCollection<dynamic> GetEmployeesDetails_Dynamic(int count)
        {
            var employees = new ObservableCollection<dynamic>();
            for (int i = 1; i <= count; i++)
            {
                employees.Add(GetDynamicEmployee(i));
            }
            return employees;
        }

       #endregion

       #region Dynamic Property

       public dynamic GetDynamicEmployee(int i)
        {
            dynamic employee = new ExpandoObject();
            employee.EmployeeName = employeeName[random.Next(14)];
            employee.EmployeeID = i;
            employee.ContactID = i + 100;
            return employee;
        }
        #endregion

       #region ItemsSource

       string[] employeeName = new string[]
        {
            "Sean Jacobson",
            "Phyllis Allen",
            "Marvin Allen",
            "Michael Allen",
            "Cecil Allison",
            "Oscar Alpuerto",
            "Sandra Altamirano",
            "Selena Alvarad",
            "Emilio Alvaro",
            "Maxwell Amland",
            "Mae Anderson",
            "Ramona Antrim",
            "Sabria Appelbaum",
            "Hannah Arakawa",
        };
       #endregion

       #region Property Changed

       public event PropertyChangedEventHandler PropertyChanged;
       public void RaisePropertyChanged(string propertyName)
       {
            if (PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
       }
       #endregion
    }

   
}