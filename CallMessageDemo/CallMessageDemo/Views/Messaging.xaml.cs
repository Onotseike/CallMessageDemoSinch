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
    public partial class Messaging : ContentPage
    {
        List<string> Lister;
        private SinchService sinchService;
        private string v;
        private string reciepientId;

        public Messaging()
        {
            Lister = new List<string>();
            InitializeComponent();
           // msgThread.ItemsSource = Lister;
        }

        public Messaging(SinchService sinchService, string reciepientId)
        {
            InitializeComponent();
            this.sinchService = sinchService;
            this.reciepientId = reciepientId;
        }

       
    }
}