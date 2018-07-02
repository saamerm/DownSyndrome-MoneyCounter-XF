using System;

using Xamarin.Forms;

namespace CashCount
{
	/// <summary>
	/// Second page showing how much you're about to pay and if that will be enough.
	/// </summary>
	public class SecondPage : ContentPage
	{
		#region Fields
		//Application.Current.MainPage.Title = "345";
		int pressedNumber;
		Label label = new Label()
		{
			Text = "0",
			TextColor = Color.Green,
			BackgroundColor = Color.White,
			WidthRequest = 80,
			HeightRequest = 80,
			FontSize = 40,
		};
		#endregion Fields

		public SecondPage()
		{
			var line = new BoxView()
			{
				HeightRequest = 3,
				WidthRequest = App.Current.MainPage.Width,
				Color = Color.Red,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};
			var button1 = buttonCreator("1");
			var button2 = buttonCreator("2");
			var button3 = buttonCreator("3");
			var button4 = buttonCreator("4");
			var button5 = buttonCreator("5");
			var button6 = buttonCreator("6");
			var button7 = buttonCreator("7");
			var button8 = buttonCreator("8");
			var button9 = buttonCreator("9");
			var button0 = buttonCreator("0");
			var buttonPeriod = buttonCreator(".");
			var buttonBackSpace = buttonCreator("<=");
			var row1 = new StackLayout
			{
				Children = { button1, button2, button3 },
				Orientation = StackOrientation.Horizontal
			};
			var row2 = new StackLayout
			{
				Children = { button4, button5, button6 },
				Orientation = StackOrientation.Horizontal
			};
			var row3 = new StackLayout
			{
				Children = { button7, button8, button9 },
				Orientation = StackOrientation.Horizontal
			};
			var row4 = new StackLayout
			{
				Children = { buttonPeriod, button0, buttonBackSpace },
				Orientation = StackOrientation.Horizontal
			};
			var calculator = new StackLayout
			{
				Children = {
					label, line, row1, row2, row3, row4
				},
				Padding = 5,
				Margin = 5
			};
			var stack = new StackLayout()
			{
				Children = {
					calculator
				},
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				Padding = 20,
				Margin = 20
			};

			Content = stack;
		}

		public Button buttonCreator(string x)
		{
			var button = new Button()
			{
				Text = x,
				TextColor = Color.Blue,
				BackgroundColor = Color.White,
				WidthRequest = 60,
				HeightRequest = 60,
				FontSize = 30,
				BorderWidth = 1,
				BorderColor = Color.Blue
			};
			button.Clicked += Button_Clicked;
			return button;
		}

		void Button_Clicked(object sender, EventArgs e)
		{
			Button x = (Button)sender;
			Label.
			pressedNumber = Int32.Parse(x.Text);
		}

	}
}

