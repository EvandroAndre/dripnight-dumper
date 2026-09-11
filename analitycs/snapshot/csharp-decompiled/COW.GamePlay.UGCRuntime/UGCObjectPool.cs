using System;

namespace COW.GamePlay.UGCRuntime;

public class UGCObjectPool<T> where T : IUGCObjectPoolItem, new()
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<object> _003C_003E9__5_0;

		internal object _003CCreate_003Eb__5_0()
		{
			return null;
		}
	}

	private SimplePool simplePool;

	private int InitCountPerFrame;

	private int initLeft;

	public UGCObjectPool<T> Create(Func<object> New)
	{
		return null;
	}

	public UGCObjectPool<T> Create(int initCount = 0)
	{
		return null;
	}

	public void StartWarmUp(int addCount, int perFrameCount)
	{
	}

	public void StopWarmUp()
	{
	}

	public bool IsInitFinish()
	{
		return false;
	}

	public void AddInitItemOnTick()
	{
	}

	public void Put(IUGCObjectPoolItem item)
	{
	}

	public T Get()
	{
		return default(T);
	}

	public void EnableStatistics()
	{
	}

	public void GetStatistics(out int poolHits, out int newCreates)
	{
		poolHits = default(int);
		newCreates = default(int);
	}

	public void ResetStatistics()
	{
	}

	public int GetPoolCount()
	{
		return 0;
	}
}
