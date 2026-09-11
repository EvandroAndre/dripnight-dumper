using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW.GamePlay;

internal class LevelAirdrop : BaseLevelObject
{
	public abstract class PIFFHELJGPI
	{
		public CBIINIKMINO NDMAKMHCKLG;

		public ELKJNHCLKBF EPOOCGNJOFD;
	}

	public class LAFEKGHFHGB : PIFFHELJGPI
	{
		public uint OJFBGFOOKEK;

		public LAFEKGHFHGB BLJEIAHKEPL(CBIINIKMINO DBJBCFOHNLG, ELKJNHCLKBF GDHOJCDAGHJ, uint DBHJCLICABH)
		{
			return null;
		}
	}

	public class JELNPOHJDJN : PIFFHELJGPI
	{
		public JELNPOHJDJN BLJEIAHKEPL(CBIINIKMINO DBJBCFOHNLG)
		{
			return null;
		}
	}

	public class JIKFPDDMJMN : PIFFHELJGPI
	{
		public uint OJFBGFOOKEK;

		public JIKFPDDMJMN BLJEIAHKEPL(CBIINIKMINO DBJBCFOHNLG, ELKJNHCLKBF GDHOJCDAGHJ, uint DBHJCLICABH)
		{
			return null;
		}
	}

	public class FNIDIIDLJJP : PIFFHELJGPI
	{
		public FNIDIIDLJJP BLJEIAHKEPL(CBIINIKMINO DBJBCFOHNLG)
		{
			return null;
		}
	}

	public class DFJKLIMGGBD : PIFFHELJGPI
	{
		public DFJKLIMGGBD BLJEIAHKEPL(CBIINIKMINO DBJBCFOHNLG)
		{
			return null;
		}
	}

	public class FKEMDNKFFGM : PIFFHELJGPI
	{
		public uint OJFBGFOOKEK;

		public FKEMDNKFFGM BLJEIAHKEPL(CBIINIKMINO DBJBCFOHNLG, ELKJNHCLKBF GDHOJCDAGHJ, uint DBHJCLICABH)
		{
			return null;
		}
	}

	public enum CBIINIKMINO
	{
		SYNC_STATE,
		INTO_WATER,
		SYNC_REENTER,
		SYNC_ZombieSurprise,
		DESTROY,
		ICE_DESTRUCTIBLE_SYNC
	}

	private enum HABLCHIIJLE
	{
		None,
		Wait,
		Show,
		Hide,
		Destroy
	}

	private enum NANLFOCFFEM
	{
		EAirdropModelAction_EnterStable,
		EAirdropModelAction_EnterWater,
		EAirdropModelAction_Reenter,
		EAirdropModelAction_SyncServerLanded
	}

	private abstract class OFCCHGDEGIJ
	{
	}

	private struct MBMALEGIENJ
	{
		public NANLFOCFFEM AHKKHLOHCKM;

		public OFCCHGDEGIJ DJKGALJOJGF;
	}

	private class LJBAALIHDEE : ShadowStateBase
	{
		public Vector3 PHEOMEDPGED;

		public Quaternion GBHPAJHAAMF;

		public Vector3 AALEAHDJAMC;

		public Quaternion DOGHPBHDLCJ;

		public Vector3 AAPGPMPKMBD;
	}

	public static LAFEKGHFHGB levelAirdropSyncState;

	public static JELNPOHJDJN levelAirdropInfoWater;

	public static JIKFPDDMJMN levelAirdropSyncReenter;

	public static FNIDIIDLJJP levelAirdropZombieSurprise;

	public static DFJKLIMGGBD levelAirdropDestroy;

	public static FKEMDNKFFGM levelAirdropIceDestructibleSync;

	private Airdrop DKBDPFLEOIA;

	private bool PGIIPJPEPLF;

	private bool FDKLJIICNJD;

	private bool JNEIDFKHMIC;

	private float CBGIAMCIMGL;

	private uint KDBDOBILAKE;

	private VisualInstanceHolder PPHBEPBCLMO;

	private VisualInstanceHolder IAOCKOAELGP;

	private GameObject KKIJFEDKIJI;

	private Color EKBDMNAANHC;

	private VisualInstanceHolder JCGGMLEFCDF;

	private HABLCHIIJLE KBIPMANHJFH;

	private ResourceID EKJBJMCKOEN;

	public uint OwnerPlayerID;

	private Airdrop.DNFFHCFAHGM _003CDGEKALDBDJL_003Ek__BackingField;

	public uint AirdropMarkMainItemID;

	private uint _003CKKMKAJHDNDI_003Ek__BackingField;

	private bool EJLMKCHCLNP;

	private uint BOAIGNNFABO;

	private readonly EntityVisualEffectManager EINPMFNJINA;

	private uint EOMLLPBDDOI;

	private uint HNCBCNEJOCL;

	private Animator COCOGPPIKDD;

	private uint MLNNDBJNIDF;

	private Queue<MBMALEGIENJ> BEIOKGABIJH;

	private uint KDNHPBIEKFD;

	private ResourceID DPMNFIPLJFH;

	private uint FGBFGJIHJME;

	private bool MEJDBLCKGEL;

	private ResourceID HFDADIABEPN;

	public ResourceID m_AsyncModelResID;

	public GameObject m_ModelObject;

	protected uint IAPBBEEDLCG;

	protected Vector3 EKAJFAINGNC;

