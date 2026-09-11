using System;
using System.Collections;
using System.Collections.Generic;
using COW.PotentiallyVisible;
using GCommon;
using GCommon.Audio;
using UnityEngine;
using message;

namespace COW.GamePlay;

internal class Vehicle : AttackableEntity, BCEAFFIEMBF, FDACAOPGNJK, MOOLACGHPHJ, COW.GamePlay.EJCAJMNHGBG<LevelMissile>, IODPBADPGIB, IPVSItemActive, CNMHJGNKOOF
{
	protected class LJBAALIHDEE : ShadowStateBase
	{
		public Vector3 PHEOMEDPGED;

		public Quaternion GBHPAJHAAMF;

		public Quaternion DOGHPBHDLCJ;

		public Vector3 AALEAHDJAMC;

		public float HDBFIDDCCGF;

		public Vector3 AAPGPMPKMBD;
	}

	private enum CDHONLOGEJN
	{
		EVehicleAuthState_None,
		EVehicleAuthState_Local,
		EVehicleAuthState_Network
	}

	[Serializable]
	public class SmokeParam
	{
		public float HpRate;

		public string ResID;

		public Transform Transform;
	}

	private class DCEEMFCEMJP
	{
		public ONMHJGMIJGM BLNDLJDHEOL;

		public ONMHJGMIJGM DCEPDJEPFOD;
	}

	private struct DINGAKLBPJG
	{
		public Collider CODHKIIPNHA;

		public Matrix4x4 IDMEJMDPFOK;
	}

	private sealed class KDGCBAFLMLF
	{
		internal const int EOINBDJEKDK = 8;

		internal const int BGOIBICJJGI = 4;

		internal const int CAJOMLPFIFA = 4;

		internal readonly float[] FKJLFGKKLDC;

		internal readonly float[] IFPLEMDOHIN;

		internal readonly float[] PHOEEHPAHBK;

		internal readonly float[] CINHCNOMEBH;

		internal readonly bool[] IDJEFDICEIL;

		internal readonly bool[] AKKDDNOEHOH;

		internal readonly float[] JIJBPKLMHJD;

		internal readonly bool[] DJOPDPPBDKE;

		internal readonly float[] IDDOLFLNPHJ;

		internal readonly bool[] AHMPMKMPLOL;
	}

	private sealed class HOBBBOKAKCC
	{
		public Vehicle KOKNHFGCGLN;

		public ResourceID OCCLMDNGINA;

		public Action<CommonParticleEffect> HALOHOFFOKJ;

		public Transform FKODMCNOBDM;

		public ResourceID KDBNFJAILNE;

		internal void NFBDPBLDLHF(uint GGAOIPIHOBP, bool BBPCHCNOECP, UnityEngine.Object HACIJIFIDKM)
		{
		}
	}

	private sealed class LCCCOLNBDEN
	{
		public Vehicle KOKNHFGCGLN;

		public float JPMIGELCCDF;

		internal void DODBCDNIOJE(CommonParticleEffect DHJMMGHNCKJ)
		{
		}
	}

	private sealed class DEAFNAPNMHL
	{
		public Vehicle KOKNHFGCGLN;

		public Transform GJDLFMIFHMG;

		public Action<CommonParticleEffect> HALOHOFFOKJ;

		internal void MGONPJPCBEC(uint GGAOIPIHOBP, bool BBPCHCNOECP, UnityEngine.Object HACIJIFIDKM)
		{
		}
	}

	private sealed class CCLKJDOHDOH
	{
		public Vehicle KOKNHFGCGLN;

		public ResourceID OCCLMDNGINA;

		public Vector3 AJKJEBGDJIC;

		internal void IFFENALAAGO(uint GGAOIPIHOBP, bool BBPCHCNOECP, UnityEngine.Object HACIJIFIDKM)
		{
		}
	}

	private sealed class HJBIMDCNIHL
	{
		public Vehicle KOKNHFGCGLN;

		public ResourceID OCCLMDNGINA;

		public int GNLIAKMGDDG;

		internal void GOFENLAECNF(uint GGAOIPIHOBP, bool BBPCHCNOECP, UnityEngine.Object HACIJIFIDKM)
		{
		}
	}

	private sealed class AKPCJBIFAAA
	{
		public Vehicle KOKNHFGCGLN;

		public ResourceID FPLAPJHDMCP;

		public Action<VehicleSkinInfoBase> HALOHOFFOKJ;

		internal void HFIFLHGOBLG(uint GGAOIPIHOBP, bool BBPCHCNOECP, UnityEngine.Object HACIJIFIDKM)
		{
		}
	}

	private sealed class NHHHIHDALPM : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public Vehicle KOKNHFGCGLN;

		public CollisionDetectionMode NDDDJCMNPOH;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public NHHHIHDALPM(int CBPPJACCGOH)
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

	private sealed class NNGKGOKJDFO : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public Vehicle KOKNHFGCGLN;

		public bool NBOCCNBPDPJ;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public NNGKGOKJDFO(int CBPPJACCGOH)
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

	private sealed class CGBLBMJFGIA : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public float PCOPDDLBLMI;

		public CommonParticleEffect DHJMMGHNCKJ;

		public Vehicle KOKNHFGCGLN;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public CGBLBMJFGIA(int CBPPJACCGOH)
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

	private const float OJJDEAFMEGD = 3.6f;

	private static Vector3 HJHDNAHCEEB;

	private static float OECOIKJJMKI;

	private static float BGDOEDNILKE;

