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

        private void TimePicker_Focused(object sender, FocusEventArgs e)
        {
            Application.Current.MainPage.DisplayAlert("TimePicker", "TimePicker Focused", "OK");
        }

        private void TimePicker_Unfocused(object sender, FocusEventArgs e)
        {
            Application.Current.MainPage.DisplayAlert("TimePicker", "TimePicker Unfocused", "OK");
        }
    }

}
