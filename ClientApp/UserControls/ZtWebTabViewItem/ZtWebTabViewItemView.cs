// -----------------------------------------------------------------------
//  <copyright file="ZtTabViewItem.cs" company="Dominion Enterprise">
//        Copyright (c) Dominion Enterprise LLC. All rights reserved.
//   </copyright>
//  -----------------------------------------------------------------------

namespace ClientApp.UserControls
{
    using Microsoft.Maui.Graphics;

    [ContentProperty("Content")]
    public partial class ZtWebTabViewItemView : View, IContentView, IZtWebTabViewItemView
    {
        public ZtWebTabViewItemView()
        {

        }

        #region Properties

        public static readonly BindableProperty HeaderProperty = BindableProperty.Create("Header", typeof(string), typeof(ZtWebTabViewItemView));
        public string Header 
        {
            get { return (string)GetValue(HeaderProperty); }
            set { SetValue(HeaderProperty, value); }
        }

        public static readonly BindableProperty IconSourceProperty = BindableProperty.Create("IconSource", typeof(object), typeof(ZtWebTabViewItemView));
        public object IconSource
        {
            get { return GetValue(IconSourceProperty); }
            set { SetValue(IconSourceProperty, value); }
        }

        public static readonly BindableProperty IsClosableProperty = BindableProperty.Create("IsClosable", typeof(bool), typeof(ZtWebTabViewItemView));
        public bool IsClosable
        {
            get { return (bool)GetValue(IsClosableProperty); }
            set { SetValue(IsClosableProperty, value); }
        }

        public static readonly BindableProperty ContentProperty = BindableProperty.Create("Content", typeof(object), typeof(ZtWebTabViewItemView));
        public object Content
        {
            get { return GetValue(ContentProperty); }
            set { SetValue(ContentProperty, value); }
        }

        public static readonly BindableProperty PlatformObjectProperty = BindableProperty.Create("PlatformObject", typeof(object), typeof(ZtWebTabViewItemView));
        public object PlatformObject
        {
            get { return GetValue(PlatformObjectProperty); }
            set { }
        }

        #endregion

        #region Events
        public event EventHandler CloseRequested;

        public void WinCloseRequested(object sender, object args)
        {
            CloseRequested?.Invoke(sender, (EventArgs)args);
        }
        #endregion
#nullable enable
        object? IContentView.Content => Content;

        IView? IContentView.PresentedContent => (View)Content;
#nullable disable
        public Thickness Padding
        {
            get;
            set;
        }

        public Size CrossPlatformArrange(Rect bounds)
        {
            throw new NotImplementedException();
        }

        public Size CrossPlatformMeasure(double widthConstraint, double heightConstraint)
        {
            throw new NotImplementedException();
        }
    }
}
