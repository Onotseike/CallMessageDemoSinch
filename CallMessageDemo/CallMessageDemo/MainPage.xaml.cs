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
    public partial class MainPage : ContentPage
    {
        SinchService sinchService;
        public MainPage()
        {

            InitializeComponent();
                       
        }



        private void loginBtn_Clicked(object sender, EventArgs e)
        {
            sinchService = new SinchService();
            string userId = usernameId.Text;
            if (userId != null)
            {                          
                if (!sinchService.IsSinchClientStarted())
                {
                    sinchService.StartSinchClient(userId);
                }
                else
                {
                    Debug.WriteLine(sinchService.IsSinchClientStarted().ToString());
                    LaunchReciepientAsync();
                }


            }

        }

        private  void LaunchReciepientAsync()
        {            
           Navigation.PushAsync(new RecipientPage(usernameId.Text.ToString()));
        }
    }
}
