namespace ClientApp.Handlers
{
    using ClientApp.UserControls;


    public partial class ZtNavigationViewHandler //: IZtNavigationViewHandler
    {

        public static IPropertyMapper<IZtNavigationView, IZtNavigationViewHandler> ZtNavigationViewMapper => new PropertyMapper<IZtNavigationView, IZtNavigationViewHandler>()
        {
            [nameof(ZtNavigationView.Header)] = MapHeader,
            [nameof(ZtNavigationView.AlwaysShowHeader)] = MapAlwaysShowHeader,
            [nameof(ZtNavigationView.IsBackButtonVisable)] = MapIsBackButtonVisable,
            [nameof(ZtNavigationView.IsBackButtonEnabled)] = MapBackButtonEnabled,
            [nameof(ZtNavigationView.CompactModeThresholdWidth)] = MapCompactModeThresholdWidth,
            [nameof(ZtNavigationView.CompactPaneLength)] = MapCompactPaneLength,
            [nameof(IContentView.Content)] = MapContent,
            [nameof(ZtNavigationView.DisplayMode)] = MapDisplayMode,
            [nameof(ZtNavigationView.ExpandedModeThresholdWidth)] = MapExpandedModeThresholdWidth,
            //[nameof(ZtNavigationView.FooterMenuItems)] = MapFooterMenuItems,
            [nameof(ZtNavigationView.FooterMenuItemsSource)] = MapFooterMenuItemsSource,
            //[nameof(ZtNavigationView.HeaderTemplate)] = MapHeaderTemplate,
            [nameof(ZtNavigationView.IsPaneOpen)] = MapIsPaneOpen,
            [nameof(ZtNavigationView.IsPaneToggleButtonVisible)] = MapIsPaneToggleButtonVisible,
            [nameof(ZtNavigationView.IsSettingsVisible)] = MapIsSettingsVisible,
            [nameof(ZtNavigationView.IsTitleBarAutoPaddingEnabled)] = MapIsTitleBarAutoPaddingEnabled,
            //[nameof(ZtNavigationView.MenuItemContainerStyle)] = MapMenuItemContainerStyle,
            [nameof(ZtNavigationView.MenuItems)] = MapMenuItems,
            [nameof(ZtNavigationView.MenuItemsSource)] = MapMenuItemsSource,
            //[nameof(ZtNavigationView.MenuItemsTemplate)] = MapMenuItemsTemplate,
            [nameof(ZtNavigationView.OpenPaneLength)] = MapOpenPaneLength,
            [nameof(ZtNavigationView.OverflowLabelMode)] = MapOverflowLabelMode,
            [nameof(ZtNavigationView.PaneDisplayMode)] = MapPaneDisplayMode,
            [nameof(ZtNavigationView.SelectedItem)] = MapSelectedItem,
        };

        public static CommandMapper<IZtNavigationView, IZtNavigationViewHandler> ZtNavigationViewCommandMapper => new CommandMapper<IZtNavigationView, IZtNavigationViewHandler>();

        public ZtNavigationViewHandler() : base(ZtNavigationViewMapper, ZtNavigationViewCommandMapper)
        {

        }

        public ZtNavigationViewHandler(IPropertyMapper mapper = null) : base(mapper ?? ZtNavigationViewMapper, ZtNavigationViewCommandMapper)
        {
        }
    }
}
