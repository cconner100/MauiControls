// -----------------------------------------------------------------------
//  <copyright file="IZtTabViewItem.cs" company="Dominion Enterprise">
//        Copyright (c) Dominion Enterprise LLC. All rights reserved.
//   </copyright>
//  -----------------------------------------------------------------------

namespace ClientApp.UserControls
{

    public interface IZtWebTabViewItemView : IContentView
    {
        #region Events
        event EventHandler CloseRequested;

        void WinCloseRequested(object sender, object args);
        #endregion

        string Header { get;set; } 
        object IconSource { get; set; }
        bool IsClosable { get; set; }
        object PlatformObject { get; set; }
    }
}
