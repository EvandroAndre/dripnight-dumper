using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW.GamePlay;

internal class LevelIceWall : BaseLevelObject, EOAONLPGBBI
{
	public class LJBAALIHDEE : ShadowStateBase
	{
		public Vector3 PHEOMEDPGED;

		public Quaternion GBHPAJHAAMF;

		public Vector3 AALEAHDJAMC;

		public Quaternion DOGHPBHDLCJ;
	}

	public enum HCCPIKJIJFG
	{
		None,
		MarkIceWall,
		BeMarkIceWall
	}

	private sealed class LKBHBEGEBCP
	{
		public LevelIceWall KOKNHFGCGLN;

		public ResourceID MBLFOHLKLGE;

		internal void NHHCNJFKLHM(uint LGLKKOLPANE, bool MAGGAHNDDGI, UnityEngine.Object HACIJIFIDKM)
		{
		}
	}

	private sealed class KDGAGMJMDPI
	{
		public LevelIceWall KOKNHFGCGLN;

		public int DGDDJLEOPBL;

		public int HCCPIKJIJFG;

		public ResourceID EJPBBEFLHNA;

		internal void CDHBKHELJMG(uint GGAOIPIHOBP, bool BBPCHCNOECP, UnityEngine.Object HACIJIFIDKM)
		{
		}
	}

	private sealed class LLGLGMKDGKF : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public LevelIceWall KOKNHFGCGLN;

		private float PICJBNMIFPB;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public LLGLGMKDGKF(int CBPPJACCGOH)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	public IceWall[] m_IceWall;

	public Collider m_IceWallTrigger;

	public GameObject m_CrackRoot;

	public UILabel m_ClanNameLabel;

	public MeshRenderer m_PrimeIcon;

	private TextureIconCDNResource CHHMDCKLIBB;

	private Material PDBPEBFHMGB;

	private Renderer[] FFJCBNINCCL;

	private ResourceID DBLGNFIILFA;

	private int BNOKOIPEOFE;

	private int PGLPEDHAFAK;

	private float JLIHLLINEHD;

	private bool PNDFLHIDPID;

	private bool CGPINIELLMN;

	private static List<Material> LLMLKGBGNBK;

	private List<Material> KPNFCPHHNJG;

	private Player IPEIBKLCGLP;

	private MeshRenderer IJLEAHFGPFM;

	private const int BMGFBNPHAIM = 234;

	private const int MICOBNPKKFG = 32;

	public static readonly ResourceID CityHeroBoyIceWallPreExplodeRes;

	public static readonly ResourceID CityHeroBoyIceWallPreExplodeEnemyRes;

	public static readonly ResourceID CityHeroBoyIceWallExplodeRes;

	public static readonly ResourceID CityHeroBoyIceWallExplodeEnemyRes;

	public static readonly ResourceID CityHeroBoyIceWallExplodePerkRes;

	public static readonly ResourceID CityHeroBoyIceWallExplodeEnemyPerkRes;

	public static readonly ResourceID CityHeroBoyIceWallExplodeSfxRes;

	public static string[] DECAL_SHADER_NAME;

	private LFCGDGMJJGM OMHNJEEIDEK;

	private bool MIMKCPPMDGN;

	private bool DLPFJCNNAGI;

	private int OGPPPAMFCJB;

	private int PPMPFNNDJDH;

	private int JKJMBIJDHBM;

	private bool KEKCEKPGDMN;

	protected uint IAPBBEEDLCG;

	private LJBAALIHDEE LAPJPJICGJD;

	private GameObject PFCKGIAFBFA;

	private Vector3 FLCNKKFLFGP;

	private Quaternion KMGAHBPGIIC;

	private BHGGAEEHJCO ONMIPNENOLM;

	private Dictionary<int, UnityEngine.Object> NFIEHDPIPOL;

	private FEKBCHODFLE GELFGDBLHDE;

	private VisualInstanceHolder IFLMENDLLPK;

	private Dictionary<uint, uint> JIEPEFNEFND;

	private Dictionary<uint, ResourceID> FOFOPPOHFCK;

	private readonly Dictionary<int, ResourceID> EFNKNBCAJIB;

	private Renderer LGCMIJHJKNH;

	private float FICMDCHDMBG;

	private GameObject GFDDAHBBAEC;

	private ResourceID CNABLNAEHLC;

	private static bool? FIOKEJFEMBN;

	private GameObject NLLKKEJFPFB;

	private ResourceID LDNIODJPHFF;

	private GameObject GBGDNJJADJA;

	private GameObject JKBGJNKEHMJ;

	private ResourceID ODDMPHOCJAL;

