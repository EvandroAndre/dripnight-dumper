using UnityEngine;

namespace COW.GamePlay;

public class LevelSupply : BaseLevelObject
{
	public uint MissionType;

	public Collider m_Trigger;

	protected bool IMIDFBOODAH;

	protected override string GetObjectTag()
	{
		return null;
	}

	protected override void OnStart()
	{
	}

	public override void SyncAction(object[] DJAPBCKDFKA)
	{
	}

	public override bool Recycle()
	{
		return false;
	}

	public override void OnRecycle()
	{
	}

	public void RefreshEffect()
	{
	}

	public override void DoAction(object[] DJAPBCKDFKA)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}

	public new bool _003C_003EiFixBaseProxy_Recycle()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnRecycle()
	{
	}

	public void _003C_003EiFixBaseProxy_DoAction(object[] P0)
	{
	}
}
