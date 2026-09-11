using GCommon;
using UnityEngine;
using message;

namespace COW.GamePlay;

public class LevelLockBountyVehicle : BaseLevelObject
{
	public Collider m_InteractCollider;

	private GOENNGGJIEH MAOHIOEAMEA;

	private uint ODFDKIDBPPC;

	public GameObject m_LockVfx;

	public GameObject m_UnlockNumVfx;

	private uint HNMOBBNOKDI;

	private uint NAFCMDNCABC;

	private GameObject MBFAPNPODEK;

	private bool JEJMIOFKMKJ;

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

	public override void OnRecycle()
	{
	}

	public override bool Recycle()
	{
		return false;
	}

	private void NHFLJDGOHDO()
	{
	}

	public void OnLocalPlayerRevived()
	{
	}

	public void OnLocalPlayerDead()
	{
	}

	protected override void OnUpdateVisibleStateByStreamer(Vector3 MHAAFMCMHAC, Vector3 PAFBAHJAAGC)
	{
	}

	private new void HNKHOBJPHOO()
	{
	}

	private void IGIIALBLLFK(bool OGECPGHMIHA)
	{
	}

	private void BKFGPMOOIPJ(uint PLNDNBINKOA, ResourceID CICBIIJABAP, GameObject KGJNMPHDKAB)
	{
	}

	private void OBADLGDJMEP(uint PLNDNBINKOA, ResourceID CICBIIJABAP, GameObject KGJNMPHDKAB)
	{
	}

	private void FNHBCIOKPCD()
	{
	}

	public void OnReachUnlockThres()
	{
	}

	private void BGAIIODGMCK()
	{
	}

	protected override void OnOnDestroy()
	{
	}

	public GOENNGGJIEH GetCurState()
	{
		return GOENNGGJIEH.ELockBountyVehicleState_Lock;
	}

	public uint GetUnlockCost()
	{
		return 0u;
	}

	public new void _003C_003EiFixBaseProxy_OnStart()
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

	public new void _003C_003EiFixBaseProxy_OnUpdateVisibleStateByStreamer(Vector3 P0, Vector3 P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}
}
