using Microsoft.Maui.Controls;
using Microcharts; //chartview
using Microcharts.Maui;
using SkiaSharp; 
using System.Collections.Generic;

namespace ANDROIDAPP
{
    public partial class DashboardPage : ContentPage
    {
        public DashboardPage()
        {
            InitializeComponent();
            LoadChartData();
        }

        private void LoadChartData()
        {
            var entries = new List<ChartEntry>
            {
                new ChartEntry(40) { Label = "Development", ValueLabel = "40h", Color = SKColor.Parse("#4CAF50") },
                new ChartEntry(10) { Label = "Meetings", ValueLabel = "10h", Color = SKColor.Parse("#2196F3") },
                new ChartEntry(5) { Label = "Learning", ValueLabel = "5h", Color = SKColor.Parse("#FFC107") },
                new ChartEntry(2) { Label = "Breaks", ValueLabel = "2h", Color = SKColor.Parse("#FF5722") }
            };
            WorkHoursChart.Chart = new DonutChart
            {
                Entries = entries,
                BackgroundColor = SKColors.Transparent
            };
        }

        private async void OnProfileClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//Profile");
        }

        private async void OnIncomeClicked(object sender, EventArgs e)
        {
            try
            {
                await Shell.Current.GoToAsync("Income"); 
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Unable to navigate to Income page: {ex.Message}", "OK");
            }
        }

        private async void OnVacationsClicked(object sender, EventArgs e)
        {
            try
            {
                await Shell.Current.GoToAsync("Vacations");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Unable to navigate to Vacations page: {ex.Message}", "OK");
            }
        }

    }
}
