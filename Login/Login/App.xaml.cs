using Login.Models;
using Login.ViewModels;
using Login.Views;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Login
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer init = null) : base(init)
        {

        }

        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync("NavigationPage/index");

        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<index, indexVM>();
            containerRegistry.RegisterForNavigation<inicio, inicioVM>();
            containerRegistry.RegisterForNavigation<Juegos, juegosVM>();
        }
    }
}
