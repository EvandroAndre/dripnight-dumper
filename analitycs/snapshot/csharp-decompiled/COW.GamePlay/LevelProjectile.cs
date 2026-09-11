using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW.GamePlay;

internal class LevelProjectile : BaseLevelObject
{
	public enum FHHGDLPCCJE
	{
		flash_effect,
		alert_effect,
		trail_effect
	}

	public struct HNOLJPFBPAG
	{
		public BHGGAEEHJCO JBAKACDLDHL;

		public uint INIOPODNEKD;

		public TssSdtInt FKNHDJDGIAK;

		public float MPNKBDPOCKG;

		public float GLILMNKFIFJ;

		public float CHJBIIACNDE;

		public TssSdtInt OFDKFOGKAEN;

		public int NCBPHIJGCCN;

		public EJNFNOJNCPE FCLFBJKEHGH;

		public Vector3 CGPGMFFKLOJ;

		public float HKHEJMGNENL;

		public int PCPJPLDKKNI;

		public uint NJNHFFFPDLJ;

		public Vector3 LMAEGPEAECO;

		public float FJMAGPNDCBA;

		public float PPNDHNPHIPA;

		public float FGIEKNKJPJM;

		public float ABJMMJKGBFA;

		public float PNFNEGNMGMN;

		public float JKOHJNGJILP;

		public float OKGPHACGLEO;

		public float MOPINLAEOFH;

		public float AICKCNKKIBN;

		public FDAEPHMIEPC.DBENAPILEBC KPAKIMLMBBC;

		public int MFNKLGJEAOL;

		public float MBAHMAKHEKA;

		public float DBJPFJMAFLO;

		public uint JEGNFGHIBHB;

		public void DCBKFKBIPAC()
		{
		}
	}

	public enum NBGACPKAFHI
	{
		SYNC_STATE,
		THROW,
		EXPLODE,
		SYNC_PENETRATE_EFFECT,
		Destroy
	}

	private sealed class ONOBOGBCNFN
	{
		public FJEEGHOAKOG NCDMEOCGCKM;

		public LevelProjectile KOKNHFGCGLN;

		public GameObject CLACOPMJHDI;

		public float EADCLPJOPBD;

		public uint LNPAIODLLGM;

		internal void CALJIOPGLJK()
		{
		}
	}

	private sealed class ILLPCDIAEGO
	{
		public LevelProjectile KOKNHFGCGLN;

		public Player PGEGMKJKOKI;

		internal bool PNIBBLAMNDB()
		{
			return false;
		}

		internal bool OFCPCLBMFOF()
		{
			return false;
		}
	}

	private LayerMask AJGNNPCLIKD;

	private Vector3 FFMKOOHGMAB;

	private Vector3 DOGNJGMMPOF;

	private float HCMNPCDHLML;

	private static readonly float BOEMJFONFEK;

	private bool PCBPGLGHPCA;

	private GMPGMPFNMFP NKEPDPFIOFJ;

	private GMPGMPFNMFP GPNAIMKENKD;

	private GMPGMPFNMFP HDDNFBFKNEN;

	private GMECHKEDOJP ADECKCPNEBN;

	private bool DCLKGJHJNAD;

	private float CABCNPDHLOC;

	private float HOCKFEHJGCE;

	protected JNHIOHFMPFN AEBAGCKEJIC;

	private Vector3 GCINJHBNPKA;

	private uint JDGBKCKHNGK;

	private uint CEMLGELEMEI;

	private bool PJCKNBAGHFF;

	private float OIEPFHFCDEI;

	private float GGOHFAPAHMG;

	private bool JIOOJGDGDOB;

	private bool IBFFOKPFIJL;

	private bool GKLAACMBKEJ;

	private float JNGAFPEHOPF;

	private float MLPDHEFBJKF;

	private float EMKMMFDBNCJ;

	private float LGDGNLBEPPK;

	private uint CFBGIFPABCE;

	public bool m_LocalExplode;

	private bool FMKMLMGFIMH;

	private uint HNKCCMPHELM;

	private const float IKIOEKHFKHI = 0.001f;

	private float HEDHOKDFIMA;

	private TrailRenderer NKNMFAPIOMP;

	private EntityVisualEffectManager HJCIADKBDMF;

	private Dictionary<int, uint> LPAOHMNGGHJ;

