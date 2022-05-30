namespace ClientApp
{
    using ClientApp.Pages;
    using ClientApp.UserControls;
    using ClientApp.ViewModel;

    using Microsoft.Maui.Platform;
#if WINDOWS
    using Microsoft.UI.Xaml.Controls;
#endif
    using Models.Menus;

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }

        private void ContentPage_Loaded(object sender, EventArgs e)
        {
            // first see if we are logged in

            // get permissions

            // build menu
            var dmsmenu = new ZiiDmsMenus();
            var menucontext = new ZtBuildMenuContext();
            menucontext.BuildPlatformMenus(NavView, dmsmenu.GetPlatformMenu());

        }

        private void ContentPage_Appearing(object sender, EventArgs e)
        {

        }

        private void NavTabView_Loaded(object sender, EventArgs e)
        {
            if(BindingContext is MainPageViewModel vm)
            {
                var lp = vm.LoadLaunchPad();
                NavTabView?.TabItems?.Add(lp);
            }

        }
    }
}
