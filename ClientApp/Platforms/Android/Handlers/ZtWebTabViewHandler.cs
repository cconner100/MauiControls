// -----------------------------------------------------------------------
//  <copyright file="ZtWebTabViewHandler.cs" company="Dominion Enterprise">
//        Copyright (c) Dominion Enterprise LLC. All rights reserved.
//   </copyright>
//  -----------------------------------------------------------------------
#if __ANDROID__
namespace ClientApp.Handlers
{
    using System;
    using System.Windows.Input;

    using ClientApp.UserControls;

    using Microsoft.Maui.Handlers;

    using static Google.Android.Material.Tabs.TabLayout;

    public partial class ZtWebTabViewHandler : ViewHandler<IZtWebTabView, Android.Widget.ImageView>, IElementHandler
    {
        protected override Android.Widget.ImageView CreatePlatformView()
        {
            throw new NotImplementedException();
        }


        #region Properties
        public static void MapAddTabButtonCommand(IZtWebTabViewHandler viewHandler, IZtWebTabView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapAddTabButtonCommandParameter(IZtWebTabViewHandler viewHandler, IZtWebTabView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapAllowDropTabs(IZtWebTabViewHandler viewHandler, IZtWebTabView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapCanDragTabs(IZtWebTabViewHandler viewHandler, IZtWebTabView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapCanReorderTabs(IZtWebTabViewHandler viewHandler, IZtWebTabView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapCloseButtonOverlayMode(IZtWebTabViewHandler viewHandler, IZtWebTabView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapIsAddTabButtonVisible(IZtWebTabViewHandler viewHandler, IZtWebTabView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapSelectedIndex(IZtWebTabViewHandler viewHandler, IZtWebTabView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapTabItems(IZtWebTabViewHandler viewHandler, IZtWebTabView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapTabItemsSource(IZtWebTabViewHandler viewHandler, IZtWebTabView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapTabStripFooter(IZtWebTabViewHandler viewHandler, IZtWebTabView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapTabWidthMode(IZtWebTabViewHandler viewHandler, IZtWebTabView virtualView)
        {
            throw new NotImplementedException();
        }

        public static void MapSelectedItem(IZtWebTabViewHandler viewHandler, IZtWebTabView virtualView)
        {
            throw new NotImplementedException();
        }

    }
    #endregion
}
#endif

