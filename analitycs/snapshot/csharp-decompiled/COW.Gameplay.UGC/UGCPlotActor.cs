namespace COW.Gameplay.UGC;

public class UGCPlotActor : UGCResource
{
	public string ActorId;

	public string ActorName;

	public string ActorIcon;

	public override bool LoadFromData(byte[] data)
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_LoadFromData(byte[] P0)
	{
		return false;
	}
}
