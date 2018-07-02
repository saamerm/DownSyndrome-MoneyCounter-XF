using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CashCount
{
	public class InitialPage : ContentPage
	{
		int x = 0;
		public InitialPage()
		{
			Title = "hu";
			var label = new Label()
			{
				Text = "Welcome to the app, tap the button to continue"
			};
			var button = new Button()
			{
				Text = "Continue Here"
			};
			var stack = new StackLayout()
			{
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				Padding = 5,
				Margin = 5
			};

			stack.Children.Add(label);
			stack.Children.Add(button);
			button.Clicked += Button_Clicked;
			Content = stack;
		}

		void Button_Clicked(object sender, EventArgs e)
		{
			Application.Current.MainPage = new CounterPages();
			Application.Current.MainPage.Title = "sdfgh";
			App.Current.MainPage.Title = "hgfg";
		}

	}
}
