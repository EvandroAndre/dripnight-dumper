using System.Collections.Generic;

namespace COW.GamePlay.UGCRuntime;

public class ProfilerFrame
{
	public int frameIndex;

	public float timeOffsetMs;

	public float totalCpuMs;

	public long totalMemoryDelta;

	public List<ProfilerSample> samples;

	public UGCProfilerFrameExtraData extraData;

	public void Reset(int index)
	{
	}
}
