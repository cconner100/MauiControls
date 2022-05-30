// -----------------------------------------------------------------------
//  <copyright file="ZtBuildMenuContext.cs" company="Dominion Enterprise">
//        Copyright (c) Dominion Enterprise LLC. All rights reserved.
//   </copyright>
//  -----------------------------------------------------------------------

namespace ClientApp.Models.Menus
{
    using System.Collections.Generic;
    using System.Linq;

    using ClientApp.UserControls;

    using Microsoft.UI.Xaml.Controls;

    public partial class ZtBuildMenuContext
    {
        public void BuildPlatformMenus(ZtNavigationView nv, List<ZtMenuItem> menulist)
        {

            var toplevel = menulist.Where(o => o.Id == o.ParentId).ToList();
            foreach (var rootMenu in toplevel)
            {
                var Level0Menu = MakeMenuItem(rootMenu);
                var subitem = menulist.Where(o => o.ParentId == rootMenu.Id).ToList();

                foreach (var subsubitem in subitem)
                {
                    if (subsubitem.Id == subsubitem.ParentId)
                    {
                        continue;
                    }

                    var second = menulist.Where(o => o.ParentId == subsubitem.Id).ToList();

                    if (!second.Any())
                    {
                        Level0Menu.MenuItems.Add(MakeMenuItem(subsubitem));
                        continue;
                    }

                    var Level2Menu = MakeMenuItem(subsubitem);

                    foreach (var smenu in second)
                    {
                        Level2Menu.MenuItems.Add(MakeMenuItem(smenu));
                    }
                    Level0Menu.MenuItems.Add(Level2Menu);
                }
                nv?.MenuItems?.Add(Level0Menu);
            }
        }

        private NavigationViewItem MakeMenuItem(ZtMenuItem item)
        {
            var tooltip = new ToolTip();
            tooltip.Content = item.ToolTipResource;
            var ret = new NavigationViewItem
            {
                Content = item.NameResource,
                Icon = new SymbolIcon() { Symbol = Symbol.Account },
                Tag = item.Screen
            };
            ToolTipService.SetToolTip(ret, tooltip);
            return ret;
        }
    }
}
