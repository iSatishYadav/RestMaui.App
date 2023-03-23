using RestMaui.Models;
using RestMaui.Services;
using System.Collections.ObjectModel;

namespace RestMaui;

public partial class ListEmployees : ContentPage
{
    private ObservableCollection<Employee> employees;    

    public ListEmployees()
	{
		InitializeComponent();
        BindingContext = this;
	}
    public ObservableCollection<Employee> Employees
    {
        get => employees;
        set { employees = value; OnPropertyChanged(); }
    }    

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        var service = new EmployeeService("https://localhost:7252/");
        var employees = await service.GetAll();
        Employees = new ObservableCollection<Employee>(employees);
        EmployeeListView.ItemsSource = Employees;
    }

    private void Create_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new CreateEmployee());
    }
}