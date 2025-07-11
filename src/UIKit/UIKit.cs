using System;
using System.Collections.Generic;
using CGFloat = System.Double;
using Any = System.Object;
using Selector = System.Delegate;


namespace CocoaDotNet
{
	public class UIEdgeInsets
	{
		public CGFloat top;
		public CGFloat left;
		public CGFloat bottom;
		public CGFloat right;
	}

	public class NSDirectionalEdgeInsets
	{
		public CGFloat top;
		public CGFloat leading;
		public CGFloat bottom;
		public CGFloat trailing;
	}
	
	public class UIInterfaceOrientation
	{
		
	}
	
	public class UIInterfaceOrientationMask
	{
		
	}

	public class UIStoryboardSegue
	{
		public UIViewController source;
		public UIViewController destination;
		public string identifier;
	}
	
	public class UIStoryboardUnwindSegueSource
	{
		public UIViewController source;
		public Selector unwindAction;
		public Any sender;
	}

	public class NSCoder
	{
		
	}

	public class Bundle
	{
		
	}

	public class UIApplication
	{
	}

	public class UIScene
	{
	}

	public class UIScreen
	{
	}

	public class UIWindow
	{
	}
	
	public class UINavigationController : UIViewController
	{
	}
	
	public class UIView
	{
	}

	public class UIStackView : UIView
	{
	}
}