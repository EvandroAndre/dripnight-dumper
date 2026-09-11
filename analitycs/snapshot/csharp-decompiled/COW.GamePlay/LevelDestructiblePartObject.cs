using COW.GamePlay.UGCRuntime;
using GCommon;
using UnityEngine;

namespace COW.GamePlay;

public class LevelDestructiblePartObject : BaseLevelObject
{
	public uint PartDataID;

	public GameObject ServerCollider;

	private bool APNDBLCAMIP;

	private GameObject LLLGJAFNPMM;

	private ResourceID KGPHCHGFKJN;

	private bool ENCJGLNFGKA;

	private DestructibleObjectConfigData OMHPHBEFBKH;

	private uint IJFOOEENBBG;

	private uint HPINJBBEFIH;

	protected BitArrayBoolean CNELANECFHO;

	public bool JCIBPFKMMPC
	{
		set
		{
		}
	}

	protected override string GetObjectTag()
	{
		return null;
	}

	protected override void OnStart()
	{
	}

	public void SetInitialHP(uint NKGBIPINKIE)
	{
	}

	protected override void OnUserDefineReplicationInfo()
	{
	}

	public int GetCurHP()
	{
		return 0;
	}

	public void SetHP(int JHLNMNMLGPB)
	{
	}

	public uint GetStatus()
	{
		return 0u;
	}

	public void onStatusChange(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	protected override int GetMaxRepDataCount()
	{
		return 0;
	}

	public void SetNormalState()
	{
	}

	public void OnBroken()
	{
	}

	public bool OnNeedDestroy()
	{
		return false;
	}

	public void RecycleModel()
	{
	}

	public void LoadModel(bool LONOBDDEMCI)
	{
	}

	public override void OnSyncUGCEntityProperty(long OGDNBBJKNFD, UGCSimpleValue EIOKHLKJEEL)
	{
	}

	private void JPBBKEGNKIG()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnSyncUGCEntityProperty(long P0, UGCSimpleValue P1)
	{
	}
}
