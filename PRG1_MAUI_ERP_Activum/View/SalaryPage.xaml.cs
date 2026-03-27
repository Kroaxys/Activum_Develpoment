namespace PRG1_MAUI_ERP_Activum.View;
using PRG1_MAUI_ERP_Activum.Model;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text.Json;

public partial class SalaryPage : ContentPage
{
    string path;
	public SalaryPage()
	{
		InitializeComponent();
		int CurrentUser = SalaryPageClass.CurrentUser;
		Debug.WriteLine(CurrentUser);
        string basePath = Directory.GetCurrentDirectory();
        string shortendPath = Directory.GetParent(basePath).Parent.Parent.Parent.FullName;
        path = Path.Combine(shortendPath, "Storage", "UserData.json");
        Debug.WriteLine(path);
        Load();
    }

	private void Load()
	{
        string json = File.ReadAllText(path);
        //ObservableCollection<Employee> employees = JsonSerializer.Deserialize<ObservableCollection<Employee>>(json);
        //Debug.WriteLine(employees[0]);
        Debug.WriteLine(json);
    }
}