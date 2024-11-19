using System;
using Microsoft.Maui.Controls;

namespace ANDROIDAPP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            try
            {
                string employeeId = EmployeeIDEntry.Text;
                string password = PasswordEntry.Text;

                if (string.IsNullOrWhiteSpace(employeeId) || string.IsNullOrWhiteSpace(password))
                {
                    await DisplayAlert("Error", "Please enter both Employee ID and Password.", "OK");
                    return;
                }

                if (employeeId == "01001070968" && password == "123456789")
                {
                    Application.Current.MainPage = new AppShell();
                }
                else
                {
                    await DisplayAlert("Error", "Invalid Employee ID or Password.", "OK");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"An unexpected error occurred: {ex.Message}", "OK");
            }
        }




        private void OnCancelButtonClicked(object sender, EventArgs e)
        {
            System.Environment.Exit(0); //gamosvla..
        }
    }
}
