namespace PRG1_MAUI_ERP_Activum.View;
using PRG1_MAUI_ERP_Activum.Model;
using System.Diagnostics;

public partial class SalaryPage : ContentPage
{
	public SalaryPage()
	{
		InitializeComponent();
		int CurrentUser = SalaryPageClass.CurrentUser;
		Debug.WriteLine(CurrentUser);

    }
}