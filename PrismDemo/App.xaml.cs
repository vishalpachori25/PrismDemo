using Prism.Unity;
using PrismDemo.Views;

namespace PrismDemo
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("PrismDemoPage");
        }
        protected override void OnSleep()
        {
            base.OnSleep();
        }
        protected override void OnStart()
        {
            base.OnStart();
        }
        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<PrismDemoPage>();
            Container.RegisterTypeForNavigation<SecondPage>();
        }

        protected override void OnResume()
        {
            base.OnResume();
        }
    }
}