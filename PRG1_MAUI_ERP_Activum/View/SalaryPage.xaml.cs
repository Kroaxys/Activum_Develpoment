namespace PRG1_MAUI_ERP_Activum.View;
using PRG1_MAUI_ERP_Activum.Model;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text.Json;

public partial class SalaryPage : ContentPage
{
    Employee employee;
    string path;
	public SalaryPage()
	{
		InitializeComponent();
        GetPath();
        Load();
        Serve();
    }

    //We Need To Convert It To Something That Can Handle The Json File
    private void GetPath()
    {
        path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "Storage", "UserData.json");
    }
	private void Load()
	{
        string json = File.ReadAllText(path);
        ObservableCollection<Employee> employees = JsonSerializer.Deserialize<ObservableCollection<Employee>>(json);
        employee = employees[SalaryPageClass.CurrentUser];
        Debug.WriteLine(employee.Name);
        Debug.WriteLine(employee.BaseSalary);
        Debug.WriteLine(json);
    }
    private void Serve()
    {
        CommissionEarnedThisMonthLabel.Text = employee.CommissionEarnedThisMonth.ToString();
        CommissionRateLabel.Text = employee.CommissionRate.ToString();
        BaseSalaryLabel.Text = employee.BaseSalary.ToString();
        TotalEarnedThisYearLabel.Text = employee.TotalEarnedThisYear.ToString();
    }
}