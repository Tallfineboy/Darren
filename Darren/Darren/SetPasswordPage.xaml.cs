﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Darren
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SetPasswordPage : ContentPage
	{
		public SetPasswordPage()
		{
			InitializeComponent();
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			Navigation.PushModalAsync(new MainPage());
        }

		private void Button_Clicked_1(object sender, EventArgs e)
		{
			Navigation.PushModalAsync(new ForgotPasswordPage());
        }
    }
}