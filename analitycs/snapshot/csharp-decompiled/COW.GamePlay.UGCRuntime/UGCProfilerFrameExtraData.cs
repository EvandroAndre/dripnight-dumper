using System;

namespace COW.GamePlay.UGCRuntime;

[Serializable]
public class UGCProfilerFrameExtraData
{
	public ProfilerEntityInfo[] addEntityData;

	public ProfilerEntityInfo[] removeEntityData;

	public int sceneDrawCalls;

	public float physicsCostMs;

	public int triangleCount;

	public int effectCount;

	public int particleCount;

	public long totalUsedBytes;
}
