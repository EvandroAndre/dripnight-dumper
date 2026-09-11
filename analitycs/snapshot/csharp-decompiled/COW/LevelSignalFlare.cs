using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class LevelSignalFlare : BaseLevelObject
{
	private bool m_NeedDestroy;

	private GameObject m_EffectObj;

	private ResourceID m_EffectResID;

	private Airdrop.DNFFHCFAHGM m_AirDropType;

	private FEKBCHODFLE m_AsyncLoadTickets;

	protected override void OnOnDestroy()
	{
	}

	protected override string GetObjectTag()
	{
		return null;
	}

	public override void SyncAction(object[] param)
	{
	}

	private void DelegateAsyncLoadEffect(uint ticket, bool succeeded, Object obj)
	{
	}

	public bool OnAirDropLanded()
	{
		return false;
	}

	public override void OnRecycle()
	{
	}

	public override bool Recycle()
	{
		return false;
	}

	private void DestroySignalFlare()
	{
	}

	public override void RecycleForInGameReload()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnRecycle()
	{
	}

	public new bool _003C_003EiFixBaseProxy_Recycle()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_RecycleForInGameReload()
	{
	}
}
