using CallMessageDemo.InterfaceImplements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CallMessageDemo
{
    public partial class App : Application
    {
        public SinchService sinchService;
        public App()
        {
            InitializeComponent();
            sinchService = new SinchService();
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts            
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
