using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LearnApp_001
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // 用
            //MainPage = new NavigationPage(new MainPage());
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