	private LJBAALIHDEE LAPJPJICGJD;

	private bool GEGODLFBCOG;

	private Queue<Vector3> JEOMCIOKJCD;

	private Vector3 ENPLBBCFPGE;

	public bool IsLanding;

	private bool CAOMDKGNEDJ;

	private Vector3 DMIFNAMKGGM;

	private float IPHDKPPMLAK;

	public Airdrop.DNFFHCFAHGM CEDIHMKMHKI
	{
		get
		{
			return Airdrop.DNFFHCFAHGM.AIRDROPNORMAL;
		}
		private set
		{
		}
	}

	public uint IHIDANHBMFP
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public bool OHFMMLCIFEF => false;

	public Vector3 CLNIPGLOEMG => default(Vector3);

	protected override string GetObjectTag()
	{
		return null;
	}

	public void SetShowOnMap(bool EOGOGFLCEHL, Airdrop.DNFFHCFAHGM AMOKBPJEDJB)
	{
	}

	public override void OnUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	protected override void OnOnDestroy()
	{
	}

	private void BMEKBIFNJFC(bool EOGOGFLCEHL)
	{
	}

	public override void SyncAction(object[] DJAPBCKDFKA)
	{
	}

	public override void OnReUse()
	{
	}

	public override void OnRecycle()
	{
	}

	public override bool Recycle()
	{
		return false;
	}

	public void ProcessAirDropBreathEffect(bool IHLDAIHLHKH, bool LLBIFBFCLHK, uint BBEKDGNFBIP = 0u)
	{
	}

	private void JBDBHOIGKBJ()
	{
	}

	private void MKHMNOGIGOF()
	{
	}

	private void FEDLAKNNEOI(bool MIBHDOJIHJE)
	{
	}

	private void PGANNPNLHPD(GameObject CLACOPMJHDI)
	{
	}

	private void DBKCLGPKOKN(ELKJNHCLKBF EPOOCGNJOFD)
	{
	}

	private void MBDAIMEMECM()
	{
	}

	private void PFNHAGAOJGM()
	{
	}

	private void KJLBHAEEOAI()
	{
	}

	public void SyncIceDestructibleAirdropInitState(ELKJNHCLKBF EPOOCGNJOFD)
	{
	}

	public void SyncIceDestructibleAirdropState(ELKJNHCLKBF EPOOCGNJOFD)
	{
	}

	public bool IsIceDestructibleAirdrop()
	{
		return false;
	}

	public bool IsMeteoriteAirdrop()
	{
		return false;
	}

	public void LoadSpawnVfx()
	{
	}

	protected override void OnUpdateVisibleStateByStreamer(Vector3 MHAAFMCMHAC, Vector3 PAFBAHJAAGC)
	{
	}

	private void ILPADGDNBBO(bool LLBIFBFCLHK, uint BBEKDGNFBIP)
	{
	}

	private float GOFLFEIEJFA()
	{
		return 0f;
	}

	private void OBDJPMLMOPJ(uint PLNDNBINKOA, ResourceID CICBIIJABAP, GameObject CLACOPMJHDI)
	{
	}

	public void ShowAirDropWeaponLevelBoxVFX(bool IHLDAIHLHKH, bool LLBIFBFCLHK, uint IDAHCFCBLBA, Vector3 DFNHOKCIIJK, Vector3 GLPLIHEECAP)
	{
	}

	public void RecyleAirDropWeaponLevelBoxVFX()
	{
	}

	private void FGFAHNDMILP(GameObject CLACOPMJHDI)
	{
	}

	public void PlayUpgradeGemLoopEffect(Vector3 HCPPKIHKCEP)
	{
	}

	private void ILHGMBOGJEL(GameObject CLACOPMJHDI)
	{
	}

	public void PlayUpgradeGemUnlockEffect()
	{
	}

	private void JPOFBNDGKBI(bool MIBHDOJIHJE)
	{
	}

	public void LoadModel(bool NPPFIPPGKDP, ResourceID BIHBIINNGIK, ResourceID PPNFFDDNMJE)
	{
	}

	private uint MJNOIOHHDBI(ResourceID EJPBBEFLHNA)
	{
		return 0u;
	}

	private void FGPNMOGOFLB(ResourceID BIHBIINNGIK)
	{
	}

	private void MKOMLLNAIJC(uint GGAOIPIHOBP, bool BBPCHCNOECP, Object HACIJIFIDKM)
	{
	}

	private void GGHBJKDGFBE(GameObject HODGMGDDABK)
	{
	}

	private void JHFPDDJOCHC(Airdrop CNKNCPNCLGL)
	{
	}

	private void EAFDNGJPDEN()
	{
	}

	private void IPHEKOHIOPB(NANLFOCFFEM DBJBCFOHNLG, OFCCHGDEGIJ KEILNEEPFGD = null)
	{
	}

	private void ABDKLECKBLG(NANLFOCFFEM DBJBCFOHNLG, OFCCHGDEGIJ KEILNEEPFGD = null)
	{
	}

	protected override void OnAwake()
	{
	}

	public void SetNeedForceUpdate(bool GPFPIAMCEMI)
	{
	}

	public virtual void PushSyncState(ELKJNHCLKBF EPOOCGNJOFD, uint OJFBGFOOKEK)
	{
	}

	public override void OnFixedUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private void IOJOPBNIJIF()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUpdate(float P0, float P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnReUse()
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

	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	public void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}
}
