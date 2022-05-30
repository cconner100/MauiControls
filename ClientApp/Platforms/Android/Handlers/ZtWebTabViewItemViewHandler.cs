// -----------------------------------------------------------------------
//  <copyright file="ZtTabViewItemViewHandler.cs" company="Dominion Enterprise">
//        Copyright (c) Dominion Enterprise LLC. All rights reserved.
//   </copyright>
//  -----------------------------------------------------------------------

namespace ClientApp.Handlers
{
    using System;

    using ClientApp.UserControls;

    using Microsoft.Maui.Handlers;

    public partial class ZtWebTabViewItemViewHandler : ViewHandler<IZtWebTabViewItemView, Android.Views.View>, IZtWebTabViewItemViewHandler
    {

        IZtWebTabViewItemView IZtWebTabViewItemViewHandler.VirtualView => VirtualView;
        protected override Android.Views.View CreatePlatformView()
        {
            throw new NotImplementedException();
        }

        #region Events
        protected override void ConnectHandler(Android.Views.View platformView)
        {
            base.ConnectHandler(platformView);
            //platformView.CloseRequested += PlatformView_CloseRequested;
        }

        protected override void DisconnectHandler(Android.Views.View platformView)
        {
            base.DisconnectHandler(platformView);
            //platformView.CloseRequested -= PlatformView_CloseRequested;
        }


        #endregion

        #region PropertyMaps
        public static void MapHeader(IZtWebTabViewItemViewHandler handler, IZtWebTabViewItemView virtualView)
        {
            throw new NotImplementedException();
        }

        public static void MapIconSource(IZtWebTabViewItemViewHandler handler, IZtWebTabViewItemView virtualView)
        {
            throw new NotImplementedException();
        }

        public static void MapIsClosable(IZtWebTabViewItemViewHandler handler, IZtWebTabViewItemView virtualView)
        {
            throw new NotImplementedException();
        }

        public static void MapContent(IZtWebTabViewItemViewHandler handler, IZtWebTabViewItemView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapPlatformObject(IZtWebTabViewItemViewHandler handler, IZtWebTabViewItemView virtualView)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
