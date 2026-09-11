namespace COW.GamePlay;

public class LevelFeedZone : BaseLevelObject
{
	public uint teammodeid;

	public int milestoneid;

	public void OnLocalPlayerEnterTrigger()
	{
	}

	public void OnLocalPlayerExitTrigger()
	{
	}

	protected override string GetObjectTag()
	{
		return null;
	}

	public override void OnRecycle()
	{
	}

	public override bool Recycle()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnRecycle()
	{
	}

	public new bool _003C_003EiFixBaseProxy_Recycle()
	{
		return false;
	}
}
