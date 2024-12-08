﻿using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        private string APIKey = "9f0b0edb7acc7f63b7646b101031a44a";

        public Form1()
        {
            InitializeComponent();

            // Set the FormBorderStyle to FixedDialog to make the window non-resizable
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;  // Optional: Prevent maximizing the window
            this.MinimizeBox = true;   // Optional: Allow minimizing
        }

        private async void btn_Search_Click(object sender, EventArgs e)
        {
            string city = tB_City.Text.Trim();

            if (string.IsNullOrEmpty(city))
            {
                MessageBox.Show("Please enter a city name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                await GetWeatherDataAsync(city);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task GetWeatherDataAsync(string city)
        {
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={APIKey}&units=metric";

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    WeatherInfo.root weatherInfo = JsonConvert.DeserializeObject<WeatherInfo.root>(jsonResponse);
                    
                    // Update UI with weather data
                    lab_Condition.Text = weatherInfo.weather[0].main;
                    string dtls = weatherInfo.weather[0].description;
                    lab_Details.Text = char.ToUpper(dtls[0]) + dtls.Substring(1); 
                    lab_Temp.Text = $"{Math.Round(weatherInfo.main.temp)}°C";
                    lab_WindSpeed.Text = $"{weatherInfo.wind.speed} m/s";
                    lab_Pressure.Text = $"{weatherInfo.main.pressure} hPa";

                    DisplaySunriseAndSunset(weatherInfo.sys.sunrise, weatherInfo.sys.sunset, weatherInfo.timezone);

                    LoadWeatherIcon(weatherInfo.weather[0].icon);

                }
                else
                {
                    MessageBox.Show("Place not found or API request failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void LoadWeatherIcon(string iconCode)
        {
            string localIconPath = @"C:\Users\janic\Desktop\a\WeatherApp\src\icons\" + iconCode + ".png";

            if (File.Exists(localIconPath))
            {
                picIcon.ImageLocation = localIconPath; 
            }
            else
            {
                picIcon.ImageLocation = @"C:\Users\janic\Desktop\a\WeatherApp\src\icons\default.png";
            }
        }

        public DateTime ConvertUnixToLocalTime(long unixTimestamp, long timezoneOffset)
        {
            DateTime utcDateTime = DateTimeOffset.FromUnixTimeSeconds(unixTimestamp).UtcDateTime;

            DateTime localDateTime = utcDateTime.AddSeconds(timezoneOffset);

            return localDateTime;
        }
        public void DisplaySunriseAndSunset(long sunrise, long sunset, long timezoneOffset)
        {
            // Convert UNIX timestamps for sunrise and sunset to local time
            DateTime localSunrise = ConvertUnixToLocalTime(sunrise, timezoneOffset);
            DateTime localSunset = ConvertUnixToLocalTime(sunset, timezoneOffset);

            lab_Sunrise.Text = localSunrise.ToString("hh:mm tt");
            lab_Sunset.Text = localSunset.ToString("hh:mm tt");
        }

    }
}

