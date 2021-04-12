using System;
using CustomControlDemo.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomControlDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage() {Content = new CustomContentView() };
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
