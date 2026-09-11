using GCommon;
using UnityEngine;
using message;

namespace COW.GamePlay;

public class LevelTreasure : BaseLevelObject
{
	public PickupTreasureBox m_PickupTreasureBox;

	public ulong m_OwnerID;

	public bool m_IsDiggedOut;

	public uint m_ContainerID;

	public DHFCAKKIKOD m_TreasureType;

	private uint DGCHOGOIBJM;

	protected override string GetObjectTag()
	{
		return null;
	}

	private void MKOMLLNAIJC(uint JDHNCLHNJIP, ResourceID JMIMKLAELHE, GameObject KGJNMPHDKAB)
	{
	}

	public override void SyncAction(object[] DJAPBCKDFKA)
	{
	}

	public void OnTreasureTrigger(bool EKMOGLAFDHO)
	{
	}

	public override bool Recycle()
	{
		return false;
	}

	public override void OnRecycle()
	{
	}

	public override void OnReUse()
	{
	}

	public void Delete()
	{
	}

	private void LNIAAGLHPOO()
	{
	}

	public override void RecycleForInGameReload()
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

	public void _003C_003EiFixBaseProxy_OnReUse()
	{
	}

	public void _003C_003EiFixBaseProxy_RecycleForInGameReload()
	{
	}
}
