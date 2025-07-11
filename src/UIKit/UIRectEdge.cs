using System;


namespace CocoaDotNet
{
	[Flags]
	public enum UIRectEdge
	{
		none = 0,
		top = 1 << 0,
		left = 1 << 1,
		bottom = 1 << 2,
		right = 1 << 3,
		all = top | left | bottom | right
	}
}