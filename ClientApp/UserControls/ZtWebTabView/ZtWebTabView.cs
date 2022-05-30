// -----------------------------------------------------------------------
//  <copyright file="ZtWebTabView.cs" company="Dominion Enterprise">
//        Copyright (c) Dominion Enterprise LLC. All rights reserved.
//   </copyright>
//  -----------------------------------------------------------------------

namespace ClientApp.UserControls
{
    using Microsoft.Maui.Graphics;

    public partial class ZtWebTabView : View, IContentView, IZtWebTabView
    {
        public enum CloseButtonOverlayModeEnum
        {
            Always,
            Auto,
            OnPointerOver
        };

        public enum TabWidthModeEnum
        {
            Compact,
            Equal,
            SizeToContent
        }

        public ZtWebTabView()
        {

        }

        #region Events
        public new event EventHandler Loaded;
        public event EventHandler AddTabButtonClick;
        public event EventHandler SelectionChanged;
        public event EventHandler TabCloseRequested;
        public event EventHandler TabDragCompleted;
        public event EventHandler TabDragStarting;
        public event EventHandler TabDroppedOutSide;
        public event EventHandler TabItemsChanged;
        public event EventHandler TabStripDragOver;
        public event EventHandler TabStripDrop;

        public void WinLoaded(object sender, object args)
        {
            Loaded?.Invoke(sender, null);
        }

        public void WinAddTabButtonClick(object sender, object args)
        {
            AddTabButtonClick?.Invoke(sender, (EventArgs)args);
        }
        public void WinSelectionChanged(object sender, object args)
        {
            SelectionChanged?.Invoke(sender, (EventArgs)args);
        }
        public void WinTabCloseRequested(object sender, object args)
        {
            TabCloseRequested?.Invoke(sender, (EventArgs)args);
        }
        public void WinTabDragCompleted(object sender, object args)
        {
            TabDragCompleted?.Invoke(sender, (EventArgs)args);
        }
        public void WinTabDragStarting(object sender, object args)
        {
            TabDragStarting?.Invoke(sender, (EventArgs)args);
        }
        public void WinTabDroppedOutSide(object sender, object args)
        {
            TabDroppedOutSide?.Invoke(sender, (EventArgs)args);
        }
        public void WinTabItemsChanged(object sender, object args)
        {
            TabItemsChanged?.Invoke(sender, (EventArgs)args);
        }
        public void WinTabStripDragOver(object sender, object args)
        {
            TabStripDragOver?.Invoke(sender, (EventArgs)args);
        }
        public void WinTabStripDrop(object sender, object args)
        {
            TabStripDrop?.Invoke(sender, (EventArgs)args);
        }

        public Size CrossPlatformMeasure(double widthConstraint, double heightConstraint)
        {
            throw new NotImplementedException();
        }

        public Size CrossPlatformArrange(Rect bounds)
        {
            throw new NotImplementedException();
        }
        #endregion


        #region Properties

        public static readonly BindableProperty AddTabButtonCommandProperty = BindableProperty.Create("AddTabButtonCommand", typeof(object), typeof(ZtWebTabView));
        public object AddTabButtonCommand { get; set; }

        public static readonly BindableProperty AddTabButtonCommandParameterProperty = BindableProperty.Create("AddTabButtonCommandParameter", typeof(object), typeof(ZtWebTabView));
        public object AddTabButtonCommandParameter { get; set; }

        public static readonly BindableProperty AllowDropTabsProperty = BindableProperty.Create("AllowDropTabs", typeof(bool), typeof(ZtWebTabView), true);
        public bool AllowDropTabs { get; set; } = true;

        public static readonly BindableProperty CanDragTabsProperty = BindableProperty.Create("CanDragTabs", typeof(bool), typeof(ZtWebTabView), false);
        public bool CanDragTabs { get; set; } = false;

        public static readonly BindableProperty CanReorderTabsProperty = BindableProperty.Create("CanReorderTabs", typeof(bool), typeof(ZtWebTabView), true);
        public bool CanReorderTabs { get; set; } = true;

        public static readonly BindableProperty CloseButtonOverlayModeProperty = BindableProperty.Create("CloseButtonOverlayMode", typeof(CloseButtonOverlayModeEnum), typeof(ZtWebTabView), CloseButtonOverlayModeEnum.Auto);
        public CloseButtonOverlayModeEnum CloseButtonOverlayMode { get; set; } = CloseButtonOverlayModeEnum.Auto;

        public static readonly BindableProperty IsAddTabButtonVisibleProperty = BindableProperty.Create("IsAddTabButtonVisible", typeof(bool), typeof(ZtWebTabView), true);
        public bool IsAddTabButtonVisible { get; set; } = true;

        public static readonly BindableProperty SelectedIndexProperty = BindableProperty.Create("SelectedIndex", typeof(int), typeof(ZtWebTabView));
        public int SelectedIndex { get; set; }

        public static readonly BindableProperty SelectedItemProperty = BindableProperty.Create("SelectedItem", typeof(object), typeof(ZtWebTabView));
        public object SelectedItem { get; set; }

        public static readonly BindableProperty TabItemsProperty = BindableProperty.Create("TabItems", typeof(IList<object>), typeof(ZtWebTabView));
        public IList<object> TabItems { get; set; }

        public static readonly BindableProperty TabItemsSourceProperty = BindableProperty.Create("TabItemsSource", typeof(object), typeof(ZtWebTabView));
        public object TabItemsSource { get; set; }

        public static readonly BindableProperty TabStripFooterProperty = BindableProperty.Create("TabStripFooter", typeof(object), typeof(ZtWebTabView));
        public object TabStripFooter { get; set; }

        public static readonly BindableProperty TabWidthModeProperty = BindableProperty.Create("TabWidthModeEnum", typeof(object), typeof(ZtWebTabView), TabWidthModeEnum.Equal);
        public TabWidthModeEnum TabWidthMode { get; set; } = TabWidthModeEnum.Equal;

        public static readonly BindableProperty ContentProperty = BindableProperty.Create("Content", typeof(object), typeof(ZtNavigationView));
        public object Content
        {
            get { return (View)GetValue(ContentProperty); }
            set { SetValue(ContentProperty, value); }
        }
        #endregion

#nullable enable
        object? IContentView.Content => Content;

        IView? IContentView.PresentedContent => (View)Content;

        public Thickness Padding { get; }
#nullable disable
    }
}
