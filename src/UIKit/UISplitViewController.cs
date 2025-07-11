namespace CocoaDotNet
{
	public class UISplitViewController : UIViewController
	{
		public enum Style
		{
			unspecified,
			doubleColumn,
			tripleColumn,
		}
		
		public Style style { private set; get; }
		
		public virtual void init(Style style)
		{
			this.style = style;
		}
		
		public override void init(string nibName, Bundle bundle)
		{
			base.init(nibName, bundle);
		}

		public override void init(NSCoder coder)
		{
			base.init(coder);
		}
	}
}