	private string EPCPJEBAJAH;

	private string HNDKKHNOBGH;

	private bool MIBDDOFHBOM;

	private GameObject FDFBKLKOEOG;

	private ResourceID IEKGNBKODKA;

	private string IGEAAMPNGFK;

	private float HEEHALBBBKE;

	private bool CGKGNHLIOAJ;

	private const string JPJEJEBMFDI = "ICEWALL_RECOVERHP_SKILL";

	private Vector3 KKJONPHEEAO;

	private const string HNNJGBHPKFI = "ICEWALL_EXTRAHP_VIEW";

	private Vector3 HIBOBHPFBAH;

	private bool KGBPLBICBJO;

	private uint BNBKPOOIHHC;

	private EntityVisualEffectManager HJCIADKBDMF;

	public int LOFANKDFPJB => 0;

	public bool DBEGDOFAHBE => false;

	private int HNKIFFMGMOH => 0;

	private int ICFGMMADCAN => 0;

	private int FECJIKCINNH => 0;

	public void UpdateShadowState(LJBAALIHDEE LIGOKJFNAED, uint MAMEDNLECKF)
	{
	}

	private bool AJOKGDFCJIJ()
	{
		return false;
	}

	public void Init(DFGEEDAHPAP KIPDOAEDJNK, LFCGDGMJJGM KCMFOHGIPHM, int ICNLDNANPLL, uint NCHOKMAKBBD, bool LLDHBFDPIDO, bool CGOFBEMMGJD, bool IGKHLGKLGPM = false, bool OMKLHGNOHJG = false, byte LABBAIMMELK = 0, uint MECONKDDAEC = 0u, bool CMIDCHGNKFH = false)
	{
	}

	private void KOEDHMDADIH(uint MECONKDDAEC)
	{
	}

	private void JJKJGPNDJOL(uint MECONKDDAEC)
	{
	}

	private ResourceID JHBOIEALCHL()
	{
		return default(ResourceID);
	}

	private ResourceID EPMEFICCAGG()
	{
		return default(ResourceID);
	}

	private bool CJNJDMEGGIJ(string DHGPGNFOMIC)
	{
		return false;
	}

	public bool NeedGetOut()
	{
		return false;
	}

	private IEnumerator CJAHCIPKCBI()
	{
		return null;
	}

	protected override string GetObjectTag()
	{
		return null;
	}

	public void GetRenderer()
	{
	}

	protected override void OnAwake()
	{
	}

	private void AMPPCGGHPAB()
	{
	}

	private void OECHPGECOKF()
	{
	}

	protected override void OnOnDestroy()
	{
	}

	private void BADPIBGDNCE()
	{
	}

	private void BPCIMNNFANA(float EFABABOFIOJ)
	{
	}

	private void MJJJJIKGOIF()
	{
	}

	public override void OnUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public override void OnFixedUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public void SyncState(Vector3 IGDHIDGLOKG, Quaternion FOALBMBCJLF, uint OJFBGFOOKEK)
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

	public void DestroyIceWall()
	{
	}

	public void UGCDestroyIceWall()
	{
	}

	private ResourceID LNKHHFJCBLC()
	{
		return default(ResourceID);
	}

	private ResourceID IHPNAKDHBEL()
	{
		return default(ResourceID);
	}

	private ResourceID HEDDBEOCNJO()
	{
		return default(ResourceID);
	}

	private ResourceID JGLOFCGGLMD()
	{
		return default(ResourceID);
	}

	public ResourceID GetHitSparkleVFX()
	{
		return default(ResourceID);
	}

	public ResourceID GetHitSFX()
	{
		return default(ResourceID);
	}

	private void HIAAIELJCED()
	{
	}

	private void NPCJAHMHKEO()
	{
	}

	private void LPIBEMOKAFA(GameObject CLACOPMJHDI)
	{
	}

	private void LCGEIGGKODA(uint GGAOIPIHOBP, bool BBPCHCNOECP, UnityEngine.Object HACIJIFIDKM)
	{
	}

	private void JPFEJJMKEPI()
	{
	}

	private void AHBCLCCLLPK(ResourceID DHJMMGHNCKJ, ResourceID KDBNFJAILNE)
	{
	}

	private void EAPIPNMGPCN(uint GGAOIPIHOBP, bool BBPCHCNOECP, UnityEngine.Object HACIJIFIDKM)
	{
	}

	protected override int GetMaxRepDataCount()
	{
		return 0;
	}

	protected override void OnUserDefineReplicationInfo()
	{
	}

	public void OnVFXMultiCustomChange(ulong GNBOOELAHNP, ulong LAHMCKAGGCO)
	{
	}

