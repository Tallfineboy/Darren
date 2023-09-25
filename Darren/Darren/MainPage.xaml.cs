using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Darren
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			Navigation.PushModalAsync(new RegisterationPage());
		}

		private void Button_Clicked_1(object sender, EventArgs e)
		{
			
		}

		private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
		{
			Navigation.PushModalAsync(new ForgotPasswordPage());
		}

		private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
		{
			Navigation.PushModalAsync( new Tac());
		}

		private void Button_Clicked_2(object sender, EventArgs e)
		{

		}
	}
}
