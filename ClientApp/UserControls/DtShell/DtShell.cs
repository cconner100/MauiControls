// -----------------------------------------------------------------------
//  <copyright file="DtShell.cs" company="Dominion Enterprise">
//        Copyright (c) Dominion Enterprise LLC. All rights reserved.
//   </copyright>
//  -----------------------------------------------------------------------

namespace ClientApp.UserControls
{

    public partial class DtShell : Page, IView, IElement, IPageController, IVisualElementController,  IElementController, IDtShellController, IPageContainer<Page>
    {
        public View NavigationView { get; }
        public View WebTabView { get; }
        public View WebTabViewContent { get; }
        public Page CurrentPage { get; }
    }
}
