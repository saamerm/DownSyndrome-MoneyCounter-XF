using System;

using Xamarin.Forms;

namespace CashCount
{
	/// <summary>
	/// Third page showing how much you should get back.
	/// </summary>
	public class ThirdPage : ContentPage
	{
		public ThirdPage()
		{
			App.Current.MainPage.Title = "hgfjhg";

			Content = new StackLayout
			{
				Children = {
					new Label { Text = "You should get back a total of $5.55" }
				},
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};
		}
	}
}

