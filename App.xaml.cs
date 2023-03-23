namespace RestMaui;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        //MainPage = new Rest();
        //MainPage = new CreateEmployee();
        MainPage = new ListEmployees();
    }
}
