// -----------------------------------------------------------------------
//  <copyright file="IDtShellController.cs" company="Dominion Enterprise">
//        Copyright (c) Dominion Enterprise LLC. All rights reserved.
//   </copyright>
//  -----------------------------------------------------------------------

namespace ClientApp.UserControls
{

    public interface IDtShellController : IPageController
    {
        View NavigationView { get; }
        View WebTabView { get; }
        View WebTabViewContent { get; }
    }
}
