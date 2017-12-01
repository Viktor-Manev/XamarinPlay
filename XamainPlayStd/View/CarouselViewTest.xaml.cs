using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamainPlayStd.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CarouselViewTest : ContentPage
	{
		public CarouselViewTest ()
		{
			InitializeComponent ();

            Title = "Carosel View Demo";

            try
            {
                 carouselView.ItemsSource = new List<int> { 1, 2, 3, 3 };
                 carouselView.ItemTemplate =  new DataTemplate(typeof(CarouselTemplate));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
         

        }
	}
}