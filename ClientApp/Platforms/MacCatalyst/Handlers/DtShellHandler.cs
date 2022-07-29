// -----------------------------------------------------------------------
//  <copyright file="DtShellHandler.cs" company="Dominion Enterprise">
//        Copyright (c) Dominion Enterprise LLC. All rights reserved.
//   </copyright>
//  -----------------------------------------------------------------------

namespace ClientApp.Handlers
{
    using System;
    using System.ComponentModel;

    using ClientApp.UserControls;

    using Microsoft.Maui.Controls.Platform;
    using Microsoft.Maui.Graphics;
    using Microsoft.Maui.Handlers;

    using UIKit;

    public class DtShellHandler : UISplitViewController, IPlatformViewHandler
    {
        UIView rootview;

        public DtShellHandler()
        {
            rootview = new UIView();
        }


        public static IPropertyMapper<DtShell, DtShellHandler> Mapper = new PropertyMapper<DtShell, DtShellHandler>(ViewHandler.ViewMapper);
        public static CommandMapper<DtShell, DtShellHandler> CommandMapper = new CommandMapper<DtShell, DtShellHandler>(ViewHandler.ViewCommandMapper);

        public UIView NativeView => rootview;
        public UIView PlatformView { get; }
        public UIView ContainerView { get; }
        public UISplitViewController ViewController => this;
        public bool HasContainer { get; set; }
        public IView VirtualView { get; }
        public IMauiContext MauiContext { get; }
        public event EventHandler<VisualElementChangedEventArgs> ElementChanged;
        public VisualElement Element { get; private set; }

        object IViewHandler.ContainerView { get; }
        IMauiContext _mauiContext;
        IMauiContext IElementHandler.MauiContext => _mauiContext;
        UIView IPlatformViewHandler.PlatformView => NativeView;
        UIView IPlatformViewHandler.ContainerView => null;
        IElement IElementHandler.VirtualView => Element;
        object IElementHandler.PlatformView => NativeView;

        UIViewController IPlatformViewHandler.ViewController => this;

        public void DisconnectHandler()
        {

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var config = new UICollectionLayoutListConfiguration(UICollectionLayoutListAppearance.Sidebar);
            //config.HeaderMode = UICollectionLayoutListHeaderMode.None;
            //config.HeaderMode = UICollectionLayoutListHeaderMode.FirstItemInSection;


            var layout = UICollectionViewCompositionalLayout.GetLayout(config);


            UICollectionView collectionView = new UICollectionView(UIScreen.MainScreen.Bounds, layout);
            this.Add(collectionView);


            collectionView.TranslatesAutoresizingMaskIntoConstraints = false;
            NSLayoutConstraint.ActivateConstraints(new[]
            {
                 collectionView.TopAnchor.ConstraintEqualTo(View.LayoutMarginsGuide.TopAnchor, 0.0f),
                 collectionView.LeadingAnchor.ConstraintEqualTo(View.LeadingAnchor, 0.0f),
                 collectionView.TrailingAnchor.ConstraintEqualTo(View.TrailingAnchor, 0.0f),
                 collectionView.BottomAnchor.ConstraintEqualTo(View.BottomAnchor, 0.0f)
             });
        }

        public Size GetDesiredSize(double widthConstraint, double heightConstraint)
        {
            return new Size(100, 100);
        }

        public void Invoke(string command, object args = null)
        {
            //CommandMapper.Invoke(this, Element, command, args);
        }

        public void PlatformArrange(Rect frame)
        {
            //throw new NotImplementedException();
        }

        public void SetMauiContext(IMauiContext mauiContext)
        {
            _mauiContext = mauiContext;
        }

        public void SetVirtualView(IElement view)
        {
            SetElement((VisualElement)view);
        }

        public void UpdateValue(string property)
        {
            Mapper.UpdateProperty(this, Element, property);
        }

        public void SetElement(VisualElement element)
        {
            if (Element != null)
                throw new NotSupportedException("Reuse of the Shell Renderer is not supported");
            Element = element;
            OnElementSet((DtShell)Element);

            ElementChanged?.Invoke(this, new VisualElementChangedEventArgs(null, Element));
            Mapper.UpdateProperties(this, Element);
        }

        protected virtual void OnElementSet(DtShell element)
        {
            if (element == null)
                return;

            element.PropertyChanged += OnElementPropertyChanged;
        }
        protected virtual void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == Shell.CurrentItemProperty.PropertyName)
            {
                OnCurrentItemChanged();
            }
            else if (e.PropertyName == VisualElement.FlowDirectionProperty.PropertyName)
            {
                // UpdateFlowDirection(true);
            }
        }

        protected virtual async void OnCurrentItemChanged()
        {
            try
            {
                await OnCurrentItemChangedAsync();
            }
            catch (Exception exc)
            {
                //_mauiContext?.CreateLogger<DtShellHandler>()?.LogWarning(exc, "Failed on changing current item");
            }
        }

        protected virtual async Task OnCurrentItemChangedAsync()
        {
            //var currentItem = DtShell.CurrentItem;

            //var oldLayer = _currentShellItemRenderer
            //    ?.ViewController
            //    ?.View
            //    ?.Layer;

            //if (oldLayer?.AnimationKeys?.Length > 0)
            //    oldLayer.RemoveAllAnimations();

            //await _activeTransition;
            //if (_currentShellItemRenderer?.ShellItem != currentItem)
            //{
            //    var newController = CreateShellItemRenderer(currentItem);
            //    await SetCurrentShellItemControllerAsync(newController);
            //}
        }
    }
}
