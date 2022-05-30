// -----------------------------------------------------------------------
//  <copyright file="IZtBuildMenuContext.cs" company="Dominion Enterprise">
//        Copyright (c) Dominion Enterprise LLC. All rights reserved.
//   </copyright>
//  -----------------------------------------------------------------------

namespace ClientApp.Models.Menus
{
    using System.Collections.Generic;

    public interface IZtBuildMenuContext
    {
        void BuildPlatformMenus(object nv, List<ZtMenuItem> menulist);
    }
}
