using System.Collections.Generic;
using GCommon;
using message;

namespace COW.GamePlay;

public abstract class LevelObjectIceSculptureBase : BaseLevelObject
{
	private uint NDOAJJOPJHF;

	public bool TestDebug;

	private ResourceID DBLGNFIILFA;

	protected int HCKEMFFOPEF;

	protected int KNFDNGLBCEP;

	protected float OJNGHGHHLPJ;

	protected float PMPGHGFHCLF;

	public Dictionary<BHGGAEEHJCO, int> m_HotPursuitScanDict;

	public float KLEBPPAEOHF => 0f;

	public float JPFABEILOEM => 0f;

	public override void SyncAction(object[] DJAPBCKDFKA)
	{
	}

	public ResourceID GetIconRes()
	{
		return default(ResourceID);
	}

	public override void DoAction(object[] DJAPBCKDFKA)
	{
	}

	public void Init(ResourceID OCCLMDNGINA)
	{
	}

	public override void OnRecycle()
	{
	}

	public override bool Recycle()
	{
		return false;
	}

	protected virtual void HFBOKGMLJPO()
	{
	}

	protected override void OnUserDefineReplicationInfo()
	{
	}

	protected virtual void ENBDBKBLCFM(int GNBOOELAHNP, int LAHMCKAGGCO)
	{
	}

	private void AOCJIOHGHCO(int GNBOOELAHNP, int LAHMCKAGGCO)
	{
	}

	protected override int GetMaxRepDataCount()
	{
		return 0;
	}

	protected abstract BDNDCIPKGEC IOIFGDIFMGG();

	public int GetScanEnemyCountByPlayerID(BHGGAEEHJCO OBMFMAKFDDL)
	{
		return 0;
	}

	public void SetScanEnemyCountByPlayerID(BHGGAEEHJCO OBMFMAKFDDL, int PNLDKNOFPNG)
	{
	}

	protected float LPNOGKIHCBD()
	{
		return 0f;
	}

	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_DoAction(object[] P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnRecycle()
	{
	}

	public new bool _003C_003EiFixBaseProxy_Recycle()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return 0;
	}
}
