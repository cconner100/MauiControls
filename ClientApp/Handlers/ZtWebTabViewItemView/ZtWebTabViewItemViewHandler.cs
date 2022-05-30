// -----------------------------------------------------------------------
//  <copyright file="ZtTabViewItemViewHandler.cs" company="Dominion Enterprise">
//        Copyright (c) Dominion Enterprise LLC. All rights reserved.
//   </copyright>
//  -----------------------------------------------------------------------

namespace ClientApp.Handlers
{
    using ClientApp.UserControls;
    public partial class ZtWebTabViewItemViewHandler 
    {
        public static IPropertyMapper<IZtWebTabViewItemView, IZtWebTabViewItemViewHandler> ZtTabViewItemViewPropertyMapper => new PropertyMapper<IZtWebTabViewItemView, IZtWebTabViewItemViewHandler>()
        {
            [nameof(ZtWebTabViewItemView.Header)] = MapHeader,
            [nameof(ZtWebTabViewItemView.IconSource)] = MapIconSource,
            [nameof(ZtWebTabViewItemView.IsClosable)] = MapIsClosable,
            [nameof(ZtWebTabViewItemView.PlatformObject)] = MapPlatformObject,
            [nameof(IContentView.Content)] = MapContent,
        };

        public static CommandMapper<IZtWebTabViewItemView, IZtWebTabViewItemViewHandler> ZtTabViewItemViewCommandMapper => new CommandMapper<IZtWebTabViewItemView, IZtWebTabViewItemViewHandler>();

        public ZtWebTabViewItemViewHandler() : base(ZtTabViewItemViewPropertyMapper, ZtTabViewItemViewCommandMapper)
        {

        }

        public ZtWebTabViewItemViewHandler(IPropertyMapper mapper = null) : base(mapper ?? ZtTabViewItemViewPropertyMapper, ZtTabViewItemViewCommandMapper)
        {
        }
    }
}
