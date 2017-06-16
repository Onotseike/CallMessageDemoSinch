using CallMessageDemo.InterfaceImplements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CallMessageDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecipientPage : ContentPage
    {
        SinchService sinchService;
        public RecipientPage()
        {
            InitializeComponent();
        }

        public RecipientPage(SinchService sinchService)
        {
            InitializeComponent();
            this.sinchService = sinchService;
            userId.Text = sinchService.GetUserId();
        }

        private void imBtn_Clicked(object sender, EventArgs e)
        {
           
                LaunchIMAsync();
            
        }

        private void videoCallBtn_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(reciepientId.Text))
            {
                LaunchVideoAsync();
            }
        }

        private void voiceCallBtn_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(reciepientId.Text))
            {
                LaunchVoiceAsync();
            }
        }

        private void LaunchIMAsync()
        {
            Navigation.PushAsync(new Messaging(sinchService, reciepientId.Text));
        }

        private void LaunchVoiceAsync()
        {
            Navigation.PushAsync(new CallPage(sinchService, reciepientId.Text, voiceCallBtn.Text));
        }

        private void LaunchVideoAsync()
        {
            Navigation.PushAsync(new CallPage(sinchService, reciepientId.Text, videoCallBtn.Text));
        }
    }
}