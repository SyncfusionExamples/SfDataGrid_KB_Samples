using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Syncfusion.SfDataGrid;

namespace DynamicDemo
{
    [Activity(Label = "DynamicDemo", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        SfDataGrid dataGrid;
        EmployeeCollection employeeCollection;
       
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            LinearLayout linear = new LinearLayout(this);
            linear.Orientation = Orientation.Vertical;
            dataGrid = new SfDataGrid(this);
            dataGrid.ColumnSizer = ColumnSizer.Star;
            employeeCollection = new EmployeeCollection();
            dataGrid.ItemsSource = employeeCollection.EmployeeDetails;
            linear.AddView(dataGrid);
            SetContentView(linear);
           
        }
    }
}

