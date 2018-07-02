using System;

using Xamarin.Forms;

namespace CashCount
{
	public class CounterPages : CarouselPage
	{
		public CounterPages()
		{
			var a = new FirstPage();
			var b = new SecondPage();
			var c = new ThirdPage();
			var d = new FourthPage();
			a.Title = "Amount To Pay";
			Children.Add(a);
			Children.Add(b);
			Children.Add(c);
			Children.Add(d);
		}
	}
}

