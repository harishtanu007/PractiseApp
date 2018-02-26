using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PractiseApp
{
    public partial class LoginPage : ContentPage
    {
      

        public LoginPage()
        {
            InitializeComponent();
            var MyEntry = new Entry { Placeholder = "Username" };
        }
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            if(username.Text.Trim()=="Harish" && password.Text=="12345")
            {
                DisplayAlert("Success!","You have entered valid Credentials","OK!");

                    Navigation.PushAsync(new UserDetailPage(username.Text, password.Text));
               // SaveCredentials(username.Text,password.Text);
            }
            else
            {
                DisplayAlert("Failure!","You have entered wrong Credentials","Try again!");
            }
        }

    }
}
