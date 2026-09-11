namespace COW.GamePlay.UGCRuntime;

public class UGCLogicEntityLinkInfo
{
	public UGCRuntime ugcRuntime;

	public string entityID;

	public long entityBridgingType;

	public string archTypeID;

	public UGCLogicEntityLinkInfo Create(UGCRuntime ugcRuntime, string entityRefID, long[] componentsRefID)
	{
		return null;
	}

	public UGCLogicEntityLinkInfo CreateForTarget(UGCRuntime ugcRuntime, string targetEntityID, UGCLogicEntity prefabEntity)
	{
		return null;
	}

	public UGCLogicEntityInternal FindLinkTarget()
	{
		return null;
	}
}