	private const uint BLFIGJNPBHL = 119u;

	private Dictionary<int, float> KNHEFLBJNNP;

	public const uint ISVISIBLE_STREAMER = 4u;

	public const uint ISVISIBLE_ONBOARD = 8u;

	protected BitArrayBoolean CNELANECFHO;

	private static Dictionary<int, ResourceID> CPFFKBKCMMK;

	protected VehicleControllerInterface BLNLPBECAOA;

	private CarAudioComponent EFPHAMKGDMI;

	protected VehicleSkinInfoBase CAGDGENIKEB;

	protected VehicleSkinInfoBase HMLJMOGNOHP;

	public BaseLevelObjectRendererCollection RendererCollector;

	public VehicleSkinPropertyData SkinPropData;

	protected uint DHJCKPCJJKN;

	protected bool MDBAAEKIOPE;

	protected ResourceID FPEDHIJEAIB;

	public string m_VehicleDefaultResourceName;

	public float m_CameraHeightScale;

	public float m_CameraDistanceScale;

	public float m_CameraMinPitch;

	public float m_CameraMaxPitch;

	public Vector3 CameraPosOffset;

	public float m_CameraHeightScale_PassengerFire;

	public float m_CameraDistanceScale_PassengerFire;

	public bool m_CanPassengerSteering;

	public bool m_UpdateAnimSteerAngle;

	public bool m_UpdateAnimSteerAngleHD;

	public Player DriverPlayer;

	protected GEBEMCDHIOH KFAFFNHMPAP;

	public BoxCollider LevelTrigger;

	public LevelVehicle LevelVehicle;

	public Rigidbody VehicleRigidBody;

	public GameObject[] HideAfterBroken;

	public bool EnableSetSeatVisible;

	public GameObject DriverSeat;

	public GameObject[] PassengerSeat;

	private ResourceID CMKBJDDHOHJ;

	public Transform[] GetOffPositions;

	public SmokeParam[] SmokeParams;

	public Transform ExplodePoint1;

	public Transform ExplodePoint2;

	public const int DRIVER_SEAT_INDEX = 0;

	protected Vector3 MKOMFCMMIPI;

	private Vector3 PAKGCNHKKAO;

	protected Vector3 PPLDGLKIMHB;

	public BHGGAEEHJCO LastDriver;

	private WheelCollider[] BMCKBOFHFIF;

	protected bool ELNCKOJLFLG;

	protected BHGGAEEHJCO[] GKNGAPNOOLP;

	private bool CBINBLOFBKC;

	public int[] AnimPoses;

	private GKEDHMFHDFM NPHJGLLHGJP;

	private int BGJKNEJBNLG;

	private float MPIMLCONKIP;

	private float MPPLNKOJIMA;

	public float m_MaxExtent;

	public float MaxExtentParam;

	private Bounds _003CELIPGLBAKFO_003Ek__BackingField;

	private CDHONLOGEJN EDHAGNKNDBI;

	protected uint IAPBBEEDLCG;

	protected LJBAALIHDEE LAPJPJICGJD;

	private bool GEGODLFBCOG;

	private bool OAGCEPGEMBK;

	private Queue<Vector3> JEOMCIOKJCD;

	private Vector3 ENPLBBCFPGE;

	private Queue<Vector3> EOHIDMBEMML;

	private Vector3 MKJCAEOBFJF;

	protected Vector3 JKINHAKCHGB;

	private HitDetectColliderHelper BLDJAONBAEI;

	protected bool LAMBKDFCEDA;

	protected bool IGOPNCPBEEP;

	private CommonParticleEffect CNEJMKLLFCN;

	private GameObject HGJCPIOPEGC;

	private Dictionary<int, List<int>> ECNJHEBHGKB;

	protected Dictionary<int, List<int>> LEEGONDEGHE;

	protected int NBEEDFKDDLM;

	protected bool FDHDFEBEEBM;

	protected bool GCKONOOMBOM;

	private float NEKJMPONICE;

	private float NLKKBJEKCAI;

	public VehicleEffect[] m_Effecects;

	public VehicleConfig config;

	public VehicleUpgradeSetting[] VehicleUpgrades;

	public int BoostStartEffectIndex;

	public int BoostLoopEffectIndex;

	public int BoostEndEffectIndex;

	public int JumpStartEffectIndex;

	public int JumpLoopEffectIndex;

	public int JumpEndEffectIndex;

	public TssSdtFloat BoostDurationRate;

	public TssSdtFloat BoostCDRate;

	protected TssSdtFloat AJAJLKPNJDO;

	public TssSdtFloat JumpCDRate;

	protected TssSdtFloat BBLJAEOBBBF;

	protected TssSdtFloat PLHBELDCHFG;

	protected TssSdtFloat LPHIAKFDPBI;

	protected TssSdtFloat DMADDBMBMGL;

	public Transform[] MissilePositions;

	private const int IMBECIIFFGC = 14;

	public Dictionary<int, LevelMissile> Missiles;

	protected MNGMJKHBPGI OFOJIHOEIDO;

	public Transform AimingCameraPos;

	public Transform HornPos;

	private GameObject PEFEPOBAMCK;

	private bool LLNAHOFMAEF;

	private bool BOOEEGLEALJ;

	public bool IsDuringDrift;

	private Timer JOLHAHCGABP;

	private Timer IDLCCGEAAHM;

	private DCEEMFCEMJP LCNJJIJHBFD;

	private const float LJEAEHICFNF = 1f;

	protected bool GCAJPGNKCDC;

