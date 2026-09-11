using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW.GamePlay;

internal class LevelUAV : AttackableEntity
{
	protected class LJBAALIHDEE : ShadowStateBase
	{
		public Vector3 AALEAHDJAMC;

		public Vector3 PHEOMEDPGED;

		public Quaternion DOGHPBHDLCJ;

		public Quaternion GBHPAJHAAMF;
	}

	protected uint IAPBBEEDLCG;

	protected LJBAALIHDEE LAPJPJICGJD;

	public uint UAV_ID;

	public string m_ModelResID;

	private uint DGCHOGOIBJM;

	public GameObject m_ModelObject;

	public Animation m_Animation;

	private bool NDBHDFFNGEG;

	public BHGGAEEHJCO m_OwnerID;

	public uint m_UAVItemID;

	public GameObject VFXRoot;

	public const string IdleAnimName = "Idle";

	public const string FlyAnimName = "Fly_F";

	public const string ANIM_SPEED_PARAM = "Speed";

	public EKLALLOELLG m_IconStyle;

	public float m_Radius;

	private bool DBJFKNIIAMC;

	public HCFAJFBKDIJ m_VisualType;

	private const float JDFHKFPBKIH = 18f;

	private float MOCJADNCBNH;

	public Vector3 m_TargetDirection;

	private string MKAGOJLDEAO;

	private uint HBNFFBAHNNN;

	private uint LIBOFJAEJAB;

	private uint NENEBONLKOL;

	private uint MLFFGNEAGFC;

	private uint LLGFAGFHMHP;

	private GameObject NKMPNBDCOEC;

	private ResourceID LJODAKGHAHM;

	private ResourceID NBEGIMMAFBB;

	private uint EGHLBLGLDKK;

	private const float BCOJNCHAIGP = 2.5f;

	private const float IFKHJKGGECL = 2.5f;

	private bool NMDABGMFHHN;

	private uint KLEOJENNBBA;

	private float BKEAMFCMAAC;

	private GameObject NNOBAEHBAGA;

	private VisualInstanceHolder GGFLFJOPBNI;

	private uint LOFANKDFPJB;

	public HCFAJFBKDIJ LPDLNOONDKC => HCFAJFBKDIJ.EUAV_VISUALTYPE_NONE;

	public void ResetLastValidTickCount()
	{
	}

	public void Init(uint AHOCAOCLHHP, uint CPDCONFICBP = 0u, uint GEHJJDLAGJJ = 0u, byte PDILMIOIOHE = 0, float NMEEAHMNACE = 0f, uint MHIHBHDMFCN = 0u, uint OPOEOPALIHP = 0u, uint ODNKFIPHMEB = 0u, uint BADGKIEJIJE = 0u)
	{
	}

	public static bool IsTreasuryUAV(HCFAJFBKDIJ BADGKIEJIJE)
	{
		return false;
	}

	private void MKOMLLNAIJC(uint JDHNCLHNJIP, ResourceID JMIMKLAELHE, GameObject KGJNMPHDKAB)
	{
	}

	private void HEFPCMKMKID(uint JDHNCLHNJIP, ResourceID JMIMKLAELHE, GameObject KGJNMPHDKAB)
	{
	}

	private void DCPCAHCJODH(HCFAJFBKDIJ BADGKIEJIJE)
	{
	}

	private void IMANKKLEBMA(uint JDHNCLHNJIP, ResourceID JMIMKLAELHE, GameObject KGJNMPHDKAB)
	{
	}

	public void PushSyncState(Vector3 IGDHIDGLOKG, uint OJFBGFOOKEK)
	{
	}

	public void OnHealUavSyncState(Vector3 IGDHIDGLOKG, uint OJFBGFOOKEK)
	{
	}

	public void SyncInvincibleState(bool KBMAJKPAMML)
	{
	}

	public override void OnFixedUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public bool IsIceWallBuffUAV()
	{
		return false;
	}

	public bool IsHealUAV()
	{
		return false;
	}

	public bool CanShowHudUAVHP()
	{
		return false;
	}

	public override void TakeDamage(GLLLEDKLLDA PMMCGNJHOOA, LOAEBBHPMEK AOJANNHGCEA = null, List<float> LFLPGCMLPFM = null, uint FKDEIFDNMJD = 0u)
	{
	}

	public void Dead(int OGGDMKGPFNP)
	{
	}

	public override void OnRecycle()
	{
	}

	public override void RecycleForInGameReload()
	{
	}

	public GKLDCJLLGHP GetUavDATA()
	{
		return null;
	}

	public void UpdateAnim(float IMKNJGHAHPI)
	{
	}

	private void BENDFKJKGPP()
	{
	}

	private void ODEIGGDNOBB(GameObject CLACOPMJHDI)
	{
	}

	protected override void OnUserDefineReplicationInfo()
	{
	}

	protected override int GetMaxRepDataCount()
	{
		return 0;
	}

	public float GerCurfillAmount()
	{
		return 0f;
	}

	public void ShowHudUAVHP()
	{
	}

	private void GOCOFIKCFCK(Vector3 IGDHIDGLOKG)
	{
	}

	public void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}

	public void _003C_003EiFixBaseProxy_TakeDamage(GLLLEDKLLDA P0, LOAEBBHPMEK P1, List<float> P2, uint P3)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnRecycle()
	{
	}

	public void _003C_003EiFixBaseProxy_RecycleForInGameReload()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}
}
