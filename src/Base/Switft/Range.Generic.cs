using System;
using System.Collections.Generic;


namespace CocoaDotNet
{
	/// <summary>
	/// 하한에서 상한까지의 간격. (Count-1까지만)
	/// </summary>
	public struct Range<Bound> where Bound : IComparable<Bound>
	{
		/// <summary>
		/// 범위의 하한.
		/// </summary>
		public Bound lowerBound { get; }

		/// <summary>
		/// 범위의 상한.
		/// </summary>
		public Bound upperBound { get; }

		/// <summary>
		/// 범위에 요소가 없는지 여부.
		/// </summary>
		public bool isEmpty => lowerBound.CompareTo(upperBound) >= 0;

		/// <summary>
		/// 
		/// </summary>
		public Range(Bound lowerBound, Bound upperBound)
		{
			this.lowerBound = lowerBound;
			this.upperBound = upperBound;
		}

		/// <summary>
		/// 주어진 컬렉션 내에서 이 범위 표현식으로 설명되는 인덱스 범위를 반환.
		/// </summary>
		public Range<Bound> relative<C>(C collection) where C : IEnumerable<Bound>
		{
			return new Range<Bound>();
		}

		/// <summary>
		/// 주어진 제한 범위에 맞춰 이 범위의 복사본을 반환.
		/// </summary>
		public Range<Bound> clamped(Range<Bound> to)
		{
			return new Range<Bound>();
		}

		/// <summary>
		/// 주어진 범위가 이 범위에 포함되는지 여부.
		/// </summary>
		public bool contains(Range<Bound> other)
		{
			return false;
		}

		/// <summary>
		/// 주어진 요소가 이 범위 내에 포함되는지 여부.
		/// </summary>
		public bool contains(Bound element)
		{
			return lowerBound.CompareTo(element) <= 0 && element.CompareTo(upperBound) < 0;
		}
	}
}