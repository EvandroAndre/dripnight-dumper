using System.Collections.Generic;
using COW.GamePlay;
using COW.GamePlay.UGCRuntime;
using message;

namespace COW.Gameplay.UGC;

public class UGCLogicEntityBridgingMgr
{
	private Dictionary<string, IUGCLogicEntityBridging> m_logicEntityBridgingMap;

	public void Destroy()
	{
	}

	public IUGCLogicEntityBridging CreateBridging(string typeName, string entityID, SceneEditObjectBase editObj)
	{
		return null;
	}

	public void RemoveBridging(string entityID)
	{
	}

	public void InitializeUGCLogicEntityRepDataItem(string entityID, INAMDLOFOHF entityData)
	{
	}

	private void RemoveEmptyLevelObjectIDRepItems(UGCRuntime ugcRuntime, UGCEntityRepData entityRepData)
	{
	}

	public IUGCLogicEntityBridging GetBridging(string entityID)
	{
		return null;
	}
}