	protected bool PIPBMDIPHKD;

	public Transform MachineGunRoot;

	public Transform MachineGunRotY;

	public Transform MachineGunRotX;

	public Transform MachineGunFirePoint;

	private float DJDKFCGAANL;

	private bool FFPCIMICMKM;

	private bool IGOGBCDLNNL;

	private float BGJKECGCHKA;

	private float GMEJOMNHAGP;

	public string ImpactConcreteSound;

	public string ImpactBodySound;

	protected bool IMIDFBOODAH;

	protected List<Renderer> LMKKJDJNCEA;

	protected bool ANHEAALMPKK;

	private bool _003CCHJJFBBDPGM_003Ek__BackingField;

	private FEKBCHODFLE GELFGDBLHDE;

	private readonly AudioPlaybackParams_Unity FIGKMNCINAJ;

	private uint AHJEJCHIOBC;

	private uint LMFHIPJEAFJ;

	private Rigidbody FBCLLGMNOPG;

	protected float AJDBGHEKFOI;

	private float EIHIFINPMOE;

	private static List<Collider> LMJCHBNFKKE;

	private List<DINGAKLBPJG> DHEKJDDEFFP;

	private bool AAAADJFEMNC;

	private Collider[] IHMDKJNCJDE;

	private KDGCBAFLMLF CNKFBEIAPGH;

	private float DEANGEEFDAG;

	private float HOFOGNFAHOD;

	private int LCFHEMFLCLG;

	private Vector3 NJKEJDEJPLG;

	private Vector3 HKPDBPBNCFE;

	private float NAELFFILELE;

	private const uint IONPNIKFDLM = 128u;

	private const uint JFIACOIBCEI = 64u;

	private const uint OLIKGKIHGME = 32u;

	protected const uint ONGIHCEMNIM = 16u;

	protected const uint CEAJCMCHMPI = 4u;

	private const uint BKMBIICLPDJ = 31u;

	private bool LAKKKBLPHEO;

	private List<CommonParticleEffect> CJCOEFEAJJH;

	public float StopBoostCollisionAngle;

	public float StopBoostCollisionYAngle;

	private List<float> FOALAJOELMN;

	private bool PDEMPONKBJF;

	public DALCIFJKFGO Weapon;

	public DALCIFJKFGO SecondaryWeapon;

	protected GameObject BAEAAKHEINH;

	protected Transform ADFNIMHHPCJ;

	private const float HHCNOONEAIB = 4f;

	private GMNANAILECK CPNKBJLOMIL;

	private ResourceID FHPPNAOAFNO;

	private bool AIKJKKJGCOH;

	private uint IDFJPBLNJFA;

	private bool NJJBIHAOPNK;

	private Dictionary<int, float> PKAJEIABFAG
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public VehicleControllerInterface CAHKHBNEBBN => null;

	public virtual CarAudioComponent BBMIGIAIAGP => null;

	public uint KFBDKCAEEMF => 0u;

	public Vector3 AOODIONOMDA => default(Vector3);

	public BHGGAEEHJCO EAMFCICBHMF
	{
		get
		{
			return default(BHGGAEEHJCO);
		}
		set
		{
		}
	}

	public BHGGAEEHJCO[] ALOOJDIAPJN => null;

	public float JODGBDANEPO => 0f;

	public Bounds CAFCJEMEHLG
	{
		get
		{
			return default(Bounds);
		}
		protected set
		{
		}
	}

	public bool BHKIDIGFCHP => false;

	public bool CAPBANEHFKF => false;

	public bool OCHKBAIBFOP => false;

	private Dictionary<int, List<int>> OIANKMAKMOM
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual bool FGMDKNNKGNJ => false;

	protected Dictionary<int, List<int>> HKPHDCFHBDN
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual bool GNHBBFLPILP => false;

	public bool ENNKALDLMEL => false;

	public bool EBILOJPGCPC => false;

	public bool PGIEHOBJJBO
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	public virtual EControlMode JEKCMOCKMGF => EControlMode.Default;

	public int LMNKLKFOOOF
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int IOGONNLBJMO
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool FOEMOKALDIL => false;

	public virtual bool OCIJCPDJBEF => false;

	public bool EJBGALEJJJE => false;

	protected bool JGFMBHKHJGB()
	{
		return false;
	}

	public bool CanPassengerFire()
	{
		return false;
	}

	public override bool IsVisible()
	{
		return false;
	}

	public override uint GetAttackableID()
	{
		return 0u;
	}

	public override DPNIICGMOJG GetAttackableType()
	{
		return DPNIICGMOJG.EAttackableType_None;
	}

	public virtual void SetEnterLevelTrigger(VehicleCollision NGGELGKKGBI, Collider GLJGHEAPBOF, bool PDEMMOBBACC)
	{
	}

	private void LOEICHCIHCJ(Collider GLJGHEAPBOF, bool PDEMMOBBACC)
	{
	}

	protected override void OnAwake()
	{
	}

	public override void OnRecycle()
	{
	}

	protected override void OnOnDestroy()
	{
	}

	public void RegistToPVSManager()
	{
	}

	public void UnRegistToPVSManager()
	{
	}

	protected virtual void GBDDGCMFHPP()
	{
	}

	public void SetRenderersActive(bool CJGJFCPPCEJ)
	{
	}

	public void OnHitIceWall(bool IPNPKMJDIPC)
	{
	}

	public virtual void ApplyVechileControl(FDDEPNLACNI JIHJLBFECCO, Vector3 PMIKOMKJPBF)
	{
	}

