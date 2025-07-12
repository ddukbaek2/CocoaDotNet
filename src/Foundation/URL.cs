using System;


namespace CocoaDotNet.Foundation
{
	/// <summary>
	/// 원격 서버의 항목이나 로컬 파일의 경로 등 리소스의 위치를 식별하는 값.
	/// </summary>
	public struct URL
	{
		/// <summary>
		/// 디렉토리를 참조할 수 있는 경로를 처리하기 위한 URL 파일 API에 대한 힌트.
		/// </summary>
		public enum DirectoryHint
		{
			isDirectory,
			notDirectory,
			checkFileSystem,
			inferFromPath,
		}


		/// <summary>
		/// 북마크 데이터를 확인할 때 사용되는 옵션.
		/// <para><a href="https://developer.apple.com/documentation/foundation/nsurl/bookmarkresolutionoptions">Apple Developer Documentation</a></para>
		/// </summary>
		[Flags]
		public enum BookmarkResolutionOptions
		{
			/// <summary>
			/// 북마크 데이터 확인 시 UI 피드백이 함께 제공되지 않도록 지정.
			/// </summary>
			withoutUI,

			/// <summary>
			/// 북마크 데이터를 확인하는 동안 볼륨이 마운트되지 않도록 지정.
			/// </summary>
			withoutMounting,

			/// <summary>
			/// 북마크가 생성될 때 적용된 보안 범위가 북마크 데이터를 확인하는 동안 사용되어야 함을 지정.
			/// </summary>
			withSecurityScope,

			/// <summary>
			/// 해결이 암묵적으로 임시 보안 범위 리소스에 대한 액세스를 시작하지 않도록 지정.
			/// </summary>
			withoutImplicitStartAccessing,
		}

		/// <summary>
		/// 기본 URL.
		/// </summary>
		public URL? baseURL { private set; get; }

		/// <summary>
		/// URL에 대한 절대 문자열.
		/// </summary>
		public string absoluteString { private set; get; }

		/// <summary>
		/// 제공된 문자열에서 URL 인스턴스를 생성.
		/// </summary>
		public URL(string @string)
		{
			baseURL = null;
			absoluteString = @string;
		}

		/// <summary>
		/// 제공된 문자열에서 URL 인스턴스를 생성하고, 선택적으로 유효하지 않은 문자를 IDNA 및 퍼센트 인코딩.
		/// </summary>
		public URL(string @string, bool encodingInvalidCharacters)
		{
		}

		/// <summary>
		/// 제공된 문자열에서 다른 URL을 기준으로 URL 인스턴스를 생성.
		/// </summary>
		public URL(string @string, URL? relativeTo)
		{
		}

		/// <summary>
		/// 북마크 데이터를 확인하여 지정된 위치를 참조하는 URL을 생성.
		/// </summary>
		public URL(Data resolvingBookmarkData, URL.BookmarkResolutionOptions options, URL? relativeTo, ref bool bookmarkDataIsStale)
		{
		}

		/// <summary>
		/// 문자열로 지정한 경로를 참조하는 파일 URL을 생성.
		/// </summary>
		public URL(string filePath, DirectoryHint directoryHint, URL? relativeTo)
		{
		}


	}
}