	protected HNOLJPFBPAG FMPHMLEOLBC;

	public Projectile m_projectile;

	private uint ELNAGKFGHGH;

	private GameObject DGINKCNCIOD;

	private GameObject JLMKENKFPHI;

	private const string MAOGOEGDMME = "bone_RightArm";

	private const string JCIMPJEBMPA = "bone_LeftArm";

	private float BCNFILCCAEK;

	private ResourceID NHPPNKAGIDL;

	private ResourceID PPMNHBIBGAA;

	private ResourceID JPLFBCMODIE;

	private List<float> FOALAJOELMN;

	private int[] JNHDHGHAFKN;

	private float[] HMAEEFKIBOI;

	private List<GMPGMPFNMFP> PJNOMOFGJBK;

	private List<GMPGMPFNMFP> HMBEKOKEHKE;

	private static Func<Collider, bool> FPKNBJCEAFE;

	private bool NEDEODGOPMF;

	private int FIIKPJJPEHF;

	private float HABAFKMMDEK;

	private float NKJHFCLLMDF;

	private float EEEKFMALLPB;

	private float KDHHGBAKLMB;

	private float GFOIMIGNIMA;

	private float LKJGHPGCPFG;

	private float AKMLCODODDM;

	private float BJNONLOPMKP;

	private float FDNLKHJCDKP;

	private float AICCALJDMCJ;

	private ResourceID DBLGNFIILFA;

	private GMPGMPFNMFP NNGCMHGJCBD => null;

	private GMPGMPFNMFP OHPFLAOADKI => null;

	public GMECHKEDOJP ABHCIOHBIEF
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public BHGGAEEHJCO NKPFAEIGJLB => default(BHGGAEEHJCO);

	protected override void OnAwake()
	{
	}

	private static VisualEffectLoadMethod CPLAFGKJLMI()
	{
		return VisualEffectLoadMethod.None;
	}

	public EntityVisualEffectManager GetVisualEffectManager()
	{
		return null;
	}

	public void CancelOrDetachEntityVisualEffect(FHHGDLPCCJE BIIDIBMHMPJ)
	{
	}

	protected override string GetObjectTag()
	{
		return null;
	}

	protected override void OnOnDestroy()
	{
	}

	private void EINCGALPCCP()
	{
	}

	public void SetLocalData(uint CBEPBJPAOIE, Vector3 BAFIFNKBHLC, HNOLJPFBPAG DDCKHFFKLLP, float PBIHCGFLCHG = -1f, bool DPCPAAODBGI = false, bool BKLBHCHHLHE = true, float KGCILGCNJAI = 999f)
	{
	}

	public void SetGrenadeDataScale(Player PGEGMKJKOKI)
	{
	}

	public void SetGrenadeDataScaleDetail(float JMJLIDMNIEK, float MEPHPFCADKH)
	{
	}

	public void PlayThrowSound()
	{
	}

	private bool HOCJDBFGLLC(FDAEPHMIEPC.NHMNBDFPMJP CCNBNLAPJFM)
	{
		return false;
	}

	private uint EBAIILAHCIE()
	{
		return 0u;
	}

	private bool DEBIFCBILJK()
	{
		return false;
	}

	private bool DJJPOLGFNCO(int PNLKPJNLDGB)
	{
		return false;
	}

	private bool EGPEOJLNAPL()
	{
		return false;
	}

	private void MMBFBAFBFLK(uint HIDANNMJCDP, Vector3 AIGPMFLKHLC)
	{
	}

	public float GetExplodeRange()
	{
		return 0f;
	}

	private void ODFEGIPFHBN()
	{
	}

	private void LDDLJIJAOEE()
	{
	}

	private void EOIDBABEFCB(uint PLNDNBINKOA, ResourceID CICBIIJABAP, GameObject CLACOPMJHDI)
	{
	}

	private float KGAHFAOBDHK()
	{
		return 0f;
	}

	private void LJMLBKJOPKF(uint HIDANNMJCDP, Vector3 GFDPGLHIACM, int DJAPBCKDFKA)
	{
	}

	private void HGDHOKGEMCK()
	{
	}

	private void NHKNBFCLFJH()
	{
	}

	private void HMCIHAEJLDN(Vector3 GFDPGLHIACM)
	{
	}

	private ResourceID CCBKOCKJCNN()
	{
		return default(ResourceID);
	}

