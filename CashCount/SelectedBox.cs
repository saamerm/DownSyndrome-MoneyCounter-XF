using System;
using Xamarin.Forms;
namespace CashCount
{
	public class SelectedBox
	{
		public SelectedBox()
		{
		}

		public AbsoluteLayout Boxes(int outer, int inner)
		{
			var outerBox = new BoxView()
			{
				HeightRequest = outer,
				WidthRequest = outer,
				BackgroundColor = Color.Black,
				Color = Color.Red
			};

			var innerBox = new BoxView()
			{
				HeightRequest = inner,
				WidthRequest = inner,
				BackgroundColor = Color.Green,
				Color = Color.Blue
			};

			AbsoluteLayout.SetLayoutBounds(outerBox, new Rectangle(0.5, 0.25, 25, 100)); //(0, .5, 25, 100));
			AbsoluteLayout.SetLayoutFlags(outerBox, AbsoluteLayoutFlags.All);

			AbsoluteLayout.SetLayoutBounds(innerBox, new Rectangle(0.5, 0.5, 15, 75)); //(0, .5, 25, 100));
			AbsoluteLayout.SetLayoutFlags(innerBox, AbsoluteLayoutFlags.PositionProportional);
			var layout = new AbsoluteLayout();
			layout.Children.Add(outerBox);
			layout.Children.Add(innerBox);

			return layout;
		}
	}
}
