using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net;
using XamainPlayStd;

namespace XamarinPlay
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            XamainPlayStd.Model.MainViewModel mainViewModel = new XamainPlayStd.Model.MainViewModel() { FullName = "Viktor Manev" };
            InitializeComponent();
            BindingContext = mainViewModel;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

          //  var httpClient = new System.Net.Http.HttpClient();

            try
            {
             // System.Net.Http.HttpResponseMessage result = await httpClient.GetAsync("https://reqres.in/api/");

                //   RestSharp.RestClient restClient = new RestSharp.RestClient("https://reqres.in/api/");

                //  var res =   restClient.Execute(new RestSharp.RestRequest("users" , RestSharp.Method.GET));

               // var result2 = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/posts");

               // Console.WriteLine(result2);

                //await Navigation.PushAsync(new MasterDetailPage1());

               // Console.WriteLine(result.Content);
              //  Console.WriteLine(res.Content);

            }
            catch (Exception ex)
            {
             
            }

         
        }
        
    }
}
