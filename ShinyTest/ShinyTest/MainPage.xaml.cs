using Shiny;
using Shiny.Jobs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ShinyTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var result = await ShinyHost.Resolve<IJobManager>().RunAll();//System.Threading.CancellationToken.None);
            var success = result.FirstOrDefault().Success ? "Success" : "Fail";

            await this.DisplayAlert("Job Done", "Yay!! " + success, "Ok");
        }
    }
}
