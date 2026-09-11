using System.Collections.Generic;

namespace COW.GamePlay.UGCRuntime;

public class IndexRecyclePool
{
	public const uint IndexRecyclePool_InvalidIndex = 0u;

	public const uint IndexRecyclePool_StartIndex = 1u;

	public const uint IndexRecyclePool_MaxPrioritySeed = 1024u;

	private uint seed;

	private List<uint> pool;

	public IndexRecyclePool Create()
	{
		return null;
	}

	public void Push(uint value)
	{
	}

	public uint Pop()
	{
		return 0u;
	}

	private uint _Pop()
	{
		return 0u;
	}
}
