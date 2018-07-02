using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace CashCount
{
	public partial class App : Application
	{
		public static float numeric1 = 0;
		public App()
		{
			//InitializeComponent();
			MainPage = new InitialPage();
			MainPage.Title = "Yeah";
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