	private ResourceID JNIIFIDHAFK()
	{
		return default(ResourceID);
	}

	private ResourceID IMBBMOBBGEG()
	{
		return default(ResourceID);
	}

	private ResourceID HJEFDPOCNKC()
	{
		return default(ResourceID);
	}

	private int NBMHJFGMBCJ(Player PGEGMKJKOKI, GMECHKEDOJP.DJNOAKFICCM KHCPBNAPENK)
	{
		return 0;
	}

	private void BMLJHMBIFAK(float DAPJEMMKMCN)
	{
	}

	private void FNOFLKMPPMN(Player PGEGMKJKOKI, float DAPJEMMKMCN)
	{
	}

	private void HDKOOJCELEK(ResourceID DPNJMHJGIPA, float INNIDEIFIFN, Vector3 HDFILHFDBKB, Vector3 LJADOJKNALD)
	{
	}

	public override void SyncAction(object[] DJAPBCKDFKA)
	{
	}

	protected virtual void FIHBEJPIMDE(GMPGMPFNMFP NKEPDPFIOFJ)
	{
	}

	protected bool EHMLDADFDHE(GMPGMPFNMFP NKEPDPFIOFJ)
	{
		return false;
	}

	protected bool OPGKADLIBLE(GMPGMPFNMFP NKEPDPFIOFJ)
	{
		return false;
	}

	public void OnPlayHitEffect(GMPGMPFNMFP NKEPDPFIOFJ)
	{
	}

	private void FKGCNDMHAJM(Vector3 EAFNEMPEAFL)
	{
	}

	private bool PONKFEIMEHB(Vector3 MOEFFAIDCBP, Vector3 MDHOFOMOHKF, float CCFIKGCBPJM, uint NDJPACKNMOG, ref GMPGMPFNMFP NKEPDPFIOFJ, GameObject CNGEDFMHEBI, Func<Collider, bool> OKFPMOMLOOH = null)
	{
		return false;
	}

	public override void OnFixedUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private Vector3 HENFBJMIGFN(Vector3 NNDKLPKEIPD, Vector3 MPBGHMDLDEG)
	{
		return default(Vector3);
	}

	private static bool JFAPEEBBNAI(Collider NFOAOEHOFCH)
	{
		return false;
	}

	private void APBACPEJLBA(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public void SetIsSplitedProjectile(bool PFLHCEGLJHO)
	{
	}

	public void SetIsSplitedSubProjectile(bool NJPGBMGJIHB)
	{
	}

	public void SetCanGrenadeSplit(Player NLBIOKNKKHG)
	{
	}

	public void PlayProjectileSplitSound()
	{
	}

	public void SetMainGrenadeModelScale(float INKJIPDBJIO)
	{
	}

	private bool AFGKMALBAGH()
	{
		return false;
	}

	public int GetMaxDamage()
	{
		return 0;
	}

	private void MMKCJPOICDD()
	{
	}

	private void PEKLEAKKGGL(MovableShootingTarget PFJFADHEJLJ)
	{
	}

	private void DOJKOLOGLGL()
	{
	}

	private void INGFHFPNIFA()
	{
	}

	private void KFNOOJLIMAI()
	{
	}

	private void HNHEFJHPJOK()
	{
	}

	private void PKADACNOLPJ()
	{
	}

	private void ODEIGGDNOBB(uint GGAOIPIHOBP, bool NNGHBFHBCKB, UnityEngine.Object HACIJIFIDKM)
	{
	}

	private void MEDOMPIJFMA()
	{
	}

	private bool JHAKHCCGBLN()
	{
		return false;
	}

	public bool IsSnowBall()
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

	private void BFCGLDAKINA()
	{
	}

	private void ONKPDGOICBM()
	{
	}

	private void AJCLHHPCGFP(GameObject EPJPNAKMFMB, float OBNPLABHICH = 0f)
	{
	}

	public void SetResId(ResourceID EEOJGIGGNAA)
	{
	}

	private void MNFFAFFIHEH(uint LIKPJDHGPFG)
	{
	}

	public void OnGrenadeExplode(uint LIKPJDHGPFG)
	{
	}

	private void NAKMAELDEKD()
	{
	}

	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnRecycle()
	{
	}

	public new bool _003C_003EiFixBaseProxy_Recycle()
	{
		return false;
	}
}
