using RestMaui.Services;

namespace RestMaui;

public partial class CreateEmployee : ContentPage
{
    public CreateEmployee()
    {
        InitializeComponent();
    }

    private async void Create_Clicked(object sender, EventArgs e)
    {
        var service = new EmployeeService("https://localhost:7252/");
        var added = await service.CreateEmployee(new Models.Employee
        {
            Address = Address.Text,
            Email = Email.Text,
            FirstName = FirstName.Text,
            Gender = Gender.Text,
            LastName = LastName.Text,
        });
        Message.Text = added ? "Added" : "Error";
        Message.IsVisible = true;        
    }
    private async void Back_Clicked(object sender, EventArgs e)
    {
        //Navigation.PushAsync(
    }
}