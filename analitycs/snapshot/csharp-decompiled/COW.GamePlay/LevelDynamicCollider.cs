using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;
using GCommon;
using UnityEngine;
using message;

namespace COW.GamePlay;

public class LevelDynamicCollider : BaseLevelObject
{
	public enum PONNBKMDCJN
	{
		Add
	}

	public static Dictionary<uint, uint> PendingEntityGameID2RepID;

	public bool isDynamic;

	public LMEPCDHNOAO colliderType;

	public GameObject hideModelOrVFX;

	protected const uint PLKFEGEFNJK = 2u;

	private Collider[] PDJCPFLHOCF;

	public bool blockInitialValue;

	public int DisableInLevelID;

	public bool isDestructive;

	public string prefabColliderResName;

	private ResourceID IDNJJDDJNGD;

	private uint GFHLIHAGHJE;

	private EntityVisualEffectManager EINPMFNJINA;

	private VisualInstanceHolder HAJEKDLBKKM;

	private uint ENGONDNFMJA;

	private float NENGJNEOAKG;

	private GameObject HBOPFKJJKPL;

	public bool HIFPHDOPJIN => false;

	public static void AddEntityGameID2RepID(uint GFDDIBHJEAA, uint DDAHKMAFFNE)
	{
	}

	public static void RemoveEntityGameID2RepID(uint MHMIOIODCFD)
	{
	}

	private EntityVisualEffectManager GOKDPINCDCJ()
	{
		return null;
	}

	protected override string GetObjectTag()
	{
		return null;
	}

	protected override void OnAwake()
	{
	}

	public override bool Recycle()
	{
		return false;
	}

	protected override void OnOnDestroy()
	{
	}

	protected override void OnUserDefineReplicationInfo()
	{
	}

	protected override int GetMaxRepDataCount()
	{
		return 0;
	}

	public override void SyncAction(object[] DJAPBCKDFKA)
	{
	}

	public void UpdatePropEnable()
	{
	}

	private void ELAOHNBCICH(bool OJEPOBEENEK, bool EIOKHLKJEEL)
	{
	}

	private void EAPHIIOHJEK(bool KGOHDEBHENF)
	{
	}

	protected override void OnUpdateVisibleStateByStreamer(Vector3 MHAAFMCMHAC, Vector3 PAFBAHJAAGC)
	{
	}

	public virtual void SetIsEnabled(bool AOOAGBBHDFA)
	{
	}

	public override void OnSyncUGCEntityProperty(long OGDNBBJKNFD, UGCSimpleValue EIOKHLKJEEL)
	{
	}

	public bool RegisterCustomStyleVfx(ResourceID KPCOEDMDBIK)
	{
		return false;
	}

	private void EIPFMMLMJAD()
	{
	}

	private void KEOLFIGIJCH(uint LKHIALHNOLD, ResourceID GGMIDNEJGNO, GameObject KGJNMPHDKAB)
	{
	}

	private void KNBCCMELMLL(bool HCLGHJNEFIC)
	{
	}

	private void JIFBELCHEGP(ResourceID GGMIDNEJGNO)
	{
	}

	private VisualInstanceHolder CMFECJIJGOK()
	{
		return null;
	}

	private void IOPMOJKHGNO()
	{
	}

	private void HHPAGDAOOFJ()
	{
	}

	private void FBKCHBGGDHJ()
	{
	}

	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	public new bool _003C_003EiFixBaseProxy_Recycle()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUpdateVisibleStateByStreamer(Vector3 P0, Vector3 P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnSyncUGCEntityProperty(long P0, UGCSimpleValue P1)
	{
	}
}
