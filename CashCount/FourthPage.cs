using System;

using Xamarin.Forms;

namespace CashCount
{
	/// <summary>
	/// Fourth page showing Hoow much you did get back.
	/// </summary>
	public class FourthPage : ContentPage
	{
		public FourthPage()
		{
			Content = new StackLayout
			{
				Children = {
					new Label { Text = "Hello ContentPage4" }
				},
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};
			App.Current.MainPage.Title = "knhgfg";
		}
	}
}

