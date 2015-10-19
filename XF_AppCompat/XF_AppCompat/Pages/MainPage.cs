using System;
using Xamarin.Forms;

namespace XF_AppCompat.Pages
{
	public class MainPage : Xamarin.Forms.MasterDetailPage
	{
		public MainPage ()
		{

			var menuPageContent = new StackLayout {
				VerticalOptions = LayoutOptions.Center,
			};

			menuPageContent.Children.Add (new Label {
				Text = "Menu Drawer",
				TextColor = Color.Black,
				HorizontalOptions = LayoutOptions.Center
			});

			var menuPage = new ContentPage { Content = menuPageContent, Title = "Menu Drawer"
			};

			Master = menuPage;


			var detailPageContent = new StackLayout { VerticalOptions = LayoutOptions.Center };

			detailPageContent.Children.Add (new Label {
				Text = "Landing Page",
				TextColor = Color.Black,
				HorizontalOptions = LayoutOptions.Center
			});

			var detailPage = new ContentPage { Content = detailPageContent, Title = "Home" };


			Detail = new NavigationPage (detailPage);

		}
	}
}

