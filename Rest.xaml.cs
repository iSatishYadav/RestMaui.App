using RestMaui.Models;
using System.Collections.ObjectModel;
using System.Net.Http.Json;

namespace RestMaui;

public partial class Rest : ContentPage
{
    private static readonly HttpClient _httpClient = new();
    private ObservableCollection<User> users;

    public ObservableCollection<User> Users
    {
        get => users;
        set { users = value; /*OnPropertyChanged();*/ }
    }
    public Rest()
    {
        InitializeComponent();
        BindingContext = this;
    }    

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        var users = await _httpClient.GetFromJsonAsync<List<User>>("https://jsonplaceholder.typicode.com/users");
        Users = new ObservableCollection<User>(users);
        UserListView.ItemsSource = Users;
    }
}