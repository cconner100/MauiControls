// -----------------------------------------------------------------------
//  <copyright file="ZtTabViewItemHandler.cs" company="Dominion Enterprise">
//        Copyright (c) Dominion Enterprise LLC. All rights reserved.
//   </copyright>
//  -----------------------------------------------------------------------

namespace ClientApp.Handlers
{
    using ClientApp.UserControls;

    using Microsoft.Maui;
    using Microsoft.Maui.Handlers;
    using Microsoft.Maui.Platform;
    using Microsoft.UI.Xaml.Controls;

    public partial class ZtWebTabViewItemViewHandler : ViewHandler<ZtWebTabViewItemView, TabViewItem>, IZtWebTabViewItemViewHandler
    {
        private TabViewItem _tabViewItem = new TabViewItem();

        IZtWebTabViewItemView IZtWebTabViewItemViewHandler.VirtualView => VirtualView;

        protected override TabViewItem CreatePlatformView()
        {
            return _tabViewItem;
        }

        #region Events
        protected override void ConnectHandler(TabViewItem platformView)
        {
            base.ConnectHandler(platformView);
            platformView.CloseRequested += PlatformView_CloseRequested;
        }

        protected override void DisconnectHandler(TabViewItem platformView)
        {
            base.DisconnectHandler(platformView);
            platformView.CloseRequested -= PlatformView_CloseRequested;
        }

        public override void SetMauiContext(IMauiContext mauiContext)
        {
            base.SetMauiContext(mauiContext);
        }

        private void PlatformView_CloseRequested(TabViewItem sender, TabViewTabCloseRequestedEventArgs args)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region PropertyMaps
        public static void MapHeader(IZtWebTabViewItemViewHandler handler, IZtWebTabViewItemView virtualView)
        {
            ((TabViewItem)(handler?.PlatformView)).Header = virtualView.Header;
        }

        public static void MapIconSource(IZtWebTabViewItemViewHandler handler, IZtWebTabViewItemView virtualView)
        {
            ((TabViewItem)(handler?.PlatformView)).IconSource = (IconSource)virtualView.IconSource;
        }

        public static void MapIsClosable(IZtWebTabViewItemViewHandler handler, IZtWebTabViewItemView virtualView)
        {
            ((TabViewItem)(handler?.PlatformView)).IsClosable = virtualView.IsClosable;
        }

        public static void MapContent(IZtWebTabViewItemViewHandler handler, IZtWebTabViewItemView virtualView)
        {
            _ = handler.PlatformView ?? throw new InvalidOperationException($"{nameof(PlatformView)} should have been set by base class.");
            _ = handler.VirtualView ?? throw new InvalidOperationException($"{nameof(VirtualView)} should have been set by base class.");
            _ = handler.MauiContext ?? throw new InvalidOperationException($"{nameof(MauiContext)} should have been set by base class.");

#if WINDOWS
            if (handler.VirtualView.PresentedContent is IView view)
                handler.PlatformView.Content = view.ToPlatform(handler.MauiContext);
#endif
        }

        public static void MapPlatformObject(IZtWebTabViewItemViewHandler handler, IZtWebTabViewItemView virtualView)
        {
            _ = handler.PlatformView ?? throw new InvalidOperationException($"{nameof(PlatformView)} should have been set by base class.");
            _ = handler.VirtualView ?? throw new InvalidOperationException($"{nameof(VirtualView)} should have been set by base class.");
            _ = handler.MauiContext ?? throw new InvalidOperationException($"{nameof(MauiContext)} should have been set by base class.");

#if WINDOWS
            if (handler.VirtualView.PresentedContent is IView view)
                virtualView.PlatformObject = view.ToPlatform(handler.MauiContext);
#endif
        }
        #endregion
    }
}