	public static Vector3 ConvertAxisToGasBreak(Vector3 PMIKOMKJPBF, out float LHHPOGFCMAM, out float OCHAHGCHCFC, bool MCDNLHMGKGM = true)
	{
		LHHPOGFCMAM = default(float);
		OCHAHGCHCFC = default(float);
		return default(Vector3);
	}

	private bool EANMNKLGLMF()
	{
		return false;
	}

	protected virtual void BHIMKPGOPIP(bool HCLGHJNEFIC)
	{
	}

	private bool CAMGNPCHAJA()
	{
		return false;
	}

	public override void OnFixedUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private static List<Collider> PPICKBGIPDA()
	{
		return null;
	}

	private Collider[] OIEHKFJGMMJ()
	{
		return null;
	}

	private static float OPINMFMGGIG(bool MEPBCEKAKLA)
	{
		return 0f;
	}

	private KDGCBAFLMLF FPMCIKIIKGK()
	{
		return null;
	}

	private void NCCECFPCHCB(int PNLKPJNLDGB)
	{
	}

	private bool FBGBAAANMAP()
	{
		return false;
	}

	private bool EMMPFCKNGCE(Bounds DEGPKEDMCOD)
	{
		return false;
	}

	private bool HNBKCMCCFMA(float LCIEAFHLELH, out Vector3 BIOEPDKLDHJ, out float DLMEJIMEEJD)
	{
		BIOEPDKLDHJ = default(Vector3);
		DLMEJIMEEJD = default(float);
		return false;
	}

	private bool OAPCOPMIIIN()
	{
		return false;
	}

	private bool PHIANLJLFGO()
	{
		return false;
	}

	private bool DBAGBNHFKIL(Bounds DEGPKEDMCOD)
	{
		return false;
	}

	private void CLCPJHPGBPD(Vector3 DFNHOKCIIJK, bool FOKNNJCGFGN)
	{
	}

	private bool KMPHJKJCOOK()
	{
		return false;
	}

	private bool ACAFKMFCMPM()
	{
		return false;
	}

	private bool HJCPPHBKECI()
	{
		return false;
	}

	private bool IDOKOLPJJIL(out int GHMCJFDEKCP)
	{
		GHMCJFDEKCP = default(int);
		return false;
	}

	private static bool MCFIEGFHKHI(WheelCollider PLPPCEJCHJH, float DHMKJBDBHFD, out float EONOEOLFDBG)
	{
		EONOEOLFDBG = default(float);
		return false;
	}

	private bool HHKOAMHPELL(out int DIGCKKJJEME, out int BHPAFNKKFLF)
	{
		DIGCKKJJEME = default(int);
		BHPAFNKKFLF = default(int);
		return false;
	}

	private bool DMMCPACGPAJ()
	{
		return false;
	}

	private bool PAPDPEJODPA(out float FLHGNEKAGDB, out float ICGJOJDBOCO, out int CLNGCFHIOLA, out int MAHAELJIFCB, out int NPGCNLJJMMJ, out int NAJAPODIAFJ)
	{
		FLHGNEKAGDB = default(float);
		ICGJOJDBOCO = default(float);
		CLNGCFHIOLA = default(int);
		MAHAELJIFCB = default(int);
		NPGCNLJJMMJ = default(int);
		NAJAPODIAFJ = default(int);
		return false;
	}

	private bool GJLNIJIODMO()
	{
		return false;
	}

	private bool PMMKMKBFDMG()
	{
		return false;
	}

	private bool HEGEONOAGAG()
	{
		return false;
	}

	private bool IFILDBHACMP()
	{
		return false;
	}

	private bool FKOODOJOEPN(bool LENAFOHCCEM)
	{
		return false;
	}

	private static bool JNHBNJOGBCI(int GHMCJFDEKCP, float[] OPGJNKKOHEK, bool[] HMDAKKKPLHC, float[] PBDFGKBCNOA, bool[] OECFJCNKGNB, int NFLIOGIBIOJ, out int JAHAMHGNDDD, out int OBJHPPHAOMO)
	{
		JAHAMHGNDDD = default(int);
		OBJHPPHAOMO = default(int);
		return false;
	}

	private bool IMLBIBCNGEI(out int JAHAMHGNDDD, out int OBJHPPHAOMO)
	{
		JAHAMHGNDDD = default(int);
		OBJHPPHAOMO = default(int);
		return false;
	}

	private bool HMKIEGDDPLO(out int JAHAMHGNDDD, out int OBJHPPHAOMO)
	{
		JAHAMHGNDDD = default(int);
		OBJHPPHAOMO = default(int);
		return false;
	}

	private bool IAACGAHFEGA()
	{
		return false;
	}

	private float OIKLHGHNCPD()
	{
		return 0f;
	}

	private bool GMFIDAFLEIP(out Bounds DEGPKEDMCOD)
	{
		DEGPKEDMCOD = default(Bounds);
		return false;
	}

	protected void MEHPMKPALOA()
	{
	}

	private bool HHDEPDOLCEP(Transform MBOGNMNNBMH)
	{
		return false;
	}

	private bool JJIDGKNIICH(Collider IIHDALCNINP)
	{
		return false;
	}

	private static Matrix4x4 NOIOGDJKFMJ(Transform OOCDCNJOHPB, Transform MBOGNMNNBMH)
	{
		return default(Matrix4x4);
	}

