using COW.GamePlay;
using UnityEngine;

namespace COW;

public class LevelUGCSpawnPos : BaseAutoGenIDLevelObject
{
	public Transform[] points;

	public LevelDynamicCollider dynamicCollider;

	protected override string GetObjectTag()
	{
		return null;
	}

	protected override void OnStart()
	{
	}

	public override void SyncAction(object[] param)
	{
	}

	private void DoUgcLevelObjectDel()
	{
	}

	private void DoUgcLevelObjectAdd(object[] data)
	{
	}

	public string _003C_003EiFixBaseProxy_GetObjectTag()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}
}
