using System;
using System.Collections.Generic;
using Any = System.Object;
using Selector = System.Delegate;
using UITrait = CocoaDotNet.UITraitDefinition;

namespace CocoaDotNet
{
	public class UITraitChangeObservable
	{
		public virtual UITraitChangeRegistration registerForTraitChanges(List<UITrait> traits, Selector any) { return null; }
	}
}