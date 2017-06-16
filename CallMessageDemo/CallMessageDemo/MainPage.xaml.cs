using CallMessageDemo.InterfaceImplements;
using CallMessageDemo.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CallMessageDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        SinchService sinchService;
        public MainPage()
        {
            InitializeComponent();
            sinchService = new SinchService();            
        }



        private async void loginBtn_Clicked(object sender, EventArgs e)
        {
            string userId = usernameId.Text;
            if (userId != null)
            {
                sinchService.StartSinchClient(userId);
                while (!IsSinchStarted())
                {
                    progress.Text = "Please wait app is starting to sinch service...";
                    await Task.Delay(500);
                }

                Debug.WriteLine(sinchService.IsSinchClientStarted().ToString());
                LaunchReciepientAsync();

            }

        }

        private  void LaunchReciepientAsync()
        {            
           Navigation.PushAsync(new RecipientPage(sinchService));
        }
        private bool IsSinchStarted()
        {
            return sinchService.IsSinchClientStarted();
        }
    }
}
