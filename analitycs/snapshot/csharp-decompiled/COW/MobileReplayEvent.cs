using System;

namespace COW;

[Serializable]
public class MobileReplayEvent
{
	public float Time;

	public uint EventGroup;

	public byte Index;

	public bool Contains(uint group, float point)
	{
		return false;
	}
}
