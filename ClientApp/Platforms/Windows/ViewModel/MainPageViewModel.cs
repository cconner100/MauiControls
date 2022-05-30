// -----------------------------------------------------------------------
//  <copyright file="MainPageViewModel.cs" company="Dominion Enterprise">
//        Copyright (c) Dominion Enterprise LLC. All rights reserved.
//   </copyright>
//  -----------------------------------------------------------------------

namespace ClientApp.ViewModel
{
    using ClientApp.Pages;
    using ClientApp.UserControls;

    using Microsoft.Maui.Platform;
    using Microsoft.UI.Xaml.Controls;

    public partial class MainPageViewModel : IMainPageViewModel
    {
        public object LoadLaunchPad()
        {

            var np = new NavigationPage { Title = "Launch Pad"};
            
            var t = np.PushAsync(new LaunchPadPage());
            Task.WaitAll(t);    
            if (np is IView view)
            {
                if (view is IElement element)
                {
                    if (element is IElementHandler han)
                    {
                        var m = han.MauiContext;
                    }
                }
            }

            var newTab = new ZtWebTabViewItemView()
            {
                IconSource = new SymbolIconSource() { Symbol = Symbol.Document },
                Header = "LaunchPad",
                Content = np
            };

            return newTab;

        }        
    }
}
