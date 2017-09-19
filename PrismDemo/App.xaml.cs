using Prism.Unity;

namespace PrismDemo
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            MainPage = new PrismDemoPage();
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

        }

        protected override void OnResume()
        {
            base.OnResume();
        }
    }
}
