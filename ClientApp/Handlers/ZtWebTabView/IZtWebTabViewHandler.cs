// -----------------------------------------------------------------------
//  <copyright file="IZtWebTabView.cs" company="Dominion Enterprise">
//        Copyright (c) Dominion Enterprise LLC. All rights reserved.
//   </copyright>
//  -----------------------------------------------------------------------

namespace ClientApp.Handlers
{
    using ClientApp.UserControls;
#if __IOS__ || MACCATALYST
    using PlatformView = UIKit.UIView;
#elif ANDROID
    using PlatformView = Android.Widget.ImageView;
#elif WINDOWS
    using PlatformView = Microsoft.UI.Xaml.Controls.TabView;
#elif NETSTANDARD || (NET6_0 && !IOS && !ANDROID)
    using PlatformView = System.Object;
#endif

    public interface IZtWebTabViewHandler : IViewHandler
    {
        new IZtWebTabView VirtualView { get; }
        new PlatformView PlatformView { get; }
    }

}
