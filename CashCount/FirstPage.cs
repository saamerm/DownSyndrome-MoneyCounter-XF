using System;

using Xamarin.Forms;

namespace CashCount
{
	/// <summary>
	/// First page showing how much do you have to pay.
	/// </summary>
	public class FirstPage : ContentPage
	{
		#region Fields
		Entry entry = new Entry()
		{
			FontSize = 20,
			HeightRequest = 100,
			WidthRequest = 100,
			Keyboard = Keyboard.Numeric
		};

		Label errorLabel = new Label()
		{
			Text = "You can only have numeric characters!",
			FontSize = 12,
			TextColor = Color.Red,
			IsVisible = false
		};
		#endregion Fields


		#region Constructor
		public FirstPage()
		{

			//var box1 = new BoxView()
			//{
			//	HeightRequest = 50,
			//	WidthRequest = 50
			//};
			//var box = new SelectedBox();

			Title = "Payment Amount";
			var entryLabel = new Label()
			{
				Text = "How much do you have to pay?",

			};


			entry.TextChanged += Entry_TextChanged;

			var swipeLabel = new Label()
			{
				Text = "Swipe to the right once done"
			};
			var stack = new StackLayout()
			{
				Children = {
					entryLabel,
					entry,
					errorLabel,
					swipeLabel
				},
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};

			Content = stack;
		}
		#endregion Constructor

		#region Events
		void Entry_TextChanged(object sender, TextChangedEventArgs e)
		{
			float.TryParse(entry.Text, out float x);
			App.numeric1 = x;
			if (entry.Text != string.Empty && x == 0f)
				errorLabel.IsVisible = true;
			else
				errorLabel.IsVisible = false;
		}
		#endregion Events
	}
}

