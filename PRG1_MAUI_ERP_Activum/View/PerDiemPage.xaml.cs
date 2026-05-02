namespace PRG1_MAUI_ERP_Activum.View;

public partial class PerDiemPage : ContentPage
{
    DateTime startDate;
    DateTime endDate;
    int frukost;
    int lunch;
    int middag;
    int Distance;
    string carType;
    string money;
    public PerDiemPage()
	{
		InitializeComponent();
		CarPicker.Items.Add("Egen bil");
        CarPicker.Items.Add("Förmånsbil som drivs helt med el");
        CarPicker.Items.Add("Förmånsbil som inte drivs helt med el");
    }

    private void SubmitButtonClicked(object sender, EventArgs e)
    {
        startDate = StartDatePicker.Date.Value;
        endDate = EndDatePicker.Date.Value;
        frukost = int.Parse(FrukostEntry.Text);
        lunch = int.Parse(LunchEntry.Text);
        middag = int.Parse(MiddagEntry.Text);
        Distance = int.Parse(DistanceEntry.Text);
        carType = CarPicker.SelectedItem.ToString();
    }

    private void CalculateMoney()
    {
            
    }
}