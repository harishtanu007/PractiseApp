﻿using System;

using Xamarin.Forms;

namespace PractiseApp
{
    public partial class App : Application
    {
        public static bool UseMockDataStore = true;
        public static string BackendUrl = "https://localhost:5000";

        public App()
        {
            InitializeComponent();
           // MainPage = new NavigationPage(new Page1Xaml());
            if (UseMockDataStore)
                DependencyService.Register<MockDataStore>();
            else
                DependencyService.Register<CloudDataStore>();

            //if (Device.RuntimePlatform == Device.iOS)
            //    MainPage = new LoginPage();
            //else
                MainPage = new NavigationPage(new LoginPage());
        }
    }
}
