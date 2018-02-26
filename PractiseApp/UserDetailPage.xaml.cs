using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PractiseApp
{
    public partial class UserDetailPage : ContentPage
    {
        void Icon1_Tapped(object sender, System.EventArgs e)
        {
            var page = new Page1();
            PlaceHolder.Content = page.Content;
        }
        void Icon2_Tapped(object sender, System.EventArgs e)
        {
            var page = new Page2();
            PlaceHolder.Content = page.Content;
        }
        void Icon3_Tapped(object sender, System.EventArgs e)
        {
            var page = new Page3();
            PlaceHolder.Content = page.Content;
        }
        void Icon4_Tapped(object sender, System.EventArgs e)
        {
            var page = new Page4();
            PlaceHolder.Content = page.Content;
        }
        void Icon5_Tapped(object sender, System.EventArgs e)
        {
            var page = new Page5();
            PlaceHolder.Content = page.Content;
        }

       

        public UserDetailPage(String username, String password)
        {
            InitializeComponent();

        }

    }
}
