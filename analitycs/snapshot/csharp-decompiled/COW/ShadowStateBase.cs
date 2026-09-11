namespace COW;

internal class ShadowStateBase
{
	public uint TargetTickCount;

	public uint SimTick;

	public float SimStartTime;

	public float SimTargetTime;

	public float LastLerpTime;

	public virtual void Clear()
	{
	}

	public bool IncreaseSimTick()
	{
		return false;
	}

	public float GetDeltaTimeInLerp()
	{
		return 0f;
	}

	public float GetLerpRatio()
	{
		return 0f;
	}

	public float GetRenderLerpRatio()
	{
		return 0f;
	}
}
