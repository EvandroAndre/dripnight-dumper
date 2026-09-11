using System;
using System.Collections.Generic;

namespace COW.OpSysExt;

public abstract class OpSysExt
{
	protected class Pool<K, V>
	{
		protected K _Key;

		protected Dictionary<K, V> _Pool;

		protected Func<Dictionary<K, V>, K, V, K> _KeyGen;

		public Pool(Func<Dictionary<K, V>, K, V, K> keyGen)
		{
		}

		public K Save(V value)
		{
			return default(K);
		}

		public bool Has(K id)
		{
			return false;
		}

		public V Get(K id)
		{
			return default(V);
		}

		public bool TryGet(K id, out V result)
		{
			result = default(V);
			return false;
		}

		public V Take(K id)
		{
			return default(V);
		}

		public bool TryTake(K id, out V result)
		{
			result = default(V);
			return false;
		}
	}

	protected class LongSeqPool<T> : Pool<long, T>
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

	protected class GuidPool<T> : Pool<string, T>
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

	protected class HashCodePool<T> : Pool<int, T>
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Func<Dictionary<int, T>, int, T, int> _003C_003E9__0_0;

			internal int _003C_002Ector_003Eb__0_0(Dictionary<int, T> dict, int key, T value)
			{
				return 0;
			}
		}

		public HashCodePool()
			: base((Func<Dictionary<int, T>, int, T, int>)null)
		{
		}
	}

	public class LogLevels
	{
		public const int NONE = 0;

		public const int ERROR = 1;

		public const int WARNING = 2;

		public const int INFO = 3;

		public const int DEBUG = 5;
	}

	public Action<string, object[]> OnLog;

	public int LogLevel;

	protected void Log(int level, string format, object[] args)
	{
	}
}