	private static void MEJJJDCBIOL(Matrix4x4 KKBFMBBMOAA, Matrix4x4 DMJOFMNOOHB, out Vector3 IMIHEBBAPPF, out Quaternion HMBACJBKEEL)
	{
		IMIHEBBAPPF = default(Vector3);
		HMBACJBKEEL = default(Quaternion);
	}

	private void PAKMMJAHJIC()
	{
	}

	private List<DINGAKLBPJG> CKFHFNLBIDD()
	{
		return null;
	}

	private bool PFCGELKJAAD(Collider IIHDALCNINP)
	{
		return false;
	}

	private bool NAOMLCMCLPD(Collider IIHDALCNINP)
	{
		return false;
	}

	private int LANCHHMHKPA()
	{
		return 0;
	}

	protected void AGBJHJCCAGI(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public override void OnUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public void CheckAndPlayBeHitVibrate()
	{
	}

	public void PlayCollisionVibrate()
	{
	}

	private void JOFFOLMHOOC()
	{
	}

	protected virtual bool IICNLIKFPCA()
	{
		return false;
	}

	private void ALJBFFAMLAO()
	{
	}

	public override void OnPaused()
	{
	}

	public override void OnResumed()
	{
	}

	protected virtual void JGEEBJDNCOE()
	{
	}

	public virtual void LockSpeed()
	{
	}

	public virtual void UnLockSpeed()
	{
	}

	public virtual void StartAutoDrive()
	{
	}

	public void StopAutoDrive()
	{
	}

	public virtual void RequestAutoDrive(bool PIDINBNGILH)
	{
	}

	public GKEDHMFHDFM GetVehicleData()
	{
		return null;
	}

	public virtual void SetVehicleData(GKEDHMFHDFM JCONDDPFBKK, VehicleConfigData DKLKGHGFNCC, int HHLLCKFNHPM)
	{
	}

	private void GBPLLMBPNDB(VehicleConfigData DKLKGHGFNCC)
	{
	}

	protected virtual void HDNBCDEPLHP(Dictionary<string, VehicleControllerInfo> BIBGOPMGFDC)
	{
	}

	protected virtual void HKNPLOJGOBM()
	{
	}

	protected virtual void HJADKDOENFI(Player PGEGMKJKOKI)
	{
	}

	public void ChangeState(bool CELKGHPNIKO, Player PGEGMKJKOKI, bool IKOJPPPAHCC = false, int OPMCCFAAOEL = -1, uint FHCABCCIOGP = 0u, bool HNMHFDJGBAM = false)
	{
	}

	public void GetOffByCannon(BHGGAEEHJCO MJBAGNLEIIL)
	{
	}

	public virtual void SetPassergerWeapon(int OIMPDJMNOFC, BHGGAEEHJCO MJBAGNLEIIL)
	{
	}

	private void HJHMDAAGGOI()
	{
	}

	public int GetPlayerSeat(BHGGAEEHJCO JFPADHMCADP)
	{
		return 0;
	}

	public bool AnyPassenger()
	{
		return false;
	}

	protected virtual void EHOMMMGPOFF(float DHKLOLJALAN)
	{
	}

	protected virtual void BMMODHKDMFN(bool DCAPIHJMMBL)
	{
	}

	public int GetEmptyPassengerSeat()
	{
		return 0;
	}

	public bool IsSeatEmpty(int KEMBBPMADFD)
	{
		return false;
	}

	public virtual bool SetSeat(int KEMBBPMADFD, BHGGAEEHJCO NDGDFMDIGLC)
	{
		return false;
	}

	public void SyncStateWithServer(Vector3 HDFILHFDBKB, Quaternion IPKKCHLDJMA, byte AGGFFHGLIEA)
	{
	}

	public void InitState(Vector3 HDFILHFDBKB, Quaternion IPKKCHLDJMA, bool CONGBDKNHLE, List<ONMHJGMIJGM> ICEDNEMFHLG)
	{
	}

	public void PushSyncState(OLEOJNOGCCN EPOOCGNJOFD, uint OJFBGFOOKEK)
	{
	}

	public void PushSyncSimplePosition(MFFPOILAAOD PIEFNMJNMKH, uint OJFBGFOOKEK)
	{
	}

	private void DAMFEBOGJAB(uint OJFBGFOOKEK, uint MICLJKJCFIE)
	{
	}

	protected virtual void BNAPBLBBIEJ()
	{
	}

	public void SyncTransform(Vector3 HDFILHFDBKB, Quaternion IPKKCHLDJMA)
	{
	}

	private void LPFNJDMLMNB(bool KGOHDEBHENF)
	{
	}

	public virtual void SetupCamera(VehicleDriverCamera NJMENHHJHCJ)
	{
	}

	public void SetupCamera(VehiclePassengerCamera NJMENHHJHCJ)
	{
	}

	public virtual byte GetCurrentPackedOp()
	{
		return 0;
	}

	public float GetSteeringFromPackedOp(byte INMPJFOMGOP)
	{
		return 0f;
	}

	private void GDCPJJPKNCF(CDHONLOGEJN PEHCNMANMOF, uint IHMLKNIJKNH = 0u, bool DHJNLHPOOFI = false)
	{
	}

	protected IEnumerator NGLBBDEGCOI(bool NBOCCNBPDPJ)
	{
		return null;
	}

	protected IEnumerator AGACBJLBJKD(CollisionDetectionMode NDDDJCMNPOH)
	{
		return null;
	}

	private void LBCFLJPPOGG(bool NMPLOMKCHBA)
	{
	}

	protected virtual ResourceID NHLHLKPFCLD()
	{
		return default(ResourceID);
	}

	private void OOAEJLGKPMJ()
	{
	}

	private void AOIMOLNGDAJ()
	{
	}

	protected virtual void JDNPKCJMLFK(bool OGECPGHMIHA)
	{
	}

	private void LHGIJECCEJK(bool OGECPGHMIHA)
	{
	}

	public virtual void SetVisibility(uint PIDINBNGILH, bool HOCFHLLIOJK)
	{
	}

	public Vector3 GetCameraTrackableEntityPosition()
	{
		return default(Vector3);
	}

	public Quaternion GetCameraTrackableEntityAimRotation()
	{
		return default(Quaternion);
	}

	public Vector3 GetCameraTrackableEntityTopPosition()
	{
		return default(Vector3);
	}

	public Transform GetCameraTrackableEntityTransfrom()
	{
		return null;
	}

	public bool IsCameraTrackableEntityAlive()
	{
		return false;
	}

	private CommonParticleEffect ODEIGGDNOBB(GameObject CLACOPMJHDI, Transform FKODMCNOBDM, ResourceID KDBNFJAILNE)
	{
		return null;
	}

	private void BENDFKJKGPP(ResourceID DHJMMGHNCKJ, ResourceID KDBNFJAILNE, Transform FKODMCNOBDM, Action<CommonParticleEffect> HALOHOFFOKJ)
	{
	}

	public override void TakeDamage(GLLLEDKLLDA PMMCGNJHOOA, LOAEBBHPMEK AOJANNHGCEA = null, List<float> LFLPGCMLPFM = null, uint FKDEIFDNMJD = 0u)
	{
	}

	public void Dead(float ODBAIHPNNOJ)
	{
	}

	public virtual void Explode(float JPMIGELCCDF)
	{
	}

	protected override void OnUpdateVisibleStateByStreamer(Vector3 MHAAFMCMHAC, Vector3 PAFBAHJAAGC)
	{
	}

	private void ILPCNHJOGPB()
	{
	}

	private void CFCCAFIOMHP()
	{
	}

	private void LDOKLALNCJB()
	{
	}

	private void DJMKNCIOAOE()
	{
	}

	private void FOPHBNKBGJE()
	{
	}

	private uint MHFOGEKJJNK(ResourceID CIOJIHBKICA, ResourceID KOJPBAKKBOK)
	{
		return 0u;
	}

	private void PDJNOEDKGGN()
	{
	}

	private IEnumerator CEIFIKOFIFI(float PCOPDDLBLMI, CommonParticleEffect DHJMMGHNCKJ)
	{
		return null;
	}

	public void CheckAndStartSmoke(float NCPNOAAFANG)
	{
	}

	private void LDOKBHOAAMN()
	{
	}

	private CommonParticleEffect MFCIFNIPJIM(GameObject CLACOPMJHDI, Vector3 HDFILHFDBKB)
	{
		return null;
	}

	private void JLCFKDPGOHI(Transform GJDLFMIFHMG, ResourceID AOFCDPKJKJO, Action<CommonParticleEffect> HALOHOFFOKJ)
	{
	}

	private void AOMNJOPGEHF()
	{
	}

	public void SendBrakeLightState(bool OGECPGHMIHA)
	{
	}

	public void SyncBrakeLight(bool HCLGHJNEFIC)
	{
	}

	public void SendHornState(bool OGECPGHMIHA)
	{
	}

	public void SyncHorn(bool OGECPGHMIHA)
	{
	}

	public void SendGearVFXState()
	{
	}

	public void EnableGearVFX()
	{
	}

	private void COHMCNJOPNN(uint GGAOIPIHOBP, bool BBPCHCNOECP, UnityEngine.Object HACIJIFIDKM)
	{
	}

	public void OnVehicleReset()
	{
	}

	public void NotifyServerGotForceSyncInfo(uint FFOAOKAFODF, uint DNLOGLJJDCJ)
	{
	}

	public override Vector3 GetAttackableCenterWS()
	{
		return default(Vector3);
	}

	public override bool CanAssistByUGC(float PHGFEGOEOLD)
	{
		return false;
	}

	protected override int GetMaxRepDataCount()
	{
		return 0;
	}

	public bool IsLowSpeed()
	{
		return false;
	}

	public bool IsMiddleSpeed()
	{
		return false;
	}

	public bool IsHighSpeed()
	{
		return false;
	}

	public bool IsDustMaxSpeed()
	{
		return false;
	}

	public float GetResetLeftTime()
	{
		return 0f;
	}

	public virtual Vector3 GetVelocity()
	{
		return default(Vector3);
	}

	public bool IsLocalPlayerOnBoard()
	{
		return false;
	}

	public bool IsTeammateOnBoard()
	{
		return false;
	}

	public bool IsDriverLocalPlayer()
	{
		return false;
	}

	public bool HasTeammatesOnBoard(BHGGAEEHJCO MEIMFKAABDA, BHGGAEEHJCO OCHKBHCGANI)
	{
		return false;
	}

	public bool HasNonTeammateOnBoard(BHGGAEEHJCO MEIMFKAABDA)
	{
		return false;
	}

	public void CollisionEnter(Collider MKPLDLFKAIK, bool FLDIFLJDJBK, Vector3 AJKJEBGDJIC)
	{
	}

	protected virtual void OnCollisionEnter(Collision MKPLDLFKAIK)
	{
	}

	protected virtual void MOIICJGCEKN(Collision MKPLDLFKAIK)
	{
	}

	private void JBNOPDAPBNP(Collider MKPLDLFKAIK, bool FLDIFLJDJBK, Vector3 AJKJEBGDJIC)
	{
	}

	public override bool NeedAssit()
	{
		return false;
	}

	private void KGCABLKLGBC(Vector3 AJKJEBGDJIC)
	{
	}

	private void LKEJJJOEKOJ(int GNLIAKMGDDG)
	{
	}

	private void NLFFILFEODC(Collider MKPLDLFKAIK, bool FLDIFLJDJBK, Vector3 AJKJEBGDJIC)
	{
	}

	private void KLEPLGGMEDM(Collider MKPLDLFKAIK, bool FLDIFLJDJBK, Vector3 AJKJEBGDJIC, float LIJJONCCFBP)
	{
	}

	private void LLECIAOPKFN(Collision MKPLDLFKAIK)
	{
	}

	public string[] GetVehicleDynamicAnimClipRes()
	{
		return null;
	}

	public virtual AnimationID GetAnimName()
	{
		return default(AnimationID);
	}

	public int GetAnimPose(BHGGAEEHJCO NDGDFMDIGLC)
	{
		return 0;
	}

	private static int NDBDIPEJENH(Vehicle NPBEMDBPPIC)
	{
		return 0;
	}

	protected float GCMHGELGGAF(float PMNNBDDKCCE)
	{
		return 0f;
	}

	private void LGACJCHNGIA(int FCAOOKIBKJK, BHGGAEEHJCO FNOOENEHBJP)
	{
	}

	private bool EFKACDKNFDL(int DGDDJLEOPBL, float PHLKJIEAIDJ)
	{
		return false;
	}

	public virtual void SyncChangeShape(byte GKKELMDDGBJ)
	{
	}

	public virtual void SendChangeShape()
	{
	}

	public virtual void SyncParachuteState(byte CBCAJJJCKLH)
	{
	}

	public bool IsLocalAuth()
	{
		return false;
	}

	public void SyncChangeAuth(bool GNADDKDEACF, uint IHMLKNIJKNH)
	{
	}

	public void SyncChangeSeat(ONMHJGMIJGM BAIHFJJNHKD, ONMHJGMIJGM AEFNGFHGMMM, float PBIHCGFLCHG)
	{
	}

	private void DNKBCOEABNP()
	{
	}

	public bool HasPendingChangeSeatRequest()
	{
		return false;
	}

	protected virtual void JCBIGCIKIPB()
	{
	}

	protected virtual void FIHCLADPPAF()
	{
	}

	private void DDHIHGNFGMO(ONMHJGMIJGM BAIHFJJNHKD, ONMHJGMIJGM AEFNGFHGMMM)
	{
	}

	public bool DriverHasInput()
	{
		return false;
	}

	protected BDBKGOMDIME FNPNCFGOPMO(DKCOBGILPCO DNNNJDJIBMP)
	{
		return null;
	}

	protected bool DBONEIILLLJ(DKCOBGILPCO DNNNJDJIBMP)
	{
		return false;
	}

	public void StopUseItem(DKCOBGILPCO DNNNJDJIBMP)
	{
	}

	protected void AOFPIPNOJJN(DKCOBGILPCO DNNNJDJIBMP, bool IIJFLMLBDBL)
	{
	}

	public virtual bool IsGranded()
	{
		return false;
	}

	public bool InWaterAndShouldBreak()
	{
		return false;
	}

	public void AddWeapon(DALCIFJKFGO PJMDKPKBBAM)
	{
	}

	public void ActiveWeapon(DALCIFJKFGO PJMDKPKBBAM)
	{
	}

	public virtual void InitStateWithPlayer(bool NIFCOJBPFAJ, byte DHGPANMNGKB, Player LNGAFJFGPNE, bool IKOJPPPAHCC = false, int OPMCCFAAOEL = -1)
	{
	}

	public virtual void StartOnBoard()
	{
	}

	public virtual void StartSkyDiving()
	{
	}

	public virtual void StartParachute()
	{
	}

	public virtual bool IsInParachuteJumpState()
	{
		return false;
	}

	public virtual void OnBevActionCome()
	{
	}

	public virtual bool IsOnBoard()
	{
		return false;
	}

	public virtual void StopParachutEffect()
	{
	}

	public virtual void SyncAirDropState(byte JJFMGNOIPFL)
	{
	}

	private void KCCLIDKDHII()
	{
	}

	private void CAHELBMBADH()
	{
	}

	private void FKDGLPLANPP()
	{
	}

	private void ADCKPJFOAKH(Vector3 GIPABKDIIDN)
	{
	}

	protected void KAFLDKJNOAD(bool FKJMCGEFJMD)
	{
	}

	public void Mount(int NIBBKONKPHP, LevelMissile KECDHKLPGFL)
	{
	}

	private void KJNAFKMAIJA(int NIBBKONKPHP, LevelMissile KECDHKLPGFL)
	{
	}

	public void UnMount(int NIBBKONKPHP, LevelMissile KECDHKLPGFL)
	{
	}

	public void ReleaseMounted()
	{
	}

	public virtual void OpenDriverFireHudInNeed()
	{
	}

	public void OpenPassengerSkillHudInNeed()
	{
	}

	private void FFINHAFIINE()
	{
	}

	public virtual void SyncVehicleStable(bool BAGNKAKIOFJ)
	{
	}

	public virtual void SyncVehicleSkin(uint KKIPNLOLAAM, bool BGJILLHFGIL = false)
	{
	}

	public void SwitchVehicleSkinBuff()
	{
	}

	public static VehicleSkinInfoBase GetSkinInfoFromPool(ResourceID FPLAPJHDMCP)
	{
		return null;
	}

	public void GetSkinInfoFromPool(ResourceID FPLAPJHDMCP, Action<VehicleSkinInfoBase> HALOHOFFOKJ)
	{
	}

	protected void ENJJHFFPJEA(ResourceID DMKJIBKEEOH, bool PILCILLBHPD)
	{
	}

	private void DLNHCNFJNFJ()
	{
	}

	private void BLHCJGODFKI(uint GGAOIPIHOBP, bool NNGHBFHBCKB, UnityEngine.Object HACIJIFIDKM)
	{
	}

	private void GDPEMJPLGFG(bool CAFPCHNFGBB)
	{
	}

	protected virtual void EGHBAPLFLHO(VehicleSkinInfoBase HPAEPPLOBFN = null)
	{
	}

	protected virtual void ODJIAANOCJH()
	{
	}

	private void JIJIJPKDJHD()
	{
	}

	private void AHEKAMEDCFL(VehicleSkinInfoBase CMGPDICHMJB)
	{
	}

	private VehicleSkinData BEODMEDKDJI()
	{
		return null;
	}

	private bool BPFDLKMMPMB(VehicleSkinData BOBIDPBLHPL)
	{
		return false;
	}

	public virtual void ChangeProperty(string HPLGKADLMKG, float IFOFEKIPOAP)
	{
	}

	public uint GetCurRealSkinID()
	{
		return 0u;
	}

	public bool GetCurRealSkinReady()
	{
		return false;
	}

	public GameObject GetCurrentVehicleSkinRoot()
	{
		return null;
	}

	string CNMHJGNKOOF.UGCEntityID()
	{
		return null;
	}

	string CNMHJGNKOOF.UGCArchTypeID()
	{
		return null;
	}

	bool CNMHJGNKOOF.IsStatic()
	{
		return false;
	}

	public void SetVelocity(Vector3 KMFMICABCFL)
	{
	}

	public GEBEMCDHIOH GetPilotMode()
	{
		return GEBEMCDHIOH.EPilotMode_None;
	}

	public void SetPilotMode(GEBEMCDHIOH GGAOKBAMALB)
	{
	}

	public bool IsBountyMoto()
	{
		return false;
	}

	public virtual string GetIconInMap()
	{
		return null;
	}

	public virtual bool IsLimitTimeUsage()
	{
		return false;
	}

	public void RefreshControllerSpeedScale()
	{
	}

	public virtual void PlayEffect(uint MGGNLEEAPEP)
	{
	}

	public virtual bool CanDriverFire()
	{
		return false;
	}

	public virtual void ForceStop(bool CNCDDJLLLHO = false)
	{
	}

	public virtual void ForceBrake()
	{
	}

	public virtual bool IsMoving()
	{
		return false;
	}

	public virtual void RemoveForDestroy(bool ODBECFEKBNJ)
	{
	}

	public virtual ResourceID GetDustResourceID()
	{
		return default(ResourceID);
	}

	public bool IsShowSpeedLine()
	{
		return false;
	}

	public bool IsShowHorseMoveEffect()
	{
		return false;
	}

	public virtual ResourceID GetSpeedLineEffect()
	{
		return default(ResourceID);
	}

	public virtual string GetTeammateVehicleIcon()
	{
		return null;
	}

	public virtual void RefreshIdleHoldWeaponAnim()
	{
	}

	public virtual void RefreshHealState()
	{
	}

	public virtual ResourceID GetWeaponHitEffect()
	{
		return default(ResourceID);
	}

	public virtual ResourceID GetWeaponHitSound()
	{
		return default(ResourceID);
	}

	public virtual ResourceID GetHitSound()
	{
		return default(ResourceID);
	}

	protected virtual Bounds CEOKGMFFNCP(Transform HACIJIFIDKM, bool PCBKLELIOMM = false)
	{
		return default(Bounds);
	}

	public virtual bool CanIgnoreAimAssistBySkill()
	{
		return false;
	}

	private void OFGHCIIFIBG(VehicleSkinInfoBase CMGPDICHMJB)
	{
	}

	private void FCMLBKCPGHO(CommonParticleEffect DHJMMGHNCKJ)
	{
	}

	private void JCGBNBIICBE(CommonParticleEffect DHJMMGHNCKJ)
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

	public bool _003C_003EiFixBaseProxy_IsVisible()
	{
		return false;
	}

	public uint _003C_003EiFixBaseProxy_GetAttackableID()
	{
		return 0u;
	}

	public DPNIICGMOJG _003C_003EiFixBaseProxy_GetAttackableType()
	{
		return DPNIICGMOJG.EAttackableType_None;
	}

	public new void _003C_003EiFixBaseProxy_OnRecycle()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPaused()
	{
	}

	public void _003C_003EiFixBaseProxy_OnResumed()
	{
	}

	public void _003C_003EiFixBaseProxy_TakeDamage(GLLLEDKLLDA P0, LOAEBBHPMEK P1, List<float> P2, uint P3)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUpdateVisibleStateByStreamer(Vector3 P0, Vector3 P1)
	{
	}

	public Vector3 _003C_003EiFixBaseProxy_GetAttackableCenterWS()
	{
		return default(Vector3);
	}

	public bool _003C_003EiFixBaseProxy_CanAssistByUGC(float P0)
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_NeedAssit()
	{
		return false;
	}
}
