// -----------------------------------------------------------------------
//  <copyright file="ZtWebTabViewHandler.cs" company="Dominion Enterprise">
//        Copyright (c) Dominion Enterprise LLC. All rights reserved.
//   </copyright>
//  -----------------------------------------------------------------------

namespace ClientApp.Handlers
{
    using ClientApp.UserControls;


    public partial class ZtWebTabViewHandler
    {
        public static IPropertyMapper<IZtWebTabView, IZtWebTabViewHandler> ZtWebTabViewPropertyMapper => new PropertyMapper<IZtWebTabView, IZtWebTabViewHandler>()
        {
            [nameof(IZtWebTabView.AddTabButtonCommand)] = MapAddTabButtonCommand,
            [nameof(IZtWebTabView.AddTabButtonCommandParameter)] = MapAddTabButtonCommandParameter,
            [nameof(IZtWebTabView.AllowDropTabs)] = MapAllowDropTabs,
            [nameof(IZtWebTabView.CanDragTabs)] = MapCanDragTabs,
            [nameof(IZtWebTabView.CanReorderTabs)] = MapCanReorderTabs,
            [nameof(IZtWebTabView.CloseButtonOverlayMode)] = MapCloseButtonOverlayMode,
            [nameof(IZtWebTabView.IsAddTabButtonVisible)] = MapIsAddTabButtonVisible,
            [nameof(IZtWebTabView.SelectedIndex)] = MapSelectedIndex,
            [nameof(IZtWebTabView.SelectedItem)] = MapSelectedItem,
            [nameof(IZtWebTabView.TabItems)] = MapTabItems,
            [nameof(IZtWebTabView.TabItemsSource)] = MapTabItemsSource,
            [nameof(IZtWebTabView.TabStripFooter)] = MapTabStripFooter,
            [nameof(IZtWebTabView.TabWidthMode)] = MapTabWidthMode,
        };

        public static CommandMapper<IZtWebTabView, IZtWebTabViewHandler> ZtWebTabViewCommandMapper => new CommandMapper<IZtWebTabView, IZtWebTabViewHandler>();

        public ZtWebTabViewHandler() : base(ZtWebTabViewPropertyMapper, ZtWebTabViewCommandMapper)
        {

        }

        public ZtWebTabViewHandler(IPropertyMapper mapper = null) : base(mapper ?? ZtWebTabViewPropertyMapper, ZtWebTabViewCommandMapper)
        {
        }
    }

}
