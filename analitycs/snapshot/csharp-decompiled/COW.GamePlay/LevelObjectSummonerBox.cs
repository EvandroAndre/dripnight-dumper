using UnityEngine;

namespace COW.GamePlay;

public class LevelObjectSummonerBox : BaseLevelObject
{
	public Collider m_Trigger;

	public uint OwnerID;

	protected override string GetObjectTag()
	{
		return null;
	}

	protected override void OnModelShowed()
	{
	}

	public override void SyncAction(object[] DJAPBCKDFKA)
	{
	}

	public void Destroy()
	{
	}

	public override bool Recycle()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnModelShowed()
	{
	}

	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}

	public new bool _003C_003EiFixBaseProxy_Recycle()
	{
		return false;
	}
}
