using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace PRG1_MAUI_ERP_Activum.View;

public partial class CalculatorPage : ContentPage
{
    double FirstNumber;
    double LastNumber;
    string HiddenOperator;
    double HiddenNumber;
    public CalculatorPage()
	{
		InitializeComponent();
	}

    private void OnNumberClicked(object sender, EventArgs e)
    {
        Button OnNumberClicked = (Button)sender;
        DisplayLabel.Text += OnNumberClicked.Text;
        HiddenOperator += OnNumberClicked.Text;

    }

    public void OnOperatorClicked(object sender, EventArgs e)
    {
        if (!double.TryParse(HiddenOperator, out double working))
        {
            DisplayLabel.Text = "Error: Invalid Input";
            return;
        }
        if (HiddenOperator.Contains("+"))
        {
            DisplayLabel.Text = "Error: No Number Entered";
            return;
        }

        FirstNumber = working;
        Button OnOperatorClicked = (Button)sender;
        DisplayLabel.Text += OnOperatorClicked.Text;
        HiddenOperator = "";
    }

    public void OnCalculateClicked(object sender, EventArgs e)
    {
        if (!double.TryParse(HiddenOperator, out double working))
        {
            DisplayLabel.Text = "Error: Invalid Input";
            return;
        }
        LastNumber = working;
        Button OnCalculateClicked = (Button)sender;
        DisplayLabel.Text += OnCalculateClicked.Text;


        if (DisplayLabel.Text.Contains("+"))
        {
            DisplayLabel.Text = (FirstNumber + LastNumber).ToString();
            if (HiddenNumber != 0)
            {
                DisplayLabel.Text = (HiddenNumber + LastNumber).ToString();
                HiddenNumber = double.Parse(DisplayLabel.Text);
            }
            else
            {
                HiddenNumber = double.Parse(DisplayLabel.Text);
            }
        }
        else if (DisplayLabel.Text.Contains("-"))
        {
            DisplayLabel.Text = (FirstNumber - LastNumber).ToString();
            if (HiddenNumber != 0)
            {
                DisplayLabel.Text = (HiddenNumber - LastNumber).ToString();
                HiddenNumber = double.Parse(DisplayLabel.Text);
            }
            else
            {
                HiddenNumber = double.Parse(DisplayLabel.Text);
            }
        }
        else if (DisplayLabel.Text.Contains("×"))
        {
            if (LastNumber == 0)
            {
                FirstNumber = 0;
            }

            DisplayLabel.Text = (FirstNumber * LastNumber).ToString();
            if (HiddenNumber != 0)
            {
                DisplayLabel.Text = (HiddenNumber * LastNumber).ToString();
                HiddenNumber = double.Parse(DisplayLabel.Text);
            }
            else
            {
                HiddenNumber = double.Parse(DisplayLabel.Text);
            }
        }
        else if (DisplayLabel.Text.Contains("/"))
        {
            DisplayLabel.Text = (FirstNumber / LastNumber).ToString();
            if (HiddenNumber != 0)
            {
                DisplayLabel.Text = (HiddenNumber / LastNumber).ToString();
                HiddenNumber = double.Parse(DisplayLabel.Text);
            }
            else
            {
                HiddenNumber = double.Parse(DisplayLabel.Text);
            }
        }



    }
    public void OnClearClicked(object sender, EventArgs e)
    {
        DisplayLabel.Text = "";
        FirstNumber = 0;
        LastNumber = 0;
        HiddenOperator = "";
        HiddenNumber = 0;
    }

}