using System;
using System.Collections.Generic;

namespace GarenaMSDK;

public class GuidPool<T> : Pool<string, T>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<Dictionary<string, T>, string, T, string> _003C_003E9__0_0;

		internal string _003C_002Ector_003Eb__0_0(Dictionary<string, T> dict, string key, T value)
		{
			return null;
		}
	}

	public GuidPool()
		: base((Func<Dictionary<string, T>, string, T, string>)null)
	{
	}
}
