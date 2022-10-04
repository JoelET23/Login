using Login.Models;
using Login.ViewModels;
using Login.Views;
using Login.Views.JuegosMemoria;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("MaterialIconsRegular.ttf", Alias = "RegularMaterial")]
[assembly: ExportFont("MaterialIconsTwoTone.otf", Alias = "TwoToneMaterial")]


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
            containerRegistry.RegisterForNavigation<JuegoMemoria, JuegoMemoriaVM>();
            containerRegistry.RegisterForNavigation<FrutasI, ModalVM>();
            containerRegistry.RegisterForNavigation<FrutasII, ModalVM>();
        }
    }
}
