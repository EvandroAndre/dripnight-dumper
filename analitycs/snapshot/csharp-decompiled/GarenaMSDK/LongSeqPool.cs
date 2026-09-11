using System;
using System.Collections.Generic;

namespace GarenaMSDK;

public class LongSeqPool<T> : Pool<long, T>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<Dictionary<long, T>, long, T, long> _003C_003E9__0_0;

		internal long _003C_002Ector_003Eb__0_0(Dictionary<long, T> dict, long key, T value)
		{
			return 0L;
		}
	}

	public LongSeqPool()
		: base((Func<Dictionary<long, T>, long, T, long>)null)
	{
	}
}
