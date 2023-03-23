using RestMaui.Models;
using System.Net.Http.Json;

namespace RestMaui.Services
{
    internal class EmployeeService
    {
        private static HttpClient _httpClient = new();
        private readonly string _baseUrl;

        public EmployeeService(string baseUrl)
        {
            _baseUrl = baseUrl;
            _httpClient.BaseAddress = new Uri(_baseUrl);
        }
        public async Task<List<Employee>> GetAll()
        {
            //var response = await _httpClient.GetAsync("api/Employees");
            //var content = await response.Content.ReadFromJsonAsync<Result<List<Employee>>>();
            var content = await _httpClient.GetFromJsonAsync<Result<List<Employee>>>("api/Employees");
            return content.Content;
        }

        public async Task<bool> CreateEmployee(Employee employee)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Employees", employee);
            return response.IsSuccessStatusCode;
        }
    }
}
