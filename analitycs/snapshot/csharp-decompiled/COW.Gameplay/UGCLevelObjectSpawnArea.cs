using COW.GamePlay;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW.Gameplay;

public class UGCLevelObjectSpawnArea : BaseAutoGenIDLevelObject
{
	public GameObject edittimeVFX;

	public LevelDynamicCollider dynamicCollider;

	public bool blockScale;

	protected override string GetObjectTag()
	{
		return null;
	}

	public override void SyncAction(object[] param)
	{
	}

	public override void OnSyncUGCEntityProperty(long propertyIndex, UGCSimpleValue newValue)
	{
	}

	public override bool CreateDynamicallyForUGC(string entityID)
	{
		return false;
	}

	public string _003C_003EiFixBaseProxy_GetObjectTag()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnSyncUGCEntityProperty(long P0, UGCSimpleValue P1)
	{
	}

	public bool _003C_003EiFixBaseProxy_CreateDynamicallyForUGC(string P0)
	{
		return false;
	}
}