	private void FFBBFGLAEPL(uint KGHDGMPIGBL, bool CJODEAIGEFO)
	{
	}

	public void OnStateChange(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	public void OnBurnDotEffectChange(bool OJEPOBEENEK, bool EIOKHLKJEEL)
	{
	}

	private bool BHCAOGHLIFO()
	{
		return false;
	}

	private void HJEMBLBPFCE(GameObject CLACOPMJHDI)
	{
	}

	public void OnPoisonEffectChange(int OJEPOBEENEK, int EIOKHLKJEEL)
	{
	}

	private void CHGCCIBLGON(uint GGAOIPIHOBP, bool BBPCHCNOECP, UnityEngine.Object HACIJIFIDKM)
	{
	}

	public void OnIceWallHealSelfEffect(int OJEPOBEENEK, int EIOKHLKJEEL)
	{
	}

	private void GBNPGIKFJPF(uint GGAOIPIHOBP, bool BBPCHCNOECP, UnityEngine.Object HACIJIFIDKM)
	{
	}

	private void GCIPHAEBOMN(uint GGAOIPIHOBP, bool BBPCHCNOECP, UnityEngine.Object HACIJIFIDKM)
	{
	}

	public void OnIceWallShowHealRangeEffect(float OJEPOBEENEK, float EIOKHLKJEEL)
	{
	}

	private void KIMDJHHJDFI(uint GGAOIPIHOBP, bool BBPCHCNOECP, UnityEngine.Object HACIJIFIDKM)
	{
	}

	private void ADKBHFGEADF(bool EOGOGFLCEHL)
	{
	}

	private void DOANKDEOPNO(uint GGAOIPIHOBP, bool BBPCHCNOECP, UnityEngine.Object HACIJIFIDKM)
	{
	}

	protected override void UnRegisterEntity()
	{
	}

	private void HGICPICLEIA(bool GPFPIAMCEMI)
	{
	}

	private void BHPDCIIAAKN(bool PIDINBNGILH)
	{
	}

	private void CPCDHGGMJFH(bool EOGOGFLCEHL)
	{
	}

	private void HNFECCIAMLD(uint GGAOIPIHOBP, bool BBPCHCNOECP, UnityEngine.Object HACIJIFIDKM)
	{
	}

	private bool KIBCKBFGHFA()
	{
		return false;
	}

	public void OnSightingStateChanged(object[] JCONDDPFBKK)
	{
	}

	private ResourceID MOJKMCOPJKN(int HCCPIKJIJFG)
	{
		return default(ResourceID);
	}

	private void HHMAFGEHKEG()
	{
	}

	public void DestroySkillVFX(int HCCPIKJIJFG)
	{
	}

	public void GenerateSkillVFX(int HCCPIKJIJFG)
	{
	}

	public void OnObserverSwitch(object[] JCONDDPFBKK)
	{
	}

	public void RefreshSkillVfxVisible()
	{
	}

	public void PlayIceWallOnceEffect(ResourceID EEOJGIGGNAA, ResourceID GHDLAAEMJDO)
	{
	}

	public EntityVisualEffectManager GetVisualEffectManager()
	{
		return null;
	}

	private static uint IPNCEADFOFI(ulong GPFPIAMCEMI)
	{
		return 0u;
	}

	private static uint CJIFIEEJFPD(ulong GPFPIAMCEMI)
	{
		return 0u;
	}

	private static ResourceID LJPDEPMGDEG(uint CGNLINOIMAA, bool CDKLFJAHKFH)
	{
		return default(ResourceID);
	}

	private static ResourceID HFMFONNDFGD(uint CGNLINOIMAA, bool CDKLFJAHKFH)
	{
		return default(ResourceID);
	}

	public void OnCityHeroBoyBuff(ulong OJEPOBEENEK, ulong EIOKHLKJEEL)
	{
	}

	public void OnCityHeroBoyBuffShowPreExplodeVfx(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	public override void TakeDamage(int FCAOOKIBKJK)
	{
	}

	private void EPFLFIFFKAC()
	{
	}

	public void HideCrackInHdLobby()
	{
	}

	private void APDDFENHBCB()
	{
	}

	public void IceWallPlayVfx(ResourceID KMMFBGMHKCJ, float CNKMEPFCJOM)
	{
	}

	private void KNHDEFKLGEI(bool EMANEBGLLJG)
	{
	}

	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUpdate(float P0, float P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
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

	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	public void _003C_003EiFixBaseProxy_UnRegisterEntity()
	{
	}

	public void _003C_003EiFixBaseProxy_TakeDamage(int P0)
	{
	}
}
