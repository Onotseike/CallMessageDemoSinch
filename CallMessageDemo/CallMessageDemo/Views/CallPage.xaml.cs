using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallMessageDemo.InterfaceImplements;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CallMessageDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CallPage : ContentPage
    {
        private SinchService sinchService;
        private string text1;
        private string text2;

        public CallPage()
        {
            InitializeComponent();
        }

        public CallPage(SinchService sinchService, string text1, string text2)
        {
            this.sinchService = sinchService;
            this.text1 = text1;
            this.text2 = text2;
        }
    }
}