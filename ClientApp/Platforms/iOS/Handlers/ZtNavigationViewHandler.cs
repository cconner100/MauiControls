#if __IOS__ 
namespace ClientApp.Handlers
{
    using ClientApp.UserControls;

    using Microsoft.Maui.Handlers;


    public partial class ZtNavigationViewHandler : ViewHandler<IZtNavigationView, UIKit.UIView>, IElementHandler
    {
        protected override UIKit.UIView CreatePlatformView()
        {
            return new UIKit.UIView();
        }

        #region Properties

        public static void MapContent(IZtNavigationViewHandler viewHandler, IZtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapHeader(IZtNavigationViewHandler viewHandler, IZtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapAlwaysShowHeader(IZtNavigationViewHandler viewHandler, IZtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapIsBackButtonVisable(IZtNavigationViewHandler viewHandler, IZtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapBackButtonEnabled(IZtNavigationViewHandler viewHandler, IZtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapCompactModeThresholdWidth(IZtNavigationViewHandler viewHandler, IZtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapCompactPaneLength(IZtNavigationViewHandler viewHandler, IZtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapDisplayMode(IZtNavigationViewHandler viewHandler, IZtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapExpandedModeThresholdWidth(IZtNavigationViewHandler viewHandler, IZtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        //public static void MapFooterMenuItems(IZtNavigationViewHandler viewHandler, IZtNavigationView virtualView)
        //{
        //     virtualView.FooterMenuItems = ((NavigationView)(viewHandler?.PlatformView)).FooterMenuItems; = virtualView.FooterMenuItems;
        //}

        public static void MapFooterMenuItemsSource(IZtNavigationViewHandler viewHandler, IZtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapHeaderTemplate(IZtNavigationViewHandler viewHandler, IZtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapIsPaneOpen(IZtNavigationViewHandler viewHandler, IZtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapIsPaneToggleButtonVisible(IZtNavigationViewHandler viewHandler, IZtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapIsSettingsVisible(IZtNavigationViewHandler viewHandler, IZtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapIsTitleBarAutoPaddingEnabled(IZtNavigationViewHandler viewHandler, IZtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapMenuItemContainerStyle(IZtNavigationViewHandler viewHandler, IZtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapMenuItems(IZtNavigationViewHandler viewHandler, IZtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapMenuItemsSource(IZtNavigationViewHandler viewHandler, IZtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapMenuItemsTemplate(IZtNavigationViewHandler viewHandler, IZtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapOpenPaneLength(IZtNavigationViewHandler viewHandler, IZtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapPaneDisplayMode(IZtNavigationViewHandler viewHandler, IZtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapOverflowLabelMode(IZtNavigationViewHandler viewHandler, IZtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }

        public static void MapSelectedItem(IZtNavigationViewHandler viewHandler, IZtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
#endif
