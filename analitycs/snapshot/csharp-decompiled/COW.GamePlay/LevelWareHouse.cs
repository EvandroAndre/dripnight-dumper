using UnityEngine;

namespace COW.GamePlay;

public class LevelWareHouse : BaseLevelObject
{
	public enum LOHDHKBHHKE
	{
		Warehouse_None,
		Warehouse_Normal,
		Warehouse_Damaged,
		Warehouse_Broken
	}

	public enum PKKDJGADIEN
	{
		Add,
		Destroy
	}

	private Warehouse JMODJDEBGIF;

	public uint m_TeamIndex;

	private float HIGOIOPAIHM;

	private const float LLLMIONBACF = 5f;

	public GameObject m_NormalEffect;

	public GameObject m_DamagedEffect;

	public GameObject m_BrokenEffect;

	private GameObject DGINKCNCIOD;

	private LOHDHKBHHKE MJPHBDEGAEM;

	public int IOGONNLBJMO => 0;

	public int LMNKLKFOOOF => 0;

	protected override string GetObjectTag()
	{
		return null;
	}

	protected override int GetMaxRepDataCount()
	{
		return 0;
	}

	public bool IsMyTeam(int HPBLCDJHHIH)
	{
		return false;
	}

	protected override void OnUserDefineReplicationInfo()
	{
	}

	protected void KFOLHOPJBAC(ushort OJEPOBEENEK, ushort EIOKHLKJEEL)
	{
	}

	private void GJDCCHCGPEP()
	{
	}

	protected void IADNNOOHLBD(ushort OJEPOBEENEK, ushort EIOKHLKJEEL)
	{
	}

	public override void OnRecycle()
	{
	}

	public override bool Recycle()
	{
		return false;
	}

	public override void SyncAction(object[] DJAPBCKDFKA)
	{
	}

	public void ShowInMap(bool PIMBMKMADMG)
	{
	}

	public override void RecycleForInGameReload()
	{
	}

	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnRecycle()
	{
	}

	public new bool _003C_003EiFixBaseProxy_Recycle()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_RecycleForInGameReload()
	{
	}
}
