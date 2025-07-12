using System;
using System.Collections.Generic;
using CGFloat = System.Double;
using Any = System.Object;
using Selector = System.Delegate;


namespace CocoaDotNet
{
	public class UIViewController : UIResponder
	{
		public object storyboard { private set; get; }
		public string nibName { private set; get; }
		public object nibBundle { private set; get; }

		public string title { private set; get; }
		public CGSize preferredContentSize { private set; get; }

		public UIView view { private set; get; }
		public UIView viewIfLoaded { private set; get; }
		public bool isViewLoaded { private set; get; }

		public bool isBeingDismissed { private set; get; }
		public bool isBeingPresented { private set; get; }
		public bool isMovingFromParent { private set; get; }
		public bool isMovingToParent { private set; get; }
		
		public UIEdgeInsets additionalSafeAreaInsets { private set; get; }
		public bool viewRespectsSystemMinimumLayoutMargins { private set; get; }
		public NSDirectionalEdgeInsets systemMinimumLayoutMargins { private set; get; }
		public UIRectEdge edgesForExtendedLayout { private set; get; }
		public bool extendedLayoutIncludesOpaqueBars { private set; get; }
		
		public UIInterfaceOrientationMask supportedInterfaceOrientations { private set; get; }
		public UIInterfaceOrientation preferredInterfaceOrientationForPresentation { private set; get; }
		public bool prefersInterfaceOrientationLocked { private set; get; }
		public UIViewController childViewControllerForInterfaceOrientationLock { private set; get; }
		
		public UIModalPresentationStyle modalPresentationStyle { private set; get; }
		public UIModalTransitionStyle modalTransitionStyle { private set; get; }
		public bool isModalInPresentation { private set; get; }
		public bool definesPresentationContext { private set; get; }
		public bool providersPresentationContextTransitionStyle { private set; get; }
		public bool disablesAutomaticKeyboardDismissal { private set; get; }
		public static NSNotification.Name showDetailTargetDidChangeNotification { private set; get; }

		public UIViewControllerTransitioningDelegate transitioningDelegate { private set; get; }
		public UIViewControllerTransitionCoordinator transitionCoordinator { private set; get; }
		public UIPresentationController presentationController { private set; get; }
		public UIPopoverPresentationController popoverPresentationController { private set; get; }
		public UISheetPresentationController sheetPresentationController { private set; get; }
		public UIPresentationController activePresentationController { private set; get; }
		public bool restoresFocusAfterTransition { private set; get; }
	
		public UIUserInterfaceStyle overrideUserInterfaceStyle { private set; get; }
		public UIUserInterfaceStyle preferredUserInterfaceStyle { private set; get; }
		public UIViewController childViewControllerForUserInterfaceStyle { private set; get; }

		public virtual void init(NSCoder coder) { }
		public virtual void init(string nibName, Bundle bundle) { }
		
		public virtual void loadView() {  }
		public virtual void viewDidLoad() { }
		public virtual void loadViewIfNeeded() { }
		
		public virtual void viewWillAppear(bool animated) { }
		public virtual void viewIsAppearing(bool animated) { }
		public virtual void viewDidAppear(bool animated) { }
		public virtual void viewWillDisappear(bool animated) { }
		public virtual void viewDidDisappear(bool animated) { }

		public virtual void viewSafeAreaInsetsDidChange() { }
		public virtual void viewLayoutMarginsDidChange() { }
		public virtual void viewWillLayoutSubviews() { }
		public virtual void viewDidLayoutSubviews() { }
		public virtual void updateViewConstraints() { }
		public virtual void setNeedsUpdateOfSupportedInterfaceOrientations() { }
		public virtual void setNeedUpdateOfPrefersInterfaceOrientationLocked() { }
		
		public virtual bool shouldPerformSegue(string withIdentifier, Any sender) { return false; }
		public virtual void prepare(UIStoryboardSegue @for, Any sender) { }
		public virtual void performSegue(string withIdentifier, Any sender) { }
		public virtual List<UIViewController> allowedChildrenForUnwinding(UIStoryboardUnwindSegueSource @from) { return null; }
		public virtual UIViewController childContaining(UIStoryboardUnwindSegueSource source) { return null; }
		public virtual bool canPerformUnwindSegueAction(Selector action, UIViewController @from, Any sender) { return false; }
		public virtual void unwind(UIStoryboardSegue @for, UIViewController towards) { }
		
		public virtual void show(UIViewController vc, Any sender) { }
		public virtual void showDetailViewController(UIViewController vc, Any sender) { }
		public virtual void present(UIViewController vc, bool animated, Action completion) { }
		public virtual void dismiss(bool animated, Action completion) { }
		
		public virtual UIViewController targetViewController(Selector forAction, Any sender) { return null; }
		
		public virtual void collapseSecondaryViewController(UIViewController vc, UISplitViewController @for) { }
		public virtual UIViewController separateSecondaryViewController(UISplitViewController @for) { return null; }

		public virtual void setNeedsUserInterfaceAppearanceUpdate() { }
	}
}