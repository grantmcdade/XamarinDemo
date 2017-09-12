using Demo.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Demo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DemoContainer.PerformRegistration();

            // MainPage = new Demo.MainPage();
            MainPage = new Demo.Core.CustomersMaster();
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
