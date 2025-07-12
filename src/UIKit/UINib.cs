using CocoaDotNet.Foundation;
using System;
using System.Collections.Generic;
using Any = System.Object;


namespace CocoaDotNet.UIKit
{
	/// <summary>
	/// Interface Builder nib 파일을 포함하는 객체.
	/// </summary>
	public class UINib : NSObject
	{
		/// <summary>
		/// 
		/// </summary>
		[Flags]
		public enum OptionsKey
		{
			/// <summary>
			/// 
			/// </summary>
			externalObjects = 1 << 0,
		}

		/// <summary>
		/// 지정된 번들의 nib 파일에서 nib 객체를 반환.
		/// </summary>
		public UINib(string name, Bundle? bundleOrNil = null)
		{
		}

		/// <summary>
		/// 메모리에 저장된 니브 데이터에서 니브 객체를 생성.
		/// </summary>
		public UINib(Data data, Bundle? bundleOrNil = null)
		{
		}

		/// <summary>
		/// nib 객체의 nib 파일에 있는 메모리 내 내용을 압축 해제하고 인스턴스화하여 고유한 객체 트리와 최상위 객체 세트를 만듭니다.
		/// </summary>
		public List<Any> instantiate(Any ownerOrNil = null, Dictionary<OptionsKey, Any>? optionsOrNil = null)
		{
			return null;
		}
	}
}