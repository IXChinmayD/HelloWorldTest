using HelloWorldTest.Model;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace HelloWorldTest
{
    public partial class MainPage : ContentPage
    {
        string jsonString = "";
        public MainPage()
        {
            InitializeComponent();
         
        }

        private void DatePicker_Focused(object sender, FocusEventArgs e)
        {
            Application.Current.MainPage.DisplayAlert("DatePicker", "DatePicker Focused", "OK");
        }

        private void DatePicker_Unfocused(object sender, FocusEventArgs e)
        {
            Application.Current.MainPage.DisplayAlert("DatePicker", "DatePicker Unfocused", "OK");
        }
    }

}
