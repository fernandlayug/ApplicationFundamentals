using Microsoft.Maui.Controls;
using ApplicationFundamentals.Services;

namespace ApplicationFundamentals.View;

public partial class StartPage : ContentPage
{
    private readonly IMyService _myService; // Add a field for the service
    public StartPage(IMyService myService)
	{
		InitializeComponent();

        _myService = myService;

        // Use the service
        InitializePage();

    }

    private void InitializePage()
    {
        // Example usage of the service
        var message = _myService.GetMessage();
        MyLabel.Text = message; // Assuming you have a Label with x:Name="MyLabel" in your XAML
    }
}