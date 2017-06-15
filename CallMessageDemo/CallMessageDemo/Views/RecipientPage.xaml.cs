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
        private string userId;

        public RecipientPage()
        {
            InitializeComponent();
        }

        public RecipientPage(string userId)
        {
            this.userId = userId;
            InitializeComponent();
        }
    }
}