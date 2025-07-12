using System;


namespace CocoaDotNet.Foundation
{
	/// <summary>
	/// 메모리 내의 바이트 버퍼.
	/// <para><a href="https://developer.apple.com/documentation/foundation/data">Apple Developer Documentation</a></para>
	/// </summary>
	public class Data
	{
		/// <summary>
		/// 
		/// </summary>
		public enum Deallocator
		{
			custom,
			free,
			none,
			unmap,
			virtualMemory,
		}

		/// <summary>
		/// 
		/// </summary>
		[Flags]
		public enum ReadingOptions
		{
			/// <summary>
			/// dataReadingMapped, mappedRead 
			/// </summary>
			mappedIfSafe,

			/// <summary>
			/// uncachedRead
			/// </summary>
			uncached,

			/// <summary>
			/// 
			/// </summary>
			alwaysMapped,
		}

		/// <summary>
		/// 
		/// </summary>
		[Flags]
		public enum WritingOptions
		{
			/// <summary>
			/// 
			/// </summary>
			atomic = 1 << 0,

			/// <summary>
			/// 
			/// </summary>
			withoutOverwritting = 1 << 1,

			/// <summary>
			/// 
			/// </summary>
			noFileProtection = 1 << 2,

			/// <summary>
			/// 
			/// </summary>
			completeFileProtection = 1 << 2,

			/// <summary>
			/// 
			/// </summary>
			completeFileProtectionUnlessOpen = 1 << 3,

			/// <summary>
			/// 
			/// </summary>
			completeFileProtectionUntilFirstUserAuthentication = 1 << 4,

			/// <summary>
			/// 
			/// </summary>
			fileProtectionMask = 1 << 5,
		}


		/// <summary>
		/// 빈 데이터 버퍼를 생성.
		/// </summary>
		public Data()
		{
		}

		/// <summary>
		/// 지정된 크기의 빈 데이터 버퍼를 생성.
		/// </summary>
		public Data(int capacity)
		{
		}

		/// <summary>
		/// 지정된 수의 0으로 채워진 바이트로 새로운 데이터 버퍼를 생성.
		/// </summary>
		public Data(int count, int overloadBypass = int.MinValue)
		{
		}

		/// <summary>
		/// 데이터 버퍼의 영역을 설정.
		/// </summary>
		public void resetBytes(Range range)
		{
		}

		/// <summary>
		/// 데이터 버퍼의 내용을 위치에 작성.
		/// </summary>
		public void write(URL to, WritingOptions options)
		{
		}
	}
}