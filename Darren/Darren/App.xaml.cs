using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Darren
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new OnboardingPage();
		}

		protected override void OnStart()
		{
		   new OnboardingPage();
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
