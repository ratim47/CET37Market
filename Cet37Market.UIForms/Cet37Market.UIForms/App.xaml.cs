﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Cet37Market.UIForms
{
    public partial class App : Application  //Code behind responsible for app start
    {
        //common code place for app
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();  //This always start the main page
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart() //app start
        {
            // Handle when your app starts
        }

        protected override void OnSleep()  //when app goes to sleep mode
        {
            // Handle when your app sleeps
        }

        protected override void OnResume() //when app resumes from sleep mode
        {
            // Handle when your app resumes
        }
    }
}
