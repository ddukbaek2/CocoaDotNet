using System;


namespace CocoaDotNet.Foundation
{
	/// <summary>
	/// 
	/// </summary>
	public class NSNotification
	{
		/// <summary>
		/// 
		/// </summary>
		public readonly struct Name : IEquatable<Name>
		{
			public string rawValue { get; }

			public Name(string value)
			{
				if (string.IsNullOrWhiteSpace(value))
					throw new ArgumentNullException(nameof(value));
				this.rawValue = value;
			}
			
			public bool Equals(Name other)
			{
				return this.rawValue == other.rawValue;
			}

			public override bool Equals(object obj)
			{
				if (obj is Name name)
					return Equals(name);

				return false;
			}

			public override int GetHashCode()
			{
				if (string.IsNullOrWhiteSpace(this.rawValue))
					return 0;
				return this.rawValue.GetHashCode();
			}

			public override string ToString()
			{
				return this.rawValue;
			}
			
			public static implicit operator Name(string value)
			{
				return new Name(value);
			}

			public static implicit operator string(Name name)
			{
				return name.rawValue;
			}
		}
	}
}