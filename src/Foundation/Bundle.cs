using CocoaDotNet.UIKit;
using System;
using System.Collections.Generic;
using System.IO;
using Any = System.Object;


namespace CocoaDotNet.Foundation
{
	/// <summary>
	/// 번들.
	/// </summary>
	public class Bundle : NSObject
	{
		/// <summary>
		/// 현재 실행 파일을 포함하는 번들.
		/// </summary>
		public static Bundle main { private set; get; }

		/// <summary>
		/// 애플리케이션의 모든 비프레임워크 번들의 배열.
		/// </summary>
		public static List<Bundle> allBundles { private set; get; }

		/// <summary>
		/// 프레임워크를 나타내는 모든 애플리케이션 번들의 배열.
		/// </summary>
		public static List<Bundle> allFrameworks { private set; get; }

		/// <summary>
		/// 번들의 경로.
		/// <para>예) /var/containers/Bundle/Application/.../MyApp.app</para>
		/// </summary>
		public string bundlePath { private set; get; }

		/// <summary>
		/// 리소스 폴더의 경로.
		/// <para>보통 bundlePath/Resources</para>
		/// </summary>
		public string resourcePath { private set; get; }

		/// <summary>
		/// 번들 디렉토리의 URL.
		/// </summary>
		public URL bundleURl { private set; get; }

		/// <summary>
		/// 
		/// </summary>
		public bool isLoaded { private set; get; }

		/// <summary>
		/// NSBundle 지정된 디렉토리에 맞게 초기화된 객체를 반환.
		/// </summary>
		public Bundle(string path)
		{
			if (!Directory.Exists(path))
				throw new DirectoryNotFoundException(path);
		}

		/// <summary>
		/// NSBundle 지정된 클래스와 연관된 객체를 반환.
		/// </summary>
		public Bundle(Type aClass)
		{
			//init();
		}

		/// <summary>
		/// NSBundle 지정된 파일 URL에 맞게 초기화된 객체를 반환.
		/// </summary>
		public Bundle(URL url)
		{

		}

		/// <summary>
		/// NSBundle 지정된 번들 식별자가 있는 인스턴스를 반환.
		/// </summary>
		public Bundle(string identifier, int overloadBypass = int.MinValue)
		{
		}

		/// <summary>
		/// 수신기 번들에 있는 nib 파일의 내용을 압축 해제.
		/// </summary>
		public List<Any> loadNibNamed(string name, Any? owner, Dictionary<UINib.OptionsKey, Any>? options = null)
		{
			return null;
		}

		/// <summary>
		/// 
		/// </summary>
		public virtual bool load()
		{
			return false;
		}

		/// <summary>
		/// 
		/// </summary>
		public bool unload()
		{
			return false;
		}

		/// <summary>
		/// 
		/// </summary>
		public virtual Any @object ()
		{
			return null;
		}
	}
}