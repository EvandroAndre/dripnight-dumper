using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using COW.GamePlay.UGCRuntime;
using COW.Gameplay.UGC;
using GCommon;
using GCommon.Audio;
using TsiU;
using UMA;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Playables;
using UnityEngine.Rendering;
using message;

namespace COW.GamePlay;

internal class Player : AttackableEntity, LJJABOHJEIN, FDACAOPGNJK, FOCGJHJOBFE, IReusableObjectOwner, MOOLACGHPHJ, CNMHJGNKOOF
{
	private class IHAMCEAHFOC
	{
		public float DPCDGEHLJDG;

		public uint BAFEIAKDCEK;

		public PlayerAttributes.BDACINNPFDD PPODKMJODLN;

		public float NPIEOEPMAFN;
	}

	[Serializable]
	private class SkillCdReductionClientParams
	{
		public string icon;
	}

	private class ELIJDNKGDID
	{
		public int FHAPLNEIBFB;

		public uint LMAIHDKMAKA;
	}

	protected class CEKCFPPLFNP
	{
		private BHGGAEEHJCO OBMFMAKFDDL;

		private float MMBHKHJHBBF;

		private bool HFFLIFNIBAO;

		public CEKCFPPLFNP(BHGGAEEHJCO LIKPJDHGPFG, float CNKMEPFCJOM, bool KGOHDEBHENF = false)
		{
		}

		public void LEMOAMFBCPG(float CNKMEPFCJOM)
		{
		}

		public bool GDOMJPBILPL()
		{
			return false;
		}

		public BHGGAEEHJCO GHNJEDKGMEH()
		{
			return default(BHGGAEEHJCO);
		}

		public bool JDFKKCPBAEL()
		{
			return false;
		}
	}

	public class ALJIMOHHJNO : GEvent
	{
		public BHGGAEEHJCO GJKKLNLABPO;

		public Vector3 GIDCGFFAOBF;

		public bool MCEIGCAJNIA;

		public bool CPDJFHOACGO;

		public void BLJEIAHKEPL(BHGGAEEHJCO PGEGMKJKOKI, Vector3 HDFILHFDBKB, bool CPEIFHKMLCN, bool BHHNNKBNLPC = false)
		{
		}
	}

	public class BCNENNHAIDG : GEvent
	{
		public bool ELOJGNBBPGH;

		public BHGGAEEHJCO GJKKLNLABPO;

		public ushort FECPCELJAFJ;

		public ushort IJKDAJNDOKC;

		public void BLJEIAHKEPL(bool DDKLDJLECHP, BHGGAEEHJCO PGEGMKJKOKI, ushort FPCJPPPENKE, ushort BAAGLCNDPFF)
		{
		}
	}

	public enum ACOGBMIGNPI
	{
		ESPType_None,
		ESPType_Cur_Temp,
		ESPType_Max_Temp,
		ESpType_Cur_Perm,
		ESpType_Max_Perm
	}

	public class EELIECHCOBI : GEvent
	{
		public ACOGBMIGNPI GNONLBKPFGN;

		public BHGGAEEHJCO GJKKLNLABPO;

		public uint FECPCELJAFJ;

		public uint IJKDAJNDOKC;

		public void BLJEIAHKEPL(ACOGBMIGNPI CCNBNLAPJFM, BHGGAEEHJCO PGEGMKJKOKI, uint FPCJPPPENKE, uint BAAGLCNDPFF)
		{
		}
	}

	public class NAGLDDPFNCD : GEvent
	{
		public bool NEJAACDIIPH;

		public BHGGAEEHJCO GJKKLNLABPO;

		public GEvent BLJEIAHKEPL(bool EGOJIOGEEAM, BHGGAEEHJCO PGEGMKJKOKI)
		{
			return null;
		}
	}

	public class PCKKBMCLJGG : GEvent
	{
		public BHGGAEEHJCO KOHOAGNJKAB;

		public int ILOIDFAEGJA;

		public int APFCFAOFKFA;

		public GEvent BLJEIAHKEPL(BHGGAEEHJCO KJLFMPOFELA, int PEDBKNOAKIF, int JMODGOKNFGH)
		{
			return null;
		}
	}

	public class JJLKKJCPPNB : GEvent
	{
		public uint BHGGAEEHJCO;

		public List<uint> MDHIHMAMOBP;

		public float IAELPIEBMIN;

		public GEvent BLJEIAHKEPL(uint KJLFMPOFELA, List<uint> HKBKEILKJPJ, float DBMHCKPBKMC)
		{
			return null;
		}
	}

	public class NMHJPBFLOCG : GEvent
	{
		public BKGEMKGCLAK CKKFFEDANPH;

		public uint OPCGBNCFJHN;

		public Vector3 MMBNJEKMJCK;

		public uint HMFCNIBPOGD;

		public uint LEOKMNIDBAJ;

		public void BLJEIAHKEPL(BKGEMKGCLAK GDHOJCDAGHJ, uint DBHJCLICABH, Vector3 OOHPGKKKJJP, uint GFNGPPGMMKN, uint JLDCAPAFNOG)
		{
		}
	}

	public class IFNMJCACKHO : GEvent
	{
		public bool IBODNHGPKBM;

		public Vector3 KELNCEHFDMA;

		public void BLJEIAHKEPL(bool GDHOJCDAGHJ, Vector3 DBHJCLICABH)
		{
		}
	}

	public class GNLLANIMHNP : GEvent
	{
		public BHGGAEEHJCO BNEAGPEAPMG;

		public string JPODNJEIEGL;

		public float KKGCDBGGHHM;

		public uint HPBOHPJPKCI;

		public bool GEDHAKIBLMO;

		public void BLJEIAHKEPL(BHGGAEEHJCO OBMFMAKFDDL, string LENJFKDNPMO, float PMEBPPEMEFC, uint OHKPIIENIMH, bool AHILCLPIGKB)
		{
		}
	}

	public class EHAFOPMKHJO : GEvent
	{
		public BHGGAEEHJCO EIGOHHAOIHL;

		public bool GMIPLJIJLEJ;

		public int BDOOPPOFOPG;

		public bool ILDLPKGMHOH;

		public bool HHJLPAKBPAM;

		public bool BGMHLLMHFFP;

		public bool LNPLNACJHIP;

		public void BLJEIAHKEPL(BHGGAEEHJCO KJLFMPOFELA, bool JAGMLGOAPBE, int KBJCJFLHKJL, bool KBKALPABPDC, bool GLLPNODCEJA, bool CPFBOCJFEAH, bool NEICHNJFPBG)
		{
		}
	}

	public class BEBDFCOELCL : GEvent
	{
		public BHGGAEEHJCO BNEAGPEAPMG;

		public KCLBKEBAILK JPODNJEIEGL;

		public float KKGCDBGGHHM;

		public uint HPBOHPJPKCI;

		public void BLJEIAHKEPL(BHGGAEEHJCO OBMFMAKFDDL, KCLBKEBAILK LENJFKDNPMO, float PMEBPPEMEFC = 0f, uint OHKPIIENIMH = 0u)
		{
		}
	}

	public class DGKCJOILHDE : GEvent
	{
		public string EKCFPAGLOIL;

		public bool AEIJPLNDFDC;

		public BHGGAEEHJCO BNEAGPEAPMG;

		public float ONMBKILPMJM;

		public void BLJEIAHKEPL(string LENJFKDNPMO, bool HGADPGICIHO, uint NDGDFMDIGLC, float FBDGLENMINK = 0f)
		{
		}
	}

	public class OGEHLPBABJJ : GEvent
	{
		public BHGGAEEHJCO BNEAGPEAPMG;

		public KCLBKEBAILK JPODNJEIEGL;

		public bool AEIJPLNDFDC;

		public float ONMBKILPMJM;

		public void BLJEIAHKEPL(BHGGAEEHJCO NDGDFMDIGLC, KCLBKEBAILK LENJFKDNPMO, bool HGADPGICIHO, float FBDGLENMINK = 0f)
		{
		}
	}

	public class KAAIFAFGOJB : GEvent
	{
		public string JPODNJEIEGL;

		public bool FKOBBNBMJIA;

		public ESkillHudBrightStyle OMANAHCFEIE;

		public float ONMBKILPMJM;

		public uint HAAMGLBLBKA;

		public void BLJEIAHKEPL(string LENJFKDNPMO, bool AEAPKEDNBGK, ESkillHudBrightStyle IIHJMNDKHLA = ESkillHudBrightStyle.Default, float FBDGLENMINK = 0f, uint KHBEAGGAPJA = 0u)
		{
		}
	}

	public class CMBGCMDMJKD : GEvent
	{
		public KCLBKEBAILK JPODNJEIEGL;

		public bool FKOBBNBMJIA;

		public float ONMBKILPMJM;

		public uint HAAMGLBLBKA;

		public void BLJEIAHKEPL(KCLBKEBAILK LENJFKDNPMO, bool AEAPKEDNBGK, float FBDGLENMINK = 0f, uint KHBEAGGAPJA = 0u)
		{
		}
	}

	public class GJKPJDLFJMC : GEvent
	{
		public string JPODNJEIEGL;

		public bool FKOBBNBMJIA;

		public float KKGCDBGGHHM;

		public uint HPBOHPJPKCI;

		public void BLJEIAHKEPL(string LENJFKDNPMO, bool AEAPKEDNBGK, float PMEBPPEMEFC, uint OHKPIIENIMH)
		{
		}
	}

	public class MAGAJBDJAEI : GEvent
	{
		public KCLBKEBAILK JPODNJEIEGL;

		public bool FKOBBNBMJIA;

		public float KKGCDBGGHHM;

		public uint HPBOHPJPKCI;

		public void BLJEIAHKEPL(KCLBKEBAILK LENJFKDNPMO, bool AEAPKEDNBGK, float PMEBPPEMEFC, uint OHKPIIENIMH)
		{
		}
	}

	public class BFAGBOCGCAD : GEvent
	{
		public string JPODNJEIEGL;

		public void BLJEIAHKEPL(string LENJFKDNPMO)
		{
		}
	}

	public class CAAMNOGOALI : GEvent
	{
		public KCLBKEBAILK JPODNJEIEGL;

		public void BLJEIAHKEPL(KCLBKEBAILK LENJFKDNPMO)
		{
		}
	}

	public class LLKKJNIAMDD : GEvent
	{
		public KCLBKEBAILK JPODNJEIEGL;

		public string BNCMCLIJPJN;

		public void BLJEIAHKEPL(KCLBKEBAILK LENJFKDNPMO, string IDFADLFIOHC)
		{
		}
	}

	public class DDFCIJDHODF : GEvent
	{
		public BHGGAEEHJCO ANHLIHEKECE;

		public BHGGAEEHJCO PEMGFEHMELF;

		public int HNDFDMAHLBO;

		public LLEDPGIGCMO AMAHFBMMOHF;

		public int OGHFODFCKEJ;

		public bool JDBCPBNPHGB;

		public CECJMLEEPLG COFNPPEKBKF;

		public bool IJHNEHDLHNE;

		public int GKEHBBKIAAL;

		public bool KDIIGJGKGMF;

		public bool IOFGOJHGBAF;

		public int NEEJCOGNGED;

		public bool EJEGNPBLJGN;

		public bool DCCGFMPHGDN;

		public string CODMFKNGDAL;

		public bool DPOOGNMKIPA;

		public Vector3 KFHFJCCOHFD;

		public void BLJEIAHKEPL(BHGGAEEHJCO GDHOJCDAGHJ, BHGGAEEHJCO DBHJCLICABH, int OOHPGKKKJJP, LLEDPGIGCMO GFNGPPGMMKN, int JLDCAPAFNOG, bool OPGIHCOLJBI, CECJMLEEPLG HCEMMEOKMCA, bool CKHFHHKDCCL, int BCGKCLDPOMG, bool MEDEOPGLEMO, bool MGEHDJFMMJA = false, int JEKAAAOBKLL = 0, string NLFFCJFCBKF = "", bool MLGCDPIMIOK = false, Vector3 GKDIOHCMHBG = default(Vector3))
		{
		}
	}

	public class IAMEOGKAJBN : GEvent
	{
		public IOENNEBCHBF CCPHKBJGHNG;

		public EPickupListOp ONGDPMDEBCB;

		public void BLJEIAHKEPL(IOENNEBCHBF MLBAMPFOCGP, EPickupListOp KGEMBGEMCJB)
		{
		}
	}

	public class OJOGAHIAAJM : GEvent
	{
		public LevelContainer CCPHKBJGHNG;

		public EPickupListOp ONGDPMDEBCB;

		public void BLJEIAHKEPL(LevelContainer MLBAMPFOCGP, EPickupListOp KGEMBGEMCJB)
		{
		}
	}

	public class PEDGFKBFMEC : GEvent
	{
		public EPreparationTimerType EPJNCHPEKMM;

		public bool GHDLLGJFOCC;

		public bool NPOOODJNDJN;

		public bool IEDDMNJOHAP;

		public bool PPMGMIGIBMP;

		public EPreparationTimerCancelType BMDIJKHONGD;

		public uint ICKGHDKDIFC;

		public GEvent BLJEIAHKEPL(EPreparationTimerType NADOGLBIKEF = EPreparationTimerType.None, bool DJAPBCKDFKA = true, bool JIEJGEBJLAG = false, bool KMJCBCGAAID = true, bool EMHAMBDCACH = true, EPreparationTimerCancelType ILCLFPOELAA = EPreparationTimerCancelType.None, uint NAIKLHHABCB = 0u)
		{
			return null;
		}
	}

	public enum IMNFFGNAACK
	{
		EHitArmorType_None,
		EHitArmorType_Helmet,
		EHitArmorType_Armor,
		EHitArmorType_Shield
	}

	public class NOKLHKDNCNO : GEvent
	{
		public IMNFFGNAACK HOMFEFMMKIG;

		public int EJIFNLJBCMP;

		public void BLJEIAHKEPL(IMNFFGNAACK HOMFEFMMKIG, int EJIFNLJBCMP)
		{
		}
	}

	public class HDOLGJKOJLK : GEvent
	{
		public BHGGAEEHJCO BNEAGPEAPMG;

		public void BLJEIAHKEPL(BHGGAEEHJCO NDGDFMDIGLC)
		{
		}
	}

	public class CJIPCFAMCMM : GEvent
	{
		public BHGGAEEHJCO BNEAGPEAPMG;

		public bool MANCKDNBDKP;

		public void BLJEIAHKEPL(BHGGAEEHJCO NDGDFMDIGLC, bool PIDINBNGILH)
		{
		}
	}

	public class KGCNPIGNFAD : GEvent
	{
		public BHGGAEEHJCO CACFKDEFAGE;

		public BHGGAEEHJCO GHCHKPONEBM;

		public int EJJFPFENMBP;

		public void BLJEIAHKEPL(BHGGAEEHJCO GEKCACGOBLK, BHGGAEEHJCO FJPPGBNIJCH, int HPPACPHIPCP)
		{
		}
	}

	public class LOMICFHFOHA : GEvent
	{
		public BHGGAEEHJCO BNEAGPEAPMG;

		public uint GKOKMPCJDLE;

		public void BLJEIAHKEPL(BHGGAEEHJCO NDGDFMDIGLC, uint DMKFDEMFGHL)
		{
		}
	}

	public class ILAJKNALAJI : GEvent
	{
		public BHGGAEEHJCO BNEAGPEAPMG;

		public BHGGAEEHJCO LJFHDBEHHJG;

		public uint GKOKMPCJDLE;

		public bool MKOIJMEHEEA;

		public void BLJEIAHKEPL(BHGGAEEHJCO NDGDFMDIGLC, BHGGAEEHJCO PNOIDOKAEPD, bool KMGFELOGKOK, uint DMKFDEMFGHL)
		{
		}
	}

	public class LCEMIJHJIKG : GEvent
	{
		public BHGGAEEHJCO BNEAGPEAPMG;

		public byte NLEKNLBKCEI;

		public int IDHLIEHJBFB;

		public byte ECIHKDANEOP;

		public uint KDEEIMNALND;

		public byte PGCIJMELLME;

		public List<KMGBNNHDOHF> JNPGFPKNAGO;

		public void BLJEIAHKEPL(BHGGAEEHJCO JFPADHMCADP, byte KKFGBFKFJEL, int JJCHNNAIFNL, byte ABNJNBBPKEM, uint GDBPMFDEJGA, byte ACOJGJFHOJO, List<KMGBNNHDOHF> OPPJPKCHBOP)
		{
		}
	}

	public class AOOCPENNMGL
	{
		public UIHudPlayerSPItem.ESPVisualType LPDLNOONDKC;

		public Color POHDKFNFBKK;

		public string EKAPBAMNDBA;

		public Color AFICNPGONLL;

		public string HEKNLDNOFPA;

		public string OLNBGAEEEGN;

		public string GHOOANIHJCF;
	}

	public enum IGJPHDANPJD
	{
		Walking,
		Falling,
		Parachuting,
		OnBoard,
		SkyDiving,
		HitFly,
		Swimming,
		OnStrop,
		Football,
		JetFly,
		Gliding,
		OnGrapplingHook,
		Skateboarding,
		OnFerrisWheel,
		FlightRoam,
		FaithJumping,
		Swing,
		Sprint,
		SlideRunning,
		SlideFalling,
		PassiveMoving,
		Max
	}

	public enum JCPJMHLOOHD
	{
		None,
		EnterFastRun,
		FastRun
	}

	public enum MNLGJFCJGJA
	{
		None,
		Attack,
		Defense
	}

	public enum BCDFPMMEPFN
	{
		None,
		ThrowingWeapon,
		ActiveSkill,
		TeleportToKnockDown,
		KickFootball
	}

	public class FEMJPMLIKDF
	{
		public EntityInfo BFFJDHJFCCG;

		public Vector3 EBKOEPAJDII;

		public GameObject MJEPAEJFMCN;

		public bool KKAMEHEIGKD;

		public bool KDLNHGPBGLI;

		public override string ToString()
		{
			return null;
		}

		public string _003C_003EiFixBaseProxy_ToString()
		{
			return null;
		}
	}

	public enum CFIGAMOOFLH
	{
		NONE,
		TeammateRescure,
		SelfRescure,
		UseRescureZone,
		RemoteRescue,
		RescueOwnerBuffECA,
		HealRobot
	}

	public enum JOHBFACKCJJ
	{
		NotSet,
		Show,
		Hide
	}

	private enum NFDDMKNPIBC
	{
		Flag_None = 0,
		Flag_1 = 1,
		Flag_2 = 2,
		Flag_3 = 4,
		Flag_4 = 8,
		Flag_5 = 0x10
	}

	public enum CNIGGEPKEFD
	{
		None,
		Opened,
		Closed,
		Openning
	}

	public class PCBOIABIHPD
	{
		public float AEIAAHOOABN;

		protected float PMPGHGFHCLF;

		public bool IFKNFDKPLFN => false;

		public void CJFHGJHBCAL()
		{
		}

		public void CBDCNPDPJEC()
		{
		}

		public void CHAOIPNPPPH()
		{
		}

		public float HHJNBNAGPJP()
		{
			return 0f;
		}

		public void ENCHNGJDAJD(float PCOPDDLBLMI)
		{
		}
	}

	public enum KPADFFNLKHP : byte
	{
		Fist,
		Rifle,
		Melle,
		TwoHand
	}

	public enum FHHGDLPCCJE
	{
		weapon_on_hand_effect,
		weapon1_on_back_effect,
		weapon2_on_back_effect
	}

	public enum CMGBJDKIDJJ
	{
		Defalut,
		On,
		Off
	}

	public delegate bool BDFFBCKEGHL(float OKJIFBCMDAD, float HOGHEFNINAE);

	public enum HANMBDAAIFN
	{
		SkillNoiseDampingAndBleed,
		SkillImmortality
	}

	public enum PLAMDOMBAON
	{
		None,
		MonkeyTransform,
		BloodPoolTransform,
		GBFootBall,
		MonkeyTransform_NoCollectionSkin
	}

	public class ALAICHHNNEN
	{
		public Material DJNMFEAFJOB;

		public CommandBuffer DFOCKGCKFDN;

		public Camera DIFBMHJKNHL;

		public CAIDKDGENGJ KOANKNNBAGP;

		public CameraEvent LFHEPMLPJCE;

		public float LIEPIBNBGKB;

		public float MOPKEGDECLC;

		public Action<int> BBNMDIPAEMA;

		public Action<int> EEKDPCOKIJE;

		public bool AILOHBHAJCL;

		public bool JOOAAPCPFHL;
	}

	private class CCOHEOMEKBP : BGDMAEFKAFK
	{
		public CCOHEOMEKBP(Player LDCIMNAAGNO)
			: base(null)
		{
		}

		public override IGJPHDANPJD JLCHKEOGPLC()
		{
			return IGJPHDANPJD.Walking;
		}

		protected override void NKFCJNLBDDI(IGJPHDANPJD OLAHOFPELBC)
		{
		}

		protected override void KNOJLLAMIIM(IGJPHDANPJD GCJPAAPKMMA)
		{
		}

		protected override void GPJGONKFEAG(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		public void _003C_003EiFixBaseProxy_NKFCJNLBDDI(IGJPHDANPJD P0)
		{
		}

		public void _003C_003EiFixBaseProxy_KNOJLLAMIIM(IGJPHDANPJD P0)
		{
		}

		public void _003C_003EiFixBaseProxy_GPJGONKFEAG(IGJPHDANPJD P0, EOGPGNIDOKF P1)
		{
		}
	}

	private class GFIEAOJEFFC : BGDMAEFKAFK
	{
		public GFIEAOJEFFC(Player LDCIMNAAGNO)
			: base(null)
		{
		}

		public override IGJPHDANPJD JLCHKEOGPLC()
		{
			return IGJPHDANPJD.Walking;
		}

		protected override void NKFCJNLBDDI(IGJPHDANPJD OLAHOFPELBC)
		{
		}

		protected override void KNOJLLAMIIM(IGJPHDANPJD GCJPAAPKMMA)
		{
		}

		protected override void GPJGONKFEAG(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		public void _003C_003EiFixBaseProxy_NKFCJNLBDDI(IGJPHDANPJD P0)
		{
		}

		public void _003C_003EiFixBaseProxy_KNOJLLAMIIM(IGJPHDANPJD P0)
		{
		}

		public void _003C_003EiFixBaseProxy_GPJGONKFEAG(IGJPHDANPJD P0, EOGPGNIDOKF P1)
		{
		}
	}

	private enum GDIEANOJNGP
	{
		None,
		SpeedLow,
		SpeedUp,
		SpeedMax
	}

	private enum OIBKLAKMFOL
	{
		None,
		AccUp,
		AccDown
	}

	public class AvatarTransformer : MonoBehaviour
	{
		public GameObject root;

		public bool playerRawIsFemale;

		public AvatarEffect rawAvateaEffect;

		public PlayerAudioComponent rawAudioComponent;

		public AvatarTransformData transformData;

		private Renderer[] APKCOKLHJAO;

		private Animator[] APLOJDNMABG;

		private SkinnedMeshRenderer[] CLDKMJKKAAM;

		private ParticleSystemRenderer[] DNMFLFNJECO;

		private MeshRenderer[] CJEPEJBIAIB;

		public ResourceID modelResId;

		public Player owner;

		private BigHeadComponent KHMHJPMEHND;

		private string OLCGLJCCPPL;

		private Dictionary<int, HELBFMHHPBI> OKNNIAGCGBG;

		private int? OJPDMHKPPGO;

		private Dictionary<int, int> LEJLOHPNNMG;

		private int OGPPPAMFCJB;

		private int HNKIFFMGMOH => 0;

		public void SetVisible(bool GPFPIAMCEMI)
		{
		}

		public void Clear()
		{
		}

		public Vector3 GetLocalPosition()
		{
			return default(Vector3);
		}

		public void ResetLocalPosition()
		{
		}

		public void SetLocalPosition(Vector3 GPFPIAMCEMI)
		{
		}

		public void UpdateBigHeadScale(float GPFPIAMCEMI)
		{
		}

		public void SetBigHeadNeckRevertScaleMult(Vector3 FDOKAOIEDFD)
		{
		}

		public void SwitchEffect(UMAData.EffectType DHJMMGHNCKJ)
		{
		}

		public void SetShader(string NKOEPMIECFC, HELBFMHHPBI IGGPKOIHLJE = null, Shader BGBLINMCBGD = null)
		{
		}

		public void RevertToDefaultShader()
		{
		}

		public void SetRenderQ(int MMNAILAPJFN, bool IDCHCEECMBE = false, bool MNMOFPDPGGN = false)
		{
		}

		public void RevertToDefaultRenderQ(bool OKEOCDOOHAF = true)
		{
		}

		public SkinnedMeshRenderer[] GetRenderer()
		{
			return null;
		}

		public void MakeAllTransformEffectVisible(bool PIDINBNGILH)
		{
		}

		public bool IsFirstRendererEnabled()
		{
			return false;
		}

		public void SetThermalView(bool HCLGHJNEFIC)
		{
		}
	}

	public class DAPOIBANHEH : ITransformNode
	{
		private Transform _003CIKLHANPPCGM_003Ek__BackingField;

		private List<Transform> KHOPJGJKMNE;

		public Transform HECDKBIPPPE
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void JNCMEDPBCBA(bool MIBHDOJIHJE)
		{
		}

		public void JOIJMCPPENP()
		{
		}

		public void GOHPILPELLJ(Transform EDIPDJFBPNA)
		{
		}
	}

	public class HPCNMOKAGAK
	{
		private static List<string> HFGONOOPEEC;

		private static List<Transform> CEGJHMNNPEC;

		private Dictionary<string, DAPOIBANHEH> KLKJOCMOLHJ;

		private Transform DHOIAKLGHHI;

		private DAPOIBANHEH POPEGGOBJCF;

		private bool MGIHFIIHFGG;

		public void LMNGOJOJFNM(Transform IBDNJDLJPDG)
		{
		}

		public DAPOIBANHEH GOIMIEICJBE(string ODMPOJBJADM)
		{
			return null;
		}

		public void GOIMIEICJBE(Dictionary<string, Action<DAPOIBANHEH>> GBKJPBGCPHD)
		{
		}

		public void GOIMIEICJBE(List<string> NEOBBFEDGDE, Dictionary<string, DAPOIBANHEH> OINGJCPEOPL)
		{
		}

		public void IKGCNJFLGBO(Transform PDNCKLFPHPJ)
		{
		}

		public void FKEHBGCNJMC()
		{
		}

		public void ELDEBDKILFO(GameObject HACIJIFIDKM)
		{
		}
	}

	public class FLFADFKGIHB : ObjectPoolCallbackBase, IComparable<FLFADFKGIHB>
	{
		public ulong MLIPJLJCLFI;

		public COOFONGLAIB ADLOOKMPNHO;

		public uint PLOMHKEDOOG;

		public uint FDNFBPONNCJ;

		public uint KCKONGPILGK;

		public uint FPEHDKEMLKB;

		public int FBJGNMNJFHF;

		public void CMEOOIMDPKC(HOPPKJFDGKB KNBEKHOLLJM)
		{
		}

		public void CMEOOIMDPKC(AMGDCBACIBH GKMGBFDLLJM)
		{
		}

		public int CompareTo(FLFADFKGIHB GLJGHEAPBOF)
		{
			return 0;
		}
	}

	public class ANJGLPLLHAN
	{
		public uint KKOFNKKHOKL;

		public byte LKIANEOILHI;

		public float IKPDMMIIPCL;
	}

	private enum PNDBOOADDEJ
	{
		None,
		UpdateClothes,
		SelectProfile
	}

	public struct LHNIGIDFMMP
	{
		public Vector3 IFPPDLCPGEL;

		public Vector3 KJFDBODHPII;
	}

	public class BKIDLEFNNJA
	{
		public BHGGAEEHJCO CEHFOENKODO;

		public byte FGDCMNGILKE;

		public ushort IAMOGEDNGPO;

		public ushort MDFLLLJNDAJ;

		public ushort AAALPDMDOBN;

		public bool DJOFEJBPMBA(int BPEKPCICCEM)
		{
			return false;
		}

		public bool HPMKAKMLBBO(int PIDINBNGILH)
		{
			return false;
		}
	}

	public class AKCKCJHBEKD
	{
		public ushort MEJJIIKOMKM;

		public ushort CCMGPKIHGGB;
	}

	public enum MABCLDLDMJO
	{
		DUST,
		GRASS,
		LENGTH
	}

	public enum IJJFLMLECCJ
	{
		Show,
		Hide,
		Fall
	}

	public enum KDOJONOLNKG
	{
		None,
		Carry,
		DancePool,
		Seesaw,
		FollowEmote,
		Catapult,
		Chair,
		LobbyLW
	}

	public class FGAHFBDAKPI
	{
		private Player MBPMMLMJOHL;

		private IGJPHDANPJD BNCGMLMIGCP;

		private BGDMAEFKAFK _003CCGCLPJIGCOK_003Ek__BackingField;

		public Vector3 ICHKNLFJIFP;

		public Vector3 POAJHDKFLGE;

		public float EPCIJJLKNCO;

		public float HIDEHMALLFL;

		public Vector3 AAPGPMPKMBD;

		public Vector3 LDIGFNJKCCA;

		public Vector3 ALGCCNIEEKA;

		public BGDMAEFKAFK KJAOALOPDHH
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public IGJPHDANPJD BGDMAEFKAFK => IGJPHDANPJD.Walking;

		public EOGPGNIDOKF LADGDMGAMBG => EOGPGNIDOKF.EPHYSXPOSE_STANDING;

		public float IIBOGLKIJKH
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float ADLNJGOICPO
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool EEMLIFAFDJB => false;

		public bool AACBLJLDAMP => false;

		public bool MBAHNMFKLLN => false;

		public bool MCLNEIELACA => false;

		public bool GNKLNHAFGGH => false;

		public bool BBNHOCIHLAJ => false;

		public bool DLEANDNIHBN => false;

		public bool NILHIPJIELG => false;

		public bool OGIPPPKKFBG => false;

		public bool KKIDDJLBHLF => false;

		public bool NLKPMEAFKMG => false;

		public bool GODNOJLALNJ => false;

		public bool CBNNDBDHMJE => false;

		public bool PGBLKNHHPJF => false;

		public bool MIDNGIIBFJF => false;

		public bool BFIKPMAFNEM => false;

		public bool PDIPJALCNND => false;

		public bool BGFJBMKKGNO => false;

		public bool JJLIFPHAGCL => false;

		public bool OOKHGOKONKD => false;

		public bool IEGNLNLKJDE => false;

		public bool BIHPPIAHDCM => false;

		public bool HGAIMMDNKJL => false;

		public bool EGPNPKGAOMP => false;

		public FGAHFBDAKPI(Player LDCIMNAAGNO)
		{
		}

		public void CDGOMPJLDPC(BGDMAEFKAFK GCJPAAPKMMA)
		{
		}
	}

	public enum CDAEGDACFBG
	{
		BUFF_DOT = 1,
		BUFF_SKIN
	}

	public class HLIJMCPGMIG
	{
		protected BitArrayBoolean ANMKEJNIKFD;

		private HashSet<uint> GIDJNGLNFIJ;

		private Action ALPKDEFIEAI;

		private Action CEKBKGIABMO;

		public virtual void DCBKFKBIPAC()
		{
		}

		public void JHGAAMLNOBC(Action CLADKGNFEGI)
		{
		}

		public void MPDNBBOLLGB(Action IMJLBELEPNA)
		{
		}

		[SpecialName]
		public static bool LMCLIKOCCJM(HLIJMCPGMIG GKLNBCJDPLI)
		{
			return false;
		}

		public virtual void PKCANOGNONP(uint OINKNIGKDMO)
		{
		}

		public virtual void KOHMDLCFCML(uint OINKNIGKDMO)
		{
		}

		public void PNEOPNGLMNM(bool FDNEJJLHNIH, uint OINKNIGKDMO)
		{
		}

		public void GOIBNCFMMEB(uint LKHIALHNOLD)
		{
		}

		public void IEEHHIHKNPI(uint LKHIALHNOLD)
		{
		}

		public void DMEADLMDKLG(bool FDNEJJLHNIH, uint LKHIALHNOLD)
		{
		}
	}

	public enum BDMKPMCMHBA
	{
		CityHeroBoy
	}

	public enum AOKONLNMEND
	{
		InValid,
		NBDash,
		NBSplit,
		CityHeroBoy,
		Scout,
		Naru2NBGPPainUniversalPull,
		IIV_GP_PURPLE_Ball,
		IIV_GP_Boxing,
		IIV_GP_1v1
	}

	public enum CDPIFBEMOKJ
	{
		InValid,
		NBDash,
		NBSplit,
		Scout,
		Naru2NBGPPainUniversalPull,
		IIV_GP_PURPLE_Ball,
		IIV_GP_Boxing,
		IIV_GP_1v1,
		FreeViewCamera,
		GB_GP_Gulag
	}

	public enum KEJCEFKHMND
	{
		InValid,
		IIV_GP_PURPLE_Ball,
		IIV_GP_1v1,
		FreeViewCamera,
		GB_GP_Gulag
	}

	public enum LGILCKEKGDE
	{
		InValid,
		IIV_GP_PURPLE_Ball,
		IIV_GP_1v1,
		FreeViewCamera,
		GB_GP_Gulag
	}

	public enum BMMIFLPFJJF
	{
		InValid,
		IIV_GP_PURPLE_Ball,
		IIV_GP_Boxing,
		Stealth,
		IIV_GP_1v1
	}

	public class CNGEIDMLDIP : HLIJMCPGMIG
	{
		public class CDAIDJPJCGP
		{
			public uint IMIFCILMHDC;

			public float LIEPIBNBGKB;

			public float CKMCCHKEIFM;
		}

		protected Player IAMDEGAAELH;

		protected BitArrayBoolean BEHPOJGJIBK;

		public Dictionary<uint, HashSet<uint>> FFEDLIHGFCJ;

		public Dictionary<uint, CDAIDJPJCGP> IBMAGELJDBO;

		protected HashSet<uint> CDFOMFLKCBJ;

		public void JCJPHOLMLOB(Player PGEGMKJKOKI)
		{
		}

		public override void DCBKFKBIPAC()
		{
		}

		public void FEECHHIPADP(uint OINKNIGKDMO, List<uint> JEJMDJNGONB, bool IBEPDNDNDEG = true)
		{
		}

		public void EHHNKLHENBI(uint OINKNIGKDMO)
		{
		}

		public override void PKCANOGNONP(uint OINKNIGKDMO)
		{
		}

		public override void KOHMDLCFCML(uint OINKNIGKDMO)
		{
		}

		public bool MDDNHGPMHAC(NAELPAAELNO PPFBJKMHKGC)
		{
			return false;
		}

		public void DHMHNDHCOAH(uint OINKNIGKDMO, float IODGGOHKCJD)
		{
		}

		public float PHGLBBEMBBP()
		{
			return 0f;
		}

		public bool ILGDBFOLNNI(NAELPAAELNO PPFBJKMHKGC)
		{
			return false;
		}

		public void _003C_003EiFixBaseProxy_DCBKFKBIPAC()
		{
		}

		public void _003C_003EiFixBaseProxy_PKCANOGNONP(uint P0)
		{
		}

		public void _003C_003EiFixBaseProxy_KOHMDLCFCML(uint P0)
		{
		}
	}

	public enum NNINDCDCAAO
	{
		InValid,
		NBDash,
		NBSplit,
		Naru2NBGPPainUniversalPull,
		IIV_GP_PURPLE_Ball,
		IIV_GP_Boxing
	}

	public enum OOPIHDIJOMC
	{
		NBDash,
		CityHeroBoy,
		IIV_GP_Boxing
	}

	public enum FIKHKMKGDIA
	{
		CityHeroBoy
	}

	public enum OBICEGCJIAG
	{
		InValid,
		NBSplit,
		IIV_GP_PURPLE_Ball
	}

	public enum MLFHBDHILOO
	{
		NBDash,
		NBSplit,
		CityHeroBoy,
		IIV_GP_Boxing,
		ForceTutorial,
		FreeViewCamera
	}

	private class OEIKEOFBDMK
	{
		public BHGGAEEHJCO BAFEIAKDCEK;

		public ILinkTwoPointEffect DOAJLBPIENL;
	}

	public class IEHEBKEFFCC : GEvent
	{
		public Player GJKKLNLABPO;

		public IGJPHDANPJD PDHPNIDHFBM;

		public IGJPHDANPJD EDLGHACJCJL;

		public void BLJEIAHKEPL(Player PGEGMKJKOKI, IGJPHDANPJD OLAHOFPELBC, IGJPHDANPJD GCJPAAPKMMA)
		{
		}

		public void DCBKFKBIPAC()
		{
		}
	}

	public enum EFBIHIABNJM
	{
		Normal,
		Jump,
		Fall
	}

	public abstract class BGDMAEFKAFK
	{
		protected EOGPGNIDOKF BIJCHKALEBE;

		private Player _003CMALAOHNCOBI_003Ek__BackingField;

		protected Player NKPFAEIGJLB
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public BGDMAEFKAFK(Player LDCIMNAAGNO)
		{
		}

		public abstract IGJPHDANPJD JLCHKEOGPLC();

		public EOGPGNIDOKF KJMHAMFBAOG()
		{
			return EOGPGNIDOKF.EPHYSXPOSE_STANDING;
		}

		public void LKKDFPHJKGB(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM, EOGPGNIDOKF KCMJONOCMPN)
		{
		}

		public void HJNFOENPDIL(EOGPGNIDOKF KCMJONOCMPN)
		{
		}

		public void LLAFPLELHOE(IGJPHDANPJD GCJPAAPKMMA, EOGPGNIDOKF KCMJONOCMPN)
		{
		}

		protected void CAJKHJNFOBK(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM, EOGPGNIDOKF KCMJONOCMPN)
		{
		}

		protected void NMLDCILBDHB(IGJPHDANPJD GCJPAAPKMMA, EOGPGNIDOKF KCMJONOCMPN)
		{
		}

		protected virtual void KNOJLLAMIIM(IGJPHDANPJD GCJPAAPKMMA)
		{
		}

		protected virtual void NKFCJNLBDDI(IGJPHDANPJD OLAHOFPELBC)
		{
		}

		protected virtual void OHOJBJJFHJD(IGJPHDANPJD GCJPAAPKMMA, EOGPGNIDOKF KCMJONOCMPN)
		{
		}

		protected virtual void GPJGONKFEAG(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		protected virtual bool ADHKLGFCCDP(EOGPGNIDOKF KCMJONOCMPN)
		{
			return false;
		}

		protected bool NLMOEEMMMBE(IGJPHDANPJD GCJPAAPKMMA, EOGPGNIDOKF KCMJONOCMPN)
		{
			return false;
		}
	}

	protected class BFCJMGDNINP : BGDMAEFKAFK
	{
		public BFCJMGDNINP(Player LDCIMNAAGNO)
			: base(null)
		{
		}

		public override IGJPHDANPJD JLCHKEOGPLC()
		{
			return IGJPHDANPJD.Walking;
		}

		protected override bool ADHKLGFCCDP(EOGPGNIDOKF KCMJONOCMPN)
		{
			return false;
		}

		protected override void OHOJBJJFHJD(IGJPHDANPJD GCJPAAPKMMA, EOGPGNIDOKF KCMJONOCMPN)
		{
		}

		protected override void GPJGONKFEAG(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		private void AEIDGPJKIPE(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		private void KDJABJMOHGD(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		private void EKJMJPCFFJK(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		protected virtual void ICDPOJKPIID(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		private void ADCDCACHPLO(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		private void DJJNCDLHOKJ(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		private void ODDJLGONBGK(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		private void FBNPLJNLNDL(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		private void FJFIHCCHMJJ(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		private void KFKFFFMAHOK(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		private void IKFONNCJPGI(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		private void ODGPHADCLPG(IGJPHDANPJD GCJPAAPKMMA, EOGPGNIDOKF KCMJONOCMPN)
		{
		}

		private void AGKMBBEKFLA(IGJPHDANPJD GCJPAAPKMMA, EOGPGNIDOKF KCMJONOCMPN)
		{
		}

		private void LBIFDFCPMIJ(IGJPHDANPJD GCJPAAPKMMA, EOGPGNIDOKF KCMJONOCMPN)
		{
		}

		private void BLJAGGFNOMA(IGJPHDANPJD GCJPAAPKMMA, EOGPGNIDOKF KCMJONOCMPN)
		{
		}

		private void OLHIPNELBDG(IGJPHDANPJD GCJPAAPKMMA, EOGPGNIDOKF KCMJONOCMPN)
		{
		}

		private void JGNGDMBIGPO(IGJPHDANPJD GCJPAAPKMMA, EOGPGNIDOKF KCMJONOCMPN)
		{
		}

		private void GOOHFJAHLEA(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		private void PJLDOEGJDNC(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		private void GMPDFJLLONP(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		private void LKCAJDMHJHP(IGJPHDANPJD GCJPAAPKMMA, EOGPGNIDOKF KCMJONOCMPN)
		{
		}

		public bool _003C_003EiFixBaseProxy_ADHKLGFCCDP(EOGPGNIDOKF P0)
		{
			return false;
		}

		public void _003C_003EiFixBaseProxy_OHOJBJJFHJD(IGJPHDANPJD P0, EOGPGNIDOKF P1)
		{
		}

		public void _003C_003EiFixBaseProxy_GPJGONKFEAG(IGJPHDANPJD P0, EOGPGNIDOKF P1)
		{
		}
	}

	protected class FBPICOOCHKK : BGDMAEFKAFK
	{
		public FBPICOOCHKK(Player LDCIMNAAGNO)
			: base(null)
		{
		}

		public override IGJPHDANPJD JLCHKEOGPLC()
		{
			return IGJPHDANPJD.Walking;
		}

		protected override void NKFCJNLBDDI(IGJPHDANPJD OLAHOFPELBC)
		{
		}

		protected override void KNOJLLAMIIM(IGJPHDANPJD GCJPAAPKMMA)
		{
		}

		protected override bool ADHKLGFCCDP(EOGPGNIDOKF KCMJONOCMPN)
		{
			return false;
		}

		protected override void GPJGONKFEAG(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		private void OJNIHNEGMIN()
		{
		}

		protected virtual void ICDPOJKPIID(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		protected virtual void DDEPLBFCJND(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		protected virtual void KAHPJOEEFCD(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		protected virtual void FGDOIEHIPNO(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		private void HAEPDJJHNLP(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		private void OFPCDMDOOEB(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		private void NCMICOLGIFJ(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		private void DMPMKCEDMPD(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		private void AAABLNKLMLA(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		private void PEPFPALMFAO(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		private void IKFONNCJPGI(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		private void ODGPHADCLPG(IGJPHDANPJD GCJPAAPKMMA, EOGPGNIDOKF KCMJONOCMPN)
		{
		}

		private void JKMGGHMADLP(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		private void LPOIFCPCHII()
		{
		}

		protected override void OHOJBJJFHJD(IGJPHDANPJD GCJPAAPKMMA, EOGPGNIDOKF KCMJONOCMPN)
		{
		}

		public void _003C_003EiFixBaseProxy_NKFCJNLBDDI(IGJPHDANPJD P0)
		{
		}

		public void _003C_003EiFixBaseProxy_KNOJLLAMIIM(IGJPHDANPJD P0)
		{
		}

		public bool _003C_003EiFixBaseProxy_ADHKLGFCCDP(EOGPGNIDOKF P0)
		{
			return false;
		}

		public void _003C_003EiFixBaseProxy_GPJGONKFEAG(IGJPHDANPJD P0, EOGPGNIDOKF P1)
		{
		}

		public void _003C_003EiFixBaseProxy_OHOJBJJFHJD(IGJPHDANPJD P0, EOGPGNIDOKF P1)
		{
		}
	}

	private class PAHCCEBNNCJ : BGDMAEFKAFK
	{
		public PAHCCEBNNCJ(Player LDCIMNAAGNO)
			: base(null)
		{
		}

		public override IGJPHDANPJD JLCHKEOGPLC()
		{
			return IGJPHDANPJD.Walking;
		}

		protected override void NKFCJNLBDDI(IGJPHDANPJD OLAHOFPELBC)
		{
		}

		protected override void KNOJLLAMIIM(IGJPHDANPJD GCJPAAPKMMA)
		{
		}

		public void _003C_003EiFixBaseProxy_NKFCJNLBDDI(IGJPHDANPJD P0)
		{
		}

		public void _003C_003EiFixBaseProxy_KNOJLLAMIIM(IGJPHDANPJD P0)
		{
		}
	}

	private class IGKIBIOAGEK : BGDMAEFKAFK
	{
		public IGKIBIOAGEK(Player LDCIMNAAGNO)
			: base(null)
		{
		}

		public override IGJPHDANPJD JLCHKEOGPLC()
		{
			return IGJPHDANPJD.Walking;
		}

		protected override bool ADHKLGFCCDP(EOGPGNIDOKF KCMJONOCMPN)
		{
			return false;
		}

		protected override void NKFCJNLBDDI(IGJPHDANPJD OLAHOFPELBC)
		{
		}

		protected override void KNOJLLAMIIM(IGJPHDANPJD GCJPAAPKMMA)
		{
		}

		public bool _003C_003EiFixBaseProxy_ADHKLGFCCDP(EOGPGNIDOKF P0)
		{
			return false;
		}

		public void _003C_003EiFixBaseProxy_NKFCJNLBDDI(IGJPHDANPJD P0)
		{
		}

		public void _003C_003EiFixBaseProxy_KNOJLLAMIIM(IGJPHDANPJD P0)
		{
		}
	}

	private class ONJHAPNGJHL : BGDMAEFKAFK
	{
		public ONJHAPNGJHL(Player LDCIMNAAGNO)
			: base(null)
		{
		}

		public override IGJPHDANPJD JLCHKEOGPLC()
		{
			return IGJPHDANPJD.Walking;
		}

		protected override bool ADHKLGFCCDP(EOGPGNIDOKF KCMJONOCMPN)
		{
			return false;
		}

		protected override void NKFCJNLBDDI(IGJPHDANPJD OLAHOFPELBC)
		{
		}

		protected override void KNOJLLAMIIM(IGJPHDANPJD GCJPAAPKMMA)
		{
		}

		public bool _003C_003EiFixBaseProxy_ADHKLGFCCDP(EOGPGNIDOKF P0)
		{
			return false;
		}

		public void _003C_003EiFixBaseProxy_NKFCJNLBDDI(IGJPHDANPJD P0)
		{
		}

		public void _003C_003EiFixBaseProxy_KNOJLLAMIIM(IGJPHDANPJD P0)
		{
		}
	}

	private class CMJCOAKMOJF : BGDMAEFKAFK
	{
		public CMJCOAKMOJF(Player LDCIMNAAGNO)
			: base(null)
		{
		}

		public override IGJPHDANPJD JLCHKEOGPLC()
		{
			return IGJPHDANPJD.Walking;
		}

		protected override bool ADHKLGFCCDP(EOGPGNIDOKF KCMJONOCMPN)
		{
			return false;
		}

		protected override void NKFCJNLBDDI(IGJPHDANPJD OLAHOFPELBC)
		{
		}

		protected override void KNOJLLAMIIM(IGJPHDANPJD GCJPAAPKMMA)
		{
		}

		protected override void GPJGONKFEAG(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		private void EBKPJABDIIL(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		private void OACMNCIEJMN(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		private void NHDCOPOJEMH(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		public bool _003C_003EiFixBaseProxy_ADHKLGFCCDP(EOGPGNIDOKF P0)
		{
			return false;
		}

		public void _003C_003EiFixBaseProxy_NKFCJNLBDDI(IGJPHDANPJD P0)
		{
		}

		public void _003C_003EiFixBaseProxy_KNOJLLAMIIM(IGJPHDANPJD P0)
		{
		}

		public void _003C_003EiFixBaseProxy_GPJGONKFEAG(IGJPHDANPJD P0, EOGPGNIDOKF P1)
		{
		}
	}

	private class NOKLFBJLAGF : BGDMAEFKAFK
	{
		private bool EIHGIKFIBEM;

		public NOKLFBJLAGF(Player LDCIMNAAGNO)
			: base(null)
		{
		}

		public override IGJPHDANPJD JLCHKEOGPLC()
		{
			return IGJPHDANPJD.Walking;
		}

		protected override void NKFCJNLBDDI(IGJPHDANPJD OLAHOFPELBC)
		{
		}

		protected override void KNOJLLAMIIM(IGJPHDANPJD GCJPAAPKMMA)
		{
		}

		public void _003C_003EiFixBaseProxy_NKFCJNLBDDI(IGJPHDANPJD P0)
		{
		}

		public void _003C_003EiFixBaseProxy_KNOJLLAMIIM(IGJPHDANPJD P0)
		{
		}
	}

	protected class KPIEDJKJMBB : BGDMAEFKAFK
	{
		public KPIEDJKJMBB(Player LDCIMNAAGNO)
			: base(null)
		{
		}

		public override IGJPHDANPJD JLCHKEOGPLC()
		{
			return IGJPHDANPJD.Walking;
		}

		protected override void NKFCJNLBDDI(IGJPHDANPJD OLAHOFPELBC)
		{
		}

		protected override void GPJGONKFEAG(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		protected override void KNOJLLAMIIM(IGJPHDANPJD GCJPAAPKMMA)
		{
		}

		protected override bool ADHKLGFCCDP(EOGPGNIDOKF KCMJONOCMPN)
		{
			return false;
		}

		public void _003C_003EiFixBaseProxy_NKFCJNLBDDI(IGJPHDANPJD P0)
		{
		}

		public void _003C_003EiFixBaseProxy_GPJGONKFEAG(IGJPHDANPJD P0, EOGPGNIDOKF P1)
		{
		}

		public void _003C_003EiFixBaseProxy_KNOJLLAMIIM(IGJPHDANPJD P0)
		{
		}

		public bool _003C_003EiFixBaseProxy_ADHKLGFCCDP(EOGPGNIDOKF P0)
		{
			return false;
		}
	}

	protected class FAGLJAHJGHB : BGDMAEFKAFK
	{
		public FAGLJAHJGHB(Player LDCIMNAAGNO)
			: base(null)
		{
		}

		public override IGJPHDANPJD JLCHKEOGPLC()
		{
			return IGJPHDANPJD.Walking;
		}

		protected override void NKFCJNLBDDI(IGJPHDANPJD OLAHOFPELBC)
		{
		}

		protected override void GPJGONKFEAG(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		protected override void OHOJBJJFHJD(IGJPHDANPJD GCJPAAPKMMA, EOGPGNIDOKF KCMJONOCMPN)
		{
		}

		protected override void KNOJLLAMIIM(IGJPHDANPJD GCJPAAPKMMA)
		{
		}

		protected override bool ADHKLGFCCDP(EOGPGNIDOKF KCMJONOCMPN)
		{
			return false;
		}

		public void _003C_003EiFixBaseProxy_NKFCJNLBDDI(IGJPHDANPJD P0)
		{
		}

		public void _003C_003EiFixBaseProxy_GPJGONKFEAG(IGJPHDANPJD P0, EOGPGNIDOKF P1)
		{
		}

		public void _003C_003EiFixBaseProxy_OHOJBJJFHJD(IGJPHDANPJD P0, EOGPGNIDOKF P1)
		{
		}

		public void _003C_003EiFixBaseProxy_KNOJLLAMIIM(IGJPHDANPJD P0)
		{
		}

		public bool _003C_003EiFixBaseProxy_ADHKLGFCCDP(EOGPGNIDOKF P0)
		{
			return false;
		}
	}

	private class CGIMFAKFCFN : BGDMAEFKAFK
	{
		public CGIMFAKFCFN(Player LDCIMNAAGNO)
			: base(null)
		{
		}

		public override IGJPHDANPJD JLCHKEOGPLC()
		{
			return IGJPHDANPJD.Walking;
		}

		protected override bool ADHKLGFCCDP(EOGPGNIDOKF KCMJONOCMPN)
		{
			return false;
		}

		protected override void NKFCJNLBDDI(IGJPHDANPJD OLAHOFPELBC)
		{
		}

		protected override void KNOJLLAMIIM(IGJPHDANPJD GCJPAAPKMMA)
		{
		}

		protected override void GPJGONKFEAG(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		protected override void OHOJBJJFHJD(IGJPHDANPJD GCJPAAPKMMA, EOGPGNIDOKF KCMJONOCMPN)
		{
		}

		private void MDGAKOLIBPM(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		private void EIGFIKFMFOP(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		private void ELCEJGOBPHG(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		private void PBLKNFFDBDD(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		private void BPKNNPFAPLA(IGJPHDANPJD GCJPAAPKMMA, EOGPGNIDOKF KCMJONOCMPN)
		{
		}

		private void DLFGFPPDHKO(IGJPHDANPJD GCJPAAPKMMA, EOGPGNIDOKF KCMJONOCMPN)
		{
		}

		public bool _003C_003EiFixBaseProxy_ADHKLGFCCDP(EOGPGNIDOKF P0)
		{
			return false;
		}

		public void _003C_003EiFixBaseProxy_NKFCJNLBDDI(IGJPHDANPJD P0)
		{
		}

		public void _003C_003EiFixBaseProxy_KNOJLLAMIIM(IGJPHDANPJD P0)
		{
		}

		public void _003C_003EiFixBaseProxy_GPJGONKFEAG(IGJPHDANPJD P0, EOGPGNIDOKF P1)
		{
		}

		public void _003C_003EiFixBaseProxy_OHOJBJJFHJD(IGJPHDANPJD P0, EOGPGNIDOKF P1)
		{
		}
	}

	private class EKIKOPCFKJK : BGDMAEFKAFK
	{
		public EKIKOPCFKJK(Player LDCIMNAAGNO)
			: base(null)
		{
		}

		public override IGJPHDANPJD JLCHKEOGPLC()
		{
			return IGJPHDANPJD.Walking;
		}
	}

	private class CMLAICGEJDL : BGDMAEFKAFK
	{
		public CMLAICGEJDL(Player LDCIMNAAGNO)
			: base(null)
		{
		}

		public override IGJPHDANPJD JLCHKEOGPLC()
		{
			return IGJPHDANPJD.Walking;
		}

		protected override void NKFCJNLBDDI(IGJPHDANPJD OLAHOFPELBC)
		{
		}

		protected override void KNOJLLAMIIM(IGJPHDANPJD GCJPAAPKMMA)
		{
		}

		public void _003C_003EiFixBaseProxy_NKFCJNLBDDI(IGJPHDANPJD P0)
		{
		}

		public void _003C_003EiFixBaseProxy_KNOJLLAMIIM(IGJPHDANPJD P0)
		{
		}
	}

	private class PFBOEOOACMN : BGDMAEFKAFK
	{
		public PFBOEOOACMN(Player LDCIMNAAGNO)
			: base(null)
		{
		}

		public override IGJPHDANPJD JLCHKEOGPLC()
		{
			return IGJPHDANPJD.Walking;
		}

		protected override void NKFCJNLBDDI(IGJPHDANPJD OLAHOFPELBC)
		{
		}

		protected override void KNOJLLAMIIM(IGJPHDANPJD GCJPAAPKMMA)
		{
		}

		public void _003C_003EiFixBaseProxy_NKFCJNLBDDI(IGJPHDANPJD P0)
		{
		}

		public void _003C_003EiFixBaseProxy_KNOJLLAMIIM(IGJPHDANPJD P0)
		{
		}
	}

	private class HOGMJNJDEEI : BGDMAEFKAFK
	{
		public HOGMJNJDEEI(Player LDCIMNAAGNO)
			: base(null)
		{
		}

		public override IGJPHDANPJD JLCHKEOGPLC()
		{
			return IGJPHDANPJD.Walking;
		}

		protected override void NKFCJNLBDDI(IGJPHDANPJD OLAHOFPELBC)
		{
		}

		protected override void KNOJLLAMIIM(IGJPHDANPJD GCJPAAPKMMA)
		{
		}

		public void _003C_003EiFixBaseProxy_NKFCJNLBDDI(IGJPHDANPJD P0)
		{
		}

		public void _003C_003EiFixBaseProxy_KNOJLLAMIIM(IGJPHDANPJD P0)
		{
		}
	}

	private class DLOFHHJPJIO : BGDMAEFKAFK
	{
		public DLOFHHJPJIO(Player LDCIMNAAGNO)
			: base(null)
		{
		}

		public override IGJPHDANPJD JLCHKEOGPLC()
		{
			return IGJPHDANPJD.Walking;
		}

		protected override void NKFCJNLBDDI(IGJPHDANPJD OLAHOFPELBC)
		{
		}

		protected override void KNOJLLAMIIM(IGJPHDANPJD GCJPAAPKMMA)
		{
		}

		protected override bool ADHKLGFCCDP(EOGPGNIDOKF KCMJONOCMPN)
		{
			return false;
		}

		protected override void GPJGONKFEAG(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		protected virtual void ICDPOJKPIID(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		public void _003C_003EiFixBaseProxy_NKFCJNLBDDI(IGJPHDANPJD P0)
		{
		}

		public void _003C_003EiFixBaseProxy_KNOJLLAMIIM(IGJPHDANPJD P0)
		{
		}

		public bool _003C_003EiFixBaseProxy_ADHKLGFCCDP(EOGPGNIDOKF P0)
		{
			return false;
		}

		public void _003C_003EiFixBaseProxy_GPJGONKFEAG(IGJPHDANPJD P0, EOGPGNIDOKF P1)
		{
		}
	}

	private class KKLMKFDJGKO : BGDMAEFKAFK
	{
		public KKLMKFDJGKO(Player LDCIMNAAGNO)
			: base(null)
		{
		}

		public override IGJPHDANPJD JLCHKEOGPLC()
		{
			return IGJPHDANPJD.Walking;
		}

		protected override bool ADHKLGFCCDP(EOGPGNIDOKF KCMJONOCMPN)
		{
			return false;
		}

		protected override void NKFCJNLBDDI(IGJPHDANPJD OLAHOFPELBC)
		{
		}

		protected override void KNOJLLAMIIM(IGJPHDANPJD GCJPAAPKMMA)
		{
		}

		public bool _003C_003EiFixBaseProxy_ADHKLGFCCDP(EOGPGNIDOKF P0)
		{
			return false;
		}

		public void _003C_003EiFixBaseProxy_NKFCJNLBDDI(IGJPHDANPJD P0)
		{
		}

		public void _003C_003EiFixBaseProxy_KNOJLLAMIIM(IGJPHDANPJD P0)
		{
		}
	}

	private class BKGJKNPIPLO : BGDMAEFKAFK
	{
		public BKGJKNPIPLO(Player LDCIMNAAGNO)
			: base(null)
		{
		}

		public override IGJPHDANPJD JLCHKEOGPLC()
		{
			return IGJPHDANPJD.Walking;
		}

		protected override void KNOJLLAMIIM(IGJPHDANPJD GCJPAAPKMMA)
		{
		}

		protected override void NKFCJNLBDDI(IGJPHDANPJD OLAHOFPELBC)
		{
		}

		protected override void OHOJBJJFHJD(IGJPHDANPJD GCJPAAPKMMA, EOGPGNIDOKF KCMJONOCMPN)
		{
		}

		protected override void GPJGONKFEAG(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		protected override bool ADHKLGFCCDP(EOGPGNIDOKF KCMJONOCMPN)
		{
			return false;
		}

		private void PLKHJDBPIEI(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		private void PMICKODPLAJ(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		public void _003C_003EiFixBaseProxy_KNOJLLAMIIM(IGJPHDANPJD P0)
		{
		}

		public void _003C_003EiFixBaseProxy_NKFCJNLBDDI(IGJPHDANPJD P0)
		{
		}

		public void _003C_003EiFixBaseProxy_OHOJBJJFHJD(IGJPHDANPJD P0, EOGPGNIDOKF P1)
		{
		}

		public void _003C_003EiFixBaseProxy_GPJGONKFEAG(IGJPHDANPJD P0, EOGPGNIDOKF P1)
		{
		}

		public bool _003C_003EiFixBaseProxy_ADHKLGFCCDP(EOGPGNIDOKF P0)
		{
			return false;
		}
	}

	private class IJCLFDCKAEE : BGDMAEFKAFK
	{
		public IJCLFDCKAEE(Player LDCIMNAAGNO)
			: base(null)
		{
		}

		public override IGJPHDANPJD JLCHKEOGPLC()
		{
			return IGJPHDANPJD.Walking;
		}

		protected override void NKFCJNLBDDI(IGJPHDANPJD OLAHOFPELBC)
		{
		}

		protected override void KNOJLLAMIIM(IGJPHDANPJD GCJPAAPKMMA)
		{
		}

		protected override void GPJGONKFEAG(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		protected override void OHOJBJJFHJD(IGJPHDANPJD GCJPAAPKMMA, EOGPGNIDOKF KCMJONOCMPN)
		{
		}

		protected override bool ADHKLGFCCDP(EOGPGNIDOKF KCMJONOCMPN)
		{
			return false;
		}

		public void _003C_003EiFixBaseProxy_NKFCJNLBDDI(IGJPHDANPJD P0)
		{
		}

		public void _003C_003EiFixBaseProxy_KNOJLLAMIIM(IGJPHDANPJD P0)
		{
		}

		public void _003C_003EiFixBaseProxy_GPJGONKFEAG(IGJPHDANPJD P0, EOGPGNIDOKF P1)
		{
		}

		public void _003C_003EiFixBaseProxy_OHOJBJJFHJD(IGJPHDANPJD P0, EOGPGNIDOKF P1)
		{
		}

		public bool _003C_003EiFixBaseProxy_ADHKLGFCCDP(EOGPGNIDOKF P0)
		{
			return false;
		}
	}

	private class CAHCPIINKEG : BGDMAEFKAFK
	{
		public CAHCPIINKEG(Player LDCIMNAAGNO)
			: base(null)
		{
		}

		public override IGJPHDANPJD JLCHKEOGPLC()
		{
			return IGJPHDANPJD.Walking;
		}

		protected override void NKFCJNLBDDI(IGJPHDANPJD OLAHOFPELBC)
		{
		}

		protected override void KNOJLLAMIIM(IGJPHDANPJD GCJPAAPKMMA)
		{
		}

		public void _003C_003EiFixBaseProxy_NKFCJNLBDDI(IGJPHDANPJD P0)
		{
		}

		public void _003C_003EiFixBaseProxy_KNOJLLAMIIM(IGJPHDANPJD P0)
		{
		}
	}

	protected class GHPBBGKOKHB : FBPICOOCHKK
	{
		public GHPBBGKOKHB(Player LDCIMNAAGNO)
			: base(null)
		{
		}

		protected override void KAHPJOEEFCD(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		protected override void DDEPLBFCJND(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		protected override void ICDPOJKPIID(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		public void _003C_003EiFixBaseProxy_KAHPJOEEFCD(IGJPHDANPJD P0, EOGPGNIDOKF P1)
		{
		}

		public void _003C_003EiFixBaseProxy_DDEPLBFCJND(IGJPHDANPJD P0, EOGPGNIDOKF P1)
		{
		}

		public void _003C_003EiFixBaseProxy_ICDPOJKPIID(IGJPHDANPJD P0, EOGPGNIDOKF P1)
		{
		}
	}

	protected class DHFGLKFKKBC : KPIEDJKJMBB
	{
		public DHFGLKFKKBC(Player LDCIMNAAGNO)
			: base(null)
		{
		}

		protected override void NKFCJNLBDDI(IGJPHDANPJD OLAHOFPELBC)
		{
		}

		public new void _003C_003EiFixBaseProxy_NKFCJNLBDDI(IGJPHDANPJD P0)
		{
		}
	}

	protected class LFBJBFJIBHK : BFCJMGDNINP
	{
		public LFBJBFJIBHK(Player LDCIMNAAGNO)
			: base(null)
		{
		}

		protected override void ICDPOJKPIID(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
		{
		}

		public void _003C_003EiFixBaseProxy_ICDPOJKPIID(IGJPHDANPJD P0, EOGPGNIDOKF P1)
		{
		}
	}

	public delegate void ACDGKAEOMGJ(Player PGEGMKJKOKI, OAFPLENFFPA CHIHINJEFAI, float DBHJCLICABH = 0f, float OOHPGKKKJJP = 0f);

	public delegate void OAKGCHJHDDJ(Player PGEGMKJKOKI, IGJPHDANPJD LALADOJHOBE, IGJPHDANPJD GCJPAAPKMMA, EOGPGNIDOKF PFPCMFDBGPB, EOGPGNIDOKF KCMJONOCMPN);

	public delegate void ECAABJEOKPM(Player PGEGMKJKOKI, Vector3 JDAAHCPNKJG, Quaternion MJHGBLMFJND, float HOGHEFNINAE);

	private enum EGDEHGCIILC
	{
		Unhitted,
		Hitted,
		FadeIn,
		FadeOut
	}

	public enum AALGCBFJHJM
	{
		Enable,
		Disable,
		Invisible
	}

	public class GMIEHNAILKF
	{
		public bool INPKKGMOBLM;

		public DGNALFBNMDP NBLHNPAHGNA;

		public void DCBKFKBIPAC()
		{
		}
	}

	public enum CKMIIAEOOKD
	{
		None,
		XRayShader
	}

	public interface ICFILIBHMAJ
	{
		uint HJHPNEMLLGD();

		bool DKHAMNMMELJ(Player FFHGOACBDMH);

		void DPEPOPPGEAK();

		float IIPMFFJMDPA();

		void FFHFPILHGDF();

		void IEFDFBJCBPH();

		void CLONDADPHAN();

		void OKOFEFDGNDC();
	}

	public class LPMLOHBLCCG
	{
		public uint ODPHDCONHPI;

		public uint LCIGBBOBPKK;

		public float AEIAAHOOABN;

		public float NKJFOBALDGG;

		public float KPPLKCNCMML;

		public float BPFLCNLCAAM;

		public bool CECFNMHGKCD;

		public ResourceID IEPKHLCHOJP;

		public string EICGDADIOCL;

		public float LIEPIBNBGKB;

		public LPMLOHBLCCG(uint APDFMHJBNLA, float IDCHLDICNPP, float CNKMEPFCJOM, float PHLKJIEAIDJ, float DFKJIKFKKDH, ResourceID IOGHDPOFIGL = default(ResourceID), string JOGKNFJNJNF = null)
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<MANLOOMKLOD> _003C_003E9__95_0;

		public static Comparison<IHJIKFAEDCM> _003C_003E9__110_0;

		public static Action<float> _003C_003E9__2428_0;

		public static Comparison<uint> _003C_003E9__2863_1;

		public static Comparison<NCHOOLJCDNM> _003C_003E9__2863_0;

		internal int HPOIMDCCMFD(MANLOOMKLOD MDFHMBHHGGF, MANLOOMKLOD OGECPGHMIHA)
		{
			return 0;
		}

		internal int ILKPGLLPAAB(IHJIKFAEDCM MDFHMBHHGGF, IHJIKFAEDCM OGECPGHMIHA)
		{
			return 0;
		}

		internal void DODOKBPMFOD(float HKJKEJONGMC)
		{
		}

		internal int HOHAOGJENOG(uint FADOEDJHAGD, uint LJJDHJOELML)
		{
			return 0;
		}

		internal int DDNCCAFLBNA(NCHOOLJCDNM FADOEDJHAGD, NCHOOLJCDNM LJJDHJOELML)
		{
			return 0;
		}
	}

	private sealed class BDDFPMJJOGD
	{
		public Player LDCIMNAAGNO;

		public Vector3 OCLFLNINDAP;

		public float ABKDDMOLCBC;

		internal void KFBFHKKONJI(uint JDHNCLHNJIP, ResourceID JMIMKLAELHE, GameObject KGJNMPHDKAB)
		{
		}
	}

	private sealed class ELNNBIHHCCJ
	{
		public Player KOKNHFGCGLN;

		public ITransformNode DELFNCBMJIM;

		internal void GOPLNKGEHAG(DAPOIBANHEH JKPPNGPCCHN)
		{
		}

		internal void FGAMINOPDLA(DAPOIBANHEH JKPPNGPCCHN)
		{
		}

		internal void OEADNKIHIBD(DAPOIBANHEH JKPPNGPCCHN)
		{
		}

		internal void ELJFFLFOFDC(DAPOIBANHEH JKPPNGPCCHN)
		{
		}

		internal void HJNKBPAEAJJ(DAPOIBANHEH JKPPNGPCCHN)
		{
		}

		internal void DLENEMLIGDL(DAPOIBANHEH JKPPNGPCCHN)
		{
		}

		internal void GIBHNPODIMG(DAPOIBANHEH JKPPNGPCCHN)
		{
		}

		internal void NNHHCCGEEAH(DAPOIBANHEH JKPPNGPCCHN)
		{
		}

		internal void PLDBBIKLDFM(DAPOIBANHEH JKPPNGPCCHN)
		{
		}

		internal void NKIFAHAENDG(DAPOIBANHEH JKPPNGPCCHN)
		{
		}

		internal void MGIBCNBEOIH(DAPOIBANHEH JKPPNGPCCHN)
		{
		}

		internal void OFFNIFEBEPA(DAPOIBANHEH JKPPNGPCCHN)
		{
		}

		internal void AKLAHMDCNNH(DAPOIBANHEH JKPPNGPCCHN)
		{
		}

		internal void CJBNPNCCIMN(DAPOIBANHEH JKPPNGPCCHN)
		{
		}

		internal void FALFIKJMLFD(DAPOIBANHEH JKPPNGPCCHN)
		{
		}

		internal void MHPKENBBNNO(DAPOIBANHEH JKPPNGPCCHN)
		{
		}

		internal void EDMJPEAILLB(DAPOIBANHEH JKPPNGPCCHN)
		{
		}

		internal void GPLGGDKPKPO(DAPOIBANHEH JKPPNGPCCHN)
		{
		}

		internal void EEDIMPGAOJH(DAPOIBANHEH JKPPNGPCCHN)
		{
		}
	}

	private sealed class CDIPLLKGEGJ
	{
		public float PCKBJNOLGEJ;

		public Player KOKNHFGCGLN;

		internal void MGHHHKIMECA(uint CNMCEMFDGGP, ResourceID JMIMKLAELHE, GameObject KGJNMPHDKAB)
		{
		}
	}

	private sealed class AGDDFMNKIID
	{
		public Player KOKNHFGCGLN;

		public LevelTeleportDoor FMBDOFBIDKF;

		public uint ONFPCIABJJC;

		internal void PBLDNADHKAG()
		{
		}
	}

	private sealed class JMKCFJHPKFO
	{
		public EntityVisualEffectManager GNGLJGFBCLK;

		public Player KOKNHFGCGLN;

		internal void HOLDANLNOLO(uint JPEHNBCECBD, ResourceID LAKJAMPOIFA, GameObject BOMJKCLNOKO)
		{
		}
	}

	private sealed class EFBEKENCBEG
	{
		public Player KOKNHFGCGLN;

		public bool JFNHFMJCLJJ;

		internal void NLACINHALLG()
		{
		}
	}

	private sealed class JHKNOIHIKOO
	{
		public Player KOKNHFGCGLN;

		public ResourceID GGMIDNEJGNO;

		public float CNKMEPFCJOM;

		internal void IAFAIIFOIGN()
		{
		}
	}

	private sealed class BKOHGEPHCOM
	{
		public TransformData ICHJBEPFCOO;

		public Player KOKNHFGCGLN;

		public ResourceID FMNOENNAPMK;

		public Action<bool> CEHELPAIELA;

		internal void ABKDFGGPEDP(bool FFCKGGMFPMF)
		{
		}
	}

	private sealed class DIPNPPCPAPH
	{
		public TransformData ICHJBEPFCOO;

		public Player KOKNHFGCGLN;

		public ResourceID FMNOENNAPMK;

		public Action<bool> CEHELPAIELA;

		internal void MPOPFLCEFAI(bool FFCKGGMFPMF)
		{
		}
	}

	private sealed class JDDGFAKGKED
	{
		public TransformData ICHJBEPFCOO;

		public Player KOKNHFGCGLN;

		public ResourceID FMNOENNAPMK;

		public EAvatarModelIngameType LHGFEFOJMFC;

		public Action<bool> CEHELPAIELA;

		internal void CHPCKADIMIN(bool FFCKGGMFPMF)
		{
		}
	}

	private sealed class FJDEGPCPCPB
	{
		public Player KOKNHFGCGLN;

		public AvatarTransformData CBGLCANKIJA;

		internal void IOOHOONPCPJ(uint LIKPJDHGPFG, ResourceID OCCLMDNGINA, GameObject KGJNMPHDKAB)
		{
		}
	}

	private sealed class OMBNDGKNBCD
	{
		public GameObject ADDGINGLHBN;

		internal void JFDGLIOGALK(uint JDHNCLHNJIP, ResourceID GGMIDNEJGNO, GameObject GEDMIJPILBO)
		{
		}
	}

	private sealed class MEINKHCKJCM
	{
		public Player KOKNHFGCGLN;

		public uint KOAALACEJED;

		internal void APGGOGAMCBG()
		{
		}

		internal void LPIHGCPFBGO()
		{
		}
	}

	private sealed class KPLCNFFDAJA
	{
		public BHGGAEEHJCO OBMFMAKFDDL;

		internal bool FGABIOJOLHA(DEIINJIGKAC FJEPEDPFODO)
		{
			return false;
		}
	}

	private sealed class HNMPBELFLND
	{
		public Action<bool> PPPKMNCCEOA;

		public Player KOKNHFGCGLN;

		public uint JPBDHEELLLK;

		public float PCMPHDMHGHF;

		internal void AANPGGAAHKK(bool PHJICGMMFME)
		{
		}
	}

	private sealed class LNJABJMKEPC
	{
		public Player KOKNHFGCGLN;

		public uint OCKLGKCODNF;

		public Vector3? HDFILHFDBKB;

		internal void ACNNPLPJDGO(bool HMMNPFJHLEE)
		{
		}
	}

	private sealed class IKIAOEGGMFL
	{
		public Player KOKNHFGCGLN;

		public uint PJMMDOONDOP;

		public uint HBIECBMJCDO;

		internal void KDFMKDAHAAA(bool CPBHKACJHLG)
		{
		}
	}

	private sealed class MNFLODMLDED
	{
		public Player KOKNHFGCGLN;

		public uint PJMMDOONDOP;

		public int MAIFPPFLCEB;

		public BHGGAEEHJCO JEDILDMEEPP;

		internal void ICOCMHNMJEL(bool CPBHKACJHLG)
		{
		}
	}

	private sealed class NNLELJMLOHP
	{
		public Player KOKNHFGCGLN;

		public uint LJECAGELDFD;

		public int FOCONCNGCAM;

		public bool BFCJFEBCLHP;

		internal void IEKAJLOPBMM(bool HMMNPFJHLEE)
		{
		}
	}

	private sealed class ONNLHNIPKHB
	{
		public Player KOKNHFGCGLN;

		public uint OJEPOBEENEK;

		public uint EIOKHLKJEEL;

		internal void BNPDHIGIKNF(bool HMMNPFJHLEE)
		{
		}
	}

	private sealed class MAKFJAOBHEI
	{
		public Player KOKNHFGCGLN;

		public uint OJEPOBEENEK;

		public uint EIOKHLKJEEL;

		internal void MHNFNHBALJI(bool HMMNPFJHLEE)
		{
		}
	}

	private sealed class IFDLIFLMGIO
	{
		public Player KOKNHFGCGLN;

		public uint EIOKHLKJEEL;

		internal void NEMAOANBJJJ()
		{
		}
	}

	private sealed class MENMDEHEGLO
	{
		public Player KOKNHFGCGLN;

		public byte AJPCBMBKNJC;

		internal void FKHGOANPJDD()
		{
		}

		internal void ALECKJFABEK()
		{
		}
	}

	private sealed class NMDKBJGMPFA
	{
		public Player KOKNHFGCGLN;

		public ManagedVisualInstanceHolder.OnManagedInstanceAttached IKNHMADBKPE;

		internal void BPMPCNMIEHJ(uint JDHNCLHNJIP, ResourceID JMIMKLAELHE, GameObject KGJNMPHDKAB)
		{
		}
	}

	private sealed class GMEGLBGKCMH
	{
		public Player KOKNHFGCGLN;

		public COOJMNODMOC APHHNHEDHKD;

		internal void JMPBAAODJAL(bool HMMNPFJHLEE)
		{
		}
	}

	private sealed class PLDIDFJADEO
	{
		public Player KOKNHFGCGLN;

		public COOJMNODMOC APHHNHEDHKD;

		internal void ADGEHCDLLJH(bool HMMNPFJHLEE)
		{
		}
	}

	private sealed class OJIKNOBPEPN
	{
		public Player KOKNHFGCGLN;

		public Player HOGELIPBAJI;

		public CollectionSuperEmote ALAGJBHFFBL;

		internal void FPHKIINBBIF(bool HMMNPFJHLEE)
		{
		}
	}

	private sealed class LHJHDLLNOPE
	{
		public Player KOKNHFGCGLN;

		public CollectionSuperEmote ALAGJBHFFBL;

		public COOJMNODMOC APHHNHEDHKD;

		internal void BDPGHMLNFAD(bool HMMNPFJHLEE)
		{
		}
	}

	private sealed class MKCOCJGDOKP : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public Player KOKNHFGCGLN;

		public Vector3 BAFIFNKBHLC;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public MKCOCJGDOKP(int CBPPJACCGOH)
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

	private sealed class HBOCILCAJDC : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public Player KOKNHFGCGLN;

		public Vector3 BAFIFNKBHLC;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public HBOCILCAJDC(int CBPPJACCGOH)
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

	private sealed class BOMLMOOPIPK : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public Player KOKNHFGCGLN;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public BOMLMOOPIPK(int CBPPJACCGOH)
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

	private sealed class GBHLELBPKML : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public Player KOKNHFGCGLN;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public GBHLELBPKML(int CBPPJACCGOH)
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

	private sealed class LDIKIMEFCBI : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public Player KOKNHFGCGLN;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public LDIKIMEFCBI(int CBPPJACCGOH)
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

	private sealed class LFEMIJBKAML : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public Player KOKNHFGCGLN;

		private GameObject CNDEFCOKDMK;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public LFEMIJBKAML(int CBPPJACCGOH)
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

	private sealed class EFLAPNKHGHM : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public Player KOKNHFGCGLN;

		private EMKJHAJNPDH CPFOFFLECCJ;

		private Animator CLDPMCFPJOE;

		private bool JPGGHHOAHJM;

		private FlightData GNIJJPEAOIG;

		private PreviewTeamFlightView PLPNKBNKODL;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public EFLAPNKHGHM(int CBPPJACCGOH)
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

	private sealed class AGHOBBLHJPI : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public Player KOKNHFGCGLN;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public AGHOBBLHJPI(int CBPPJACCGOH)
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

	private sealed class JCAOKMPGOIN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public Player KOKNHFGCGLN;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public JCAOKMPGOIN(int CBPPJACCGOH)
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

	private sealed class LMALKFJJHAH : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public PreviewTeamFlightView HOECOJGCDOG;

		public Player KOKNHFGCGLN;

		public FlightData LIHNBGOGPAH;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public LMALKFJJHAH(int CBPPJACCGOH)
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

	private sealed class MKMANNPDOHB : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public Player KOKNHFGCGLN;

		public int EIOKHLKJEEL;

		public int OJEPOBEENEK;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public MKMANNPDOHB(int CBPPJACCGOH)
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

	private sealed class JLEADODMEIB : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public Player KOKNHFGCGLN;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public JLEADODMEIB(int CBPPJACCGOH)
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

	private sealed class NLCJBKHMPPE : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public Player KOKNHFGCGLN;

		public uint BHLPPNDJKGB;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public NLCJBKHMPPE(int CBPPJACCGOH)
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

	private sealed class JKDMIHEGJIH : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public Player KOKNHFGCGLN;

		public uint KFMPAFHIGPF;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public JKDMIHEGJIH(int CBPPJACCGOH)
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

	private sealed class EHANPAGONII : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public Player KOKNHFGCGLN;

		public uint MNGIJBDCGGE;

		private bool NIICCDFGCAM;

		private LevelObjectPantherTruck CJJNIHAGCLE;

		private bool GACDGGJFKLO;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public EHANPAGONII(int CBPPJACCGOH)
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

	private sealed class FFHKJPECIII : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public Player KOKNHFGCGLN;

		public uint FOGNPDBNBDK;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public FFHKJPECIII(int CBPPJACCGOH)
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

	private sealed class JJCHOGAHEEM : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public Player KOKNHFGCGLN;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public JJCHOGAHEEM(int CBPPJACCGOH)
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

	private sealed class BABDKKNINBD : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public Player KOKNHFGCGLN;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public BABDKKNINBD(int CBPPJACCGOH)
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

	private sealed class PNMBIJJLAIF : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public Player KOKNHFGCGLN;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public PNMBIJJLAIF(int CBPPJACCGOH)
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

	private sealed class CNCHMNNGAOI : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public Player KOKNHFGCGLN;

		public EPreparationTimerType CCNBNLAPJFM;

		public uint LIKPJDHGPFG;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public CNCHMNNGAOI(int CBPPJACCGOH)
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

	private LazyDictionary<uint, uint> NLAINMKCJJA;

	private LazyDictionary<uint, uint> EPHNBLFBPHP;

	private readonly LazyDictionary<uint, OBHKEJHFBIP> CNFBAGOILKP;

	private readonly List<LJGEFDOCGFM> MBHENKFIGEC;

	public bool IsFrozenKnockDown;

	private Dictionary<ulong, IHAMCEAHFOC> NMPNDLDCLDB;

	private AudioResource COGALGHFJPE;

	private uint CLOANBEIICA;

	private Vector3 JHHINIJMBOO;

	private List<uint> BBEENOICNFD;

	private Dictionary<uint, List<uint>> MDDDIFMLMLA;

	private Dictionary<uint, List<uint>> JEGFKJBAOCB;

	private Dictionary<uint, BGIEHHOLMFL> LFAMNGJIJCN;

	private Comparison<MANLOOMKLOD> NCKBDFNJEEK;

	private List<MANLOOMKLOD> GDDGIEFOODG;

	private List<MANLOOMKLOD> KEICGAHKMBK;

	private List<MANLOOMKLOD> DCCBJDIALPA;

	private Comparison<IHJIKFAEDCM> FGBDAIDCLKP;

	private List<IHJIKFAEDCM> EIEHFANNIMI;

	private uint FOLNIIIKLBK;

	private uint BKDLHNNMAMI;

	private uint EKCHOGBLICD;

	private bool PJHBIBCBIIN;

	private PIKFAEFJOJA CANHJOANHJO;

	private GNLGEJKFMFH BDAPLPFDBFB;

	private Dictionary<uint, BAOAAPOIKKB> LKOABOKNKHC;

	private JDAGODAGAIK OHLHDACLKCD;

	private CLLCBACNHEM FEONEBCDKIA;

	private Dictionary<uint, ELIJDNKGDID> LOFCJMCOKAK;

	private bool HEIMEFIGCFO;

	private GameObject OOHDDNAAKJK;

	private HashSet<uint> OJHEBMIMGMB;

	private HashSet<uint> JLHMOMMACJL;

	private uint LOKFCEBBGFJ;

	private uint JEBDMOEIJGL;

	private GameObject NILKEBNFAML;

	private uint CIDAJOGNEGJ;

	private float PFJECKMCGFA;

	public float GBFootballEndTime;

	public float GBFootballStartTime;

	private GBGPFootballHitFlyTrigger GAPBNFNBKLN;

	private bool NNKGMDLDFJG;

	private bool APEDNPMKMNJ;

	private bool JDNGCMDLMNM;

	private Vector3 _003CDEMFLJGGKMP_003Ek__BackingField;

	private Coroutine KFOLBDHOPPO;

	private float KJLFBDFAICN;

	private Player ODMGBJNAIFP;

	private Vector3 OCMKPFDDCGB;

	private float JPLEJIOMFCD;

	private const float KGICCMPPMPH = 0.1f;

	private bool DPLOOCPLKBP;

	public uint InteractingReviveBoxID;

	public LevelSeafoodLittleGirl CurrSeafoodLittleGirl;

	public bool UGCRequestJump;

	public bool UGCStartFiring;

	public int JumpCount;

	private bool _003CAIKNHCBDMGF_003Ek__BackingField;

	private PhysicalCCT _003COODHNKFMOEG_003Ek__BackingField;

	private Vector3 HHJFHEJLIOH;

	public static ALJIMOHHJNO m_PlayerFiringEvt;

	public static BCNENNHAIDG m_PlayerHPChangeEvt;

	public static NAGLDDPFNCD m_PlayerEPChangeEvt;

	public static PCKKBMCLJGG m_PlayerIncreaseShootAndMoveSpeedSyncEvt;

	public static JJLKKJCPPNB m_PlayerTeamShieldEvt;

	public static EHAFOPMKHJO m_PlayerLandingFightProtectionInfoChangeEvt;

	public static NMHJPBFLOCG m_PlayerSerachEvt;

	public static IFNMJCACKHO m_PlayerAimEvt;

	public static DGKCJOILHDE PlayerSkillBrightEvt;

	public static OGEHLPBABJJ PetSkillBrightEvt;

	public static GNLLANIMHNP PlayerSkillPassiveCDEvt;

	public static BEBDFCOELCL PetSkillCDEvt;

	public static KAAIFAFGOJB HudPlayerSkillBrightAnimEvt;

	public static CMBGCMDMJKD HudPetSkillBrightAnimEvt;

	public static BFAGBOCGCAD HudPlayerSkillFlashAnimEvt;

	public static CAAMNOGOALI HudPetSkillFlashAnimEvt;

	public static LLKKJNIAMDD HudPetSkillChangeIconEvt;

	public static GJKPJDLFJMC HudPlayerSkillPassiveCDAnimEvt;

	public static MAGAJBDJAEI HudPetSkillCDAnimEvt;

	public static DDFCIJDHODF m_LocalPlayerHitEvt;

	public static IAMEOGKAJBN m_LPickupAreaEvt;

	public static OJOGAHIAAJM m_PickupAreaEvt;

	public static PEDGFKBFMEC m_PreparationCancelEvt;

	public static EELIECHCOBI m_PlayerSPChangeEvt;

	public static NOKLHKDNCNO hitArmorEvent;

	public static HDOLGJKOJLK PlayerIDEvt;

	public static CJIPCFAMCMM PlayerBoolStateEvt;

	public static KGCNPIGNFAD PlayerKillEvt;

	public static LOMICFHFOHA PersonaHitEvt;

	public static ILAJKNALAJI PersonaBreakEvt;

	public static LCEMIJHJIKG PlayerChangeTeamEvt;

	private bool EBDGOJNFBLN;

	private static readonly AOOCPENNMGL FDONOOANECF;

	private AOOCPENNMGL NCMEPIOHNJJ;

	public LazyDictionary<uint, uint> InventoryMap3P;

	public LevelBombModeBomb TriggerBombModeBomb;

	protected CEKCFPPLFNP EKJPKJIECOK;

	protected Dictionary<BHGGAEEHJCO, CEKCFPPLFNP> CHNOJGMCDEC;

	protected ResourceID FOCKBBMEMCN;

	protected uint LKDCAGNHDHP;

	protected GameObject JIGINOILDLL;

	protected ResourceID NEGAKDHJHEB;

	private Dictionary<uint, int> PNKKBOJMLBF;

	private Dictionary<int, uint> MDGCPIPPLBO;

	private Dictionary<int, uint> BCODCKBBHIJ;

	private LazyDictionary<uint, GameObject> OPLGPMJAEDP;

	protected GameObject KGHPFDHGIOE;

	protected uint DGPKLDCJIKC;

	public bool isInZeppelin;

	protected uint DCEHPCDIEEL;

	private bool OHMFJHOJJIL;

	private bool KNDOHBIBANE;

	private float PDLFJHDOJDA;

	private float MCIMFJOLGBI;

	protected bool AHKGKBGFCDN;

	protected GameObject HCLHGILPIDA;

	private Dictionary<uint, ushort> FOBBLLBAALH;

	public List<LevelMovePlatform> m_PendingMovePlatformList;

	protected Vector3 EEGLNKKNOHC;

	public bool UseAimForwardAsForward;

	public bool NeedShowVehicleScanTips;

	public bool NeedShowVehicleFortressTips;

	private bool GMAIDBGCPKL;

	private bool PAHIBBPDPKG;

	public bool IsPersonaEPDown;

	public bool IsPersonaEPUp;

	public Action LateUpdateFunc;

	protected bool JFIGCLAAMMO;

	protected Vector3 ONEAAADABAF;

	private float GMBEHBFDMPA;

	private Action JOCPOFNIEFC;

	private float LFGELCHOHMH;

	private float ALPNIBFOOKJ;

	public static float REQUEST_STROP_ACTION_CD;

	private float OABHPNNBGMM;

	public static KKLOIPIACBL s_bbUpdateRes;

	private static List<string> AAOIGPCCNJK;

	private static Dictionary<string, DAPOIBANHEH> EBPNGBCPIKG;

	protected readonly LazyDictionary<uint, WeaponSkinRightDesc> PDBMNGJMBAB;

	private bool _003CLGHFAILCNLD_003Ek__BackingField;

	private float _003CPKHBOFJDCHD_003Ek__BackingField;

	private DMBLHAPEMPA NMBNLGNJFNH;

	private bool _003CAEKDOGONAKE_003Ek__BackingField;

	private List<FLFADFKGIHB> CMBOLPECJLE;

	protected GameObject JJCJCCOHJAF;

	private EmoteLeaderCollider OBMFEMDHGEP;

	protected GameObject JDBFEEFHLGD;

	protected bool PHHJBLDFNFP;

	public uint m_KnockDownDamagePerSec;

	private bool DLPFJCNNAGI;

	protected uint BENDIENECKM;

	private JJCDFCNHPID PCMALENAEOA;

	private FEKBCHODFLE GELFGDBLHDE;

	private float _003CCHMFGAOOFOP_003Ek__BackingField;

	private MPICPIKELNP _003CHNFAOBLIHAH_003Ek__BackingField;

	private CommonMeshEffect PJOAKNKMEAF;

	private float DHJHALNOJLP;

	private ResourceID NEAAHOBKLFK;

	private bool GMJCMPJDKGD;

	public Transform MainCameraTransform;

	private JCPJMHLOOHD FBEINANDJAN;

	private uint GLMAPGCBOMO;

	protected ulong LLFKPBJCFEA;

	public bool IsCadet;

	protected BHGGAEEHJCO BMIGBNMBAJH;

	protected bool EOCKNADJPBE;

	protected ulong FGFCHGLJDIL;

	private int _003CGPCOJMNJGMP_003Ek__BackingField;

	public uint TeamModeID;

	public bool IsShowEquip;

	private BHGGAEEHJCO _003CBADPEFKDCED_003Ek__BackingField;

	private uint _003CGHMHMANDLFA_003Ek__BackingField;

	private string _003COAAKOJBCHPL_003Ek__BackingField;

	private string _003CMMEEMBAONGG_003Ek__BackingField;

	private uint _003CPFJHPNFAILL_003Ek__BackingField;

	private uint _003CDHJBNBMDKFO_003Ek__BackingField;

	public bool PartyGameComboChanged;

	public uint PartyGameMusicShootingIndex;

	public uint ServerGameMusicShootingIndex;

	protected object HICEDJPMMJB;

	protected string MOKGDCJLJFI;

	public string OriginalNickName;

	public bool IsClientBot;

	private bool AIEEAEKHEBK;

	private ulong NOBFKCFCGEA;

	private uint GMFIOAJKBGK;

	private List<AvatarSkillData> LMFNPPIANMF;

	protected bool MKIFMMHMMOH;

	private bool _003CBFDHGCFEGLF_003Ek__BackingField;

	private EPreparationTimerType KBHMGGLIMLI;

	protected TBlackBoard FPLHAOOMJKG;

	protected UserControlHandler ODIGILJGPAK;

	protected CharacterController PJOFCJEIEBP;

	private bool DNEMOJCICHA;

	private bool BMDPGFMCPHJ;

	private uint MAKCEDCBJEC;

	private bool EMFOFANEILK;

	private bool FGEEKMDHBBO;

	protected uint NANLEGBNDAJ;

	protected bool PJNENBOIPLG;

	private uint _003CFGFPIILFJLI_003Ek__BackingField;

	public bool m_GetInVehicle;

	private bool _003CMCEJIGPEJJH_003Ek__BackingField;

	private bool _003CGHMBKADJPIM_003Ek__BackingField;

	private bool _003CMCKOEPEHCCF_003Ek__BackingField;

	private bool _003CDEKPMNMCHJK_003Ek__BackingField;

	private AvatarEffect.EPlayerLastKillState _003CNKNFHFFNBFB_003Ek__BackingField;

	private bool _003CFDAPFMGNGCF_003Ek__BackingField;

	private bool LFMLELOOKCJ;

	private bool ODOOIKBEOGI;

	private bool ECCEPHMAEMH;

	private bool FNMAJOBDENL;

	private bool GOCPEIMFPCP;

	private bool _003CDFGBMGEJJHF_003Ek__BackingField;

	protected LevelAmmoBox BJDPPGFOEME;

	private uint _003CIBLPFOJOILG_003Ek__BackingField;

	private string _003CEDGJBODLNNC_003Ek__BackingField;

	private bool _003COGIOCLLKFOC_003Ek__BackingField;

	public Vector3 TeamMapMark;

	public bool ShowMapMark;

	public bool ShowMarkBtn;

	public uint CachedLastDriveVehicleObjID;

	public float InCount;

	public float UnCount;

	public uint GetCount;

	public uint AimCount;

	private Quaternion MJALKGNKGOA;

	public float Speed;

	private float EAIDFGKBBBL;

	private Queue<float> HHCLHMNHECN;

	public float ACount;

	private bool OGNKBGBJPEI;

	private bool LOBILABCMJJ;

	private bool INKIODFFGIJ;

	private bool KDHFEFGCPBJ;

	private bool INBKDMMKHFC;

	private bool KMOKDJGIMOG;

	private float GCBBONKJOGH;

	protected AvatarEffect KKFCHIGMHJP;

	protected GameObject CBAEGLGIAFB;

	protected PropAnimComponent EEGGCDJDPED;

	protected GameObject KPLGJDIMLKE;

	protected ResourceID BCDBOPFAINJ;

	protected BattleFlagConfigData DCCNLIFPANJ;

	protected IEnumerator GJHNLKJCEFD;

	protected IEnumerator ADJHODMDGBG;

	protected IEnumerator CLDHDBFFPBH;

	private uint KPDPGJLBGLF;

	private bool EFMNCBOJNIH;

	private uint PPCHKEOBONA;

	private uint PNMJKMJJMGJ;

	private int NMHODKKJNMN;

	private uint GLAHJFDDNJC;

	private uint DGONKCJOKKE;

	private uint JGDIEJOCKDF;

	public bool lockTransformMusicWhenUpdate;

	private uint MAKIJFOMLOI;

	private EDuoEmoteStage _003CLOCLHBIGGMG_003Ek__BackingField;

	private uint OHMHBEGMBMB;

	private ResourceID DGNLDPFLMEL;

	private uint _003CHGFCNJPHEPA_003Ek__BackingField;

	public FDAEPHMIEPC ActiveUISightingWeapon;

	protected JNGBBHLCHEB IHAIOPJEJEC;

	public bool NextFireActionFromAuxButton;

	private Quaternion _003CMDCADLIAJIH_003Ek__BackingField;

	private Quaternion _003CMPNEBFFFAMP_003Ek__BackingField;

	public IGABMLHFICJ m_AimAssist;

	public PBIGKAOEMBJ m_AimAssistForIceWall;

	private bool _003CIMEHJNCKIJN_003Ek__BackingField;

	private float JADIAHNBLCH;

	private bool MPEGFAIPDHI;

	private bool PAPCLFAPLPM;

	private bool ICJHKPJKPAJ;

	private HashSet<int> MILDHJONGNC;

	private EAimAssist FGEAKHHPKCC;

	private EMFEPBOHGOJ BJPAKMNJHKM;

	private INLEEGPMNMD HCGJIALNCHG;

	protected HDGPDKHLKKC GBLKMKHEHOJ;

	protected HJDBKPGPNFF CJNPLJABIMD;

	protected EJDJBFFBLLM ICHICNJNCIG;

	protected FollowCamera OHEPMNHMJMK;

	protected ITransformNode GOLAIKOPNJK;

	protected ITransformNode PEMOFNFCLFB;

	protected ITransformNode DIDHPFKMJJE;

	protected ITransformNode KAKOKIHEPCF;

	protected ITransformNode GCEICMOOFIA;

	protected ITransformNode CLOEKEADCHD;

	protected ITransformNode KNFKIDHJCCO;

	protected ITransformNode HNFBCFKKCJP;

	protected ITransformNode BOHFCEHMJBD;

	protected ITransformNode BIPBNNIFCNO;

	protected ITransformNode JLLMBADGKJP;

	protected ITransformNode INHGPBHOKPF;

	protected ITransformNode OEHAGFIGILO;

	protected Transform OKOLMFJKGEC;

	protected ITransformNode NBHOEOOCIIG;

	protected ITransformNode OEJFBHIIBBG;

	protected ITransformNode DIHJDDNIJHP;

	protected ITransformNode PNPBBNDANEM;

	protected ITransformNode KMIANNCLNOJ;

	protected ITransformNode KNBJLEHOPIL;

	protected Collider NFDNMIOPILM;

	protected OMELKCOGCBK LPEALCPGJBL;

	protected DLGEOEOEDBC KGHHPFINNLP;

	protected AFBNBKPGOGO LOIJOEBOEKE;

	private bool MPJBMKODJMF;

	protected NewPlayerAnimationSystemComponent DGNAGHGGMCA;

	protected PlayerAttributes KDJHNBAECLM;

	protected AvatarManager KPMDIPJINJO;

	protected AvatarDynamicEffectManager BPFDJKJMBFJ;

	protected AvatarPropManager HGJDEIPHCGN;

	protected PropertyData AJBLKLFDNHC;

	protected BigHeadComponent KHMHJPMEHND;

	protected BigHeadDataConfig IHHAAEMCFFL;

	protected float AKMAAACGLNF;

	protected bool MCHDPBAAFLG;

	protected GameObject JKPPJJHKLPI;

	private IceWallMakerData IBPHBBMGJEC;

	private bool _003CLOFPJDKBDNC_003Ek__BackingField;

	private bool _003CKINIABJKLEL_003Ek__BackingField;

	protected NavMeshAgent PDHEAKFNCFE;

	private NetworkPet _003CJPFIJGBLCAN_003Ek__BackingField;

	private bool KHGPIFCFBMK;

	public bool PetForceHide;

	private bool LNNCGAEJOGC;

	private bool _003CIJJBDCMHHAN_003Ek__BackingField;

	private bool LJFDNAEOLHC;

	private bool _003CJGMMBEILBBL_003Ek__BackingField;

	private uint _003COBBMAIMKOAF_003Ek__BackingField;

	private float KJKFBMCIHCB;

	private Vector3 LOALNHHEHKG;

	private float JINOKKJCLDH;

	public const float RECOVER_FROM_HIT_FLY_INTERVAL = 0.5f;

	public LHKJOBBBDHN HitFlyInfo;

	private bool GPGLGPDHLEK;

	private float KDNABNMDIPA;

	protected bool OFEBBCHKOAJ;

	protected const int MIMPLICHGIE = 3;

	public uint CallSetAimRotationCount;

	public string TeamColorStr;

	protected JKJPBMKDLLD OCPEPIBFAFA;

	protected TBTAction GMDCLGLHHBJ;

	protected AKCBJNJBLCC NLNPGCLDFIE;

	protected TBTAction AMOLCNNGFOM;

	protected TBTAction JNKCEMBOMNA;

	private bool _003CNNFKGNCILNK_003Ek__BackingField;

	private BCDFPMMEPFN ALNPLDGNKJF;

	private bool IFCJGLEOGDD;

	private EntityInfo IGDCGGALHLF;

	private FEMJPMLIKDF DKHGHJNAAPC;

	private EntityInfo PNEHCBHBKLO;

	protected List<FEMJPMLIKDF> BHFHCABMIHC;

	protected List<FEMJPMLIKDF> GCIBMFBPOOM;

	private List<EntityInfo> GFJEPBDIIIC;

	protected int JIFIBDCNDGD;

	protected Vector3 CMGJLOLGFHF;

	protected Vector3 AGCILMCMILA;

	protected bool GJFGGKHPBAL;

	protected bool PJAAFOOKJAH;

	private List<int> CILELFBGLAB;

	private List<int> OIANKMAKMOM;

	private List<int> HKPHDCFHBDN;

	private Dictionary<uint, float> EEFHAAIJOBP;

	private List<ClimbingTrigger> LPJJBDIBKAM;

	private ClimbingTrigger EMIEDAOBCCK;

	private bool LGOJIBCLBAI;

	private bool LCOHEAOPKBF;

	private Collider ABAJFENKLEO;

	public LevelDoor CurProcessLevelDoor;

	protected Vector3 AFNIFHFFBDK;

	protected Vehicle IIPDHPKBDBA;

	public LevelTechBuildSafeZoneController m_SafeZoneCtrlIAmIn;

	public LevelAstrolGate m_AstrolGateIAmIn;

	protected LevelStrop JCGPLBAPOLO;

	protected int HDBOEFADKOG;

	protected bool LGDNCOLPJLO;

	protected float AGMBGKBLOCP;

	public bool IsStropDash;

	protected FerrisWheelSeatGroup BKGPCHEBGEO;

	protected float BPDALPCIOCD;

	protected float OKOLGBFOBCK;

	protected bool AEBABLOBACB;

	protected Vector3 EPHKKENKHPN;

	protected Vector3 GJKANGHIEJL;

	protected Vector3 APCHOPGGCNE;

	protected Vector3 GBHIKHJAPCC;

	protected LevelChair HHAKPPECKIC;

	protected LevelSeesaw DLBGHKGKPBJ;

	protected int LMACIGOFJNL;

	protected LevelCatapult IKOPENAGFIH;

	protected LevelCannon DLJEJDEKIIL;

	protected Quaternion IDKAJOCHMAJ;

	protected Quaternion DMCFLCGOIMC;

	protected LevelFerrisWheel GFDJPAIPGBG;

	protected ITransformNode POIIJNJLGCO;

	protected ITransformNode GKAGFCKBHJB;

	protected ITransformNode LAIEJLCIJNC;

	protected ITransformNode BNDLKFFHENC;

	protected ITransformNode NALHCKGKDOF;

	protected ITransformNode LKCDAFFDJNK;

	protected ITransformNode FLGNFGPLGNH;

	private float MNLHLOHDMBC;

	private float ANOKJEDIJOH;

	private AudioResource AOMHBLDCCDM;

	protected Vector3 CPLBONAPFNC;

	protected LevelGrapplingHook DCAMIDOJNPD;

	private PlayerLagHint LELAMGPGNJK;

	protected LevelSwingSpider EBOHKMDBICE;

	protected bool CGFHMHEDDMF;

	protected uint CLFMJDFEBPL;

	protected float NAELFFILELE;

	private bool _003CALAALNGJLJN_003Ek__BackingField;

	private bool _003CNHJMKMPFGIC_003Ek__BackingField;

	private bool _003CFLPJKEJEFCA_003Ek__BackingField;

	private uint NIJCOKDFFGL;

	private bool _003CFJALMLADDPA_003Ek__BackingField;

	private bool _003CDKMHHMGPFAI_003Ek__BackingField;

	protected bool IGNJGJMKEHN;

	protected Vector3 JIPIGEIPEJP;

	protected Vector3 IPJAHOIEGIA;

	protected bool OEOPOLMJPFG;

	protected bool PBHHNFPOEIP;

	protected Vector3 DHEHCFDONNP;

	public int BlockUserControlExceptCancel;

	private bool _003CJDPCJEJMOHN_003Ek__BackingField;

	private bool _003CLBHECFKLCNK_003Ek__BackingField;

	private bool _003CDPIMCOIDBDC_003Ek__BackingField;

	private bool _003CKNJGEKFIBGP_003Ek__BackingField;

	private bool _003CCEPMANPBCBA_003Ek__BackingField;

	private bool MJFFGJJPFGM;

	private bool DEANHIGBIOH;

	private bool DBGDPHILGCN;

	private bool KOBCKNBFBDE;

	public int GetOffVehicleFrameCount;

	public int TeleportFrameCount;

	private bool _003CJINBGALLJBJ_003Ek__BackingField;

	private bool IFNFEMJMEBB;

	protected const uint OEOENFNGPNC = 1u;

	protected const uint ABOBEBHNDBD = 2u;

	protected const uint GDGAENOLDEB = 4u;

	protected const uint EHJIMDPJOCH = 8u;

	protected const uint JJPDOHKEEAF = 16u;

	protected const uint MPHACGLHFDO = 32u;

	protected const uint HIINGHJKJEJ = 64u;

	protected const uint ADDBIIGAEJK = 128u;

	protected const uint PHGGMMKPPIE = 256u;

	protected const uint AMGEABJJJCC = 512u;

	protected const uint NLNJLFJOMEJ = 1024u;

	protected const uint LFHPJMJGOBK = 2048u;

	protected const uint ACHNOAGCPLO = 4096u;

	protected const uint EBKNNBEKOND = 8192u;

	protected const uint MFDDOMENHPD = 16384u;

	protected const uint FGEMMJKOHED = 32768u;

	protected const uint KEKNCPDLBDK = 65536u;

	protected BitArrayBoolean DBBGJDEAKPM;

	public const uint ISVISIBLE_CAMERA = 1u;

	public const uint ISVISIBLE_VEHICLE = 2u;

	public const uint ISVISIBLE_STREAMER = 4u;

	public const uint ISVISIBLE_ONBOARD = 8u;

	public const uint ISVISIBLE_SKILL = 16u;

	public const uint ISVISIBLE_ALIVE = 32u;

	public const uint ISVISIBLE_INCUTSCENE = 64u;

	public const uint ISVISIBLE_PRI = 128u;

	public const uint ISVISIBLE_Transform = 256u;

	public const uint ISVISIBLE_ZoneChange = 512u;

	public const uint ISVISIBLE_Animation = 1024u;

	public const uint ISVISIBLE_WereWolfDead = 2048u;

	public const uint ISVISIBLE_SceneEdit = 4096u;

	public const uint ISVISIBLE_PHOTOGRAPH = 8192u;

	public const uint ISVISIBLE_UGCVISIBILITY = 16384u;

	public const uint ISVISIBLE_WAITING_CABIN = 32768u;

	public const uint ISVISIBLE_LASTKILL = 65536u;

	public const uint ISVISIBLE_LEAVING = 131072u;

	public const uint ISVISIBLE_FPP_Mode = 262144u;

	public const uint ISVISIBLE_Fligh_Async_Load = 524288u;

	public const uint ISVISIBLE_DynamicPVS = 1048576u;

	public const uint ISVISIBLE_CAMERA_MODE = 2097152u;

	public const uint ISVISIBLE_HIPPOCRISIS_RETREAT = 4194304u;

	public const uint ISVISIBLE_FLIGHTHIDEMODEL = 8388608u;

	public const uint ISVISIBLE_STEALTH_BLIND = 16777216u;

	public const uint ISVISIBLE_CAMERA_MODE_FREEZE_TEMPLATE = 33554432u;

	public const uint ISVISIBLE_FLIGHT_OPENING_ANIM = 67108864u;

	public const uint ISVISIBLE_LOBBYSOCIAL = 134217728u;

	public const uint ISVISIBLE_NINTH = 268435456u;

	private uint AHKNKIIPLHN;

	protected BitArrayBoolean CNELANECFHO;

	protected bool GHEHNNODNDE;

	protected Transform OIGCFLBNGPE;

	protected List<CEKLEBBHLIG> HOEENKIDPLP;

	public bool IsSkillActive;

	private bool AHGDIAFIIBH;

	private bool OINOFNFJIDO;

	private Texture2D HEEIKBIBGMF;

	private float EICEKBAPDEB;

	private float AOKGLCHBAPL;

	private float DEFEELIECOA;

	private const float EBCKNAABBBB = 0.02f;

	private const float DKFBEINOOOD = 0.5f;

	private GMPGMPFNMFP GGKLDGMAFHN;

	private MNMBLBKENMK FGFDHKJBKNB;

	private GMPGMPFNMFP NFKMINKONNC;

	protected CapsuleHuman JCIOGODKHPP;

	private CapsuleCollider HOKDPBIKHGH;

	private readonly float ADBFLPCHHHE;

	private readonly Vector3 BMKFMHCLKOE;

	private bool HPNGKKOBLGK;

	private GameObject BMELAJNKEGG;

	private List<CapsuleCollider> CGMPIMANBNC;

	private AudioResource PFFKKCFKEKI;

	protected bool FEAAHCCFIAI;

	protected bool OMONDIFJDHB;

	protected bool IFLAOLJLMJO;

	protected bool FPDAOFBPKLJ;

	protected int EAPCFCACHAJ;

	private LevelTriggerFountain.BKEAGLIPIGP NDOEKKMAGAM;

	private List<LevelTriggerHumanTire> GOHEHGGGFOP;

	private GMECHKEDOJP.KLANPAODHHF ELPJAFHFNKE;

	private LevelLockBountyVehicle ADMGBHGGPOD;

	private LevelTeamGatherPoint MFILFKKPOMF;

	private LevelBountyBox ENAPKMGPPOJ;

	private LevelWeRunBox GJCLJOHHJFI;

	private AMONMHPLPLP ICMFPMDAAEI;

	private CFIGAMOOFLH MJFIPKOKKLH;

	private uint _003CEMNDAEBIADO_003Ek__BackingField;

	private BadgeInfoInGame _003CBPFEIKMMDEI_003Ek__BackingField;

	private JKFICGGHNFN _003CELNAFCPDDEN_003Ek__BackingField;

	private DCLNOPKBHLB _003CDJJOHMACPNM_003Ek__BackingField;

	private GHDEMJHFOJM _003CIHGEEKCKOGI_003Ek__BackingField;

	private float FNDLDKELLJM;

	private float EEKGGBCCAOG;

	private float FJIBPOCDJFP;

	private float EFOLPGIAGGE;

	public float LevelInstrumentUseCDEndTime;

	public float LevelWishingTreeUseCDEndTime;

	public float WaitingCupUseCDEndTime;

	private bool LAOMENHNCEP;

	private float BCKLIGNIAKB;

	private bool MPKHIEBCOLG;

	public static byte[] _expBytes;

	public bool recyling;

	private static PropertyInfo FENMDBJAFPG;

	private Avatar IHEBEFEHLIL;

	private uint CKNONOOBJGB;

	private bool _003CDABCKMCKKOO_003Ek__BackingField;

	private byte _003CLNDNNADINIL_003Ek__BackingField;

	private bool CPLFPEPADKD;

	protected bool HLJFCDJFAOL;

	protected float IPIJOPABOIK;

	private uint MECCGIOAHPE;

	private uint KCDNEIMJDHA;

	private bool MFKBABKLKFA;

	private bool NGEEMDLCMNA;

	protected AFOLPMOCBOG NEAHDHLDANN;

	private uint CNADFGNFJNO;

	protected ResourceID EPKLBCPKBHL;

	protected ResourceID ICBAANKDOCH;

	protected ResourceID CFIHMDGBDDM;

	public ResourceID m_FlightLandAnimEffctResID;

	public float LandAnimClipTime;

	public IGJPHDANPJD PrevFallingState;

	protected SkyboardData LEOJCMCLELG;

	protected FlightData DFNMEHJEHLO;

	protected FlightData FAONGDMKAJG;

	protected PlayerAudioComponent COLOLCHMODI;

	protected PreviewTeamFlightView BEPIHOJHJKF;

	protected GameObject OABNNDPGJAD;

	protected Flight PAHNNFBKCBI;

	protected GameObject BMKDPIEKAEL;

	private uint PPDLCMDKHDH;

	private PlayableDirector DODFPJIHIAP;

	private PreviewTeamFlightView OINMPCMDMEE;

	private FlightData OJMBBJLJGMJ;

	private bool LCDJLMJPHJJ;

	protected GameObject ODNJDKCGPJP;

	protected Parachute FCNDKCHEPHA;

	private uint KGIDMGJLKMO;

	protected bool CDNDPAFHJIC;

	private uint PJBBGPGGBGL;

	private uint NFBLJJOKKDL;

	private ResourceID OOCBLDCAAEC;

	private bool JLDJJFNJBND;

	private uint DBKEJLKNJIM;

	protected uint JNJDPJIPBOK;

	protected GameObject DCOBHFJMNLD;

	protected GameObject CDKJHOBMJPK;

	protected ResourceID NOEJLDMOADB;

	protected uint NHKLKDIBPOO;

	protected GameObject ADHLAEENHKC;

	protected ResourceID HIIJDBECIIE;

	protected uint LBLFGFKENFM;

	protected GameObject NMGKMKPNOPP;

	protected GameObject CHHMPNKOOHP;

	protected uint AECCLLOOMOD;

	protected StropRing BHJINKEDKGH;

	protected uint MNEGHCCEOBB;

	protected uint FBLJGGKCFKH;

	protected uint BCKGCOJOEPB;

	protected uint AJOINIPLBHK;

	public GameObject m_CamouflageUniformGO;

	protected GameObject AAMHFGLLGAN;

	protected GameObject GMGNKBGNDNG;

	protected GameObject MABJGIOMKAF;

	protected LevelHayrickOrigin EGGEAACEKIA;

	protected LevelHayrickEnd NKJFDEJMHLP;

	private GameObject NGLCLMKGAPE;

	protected GameObject MAOMFBOJGLH;

	protected ResourceID OADFMGFMMBL;

	protected GameObject OLHABAOLJNK;

	protected ResourceID OMJALHFAGDP;

	protected ResourceID DOCGKBNBLBG;

	private Dictionary<int, ResourceID> LCAPHALDGFB;

	private JOHBFACKCJJ _003CLJKMPAPCCLC_003Ek__BackingField;

	private GameObject PIBECPLAILJ;

	private bool IINPJPOGDCL;

	private bool MJCJGOMGPPN;

	private bool KCIFHPCBKJM;

	private bool KHANCEMOAPG;

	private FEMJPMLIKDF KJOPDHLKPML;

	private ResourceID PDLCLHOHKKL;

	private uint AAODCLKPDLD;

	private float DEJMDIIGMCD;

	public bool isInTrainingShootAreaTrigger;

	private OOMGNPFEHMG AKJPIOMCJFK;

	private MGAHNNBLGHN OGGKGKPHJFL;

	private EntityInfo DPNJJLIOBGJ;

	public float LastSmartFireTime;

	public bool IsLastSmartFire;

	public bool m_EnableParachutingOnPlatform;

	private bool OMBDJGFCJHM;

	private uint MLMAJLBIOOK;

	private bool MMOGOADNEAI;

	private Quaternion KCEIAMMBJCH;

	private float LFBHGHNCDGA;

	private const float CHOLCBHJHNL = 35f;

	private const float JCPOHMLADNJ = 135f;

	private float GOGOJJILIBD;

	protected BHGGAEEHJCO GLFKECAMMIF;

	protected bool APCJPGEOOLI;

	public float m_ControlDirectionResetTime;

	public float m_AuxAimResetTime;

	public float m_MinAngleX;

	public float m_MaxAngleX;

	private float EADJNPDFAHE;

	private bool _003CMFDAJNBNCGH_003Ek__BackingField;

	private float LEHMOJBIEBL;

	private GMPGMPFNMFP AKFLHNOIHED;

	private GMPGMPFNMFP PJGMLPMAMGN;

	public bool LastAimingInfoFromWeaponAdjusted;

	private bool KDEPJOHCLFK;

	private bool MIBLFMGKIPM;

	private OKEAMEELLBB _003COHPFIIKIOPJ_003Ek__BackingField;

	private NFDDMKNPIBC KOOMEMLDKAN;

	private Func<Collider, bool> PIIPNDDFGFD;

	private uint ENMEPALGNMJ;

	public float LastPlayBulletTrackEffectTime;

	private ResourceID BAIGMNFPOJL;

	private uint BNJODKIGJBP;

	private uint JBMMGKKFJGF;

	private GameObject KNJFNDFJHHP;

	private uint MEHDCGOEJLJ;

	private GameObject LFOGNFOMCPP;

	private GameObject KECIJHLCADM;

	private GameObject COFJCPBBBDB;

	private GameObject PPFCOGOJBGC;

	private GameObject MONECNANNKA;

	private GameObject CNMJDBIOLKG;

	private GameObject GIOHDPGNGKH;

	private bool KEHIEBOKHNN;

	private ResourceID JFIBOOCEKAM;

	private uint BKNJKNEPOGI;

	private uint ANBOMMANDLC;

	private ResourceID FMMBBGFOPDM;

	private uint GJAGHDIEBLP;

	private uint IMKAGJFHDMA;

	private bool HAGCAHDGCHE;

	private const float NEEFNJAHAAP = 1f;

	private uint HJNJBINCJKN;

	private int IIFJBLEKKKB;

	private ResourceID LNJIKHIOHEI;

	private uint GOEAPLIGCLA;

	private uint LNMHGFLAADD;

	public bool Is3PStopFire_WaitingChangeClipAnim;

	private List<FBBGNEHEECB> BGFALNOEAOL;

	private RuntimeAnimatorController PNEKADMEJEK;

	private float GJACGDAKKBH;

	private bool HLBFACFNPJP;

	private uint OLBFNNHFBEL;

	private float HDHFPNPLCOA;

	private float JADHBPGPFEL;

	private float DMHPOAHKIGO;

	private int IKEBFDFCHNI;

	private float NNPELAIEGCO;

	private float FJCCDMFNFFL;

	private float JLJHPIKGPLM;

	private float HPKIIPCDFNC;

	private float HHCOOGJPNBE;

	private bool BPPOCFPPBOC;

	private bool HCHCAMAIDAE;

	private bool FDPMLLACILB;

	private bool JFEPKJOJKHA;

	private float PLLBBGDHHNC;

	private float HDIKFBOIOLN;

	private bool FBKEEECJMLG;

	public const float IPHONE_DPI = 326f;

	public const float MAX_ROTATION_DELTA = 300f;

	public const float ROTATION_EXPONENT = 3f;

	public bool EnableUserControl;

	public float m_LastPlayFallingLandTime;

	private float DAENIFCEPPB;

	protected LevelItemPlant LHCIGGGGEJI;

	public float NBEatNoodleStartTime;

	public float SeafoodEatCookieStartTime;

	public float EatInfiniteCakeStartTime;

	public float ActionWinterLandDeerStartTime;

	private LinkedList<Vector2> BEIMLGLBCGF;

	private bool _003CMJIOKANKIOF_003Ek__BackingField;

	private Quaternion JGGGJCEFGAC;

	private bool MPMJJBNMJJD;

	protected GameObject GHGEDHEOLMB;

	protected ResourceID PCGAPJLDLFN;

	private List<Vector3> ABDCKIEKAMJ;

	private bool _003CIMNFGPMKODK_003Ek__BackingField;

	private bool _003CLPKEBCILMLP_003Ek__BackingField;

	private float _003CDCPOJGJBMJG_003Ek__BackingField;

	private float _003CKBNKPLIJPNK_003Ek__BackingField;

	private ResourceID HNJIBFFABPK;

	private uint OHHABAFLLIM;

	private uint LLDLPJEJLGK;

	private ResourceID LFICLAEPMIF;

	private uint AHLBFFJMIJA;

	private bool OFJNBODLJFL;

	private bool CMGECDDIPON;

	private GameObject GAIGGFDFCHH;

	private uint PMKHPIAKLFE;

	private ResourceID EHJMCLPKLAE;

	private CheckBoxCrossHairTrigger OAAICLMBBJK;

	protected List<GameObject> MBEBINFPKLD;

	private int DJAPBGPMEPO;

	private bool _003CMLGFDMNHCHF_003Ek__BackingField;

	private int CEDPNHFNBMP;

	protected bool FPNELCIACHL;

	private ResourceID OJDGACBMBOO;

	private bool CGPIDALCFBP;

	private float LFDLALNMHLN;

	private uint OIBMCKIAJNO;

	private ResourceID KOJLFIABHKB;

	private uint BAMGAHKKDAK;

	private uint LILMFEEALGI;

	private Quaternion ADAEMJIGKEH;

	protected PCBOIABIHPD KGONGEHFGKM;

	private bool CBDILCOHEDJ;

	private float GCAKJMDOLHD;

	private Vector2 ODAPLIEKLIP;

	private bool CMPNHPOIONB;

	private float ADNHIPKGEFM;

	private Vector2 KDICKCBCEJK;

	private bool CMGLKPADDLP;

	private PCAirTrailView GHBCMLAFLNP;

	private LevelEmote IADABBALOLL;

	private ResourceID ELJOIJOMLKF;

	private GameObject GJFNNCFJLGL;

	private LazyDictionary<uint, Vector3> HBANAEIFOPO;

	private Vector3 IEDECODPLBC;

	private Dictionary<GameObject, Transform> HAMFODBNJBK;

	private const uint PFBKIKKAIPG = 2u;

	private uint LFCALKIGJDJ;

	private GameObject HFPMCIPKHFI;

	private uint JCFBGMCBDBB;

	private uint LGANOILOEKP;

	private float BDFMFFJLHNI;

	private uint JAJCIIACEAL;

	protected BitArrayBoolean GBGLFNMBFKE;

	protected AvatarTrace BKBFGNCJJOE;

	private bool _003CBBBOMIGBAOO_003Ek__BackingField;

	public const uint ISOUTLINEVISIBLE_LOCALPLAYER_ALIVE = 1u;

	public const uint ISOUTLINEVISIBLE_SKILL_TRANSFORM = 2u;

	public const uint ISOUTLINEVISIBLE_SKILL_AuroraBoy3P = 4u;

	public const uint ISOUTLINEVISIBLE_3P_ALIVE = 8u;

	public const uint ISOUTLINEVISIBLE_STEALTH = 16u;

	private string OLCGLJCCPPL;

	private HELBFMHHPBI FHNIGJCEFMP;

	private int? OJPDMHKPPGO;

	private float OBOPAFIBECA;

	private float PBFFEJHEIHO;

	private bool GBBKMINJEJB;

	private List<uint> CJHBKNOIJFL;

	private GameObject NMOLCMIGKCM;

	private GameObject KNMPJFMDNEF;

	public float LastLockFireFinishTime;

	public const float LockFireFinishContinueShootInterval = 0.1f;

	public float LastInvincibleOverTime;

	private float KDLPJOBMKNP;

	private float HFGLCGEFLME;

	private float GIIDPBLEHJN;

	private float DBLJCDFPGLN;

	private float PJGOAIPJNAL;

	private bool KBCNHLIILJI;

	private List<float> NIDGEMBOCMP;

	private uint BMHGHPDMCND;

	private uint FJBOECGPNAJ;

	public bool IsAtPartyGameSoloDanceBattleField;

	public bool IsPartyGameSoloDancePreparing;

	public bool IsPartyGameSoloDanceBattling;

	public const int UGCAnimationClipType_Fist = 0;

	public const int UGCAnimationClipType_Pistol = 1;

	public const int UGCAnimationClipType_Gun = 2;

	private Dictionary<string, AnimationClip> EJMAJMJPEIE;

	private Dictionary<string, AnimationClip> EEFALPLINJK;

	private Dictionary<string, AnimationClip> HBDIONENPGJ;

	private int DHDIHBOMFHJ;

	private Dictionary<string, AnimationClip> FPCIIGIBIHI;

	public static Dictionary<byte, string> FallingActionCollectionType2Suffix;

	private GameObject DEMEMMJCKJC;

	private ResourceID JDLKDGPKDFK;

	private AudioResource AGKIGHOMAOC;

	private int OIGBAPJFNPE;

	private int IMEKHELFEMO;

	private Dictionary<int, uint> EADJJPCAKCH;

	private EntityVisualEffectManager HJCIADKBDMF;

	public VisualEffectLoadMethod m_LoadMode;

	private string INPCPDAFMCN;

	private string IOEMGDBBNNF;

	protected JALFABPGLNE ALLGFKKELJE;

	private uint DKGOOHGGJFA;

	protected uint ENKENNJALMO;

	private uint CGAJPAOIKPC;

	private bool GFICBJKGHJD;

	private uint DPJIPEEMPAG;

	protected Dictionary<byte, uint> INJFBFEHIEI;

	protected List<NCHOOLJCDNM> GPFGINIDGGE;

	private const int GMJBGDOMAIM = 20;

	public BDFFBCKEGHL ActSkillUpdateKinmaticsCall;

	protected EBMMLGGDMCC BOHCGAKLIFC;

	private bool _003CDFDGENGHFOL_003Ek__BackingField;

	private bool _003CMNAEDJOFLPK_003Ek__BackingField;

	private bool _003CEDJBPOJJMHG_003Ek__BackingField;

	private bool _003CPEJEAEHLGEK_003Ek__BackingField;

	private bool _003CMMCLMKJFALJ_003Ek__BackingField;

	private VisualInstanceHolder PFLHKJMLNNM;

	public bool IsKnockedDownBleed;

	public bool IsKnockDownBleedingFromGS;

	private GameObject CPHEAFLMJHI;

	private ResourceID DDPPAOBHMJG;

	private GameObject OEHLIEIALGK;

	private ResourceID NAACLPMODNC;

	private PLAMDOMBAON JONOLCHJCJH;

	private bool FODJDNOOABB;

	public GameObject m_TransformObject;

	private MeshRenderer[] KCCLPGLOCAP;

	private string FMODGJDBKMP;

	private Dictionary<int, HELBFMHHPBI> HEFJMEJNCLG;

	private int? BMAFKAGAGAH;

	private Dictionary<int, int> ALMAIKIIEIF;

	public NBSkillTransformAnimCtrl m_NBTransformAnimator;

	public GBGPFootballAnimatorController m_GBGPTransformAnimator;

	protected List<HBLKLJHFJDK> CHNODEHEHAG;

	protected bool HFPFMIEKOKL;

	protected GameObject ODEGIGIGPKL;

	private bool FCMKCDHHKIA;

	public uint LevelSantinoDummyID;

	private ResourceID MAHECPJOFFO;

	private uint DMBICKNLEFK;

	private uint BJOEBPJPLOC;

	public ResourceID PlayerSkillBlowUpIceWallExplorEffect;

	private Transform IOKFMFFIJJN;

	private CameraAnimationManager CFACDOEJAEF;

	public int ReleaseActiveSkillHudToFireIndex;

	private LazyDictionary<int, ALAICHHNNEN> OMCNOOJCHND;

	private int MABFBFIKFPF;

	private bool BCHFKILOMHF;

	private bool BNMJCBMKONB;

	private bool PMJKCDCHLIG;

	private bool AIMAMMLOLNC;

	private bool EFOLKAMLPNF;

	private bool BHMGPFNJAML;

	private bool LBNJJEFKOKN;

	private bool NLHEJMJEGHF;

	private int NDFNNJHBMCG;

	private int KMMECHEOLFA;

	private SkinnedMeshRenderer[] JMMPGBFEMFI;

	private CAIDKDGENGJ GNIGNHDOPBC;

	private bool HJBIEGJMLBH;

	private static List<int> LBJGEPBIALB;

	private bool _003COGIFAIJFPOA_003Ek__BackingField;

	private GDIEANOJNGP ACLMFBKOEBI;

	private OIBKLAKMFOL JPOOGNJNEDP;

	public static float SkateBoardHalfLen;

	private bool MJPHHGHDHDG;

	private int MDIJHAADIFP;

	private bool PCDCEFMAACA;

	private uint NABODKEKKFD;

	private HashSet<ArcGenerator> BPFDMLEHJNN;

	private Dictionary<int, HashSet<Collider>> AGPNOKNHKMD;

	private ArcGenerator DGKAJDGCAOG;

	private BezierSlide BOLKAGBPMPK;

	private float MIKAOJAGNAJ;

	private ArcGenerator AAMHLECNNJN;

	private BezierSlide OCPILFGKBBB;

	private float LDDAPNFDLOF;

	private POECFMGBOLN PICEFFLBAFA;

	private Vector3 PJLAKCGKNNA;

	private Vector3 _003CFKBGFFMOIFO_003Ek__BackingField;

	private Vector3 _003CEJOKHAMLBMD_003Ek__BackingField;

	private Vector3 MLAMHDCGOLO;

	private bool _003CGEPGJFEDCBH_003Ek__BackingField;

	private Vector3 AKNLMEHOIJB;

	private float MAIKIPJEOJB;

	private float FFCGAOIPNEO;

	private float EPLKFDGGHMN;

	private Vector3 JJCPOJLAHJO;

	private float KNPOFGJDFPC;

	private uint ADIBONLCHNF;

	private EKOFDDAKHEB HBGCMGPKHJP;

	private Dictionary<ResourceID, uint> KDMBGKMHPDB;

	private uint EILMHEKLADO;

	private GameObject FDGEOJGLPOF;

	protected OHHNNBCNBCK FGHELCIHKBL;

	private OOENFLIJDAE HMCDJJBDDJB;

	private readonly AudioPlaybackParams_Unity CCENIKPBPHG;

	private uint LOKFENLADEG;

	private uint BEEHDBENLBD;

	private uint BFLNKOFBELL;

	private uint NFFGHBJHIOH;

	private AudioSource BAOKIEPKJPG;

	protected uint APBPPGFKOLI;

	protected uint LFLDILBBKMJ;

	private uint BMOGNADBENA;

	private static bool DIJIIMFMLLG;

	private uint CDOPKKJNHEF;

	private uint AIFJNKJJNAO;

	private uint BIEGPAMCIEG;

	private uint BEHEDAILODL;

	private OIGABALKKOF INHPEOCAFOL;

	private Vector3 BODCBFKGDIL;

	private List<AutoTagClassificationData> IGJKKEHIMNN;

	private bool AIBAKFDMJME;

	private uint BPBELLCPDEA;

	private AvatarTransformer HPPEICECOKN;

	private bool OMNPIHMAIAG;

	private uint HBKEOPAGFOE;

	private EAvatarModelIngameType IIJDBNMFKHG;

	private uint _003CFGHLLELGCOO_003Ek__BackingField;

	private ResourceID NKKEHIBNDPA;

	private AnimationRuntimeHandle GBOABFCHOGK;

	private PlayerBigHeadPreHangUpdater OLBKKGPHAMO;

	private uint AOLMJNPHLBJ;

	protected uint HHOGMMDGADK;

	private uint PLNEMDBBHOA;

	private uint AGKBEIOHCBI;

	private float DFBMGKJEBHE;

	private float EFMDANMCKCA;

	private List<Vector3> NIBAELMFCGF;

	private float OJIMCNAKGMB;

	private float FNMNPHHPDDG;

	private Vector3 LNFJDADBFLO;

	private float LBPBMKDILMH;

	private uint FOOFCHPEEFM;

	private Action<int> AAHPHJDGMBC;

	private Coroutine BDHHGAKHKOK;

	private uint CFNJOIMJPFE;

	private Coroutine JGMKPAKKEJD;

	protected HPCNMOKAGAK FADFIGOCKEH;

	private PVEEnergyBallManager _003CNJHOMDPEEHA_003Ek__BackingField;

	private Dictionary<uint, ANJGLPLLHAN> HBFGHBMBJGI;

	private ObjectPool<FLFADFKGIHB> EJKBLNIOKEC;

	private List<uint> JDDNPPGCKEI;

	private List<uint> ILPMMCDLKGA;

	private uint FNHAMNJJEJK;

	private uint GKPOGCKFNKP;

	private LazyDictionary<uint, uint> LLJKDAGMBGH;

	public SafeReference<uint> EnableShowAirdropWeaponMark;

	public bool TempHideAirdropWeaponMarkOnBeHit;

	public float AirdropWeaponMarkMaxDistance;

	public SafeReference<uint> AirdropCaptureSpeedUp;

	public SafeReference<uint> EnableRevivePointStore;

	public int RevivePointStoreItemId;

	public SafeReference<uint> BuffDelayDestroyLoadoutScanner;

	public SafeReference<uint> BuffUpgradeTacticShop;

	private Player FJCEFPDCKED;

	private Player BEOOHBDJBEE;

	private GameObject LJFPONEFHEA;

	private ShoulderRideBattleAnimSync HGCAELCEKJP;

	private uint PPNPAPCOJFF;

	private uint KOALIFJFAIA;

	private const float PMFDKKNIIBG = 0.1f;

	private bool ADGJPPBDMKC;

	private PNDBOOADDEJ EHHOAKEHOPK;

	private List<uint> OODBLNKDPHJ;

	private Vector3 JOGCDEMDNMB;

	private Vector3 GNBNHHEHEEH;

	private bool EALLKCNHHBD;

	private float HIJIAMDIIPB;

	private bool GFMMKCIHJIH;

	private const float ABILOBNDFPA = 180f;

	private float GEJHLJMGHIL;

	private float ENCBGNOMKPC;

	private float LLOHFKHBCAN;

	private float NKELJJCBDKP;

	private float IJDMHEHDMJK;

	private float FGBLFHIHBGH;

	private float NBDGNONGAGP;

	private float HDDHJCPNJFF;

	private Vector3 MEIMEGFIAFM;

	private ClimbingTrigger LOENOBGLIJP;

	private Vector3 FNOFKEIKOIL;

	private float BOCLIPILLJH;

	private bool LHODFCFHFLM;

	private float GNHKCCCLENM;

	private float AEHNPNLAKBE;

	private List<Collider> MBCJBNIAFLG;

	private Quaternion CCCBMHBKMAJ;

	private Quaternion IBOLGNFOAOC;

	private Quaternion JPKJHHKIOBK;

	private Quaternion ABFKPNFIBGN;

	private ClimbingTrigger LFIAHFEEIAP;

	private const float HBDLIBDAPJA = 0.11f;

	private Dictionary<BHGGAEEHJCO, BKIDLEFNNJA> OLHNHFEKGPP;

	private List<uint> HCPEEDFGFDD;

	private static Dictionary<BHGGAEEHJCO, AKCKCJHBEKD> EODFDCADIFO;

	public float minAngleInCreep;

	public float maxAngleInCreep;

	private GMPGMPFNMFP CCMNEJMBKPA;

	private bool? MNOFOJCCFAO;

	private float OONLFFAFPBP;

	private float KKEKPEKPCMN;

	protected GameObject POEFBABFJKD;

	protected GameObject[] IANFLBGIMBL;

	protected MABCLDLDMJO JLCCCFFOIHF;

	public bool IsDoubleJumpTriggered;

	public float ResetSecondJumpRushTime;

	protected GameObject DBOBBNLBIDJ;

	protected GameObject EJDILGLOPBH;

	protected FMDLJGLHAAN KAPLFNOGAAM;

	private List<uint> AMEMFMCOCGJ;

	private HashSet<uint> MDOGFOBJGMP;

	private LazyDictionary<uint, uint> GGCHLDELPAG;

	private byte _003CFCPGHKAEHOL_003Ek__BackingField;

	private bool _003CMOGCOJAGOHF_003Ek__BackingField;

	private float JOKEKDFKKOA;

	private uint OHHIOHAAJPP;

	private DuoEmoteInviteCollider HGFEMLHKLEG;

	private CooperateEmoteCollider MMJPLKBFIBL;

	public BHGGAEEHJCO DuoPlayerId;

	public bool ResetCabinWaitingFlagForPlayDuoEmote;

	public EmoteExtralInfo EmoteExtralInfo;

	public LazyDictionary<BHGGAEEHJCO, int> CooperateEmoteServantPlayerInfo;

	public int CooperateEmoteSeat;

	public BHGGAEEHJCO CooperateEmoteLeadPlayerID;

	public bool ResetCabinWaitingFlagForPlayCooperateEmote;

	private Action<bool> _003CGMAGPEHDFCJ_003Ek__BackingField;

	private uint _003CIPPLENJBGOJ_003Ek__BackingField;

	private uint NFKAGPCCOIE;

	private GameObject KNOHDFBLLDB;

	private CameraAnimationManager EEOHEMDKDON;

	private ResourceID MBCMJNLNGLE;

	private bool NNMBMLDNFAO;

	protected uint APBGIHLCJBI;

	protected uint OCAJNMINACF;

	protected JKBHKINACEN GKPIPKLLGLL;

	protected LIAFPDJNAPH CLNHNBGDPMC;

	protected bool EKIIADPIFNG;

	protected FDAEPHMIEPC GFKMKMIPOPI;

	protected ResourceID HEAMEEOFLKN;

	protected uint FOHKNAAAAPK;

	protected ResourceID NHMEGHOICFM;

	protected bool PCMFCEOLMPK;

	protected bool GHKKJLBBCMM;

	protected GameObject LDEIEFPIPOL;

	protected GameObject IKDNDOOAJEN;

	protected LIAFPDJNAPH HJLCKFLOKFI;

	protected bool GLAJDLDELNP;

	private uint FOJFLCIMFGJ;

	private float GPFMGPNNOLJ;

	public bool IsPlayExecutorCamera;

	public float LastFireBtnDownTime;

	public const uint FISTWEAPONID = 1u;

	private GMPGMPFNMFP AJEFPDDLNHC;

	protected Player EHINEGEMKMI;

	private Transform EMOGFPJHAEC;

	private CameraAnimationManager HLLOFAHNEIO;

	private uint CBFKLKLHKGB;

	private bool _003CLKOIPBHIGEN_003Ek__BackingField;

	private bool _003CKMGAGINCHHC_003Ek__BackingField;

	private float MBIKJPHIDGJ;

	protected Vector3 FMKHEOLALNG;

	protected NAGDAGNPFPD CPMHMPLPHLM;

	private bool MGNMONGIGAC;

	private GameObject LMBODNADECF;

	private bool BAPIKADLIDK;

	private byte MGCLOMGDFIK;

	private bool FOMPEDMLBHA;

	private int DFMHIJOGBNM;

	private ResourceID MJLILBMMJGD;

	protected JDFJDBOFKPM ANOABFLINNF;

	public float StartGlideTime;

	private FoldWingConfigData JDHOKDNGJIK;

	public GameObject m_FoldWingIAmIn;

	private bool PMOFFAGLKJC;

	private BHGGAEEHJCO HCEHFAACOMJ;

	private BHGGAEEHJCO FKIGAFIDGBP;

	private IHACOKBPJEM HHMIPNCNHEC;

	private bool CGGEMJFHPBN;

	private bool AKFDLHHJKMK;

	private bool CJFLCCMOBLN;

	private uint MFFCJKNJJJB;

	private Vector3 GOGGAAPIJEC;

	private int MMCGKFCOBIC;

	private uint BJMHJLMLGNL;

	private FollowMoveEmoteTrigger GMFPJJKEJBP;

	private bool EIIILINPIFD;

	private bool HKNNBCHKNCG;

	private bool MPEFFGELLOI;

	private uint CPHODOOEKCO;

	private const uint DJPFCEODDIM = 909999002u;

	protected float FNGNIAFNEBD;

	protected GameObject KOEHPENCEPF;

	protected SphereCollider NAIFBFJHGGA;

	protected Football FEBOFEJFJLF;

	protected FootballHitTrigger ODHKPBLHEFD;

	public Vector3 m_FootballHitVelocity;

	protected float PJJCMBPCDGO;

	protected bool MBEBBHNJMML;

	public static readonly float FOOTBALL_MOVE_EPSILON;

	protected Vector3 DOIKLMODMKG;

	protected GameObject FALCNLBNLEI;

	protected AudioSource GNDNJGHBMEK;

	private UIHudChatBoxController GIGLKPFMHGD;

	private GameObject AFAENMDDIPG;

	private GameObject OAMOBIPLODL;

	private VisualInstanceHolder LNIJEJIIPDJ;

	private VisualInstanceHolder NAHJEAGFLIM;

	private static readonly Dictionary<string, int> AEAMEBPCKBK;

	private readonly StackDictionary<int, int> MLJPPBDFKNB;

	public static ResourceID[] FPP_Male_Low_HP_Sound_Array;

	public static ResourceID[] FPP_Female_Low_HP_Sound_Array;

	public static ResourceID[] FPP_Male_Recover_Hp_Sound_Array;

	public static ResourceID[] FPP_Female_Recover_Hp_Sound_Array;

	public float m_FPPLastPlayRecoverSoundTime;

	public float m_FPPLastPlayLowHpSoundTime;

	public GameObject m_FPPLastRecoverSound;

	public GameObject m_FPPLastLowHpSound;

	private TransformNode EFCEMBDAKFL;

	private float MKPACMJHDML;

	private float JGBPPNNIJLM;

	private Player_FPPModel GKIDDPFOFIO;

	private GameObject MINMFPPBPJE;

	private bool CPLCHADCGPB;

	private TransformNode KPALHBKBHLE;

	private Vector3 HDBCPFBPEGC;

	private Vector3 MCLHDFIOCAE;

	private Vector3 FIOMIEPOCDL;

	private ResourceID CPLCGGBFDDL;

	private uint OIPPNFBBONB;

	private uint KFHKDLEFIFL;

	private Vector3 HHFHHOCFGEA;

	private uint OEAEMICDFMO;

	private uint BMAMBBGEECM;

	private const float FEKBHMPHIIP = 1.5f;

	private Quaternion LDBICDHLNGM;

	public Quaternion m_CurrentAimRotation;

	private Quaternion DDHBCHGPKIC;

	private float BOHJCNHPOII;

	private float IPBHLDPHPID;

	private Quaternion HJJONMOCMFI;

	private Quaternion CNCHCIHCHHJ;

	private Quaternion BILANNIIPDE;

	private Quaternion KLIEIIJIPKK;

	private float PFKNANMENGO;

	private float NNHEGOKNIBH;

	private float HCPALEBCHBO;

	private float KFBALHENADL;

	private bool FGAINDPMCKD;

	private bool JEJCNFHGKNG;

	private bool GECHIJBLBPB;

	private float LACJJJHJPFD;

	private Vector3 OHIHKOENJLN;

	private float IODEJFEPCPN;

	private bool FKLJINJOHKL;

	private bool AKIGLMJKGLO;

	private bool DOBNICCHINM;

	private bool PPAPPEBLGDA;

	private bool NMIMLECMGEG;

	private bool MDKOPEHEBAD;

	protected bool FAMEPCFJHJP;

	protected uint PLBGPGBOIPM;

	private LevelDWShield _003CHLJAFEEIMKE_003Ek__BackingField;

	private float PNLIFEGGCHH;

	private int HOAIACCBAPC;

	private float CFJAOEKBFAP;

	private bool NHGMKAMOAKJ;

	private uint JDFLNDOCMKK;

	private uint JLBAIMJOAAG;

	private uint KOGJPMBLHOE;

	private float CPODABOJJED;

	private int JFGFJIFAANK;

	private int NINGKGDAECF;

	private uint HPEGIBPJDCM;

	private float PLAAIGGOBDO;

	private float JGBIBIJHDJA;

	protected Vector3 INFPEBKKNFB;

	private ResourceID MKJCOGCEIHH;

	protected BMEBLEJJGKD HHCDAJOMIOA;

	protected GameObject GCEALOBGJMK;

	private GMPGMPFNMFP FHCDIAEFCEG;

	private JMLMEAMAKEC BEOOHNFDHNG;

	private uint JHHMEICLIHD;

	private JMLMEAMAKEC BBGDDMNPPGC;

	private uint JLDIMAPHNBB;

	private BBNHJFFAAPM LJGOEJBKKLI;

	private bool HAMJJAHINCM;

	private JMLMEAMAKEC BBCKJHLDHFM;

	private uint NCCGOHEBEMI;

	private OBOHAOFFODK MEAMMDLDODK;

	private int FBLBNKHFLON;

	private readonly Dictionary<OBOHAOFFODK, int> CJMBMNMMFHG;

	private bool GHICFKBPFDH;

	private bool HEIAKKKPLJI;

	private byte FKGCAKMAGMF;

	private bool ONGDPECHNMH;

	private bool LEGGLKPNICF;

	private float EGEPIEALLAF;

	private const float IAAJPCHFMCA = 30f;

	private bool ELGNPNMADOF;

	private uint FKPBHKEOKFK;

	private uint BEOOMIHLELJ;

	private uint OMFPJHFINCP;

	private bool GGJIFIPFOMA;

	private bool GNOEMODMBKD;

	private VisualInstanceHolder MJNCHMLLAJC;

	private VisualInstanceHolder GKKPMNNKIKM;

	private bool JGOGKNAKBND;

	private bool EEMBDEDHAMB;

	private bool BDMOJCJBCHM;

	private Player DOOOGGIKHFF;

	private float OJLICMKIGFI;

	private float PHGPLNIAOLF;

	private float MLHJOECLEBK;

	private float GOOCGPGKMLI;

	private bool HEKCCABCDDN;

	private bool NCKOODCAGOI;

	private NBEKMBDMMCE ABPLKFPLPMI;

	private GameObject LPGKBPEJJKF;

	private GameObject FIPNMKKPAFD;

	protected LevelMovePlatform HMLFPLPKFLC;

	protected Vector3 HCKGHMINJHI;

	protected Vector3 JFFMPGFFECC;

	public SafeReference<uint> PersonalShopUpgrade;

	private JMLMEAMAKEC PPOKFLKPDNA;

	private uint FKHBBPEJBBO;

	protected FGAHFBDAKPI IFGAOAHPNOC;

	private bool HPFOIBLFFJP;

	private uint HJJLBIOEFHG;

	private float DLEHCOLMIDO;

	private float GJJEMBHEAAH;

	private float MEPAJPDPIEE;

	private float INCDPDKAGFC;

	private bool KCDKONKGJKP;

	private bool BDFABLFAKEE;

	private float JMGLMIKKEPI;

	private float PEENCLEGMKE;

	private float AJJIIFHPBML;

	private float CMHDNPNLIGD;

	private ControllerColliderHit EDLEEEKFEHC;

	private RaycastHit[] OKEPFMLCHNE;

	public const float GroundDetectionBackDistance = 0.002f;

	public float MinGroundDetectionDistance;

	public Vector3 m_GroundHitNormal;

	public Vector3 m_GroundHitPos;

	public bool m_GroundHitResult;

	private bool _003CFFOGKOEFNBG_003Ek__BackingField;

	private bool _003CNLMBBGILFKN_003Ek__BackingField;

	private bool LJFBGBLMNFL;

	private bool PAEBLCJHNHF;

	private float ICPLGFGKFFJ;

	private const int LIHMKJCPEII = 128;

	private const int GCNLFBEBBFM = 127;

	private const uint PBIPHEALGPF = uint.MaxValue;

	private IEnumerator OGDOPDFJPNJ;

	private byte HPHPADBAHPG;

	protected NMCBIHOOFFF POPKKGFEMLJ;

	private bool EADEMHJJNCG;

	private bool OGIFIMFFBCK;

	private bool _003CCKDLBMNMADM_003Ek__BackingField;

	private uint DAHMOHHDLGJ;

	private uint JHDCGGGFKKD;

	private uint MLFFMICLDAC;

	public float LastHitEffectTime;

	public float LastHealHitEffectTiem;

	private uint IHAHPKGGPCC;

	protected int CNLEDNPJHBB;

	private bool OJPCOFEBAFG;

	private List<uint> BPMFLAJJIHG;

	private ResourceID LDKLCOONEIH;

	private uint PJNFMPDKPLN;

	private byte _003CPAEBIPLCBLI_003Ek__BackingField;

	private uint CDOIFPNLDGF;

	private uint CLGJMCIMKGO;

	private GameObject DBHAAPFPGAF;

	private uint JPKCKIONIHC;

	public byte IIVEggType;

	private bool _003CEELMOILOGMN_003Ek__BackingField;

	private bool CDHJAPCNNLD;

	private int APBJPNDNEAO;

	private Vector3 _003CFBOMPMJHDDN_003Ek__BackingField;

	private Vector3 _003CFLDBJKDJOME_003Ek__BackingField;

	private Vector3 _003CGMGOLJIILOD_003Ek__BackingField;

	private int MIOHDBNNOJD;

	private Material BMKMBKAKKEC;

	public HLIJMCPGMIG DisableJump;

	public HLIJMCPGMIG LockInput;

	public HLIJMCPGMIG LockInput_ExcludeSkillCancel;

	public HLIJMCPGMIG LockInput_ExcludeChangeWeapon;

	public HLIJMCPGMIG LockInput_ExcludeReloadWeapon;

	public HLIJMCPGMIG LockMove;

	public float LockMoveSpeedDecayPerFrame;

	private int GGBPFLLGDMN;

	public HLIJMCPGMIG lockUpdateRotation;

	public HLIJMCPGMIG lockForward;

	public CNGEIDMLDIP lockFire;

	public HLIJMCPGMIG LockAnim;

	public HLIJMCPGMIG ForceMove;

	public HLIJMCPGMIG ForceMoveToForward;

	public HLIJMCPGMIG LockFreeMove;

	public HLIJMCPGMIG LockFastRun;

	public float LockRunSpeed;

	private Dictionary<uint, HLIJMCPGMIG> GFNBFEIGKEI;

	private bool _003COHNMFNCNGAE_003Ek__BackingField;

	public float FlyUPDistance;

	private int BDPFFNBAHMI;

	private float DMFCABOJJHG;

	private uint DOPDKJDCLOC;

	private bool CKLLPKNOBIG;

	private uint IGCEIAFFLAK;

	private bool NOBBDPDOOCJ;

	private int NBGBOHCAEOA;

	private bool AJPBMEKOLLA;

	private bool EDGBODMNBEN;

	private BHGGAEEHJCO JALEPKJKMNI;

	private bool KOLLPAEKGEK;

	private Vector3 GHLKPNIKAPP;

	private uint BIOAOLOHDNN;

	public bool IsSFRoleplayPhantomActive;

	public bool IsSFRoleplaySummonerActive;

	public float SummonerBoxRadius;

	public float SummonerBoxCastingTime;

	public float SummonerNotebookCastingTime;

	public float SummonerEndCastingTime;

	public uint SummonerStartEmotionID;

	public uint SummonerEndEmotionID;

	private int EELPBOOJDPK;

	private bool KMCCEMAFAKE;

	private BHGGAEEHJCO JBDKOGAOCJG;

	private Dictionary<uint, KDHEPHOMCMD> DAKAKJABNCD;

	private Dictionary<uint, OEIKEOFBDMK> EJPIMECGMGL;

	private List<uint> PJCFOOONCAN;

	public const EOGPGNIDOKF SkateboardJumpPose = EOGPGNIDOKF.EPHYSXPOSE_LOWFALLING;

	public const EOGPGNIDOKF SkateboardSecondJumpPose = EOGPGNIDOKF.EPHYSXPOSE_SECONDFALLING;

	private PCBOIABIHPD NPCEMIPOMKM;

	private PCBOIABIHPD BGIEHMHCAKG;

	private PCBOIABIHPD NHCFDKNCHCA;

	private PCBOIABIHPD ICMLPIBNGHB;

	private ResourceID FKMGOACAOIJ;

	private ResourceID LJPLAOICNIP;

	private GameObject CFKDPIEEMHC;

	private GameObject MBGEAJDOGOO;

	private GameObject DMGAKDFPBNG;

	private VisualInstanceHolder FOBIBHHCOPI;

	private bool AGLGCEBODHF;

	private int JAJEDGGINKL;

	protected float OFLLNPNDNPH;

	protected float IKKEAOLEKGC;

	protected ushort LPPNBKGCJFI;

	private float BMMAGHMJDMH;

	protected float DEGGKHHJHNK;

	protected GameObject MFPHNAADCFM;

	protected KIFFPOOEIOF OAILPGHNIPE;

	private float DFFBAEIAPDL;

	private VehicleDriverCameraTarget BFOKMFNHEPK;

	private JJLCALJHHDF _003CBCBABKOFJFI_003Ek__BackingField;

	private static readonly float IACLDPFAFDD;

	private static readonly float FCKINFHDFHC;

	public float SkySurfingTotalDurationForLog;

	public float SkyDivingTotalDurationForLog;

	public uint SkySlidingPressBtnCountForLog;

	public int SkyDivingSwitchPosTimes;

	public bool LogUsedSkyDiving;

	public bool LogUsedJoystickDuringDiving;

	public bool LogIsLeadingJumpOff;

	public EOGPGNIDOKF FlightMonoPose;

	private float OFCJCNOBBBG;

	private float CHEGKAPMLMA;

	private PCBOIABIHPD AFHGNIALNAF;

	public const EOGPGNIDOKF SnowSlideGrabPose = EOGPGNIDOKF.EPHYSXPOSE_SNOWSLIDE_GRAB;

	private const byte GLDFFMECKGL = 15;

	private const int MAFLHJLLDHF = 4;

	private bool _003CLJIHGEHCNND_003Ek__BackingField;

	public OPFKMMKOJAB CurSnowSlideWay;

	public bool InSnowSlideWayDashing;

	public float SnowSlideWayVSpeedRatio;

	public float SnowSlideWayRisingGravity;

	public float SnowSlideWayFallingGravity;

	private bool FCGPDHOEEIP;

	public bool IsInWinterlandIslandCylinder;

	public bool WinterlandIgnoreHighFalling;

	public float WinterlandIslandFallingAutoUseSnowSlideTime;

	private float LCPDKJFFNDM;

	private uint OPHDGNLAPFE;

	public bool m_LastGrabRotateDirLeft;

	public Vector3 m_CurrentRotateDirection;

	private float _003CPKGMFBJNNBD_003Ek__BackingField;

	private float HIJPEDLKIJF;

	private float OANKDCEFJBL;

	private bool _003CHEGEFPDNCNL_003Ek__BackingField;

	public bool Is3PDashBefore;

	protected GameObject MOHPHLAKLNL;

	private uint IEBKKNFBBHL;

	private uint DPIMOONKLPH;

	private uint NEDFOBGECPA;

	private VisualInstanceHolder MALPHMDPAME;

	private float EHFHICAMBBN;

	private Vector3 PADCBMPGPNA;

	private const float BBFJPENCPHF = 0.5f;

	private const float JBFGJBDCJDA = 1f;

	private const float BBABJAMAPFK = 0.8f;

	private uint AONBPCMHLAJ;

	private uint FMBPPFLFCIO;

	private uint ONJOCEPOHEO;

	private uint GKEGLGFAIJJ;

	private uint GOCEOBBMFBA;

	private uint NMEHLNHDOFL;

	private uint BANEJLKEMFM;

	private uint GGGHFKOFDJL;

	private uint HLONDMCKICI;

	private PlayerSocialLobbyDeformPreHangUpdater PCEMDNFPOJJ;

	private VisualInstanceHolder EPBMBHBOHLJ;

	private bool IPLADMKNJCN;

	private Vector3 NDAJIPKPPPD;

	protected ITransformNode KGGFALBLAKO;

	protected ITransformNode PFHOPOCMGEJ;

	protected ITransformNode NAMNOKIKAGE;

	protected ITransformNode KALAHHFBDFG;

	protected ITransformNode BBBKPGEIJCL;

	protected ITransformNode EBBONNMGKGN;

	protected ITransformNode CMHELMEBNGE;

	protected ITransformNode PMNKBLNHLNG;

	protected ITransformNode FDAAIBEKHBD;

	private Transform JDDFPFLJCNI;

	private Quaternion HAMCMJMHFDE;

	private float EGIMJDDAKPC;

	private float ILBNOBKMDCN;

	protected IEHEBKEFFCC HBGCBEBNDAD;

	public bool IsDieingOnParachute;

	private EFBIHIABNJM DNDBMFOMHPO;

	protected ArrayMap<BGDMAEFKAFK> LCODCOKCLKE;

	private bool JAIKDKMBEJN;

	private float OBIOCBOOOCD;

	private static string LFJOCCFCNBO;

	private static Shader PEDJNBJFHDH;

	private static Color GOIPLNOLAMO;

	private static Color ELEDCHIEJEJ;

	private static Color FMAGLPBCEKB;

	private static Color IOAKMDJDCNG;

	private static Color GCKOGADPOHD;

	private static Color FPIMOLENANL;

	private static Color GOIPAJFJFCJ;

	private static readonly HELBFMHHPBI KKNIABBEGGC;

	private List<uint> AHBLBNGNKKL;

	private HELBFMHHPBI LHEAOKEGAPP;

	protected Dictionary<uint, FJICOMELIAG> LAAFBDAMHAN;

	private Vector4 BCFMDHDAJCN;

	private int IEEEGDBFKBM;

	private int CGFELFPPAJC;

	private int DMKIAIIMPBA;

	private int ENGKDGDDLFG;

	private int GNGEANJOJJD;

	private bool MEALAEKNJHN;

	private bool OIELOMPMBKA;

	private List<StealthRendererHandler> LJFGOPLACCJ;

	private SuperEmoteCameraAnimationManager HMDHPEHIOEJ;

	private GameObject FJIJCEGHEPO;

	private SuperEmoteCollider FFNOCPEKEGB;

	private uint FLJDOJMCECI;

	private uint PKECDJKABDO;

	private HashSet<uint> HPNDMFKFDJN;

	private CFNMNNLAKNO ODMHIBMONJE;

	private GameObject OHFLGNGBKNC;

	private ResourceID FPPJBHCFGPI;

	private GameObject KLPKJLOPHDA;

	private uint MNFHJJMIDBN;

	private ResourceID MDOEPLBJMDA;

	public bool ResetCabinWaitingFlagForPlaySuperEmote;

	public bool LocalPlayerWaitingAsyncSuperEmote;

	private uint LNOPADOCLFE;

	public bool BlockUserMoveControl;

	public bool IsCreepClearSuperEmote;

	private uint _003CHMHHLDCFFPM_003Ek__BackingField;

	private RuntimeAnimatorController LMIINKPJEDB;

	private BHGGAEEHJCO DPNBHECCGPD;

	protected uint CCDNIAJBBBK;

	protected uint PBBHAKCGAON;

	protected int JAJFFBOMNHP;

	protected byte PKDGGCBHNHH;

	private uint OKMJCKPHNPI;

	private uint PNMJFNFLAEM;

	private bool MFFFBHAEMAE;

	private bool DKEBFGEEFBA;

	private bool AOCIGNKEEDN;

	private bool PGKMIJHOOEB;

	private bool CIGBACJKLMM;

	private Vector3 KEEBDHMPPEM;

	private byte GFJDBBMOMFC;

	private CCIPIBCIIDA FDLFKIELDIA;

	private Vector3 IIHLHCOBKAA;

	private bool BPHHNAGAFOO;

	public bool IsResetTeamFlightAnim;

	private bool OIBEDHJIFJK;

	public ACDGKAEOMGJ m_TeamParachuteCallBack;

	public OAKGCHJHDDJ m_OnPlayerPhysxStateSwtich;

	public ECAABJEOKPM m_OnLeaderWantChangeTransfom;

	private bool AAIGMABKINF;

	private float JCLNFNPAKGA;

	private bool OABNMHBIFKL;

	private bool PDNEBCGOBAB;

	private bool ONCIIMBPCAK;

	private UIHudTokenGunProgressController MAJCFPGGBJE;

	private ResourceID DPKKBPCKFLM;

	protected JECKDOPHBBJ NLLMGEPPDNA;

	protected Collider IGOLCJINKHF;

	private float GBPBGBIMFIE;

	private float KODMJLABKFI;

	private int HGCCJDFHFJB;

	private GMPGMPFNMFP FBPPMDDKGGN;

	private EGDEHGCIILC PKPHBFKJGIO;

	private GameObject LFOOJOMODPJ;

	private bool JFELEBLCIFD;

	private float _003CLMLJANDJJLD_003Ek__BackingField;

	private uint _003CGIKHGJHAFIO_003Ek__BackingField;

	private uint DDCMKNJPCND;

	private uint JONHOBLGOIG;

	public bool IsWaitAstrolTeleport;

	private Coroutine FGDEGHGEPEH;

	private uint LFFPCPBNLHC;

	private UGCCustomPlayer _003CIPNPKIOMPDO_003Ek__BackingField;

	protected bool AODHAEPDKPE;

	private bool _003CMMDPCKHGLEB_003Ek__BackingField;

	private bool _003COAIPCFCAGKF_003Ek__BackingField;

	private bool _003CCDCDCODONGL_003Ek__BackingField;

	private bool _003CHOMJGECHCNE_003Ek__BackingField;

	private bool _003CBJJPOMFKBCO_003Ek__BackingField;

	private bool JPDHIOJBEIL;

	protected bool GOHIENOAEJH;

	private GMIEHNAILKF JIEPANMAGMC;

	private UGCPlayerBridge _003CHEAFBFJAODI_003Ek__BackingField;

	private const int GNGLAIPJIHH = 2;

	private const int BHKFIAPNJCD = 64;

	private Dictionary<string, int> ICPJBKOPJJB;

	private HashSet<string> LMLIBPJNGHD;

	private List<string> LNKNMLMNNBA;

	private Collider[] GBAFHGNCGCI;

	private object[] EHAKLCJJLJE;

	private HBFMLLIAPAK LNJEEKCIHNO;

	private Dictionary<uint, ICFILIBHMAJ> MKGNCMEOKPG;

	private Dictionary<uint, float> PMCOCGNCCDN;

	private Dictionary<uint, float> HBALKHAOOKL;

	private GMPGMPFNMFP DOMABMJBJLN;

	private LPDBCAOACKJ LEFICLAAPGN;

	private Dictionary<uint, uint> DHDNEPJDOEO;

	private Dictionary<uint, uint> IDNNPOHKPHE;

	private HashSet<uint> _003CCHJFCEPJHOE_003Ek__BackingField;

	private int LIMAPONLIOF;

	private Dictionary<uint, HashSet<uint>> JKAPDBCENDJ;

	private static HashSet<uint> CMJBKMBLIBL;

	private readonly LazyDictionary<int, Color> ADLMKCFAOCO;

	private readonly string GEJIBFEPDPB;

	private HELBFMHHPBI GHOCIMNJGHN;

	public readonly int CfgDonotSortCnt;

	private readonly uint EAFCMHEEIHE;

	private BitArrayBoolean BCLOGJDLFOF;

	private LPMLOHBLCCG MOABIJKJNGH;

	private bool GLAOHNFDFCN;

	public bool IsClientSkillCharging;

	public bool IsPlayingSkillAnim;

	private LevelScout CCPDBGIPDMA;

	private LevelScout.FGAHFBDAKPI JCKOAFKOMMN;

	public Comparison<MANLOOMKLOD> LIGEMOEBAHF => null;

	private List<MANLOOMKLOD> ALKCMPPHACC => null;

	private List<MANLOOMKLOD> AGNOPBCGKOO => null;

	private List<MANLOOMKLOD> LIBOHBKJJGL => null;

	public Comparison<IHJIKFAEDCM> HDNHEPMMHNJ => null;

	private List<IHJIKFAEDCM> MAGAMEOPFNP => null;

	private bool OMBADHPLKAG
	{
		set
		{
		}
	}

	public bool DCCPOACDHFP
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool MAHIADLDMAK
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool HCACFPGBPBF
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Vector3 PFHLGDFJNNA
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public float FPBOGHCPAOK => 0f;

	public Player JLGJMJEKCBL => null;

	public Vector3 CGKMFOHKOIK => default(Vector3);

	public bool IAGFFCJNFMG
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public PhysicalCCT IHAAHDPHAEO
	{
		get
		{
			return null;
		}
		protected set
		{
		}
	}

	public bool PFKGIELGNML
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	public AOOCPENNMGL ICEDJJOHAAP
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Vector3 MPJGJLLODFD => default(Vector3);

	public bool HBCMAGDGJKA
	{
		get
		{
			return false;
		}
		protected set
		{
		}
	}

	public float GHADKEDCDGO
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public DMBLHAPEMPA EKHDEPBBOAC
	{
		get
		{
			return DMBLHAPEMPA.EPlayerTeamGatherPointState_None;
		}
		set
		{
		}
	}

	public bool NPHPJKIBHOG
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool DOKKIDDIDHO
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public List<FLFADFKGIHB> FFPNCHKCBAF => null;

	public bool HKMCHHHJFEJ
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public JJCDFCNHPID HOAINOAAEIP => null;

	public float CLHOFPIGODJ
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public MPICPIKELNP ONBLPNODOKD
	{
		get
		{
			return MPICPIKELNP.None;
		}
		set
		{
		}
	}

	public CommonMeshEffect PHIJJHIBNJE
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public float CKNDMJFDCMP
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public ulong GFMLMAIJJMN
	{
		get
		{
			return 0uL;
		}
		protected set
		{
		}
	}

	public BHGGAEEHJCO BHGGAEEHJCO
	{
		get
		{
			return default(BHGGAEEHJCO);
		}
		protected set
		{
		}
	}

	public ulong EPGJGJHEEMF
	{
		get
		{
			return 0uL;
		}
		protected set
		{
		}
	}

	public ulong NJKFNJCEIEJ => 0uL;

	public int EBPGIBLHIOP
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public BHGGAEEHJCO ADGMEHMAMJD
	{
		get
		{
			return default(BHGGAEEHJCO);
		}
		protected set
		{
		}
	}

	public uint NAFJGADCFIC
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public string FANBIAFFLLL
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string PFKIHCGDLFB
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public uint BBKGJMHNDAP
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public uint PIEJEPOHHNP
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public object FIKBOIEAMOK
	{
		get
		{
			return null;
		}
		protected set
		{
		}
	}

	public string CGJONMHGBPG
	{
		get
		{
			return null;
		}
		protected set
		{
		}
	}

	public string CDKOCNBEABK => null;

	public bool GMOCIBJIMBI
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public ulong JIFELFFPHBI
	{
		get
		{
			return 0uL;
		}
		protected set
		{
		}
	}

	public uint DPHCAEAJGCA
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public List<AvatarSkillData> BCOJLFMEJLE => null;

	public bool APKCLNPGODL
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public EPreparationTimerType JHDLBEDLJLC
	{
		get
		{
			return EPreparationTimerType.None;
		}
		set
		{
		}
	}

	public bool FDEMPJPJNPB => false;

	public bool JFBLBBGBKPL => false;

	public bool IOMLAPLCNBF => false;

	public bool HPBBMELOKHN
	{
		get
		{
			return false;
		}
		protected set
		{
		}
	}

	public CharacterController AHFGGJNJCAK => null;

	public bool ONDFBDIACEC
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool DGPPPJNAEFN
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public uint KGCADNGDNEF
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public bool GOOLJHBFFHN
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool AFKAJEAOMEM
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public uint DALDGIGKHMC
	{
		get
		{
			return 0u;
		}
		protected set
		{
		}
	}

	public bool CGODEGFAGHH
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool LFLBNDBEKNH
	{
		get
		{
			return false;
		}
		protected set
		{
		}
	}

	public bool ANEKGEKGKBG
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool EBHLLLJFENI
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool HKDFGIAODDI
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool BLNPAAEOJLF => false;

	public bool CNEOBFPKHLF => false;

	public AvatarEffect.EPlayerLastKillState ADAJCJFFCNO
	{
		get
		{
			return AvatarEffect.EPlayerLastKillState.None;
		}
		set
		{
		}
	}

	public bool IJJHLLHNOPI
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool BNMGNHFGIFP
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool FHINJCCHNHA
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public uint NHALNCCIFLK
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public string FHOPPPHODEO
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool AIHLICKMHLK
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private Queue<float> DIAIGGBBAGH => null;

	public EDuoEmoteStage HEDKMIABJLG
	{
		get
		{
			return EDuoEmoteStage.None;
		}
		private set
		{
		}
	}

	public uint JDOJOLBNHPH => 0u;

	public uint DDKLPDCIMAK => 0u;

	public bool ONFCKOKDFAI => false;

	public uint CHMEEDCFBGN
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public uint JCKDHBMEGEJ
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	protected Quaternion JFLPPMNNFLN
	{
		get
		{
			return default(Quaternion);
		}
		set
		{
		}
	}

	protected Quaternion PLLEBHADBAM
	{
		get
		{
			return default(Quaternion);
		}
		set
		{
		}
	}

	public bool NCGEPBNEAJK
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	public bool KGCEDMGGJEB
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool ICAKCOOCBEO
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IKCGOLMNHFI => false;

	public HashSet<int> FDHNBFMGHOF => null;

	public bool PLMBMBFCFOM => false;

	public float PPCIMAOFFPP => 0f;

	public EAimAssist OICIFCFFGCE => EAimAssist.AllOn;

	public bool EEMLIFAFDJB => false;

	public bool CNBAJNOOJED => false;

	public bool HJOONOKGPJB => false;

	public bool KBPFDCBGABP => false;

	public bool ELCKPEAKDBA => false;

	public bool OICIMLGINFI => false;

	public FollowCamera IBOEHCAFOAA
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual Collider HPOEJIGALCP => null;

	public AFBNBKPGOGO AFBNBKPGOGO => null;

	public NewPlayerAnimationSystemComponent ILKACBEMIPF => null;

	public AvatarManager DEMGOKEFDJB => null;

	public IceWallMakerData ECHJACMPJDK => null;

	public PlayerAttributes FILJECAKHFP => null;

	public bool CCOEAALOCAE
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool MLCMPEBLKMA
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Transform NEDIOEAFMMP => null;

	public Transform AEGMHINDOPM => null;

	public Transform OMNHCDEPHJG => null;

	public Transform FAOLBCIAJHB => null;

	public Transform CLKFKFJFFAE => null;

	public Transform NCNHGLBABOC => null;

	public Transform AKOLPLOJHGD => null;

	public Transform KIPPLFOCGKF => null;

	public NavMeshAgent FBPGBOLGACD => null;

	public NetworkPet DAKCFNIEGJA
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool NGJPHBMMNDH
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool LAAHAJJAFOM
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	public bool BDMCBHMIJLG
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool LKOODFEKADE
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool DEPHHDLPDBN
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public uint BABDNCKEMBL
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public float OBIKFBNBAND
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public Vector3 FKEJPAGFJCA
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public virtual bool HDLBGGHMFEI => false;

	public bool ANDDGMGNIGE => false;

	public bool CICEMJGNHIH => false;

	public bool NABCDOKMNNI => false;

	public bool EKCLIJPBHEA => false;

	public bool OBHOFEPCAKO
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public BCDFPMMEPFN ADKMJJGBADP => BCDFPMMEPFN.None;

	public EntityInfo IFHLEILJNCI => default(EntityInfo);

	public FEMJPMLIKDF JDCCFOEFLAO => null;

	public EntityInfo AOPPAPEOBOJ => default(EntityInfo);

	public bool IHLHMHBMJCE => false;

	public bool OCHKBAIBFOP => false;

	public bool FGMDKNNKGNJ => false;

	public bool LLHHNLAECCH => false;

	public bool MIEBCEKNPAH => false;

	public bool FNFLCBDDMEC => false;

	public bool MEDMKCAJECK => false;

	public bool JKMCIMNGFME => false;

	public bool BNEOJDCKBNJ => false;

	public bool PBGNDLFOJFA => false;

	public bool AOOOKGIHIAI => false;

	public bool EOLNFOCMJDL => false;

	public bool HGMLMFJBBAJ => false;

	public bool JPPHFLBKILI => false;

	public bool PPIJNDEBDCM => false;

	public bool AAGLLKJPHNI => false;

	public LevelGrapplingHook FKCPPDDGGNA
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int FCBPJKJFADM
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public float KJABPKNPAIH
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool MANENHGOPFB
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public LevelSwingSpider PBDGJMNIBKC
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool OPLEJNGMPCB => false;

	public bool GPHAIGDNANH
	{
		get
		{
			return false;
		}
		protected set
		{
		}
	}

	public bool NKBGJJBKMJC
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool JEMIBAJMNEL
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool KKDFJKCPMEF
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool ANNAJHIHOFO
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool HBLJHNFAEFA
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool BABIOECEGAL
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	public bool FPAABENOKGA
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool LAJGPDELDFK => false;

	public bool CFFAHICPGLC => false;

	public bool DPMEJOHKAEM
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool DKDIHJAEAMK => false;

	public bool LEGMDFJMFDI => false;

	public bool CHJCKFJPLLN
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool KHDCEMNGKPN
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool DLHNBJGJDGM
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool OLBDGPGJBDJ
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public LevelChair AMKGFHHJFFB => null;

	public LevelSeesaw LHEIBEOHCOH => null;

	public int CGBCINDILLC => 0;

	public int IJEOIIJDBDJ => 0;

	public AnimationID CNNOMIBNBGJ => default(AnimationID);

	public bool IEPGMNPEPFA => false;

	public bool GFCGDMGAJJD => false;

	public Transform IBJNIOCBNCC => null;

	public Transform JELBAPDKDOA => null;

	public Transform KDHBNHOFCKJ => null;

	public Transform ODGDOFCKCPL => null;

	public Transform NBKKFLCAONA => null;

	public Transform EMPHALPIDIK => null;

	public Transform KECBGNNHMKO => null;

	public Transform KGKDAMEHLEI => null;

	public Transform FMACFCJMOLN => null;

	public Transform GFDFMFOIEED => null;

	public bool ILHLGCFNDCG => false;

	public bool GGOAJCFILHD => false;

	public bool KKIDDJLBHLF => false;

	public bool LIJDNOMOFAB => false;

	public bool JJLIFPHAGCL => false;

	public bool OOKHGOKONKD => false;

	public bool DIPNPGOKKPI => false;

	public bool ECIHLKALBGF => false;

	public bool ELEMAIAFGFJ => false;

	public bool HPJBLKHHAJA => false;

	public bool PGOGKFPKBPB => false;

	public bool FOOOHNODKOL => false;

	public bool DLEANDNIHBN => false;

	public bool HDBOJIHFLBN => false;

	public bool EIICODLDBKH => false;

	public bool BGOAGAKOKGN => false;

	public bool GFADOFMJKNE
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool OPOHJPCHEJH => false;

	public bool HGAIMMDNKJL => false;

	public bool OALMHKINHOJ
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool HBOFFFFJOPA => false;

	public bool EHNEMCMNOMB => false;

	public List<CEKLEBBHLIG> LCEJFGJPOPG => null;

	public bool MLBCMMOFILG
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool GPMOKBGCAFI
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public CapsuleHuman DBAHLEDEMPO => null;

	public List<CapsuleCollider> NJLFHKEFDMN => null;

	public LevelLockBountyVehicle ENNDGGBMPMN => null;

	public LevelTeamGatherPoint CBCHHDMAOPF => null;

	public LevelBountyBox AHMBCJCFOEB => null;

	public LevelWeRunBox LPNCFELEANM => null;

	public LevelTriggerHumanTire NALNCODKDBL => null;

	public AMONMHPLPLP AMONMHPLPLP => null;

	public CFIGAMOOFLH MGCCPPPDELJ
	{
		get
		{
			return CFIGAMOOFLH.NONE;
		}
		set
		{
		}
	}

	public uint MCGIAPKPEEF
	{
		get
		{
			return 0u;
		}
		protected set
		{
		}
	}

	public BadgeInfoInGame BCOEMABLKGE
	{
		get
		{
			return null;
		}
		protected set
		{
		}
	}

	public JKFICGGHNFN MNFECBIALJD
	{
		get
		{
			return null;
		}
		protected set
		{
		}
	}

	public DCLNOPKBHLB DFKEFCCKKEK
	{
		get
		{
			return null;
		}
		protected set
		{
		}
	}

	public GHDEMJHFOJM GOKNMKLDDIB
	{
		get
		{
			return null;
		}
		protected set
		{
		}
	}

	public float IGMJOCHOCKE
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float OMKMDKEJGAJ
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float PLNECNEKOMJ
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float HLAGCOFLJPA
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool JLDBHELDDGB
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool FHGEALFBLHM => false;

	public bool CAABGBGEDHL
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public byte KPOCPIDCMDO
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public uint OEBNKGKLFOG => 0u;

	public bool IEJCJOAHPOL => false;

	public AFOLPMOCBOG GCALNLDKAAM
	{
		set
		{
		}
	}

	public ResourceID DAGCBBNBCJF => default(ResourceID);

	public ResourceID PIDGOLIGFNK => default(ResourceID);

	public ResourceID FKEAABJABME
	{
		get
		{
			return default(ResourceID);
		}
		set
		{
		}
	}

	public ResourceID IPOHFGPANDF
	{
		get
		{
			return default(ResourceID);
		}
		set
		{
		}
	}

	public ResourceID EHMMOMNKKJM
	{
		get
		{
			return default(ResourceID);
		}
		set
		{
		}
	}

	public ResourceID ABFNKPHIJNL
	{
		get
		{
			return default(ResourceID);
		}
		set
		{
		}
	}

	public SkyboardData JNDPNKIMICI
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public FlightData EAILLLGGIJB
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool NBFIMNOIONK => false;

	public FlightData GDAFPBBLENA
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public PlayerAudioComponent IMLDFCHNOOF => null;

	public Parachute JPAACFPIKJD => null;

	public bool BILKCJIDPKC => false;

	public Flight KBPIAOLIINO => null;

	public Dictionary<int, ResourceID> PLEBKEFBHBJ => null;

	public JOHBFACKCJJ OHPCHCMANGN
	{
		get
		{
			return JOHBFACKCJJ.NotSet;
		}
		set
		{
		}
	}

	public OOMGNPFEHMG NNCBHOCEIEF
	{
		get
		{
			return OOMGNPFEHMG.None;
		}
		set
		{
		}
	}

	public MGAHNNBLGHN LINKNNKOLMK
	{
		get
		{
			return MGAHNNBLGHN.BOXING;
		}
		set
		{
		}
	}

	public bool DHKCJOJPOBG
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool GDCLNCNANLA
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public GMPGMPFNMFP DNPCAIJBOFD => null;

	public GMPGMPFNMFP LAPNDMNLICD => null;

	public OKEAMEELLBB GBOBMPPGCAO
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Vector3 MPEFJEDBKGC => default(Vector3);

	public Vector3 FMFHHHDKCIC => default(Vector3);

	public bool GDIELDJAJAE => false;

	public BaseLevelObject GHOLKLDHAJN => null;

	public bool LDHNDPJHKJN
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool NLMFMNHOPHB => false;

	public bool HEOOAAAJBFD => false;

	public bool HGBJPDNFNII
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool DNHFCIDIHHO
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool BEEKLIINIME => false;

	public bool FPCBNHBHKGA => false;

	public bool ANGKOEJGDON => false;

	public bool LKMECLACLPJ => false;

	public bool FHDBACIMGGF => false;

	public bool ABCMACPGDLA => false;

	public float ANHMOIHNLMG
	{
		get
		{
			return 0f;
		}
		private set
		{
		}
	}

	public float GGAMNFFKOAD
	{
		get
		{
			return 0f;
		}
		private set
		{
		}
	}

	public bool DMMPHHDFBAC => false;

	public bool JLEKAPDHMOK => false;

	public CheckBoxCrossHairTrigger EPGFJABCAPB => null;

	public bool FNLJGKHPBHG => false;

	public int JINAKNAPIKE => 0;

	public Player OEMPIHKIEPI => null;

	public bool NHFAKNAHGCC
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	public int HAFGPNKBOHK => 0;

	public bool HKCNNHPEALB
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	public virtual BaseProfileInfo JALNGENAEIK => null;

	private Dictionary<GameObject, Transform> HBDHMDBANMO => null;

	public bool ELJIOHGONCD
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	public float LLGEHEJFANM
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float GGGGKNALAGJ
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool MOCNEAGEIOI => false;

	public float JNPLMMFAIJF => 0f;

	public float CIFLKFOLEKD => 0f;

	public float HIJALNPHMME => 0f;

	public override bool IDFBHMDOBLL => false;

	public bool IEFIMDOKKKF => false;

	public bool JELDDIFPDGA => false;

	public override bool HLFBNDNFMCL => false;

	public int IGPHCFFGDBM => 0;

	public bool EMPOGFFALJJ => false;

	protected Dictionary<byte, uint> BIFNGEFACHB => null;

	protected List<NCHOOLJCDNM> MHMLOFIGPAE => null;

	public bool GGKJPOPDHIN
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool EIMBFABGBHC
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool NADCLAGDKND
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool AICGNMEPINN
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool GKIDKCOGJPB
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool JPPGJBINDAK => false;

	public List<HBLKLJHFJDK> MFKKNFOPMFP => null;

	public bool CKBALMKHMMJ => false;

	public bool MKIKCPPLGOL
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public ArcGenerator CLOGAMPBNJN => null;

	public BezierSlide MJPIFFKEFPC => null;

	public float BJPGGPIKFHD => 0f;

	private Vector3 GOLIPMHAHCP => default(Vector3);

	private Vector3 GOCCMAJDMBK
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	private Vector3 PKEOOKKPJLJ
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	private bool GHHIJCGEGPE
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private EKOFDDAKHEB FAMAJOAMOOP => null;

	public bool MKAHIBPAGAL => false;

	public EAvatarModelIngameType AJHFADEKOHK => EAvatarModelIngameType.Normal;

	public AvatarTransformData LEHCLMPGEAC => null;

	public bool ELCLEHBLFEE => false;

	public uint COLHBPBIPBH
	{
		get
		{
			return 0u;
		}
		private set
		{
		}
	}

	public PVEEnergyBallManager KENJLJFAAPM
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Player HNHPONLBLFE => null;

	public Player DNNLDNLODIN => null;

	public bool CNLECGKNHIF => false;

	public bool HBOONFDHINB => false;

	public bool EACGLCKMNMO => false;

	public Player CCGDPCNKHKA => null;

	private static float OCCJGOFADPB => 0f;

	private static float NNBPHOBONEG => 0f;

	public bool BEGMANJENOO => false;

	public float PNNIDIAFABF => 0f;

	public bool PFPBDLJEEHO => false;

	public bool BFIKPMAFNEM => false;

	public ClimbingTrigger BDPGGKCCIGK => null;

	public List<Collider> ALBHEDPFBBE => null;

	public float OAKLNNJOAOE
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public Vector3 ANPBCADGBGK
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	private Dictionary<BHGGAEEHJCO, BKIDLEFNNJA> GHILLIHFJOL => null;

	public bool MCLNEIELACA => false;

	public bool FJBHFPDBAGK => false;

	public bool HAMANJIOFKL => false;

	public bool IBLJPBLNANG => false;

	public byte IEIMGBDJOHL
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool MLKFLNHHLEG
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Action<bool> FJCIGNLIPMO
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public uint GBBHLALNCEG
	{
		get
		{
			return 0u;
		}
		private set
		{
		}
	}

	public bool GGMFOJEGGMH => false;

	public bool FGPCEEOJLGJ => false;

	public FDAEPHMIEPC DAAFPHJNMLJ => null;

	public LIAFPDJNAPH PINIMBCKBCP => null;

	public bool ALPFOINDNGI => false;

	public bool FDOIJJBPHBI => false;

	public bool OJKDMGNDCOK => false;

	public bool LNOBLNHECIC
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool HADMJOGGKCG => false;

	public bool PFEMKDFKPBN => false;

	public bool HGDBFEFHHGB => false;

	public bool JEBDEHLDGLN => false;

	public bool DJMHDKEGNGE
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool MIGEKBILKDA => false;

	public byte KLEOLLJKJIF => 0;

	public bool GBPJLFMHPCH => false;

	public int BCHLILCHEOL => 0;

	public JDFJDBOFKPM BIIDNAPNKHA
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool LADFCKFJFPH => false;

	public FoldWingConfigData OLBECALMHPA => null;

	public bool BEFHLHEFFNM
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static uint FEBJMOJLIPP => 0u;

	public BHGGAEEHJCO PMDLLILNFFG => default(BHGGAEEHJCO);

	public BHGGAEEHJCO DHGPDMJODJB => default(BHGGAEEHJCO);

	public IHACOKBPJEM GBAIGKLONJN => IHACOKBPJEM.Free;

	public bool NDJEBNEIHGA => false;

	public bool PECCKCNOELF => false;

	public Football NLKLGGJFABI => null;

	public float BCOFCNCKIPO => 0f;

	public bool FDAMKCJHCEF => false;

	public FootstepMaterial ADAJEALACJJ => FootstepMaterial.Default;

	public Player_FPPModel JMFHOCBLPEA => null;

	public bool GHOIHMJPNJF => false;

	public LevelDWShield ICDJLCLJMJG
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int ACMHPBOEBLF => 0;

	public int MEDBALKKBLF => 0;

	public int FAADGMEPGPD => 0;

	public float GOIOLBFEOMG => 0f;

	public bool PAHPIONMPPN => false;

	public bool PHDCPDOMLKE => false;

	public bool FANCGDHGAOE => false;

	public bool FGIHBIHHKJJ => false;

	public BMEBLEJJGKD LBEEHDKJPAC => null;

	public bool CHNBMBPFAIG => false;

	public GMPGMPFNMFP OCEOEJEOLBI => null;

	public uint NHGKJDJCBAI => 0u;

	public BBNHJFFAAPM NONEJJIIMBE
	{
		get
		{
			return BBNHJFFAAPM.EMapThrowerUseEntrance_Projectile;
		}
		set
		{
		}
	}

	public bool PPCPCJBLFKD
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	public bool JGPLFDLJDPH => false;

	public OBOHAOFFODK HJPPFOHDMEC => OBOHAOFFODK.ELobbySocialAreaZoneType_None;

	public int OJIKLBDFCOP => 0;

	public bool BKIEOCJEMBK => false;

	public bool DLGBNOJHIAC => false;

	public bool NANLNHCFKEK => false;

	public bool BGMMLEHLJED
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool LINJOGNCGAA
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool LNIJEDHOKIP => false;

	public bool KFEAPEJANOC => false;

	public uint JGLEJNBLKAK => 0u;

	public uint KBBHKDNHDEP => 0u;

	public uint GDALGCKODNH => 0u;

	public bool JBCCMFGNOGG => false;

	public bool JEOFIEJICJH => false;

	public bool HDOMAEJLOAO => false;

	public bool JHBALGDNHEK => false;

	public bool FFHIBPAEABM => false;

	public Player EIBBGMMOPLH
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public float HADJILALBKP
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float NBDGENEBPFA => 0f;

	public float DMLMPBFHGJO
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float GMDANPKECBJ => 0f;

	public float MJHDGAPAPAP
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float KIDMHKJHFCP => 0f;

	public float GBAEPLGCGIB
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float FHDGIIEJIFG => 0f;

	public bool EFHDOODMHJE => false;

	public bool JENKHDJCNNA => false;

	public NBEKMBDMMCE ABEODHNNIPJ => null;

	public uint IPCAAHJOFMD => 0u;

	public Vector3 AEHBHGICKLJ => default(Vector3);

	public bool OPNGIFDOCFL => false;

	public bool BBCNBMJOILD => false;

	public FGAHFBDAKPI LDAFALICPJK => null;

	protected float NBOACGIJMFB => 0f;

	protected float IBGDPGHEPIH => 0f;

	public Vector3 NDGHIFFIFCM => default(Vector3);

	public bool CEDFAJCHAOM => false;

	public bool PCPLBPJIFJJ
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool FPGPLIOACCH
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

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

	public int HKDJIHHPPPO => 0;

	public int KBDAIDPDPIO => 0;

	public int BPDKJJKIPDL
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int LAFHPOFNKHO
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int JPIALDGMAMA => 0;

	public int KACGOHPNALJ
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int KPNNGLIBEPC
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int HLONKLLLOGF
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool LBAJLFLLJJN => false;

	public uint EKJBHHBHBLJ => 0u;

	public int NKODMJBKHDL
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int NFPKKOPGELA => 0;

	public int BKFMNPIBJMG => 0;

	public int MGHBKCEIENN => 0;

	public uint IHNKFMICHGN => 0u;

	public bool GCJMCEAJKOO => false;

	public uint DCGJLMKAHOA => 0u;

	public int EOCOGFOFIKF => 0;

	public float PNABOPLHBMF => 0f;

	public int DCBCHLPJEEC => 0;

	public int FFHMCEEPJHL
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int LLJLPKCFPCJ => 0;

	public int BNIAKGNJGEG => 0;

	public int KBHJCOLOCBP => 0;

	public uint BCCHBLPPFFF => 0u;

	public bool AKNCIFFINPH => false;

	public int KMHGHPNKMKI => 0;

	public int MLFHKCHLBED => 0;

	public float PCFOFGMDHIF => 0f;

	public int PKPENCGNMCK => 0;

	public OAJHENLENLI EHPHJHBEOHJ => OAJHENLENLI.EPLAYER_STATUS_ONLINE;

	public int PLKEAKINDBO => 0;

	public bool LGJKPFHKAHF => false;

	public int HCINAOAHPAK => 0;

	public int JIADKNKNGNG => 0;

	public int LDEEKHKDOCM => 0;

	public byte NLPIPOBCDJL => 0;

	public int HDGDJMDBNLO => 0;

	public int BDILKNPAMAF => 0;

	public uint JBLMPCJGGDE => 0u;

	public bool ODKHOBBHLAD
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int FDJHECHPJKD => 0;

	public int JELKFOLMBLH => 0;

	public int DHOFMFDPKIH => 0;

	public bool FNFKKKEJKLO => false;

	public int IFIGEBKCMAE => 0;

	public uint KIKAGOKJGPD => 0u;

	public int PJCGEJJGCPC => 0;

	public uint GGNLHAKMBID => 0u;

	public int GKNDJLEODNA => 0;

	public uint KLKJFOJDGOC => 0u;

	public bool LCBOLAHGCFB => false;

	public int EGMMFHKMNBC => 0;

	public uint LHJOAHKPLGO => 0u;

	public uint AABMMOOGMGK => 0u;

	public byte PMPLMJLOIMO => 0;

	public byte AOINBDMIPOA => 0;

	public int LNKPAEFACFI => 0;

	public uint CKBHDJJECJC => 0u;

	public int DAFIHBDLECC => 0;

	public float CJGIACICMLD => 0f;

	public uint NKMHFDGKBBM => 0u;

	public uint DJJAFGFGLDO => 0u;

	public uint IMBHIHBNIFG => 0u;

	public int OBGBLEGLFMB => 0;

	public float BECFODMIACA => 0f;

	public uint OAEFDABFLNA => 0u;

	public bool ABAGGIGKICI => false;

	public int BLOKFMHOJNM => 0;

	public float IGPJFEOHLCB => 0f;

	public bool KBBEELMEOLM => false;

	public byte OOJPKBFKKKF => 0;

	public byte PNHLGDBHFEA => 0;

	public byte KBKCNBBHFNA => 0;

	public OJOFMFIDHEK MPIFJJIJMGB => OJOFMFIDHEK.EPlayerSkillImmortalityState_None;

	public int BMGPGIFKMCB => 0;

	public bool JGIILACNMHI => false;

	public byte MPBPEECLJKP => 0;

	public bool BMBDAKFHFMI => false;

	public uint MNFBFEGHDIE => 0u;

	public float MBOPGMKKIJM => 0f;

	public bool PPEAGGCJFII
	{
		set
		{
		}
	}

	public int PIGJGLJGLLG => 0;

	public uint EEBODJNAEKE => 0u;

	public uint COMANKJPFHI => 0u;

	public bool CAEKFFKNAFA => false;

	public bool BNEEMDFEMDB
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float HCMLPDIPKPJ => 0f;

	public int MIKEMNLDIFC => 0;

	public int OOKIMLPHLOH => 0;

	public bool LMCPKHNGPLJ => false;

	public bool CLIHGHCOFBH => false;

	public bool BBCHJNCBCGK => false;

	public byte CKDBOKNHAOM
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public byte ELKCNLHOALB => 0;

	public int FCJKNINCNEI => 0;

	public byte CCIIPNEIADG => 0;

	public ushort KAJNIPOEGAH => 0;

	public byte DDDINNKBAAE => 0;

	public byte EIEPDNFJHEC => 0;

	public bool IIBJGKKJJKA => false;

	public bool NEFJLGCDPDN => false;

	public byte JDMOCAJDIKM => 0;

	public byte KENIHDFGELN => 0;

	public ushort DHBCIHMKCGO => 0;

	public byte IAAELJFLJJF => 0;

	public byte AFGGDILJHMP => 0;

	public uint EEIJMBIIMGH => 0u;

	public byte OLGJFONJBPJ => 0;

	public uint GLCKKHLEABJ => 0u;

	public int LHELKKDJOGH => 0;

	public uint KHPJDCJLPDG => 0u;

	public uint GHFMPMDKHPB => 0u;

	public bool GLPBAPDEECN => false;

	public uint HEJEDNJFJBJ => 0u;

	public uint IGPHBNLDPIC => 0u;

	public uint EFNPGPGEFHB => 0u;

	public uint PCCGNLAFALN => 0u;

	public uint CCGMLIBCJJD => 0u;

	public bool LMJHDJADBHF => false;

	public ulong KBDBJAMGCKP => 0uL;

	public bool PMLLOMHNGGE => false;

	public bool NFKDBKELLKJ => false;

	public bool DEBHBAHFNPA => false;

	public int JHDGOJHCKKM => 0;

	public uint NMNPDNKIHFK => 0u;

	public bool EMCJDMAPLOI => false;

	public bool FJJKIGHNIGM
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool HCHEDGDCJHG => false;

	public bool GCLLMMPNCGD => false;

	public bool CMGOGHHJCCO
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int GOCNLBIMMJO
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public Vector3 MOBJOGDKOAD
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Vector3 DBHNHMOGNKO
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Vector3 DBEGOEHGOLC
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public bool KJHLGODGMJG => false;

	public uint ACNHCHBIIIP => 0u;

	public uint LJKMOEIAAEP => 0u;

	public int HNINBFDGHMD => 0;

	public uint ABKOMKLJJAG => 0u;

	public float ONOJAEKAAHB => 0f;

	public bool OFEGLGAAJAB => false;

	public bool MGCIGIBEMDF => false;

	public bool CKOFJGGJHOE => false;

	public uint LHMOEPIKAEB => 0u;

	public float JPMFABIOHAA => 0f;

	public bool HDIFLGPBHHE
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual bool DFAKEBBLEBA => false;

	public float DBBDEGHCEHL
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public uint IJIOKNDKDNE
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public bool DGLIAPHAEOA
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public uint KCBKJNAFHJC => 0u;

	private List<uint> PEKFNEENJIO => null;

	public bool KEFEGHPMANG => false;

	public bool IGGFKFABAFM => false;

	public bool IEGNLNLKJDE => false;

	public bool BIHPPIAHDCM => false;

	public VehicleDriverCameraTarget LOENEKFPCOK => null;

	protected JJLCALJHHDF JJLCALJHHDF
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool PGBLKNHHPJF => false;

	public bool LGKIGPMCFCB => false;

	public bool INKBFJLNBHK => false;

	public bool GFCCAMBNEAO
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IGBMOEBMGCL => false;

	public bool JILHJFDFBPL => false;

	public OCEKKEPPHBK PNCPBMMPNEN => OCEKKEPPHBK.EGetOnSnowSlideReason_PlayerInput;

	public bool ACBFOGGMFFP => false;

	public bool EICEANAEMKH => false;

	public bool KCKKGEAOFBC => false;

	public float HLEEOMJHIGN
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool HJCEBNMNEGD
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Transform CPECJBPACKK => null;

	public Transform LGBNBAIOMML => null;

	public Transform HHDAMLLDOLA => null;

	public Transform HHAIELAFGFF => null;

	public Transform DPHOGAMKCDA => null;

	public Transform AJALJGKKMFG => null;

	public Transform ADFBMKALOBC => null;

	public Transform OIENOCNAENM => null;

	public Transform FGLLEBLIFEH => null;

	public uint EBKOIFDJBNM => 0u;

	public EFBIHIABNJM ANGMEJJIHHE
	{
		get
		{
			return EFBIHIABNJM.Normal;
		}
		set
		{
		}
	}

	private List<uint> PMCFBLBOMEE => null;

	public CFNMNNLAKNO NJLGIHLKJPF => null;

	public bool JGDJEFLGMNH => false;

	public bool ODJAKEELIOC => false;

	private bool LOEKBHOOECL => false;

	public bool GNKLNHAFGGH => false;

	private bool ELHICNCKAOL => false;

	public bool PDIPJALCNND => false;

	private bool OBHCDODCCLB => false;

	public bool BGFJBMKKGNO => false;

	public uint BLMKDANKCBE
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public BHGGAEEHJCO HJCNNJDLDKN => default(BHGGAEEHJCO);

	public byte NBPFMFGIHBE => 0;

	public CCIPIBCIIDA JFCLDDDHJHH => CCIPIBCIIDA.EParachuteMode_Free;

	public bool MEEHCKMODGM => false;

	public Transform APOBILFBPIJ => null;

	public bool AMJHMODDDOA => false;

	public JECKDOPHBBJ FMJGKCFAEHK => null;

	public float DNHFOMMDHKI
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public uint ABCFBHPBICL
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public uint GAOJLNALBOH => 0u;

	public UGCCustomPlayer MJHAEELECJE
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool AGONIAKIHKP
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool DNBDFNCAAMF
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool DGOPFNKNGOE
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool OGFAAGDAEJF
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool FDLGDLHLEMD
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual UGCCameraConfigRepItem BLHIJJLBGDN
	{
		get
		{
			return null;
		}
		protected set
		{
		}
	}

	public virtual UGCBasicCameraEntity BPIHFAEPHFC
	{
		get
		{
			return null;
		}
		protected set
		{
		}
	}

	public virtual int OBGCODAEDHG => 0;

	public virtual UGCFactionRepItem GONPAHPNHKH
	{
		get
		{
			return null;
		}
		protected set
		{
		}
	}

	public virtual UGCTeamRepItem CPHIFMPOLAE
	{
		get
		{
			return null;
		}
		protected set
		{
		}
	}

	public bool CBAOPHJKODC => false;

	public bool AGONDFAMOFN => false;

	public AALGCBFJHJM DKEEFFHFEHO => AALGCBFJHJM.Enable;

	public AALGCBFJHJM LFJOEKMOFEM => AALGCBFJHJM.Enable;

	public AALGCBFJHJM AKDOKCOEBBL => AALGCBFJHJM.Enable;

	public AALGCBFJHJM OKNLJKNIKFJ => AALGCBFJHJM.Enable;

	public AALGCBFJHJM LGHPIFKPMNM => AALGCBFJHJM.Enable;

	public AALGCBFJHJM NGAGEMJMPBB => AALGCBFJHJM.Enable;

	public AALGCBFJHJM BLPODFDAAKD => AALGCBFJHJM.Enable;

	public AALGCBFJHJM JFBFAGGNLNI => AALGCBFJHJM.Enable;

	public AALGCBFJHJM KGFMMBBOHJB => AALGCBFJHJM.Enable;

	public bool ODCKAGJPADL => false;

	public IPRIDataPool OFDDNPJLEAH => null;

	public UGCPlayerBridge PJMGHEELAMN
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public UGCPlayerRepItem EIEFFLHEPMB => null;

	public UGCPlayerBehaviorRepItem INNCPCFJFLA => null;

	protected HBFMLLIAPAK HFJFIGJNIKN => null;

	public HashSet<uint> GCODPCIGFGA
	{
		get
		{
			return null;
		}
		protected set
		{
		}
	}

	private HELBFMHHPBI ENCPJFEPDOH => null;

	public static int FBGINAOBJGB => 0;

	public bool CMEONGDMPJJ => false;

	public bool BABLFEMOMLG
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public LevelScout OHGHLJDABHM => null;

	public bool MJOJCPHIBKL => false;

	public LevelScout.FGAHFBDAKPI EBCEAKGBFAG => null;

	public void ClearBuffAction()
	{
	}

	public uint GetPlayerActCommonShowVisualEffectUIDByBuffDataID(uint POEFMDGFENN)
	{
		return 0u;
	}

	private void MEAIKCHNCNB(PGGIOKJIMDB KJALKHEHBNG, uint HEJAFAGMMAM)
	{
	}

	private void PDGJKDOOBMA(PGGIOKJIMDB KJALKHEHBNG, uint HEJAFAGMMAM)
	{
	}

	public bool TryGetFirstActiveCustomVisualEffectContext(PGGIOKJIMDB JLKMGFODNPC, out MDICKKNODAD HGDPLAHNFJH)
	{
		HGDPLAHNFJH = null;
		return false;
	}

	public void ProcessSyncedBuffActionClientShowEffect(OIEKBDANGLI HEPICJHFDFH)
	{
	}

	private MDICKKNODAD HBDFCNKHAAL(MKJPHHDBPJO IIGNILLEGEB, EJOKDFLEONG GGNDHHOPOAC)
	{
		return null;
	}

	private static bool BCOEGLNOFFH(EJOKDFLEONG GGNDHHOPOAC, out MDICKKNODAD NADOGLBIKEF)
	{
		NADOGLBIKEF = null;
		return false;
	}

	private void EHIAEPIPNIE(OIEKBDANGLI LHLIKBIDIIJ, EJOKDFLEONG GGNDHHOPOAC, MDICKKNODAD BGDBLGOHDFD)
	{
	}

	private void PBPBBFFLGNI(uint JDHNCLHNJIP, ResourceID JMIMKLAELHE, GameObject KGJNMPHDKAB)
	{
	}

	private void CALEIDNALAE(OIEKBDANGLI LHLIKBIDIIJ, MDICKKNODAD BGDBLGOHDFD, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	private void NEMMIGJECBB(MKJPHHDBPJO IIGNILLEGEB, MDICKKNODAD BGDBLGOHDFD)
	{
	}

	public void ProcessSyncedBuffActionFunction(LBGFNBCJHMN FNONHJPIEFK)
	{
	}

	private void FDPIKFNMJAG(LBGFNBCJHMN FNONHJPIEFK, EJOKDFLEONG MJPCAIHIOHO)
	{
	}

	private void DCENAODILMJ(LBGFNBCJHMN FNONHJPIEFK)
	{
	}

	private void OLNDHAGOPDH(LBGFNBCJHMN FNONHJPIEFK)
	{
	}

	private void HGAMDECJKAB(LBGFNBCJHMN FNONHJPIEFK)
	{
	}

	public void ProcessPlayerGiveDeltaSpeedScaleAction(ulong HCMPPGODOCB, LBGFNBCJHMN FNONHJPIEFK, EJOKDFLEONG FECBOCBHKLD)
	{
	}

	private void GAILNIMBCCH(LBGFNBCJHMN FNONHJPIEFK, EJOKDFLEONG FECBOCBHKLD)
	{
	}

	private void KNEFHECLEGH()
	{
	}

	private void JDONCLGGGNE()
	{
	}

	private void LBNJOAAGDEA(LBGFNBCJHMN FNONHJPIEFK)
	{
	}

	private void OFHFOGLOBLG(LBGFNBCJHMN FNONHJPIEFK)
	{
	}

	private void CCMJBCLFADJ(LBGFNBCJHMN FNONHJPIEFK, EJOKDFLEONG IJNHEHHCLLO)
	{
	}

	private void BCHLBJMLDOH()
	{
	}

	private static void NMJOBJNHBFP(LBGFNBCJHMN FNONHJPIEFK, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	private void EECLHJDGPJG(LBGFNBCJHMN FNONHJPIEFK, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	private void MPPEHJKNDIA(LBGFNBCJHMN FNONHJPIEFK)
	{
	}

	private void CNHIAMGCOAO(LBGFNBCJHMN FNONHJPIEFK, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	private void LDNOAJJCHGJ(LBGFNBCJHMN FNONHJPIEFK, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	private void ICLOPCMMCNC(LBGFNBCJHMN FNONHJPIEFK, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	private void PIGKFLMDPBE(LBGFNBCJHMN FNONHJPIEFK, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	private void LCPFKFLDONM(LBGFNBCJHMN FNONHJPIEFK, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	private void EIKODEKPCMN(LBGFNBCJHMN FNONHJPIEFK, EJOKDFLEONG MJPCAIHIOHO)
	{
	}

	private void EMCHFFCFEMA(LBGFNBCJHMN FNONHJPIEFK, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	private void PODAMPBIADG(LBGFNBCJHMN FNONHJPIEFK, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	private void KHBOHAFOPHG(LBGFNBCJHMN FNONHJPIEFK, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	private void NJPCONIJOLG(LBGFNBCJHMN FNONHJPIEFK, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	private void AHMGADBCADP(LBGFNBCJHMN FNONHJPIEFK, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	private void OGGAOEPDMNB(LBGFNBCJHMN FNONHJPIEFK, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	private void FIMIECADLNI(LBGFNBCJHMN FNONHJPIEFK, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	private void JKMBIAHPICK(LBGFNBCJHMN FNONHJPIEFK, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	private void IMGBAEMEIHJ(LBGFNBCJHMN FNONHJPIEFK)
	{
	}

	private void NLEOPOFLIGN(LBGFNBCJHMN FNONHJPIEFK, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	private void PKKGCPGKEDI(LBGFNBCJHMN FNONHJPIEFK)
	{
	}

	public void ProcessPlayerGiveIceWallMakerSpeedScaleAction(ulong HCMPPGODOCB, LBGFNBCJHMN FNONHJPIEFK)
	{
	}

	public void ProcessAddPlayerWeaponDamageScaleAction(LBGFNBCJHMN FNONHJPIEFK)
	{
	}

	public void ProcessAddPlayerDmgIncreaseRatioAction(LBGFNBCJHMN FNONHJPIEFK, EJOKDFLEONG FECBOCBHKLD)
	{
	}

	public void ProcessAddPlayerBeDmgIncreaseRatioAction(LBGFNBCJHMN FNONHJPIEFK, EJOKDFLEONG FECBOCBHKLD)
	{
	}

	public void ProcessPlayerModifyBeHealRatioAction(LBGFNBCJHMN FNONHJPIEFK, EJOKDFLEONG FECBOCBHKLD)
	{
	}

	public bool CheckDamageFromWeapon(EECMIDPHCKN JCONDDPFBKK)
	{
		return false;
	}

	public void ProcessInfiniteIceWallAction(LBGFNBCJHMN FNONHJPIEFK, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	private void EHEGNPOEJIF(LBGFNBCJHMN FNONHJPIEFK, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	private void AJALEJLAIBE(LBGFNBCJHMN FNONHJPIEFK, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	private void KIIFOIKFAID(LBGFNBCJHMN FNONHJPIEFK, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	private bool MBMKAHGMNAI(LBGFNBCJHMN FNONHJPIEFK, ref SafeReference<uint> JIBFCCGEDGE)
	{
		return false;
	}

	public void ProcessBuffEcaEnableShowAirdropWeaponMark(LBGFNBCJHMN FNONHJPIEFK)
	{
	}

	public void ProcessBuffEcaAirdropCaptureSpeedUp(LBGFNBCJHMN FNONHJPIEFK)
	{
	}

	public void ProcessBuffEcaEnableRevivePointStore(LBGFNBCJHMN FNONHJPIEFK)
	{
	}

	public void ProcessBuffEcaBuffDelayDestroyLoadoutScanner(LBGFNBCJHMN FNONHJPIEFK)
	{
	}

	public void ProcessBuffEcaBuffUpgradeTacticShop(LBGFNBCJHMN FNONHJPIEFK)
	{
	}

	public void ProcessBuffEcaTeamScan(LBGFNBCJHMN FNONHJPIEFK)
	{
	}

	public void ProcessBuffEcaTeamReviveCardDiscount(LBGFNBCJHMN FNONHJPIEFK, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	public void ProcessBuffEcaRangedPlayerVfx(LBGFNBCJHMN FNONHJPIEFK, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	public void ProcessBuffEcaRangedPlayerCanXRayMe(LBGFNBCJHMN FNONHJPIEFK, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	private void GDCIAPIHIGA(LBGFNBCJHMN FNONHJPIEFK, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	private void MECCBHAANIE(OIEKBDANGLI LHLIKBIDIIJ, MDICKKNODAD BGDBLGOHDFD, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	private void NGBPBNJFODI()
	{
	}

	private void DOAKDGMAIFN()
	{
	}

	private void CPENEBCDEKH(PGGIOKJIMDB KJALKHEHBNG, uint NLILEHLAFME)
	{
	}

	private void MHKJLIJLMAK(OIEKBDANGLI LHLIKBIDIIJ, MDICKKNODAD BGDBLGOHDFD, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	private void LLGAMEFMAGL(OIEKBDANGLI LHLIKBIDIIJ, MDICKKNODAD BGDBLGOHDFD, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	private void CGHPILFMKPK()
	{
	}

	private void JFIABOGAGPH(OIEKBDANGLI LHLIKBIDIIJ, MDICKKNODAD BGDBLGOHDFD, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	private void MOALCPKOMMK()
	{
	}

	private void KAOLMOGGMLA(OIEKBDANGLI LHLIKBIDIIJ, MDICKKNODAD BGDBLGOHDFD, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	private void JOGJPPMAANH()
	{
	}

	private void FFMPJJJKLFE(OIEKBDANGLI LHLIKBIDIIJ, MDICKKNODAD BGDBLGOHDFD, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	public MANLOOMKLOD GetBuffECAKillNotificationContext(bool LJGGAGOBHLC)
	{
		return null;
	}

	public void ClearBuffECABeKilledContext()
	{
	}

	private void APLHEBPEHAN(MKJPHHDBPJO IIGNILLEGEB, MDICKKNODAD BGDBLGOHDFD, EJOKDFLEONG GGNDHHOPOAC, bool LJGGAGOBHLC)
	{
	}

	public IHJIKFAEDCM GetBuffECAKillVFXOnTargetContext()
	{
		return null;
	}

	private void MODGBBMHCLE(MKJPHHDBPJO IIGNILLEGEB, MDICKKNODAD BGDBLGOHDFD, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	private void ICANJHNBHKC(OIEKBDANGLI LHLIKBIDIIJ)
	{
	}

	private void BKNPDCPLBLM(OIEKBDANGLI LHLIKBIDIIJ, MDICKKNODAD BGDBLGOHDFD, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	private void EJIDNOFIEGK(OIEKBDANGLI LHLIKBIDIIJ, MDICKKNODAD BGDBLGOHDFD, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	private void CDBNDFJPGPG(OIEKBDANGLI LHLIKBIDIIJ, MDICKKNODAD BGDBLGOHDFD, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	private void JKCNOFCOKFC(OIEKBDANGLI LHLIKBIDIIJ, MDICKKNODAD BGDBLGOHDFD, EJOKDFLEONG MJPCAIHIOHO)
	{
	}

	private void DPAHKPDKCLP(MKJPHHDBPJO IIGNILLEGEB, MDICKKNODAD BGDBLGOHDFD, EJOKDFLEONG MJPCAIHIOHO)
	{
	}

	private void KDAJDPMKJKE(MKJPHHDBPJO IIGNILLEGEB, MDICKKNODAD BGDBLGOHDFD, EJOKDFLEONG MJPCAIHIOHO)
	{
	}

	private void DBDOIBNEFGH(MKJPHHDBPJO IIGNILLEGEB, MDICKKNODAD BGDBLGOHDFD, EJOKDFLEONG MJPCAIHIOHO)
	{
	}

	private void BPFEDBLIFPB(OIEKBDANGLI LHLIKBIDIIJ, MDICKKNODAD BGDBLGOHDFD, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	private void KPEOOIKHADK(OIEKBDANGLI LHLIKBIDIIJ, MDICKKNODAD BGDBLGOHDFD, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	private void LEBLMJCDBAM(OIEKBDANGLI LHLIKBIDIIJ, MDICKKNODAD BGDBLGOHDFD, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	private void GLODCCDDOBD(OIEKBDANGLI LHLIKBIDIIJ)
	{
	}

	private void PPNIGDFBOIM(OIEKBDANGLI LHLIKBIDIIJ, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	private void PGHNPBDHMBH(OIEKBDANGLI LHLIKBIDIIJ, MDICKKNODAD BGDBLGOHDFD, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	public string GetBuffKingVisualSpriteName(uint LKAEJONKLFB)
	{
		return null;
	}

	public ResourceID GetBuffKingVisualHead()
	{
		return default(ResourceID);
	}

	private void MPEHGCDMCDF(EventID IJPLGLIKLJF)
	{
	}

	private void KOAGFELMOGB(OIEKBDANGLI LHLIKBIDIIJ, MDICKKNODAD BGDBLGOHDFD)
	{
	}

	private void DAOIDNEDHNO(OIEKBDANGLI LHLIKBIDIIJ, MDICKKNODAD BGDBLGOHDFD)
	{
	}

	private void PPHBMDMNANI(OIEKBDANGLI LHLIKBIDIIJ, MDICKKNODAD BGDBLGOHDFD, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	private void PDLONBFLGNP(OIEKBDANGLI LHLIKBIDIIJ, MDICKKNODAD BGDBLGOHDFD, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	public string GetDamageLabelIconForBuffECA(out uint MNLLJKIMEOJ)
	{
		MNLLJKIMEOJ = default(uint);
		return null;
	}

	public Color GetDamageLabelIconColorForBuffECA(uint MNLLJKIMEOJ)
	{
		return default(Color);
	}

	public ResourceID GetSFXHitResIDForBuffECA(uint MNLLJKIMEOJ)
	{
		return default(ResourceID);
	}

	public void ConsumeDamageLabelIconTimesForBuffECA(uint MNLLJKIMEOJ)
	{
	}

	public ResourceID GetFireBonusUIFXResIDForBuffECA()
	{
		return default(ResourceID);
	}

	private void PIGMBKHDHJF(OIEKBDANGLI LHLIKBIDIIJ, MDICKKNODAD BGDBLGOHDFD, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	private void GJKLHIEEIAP(OIEKBDANGLI LHLIKBIDIIJ, MDICKKNODAD BGDBLGOHDFD, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	private void KKGCGMMGCEC(OIEKBDANGLI LHLIKBIDIIJ, MDICKKNODAD BGDBLGOHDFD, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	private void DKPBGBPGGJK(OIEKBDANGLI LHLIKBIDIIJ, MDICKKNODAD BGDBLGOHDFD, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	private void EGLNNKJMKKD(OIEKBDANGLI LHLIKBIDIIJ, MDICKKNODAD LNFNPEFIJGI, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	public bool InMaxHpChangeShowState()
	{
		return false;
	}

	private void LICPFILGOCD(OIEKBDANGLI LHLIKBIDIIJ, MDICKKNODAD BGDBLGOHDFD, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	private void EJOHNCBMGKE(LBGFNBCJHMN FNONHJPIEFK, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	private void AINAFPCAFDD(int MKCCNABIKII, uint PKAAOKDEHBD, uint BNCGDMMLEMJ, bool BJLHOHBEFDA)
	{
	}

	private void DDJICPKMJFM(uint PKAAOKDEHBD, bool BJLHOHBEFDA)
	{
	}

	public bool NeedTryPlayCarni25GPDanceEmote()
	{
		return false;
	}

	public void PlayCarni25GPDanceEmote()
	{
	}

	public bool IsInCarni25GPDanceDebuff()
	{
		return false;
	}

	public bool IsInCarni25GPDanceBuff()
	{
		return false;
	}

	private bool BIGJOHDPOJD()
	{
		return false;
	}

	public void ActionPantherTruck(uint MNGIJBDCGGE)
	{
	}

	private IEnumerator AONHBOCNKJG(uint MNGIJBDCGGE)
	{
		return null;
	}

	private void GFJBAAHMIMF(Collider GLJGHEAPBOF)
	{
	}

	private void LKELBAJPLAP(Collider GLJGHEAPBOF)
	{
	}

	public void ChangeToGBFootBall(uint MKCCNABIKII, uint IDCHLDICNPP)
	{
	}

	public void ChangeBackFromGBFootBall()
	{
	}

	public bool CheckCanChangeGBFootBall()
	{
		return false;
	}

	public virtual void SendChangeToGBFootBall()
	{
	}

	public virtual void SendCancelGBFootBall()
	{
	}

	public void GBFootballTryHitIceWall(IceWall CHPANHMJJDN)
	{
	}

	public void GBFootballTryHitFlyPlayer(Player PGEGMKJKOKI)
	{
	}

	public void ClearKickBallData()
	{
	}

	public void UpdateKickBallTarget(bool HNFJMJADIJE = false)
	{
	}

	public bool CheckCanKickBall()
	{
		return false;
	}

	public void TryKickBall(float GOMNGFFGLKD)
	{
	}

	public void KickBall(Player PGEGMKJKOKI, Vector3 OFICIPPBDIJ, float GOMNGFFGLKD, bool PGOPEEAHFDF)
	{
	}

	public void KickFootballAnim(Quaternion FOALBMBCJLF, bool OHABCOKJGPC)
	{
	}

	private IEnumerator EHDMICADFFP()
	{
		return null;
	}

	public void UpdateKinematics_UsingPhysicalCCT(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	void LJJABOHJEIN.BeforeCCTUpdate()
	{
	}

	void LJJABOHJEIN.AfterCCTUpdate()
	{
	}

	void LJJABOHJEIN.AfterUpdateGroundState()
	{
	}

	Quaternion LJJABOHJEIN.UpdateRotation(Quaternion FGLBEPPDAJC, float OKJIFBCMDAD, float HOGHEFNINAE)
	{
		return default(Quaternion);
	}

	Vector3 LJJABOHJEIN.UpdateVelocity(Vector3 OAFPJPDFNEK, float OKJIFBCMDAD, float HOGHEFNINAE)
	{
		return default(Vector3);
	}

	void LJJABOHJEIN.OnControllerColliderHit(ControllerColliderHit HDGIHCBAOEN)
	{
	}

	void LJJABOHJEIN.OnGroundHit(Collider NPEMKNFIIHL, Vector3 IJKBFICPDNF, Vector3 AFNNMPBCDCG)
	{
	}

	void LJJABOHJEIN.OnMovementHit(Collider NPEMKNFIIHL, Vector3 IJKBFICPDNF, Vector3 AFNNMPBCDCG)
	{
	}

	void LJJABOHJEIN.APICCTMove(Vector3 PMPDHDOENCB)
	{
	}

	void LJJABOHJEIN.APICCTTeleport(Vector3 IGDHIDGLOKG)
	{
	}

	void LJJABOHJEIN.APICCTForward(Vector3 BAPEDKECNLH)
	{
	}

	public virtual void OnSyncUGCPhysicalCCTProperty(long OGDNBBJKNFD, UGCSimpleValue EIOKHLKJEEL)
	{
	}

	public void SetDelayDestroyGoInfo(float HKJKEJONGMC, Action DBJBCFOHNLG = null)
	{
	}

	public void SetSPVisualType(AOOCPENNMGL BADGKIEJIJE)
	{
	}

	public static KKLOIPIACBL GetBuffBehaviorUpdateRes(OMEODMEKCFF JCONDDPFBKK)
	{
		return null;
	}

	public static KKLOIPIACBL GetBuffBehaviorUpdateRes(BHGGAEEHJCO OBMFMAKFDDL, uint IONLGGPBMGE, uint JBPHOKDHKJA, LBAODKIEKDL JDNDNLLIFCN, float KJBBEIFCBHN)
	{
		return null;
	}

	public void SetIgnoreUserInputState(bool GPFPIAMCEMI)
	{
	}

	public void SetIgnoreMoveInput(bool GPFPIAMCEMI)
	{
	}

	public void AddEPSurroundEffect(int FJCPAJEPBOD = 1, bool MCABMDPCKKG = true)
	{
	}

	public void ForceMoveByClientHit(Vector3 IJLDIOOKEFA)
	{
	}

	public void SetAirShopBoughtData(uint AHMECCJJDOF, ushort PGOAGEHOIEJ)
	{
	}

	public ushort GetAirShopBoughtById(uint LIKPJDHGPFG)
	{
		return 0;
	}

	public void ClearAirShopBounght()
	{
	}

	public bool IsHippoCrisisGameFinished()
	{
		return false;
	}

	public void UpdateAutoFLihtDamageEffect(bool EOGOGFLCEHL, BHGGAEEHJCO NHJPJGGCMJA, uint MDPGBPLMAFO)
	{
	}

	private Vector3 GCOEFNIEBLJ(Vector3 KLGGIFKBCGP, float EFMLCKBMOEJ = 0f)
	{
		return default(Vector3);
	}

	public bool GetInPartyShoot()
	{
		return false;
	}

	public void SetInPartyShoot(bool PIDINBNGILH)
	{
	}

	public void SetPartyEffectShow(uint FJCPAJEPBOD = 0u)
	{
	}

	public void InitMusicPartyEffect()
	{
	}

	protected void DECHCFEHAMK()
	{
	}

	public void SyncRevengeInfo(PAFKGDCOHIP APHHNHEDHKD)
	{
	}

	public void SyncRevengersInfo(FNKFGPHPPDC APHHNHEDHKD)
	{
	}

	public void UpdateRevengeStatus(bool MGGFGEHLKOE = false)
	{
	}

	public void EnableCrossWindowEffect(bool OGECPGHMIHA)
	{
	}

	public Transform GetRuntimeMainCameraTransform()
	{
		return null;
	}

	public override Vector3 GetAttackableCenterWS()
	{
		return default(Vector3);
	}

	public override float GetAttackableRadius()
	{
		return 0f;
	}

	public uint GenerateLocalDamgeProjectileID()
	{
		return 0u;
	}

	public ulong GetShowUserID()
	{
		return 0uL;
	}

	public void ReplaceSamoInfo(ulong HGNIOBLGCII, string CEIPJFIPLEN)
	{
	}

	public uint GenUniqueID()
	{
		return 0u;
	}

	public void SetBooyahEmotionID(uint LIKPJDHGPFG)
	{
	}

	public void RequireFollowCameraRotationUpdateTracing()
	{
	}

	public bool IsTracingFollowCameraRotationUpdate()
	{
		return false;
	}

	public bool IsFollowCameraRotationUpdateTracingFinished()
	{
		return false;
	}

	public void UpdateFollowCameraRotationUpdateTracing(bool DLNIDMFPDII, bool HNOJJFDDIGG)
	{
	}

	protected void BOFEIBOLHEC(Quaternion IPKKCHLDJMA)
	{
	}

	public void SetEAimAssitMode(EAimAssist GKPEBPJECHN)
	{
	}

	public EMFEPBOHGOJ GetAimAssistOnSighting()
	{
		return null;
	}

	public INLEEGPMNMD GetSightCameraRot()
	{
		return null;
	}

	public HDGPDKHLKKC GetResureStatus()
	{
		return null;
	}

	public HJDBKPGPNFF GetUsingRescureZoneStatus()
	{
		return null;
	}

	public EJDJBFFBLLM GetPacemakerStatusStatus()
	{
		return null;
	}

	public bool BeRescuedAndCanBeAssisted()
	{
		return false;
	}

	public Vector3 GetChestPos(bool IGFAECNLKIL = false)
	{
		return default(Vector3);
	}

	public virtual Transform RootTF()
	{
		return null;
	}

	public static bool IsBoneNode(string ODMPOJBJADM)
	{
		return false;
	}

	public AvatarManager GetAvatarManager()
	{
		return null;
	}

	public void ResetHitFlyGetUpSpeed()
	{
	}

	public void ResetHitFlyInfo()
	{
	}

	public void ResetSwapWeaponTime()
	{
	}

	public void SetAimRotation(Quaternion IPKKCHLDJMA, bool FKEMHKCGLEO = true)
	{
	}

	public void ReleaseCancelTargetExcept(BCDFPMMEPFN LKMDABFOPGK)
	{
	}

	public BCDFPMMEPFN GetCancelTarget()
	{
		return BCDFPMMEPFN.None;
	}

	public void SetCancelTargetTriggered()
	{
	}

	public void SetCancelTargetPressed(bool HNOKCDJJGAK, BCDFPMMEPFN PFJFADHEJLJ)
	{
	}

	public void SetIsPendingRevive(bool GGLDMJEFGCG)
	{
	}

	public Vehicle VehicleIAmIn()
	{
		return null;
	}

	public bool UseBountyMotoVehicleFireController()
	{
		return false;
	}

	public bool IsPassengerInVehicleCanFire()
	{
		return false;
	}

	public bool IsDriverInVehicleCanFire()
	{
		return false;
	}

	public bool IsVehicleSupportDriverWeaponFire()
	{
		return false;
	}

	public bool IsInVechileCanWeaponFire()
	{
		return false;
	}

	public bool IsInSitting()
	{
		return false;
	}

	public bool IsInCatapult()
	{
		return false;
	}

	public bool IsInCannon()
	{
		return false;
	}

	public bool CanUseCannon()
	{
		return false;
	}

	public bool IsUseSpaceShield()
	{
		return false;
	}

	public LevelCatapult GetCatapultIAmIn()
	{
		return null;
	}

	public LevelCannon GetCannonIAmIn()
	{
		return null;
	}

	public override bool IsVisible()
	{
		return false;
	}

	public bool IsVisibleByFlag(uint PIDINBNGILH)
	{
		return false;
	}

	public bool IsFPPVisible()
	{
		return false;
	}

	private uint OMKJKGOAGMM()
	{
		return 0u;
	}

	public BitArrayBoolean CloneCurrentVisible()
	{
		return null;
	}

	public bool IsOnlyFlagHidePlayer(uint PIDINBNGILH)
	{
		return false;
	}

	public bool IsOnlineBotAgent()
	{
		return false;
	}

	public void SetSniperFireCollider(CapsuleCollider IIHDALCNINP)
	{
	}

	internal static void CBHAACNMKJF(Collider IIHDALCNINP)
	{
	}

	public bool CanHumanTireJump()
	{
		return false;
	}

	public static CFIGAMOOFLH GetReasonFromRescueMethod(EAFGOABMIJP CEAJJKEEPMF)
	{
		return CFIGAMOOFLH.NONE;
	}

	public override bool IsStreamerVisible()
	{
		return false;
	}

	public bool IsPartialVisible(uint PIDINBNGILH)
	{
		return false;
	}

	public virtual BaseProfileInfo PlayerBaseProfile()
	{
		return null;
	}

	public virtual bool IsWatching()
	{
		return false;
	}

	public static Player CreatePlayer<T>(Transform MLBAMPFOCGP, ulong HGNIOBLGCII, ulong GMKFNKFFPBH, BHGGAEEHJCO OBMFMAKFDDL, bool CHDFFDMBMEL = false, object LHLIKBIDIIJ = null, bool MFKCPIMIAMO = false) where T : Player
	{
		return null;
	}

	public override void InitEntityInfo()
	{
	}

	private void IGOIABIBGOC(object[] JCONDDPFBKK)
	{
	}

	public void CreateCapsuleHuman()
	{
	}

	public override void OnReUse()
	{
	}

	public override bool Recycle()
	{
		return false;
	}

	public void BeforeRecyle()
	{
	}

	public override void OnRecycleClearData()
	{
	}

	public void ClearData()
	{
	}

	public void ClearDataExtra()
	{
	}

	public override void OnRecycle()
	{
	}

	protected override void OnOnDestroy()
	{
	}

	public override void RecycleForInGameReload()
	{
	}

	protected IEnumerator CEEFDKHPIFC()
	{
		return null;
	}

	public virtual void InitWhenAvatarReady()
	{
	}

	private void ILDHHEEAFCF(Animator EHKHGICCIEG)
	{
	}

	private void EPNJADECOKE(UMAData JCONDDPFBKK)
	{
	}

	private uint NAIGPENCPPP(UMAData JCONDDPFBKK)
	{
		return 0u;
	}

	private void OFFMMDAGPMM(UMAData JCONDDPFBKK)
	{
	}

	public void RefreshSocialLobbyAnimatorAvatar()
	{
	}

	public void EnableCharactorController(uint PIDINBNGILH, bool NDGMENGEGIE)
	{
	}

	public void EnableSniperCollider(bool NFFIGPEDIEH)
	{
	}

	public void EnableCharactorCollider(bool NFFIGPEDIEH)
	{
	}

	private void LILGCNOAPEC(int NIBBKONKPHP)
	{
	}

	public void EnableCharactorAnimator(bool NFFIGPEDIEH)
	{
	}

	public void SetVisibleOnTrainingZoneChange(bool KGOHDEBHENF)
	{
	}

	public bool CheckPendingTriggerEmpty()
	{
		return false;
	}

	private void CLMACAAIFKL()
	{
	}

	private List<FEMJPMLIKDF> GBNEACFGDDH(bool FCNBBAMBKOB)
	{
		return null;
	}

	private void CBOOEEAEAMM(bool HCLGHJNEFIC)
	{
	}

	public virtual void SetVisible(uint PIDINBNGILH, bool NDGMENGEGIE)
	{
	}

	public void SetModelAndWeaponVisibleOnBoardState(bool LONOBDDEMCI)
	{
	}

	public void AnimationHideForFlight()
	{
	}

	public void AnimationShowForFlight()
	{
	}

	public bool IsOnlyCabinWaitingHide()
	{
		return false;
	}

	public virtual void ClientSetOnBoard()
	{
	}

	public void SetVisibleOfCabinWaiting(bool KGOHDEBHENF)
	{
	}

	public bool GetVisibleOfCabinWaiting()
	{
		return false;
	}

	public void RefreshVehicleAnim()
	{
	}

	protected virtual void FPIBBHGKPOM()
	{
	}

	private bool OCBJJJKKGNP()
	{
		return false;
	}

	public OMELKCOGCBK GetInventoryManager()
	{
		return null;
	}

	public FDAEPHMIEPC GetWeaponOnHand()
	{
		return null;
	}

	public void RefreshAllWeaponParams()
	{
	}

	public void RefreshContinueHitTime(int NJMMDDMIION)
	{
	}

	public void RecordCurrentGrandElectricDamage(uint FCAOOKIBKJK)
	{
	}

	public void PlayerExitElectricZone()
	{
	}

	public void RefrehPlayerInElectricZone(bool LBCELFINIAB)
	{
	}

	public void ClearWeaponContinueHitTime(int NJMMDDMIION)
	{
	}

	public FDAEPHMIEPC GetActiveWeapon()
	{
		return null;
	}

	protected override void OnAwake()
	{
	}

	public void InitCollider()
	{
	}

	private void DOHMNGCOEBM(Transform EGGAHAEMEJF, Transform PFJFADHEJLJ, bool JDLBOAGOCMP)
	{
	}

	public bool HaveTeamFlight()
	{
		return false;
	}

	public virtual bool HaveFlight()
	{
		return false;
	}

	public bool IsTeamFlightParachutingNeedSound()
	{
		return false;
	}

	public bool IsTeamFlightParachuting()
	{
		return false;
	}

	protected Transform GDCDKLEGFPH()
	{
		return null;
	}

	public virtual void InitProperties(object OOCMJCKJHMG, bool PGGEHAIHHFG = true)
	{
	}

	public void SwitchReadyState(JCPJMHLOOHD CBCAJJJCKLH)
	{
	}

	public bool IsStateReady(JCPJMHLOOHD CBCAJJJCKLH)
	{
		return false;
	}

	protected void GOPCGCMCEHI()
	{
	}

	protected virtual void OPJIGLFOMPO()
	{
	}

	protected virtual void LMNGOJOJFNM()
	{
	}

	private void ACPDCDAOFBI()
	{
	}

	public virtual void UpdateShiledEffect()
	{
	}

	public void ChangeAnimationSystemFormWaitingToBattle()
	{
	}

	public void ShowShieldAttackedEffect(Player NNHKGODKFCL)
	{
	}

	private void OJKNKLLBGMC()
	{
	}

	protected void JCEGNMKAPDA()
	{
	}

	protected void EKCKBBPEFGJ()
	{
	}

	public static bool IsLocalPlayer(ulong HGNIOBLGCII, BHGGAEEHJCO OBMFMAKFDDL, bool INNDNODNPAF = true)
	{
		return false;
	}

	public bool IsLocalPlayer()
	{
		return false;
	}

	public bool IsCanOpenKillCam()
	{
		return false;
	}

	public virtual bool IsLocalTeammate(bool EPNFBEJFGPE = false)
	{
		return false;
	}

	public bool IsInLocalPlayerServiceGroup()
	{
		return false;
	}

	public bool ShowWeaponSkin()
	{
		return false;
	}

	public bool ShowSkinInternal(SkinDataManager.SkinType CCNBNLAPJFM)
	{
		return false;
	}

	public bool ShowSkin(SkinDataManager.SkinType CCNBNLAPJFM)
	{
		return false;
	}

	private bool FGMAOKDPAOD()
	{
		return false;
	}

	public bool ShouldHideWeaponSkinByStreamer()
	{
		return false;
	}

	public void MarkWeaponSkinPending()
	{
	}

	public void MarkBackWeaponSkinPending()
	{
	}

	public bool ShowSkinInUgc()
	{
		return false;
	}

	public static bool ShowSkinForQualityAndMemory()
	{
		return false;
	}

	public bool ShowFistWeapon()
	{
		return false;
	}

	public bool NeedFistCollectionSound(uint ENJBDKJIKJO)
	{
		return false;
	}

	public bool ShowHandWeaponEffect()
	{
		return false;
	}

	public bool ShowHandWeaponFireEffect()
	{
		return false;
	}

	public bool ShowHandWeaponGunTraceEffect()
	{
		return false;
	}

	public bool ShowHandWeaponReloadEffect()
	{
		return false;
	}

	public virtual uint GetWeaponRelatedFinalShotID()
	{
		return 0u;
	}

	public virtual uint GetWeaponRelatedPropertySkinID(uint LPHNICDPDBN)
	{
		return 0u;
	}

	public bool IsWeaponSkinABStatusA(uint ENJBDKJIKJO)
	{
		return false;
	}

	public bool NeedWeaponSkinFireSound(uint ENJBDKJIKJO)
	{
		return false;
	}

	public bool NeedWeaponSkinSightReskin(uint ENJBDKJIKJO)
	{
		return false;
	}

	public bool ShowBackWeaponEffectByQualityAndTeammate()
	{
		return false;
	}

	public bool ShowClothEffect()
	{
		return false;
	}

	public static bool UseHighQualityAvatar(ulong HGNIOBLGCII, BHGGAEEHJCO OBMFMAKFDDL, ulong GMKFNKFFPBH)
	{
		return false;
	}

	public bool UseHighQualityAvatar()
	{
		return false;
	}

	public bool IsLocalObservered()
	{
		return false;
	}

	public bool IsLocalTryingObservered()
	{
		return false;
	}

	public bool IsUserControlChanged()
	{
		return false;
	}

	public GameObject GetGameObject()
	{
		return null;
	}

	public Vector3 GetTargetDirection()
	{
		return default(Vector3);
	}

	public Vector3 GetFallingDirection()
	{
		return default(Vector3);
	}

	public Vector3 GetVelocity()
	{
		return default(Vector3);
	}

	public IGJPHDANPJD GetPhysXState()
	{
		return IGJPHDANPJD.Walking;
	}

	public EOGPGNIDOKF GetPhysXPose()
	{
		return EOGPGNIDOKF.EPHYSXPOSE_STANDING;
	}

	public bool IsCrouching()
	{
		return false;
	}

	private void HANPHOIIHGP()
	{
	}

	private void HPCKAMLPHIP()
	{
	}

	public virtual void Dead(int LPHNICDPDBN, uint ENJBDKJIKJO, BHGGAEEHJCO FNOOENEHBJP, bool IECLLKLGNME = false, bool GGLDMJEFGCG = false, bool FCGHCIOGMGK = false, bool FAJBOHLHDHO = false)
	{
	}

	private void COJNHADLPDO(BHGGAEEHJCO PCCFIGGEDJL, bool IECLLKLGNME, bool NDLKFPAEAKB, bool JEHCHKOEEPC, uint LPHNICDPDBN)
	{
	}

	public void HideLastKillModel(string PBIHCGFLCHG)
	{
	}

	private void HAFIPILCGKN()
	{
	}

	public virtual void UpdateController(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public void UpdateRightAxisAndDoRotation(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public void UpdateBrightness()
	{
	}

	public override void OnUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private void MHKDCEKOLEN(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public void ClearFlightVisibleShowState()
	{
	}

	private void AIHNCLGCMFC()
	{
	}

	private void GPMGPFLGGAF()
	{
	}

	private void JKGMBMLEBGJ(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private void JNPFEIJPLKK()
	{
	}

	protected void DFNFFFPANCE()
	{
	}

	public virtual void OnPlayerBeTouch()
	{
	}

	public void CapsuleHumanTriggerEnter(Collider GLJGHEAPBOF)
	{
	}

	private void OPGIDAMGHDG()
	{
	}

	public void CapsuleHumanTriggerStay(Collider GLJGHEAPBOF)
	{
	}

	public void CapsuleHumanTriggerExit(Collider GLJGHEAPBOF)
	{
	}

	private bool EPOKJHJJFIP(Collider GLJGHEAPBOF)
	{
		return false;
	}

	private bool GKCOPNILFOH(ref EntityInfo MHMODIFPHBG)
	{
		return false;
	}

	private bool PDLPMIEPKKH(ref EntityInfo MHMODIFPHBG)
	{
		return false;
	}

	public virtual void OnTriggerEnter(Collider GLJGHEAPBOF)
	{
	}

	private void OOCGNLHKPKN(bool KPEAALCEAPN)
	{
	}

	private void OOCGNLHKPKN(bool KPEAALCEAPN, EntityInfo MHMODIFPHBG, Vector3 ANPNKMJMOBP = default(Vector3), GameObject ABDLEENCNDB = null, bool NNKMOJNAANK = false, bool EMJMINHNJNH = false)
	{
	}

	private bool AMIJKGODPFN(List<FEMJPMLIKDF> MLGFIMIGJJH, ref EntityInfo MHMODIFPHBG)
	{
		return false;
	}

	private void KEMDENLHLFJ(EntityInfo MHMODIFPHBG)
	{
	}

	private void IBOIAJCEOHO(EntityInfo MHMODIFPHBG)
	{
	}

	public void ClearCurInPickupTriggers()
	{
	}

	private bool DPMLNMPJHKI(EntityInfo MHMODIFPHBG)
	{
		return false;
	}

	public List<EntityInfo> GetCurInPickupTriggers()
	{
		return null;
	}

	public bool IsCurPickupTrigger(EntityInfo MHMODIFPHBG)
	{
		return false;
	}

	public void ForceExitMusicShooingZone()
	{
	}

	public virtual void OnTriggerExit(Collider GLJGHEAPBOF)
	{
	}

	public void UpdateTriggerBtns()
	{
	}

	public void OnStayInSlider()
	{
	}

	public void OnStayInSlider(Vector3 ANKMNMGLDPN)
	{
	}

	public bool InSlider()
	{
		return false;
	}

	protected void CBCCGIKPIHN(Collider GLJGHEAPBOF)
	{
	}

	protected void IAOGOIFBGDD(Collider GLJGHEAPBOF)
	{
	}

	private void BIJDIDKDPJI()
	{
	}

	private void AMHADAPMKHE(bool IEIMFFPODPC)
	{
	}

	private void JIKDDOLAFPI(bool IEIMFFPODPC)
	{
	}

	protected void DDAHJHKGJCE(EntityInfo GIMDGHDOCJE, Vector3 ANPNKMJMOBP)
	{
	}

	protected void LMNELNGLGHO(EntityInfo GIMDGHDOCJE, Vector3 ANPNKMJMOBP)
	{
	}

	protected void DDNKMCFJLKK(EntityInfo GIMDGHDOCJE, Vector3 ANPNKMJMOBP, GameObject ABDLEENCNDB)
	{
	}

	protected void PMGBMFOLIAO(EntityInfo GIMDGHDOCJE, Vector3 ANPNKMJMOBP, GameObject ABDLEENCNDB)
	{
	}

	public int GetCurInZoneId()
	{
		return 0;
	}

	public virtual bool CanUseAmmoBox()
	{
		return false;
	}

	public bool CanJoinPartyGame()
	{
		return false;
	}

	private void GEMDGADFLBD()
	{
	}

	private void NBNFPEDKMLH()
	{
	}

	private void IIBBJLIHCLH()
	{
	}

	private void HGIMHNCMIGO()
	{
	}

	private void CPEOJGCAFNK()
	{
	}

	private void BDPOBHJMKDA()
	{
	}

	private void DGONAKLGFBP()
	{
	}

	private void JIHJCILBDFF()
	{
	}

	public bool IsInHayric()
	{
		return false;
	}

	private void FIAAPMDLFCP()
	{
	}

	private void MBDCKNCBBBL()
	{
	}

	private void KEOIINBGEGK(INOLNBGACGK MJIFGJPGLAM)
	{
	}

	private void DKOOCAHKFEC()
	{
	}

	public void EnterActionTrigger(EHudActionType CCNBNLAPJFM)
	{
	}

	public void ExitActionTrigger()
	{
	}

	private bool AAJAHIABOEN(bool OAFFCGHMFJP, out ClimbingTrigger PFCBBDKABBN)
	{
		PFCBBDKABBN = null;
		return false;
	}

	private void PLNHFDJJPMA()
	{
	}

	public bool CanPerformCrossOverClimb(bool GLDEJCNDLOI)
	{
		return false;
	}

	private void FJPBEEDPHNI()
	{
	}

	private void JFAKLKJEMAP()
	{
	}

	private void KLMEJNEMMMH(bool OKPLAAFIEFJ)
	{
	}

	public void ExitVehicleTrigger()
	{
	}

	private void DMKAMHKPLMI(OPICPDCLKAG FDJBPCFOEHM, uint ONFPCIABJJC)
	{
	}

	private void ACFONEEMHKG()
	{
	}

	public EntityInfo GetLastenteredVehicleInfo()
	{
		return default(EntityInfo);
	}

	private void ANLBNNPGFOA()
	{
	}

	public void ClearLastEnterVehicleInfoWhenVehicleExplode(EntityInfo MMPBIDFMNCA)
	{
	}

	public virtual bool IsInTrigger()
	{
		return false;
	}

	public bool IsInPickUpTrigger()
	{
		return false;
	}

	public bool IsInEntityTriggerIncludingPending(uint LIPAANMDBGM, uint OJANLPFFBOC, uint KDAPDDEJJGF)
	{
		return false;
	}

	public bool IsInTriggerIncludingPendingTrigger(EntityInfo MHMODIFPHBG)
	{
		return false;
	}

	public FEMJPMLIKDF GetTriggerEntityInfoDetailed(EntityInfo MHMODIFPHBG)
	{
		return null;
	}

	private bool INNNBLOBCBE(EntityInfo MHMODIFPHBG)
	{
		return false;
	}

	public void StopUsingItemOnHand()
	{
	}

	public NAELPAAELNO GetItemOnHand()
	{
		return null;
	}

	public bool HasThrowingKnifeBROnHand()
	{
		return false;
	}

	public int GetThrowingKnifeLegMountCount()
	{
		return 0;
	}

	public NAELPAAELNO GetRealItemOnHand()
	{
		return null;
	}

	public UserControlHandler GetUserControlHandler()
	{
		return null;
	}

	public override void OnFixedUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public bool IsGrounded()
	{
		return false;
	}

	public bool IsGroundedByRayCastHit()
	{
		return false;
	}

	public virtual void UpdateAI(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public virtual void UpdateBehavior(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public virtual void UpdateBehaviorOutOfControl(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	protected virtual void PIEJNJKMGEK()
	{
	}

	protected virtual void PLNLCOPDKLK()
	{
	}

	protected void ECCINPKFDOO(bool OAKJCJHDDCM = false)
	{
	}

	public void ForceStopEmotionForCabinWaiting()
	{
	}

	private void AAJNJHMEOID()
	{
	}

	protected void HGPNECDGCNI()
	{
	}

	public virtual void UpdateKinematics(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private void MAFKOGDDELI(bool AGGDHMPEHCO, float HOGHEFNINAE)
	{
	}

	protected void EMJBKGALGNL(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public bool IsMoving()
	{
		return false;
	}

	public bool IsHorizontalMoving()
	{
		return false;
	}

	private void LEPGLINBHMN(bool BFMNKNJMJHF)
	{
	}

	protected bool EFPAMMPLMKK(Vector3 CLJFDCLGOLA)
	{
		return false;
	}

	private void LateUpdate()
	{
	}

	protected void BKPJJAPJFKA()
	{
	}

	private void GGFDJOBDAPM()
	{
	}

	private void FMJNBPDHFFJ()
	{
	}

	private void EPNKGANCBNH(bool AEAPKEDNBGK)
	{
	}

	protected bool JAAKHCEEAOH()
	{
		return false;
	}

	public bool LastInFrustum()
	{
		return false;
	}

	protected void AAECAEDBNCN()
	{
	}

	protected void IEAHANOCJCH()
	{
	}

	protected bool OHECFAGIAFC(Transform PABPNBEEHLI, bool PKFOKOJDLFH = false, float HMCGBNGHNFP = 0f, float EEDOKPPHMDJ = 0f, bool DLMPCMGCHPP = false)
	{
		return false;
	}

	protected void OMNMMMBGIBH(Transform PABPNBEEHLI, float HMCGBNGHNFP = 0f, float EEDOKPPHMDJ = 0f, bool IPEKEDBOHFC = false)
	{
	}

	protected virtual bool ELKCJDJKOJG()
	{
		return false;
	}

	public virtual bool InKnockRevivedSafeTime()
	{
		return false;
	}

	protected virtual void HLGHCAFHBGD()
	{
	}

	private void HJJILOJMICP(float HOGHEFNINAE, out bool POGFBIPEGPM, out float IBPJBLPCANO)
	{
		POGFBIPEGPM = default(bool);
		IBPJBLPCANO = default(float);
	}

	public virtual void PostUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public void UpdateKnockdownIsInCamera()
	{
	}

	public void ShowPinKillerBtn(float HFMNEBDBFEL)
	{
	}

	protected virtual void FFHPNNBIDAP()
	{
	}

	public void ForceUpdateRotation()
	{
	}

	private void GPFMCMHMHKO(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private float MNOFFAOCEJH(Vector3 BEMGKIDFMHF, float FOFLDNIDBCC)
	{
		return 0f;
	}

	private float KGADGJLLCGM(Vector3 BEMGKIDFMHF, float FOFLDNIDBCC)
	{
		return 0f;
	}

	public virtual void OnLandFinsish()
	{
	}

	public bool IsMeleeFiring()
	{
		return false;
	}

	public virtual void OnFaithFallingLandFinsish()
	{
	}

	public void SetHayrickOrigin(LevelHayrickOrigin GKBPENKPIGD)
	{
	}

	public bool IsTargetFriend(OKEAMEELLBB PFJFADHEJLJ)
	{
		return false;
	}

	protected virtual bool LNGHMIHPOAH(OKEAMEELLBB PFJFADHEJLJ)
	{
		return false;
	}

	public Quaternion GetAimRotation()
	{
		return default(Quaternion);
	}

	public Quaternion GetAuxAimRotation()
	{
		return default(Quaternion);
	}

	public void ResetAuxAimRotation()
	{
	}

	public void OnGamePaused(bool DFIOPCMNHAD)
	{
	}

	public virtual void PauseAnimator()
	{
	}

	public bool HasHeuristicTarget()
	{
		return false;
	}

	public bool HeuristicTargetIsFriend()
	{
		return false;
	}

	public OKEAMEELLBB GetHeuristicTarget()
	{
		return null;
	}

	public float GetHeuristicTargetInfoScore()
	{
		return 0f;
	}

	public Vector3 GetWeaponTraceStartPos()
	{
		return default(Vector3);
	}

	private static bool JIOBPODHLMB(NFDDMKNPIBC FLGJDIHNCPI, NFDDMKNPIBC CDGBFCEJGKJ)
	{
		return false;
	}

	public virtual void UpdateAiming(float OKJIFBCMDAD, float HOGHEFNINAE, bool KPDCILHJOBF = false)
	{
	}

	private bool CLGFALJMFED()
	{
		return false;
	}

	public bool IsAmimingSelfGunShield(Collider NPEMKNFIIHL)
	{
		return false;
	}

	public bool IsAimmingViewBlockTransparent(Collider NPEMKNFIIHL)
	{
		return false;
	}

	public bool IsAmimingSelfVehicleShield(Collider NPEMKNFIIHL)
	{
		return false;
	}

	public bool IsAmimingLevelSpaceShield(Collider NPEMKNFIIHL)
	{
		return false;
	}

	public override void TakeDamage(GLLLEDKLLDA PMMCGNJHOOA, LOAEBBHPMEK AOJANNHGCEA = null, List<float> LFLPGCMLPFM = null, uint FKDEIFDNMJD = 0u)
	{
	}

	public virtual int TakeDamage(int PMNNBDDKCCE, BHGGAEEHJCO FNOOENEHBJP, GLLLEDKLLDA PMMCGNJHOOA = null, int HPPACPHIPCP = -1, Vector3 BAAJEMEJACH = default(Vector3), Vector3 KHNFEFFKMEB = default(Vector3), List<float> LFLPGCMLPFM = null, LOAEBBHPMEK AOJANNHGCEA = null, uint FKDEIFDNMJD = 0u)
	{
		return 0;
	}

	protected int BNLIKKEGAON(int PMNNBDDKCCE, BHGGAEEHJCO FNOOENEHBJP, out int KKLDOJNGMFD, GLLLEDKLLDA PMMCGNJHOOA = null, int HPPACPHIPCP = -1, Vector3 BAAJEMEJACH = default(Vector3), Vector3 KHNFEFFKMEB = default(Vector3), List<float> LFLPGCMLPFM = null, LOAEBBHPMEK AOJANNHGCEA = null, uint FKDEIFDNMJD = 0u)
	{
		KKLDOJNGMFD = default(int);
		return 0;
	}

	private void HBEMANHKOKM(Player DCAPIHJMMBL, BHGGAEEHJCO FNOOENEHBJP)
	{
	}

	private void NANCCNODKCK(bool LNPJFGOCHII)
	{
	}

	public void Cache3pResInRange()
	{
	}

	public override void TakeHealing(DLOFHLEHHNP LDOJBPIKBIK, List<float> LFLPGCMLPFM = null)
	{
	}

	private static bool HFCHBAOOLGA(byte CBCAJJJCKLH)
	{
		return false;
	}

	public void ShowFireInfoInMap(byte CBCAJJJCKLH)
	{
	}

	public void PlaySpeedRoyalBGM(int HPPACPHIPCP)
	{
	}

	public virtual void PlayFireEffect(FDAEPHMIEPC KEDHIAANLGO)
	{
	}

	public virtual void PlayMeleeEnergyChargeAnimation(FDAEPHMIEPC KEDHIAANLGO)
	{
	}

	public void OnMeleeEnergyAttackRateChange(float JAMCOPNBGFD)
	{
	}

	public void ClearMeleeEnergyEffect()
	{
	}

	public virtual void PlayMeleeEnergyEndAnimation()
	{
	}

	public virtual void PlayMeleeEnergyAttackAnimation(FDAEPHMIEPC KEDHIAANLGO)
	{
	}

	public virtual void PlayCureAnimation(bool AOGGADPEFCC)
	{
	}

	private void APNNFMBKMKC(bool AOGGADPEFCC)
	{
	}

	public virtual void PlayMushRoomAnimation(bool AOGGADPEFCC)
	{
	}

	public virtual void PlayRepairingAnimation(bool AOGGADPEFCC)
	{
	}

	public virtual void PlaySummoningAnimation(bool AOGGADPEFCC, float PBIHCGFLCHG = 0f)
	{
	}

	public virtual void PlayBombAnimation(bool AOGGADPEFCC, bool MMDMAKHCBCD = true, float EEEGJEKFGFH = 0f)
	{
	}

	public void PlayADSTeleportAnimation()
	{
	}

	public void ShowADSPortalEffect(bool EOGOGFLCEHL, CNIGGEPKEFD MGGNLEEAPEP)
	{
	}

	public void ShowADSBodyEffect(bool EOGOGFLCEHL)
	{
	}

	public void ShowADSWinBuffEffect(bool EOGOGFLCEHL)
	{
	}

	private GameObject BPIOOOMEHCH(CNIGGEPKEFD MGGNLEEAPEP)
	{
		return null;
	}

	private void EDHBOMLFDOG(uint JDHNCLHNJIP, ResourceID JMIMKLAELHE, GameObject KGJNMPHDKAB, float PCKBJNOLGEJ)
	{
	}

	public void PlayUsePacemakerAnimation(bool AOGGADPEFCC, uint GEHJJDLAGJJ = 0u)
	{
	}

	public void CreatePacemakerInAnim()
	{
	}

	public void ClearPacemaker()
	{
	}

	private void LBHPCBNBEJH()
	{
	}

	public void PlaySelfRescureGetUpEffect()
	{
	}

	protected void JLAPKGEGAFK()
	{
	}

	protected void DDOPBHLMCBL(EAFGOABMIJP CEAJJKEEPMF, float PCKBJNOLGEJ)
	{
	}

	public void SyncStopBeingRescued()
	{
	}

	private void KAJPOOKJKPK()
	{
	}

	private void JCMMEBHCMCD()
	{
	}

	public void PlayShootMusicTarget()
	{
	}

	public void ResetPlayerRescureReason()
	{
	}

	public virtual void PlayPreparationAnimation(bool AOGGADPEFCC, EPreparationTimerType CCNBNLAPJFM)
	{
	}

	public void PlayRMDEatFoodAnimation(bool AOGGADPEFCC, int ALFFOBPHKBI)
	{
	}

	public bool IsRMDEatingFood()
	{
		return false;
	}

	public bool IsOpenTreasureHunt()
	{
		return false;
	}

	public void ShowFoodAndSpoon(bool AOGGADPEFCC)
	{
	}

	private void PCNNDDPFLKB(uint HMEEAGECFIO, ResourceID OCCLMDNGINA, GameObject KGJNMPHDKAB)
	{
	}

	public void PlayPEDAnimation(bool AOGGADPEFCC)
	{
	}

	public virtual void StartFiring(FDAEPHMIEPC KEDHIAANLGO)
	{
	}

	protected void KBMCFFJLBBJ()
	{
	}

	public virtual void StartWholeBodyFiring(FDAEPHMIEPC KEDHIAANLGO)
	{
	}

	public virtual void StartWarmUp(FDAEPHMIEPC KEDHIAANLGO)
	{
	}

	public virtual void StopFire(FDAEPHMIEPC KEDHIAANLGO)
	{
	}

	public void OnReloadingNoBullet(FDAEPHMIEPC KEDHIAANLGO)
	{
	}

	public virtual void StopCharge(FDAEPHMIEPC KEDHIAANLGO)
	{
	}

	public List<FBBGNEHEECB> GetOccupationContinueHitInfo()
	{
		return null;
	}

	public virtual void OnExpansionAblityEnd()
	{
	}

	public virtual bool GetSightingState()
	{
		return false;
	}

	public EJNFNOJNCPE GetWeaponSightingAttachmentData()
	{
		return null;
	}

	public virtual bool IsSightingUIAvailable()
	{
		return false;
	}

	public void OnAnimationVisibilityChanged(int KFDNCIOCFAA)
	{
	}

	public void OnAnimEvent(INAHABPJKFG DNNNJDJIBMP, object[] KFDNCIOCFAA)
	{
	}

	private void FBLGAAFMEDG()
	{
	}

	private void HMIODKOOCPP()
	{
	}

	public void UpdateWeaponActiveOnProptertyVisiblityChange(bool NIPCALFAJKB)
	{
	}

	private void NMEAFCCDKKC(bool BIDKKABBNJF)
	{
	}

	public void OnChangeWeaponFinished()
	{
	}

	private void MBFCJDNEOEJ(bool PKDNLNJBKDK)
	{
	}

	public void OnSightingUIStateChange(bool BNEEMDFEMDB, float HFPLKBHDHJJ)
	{
	}

	public virtual void SwapWeapon(int GCIIEDANPOA, bool MIBDIFEEABJ = false, List<int> EOGKJGMGCAN = null)
	{
	}

	private bool JPDKIKPCBKA(HDAEFOANBGJ AINKPKJFFFP, NAELPAAELNO PPFBJKMHKGC)
	{
		return false;
	}

	public void AutoSwitchWeapon(bool MBJLIMJAKPB = false, bool MAJLHPBFKJM = false)
	{
	}

	private bool MNCJDGGPKIC()
	{
		return false;
	}

	public virtual void SwapWeapon(HDAEFOANBGJ AINKPKJFFFP, bool MIBDIFEEABJ = false)
	{
	}

	private void JOJDEHFJAFE(HDAEFOANBGJ AINKPKJFFFP)
	{
	}

	public virtual void ReloadWeapon()
	{
	}

	public virtual void FullWeaponAmmo()
	{
	}

	public virtual void OnGrenadeStartFire()
	{
	}

	public virtual void OnGrenadeEndFire()
	{
	}

	public virtual void OnIceWallStartFire()
	{
	}

	public virtual void OnThrowKnifeStartFire()
	{
	}

	public virtual void OnThrowKnifeEndFire()
	{
	}

	public virtual void OnGrenadeQuitFire()
	{
	}

	public virtual void OnBeginPutDown()
	{
	}

	public virtual void OnWeaponLift(bool DKLNGCHAKOJ = false)
	{
	}

	public virtual void OnWeaponPutDown()
	{
	}

	public virtual void OnWeaponReloadImmediateStarted(float ABPKDCKICLA, bool BOJIDHIFINO = false)
	{
	}

	public virtual void OnWeaponReloadImmediateFinished(bool NMLHNDMIOOD)
	{
	}

	public virtual void OnWeaponReloadSpeedChanged(float NKNNPEMLIGD)
	{
	}

	public virtual void OnWeaponReloadStarted(float ABPKDCKICLA, bool BOJIDHIFINO = false)
	{
	}

	public virtual void OnWeaponReloadFinished(bool NMLHNDMIOOD)
	{
	}

	public void OnWeaponReloadDone(bool KPDCILHJOBF)
	{
	}

	public void PlayReloadAnim(float ABPKDCKICLA)
	{
	}

	public void OnWeaponSegmentReloadDone(bool KPDCILHJOBF)
	{
	}

	public bool IsReloading()
	{
		return false;
	}

	public bool IsFireButtonHoldWhenReLoad()
	{
		return false;
	}

	public virtual void OnRiflePullBoltStarted(float ABPKDCKICLA)
	{
	}

	public virtual void OnRiflePullBoltFinished()
	{
	}

	public virtual void OnSniperPullBoltStarted(float ABPKDCKICLA)
	{
	}

	public virtual void OnSniperPullBoltFinished()
	{
	}

	public void OnSniperPullBoltDone()
	{
	}

	public void PlayChangeWeaponSoundInternal()
	{
	}

	protected bool FDCADJAOHAO()
	{
		return false;
	}

	public void StartJumpOffAirTransporter()
	{
	}

	public void SetLobbySocialDisplayVisible(bool KGOHDEBHENF)
	{
	}

	private void IHINDFIEFML()
	{
	}

	private IEnumerator LJEAMBFHKGI()
	{
		return null;
	}

	private void EDDJFMDCACB()
	{
	}

	private IEnumerator LDOHPHKAGCD()
	{
		return null;
	}

	private void JJDLMOOFJFG(Animator EEBGPAJFKNF, FlightData LIHNBGOGPAH, PreviewTeamFlightView HOECOJGCDOG = null)
	{
	}

	private void BGPLPPIFCIH(PlayableDirector FDCEPOENMJP)
	{
	}

	private void CGLNFAKPEPC()
	{
	}

	private void LMHNBGGKJHN()
	{
	}

	private void BOOEJKLMIAM(bool HDELNANGAON = true)
	{
	}

	private void GIHICMIMGEH(PreviewTeamFlightView HOECOJGCDOG = null, bool JDJAIODFHLP = true, FlightData LIHNBGOGPAH = null)
	{
	}

	private IEnumerator AJDNLAJPAAO(PreviewTeamFlightView HOECOJGCDOG, FlightData LIHNBGOGPAH)
	{
		return null;
	}

	private void NOPBLOCOOCL(bool AOOAGBBHDFA)
	{
	}

	protected void OCIOONOOIAE(IGJPHDANPJD EPOOCGNJOFD)
	{
	}

	private void BIFCDHOOEFH()
	{
	}

	private void OOLCNDCFCLB()
	{
	}

	private IEnumerator CGFPPLEKFLL()
	{
		return null;
	}

	private void AEIFDFJNMOG()
	{
	}

	protected void IHNDBAHCFMA()
	{
	}

	public void PlayOnBoardTutorial()
	{
	}

	protected void JCIPPAFLOEF()
	{
	}

	public void ProcessSkySpeedLeftEffect(uint BKMGJGJBDBL, ResourceID CCGDPCAOHOF, GameObject MPKIKBJJBIK)
	{
	}

	public void ProcessSkySpeedRightEffect(uint DGBODMPJJEJ, ResourceID KBADJAJKBLP, GameObject CFBBLIDIBOE)
	{
	}

	public void EquipFlight()
	{
	}

	public void UnEquipFlight()
	{
	}

	private void GEPODIIDGOJ()
	{
	}

	protected virtual void OOPEJACAOJA()
	{
	}

	public bool IsDrivingFlight()
	{
		return false;
	}

	private VisualEffectLoadMethod ANPDPEFDFOI()
	{
		return VisualEffectLoadMethod.None;
	}

	private VisualEffectLoadMethod CPOELOGMBLB()
	{
		return VisualEffectLoadMethod.None;
	}

	private bool MNGAKDGKCPO()
	{
		return false;
	}

	private bool GEDEPLNAMGG()
	{
		return false;
	}

	private bool DEOJPJNPHGO()
	{
		return false;
	}

	protected void CODJKGDAPLL()
	{
	}

	private void DMIDDMEDOFD()
	{
	}

	private void CDONOOGCLCF(uint JDHNCLHNJIP, ResourceID AKANMDDBKBP, GameObject KGJNMPHDKAB)
	{
	}

	public void PlayFlightLandAnimEffect()
	{
	}

	private void EONJJOJJFOF(uint JDHNCLHNJIP, ResourceID AKANMDDBKBP, GameObject KGJNMPHDKAB)
	{
	}

	protected void JIOFAKNFKMK()
	{
	}

	protected void DMHBOEFMOIA(bool LPBPBKGNBKA = true)
	{
	}

	private void JAHMIOBPNFI()
	{
	}

	protected void HMMHKMNJKNK()
	{
	}

	public void StartSkyDiving()
	{
	}

	private void JIBNNGCGADH()
	{
	}

	private void HNMFNLNJKHE()
	{
	}

	public void TryRefreshNBEventEffect()
	{
	}

	private void OMHONPEJMFN()
	{
	}

	public void ClearSkyDivingVFX()
	{
	}

	public bool HasUseEagleSkill()
	{
		return false;
	}

	public bool HasOwnEagleSkill()
	{
		return false;
	}

	private void EBKPJABDIIL()
	{
	}

	public virtual float GetExtraSpeed()
	{
		return 0f;
	}

	private void OACMNCIEJMN()
	{
	}

	public void StopParachuting(bool NAIBMHHMJMH = true)
	{
	}

	private void KIEOOLGPFMG()
	{
	}

	private void FKHJBDCLDIE()
	{
	}

	private void FIELHLELJND()
	{
	}

	protected void LAJLPKFEOJL()
	{
	}

	private bool GIJBEGNBFMC()
	{
		return false;
	}

	private void KEBNPPAEPKB()
	{
	}

	private void IAGMNBNFNDK()
	{
	}

	public void StartParachuting()
	{
	}

	private void BGKLGEEEAIC(uint JDHNCLHNJIP, ResourceID GGMIDNEJGNO, GameObject KGJNMPHDKAB)
	{
	}

	private void KGLJEAEOBOM(uint JDHNCLHNJIP, ResourceID GGMIDNEJGNO)
	{
	}

	public void OnParachuteSkinResCallBack(uint GGAOIPIHOBP, bool BBPCHCNOECP, UnityEngine.Object HACIJIFIDKM)
	{
	}

	public void OnParachuteSkinResCallBackEmpty(uint GGAOIPIHOBP, bool BBPCHCNOECP, UnityEngine.Object KMOGBCDKPBI)
	{
	}

	private void KNMEEFCFKMI()
	{
	}

	public void PlayHypeFireEffect(int KLBCAKEGHLN, int KIOIALGJBNJ = -1)
	{
	}

	private void EKKNMIOELFD()
	{
	}

	protected void IBOEOEDCOAP(int KIOIALGJBNJ, int MDLKEENGELE)
	{
	}

	public virtual void BeforeSwitchAnimController(bool FDGIGIAPGCB = false)
	{
	}

	public virtual void SwitchAnimController()
	{
	}

	public void SetAsDriver()
	{
	}

	public virtual void PlayChangeVehicleSeatAnimation(bool OJEENJNFAFG)
	{
	}

	public void ShowBagPack()
	{
	}

	public void HideBagPack()
	{
	}

	public virtual void OnSwitchWeaponSkin(uint ABINGMDHKJD, uint CJCOBKDPFEB)
	{
	}

	public virtual void OnWeaponAnimFireEffect()
	{
	}

	public void OnStartChangeWeapon(FDAEPHMIEPC PJMDKPKBBAM, float OIKEPMFFBNO = 1f)
	{
	}

	public virtual void ResizeSniperFireCollider(float IFDHHGECCCM, float NMEEAHMNACE, float ACKFAKHNEHA = -1f, bool DOJMKMJFBMI = false)
	{
	}

	public virtual void ResizeCapsuleCollider(float IFDHHGECCCM, float NMEEAHMNACE = -1f, float JJIAFNNDEFP = 0f, float JDLBJHACCAD = 0f)
	{
	}

	protected void HFODDGLDPOC(bool DNNNJDJIBMP)
	{
	}

	public void OnFireModeChanged(bool AAGJEPCBKOO)
	{
	}

	public void SetAimAssistIceWallParams(float HFKDMBCBNEL, float BBIJGHJBHDH, Vector4 FGCBGGGDGJD, Vector4 OGHOCGAFMHG)
	{
	}

	public void OnThrowSkillCrossHairFireBegin(bool MKOIBBGGOHH)
	{
	}

	public virtual Transform GetHeadTF()
	{
		return null;
	}

	public virtual Transform GetHipTF()
	{
		return null;
	}

	protected virtual Vector3 HEPDPEHIINF()
	{
		return default(Vector3);
	}

	public virtual Transform GetLeftAnkleTF()
	{
		return null;
	}

	public virtual Transform GetRightAnkleTF()
	{
		return null;
	}

	public virtual Transform GetLeftToeTF()
	{
		return null;
	}

	public virtual Transform GetRightToeTF()
	{
		return null;
	}

	public virtual Vector3 GetCharacterControllerTopPosition()
	{
		return default(Vector3);
	}

	public float GetCharacterHeight()
	{
		return 0f;
	}

	public float GetCharacterCenterY()
	{
		return 0f;
	}

	private OKEAMEELLBB KNBEPECEJEP(GMPGMPFNMFP NFODGJEILKL = null)
	{
		return null;
	}

	public int GetWeaponZoomAmplifier()
	{
		return 0;
	}

	protected Vector3 GMJBBLKJJBM(float JAMCOPNBGFD = 1f)
	{
		return default(Vector3);
	}

	public float GetAimAssisYSensitivity(FDAEPHMIEPC PJMDKPKBBAM)
	{
		return 0f;
	}

	public float GetAimAssistDampCoefficient(FDAEPHMIEPC PJMDKPKBBAM)
	{
		return 0f;
	}

	public virtual bool RequestRescureTarget(BHGGAEEHJCO PFJFADHEJLJ)
	{
		return false;
	}

	public virtual bool RequestStopResure()
	{
		return false;
	}

	protected void MIPHDJJPOCP()
	{
	}

	public bool CheckCanUseIIVTeleportDoor()
	{
		return false;
	}

	public void RequestUseIIVTeleportDoor(uint ONFPCIABJJC)
	{
	}

	public void RequestUsePOIMission(uint LIKPJDHGPFG)
	{
	}

	public void RequestUseTeleportDoor(uint ONFPCIABJJC, bool NAEFFDFFKBF = false)
	{
	}

	private void KFILGPLHBHO(LevelTeleportDoor FMBDOFBIDKF, uint ONFPCIABJJC)
	{
	}

	public bool CheckCanUseTeleportDoor()
	{
		return false;
	}

	public bool CheckCanUseFerrisWheel()
	{
		return false;
	}

	public bool CheckCanUnlockBountyVehicle()
	{
		return false;
	}

	public virtual void RequestPlayEmote4Plant(OPICPDCLKAG FDJBPCFOEHM, uint ONFPCIABJJC)
	{
	}

	public virtual void RequestStoreInWareHouse(uint ONFPCIABJJC)
	{
	}

	public virtual void RequestStopStoringInWarehouse()
	{
	}

	public virtual void RequestOpenTreasury()
	{
	}

	public virtual void RequestOpenTimingTreasureBox()
	{
	}

	public virtual void RequestHayrickJump()
	{
	}

	public virtual void DoSquareDancingTriggerAction()
	{
	}

	public virtual void LocalStopSquareDancing()
	{
	}

	public void ActionEnergyDeviceBatteryAward(uint BHLPPNDJKGB)
	{
	}

	public void ActionEnergyDeviceBattery(uint BHLPPNDJKGB)
	{
	}

	private IEnumerator CACKOIHPMKF(uint BHLPPNDJKGB)
	{
		return null;
	}

	public void NBEatNoodle()
	{
	}

	private IEnumerator DEMHKLECCNK()
	{
		return null;
	}

	public void SeafoodEatCookie()
	{
	}

	private IEnumerator LHLCFMANADC()
	{
		return null;
	}

	public void EatInfiniteCake(uint FOGNPDBNBDK)
	{
	}

	private IEnumerator PMPAALIGJOP(uint FOGNPDBNBDK)
	{
		return null;
	}

	public void ActionWinterLandDeer(uint KFMPAFHIGPF)
	{
	}

	private IEnumerator NKKLFHAKCEP(uint KFMPAFHIGPF)
	{
		return null;
	}

	public void LocalStartSquareDancing(uint PJMMDOONDOP)
	{
	}

	public virtual void RequestStopEmote4Plant()
	{
	}

	public virtual void StopPlayEmotion()
	{
	}

	public virtual void RequestSyncStopEmotion(bool IDNOLMLDNEC = false)
	{
	}

	public virtual void StopEmote4Plant()
	{
	}

	public void RequestEnterMusicShootZone(uint LIKPJDHGPFG)
	{
	}

	public void RequestEnterSoloDance()
	{
	}

	public void RequestSoloDanceReady()
	{
	}

	public void RequestQuitSoloDance()
	{
	}

	public void RequestInviteSoloDanceOpponent(bool JAMMHHLKFOI)
	{
	}

	public void RequestExitMusicShootZone(uint LIKPJDHGPFG, bool PIDINBNGILH = false)
	{
	}

	public virtual void RequestOpenRangeShop(uint ONFPCIABJJC)
	{
	}

	public virtual void RequestPray4EscortBoss(uint ONFPCIABJJC)
	{
	}

	public virtual void RequestStopPraying4EscortBoss()
	{
	}

	public virtual void OnEscortBossStatusChanged()
	{
	}

	public virtual void RequestGetOnFerrisWheel()
	{
	}

	public virtual void ResponseTeamGatherPointReq(bool EKNACOEIKID)
	{
	}

	public virtual void RequestUseTeamGatherPoint()
	{
	}

	public virtual bool CheckCanUseTeamGatherPoint()
	{
		return false;
	}

	public virtual bool CheckTeamGatherPointIAmInCanUse()
	{
		return false;
	}

	public virtual bool CheckTeamGatherCanUse(Vector3 LODPGLHMCMG)
	{
		return false;
	}

	public virtual void RequestUnlockBountyVehicle()
	{
	}

	public virtual bool CheckCanOpenBountyBox()
	{
		return false;
	}

	public virtual bool CheckCanOpenWeRunBox()
	{
		return false;
	}

	public virtual void RequestGetOffFerrisWheel()
	{
	}

	public void RequestEnterServerMiniGame(uint NLOEFFKKLFP)
	{
	}

	public void RequestGiveSnowball(uint PPIKHKAFBHL)
	{
	}

	public bool CanWeaponCombine(FDAEPHMIEPC NOCOHCIDAAM)
	{
		return false;
	}

	public virtual void DoUpdateActionState(EAcationState LIJCJHEAOOK, EPreparationTimerType NDMAKMHCKLG, float CNKMEPFCJOM, object[] KHDEFOMIAPK)
	{
	}

	public void MountWeaponGameObject(FDAEPHMIEPC PJMDKPKBBAM, bool FEMIBFLGFOO)
	{
	}

	public void MountWeaponGameObject(FDAEPHMIEPC PJMDKPKBBAM)
	{
	}

	public void SetQTEWeaponToTransform(FDAEPHMIEPC PJMDKPKBBAM, string NHOIOJOCMHD)
	{
	}

	public bool IsFreeMove()
	{
		return false;
	}

	public bool IsFiring()
	{
		return false;
	}

	public bool IsInExpansionAbility()
	{
		return false;
	}

	public bool IsWeaponInAutoCharge()
	{
		return false;
	}

	public bool IsHoldingFireForSingleShot()
	{
		return false;
	}

	public bool IsHoldingFireForUAV()
	{
		return false;
	}

	public bool IsSniperPullingBolt()
	{
		return false;
	}

	public bool IsHiraishinOnHand()
	{
		return false;
	}

	public FDAEPHMIEPC.DBENAPILEBC GetWeaponType()
	{
		return FDAEPHMIEPC.DBENAPILEBC.Rifle;
	}

	public int GetWeaponSubType()
	{
		return 0;
	}

	public void ExitTriggers(bool FIPKLFCJOLI = true, bool DPPOOBNGILH = true)
	{
	}

	public void ExitPickupTriggers()
	{
	}

	public virtual void OnGetOnFerrisWheel(LevelFerrisWheel OPFDOJNODPD, byte ABHFDDCCINN, byte JALHHJFCJAF)
	{
	}

	public virtual void OnGetOffFerrisWheel(byte ABHFDDCCINN, byte JALHHJFCJAF)
	{
	}

	protected void FKIKGEOKAAI()
	{
	}

	public virtual void OnGetOnVehicle(Vehicle FKJMCGEFJMD)
	{
	}

	public bool GetOffVehiclePosition(out Vector3 JCBLFKODBPG, Vehicle BDOHBLAGHNH = null)
	{
		JCBLFKODBPG = default(Vector3);
		return false;
	}

	public Vector3 GetOffChairPosition()
	{
		return default(Vector3);
	}

	public Vector3 GetOffSeesawPosition()
	{
		return default(Vector3);
	}

	public void OnLeaderPosChange(float HOGHEFNINAE)
	{
	}

	public virtual void OnGetOffVehicle()
	{
	}

	public bool GetOnStropPrecheck()
	{
		return false;
	}

	public virtual void OnGetOnStrop(LevelStrop GONAGLKKLHI, float CECGLOHKLLL, float OJILKICMMLJ, bool KHGMJLNHLLI)
	{
	}

	private void PDNHKIKMMDG()
	{
	}

	private bool JMMONMIHCAA()
	{
		return false;
	}

	public void OnStropRingGOCallBack(uint PLNDNBINKOA, ResourceID CICBIIJABAP, GameObject CLACOPMJHDI)
	{
	}

	private void FDHGHBBLHOK(uint PLNDNBINKOA, ResourceID CICBIIJABAP, GameObject CLACOPMJHDI)
	{
	}

	public virtual void OnGetOffStrop(float DDAANEFLPHH)
	{
	}

	protected void KHBCMOBLIBJ()
	{
	}

	public void SceneEditUpdateTransform()
	{
	}

	public void SceneEditDisablePlayer()
	{
	}

	public void SceneEditEnablePlayer()
	{
	}

	public void OnSceneEditPutDown()
	{
	}

	private void FJMJAAFDCHJ()
	{
	}

	public bool HasGrapplingHook()
	{
		return false;
	}

	public bool HasVMEHook()
	{
		return false;
	}

	public bool HasHook()
	{
		return false;
	}

	public bool IsOnGrapplingHook()
	{
		return false;
	}

	public bool IsOnHook()
	{
		return false;
	}

	public bool IsOnVMEHook()
	{
		return false;
	}

	public void OnGrapplingHookSpawned(LevelGrapplingHook DHHIKKKJJOO)
	{
	}

	public void OnGrapplingHookHooked()
	{
	}

	public void OnGrapplingHookDestroyed()
	{
	}

	public void GetOffGrapplingHook()
	{
	}

	public void OnGrapplingHookReEnter(Vector3 BMNLHFJNCLK)
	{
	}

	public void StartOnGrapplingHook()
	{
	}

	public void StopOnGrapplingHook()
	{
	}

	public void AddGrapplingHookGunEfeect(bool FEOOOJDHCDE)
	{
	}

	public bool HasSwingSpider()
	{
		return false;
	}

	public bool IsOnSwing()
	{
		return false;
	}

	public void OnSwingSpiderSpawned(LevelSwingSpider OECCJNCEJCI)
	{
	}

	public void OnSwingSpiderAttached()
	{
	}

	public void OnSwingSpiderDestroyed()
	{
	}

	public void GetOffSwingSpider(bool DJNHLJOEFBI = true)
	{
	}

	public void OnSwingSpiderReEnter(Vector3 BMNLHFJNCLK)
	{
	}

	public void StartOnSwingSpider()
	{
	}

	public void StopOnSwingSpider()
	{
	}

	public void AddSwingGunEffect(bool FEOOOJDHCDE)
	{
	}

	public void OnStartSprint()
	{
	}

	public void OnFinishSprint()
	{
	}

	public void OnStartFaithJuming()
	{
	}

	public void StartFaithJumping()
	{
	}

	public void OnFaithJumpingLand()
	{
	}

	public void StopFaithJumping()
	{
	}

	public void OnReusableObjectRecycled(ResourceID KIOJBPDOGCH, GameObject HACIJIFIDKM)
	{
	}

	private void IPDECCFGJBP()
	{
	}

	private void JOLAAJMNICH()
	{
	}

	public void StartJumpOffStrop(bool FEICDAFBJFK)
	{
	}

	public void SwitchStrop()
	{
	}

	public void StropDash()
	{
	}

	public bool IsFalling()
	{
		return false;
	}

	public bool IsOnStrop()
	{
		return false;
	}

	public bool IsOnRailStrop()
	{
		return false;
	}

	public bool DisableFireOnStrop()
	{
		return false;
	}

	public bool IsAbleToSwitchStrop()
	{
		return false;
	}

	public bool IsStropState()
	{
		return false;
	}

	public bool IsOnChair()
	{
		return false;
	}

	public bool IsOnSeesaw()
	{
		return false;
	}

	public FerrisWheelSeatGroup GetFerrisTriggerIAmIn()
	{
		return null;
	}

	public LevelStrop GetStropIAmOn()
	{
		return null;
	}

	public bool IsInVehicle()
	{
		return false;
	}

	public Vehicle GetVehicleIAmIn()
	{
		return null;
	}

	public bool IsInVehicleOrHelicopter()
	{
		return false;
	}

	public Vehicle GetVehicleOrHelicopterIAmIn()
	{
		return null;
	}

	public bool IsInHelicopter(bool NINOLMNLNII)
	{
		return false;
	}

	public void ApplyVechileControl(FDDEPNLACNI JIHJLBFECCO, Vector3 EEOKDLOLOOB)
	{
	}

	public List<Vector3> GetBoundingBoxList()
	{
		return null;
	}

	protected override void OnUpdateVisibleStateByStreamer(Vector3 MHAAFMCMHAC, Vector3 PAFBAHJAAGC)
	{
	}

	public void RegisterDynamicPVS()
	{
	}

	public void UnRegisterDynamicPVS()
	{
	}

	private void GOBEOOJICKB(bool KGOHDEBHENF)
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

	public virtual Vector3 GetCameraTrackableEntityTopPosition()
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

	public virtual bool IsOutOfControl()
	{
		return false;
	}

	public virtual bool IsLocalPlayerOutOfControlNeedUpdataAimRotaion()
	{
		return false;
	}

	public virtual bool NeedTickWhenDead()
	{
		return false;
	}

	public void SetDriverSteeringAngle(float PCOPDDLBLMI)
	{
	}

	public void SetHasDriverForAim(float PCOPDDLBLMI)
	{
	}

	private ResourceID PEBJMCAOMJF()
	{
		return default(ResourceID);
	}

	public bool HasCustomAnimation()
	{
		return false;
	}

	public virtual bool RequestPlayCustomAnimation()
	{
		return false;
	}

	public void SpawnBattleFlagOnHand()
	{
	}

	protected void EHJGKNCLKEI()
	{
	}

	protected void GGKEANGKJNM()
	{
	}

	protected Vector3 HCDENKCGNIH()
	{
		return default(Vector3);
	}

	public GameObject GetBattleFlagOnGround()
	{
		return null;
	}

	public void ClearOnGroundBattleFlagRef()
	{
	}

	public ResourceID GetBattleFlagResId()
	{
		return default(ResourceID);
	}

	public void ChangedBattleFlagToGround()
	{
	}

	public virtual bool RequestUseBattleFlag()
	{
		return false;
	}

	protected void EAAKHCEOCAB()
	{
	}

	private void NGDHLBFPAFP()
	{
	}

	public void StopAnimEfects(bool FAEDJCGABAA = false)
	{
	}

	public void ResetClothEffectEmoteShowMaskVisibility()
	{
	}

	public uint GetNowPlayeAvatarId()
	{
		return 0u;
	}

	public void PlayCustomAnimation(sbyte DJAPBCKDFKA = 0)
	{
	}

	public virtual bool RequestPlayEmotionAnimation(uint AMHLKPHLPNH = 1u, float FOMJCCKNEOL = 0f, Action<bool> CEHELPAIELA = null, bool PEGODMGMOCL = false, bool PMJBPOLFEEF = false, bool CEGFHCJIGOG = false)
	{
		return false;
	}

	public bool CheckCanPlayEmotion(uint AMHLKPHLPNH)
	{
		return false;
	}

	public virtual bool CanPlayEmotion()
	{
		return false;
	}

	public bool IsCanChange()
	{
		return false;
	}

	public void PlayTransformSound(ResourceID CIOJIHBKICA)
	{
	}

	public AnimationRuntimeHandle PlayAnimation(ResourceID IJJHJMBOKEB, bool NKELHICNOLN = false, bool NNFPDFIBENC = false, float JNHKPFFEELH = 0f, bool MFEKPFKOMIK = false)
	{
		return null;
	}

	public void SetAnimationSpeed(float IMKNJGHAHPI)
	{
	}

	public void UpdateBuffBehaivor(KKLOIPIACBL APHHNHEDHKD, FDAEPHMIEPC CKLFPGNJKEI = null)
	{
	}

	private void PDLCIDEJBMC(float LABAPAHJIAC)
	{
	}

	public void CancelPreparation()
	{
	}

	private void GONLGPIOEJF(bool FGLMBDDKAFM, float NNMKKDPONEM, float AGOCOPDGCEA)
	{
	}

	private void BKPIMPNLBMI(bool FGLMBDDKAFM)
	{
	}

	private void LLPLFOPGPFG(bool EOGOGFLCEHL)
	{
	}

	public void ShowBooyahGuyBuffEffect(bool EOGOGFLCEHL)
	{
	}

	private void OHPBPOCEIOE(UMAData JCONDDPFBKK)
	{
	}

	private void NJBLJAMEBGP(bool EOGOGFLCEHL, bool MKPNGDDDGCI = true, bool LDAIAKDBEOL = true, bool LAPKCANBBLN = false)
	{
	}

	private void KCFHCIDHAEF(bool KLPFIPGGJLA, bool DPFBJEDJBAK)
	{
	}

	public void SwitchEffect(UMAData.EffectType ACFMELJAGDH)
	{
	}

	public void ShowSpeedUpEffect(bool EOGOGFLCEHL)
	{
	}

	private bool MBPHICDEOFB(bool IIPNFHKIMLI)
	{
		return false;
	}

	public void ShowEnergyStoneBuffEffect(bool EOGOGFLCEHL, ResourceID EEOJGIGGNAA)
	{
	}

	private void KLDDPJLEJHO(bool MIBHDOJIHJE, OAICFPKEJNE BEEACJDCBBE)
	{
	}

	public void PlayEmotionAnimation(uint AMHLKPHLPNH, float FOMJCCKNEOL = 0f, uint OPMAPNOEFEM = 0u, EDuoEmoteStage CNBNENAEDKA = EDuoEmoteStage.None, bool FPIHBGIKLCM = true, Action<bool> CEHELPAIELA = null, bool FCMPAOJGBIM = false, bool FNHFIKLJKCJ = false, uint EPEOJCONCHF = 0u)
	{
	}

	public void SetEmoteSoundWhenEmotionEffIdxChange()
	{
	}

	public bool LeadEmote(uint PJMMDOONDOP, bool CHMDOICIKKK = false, bool PEGODMGMOCL = false)
	{
		return false;
	}

	public void FollowEmote(BHGGAEEHJCO MAPAMOKMDMC, bool CHMDOICIKKK = false)
	{
	}

	public uint GetPlayLeadEmoteTickCnt()
	{
		return 0u;
	}

	private void EEKHFBDAKEM(LevelDoor EBGHHGNFLCE)
	{
	}

	private void KGIOEGCDABF(LevelDoor EBGHHGNFLCE)
	{
	}

	private void OOEHHCMAAPG(LevelDoor EBGHHGNFLCE)
	{
	}

	public void SetExternalWeapon(JNGBBHLCHEB NOCOHCIDAAM)
	{
	}

	public MGPDBEGPNME GetCombinedWeapon()
	{
		return null;
	}

	public bool CanCombineWeapon()
	{
		return false;
	}

	public bool HasAgainstEntitesWithSpawnObjectCrossHair(SpawnObjectCrossHairTrigger HACIJIFIDKM)
	{
		return false;
	}

	public void SetTeleportDoorPlayerOverlapCheckerActive(bool MIBHDOJIHJE)
	{
	}

	public virtual bool RequestUsingTeleportDoor()
	{
		return false;
	}

	public virtual bool RequestUsingTeamGatherPointGun()
	{
		return false;
	}

	protected void FOJNINPJBBO(int FJCPAJEPBOD)
	{
	}

	protected GameObject DKEEDAHJGFP()
	{
		return null;
	}

	protected void PAHNEDEGKLO(int PNLDKNOFPNG)
	{
	}

	protected void AAEOBLGODLL(ushort OJEPOBEENEK, ushort EIOKHLKJEEL)
	{
	}

	protected void GHDHBOPBFHK(IOEECCGHJFA.OCJDMPBFJBE BJADOOOADEI, int FJCPAJEPBOD)
	{
	}

	protected void KMOBDGJKKLE(int FJCPAJEPBOD)
	{
	}

	public virtual void PlayBigHeadHypeEffect()
	{
	}

	private void IDLICELMLFI()
	{
	}

	public virtual void PlayBigHeadLevelUpEffect()
	{
	}

	public void PlaySwimmingSurfSound(bool PLNBKKNHAKO)
	{
	}

	public void PlaySurfEffect(ResourceID OCCLMDNGINA)
	{
	}

	public void DelayEquipBoard()
	{
	}

	public void StopEquipBoardCoroutine()
	{
	}

	private IEnumerator DADPGCKKPPB()
	{
		return null;
	}

	public void StartCheckBooyahEmote()
	{
	}

	private void FCDDJCLFOHE()
	{
	}

	public void StopCheckBooyahEmote(bool INFBPANEABF = true)
	{
	}

	private IEnumerator EIMCIFAIDMF()
	{
		return null;
	}

	private void OMHBNGKECKI()
	{
	}

	private IEnumerator IKMAELPJLID()
	{
		return null;
	}

	protected virtual bool AFOADJPPCAF()
	{
		return false;
	}

	public void SetObservered(bool PIDINBNGILH)
	{
	}

	public void UsedRedEnvelope()
	{
	}

	public void OnEnterDamageZone(LevelDamageZone BOCPOGEDOOB)
	{
	}

	public void OnExitDamageZone(LevelDamageZone BOCPOGEDOOB)
	{
	}

	public void SetVehicleVisible()
	{
	}

	public void StartPendingRevive(MANCAFBGENA APHHNHEDHKD)
	{
	}

	public bool CheckVisibleByDis(Vector3 NOOADLGMGNO)
	{
		return false;
	}

	public void StopPendingRevive(bool GKHDPFFOHLO, Vector3 NOOADLGMGNO)
	{
	}

	public void ReviveInitState(Vector3 HDFILHFDBKB, Quaternion IPKKCHLDJMA, Quaternion HEEEBLJBDNI, float GAPEKDNFCBE, uint LLGKAPEFODF)
	{
	}

	private void DNJNDAODMLJ()
	{
	}

	protected void POHJAAFJFIM()
	{
	}

	protected void LLAFLHNOBOM()
	{
	}

	public virtual void ReviveInitMotionState(Vector3 HDFILHFDBKB, Quaternion IPKKCHLDJMA, Quaternion HEEEBLJBDNI, uint LLGKAPEFODF)
	{
	}

	public void ReviveClearDamageZone()
	{
	}

	protected void HDCMMPFDLOC()
	{
	}

	public void OnGetInCatapult(LevelCatapult FONGGFABOCL)
	{
	}

	public void OnGetOutCatapult(LevelCatapult FONGGFABOCL)
	{
	}

	public void OnGetInCannon(LevelCannon JJJLGMGHCHA)
	{
	}

	public void TryClearTriggerEntity(uint JDHNCLHNJIP)
	{
	}

	public bool IsWholeBodyFiring()
	{
		return false;
	}

	public bool IsInExpansionAbilityMeleeCharging()
	{
		return false;
	}

	public bool IsInExpansionAbilityMeleeAttack()
	{
		return false;
	}

	public bool IsInExpansionAbilityMeleeAttackSlash()
	{
		return false;
	}

	public bool IsWholeBodyAttackMoving()
	{
		return false;
	}

	public float WholeBodyFiringMoveSpeed()
	{
		return 0f;
	}

	public float GetCurrentFireProgressRate()
	{
		return 0f;
	}

	public void OnGetOutCannon(LevelCannon JJJLGMGHCHA)
	{
	}

	public void OnStartSkyFalling(Vector3 OMCHCOKFHGA, uint NONGFCGNMDC)
	{
	}

	public void OnStartPlatformJumping(Vector3 OMCHCOKFHGA, uint NONGFCGNMDC)
	{
	}

	public void OnCatapultLaunch()
	{
	}

	public void OnStopCatapultFalling()
	{
	}

	public bool IsCatapultFalling()
	{
		return false;
	}

	public void ShowCatapultFallingTailTraceLine()
	{
	}

	public void RemoveCatapultFallingTailTraceLine()
	{
	}

	public void PlayChangeClothEffect()
	{
	}

	private void PDBFLAGEEMH()
	{
	}

	private void BCALFDNKBAL()
	{
	}

	public void OnGodStateCome(bool FJFHPNPNMCD, float OCEDEHGMEFE, bool GJKADBJKHPE = false)
	{
	}

	private void BKEOFPIODIC()
	{
	}

	private void BIEBICLIEIM(bool OGNEHLJLBGM = true)
	{
	}

	public GameObject PlayEffect(ResourceID OMKJDJBIIAC, string KOGLPHCBHJK)
	{
		return null;
	}

	public GameObject PlayEffect(ResourceID OMKJDJBIIAC, Transform GJDLFMIFHMG = null)
	{
		return null;
	}

	public void PlayEffectAsync(ResourceID OMKJDJBIIAC, Transform GJDLFMIFHMG = null, float EEKGKHEOAAF = 3f)
	{
	}

	public void PlayHitSPEffect(BHGGAEEHJCO PNOIDOKAEPD)
	{
	}

	private ResourceID CMFKNGNEJDK(out bool JAKODOHJINC)
	{
		JAKODOHJINC = default(bool);
		return default(ResourceID);
	}

	public ResourceID GetSFXSPHitResID()
	{
		return default(ResourceID);
	}

	public void PlayCSBuffScanEnemyEffect()
	{
	}

	public LevelKnockDownShield GenerateKnockDownShield()
	{
		return null;
	}

	public void PlayDamageBlockEffect(Vector3 DOEMNNFLJOB)
	{
	}

	private void OGHOCMKIENO(uint GGAOIPIHOBP, bool NNGHBFHBCKB, UnityEngine.Object HACIJIFIDKM)
	{
	}

	public virtual void UpdatePendingReviveState(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public virtual bool UpdateWaitToDestroyPlayer(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
		return false;
	}

	protected void LAHCPHDEOPL(OPICPDCLKAG FDJBPCFOEHM, uint ONFPCIABJJC)
	{
	}

	protected void KLLCEPFLNPO(OPICPDCLKAG FDJBPCFOEHM, uint ONFPCIABJJC)
	{
	}

	protected void BOIDKGPKHMN(OPICPDCLKAG FDJBPCFOEHM, uint ONFPCIABJJC, bool PDEMMOBBACC)
	{
	}

	private void CPHMFMAIPFP(LevelChair CNLHOCFGMCK)
	{
	}

	public void OnGetOnChair(LevelChair CNLHOCFGMCK)
	{
	}

	public virtual void OnGetOffChair(LevelChair CNLHOCFGMCK)
	{
	}

	protected void ECKLODGPJDB(OPICPDCLKAG FDJBPCFOEHM, uint ONFPCIABJJC)
	{
	}

	protected void EBKLHNIHCHM(OPICPDCLKAG FDJBPCFOEHM, uint ONFPCIABJJC)
	{
	}

	public void OnGetOnSeesaw(LevelSeesaw OMHKFPABEGF, int OIMPDJMNOFC)
	{
	}

	public virtual void OnGetOffSeesaw(LevelSeesaw OMHKFPABEGF)
	{
	}

	private void ILAHEKFIGIK()
	{
	}

	protected void BCNGDBILNOJ(PCBOIABIHPD GKKELMDDGBJ)
	{
	}

	protected void NJBFCBIPAEC(PCBOIABIHPD GKKELMDDGBJ)
	{
	}

	protected bool PCPLPONNHKK(PCBOIABIHPD GKKELMDDGBJ)
	{
		return false;
	}

	protected float NGKLBFFJLOJ(PCBOIABIHPD GKKELMDDGBJ)
	{
		return 0f;
	}

	protected float MAKMJILJLAM(PCBOIABIHPD GKKELMDDGBJ)
	{
		return 0f;
	}

	protected void CHELBBLBNCC()
	{
	}

	protected void AFDFHOEDNEN()
	{
	}

	public bool IsInNoHeadShotState()
	{
		return false;
	}

	private void CDIONDDCHJH()
	{
	}

	public void RefreshCrouchScatterState()
	{
	}

	public void StopCrouchScatterState()
	{
	}

	private bool KLOIAJDFKLK()
	{
		return false;
	}

	private bool DEMDLNMBHBM()
	{
		return false;
	}

	private void KDPKCBBPPAJ(ref Vector3 BEMGKIDFMHF, float OKJIFBCMDAD, float HOGHEFNINAE, bool DCEOPIDHNHF)
	{
	}

	public void OnCronchToStandOrJump()
	{
	}

	public void OnLyingToCrouch()
	{
	}

	private bool DHLFJJLDOHD()
	{
		return false;
	}

	private void EBCNIMIJAOD()
	{
	}

	public void RefreshLyingScatterState()
	{
	}

	public void StopLyingScatterState()
	{
	}

	private bool PJFNPLLKGMB()
	{
		return false;
	}

	private void EAAKEMFFCIM(ref Vector3 BEMGKIDFMHF, float OKJIFBCMDAD, float HOGHEFNINAE, bool DCEOPIDHNHF)
	{
	}

	public bool GetMeshBounds(ref Bounds KGHCCJBCLJL)
	{
		return false;
	}

	private void APFOBLAPCOO()
	{
	}

	private void EKDNAAIKDIP()
	{
	}

	public void Set1PEffect()
	{
	}

	public void Set3PEffect()
	{
	}

	public void BombModeRemoveBomb()
	{
	}

	private void CAAOBFGDPFD(LevelEmote BGIFMJKILLK)
	{
	}

	private void PKMNKLJPEIL(LevelEmote BGIFMJKILLK)
	{
	}

	private void CNGJIMMMBHE()
	{
	}

	private void OFFBCDLHGEO(BaseLevelObject GPONNDIDFJF)
	{
	}

	private void KPKHBPODNCP()
	{
	}

	public virtual void ForceUpdateAnimatorUMAChangeCallBack(UMAData JCONDDPFBKK)
	{
	}

	public void ForceUpdateAnimator()
	{
	}

	public virtual void CatchAnimComponentPlayAnimID(AnimationID IJJHJMBOKEB)
	{
	}

	public virtual bool IsIgonreWeaponFireControl()
	{
		return false;
	}

	public virtual Dictionary<int, int> GetGameControlMappingToSkillIndexMap()
	{
		return null;
	}

	public virtual Dictionary<KeyCode, int> GetKeyCodeToSkillIndexMap()
	{
		return null;
	}

	public virtual Dictionary<int, int> GetUGCActionMappingToSkillIndexMap()
	{
		return null;
	}

	public virtual bool IsOverrdieFastRunControl()
	{
		return false;
	}

	public void StopUseCurInventoryOnHand()
	{
	}

	public void SetAllPlayerThermalView(bool HCLGHJNEFIC)
	{
	}

	private void IOIBGKMPDNO(Dictionary<BHGGAEEHJCO, Player> ICEDNEMFHLG, bool HCLGHJNEFIC)
	{
	}

	public void SetThermalView()
	{
	}

	public bool JudgeInAttack()
	{
		return false;
	}

	public bool JudgeInDefence()
	{
		return false;
	}

	public void StartCrouching()
	{
	}

	public void StopCrouching()
	{
	}

	private void NNGBPEJLCLF()
	{
	}

	private void MPPEJNLKEKM()
	{
	}

	public void ClearHumanTireIAmIn(bool PJPFILBCDPM, LevelTriggerHumanTire JFEHFGEOLDJ = null)
	{
	}

	public virtual bool IsIgnorePlayerAudioComponent()
	{
		return false;
	}

	public virtual bool IsIgnoreHighFalling()
	{
		return false;
	}

	public virtual bool IsNeedAimAssists()
	{
		return false;
	}

	private bool AIJMAGDGLKI()
	{
		return false;
	}

	public void SyncTeleportDoorUseInfo(HPMLINPMHAM APHHNHEDHKD)
	{
	}

	public void SyncDriftBottleUseState(bool IEECPENEIMN)
	{
	}

	public void RecycleCurrentProp()
	{
	}

	public void ResetSimulationHP()
	{
	}

	public void SetForceMoveVelocity(Vector3 FKJMCGEFJMD, uint FBLLKNPHMOB)
	{
	}

	public Vector3 GetForceMoveVelocity()
	{
		return default(Vector3);
	}

	public List<CEKLEBBHLIG> GetDynamicSkills()
	{
		return null;
	}

	public bool IsActiveSkillTakingEffect(string IFJGAOFGMHA)
	{
		return false;
	}

	public CEKLEBBHLIG GetSkillByType(string LENJFKDNPMO)
	{
		return null;
	}

	public CEKLEBBHLIG GetSkillById(uint OIIEGGNFDBH)
	{
		return null;
	}

	public void SyncVehicleHornAccordingToDistance(bool DIDFFHGNGAI, Transform HJNNGJBABCM, Transform IKECFLDGELD, ref GameObject NEDLHHNHBLE, ResourceID GHDLAAEMJDO)
	{
	}

	public void ClearHornPool()
	{
	}

	public virtual void ChangeFog(bool GPFPIAMCEMI)
	{
	}

	public void CheckAndTryGetoffAirTransporter()
	{
	}

	public void PlayUseRescureZoneEffect(EPHBEJABIAD GEOOKCPMGCJ)
	{
	}

	public void ClearUseRescureZoneEffect()
	{
	}

	public void PlayUseRescureZoneSound(EPHBEJABIAD GEOOKCPMGCJ)
	{
	}

	public void StopUseRescureZoneLoopSound()
	{
	}

	public void PlayGetLevelIIVGPCursedEnergyEffect(Vector3 FCLPDCAIGPB)
	{
	}

	private void PMHIJIBAKHI(uint HMEEAGECFIO, ResourceID OCCLMDNGINA, GameObject CLACOPMJHDI)
	{
	}

	public void PlayIIVFastFallingEffect()
	{
	}

	private void FCMKLNCGBNO()
	{
	}

	private void AMKEJEACMAP(uint HMEEAGECFIO, ResourceID OCCLMDNGINA, GameObject CLACOPMJHDI)
	{
	}

	public void StopIIVFastFallingEffect()
	{
	}

	public void PlayIIVFastLandingEffect()
	{
	}

	public int CalKnockDownRemainingTime()
	{
		return 0;
	}

	public override bool CanAssitByWeapon(Player KALJPOOLDAD, FDAEPHMIEPC KEDHIAANLGO)
	{
		return false;
	}

	public virtual void OnPlayerTriggerCheckPoint()
	{
	}

	public void SetOutlineVisible(uint PIDINBNGILH, bool OGECPGHMIHA)
	{
	}

	public void InitOutline(AvatarTrace AELNCKDCENH)
	{
	}

	private void AEOKICOJLBH(bool GMFLCBMPHKK)
	{
	}

	private void PFBNBCHHCPF(bool IBEOBHMMHHH)
	{
	}

	public void SetShader(string NKOEPMIECFC, HELBFMHHPBI IGGPKOIHLJE = null, Shader BGBLINMCBGD = null)
	{
	}

	public void RevertToDefaultShader()
	{
	}

	public bool IsShaderApplying(string NKOEPMIECFC)
	{
		return false;
	}

	public void SetRenderQ(int MMNAILAPJFN, bool IDCHCEECMBE = false, bool MNMOFPDPGGN = false)
	{
	}

	public void RevertToDefaultRenderQ()
	{
	}

	public bool IsFullHP()
	{
		return false;
	}

	public bool IsFullPermSP()
	{
		return false;
	}

	public bool IsFullEP()
	{
		return false;
	}

	public float GetCurEPRatio()
	{
		return 0f;
	}

	protected void IEIDLIFFDFJ(Collider GLJGHEAPBOF)
	{
	}

	protected void NFLDCCIMPHE(Collider GLJGHEAPBOF)
	{
	}

	public void ReTriggerLowGravityArea()
	{
	}

	public List<uint> GetLowGravityAreasIAmIn()
	{
		return null;
	}

	public void PlayVFXJumpInLowGravityArea()
	{
	}

	public void StopVFXInLowGravityArea()
	{
	}

	private void LOIPCGHANPN(ResourceID GGMIDNEJGNO, Transform FKODMCNOBDM, ref GameObject PKOFNIADHHN)
	{
	}

	private void HJNDIOPPCBE(ResourceID GGMIDNEJGNO, ref GameObject PKOFNIADHHN)
	{
	}

	public bool StopRunSpeedUpSkill()
	{
		return false;
	}

	public bool StopCityHeroBoySkill()
	{
		return false;
	}

	public bool WithinRunLockFireFinishContinueShootInterval()
	{
		return false;
	}

	public bool WithinInvincibleContinusShootInterval()
	{
		return false;
	}

	public void EnterWalking(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM)
	{
	}

	public bool WithinEnterWalkingContinueShootInterval()
	{
		return false;
	}

	public void SavePreparePhaseEndPos()
	{
	}

	private void IJNKGGHAHOB(bool MIBHDOJIHJE, OAICFPKEJNE BEEACJDCBBE)
	{
	}

	private void GDOPICPJGEM(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public void InfectionOnPlayerBeAttacked()
	{
	}

	public void PlayChangeToZombieVfx()
	{
	}

	public void SetInfectionDefaultVfx()
	{
	}

	public void RefreshHippoCrisisReviveVFX()
	{
	}

	public void OnFinishedHippoCrisisGame()
	{
	}

	public virtual bool IsCameraUseTargetBackOffset()
	{
		return false;
	}

	public virtual void OnEnterFlightChangeCamera()
	{
	}

	public virtual void OnExitFlightChangeCamera()
	{
	}

	public virtual bool IsNeedOfflineInitInventory()
	{
		return false;
	}

	public virtual bool IsInitNeedEquipSound()
	{
		return false;
	}

	public void TapTheBeat()
	{
	}

	public void RequestPlayPartyDance(uint AOFCDPKJKJO, float GGBEMOEJDBF = 0f, bool IMBOBNAEAFG = false)
	{
	}

	private bool BIIDANAMDLG()
	{
		return false;
	}

	public void StartPartyGameSoloDanceBattling()
	{
	}

	public void EndPartyGameSoloDanceBattling()
	{
	}

	public bool IsPlayingDuoEmote()
	{
		return false;
	}

	public bool IsPlayingMoveEmote()
	{
		return false;
	}

	public bool IsPlayingLeadEmote()
	{
		return false;
	}

	public void StartJumpPadFalling()
	{
	}

	public void StopJumpPadFalling()
	{
	}

	public void OnStartFountainFallingDown()
	{
	}

	public void OnUseLevelInstrument()
	{
	}

	public void OnUseLevelWishingTree()
	{
	}

	public void OnUseWaitingCup()
	{
	}

	public void UpdatePlayerSpotLight()
	{
	}

	public void ReStartUserController()
	{
	}

	public virtual void OnResetServerTime()
	{
	}

	public void SyncPlayerAvatar(AvatarManager.JEGKOJDIKEL DKIIMBMLFHG, bool BCHDKJGBGNF)
	{
	}

	public bool EnableFallingSwapWeapon()
	{
		return false;
	}

	private void GFNFECINALK(KKLOIPIACBL APHHNHEDHKD, bool KBJKJDLOKAE, OAICFPKEJNE CFIOFMCBEAK)
	{
	}

	private void PIAFIIPPNOA(KKLOIPIACBL APHHNHEDHKD, bool KBJKJDLOKAE, OAICFPKEJNE CFIOFMCBEAK)
	{
	}

	private void MAJHCBPDPCO(KKLOIPIACBL APHHNHEDHKD, bool KBJKJDLOKAE, AJDNGNIFAFA GGABDNNNIDC)
	{
	}

	private void BGNGPIAMGPC(KKLOIPIACBL APHHNHEDHKD, bool KBJKJDLOKAE, AJDNGNIFAFA GGABDNNNIDC)
	{
	}

	private void KMBDHKMCDGB(KKLOIPIACBL APHHNHEDHKD, bool KBJKJDLOKAE, OAICFPKEJNE CFIOFMCBEAK)
	{
	}

	private void CNDPKHCGKGE(KKLOIPIACBL APHHNHEDHKD, bool KBJKJDLOKAE, OAICFPKEJNE CFIOFMCBEAK)
	{
	}

	private void EOGPENODMHB(KKLOIPIACBL APHHNHEDHKD, bool KBJKJDLOKAE, OAICFPKEJNE CFIOFMCBEAK)
	{
	}

	public bool HasActionCollection()
	{
		return false;
	}

	public void ClearUGCAniClipOverride()
	{
	}

	public Dictionary<string, AnimationClip> GetUGCAniClipOverride(bool EIHHEJIPGMB = false, int CCNBNLAPJFM = -1)
	{
		return null;
	}

	private void AFJIHAAFLMD()
	{
	}

	private void IIGKDNBKBGC(uint LIKPJDHGPFG, ref HashSet<ResourceID> FGOHBKNLFPD)
	{
	}

	private void PMBMFFCGAPL(string PEHJODPGACF, ref HashSet<ResourceID> FGOHBKNLFPD)
	{
	}

	private ResourceID HAGIKKPCEAD(uint LIKPJDHGPFG)
	{
		return default(ResourceID);
	}

	private ResourceID HAGIKKPCEAD(CollectionActionData JCONDDPFBKK)
	{
		return default(ResourceID);
	}

	private string ODDCCEHPGII(CollectionActionData JCONDDPFBKK)
	{
		return null;
	}

	public Dictionary<string, AnimationClip> GetActionCollection()
	{
		return null;
	}

	private bool ENAEHFPAHEN(uint LIKPJDHGPFG, Dictionary<string, AnimationClip> ICANOFNHAJE)
	{
		return false;
	}

	public static string GetAcitonCollectionResNameSuffix(FDAEPHMIEPC KEDHIAANLGO, byte FMDBNCGNKME)
	{
		return null;
	}

	public void PlayCureActionCollectionEffectInternel(string GGMIDNEJGNO)
	{
	}

	public void CureActionCollectionEffectEnd()
	{
	}

	public void DeleteCureActionCollectionEffect()
	{
	}

	public void TryClearInventoryMap3P()
	{
	}

	public void RemoveInventoryMap3PByDataID(uint HIDANNMJCDP)
	{
	}

	public void TryAddInventoryMap3P(uint HIDANNMJCDP, uint PNLDKNOFPNG)
	{
	}

	public ResourceID GetCureActionSoundRes()
	{
		return default(ResourceID);
	}

	public void PlayCureActionSoundInternel()
	{
	}

	public void StopCureActionSound()
	{
	}

	public virtual void DoEnterGameCache()
	{
	}

	public virtual void DoEnterGameCache3P()
	{
	}

	private void NOMDEHCGPBG()
	{
	}

	public void AddBurnBuffCnt(int GPFPIAMCEMI)
	{
	}

	public void AddRestrictedAreaFlag()
	{
	}

	public void RemoveRestrictedAreaFlag()
	{
	}

	public void CleanupRestrictedAreaFlag()
	{
	}

	public EntityVisualEffectManager GetVisualEffectManager()
	{
		return null;
	}

	public void SetVisualEffectUniqueID(FHHGDLPCCJE FDMMHCHAGBN, uint JDHNCLHNJIP)
	{
	}

	public uint GetVisualEffectUniqueID(FHHGDLPCCJE FDMMHCHAGBN)
	{
		return 0u;
	}

	public void CancelOrDetachEntityVisualEffect(FHHGDLPCCJE BIIDIBMHMPJ)
	{
	}

	public string UGCEntityID()
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

	public float GetSkillBuffWeaponScatterScale()
	{
		return 0f;
	}

	public bool TreatAs1P()
	{
		return false;
	}

	public virtual bool IsInHGEventTrigger()
	{
		return false;
	}

	public virtual void TriggerHGEvent()
	{
	}

	public virtual bool IsInBloodmoonGPTotemMissionTrigger()
	{
		return false;
	}

	public virtual void TriggerBloodmoonGPTotemMission()
	{
	}

	private bool PHNAKJDFBAH()
	{
		return false;
	}

	public void CheckLowGravityAreaAccidentallyClear()
	{
	}

	public JALFABPGLNE GetPlayerForceMoveManager()
	{
		return null;
	}

	public bool IgnoreRunOrDashMaxSpeedLimit()
	{
		return false;
	}

	private bool FNMIEAJNBLA()
	{
		return false;
	}

	public void RegisterMoveEmoteFootstepShot(uint FOBCBMLDPDK)
	{
	}

	public void StopMoveEmoteFootstepShot()
	{
	}

	public void StopEmoteSound()
	{
	}

	public void DeActiveWeaponStateMachineOnHand()
	{
	}

	public virtual void DoCacheAfterPlayerJoin()
	{
	}

	public void OnReconnect()
	{
	}

	public void OnChangeItemOnHand()
	{
	}

	public bool CanLoadoutReinforceCSShop()
	{
		return false;
	}

	public int GetWishingCoinCount()
	{
		return 0;
	}

	public DLGEOEOEDBC GetLoadoutSupportManager()
	{
		return null;
	}

	public void OnSyncAllLoadoutSupportSlotStateModified(List<DEGIKCGCFJM> LBJKNILJMNL, bool LLHIMJPHKCK)
	{
	}

	public void OnResponseModifyAllLoadoutSupportBuff(List<uint> BNBOIEIOGDN)
	{
	}

	public void ShowLoadoutSupportBeAddBuffEffect()
	{
	}

	public void SetEnterCubicMapFlag(bool PIDINBNGILH)
	{
	}

	public bool IsEnterCubicMap()
	{
		return false;
	}

	public void OnEnterRevivePointBuffShop(Collider GLJGHEAPBOF)
	{
	}

	public void OnExitRevivePointBuffShop(Collider GLJGHEAPBOF)
	{
	}

	public OLGNDPDIGLP TryGetRescureStatusForBeAssisted()
	{
		return null;
	}

	public OLGNDPDIGLP SyncAssistedDuringBeRescured(AIHEHGFNBJJ APHHNHEDHKD)
	{
		return null;
	}

	public bool SyncAssistingRescuring(AIHEHGFNBJJ APHHNHEDHKD, OLGNDPDIGLP CFNFFLDLCND)
	{
		return false;
	}

	public virtual bool RequestRescueAssistTarget(BHGGAEEHJCO PFJFADHEJLJ)
	{
		return false;
	}

	public virtual bool RequestStopAssistingRescure()
	{
		return false;
	}

	public bool InstantAnimSwitch()
	{
		return false;
	}

	public void SetInstantAnimSwitchFrame()
	{
	}

	public void SendFourSymbolSelectAttribute(byte JKNLMKFADBG, uint DLAHFLKEGIL)
	{
	}

	public void UpdateFourSymbolPendingAttributes(List<NCHOOLJCDNM> FMFAJBBAMFP)
	{
	}

	public void UpdateFourSymbolsSelectedAttributes(List<EECCOEIIKJI> APHHNHEDHKD)
	{
	}

	public List<NCHOOLJCDNM> GetPlayerPendingSelectAttributes()
	{
		return null;
	}

	public Dictionary<byte, uint> GetPlayerSelectedAttributes()
	{
		return null;
	}

	public bool HasPendingAttribute()
	{
		return false;
	}

	public void ShowLandingTutorialAtTutorialBR()
	{
	}

	public void ShowSkyDiveTutorialBR()
	{
	}

	private void LMMHBJIHEEN(Vector3 HDFILHFDBKB)
	{
	}

	public void TeleportBotAroundPlayerAtTutorialBR()
	{
	}

	private void HFGELDPDJFE(Vector3 PBFOBJNBNCB)
	{
	}

	protected EBMMLGGDMCC GKBMELENEFN(EBMMLGGDMCC HACJAENJFCJ, GameObject DAGCFDAIEDN = null)
	{
		return null;
	}

	protected void HEIFFILMKPA()
	{
	}

	public virtual void OnActSkillFinished(DMPADEOHJNJ LENJFKDNPMO)
	{
	}

	protected void IGLAGFBPIOO(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public virtual void CastSkillByIndex(int NIBBKONKPHP, bool CMLBHCJPJDA = false)
	{
	}

	public bool CheckActSkillCanCast(int NIBBKONKPHP)
	{
		return false;
	}

	public void ResetActSkillPlayerLockState()
	{
	}

	public void ClearSkillVfxEffect(HANMBDAAIFN MGGNLEEAPEP)
	{
	}

	public bool GetIsDampingNoiseBySkill(int NJMMDDMIION, int KJAEDIGHOMN)
	{
		return false;
	}

	private void NJBNPKBNDII()
	{
	}

	private void EKBFNMHCDIC(uint GGAOIPIHOBP, bool BBPCHCNOECP, UnityEngine.Object HACIJIFIDKM)
	{
	}

	private void POABFGGEAFO()
	{
	}

	private void MLAJNOGKBGH()
	{
	}

	private void OMDMCBJNEAM()
	{
	}

	private void DNKFLBNIGKN(uint GGAOIPIHOBP, bool BBPCHCNOECP, UnityEngine.Object HACIJIFIDKM)
	{
	}

	private void AOEFEEEJIPI()
	{
	}

	private void GDIFBFPMHBJ()
	{
	}

	public void OnSanioSkillStateChange(OJOFMFIDHEK CBCAJJJCKLH, OJOFMFIDHEK LALADOJHOBE)
	{
	}

	public void CreateAddIceWallEffect(Vector3 HDFILHFDBKB)
	{
	}

	private void EDGBAEBLCHC(GameObject CLACOPMJHDI)
	{
	}

	public void SetSkillLockFireState(bool KODHDCMJEND)
	{
	}

	public bool GetSkillLockFireState()
	{
		return false;
	}

	public bool IsTransformSkillTakingEffect()
	{
		return false;
	}

	public void TryCacheSkillEffects()
	{
	}

	public void TryCacheSkillEffects3P(int GCLBFFLOFIN = -1)
	{
	}

	public HBLKLJHFJDK GetActiveSkill(int NIBBKONKPHP = 0, bool MPJNGEBPEAI = true)
	{
		return null;
	}

	public bool CanUseActiveSkillWhenHighFall(int NIBBKONKPHP)
	{
		return false;
	}

	public HBLKLJHFJDK GetActiveSkillBySkillType(string LENJFKDNPMO)
	{
		return null;
	}

	public HBLKLJHFJDK GetActiveSkillByType(Type CCNBNLAPJFM)
	{
		return null;
	}

	public bool HasSkill(string LENJFKDNPMO)
	{
		return false;
	}

	public bool HasSkillSkin(string LENJFKDNPMO)
	{
		return false;
	}

	public ResourceID GetSkillSkinResourceId(Type LENJFKDNPMO, int PONCHHBJLDA, ResourceID OFECDJHBGOI)
	{
		return default(ResourceID);
	}

	public CEKLEBBHLIG GetSkillOrAwakenSkilById(uint OIIEGGNFDBH)
	{
		return null;
	}

	public HBLKLJHFJDK GetActiveSkillById(uint OIIEGGNFDBH, bool FPIFLOGAICA = true)
	{
		return null;
	}

	public void SyncActiveSkillStatus(MEHCCPKOMOJ APHHNHEDHKD)
	{
	}

	public ResourceID MonkeyKingTransformResID()
	{
		return default(ResourceID);
	}

	public void BloodPoolTransformAnimExit()
	{
	}

	public Transform GetSkillTransformerParent(PLAMDOMBAON CCNBNLAPJFM)
	{
		return null;
	}

	public void PutOnTransformer(PLAMDOMBAON HOHJCEACNAD)
	{
	}

	public Vector3 GetSkillTransformerCenter()
	{
		return default(Vector3);
	}

	public void TakeOffTransformer()
	{
	}

	public bool IsInSkillTransform()
	{
		return false;
	}

	public bool IsInGBFootBallTransform()
	{
		return false;
	}

	public void ChangeSkillTransformVisibiliy()
	{
	}

	private bool NAMPBIDOKOB()
	{
		return false;
	}

	private void FMNBOPGJKIL(string NKOEPMIECFC, HELBFMHHPBI IGGPKOIHLJE = null)
	{
	}

	private void BODBOGBBBON()
	{
	}

	private void FFFLGJMGPKI(int MMNAILAPJFN, bool IDCHCEECMBE = false, bool MNMOFPDPGGN = false)
	{
	}

	private void ALIKNNGLOEM(bool OKEOCDOOHAF = true)
	{
	}

	public void SetVisibiliyByTransformer(bool BPEAPHCCLIF)
	{
	}

	public void UpdateSkillHideInMap(bool KPMNLHPKIMN)
	{
	}

	public void UpdateDetectiveSkillEffect(bool EOGOGFLCEHL)
	{
	}

	public void UpdateStrongMedicineEffect(bool EOGOGFLCEHL)
	{
	}

	public void PlayActiveSkillCameraAnim(ResourceID AOFCDPKJKJO, float HKJKEJONGMC)
	{
	}

	public void ChangeCameraTypeFromActiveSkillToFollow()
	{
	}

	public Transform GetActiveSkillCameraReferenceTransform()
	{
		return null;
	}

	public bool IsAnyChargeSkillCharging()
	{
		return false;
	}

	public int SetAdditiveEffect(Material BIDLJGGGGJB, Camera HBJMHDIFCJO, CAIDKDGENGJ GKMFJPIEFGH = CAIDKDGENGJ.Normal, float LFLINNFNMPO = -1f, Action<int> CAAEAKMJHME = null, CameraEvent KDIEBAAJCCJ = CameraEvent.AfterForwardAlpha, Action<int> DOBOHOLBKMK = null, bool DIEJJJECODM = false)
	{
		return 0;
	}

	public void RemoveAdditiveEffect(int NIBBKONKPHP)
	{
	}

	public void PauseAllEffects()
	{
	}

	public void ResumeAllEffects()
	{
	}

	public void OnEffectDestory()
	{
	}

	private void OGHIKALIGEJ()
	{
	}

	private void DGECAIICPLH()
	{
	}

	private void BNBKOBCKLJI()
	{
	}

	public void OnEffectLateUpdate()
	{
	}

	private void NBHPKMGPCIK()
	{
	}

	private void HGDBDKCNPBA()
	{
	}

	private void DGNOJLPMDHE(UMAData EKLIOOIALIP)
	{
	}

	private void KJEGOJKJALN(UMAData EKLIOOIALIP)
	{
	}

	private void AIPABADGNKE(int NIBBKONKPHP)
	{
	}

	private void AGDJPEEDNHB(int NIBBKONKPHP)
	{
	}

	private void NMCLICHJJPD(Dictionary<int, IngameAvatarClothEffectComponent.ClothEffectObject> ICANOFNHAJE, CommandBuffer IELHEGGMJOM, Material BIDLJGGGGJB, int GCGFODOAOAA)
	{
	}

	private bool KMFFIEHOACA()
	{
		return false;
	}

	private void ICAFNIJBEBK(Collider GLJGHEAPBOF)
	{
	}

	private void MMDEDKKEEPE(Collider GLJGHEAPBOF)
	{
	}

	private void IDODAPPDEGC(Collider GLJGHEAPBOF)
	{
	}

	private void MDPNBNAPPPD(Collider GLJGHEAPBOF)
	{
	}

	public virtual void DoGetOnSlideTriggerActionInMid()
	{
	}

	public virtual void DoGetOnSlideTriggerAction()
	{
	}

	private void MNKHLNCMDLN(bool BNENCICKFNI)
	{
	}

	private bool KCEPHFGLLCD()
	{
		return false;
	}

	private bool HGFPLGCLHLG()
	{
		return false;
	}

	private void IOFCCEIDNJP()
	{
	}

	private void HBHMLPLFGOJ()
	{
	}

	private ArcGenerator CIBGMDJAACF()
	{
		return null;
	}

	private CollisionFlags GKHGNFHFNBF(Vector3 CGEEBNEEIBD)
	{
		return CollisionFlags.None;
	}

	private bool KFMFPIHKDIL(CollisionFlags CLIHDHKHLKC, CollisionFlags KMFNPMHFABA)
	{
		return false;
	}

	private void KOFMJMBNOPL(Vector3 IDOAFCNKIHO, Vector3 CDFKKKNPEFP)
	{
	}

	private void HAHAHMBJHCK(Vector3 MFCFOIBEDCB)
	{
	}

	private void IDGLAPBLKBP(Vector3 MFCFOIBEDCB, Vector3 GFLGOKLBOOB, float HOGHEFNINAE, float JFDNCECLKNA)
	{
	}

	private void PJMANHFBMFJ(ArcGenerator JNFFGHIBJBJ, Vector3 KMNLJIMKONC, POECFMGBOLN LBIOLKNAEAN, bool KHKEJCDMEFP = false)
	{
	}

	private void PJMANHFBMFJ(ArcGenerator JNFFGHIBJBJ, Vector3 KMNLJIMKONC, Vector3 MGMLAICDLCN)
	{
	}

	private void MBGDPLBFAKA(BezierSlide IALJAIOBOIF, Vector3 OINLPLDEPAD, POECFMGBOLN LBIOLKNAEAN, float DCLOCMLBNOE, bool LBAOIOFOJKK = false)
	{
	}

	private void MBGDPLBFAKA(BezierSlide IALJAIOBOIF, Vector3 KMNLJIMKONC, Vector3 MGMLAICDLCN, float DCLOCMLBNOE)
	{
	}

	private void OJPBHIPFIHE(BezierSlide IALJAIOBOIF, Vector3 KMNLJIMKONC, Vector3 MGMLAICDLCN, float DCLOCMLBNOE)
	{
	}

	private void LDEFMIOFEHD()
	{
	}

	private void PCGBLIBPHNE()
	{
	}

	private float IPPFDLMDNJC(float HOGHEFNINAE)
	{
		return 0f;
	}

	private void JEKBMHEPLBP()
	{
	}

	private void FMEGDMDALFP(OIBKLAKMFOL CKAKAGEMAJM)
	{
	}

	private void AEKLGFMEGHJ()
	{
	}

	public bool IsArcPathMoveDirClockwise()
	{
		return false;
	}

	private void ACEFHFMAJNJ(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private void DCJEAMPAOBK(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private bool NKNNOHJJING(ArcGenerator LODIOLIJGFH, float LFKCCCACLOH, float HOGHEFNINAE, float JFDNCECLKNA, bool CBFNJKLBIDH = false)
	{
		return false;
	}

	private bool NMOCAFJIBHA(BezierSlide IALJAIOBOIF, float LFKCCCACLOH, float HOGHEFNINAE, float JFDNCECLKNA, bool CBFNJKLBIDH = false)
	{
		return false;
	}

	private void CAONLFJEEPM(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private void HIIAMLBCMPI()
	{
	}

	private bool NOGLHLNNFMP(ArcGenerator LODIOLIJGFH, float LFKCCCACLOH, float HOGHEFNINAE, float JFDNCECLKNA)
	{
		return false;
	}

	private bool ILPPGFBIODA(BezierSlide LODIOLIJGFH, float LFKCCCACLOH, float HOGHEFNINAE, float JFDNCECLKNA)
	{
		return false;
	}

	private void BGCJNDJMFIJ()
	{
	}

	public void LocalFinishArcMove()
	{
	}

	private void FMJHDHIMJHL()
	{
	}

	private void PMOJFAFCCMO()
	{
	}

	public bool LocalCheckJumpToFinishArcMove()
	{
		return false;
	}

	public void LocalMoveEndToFinishArcMove(Vector3 PFECIAPMCFM)
	{
	}

	public void LocalGetOffSlide(Vector3 PFECIAPMCFM, bool INGBOECLCBI = true)
	{
	}

	public void LocalUseOffSlideBtn()
	{
	}

	public void LocalSwitchSlideMoveDir()
	{
	}

	private void AKBCHDLIALM()
	{
	}

	private void CFJPOHLJHNE()
	{
	}

	private void LDJFAMCLJMM()
	{
	}

	public void PlaySlideSpeedLowEffect()
	{
	}

	public void HideSlideSpeedLowEffect()
	{
	}

	public void LocalPlaySlideSkateBoardEffect()
	{
	}

	public void ChangeSpeedUPState(bool GKBOHJBDNEB)
	{
	}

	public void ChangeSpeedMaxState(bool NCEFEACNDAP)
	{
	}

	private void LNNCJKEJJHN()
	{
	}

	private void AMOCGONOHBO()
	{
	}

	private void FFEPFEIGJPF(bool EOGOGFLCEHL)
	{
	}

	private void HEFJHBHCDLN(ResourceID GGMIDNEJGNO, Transform PGOMNFCKAED)
	{
	}

	private void JPLMFLNMLBC(ResourceID GGMIDNEJGNO)
	{
	}

	public void ClearSlidePlayerEffect()
	{
	}

	private void CFGPGEJFOOH()
	{
	}

	private void KNGBABELIEI()
	{
	}

	private void MOHOEHKDOIA()
	{
	}

	private void HCNLBDAPOIM()
	{
	}

	private void DOOAOIDJDPF()
	{
	}

	private void KHLIFOCKFAI()
	{
	}

	private void HCGGENLHCFL(bool EOGOGFLCEHL)
	{
	}

	private void CELAAAKDKFB()
	{
	}

	private void GOAHPOFPHPE()
	{
	}

	public void PlayAssistantShot(KGNNKPBLKML NFMIALPNIEB)
	{
	}

	public void ShowEventTriggerMark(FCPLBIOLDOF BPEKPCICCEM)
	{
	}

	public void ClearEventTriggerMark(FCPLBIOLDOF BPEKPCICCEM)
	{
	}

	public void ShowEventTriggerMark(FCPLBIOLDOF BPEKPCICCEM, Vector3 IGDHIDGLOKG)
	{
	}

	public void FlashEventTriggerMark(FCPLBIOLDOF BPEKPCICCEM)
	{
	}

	public void SendTeamParachutePOIChat(Vector3 HBJHBLMCNCL)
	{
	}

	public string GetTeamParachuteMarkPOI_ID(Vector3 HDFILHFDBKB)
	{
		return null;
	}

	public void ShowAssistantMarkItem(EMEFBBBEPDG FEKAKKAKAHC, uint DIDNPODGGAA, string LCGFPGOBNBC, uint GBGKIDEMLID, Vector3 IGDHIDGLOKG, bool LPBMBGBNFOL = true)
	{
	}

	public void ChangeRemoveSelfMarkEntityTime(float HOGHEFNINAE)
	{
	}

	public void ShowAssistantMarkForMapMark(Vector3 IGDHIDGLOKG, uint AOENABIMOCH, uint CPDLAOJJHIP, bool BKFBJPLADMP = true, bool LPBMBGBNFOL = true)
	{
	}

	public OOENFLIJDAE GetCachedMarkEntityRequestExParam()
	{
		return null;
	}

	public void RequestMarkEntity(EMEFBBBEPDG FEKAKKAKAHC, uint DIDNPODGGAA, uint GBGKIDEMLID, Vector3 IGDHIDGLOKG, bool BKFBJPLADMP = true, bool LPBMBGBNFOL = true, OOENFLIJDAE LCNKCNHGCDI = null, bool IKBPCPBHDNM = true, bool PDHGMFEBJHE = false)
	{
	}

	public void TryRemoveAssistantMark(EMEFBBBEPDG FEKAKKAKAHC, uint DIDNPODGGAA, uint GBGKIDEMLID)
	{
	}

	public bool CheckAssistantMarkId(EMEFBBBEPDG FEKAKKAKAHC, uint DIDNPODGGAA)
	{
		return false;
	}

	public bool CheckAssistantMarkObjectId(EMEFBBBEPDG FEKAKKAKAHC, uint DIDNPODGGAA, uint GBGKIDEMLID)
	{
		return false;
	}

	public void TryPosRemoveAssistantMark(EMEFBBBEPDG FEKAKKAKAHC, uint DIDNPODGGAA, uint GBGKIDEMLID)
	{
	}

	public bool CheckMarkItemInfo(EMEFBBBEPDG FEKAKKAKAHC, uint DIDNPODGGAA, uint GBGKIDEMLID)
	{
		return false;
	}

	public void ClearMarkItemCacheInfo()
	{
	}

	public void RemoveAssistantMark(BHGGAEEHJCO LIKPJDHGPFG, EMEFBBBEPDG FEKAKKAKAHC, uint DIDNPODGGAA, uint GBGKIDEMLID)
	{
	}

	public void RequestAssistantShot(KGNNKPBLKML FBKKOOCKPLB)
	{
	}

	public void RequestAssistantShot(KGNNKPBLKML FBKKOOCKPLB, FCPLBIOLDOF JLJDEMBBEMF)
	{
	}

	public void RequestAssistantShot(KGNNKPBLKML FBKKOOCKPLB, FCPLBIOLDOF JLJDEMBBEMF, Vector3 ANBHOFKDHII)
	{
	}

	public void RaycastCheckForItemMark(uint CBCKBCPFOAI, ref BaseLevelObject GONDEGDDHKM, ref Vector3 JJBOJGHPLAC)
	{
	}

	public void RaycastCheckForItemMark(uint CBCKBCPFOAI, ref OGIJAGDFGAM GONDEGDDHKM, ref Vector3 JJBOJGHPLAC)
	{
	}

	public void RaycastCheckForItemMarkWithScreenPos(uint CBCKBCPFOAI, Vector3 OCLFLNINDAP, ref BaseLevelObject GONDEGDDHKM, ref Vector3 JJBOJGHPLAC)
	{
	}

	public void RaycastCheckForItemMarkWithScreenPos(uint CBCKBCPFOAI, Vector3 OCLFLNINDAP, ref OGIJAGDFGAM GONDEGDDHKM, ref Vector3 JJBOJGHPLAC)
	{
	}

	private bool PAONGBDIEII()
	{
		return false;
	}

	public bool CheckContainerSame(uint FEPNGNPHHBB)
	{
		return false;
	}

	public float GetMarkItemLastUseTime()
	{
		return 0f;
	}

	public bool IsVehicleWeaponCanFire()
	{
		return false;
	}

	public void ShowLocalTeammateKnockDownTriggerMark()
	{
	}

	public void RemoveCurrentPlayerMarkEntityShow()
	{
	}

	public bool CheckCanRecoverTeamGoalPin()
	{
		return false;
	}

	public string GetPlayerNickName(ref bool PHJEIPAPNLB)
	{
		return null;
	}

	public GameObject PlayAshot(ResourceID LIKPJDHGPFG, bool LEJKJFFACPM = true, float LHNALOCGHBP = 1f, ResourceID PDFFPKEECGM = default(ResourceID), bool OEPEBOGCFEJ = false, EAudioEngineType MNIHNCCOGJO = EAudioEngineType.eUnity, bool ALCBDJIJFKP = false, bool COHCHDADGMO = false, int JJGDKGGBBFH = -1, bool NNFPDFIBENC = false, bool NPKBCMNEIPF = false)
	{
		return null;
	}

	private bool HFIJKPPMLCG()
	{
		return false;
	}

	public bool CanPlaySwimSound()
	{
		return false;
	}

	public bool IsSceneEditFreeCameraHiddenPlayer()
	{
		return false;
	}

	private void IJJCLKAPNPP(ref int JJGDKGGBBFH)
	{
	}

	public void PlayAirlineBackgroundSounds()
	{
	}

	public void StopAirlineBackgroundSounds()
	{
	}

	private void OOKLPHMLOLG()
	{
	}

	private void AHFNDHKFGGD()
	{
	}

	public void OnSkySurfingSpeedChanged(bool NEPBPDIGJGD)
	{
	}

	public void PlaySkyDashingSound()
	{
	}

	public void PlaySkyDivingOnSound()
	{
	}

	private void HNFLGBIIPNM()
	{
	}

	private void NIAAODDEALC(float IMKNJGHAHPI)
	{
	}

	private void KKBMKCFJJFF()
	{
	}

	public void PlaySelfParachutingSound(bool AJDOBMCJFNI)
	{
	}

	public void PlayTeamParachutingSound()
	{
	}

	protected void FLONEAHEBMG(float IMKNJGHAHPI)
	{
	}

	private void GFEJMBMPNMC(bool NIOJPAADOJH)
	{
	}

	private bool LBFIFLPEAJF()
	{
		return false;
	}

	private void JBAJMLCNODL(bool FKEEDMAPKPN, bool INPKKGMOBLM = false)
	{
	}

	private void LAPIPMANMGN(bool BDMGJKCEGBM)
	{
	}

	private void DBKFBGEKPHH()
	{
	}

	private void JBALJOPCANI()
	{
	}

	private bool HJANHBDEPMN(out FlightData PLEOABBHECK)
	{
		PLEOABBHECK = null;
		return false;
	}

	private void EFMONNFJPIO(ResourceID PPDBMMLLPIF)
	{
	}

	private void EFMONNFJPIO(FlightData LIHNBGOGPAH)
	{
	}

	private void EFMONNFJPIO()
	{
	}

	private void JBOLOGBDBLO(bool MAJKIDDMCIK)
	{
	}

	private void KJCPEHPNPOI(ResourceID CBHODEPJNPJ)
	{
	}

	private void CNMFCIOGJLO()
	{
	}

	private void FNLNEIDLIFL()
	{
	}

	public void StopFlightBackgroundSounds(bool MAJKIDDMCIK)
	{
	}

	private void CCOJJLPPJKE()
	{
	}

	private void IPBLHCABHFK()
	{
	}

	private void OIPFFBCBJKM()
	{
	}

	public void OnSpectatorTargetExit(object[] JCONDDPFBKK)
	{
	}

	public void OnSpectatorTargetEnter(object[] JCONDDPFBKK)
	{
	}

	private void CMJIAAFDKDF()
	{
	}

	private bool NAMOCAJGIEM(EmoteData CLHFGHBDHBB)
	{
		return false;
	}

	public void StartSearchWithReEnter()
	{
	}

	public void StartSearch(KLHDGOLGLIO CCNBNLAPJFM, bool MCJHEPIAIGJ = false)
	{
	}

	private bool JAHFPDCPOON(KLHDGOLGLIO CCNBNLAPJFM)
	{
		return false;
	}

	public bool NeedCloseBySettingMode()
	{
		return false;
	}

	private bool PPEFFOFPAMM()
	{
		return false;
	}

	public void OnSearchOnce()
	{
	}

	private void ALGCGNFKEOI()
	{
	}

	private bool GKEEOMHIEDI(int FDMOFJDCJMH, ICLMFONIIKB FNFMMFAPDKJ)
	{
		return false;
	}

	private bool CFDNILNAEAM(uint ECJCMBJODNP)
	{
		return false;
	}

	public void SetSkipOnceItemId(uint ECJCMBJODNP)
	{
	}

	private int NJFOAOAFCJO(EJNFNOJNCPE GMBHNDKJJGL, AutoSearchItemDataIDNum LCBBJMAOHAO)
	{
		return 0;
	}

	public void SetStopByPlayer(bool ALPJDEKJBPA)
	{
	}

	public void StopSearch(bool ALPJDEKJBPA = false)
	{
	}

	private void HPFGFALIEMG(BKGEMKGCLAK LKAEJONKLFB, uint ECJCMBJODNP, Vector3 IEGPGLIEKDF, uint GEHJJDLAGJJ, uint FEPNGNPHHBB)
	{
	}

	private void ONEGCCBGCOI(BKGEMKGCLAK LKAEJONKLFB, uint ECJCMBJODNP, Vector3 IEGPGLIEKDF, uint GEHJJDLAGJJ, uint FEPNGNPHHBB)
	{
	}

	public SkinnedMeshRenderer[] GetAvatarTransformRenderers()
	{
		return null;
	}

	public void MakeTransformEffectVisible(bool PIDINBNGILH)
	{
	}

	public bool IsPlayingTransformAnim()
	{
		return false;
	}

	public void PlayTransformer(uint NGKFECCJPEE, Action<bool> CEHELPAIELA = null, EAvatarModelIngameType IEEOJJALJEK = EAvatarModelIngameType.Normal)
	{
	}

	private void BINGMGOCGHL(Action<bool> CEHELPAIELA)
	{
	}

	private void OCAAAIJAMLM(Action<bool> CEHELPAIELA)
	{
	}

	private void ODFCFKMIPOE(Action<bool> CEHELPAIELA, EAvatarModelIngameType LHGFEFOJMFC = EAvatarModelIngameType.FirstTransform)
	{
	}

	private bool IGJDONBAOBF()
	{
		return false;
	}

	private void MKDEIGMILLB(TransformData OKFGCOHEIEF, bool BNEHFPOHFGJ)
	{
	}

	public void TryCacheTransformCollection()
	{
	}

	public void TryCacheTransformCollection3P()
	{
	}

	public virtual bool CanAvatarTransform()
	{
		return false;
	}

	public void TrySwitchToAvatarTransformer(uint KJAELCGLKJL, uint FDOIFCNAECL)
	{
	}

	public void OnLoadAvatarTransfromerOver(GameObject ADDGINGLHBN, bool POKCMINBPBP)
	{
	}

	private void EJBDPPHIDDK(AvatarTransformData ICHJBEPFCOO, ResourceID HLIDHMEGAKI, GameObject ADDGINGLHBN)
	{
	}

	public void QuitAvatarTransformer(bool HJBPPGHOPHA = false)
	{
	}

	public void RebindAnimStatusWhenUGCAvatarChanged()
	{
	}

	private void DCOOFAAOMIJ(AvatarTransformData ICHJBEPFCOO, GameObject ADDGINGLHBN)
	{
	}

	private void GDCBIJPOOLO()
	{
	}

	public void RebindWeaponAnimController()
	{
	}

	public bool canShowAvatarTransform(AvatarTransformData JCONDDPFBKK)
	{
		return false;
	}

	private void HFHBNPOFLEL()
	{
	}

	public virtual void OnTransformerChanged(Transform FPMLOHFMGLP)
	{
	}

	private void EHDHLJPENPG()
	{
	}

	private void GLBMEKLEIEP()
	{
	}

	private bool LFIFEHJJHIF()
	{
		return false;
	}

	public bool IsInBigHeadScale()
	{
		return false;
	}

	public bool ApplyBigHeadScalePreHangLateUpdate()
	{
		return false;
	}

	private PlayerBigHeadPreHangUpdater LDGKMJOGJNB()
	{
		return null;
	}

	public void RegisterLocalPlayerBTFishTailCallback(Action<int> CEHELPAIELA)
	{
	}

	public void UnregisterBTFishTailCallback()
	{
	}

	public void UpdateLocalFishTail(bool JNKFCEOKLKD)
	{
	}

	public bool CanFishing()
	{
		return false;
	}

	public void SetFishSlientTime()
	{
	}

	public bool InIsSimFishSlient()
	{
		return false;
	}

	public void PlayBTFishingPoolAnimation(bool AOGGADPEFCC, Vector3 BAFIFNKBHLC = default(Vector3))
	{
	}

	private IEnumerator CENDEKFHCLI(Vector3 BAFIFNKBHLC)
	{
		return null;
	}

	public void PlayBTFishingPoolEndAnimation(uint KOAALACEJED, bool JFPDEPEOJFG)
	{
	}

	private void FPHKABIOIJM(uint KOAALACEJED)
	{
	}

	private void PPAHHDMKKFE()
	{
	}

	private void MENEMFEAOED(uint HMEEAGECFIO, ResourceID OCCLMDNGINA, GameObject KGJNMPHDKAB)
	{
	}

	private void JNADGLDOKAN()
	{
	}

	private void JJFMNNMHBCF(bool EOGOGFLCEHL, uint KOAALACEJED)
	{
	}

	public void ShowFishingRods(bool EOGOGFLCEHL)
	{
	}

	private void LIEACHJDHDJ(uint HMEEAGECFIO, ResourceID OCCLMDNGINA, GameObject KGJNMPHDKAB)
	{
	}

	private void IHEKLAHFJLN(uint HMEEAGECFIO, ResourceID OCCLMDNGINA, GameObject KGJNMPHDKAB)
	{
	}

	public bool IsBTFishingPooling()
	{
		return false;
	}

	public void UpdateFishingRemaining(uint KPAAKKDMMFD, byte CGNLBHJAHEB)
	{
	}

	public byte GetFishingRemaining(uint KPAAKKDMMFD)
	{
		return 0;
	}

	public void PlayBTBubbleAccelerateAnimation(bool AOGGADPEFCC, Vector3 BAFIFNKBHLC = default(Vector3))
	{
	}

	private IEnumerator MENIENICGBI(Vector3 BAFIFNKBHLC)
	{
		return null;
	}

	public void PlayBubbleAccelerateEffect(bool EOGOGFLCEHL)
	{
	}

	private void DFJGCOIGMNL(float OJEPOBEENEK, float EIOKHLKJEEL)
	{
	}

	public void OnLocalPlayerFinishedBubbleAccelerate()
	{
	}

	public float GetBTBubbleCDTime()
	{
		return 0f;
	}

	public float GetBTBubbleCDEndTime()
	{
		return 0f;
	}

	public bool CheckCanAccelerateBubble()
	{
		return false;
	}

	public void SetBTTeleportState(List<Vector3> GOLHJNCNDKN, float KMFMICABCFL)
	{
	}

	public Vector3 GetTeleportVelocity(float HKJKEJONGMC)
	{
		return default(Vector3);
	}

	public bool IsInBTTeleportPose()
	{
		return false;
	}

	public void OnExitBTTeleportPose()
	{
	}

	private void NEJDMCJJJHD()
	{
	}

	public override ITransformNode GetTransformNode(string JCIFFMHHBHK)
	{
		return null;
	}

	public void GetTransformNode(Dictionary<string, Action<DAPOIBANHEH>> GBKJPBGCPHD)
	{
	}

	public void GetTransformNode(List<string> NEOBBFEDGDE, Dictionary<string, DAPOIBANHEH> OJFKBNJOGGC)
	{
	}

	private void IPBKELCOAPD(KKLOIPIACBL APHHNHEDHKD, OAICFPKEJNE BEEACJDCBBE)
	{
	}

	private void JGBLMKGIHFH(KKLOIPIACBL APHHNHEDHKD, OAICFPKEJNE BEEACJDCBBE)
	{
	}

	private void IEEILMGPHLF(KKLOIPIACBL APHHNHEDHKD, OAICFPKEJNE BEEACJDCBBE)
	{
	}

	private void JBOHCFJDNDH(KKLOIPIACBL APHHNHEDHKD, OAICFPKEJNE BEEACJDCBBE)
	{
	}

	private void EBOCLCPOPNN(KKLOIPIACBL APHHNHEDHKD, OAICFPKEJNE BEEACJDCBBE)
	{
	}

	public Dictionary<uint, ANJGLPLLHAN> TryGetActiveBuffs()
	{
		return null;
	}

	private void HNJKGPNBGJK(uint DHIBDGPDEFP, byte IPNLLJDKHEE, float KJBBEIFCBHN)
	{
	}

	private void NAOIOHJKKFD()
	{
	}

	public void SyncOwnedDebuffInfo(List<HOPPKJFDGKB> HMBBAAIDICH)
	{
	}

	private void FMJDANHNLFL(KKLOIPIACBL APHHNHEDHKD)
	{
	}

	private void DNHOMHKFNEL(OAICFPKEJNE BEEACJDCBBE, KKLOIPIACBL APHHNHEDHKD)
	{
	}

	public void StartCarrying(Player KCKNPHKCIGK)
	{
	}

	public void StopCarrying()
	{
	}

	private static void GLLBMHNMDEJ()
	{
	}

	public void ReleaseCarryBinding()
	{
	}

	public void ApplyBeCarriedOutfit(bool AMLPDCMMHDA = false)
	{
	}

	public void ApplyBeCarriedOutfitForBuild()
	{
	}

	public void RestoreBeCarriedOutfit()
	{
	}

	public void MarkPendingSocialLobbyUpdateClothesRefresh()
	{
	}

	public void MarkPendingSocialLobbySelectProfileRefresh(List<uint> LIKHLGBKGAF)
	{
	}

	private void HFEBIPBEDHI()
	{
	}

	private void IABGHCMOMCA()
	{
	}

	private void OOACJJDGBII()
	{
	}

	private void GKIEGODNMPL(uint JDHNCLHNJIP, ResourceID GGMIDNEJGNO, GameObject KGJNMPHDKAB)
	{
	}

	private void LDIPAMOIFCM()
	{
	}

	private void KOLOCECHLAF()
	{
	}

	private void ONOOEIIANHJ()
	{
	}

	public void UpdateShoulderRideBattleAnim(bool EEPKDPKADCF)
	{
	}

	public void ReplayShoulderRideBattleAnim()
	{
	}

	public float ComputeCarryMeleeClampedYaw(float EIDDOMLEIAP)
	{
		return 0f;
	}

	public void StartCarryMeleeIK(float HEGJHKPEENC)
	{
	}

	public void StopCarryMeleeIK()
	{
	}

	public void UpdateCarryMeleeIK(float HOGHEFNINAE)
	{
	}

	public Vector3 GetCarryMeleeAimDir()
	{
		return default(Vector3);
	}

	private void LINMDFDOJEJ()
	{
	}

	private LHNIGIDFMMP MIFENDKAGEL(Player KCKNPHKCIGK)
	{
		return default(LHNIGIDFMMP);
	}

	public bool UpdateCarriedPosition(bool PONMIIOLEHB = true)
	{
		return false;
	}

	public Quaternion GetBodyRotation()
	{
		return default(Quaternion);
	}

	public bool CanCarryPlayer(Player PFJFADHEJLJ)
	{
		return false;
	}

	public bool IsCarryBlockedByEmoteSuperEmote()
	{
		return false;
	}

	private bool NKKPADEKKEI()
	{
		return false;
	}

	public void SendCarryPlayerReq(uint JKACBEJGGOC)
	{
	}

	public void SendReleaseCarryReq(bool CIDMALLMALE = false)
	{
	}

	public void SendCarryBattleHitReq(uint JKACBEJGGOC)
	{
	}

	public void OnCarryPlayerRes(EIFKDLLJIFD APHHNHEDHKD)
	{
	}

	public void ShowCarryFailTips()
	{
	}

	private static void GANOJKGBIAB(Player GEAFAEPFNDI, Player KCKNPHKCIGK)
	{
	}

	public void OnReleaseCarryRes(BELGLELJEEM APHHNHEDHKD)
	{
	}

	private static void EFONGDOAGAO(Player GEAFAEPFNDI, Player KCKNPHKCIGK)
	{
	}

	public void OnCarryBattleHitRes(ACLHNONEOIA APHHNHEDHKD)
	{
	}

	public void ClearJumpAscentCrossOverCommand()
	{
	}

	public void SetJumpAscentCrossOverCommand(float EHAFAJEIIKN, Vector3 AAICLALEBPA, bool FGDNOPHJNBG)
	{
	}

	public bool HasPendingJumpAscentCrossOverCommand()
	{
		return false;
	}

	public bool NeedCheckJumpAscentCrossOverMoveInputAfterJump()
	{
		return false;
	}

	public void RecordJumpAscentCrossOverMoveInputAfterJump()
	{
	}

	private void DBGDHMGHEAF()
	{
	}

	private void COEKELOPLHE(ClimbingTrigger NFEMHCKDKOB)
	{
	}

	private bool GOEPFODIEII(ClimbingTrigger NFEMHCKDKOB, float ACFKGKNAMPO)
	{
		return false;
	}

	private void ENBDOOJMKGE(ClimbingTrigger NFEMHCKDKOB)
	{
	}

	private bool OAJMOKIEGNL()
	{
		return false;
	}

	public void RequestStartClimb(bool FDMJDABPMAA)
	{
	}

	private void GMKKBGEHFMB()
	{
	}

	private float FPHMBAKIPFM(Vector3 BJLALGECMDB)
	{
		return 0f;
	}

	private float DIMPJCHPMLG(Vector3 EDKEHMCGAHC, Vector3 BFKHPMEEHHP, Vector3 EGEHMBPINCD)
	{
		return 0f;
	}

	private float CCEALJHAMOJ(Vector3 EDKEHMCGAHC, Vector3 BFKHPMEEHHP, Vector3 MNBPEEDKIAD)
	{
		return 0f;
	}

	private float OMKJKPJKIFK(float CKMJHDMIAMJ, float PLFBCLPDIGO, float BMKKGHJFIDH)
	{
		return 0f;
	}

	public void UpdateClimbCamera(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public void UpdateCrossOverJumpTimeAndFallTime(float FIFANONNMLF, float HBHGJDJLIPG)
	{
	}

	public bool CheckPhysPose_Climb()
	{
		return false;
	}

	private void JMENOBDJIGA()
	{
	}

	private Vector2 OOJMGHHAPCN(float OKJIFBCMDAD)
	{
		return default(Vector2);
	}

	private Vector2 PCMKLDJCKMH(float OKJIFBCMDAD)
	{
		return default(Vector2);
	}

	public Vector2 GetCrossOverSpeed(float OKJIFBCMDAD)
	{
		return default(Vector2);
	}

	private bool INPDKHNCKDF(float OKJIFBCMDAD)
	{
		return false;
	}

	private bool CCNNGHHOLOP()
	{
		return false;
	}

	public void RequestEndClimb(bool NMBDBFADCME = true)
	{
	}

	private void JMIKHOJGOCC()
	{
	}

	public Dictionary<BHGGAEEHJCO, BKIDLEFNNJA> GetCurCommonMarkInfos()
	{
		return null;
	}

	public void ClearCommonMark()
	{
	}

	public void RefreshCommonMark(DCNGPGPCDHG APHHNHEDHKD)
	{
	}

	public bool ClientMarkPlayer(BHGGAEEHJCO CAJFKKLGBMK, bool FDFOMDCHKKE, byte BPEKPCICCEM)
	{
		return false;
	}

	private void LIDKCJCCLLH(Dictionary<BHGGAEEHJCO, AKCKCJHBEKD> BJOCHNJANHK)
	{
	}

	private void GKCGJLBLJCF(BHGGAEEHJCO OBMFMAKFDDL, BEAFJIDDDMB KDOGAIGEGMK)
	{
	}

	private void CKFCHPJGODO(BHGGAEEHJCO OBMFMAKFDDL, BEAFJIDDDMB KDOGAIGEGMK)
	{
	}

	public bool IsMarkTarget(BHGGAEEHJCO CODKLPFNMND)
	{
		return false;
	}

	public bool HasMarkerType(BHGGAEEHJCO CODKLPFNMND, BEAFJIDDDMB KDOGAIGEGMK)
	{
		return false;
	}

	public bool IsScannerMark(BHGGAEEHJCO CODKLPFNMND)
	{
		return false;
	}

	public virtual bool RequestCreep()
	{
		return false;
	}

	public virtual bool RequestUnCreep(EOGPGNIDOKF KLDJLKMKKOJ)
	{
		return false;
	}

	protected void IHMJHPIIHKE()
	{
	}

	protected float DCFKEJLPNJE()
	{
		return 0f;
	}

	public void RequestUnSightIfNeed()
	{
	}

	public void RequestBackToSightingIfNeed()
	{
	}

	public bool CanUncreep(float FBEOEMLIJKO = 0f)
	{
		return false;
	}

	public bool CheckCeiling(float PBDPHJPBDGD = 1000f, float FBEOEMLIJKO = 0f)
	{
		return false;
	}

	public bool CheckDamageHitHead(EECMIDPHCKN JCONDDPFBKK)
	{
		return false;
	}

	public bool CanUseDamageReviseScaleLimitCount(EECMIDPHCKN JCONDDPFBKK)
	{
		return false;
	}

	public bool CheckDamageConditionByHeight(EECMIDPHCKN JCONDDPFBKK)
	{
		return false;
	}

	public bool CheckDamageConditionToMovingPlayer(EECMIDPHCKN JCONDDPFBKK)
	{
		return false;
	}

	public bool CheckDamageConditionAfterHold(EECMIDPHCKN JCONDDPFBKK)
	{
		return false;
	}

	public bool CheckDamageConditionAttackGreaterHP(EECMIDPHCKN JCONDDPFBKK)
	{
		return false;
	}

	public bool CheckDamageConditionToLowHP(EECMIDPHCKN JCONDDPFBKK)
	{
		return false;
	}

	public bool CheckPetSkillReduceDamageFromBack(EECMIDPHCKN JCONDDPFBKK)
	{
		return false;
	}

	public bool CheckTakeDamageByKnife(EECMIDPHCKN JCONDDPFBKK)
	{
		return false;
	}

	public bool CheckTakeDamageFromFront(EECMIDPHCKN JCONDDPFBKK)
	{
		return false;
	}

	public bool CheckDamageConditionToAIByMelee(EECMIDPHCKN JCONDDPFBKK)
	{
		return false;
	}

	public bool CheckDamageConditionToAIByShoot(EECMIDPHCKN JCONDDPFBKK)
	{
		return false;
	}

	public void EnableDashDustEffect(bool OGECPGHMIHA)
	{
	}

	protected void CPKEAPGNICA()
	{
	}

	public void ResetDashEffectType()
	{
	}

	public void SwitchDashEffectType(MABCLDLDMJO DIANDJBGFKK)
	{
	}

	public void ShowDoubleJumpEffect()
	{
	}

	public void EndDoubleJumpEffect()
	{
	}

	public FMDLJGLHAAN GetDoubleJumpData()
	{
		return null;
	}

	public virtual bool RequestStopDoubleJump()
	{
		return false;
	}

	public void AddEighthInfiniteEffect(uint LIKPJDHGPFG, uint NNHCKAJIOKO)
	{
	}

	public void OnEightInfiniteEffectFlyEnd(uint LIKPJDHGPFG)
	{
	}

	public void RemoveEighthInfiniteEffect(uint LIKPJDHGPFG)
	{
	}

	public bool HasEighthInfinteEffect(uint LIKPJDHGPFG)
	{
		return false;
	}

	public bool HasEighthInfinteEffectByType(uint CCNBNLAPJFM)
	{
		return false;
	}

	public bool HasEighthInfinteEffect()
	{
		return false;
	}

	public EighthInfiniteEffectData GetFirstEighthInfiniteEffectData()
	{
		return null;
	}

	public uint GetFirstEighthInfiniteEffectActiveTime()
	{
		return 0u;
	}

	public bool GetEighthInfiniteEffectIdByType(LNOLJHDKOBC CCNBNLAPJFM, out uint HIDANNMJCDP)
	{
		HIDANNMJCDP = default(uint);
		return false;
	}

	private void EOAHLOHDFOD()
	{
	}

	private void HFONONFJMGA()
	{
	}

	private void JOHDMMGKKCF()
	{
	}

	private void GKOIHBJDBPG()
	{
	}

	private void PJCMHIPLGNH()
	{
	}

	private void DJJACMLJJDH()
	{
	}

	private void DDEOMKKBJMI(uint LIKPJDHGPFG)
	{
	}

	private void KLIAKDAHLFC(uint LIKPJDHGPFG)
	{
	}

	private void EAKHFHMPOEL(uint LIKPJDHGPFG)
	{
	}

	private void KHLIFEJAMAO(uint LIKPJDHGPFG)
	{
	}

	private void HIJIMALKJFO(uint LIKPJDHGPFG)
	{
	}

	private void JAKGFLLONFB(uint LIKPJDHGPFG)
	{
	}

	public bool ValidAfterInfiniteIceWall()
	{
		return false;
	}

	public void ShowPlayerEighthInfiniteItemEffect(LNOLJHDKOBC MGGNLEEAPEP)
	{
	}

	public void DestroyPlayerEighthInfiniteItemEffect()
	{
	}

	public void PlayEmote(uint JPBDHEELLLK, Action<bool> PPPKMNCCEOA = null, float PCMPHDMHGHF = 0f)
	{
	}

	private void CHAOGBIANEK(uint JPBDHEELLLK, Action<bool> PPPKMNCCEOA, float PCMPHDMHGHF)
	{
	}

	private void HJCMMANPKGI(float PBIHCGFLCHG)
	{
	}

	public void CancelDelayCallStopEmote()
	{
	}

	public bool DuoEmoteInvite(uint OCKLGKCODNF, bool PEGODMGMOCL = false)
	{
		return false;
	}

	public void DuoEmoteJoin(BHGGAEEHJCO ANJEJCPDEAI)
	{
	}

	public void DuoEmote3PInvite(uint OCKLGKCODNF, Vector3? HDFILHFDBKB = null)
	{
	}

	private void PIMABDDHCKL(uint OCKLGKCODNF, Vector3? HDFILHFDBKB = null)
	{
	}

	private void CELAPEEDAAB()
	{
	}

	public void HideCooperateEmoteInvitation()
	{
	}

	private void FOLCPEADEJO()
	{
	}

	public void HideDuoEmoteInvitation()
	{
	}

	public void StopEmote(bool IOPEHEJMGFL = true, uint FNJNACKPODO = 0u)
	{
	}

	private void CCPNNIPAPCE()
	{
	}

	private bool PLCJGAKMKHA(EmoteData PBNJILJAFLL)
	{
		return false;
	}

	private bool AEPDJJKJACN(EmoteData CCGJBDHAABA)
	{
		return false;
	}

	public void OnBEVCheckStateValidClearSuperEmote()
	{
	}

	public void SetCooperateEmoteColliderState(bool CLNIIBNMGKF)
	{
	}

	public void LeadCooperateEmote(uint PJMMDOONDOP, uint HBIECBMJCDO = 0u)
	{
	}

	public void RegisterCooperateEmoteSurvant(BHGGAEEHJCO OBMFMAKFDDL, int MAIFPPFLCEB, uint PJMMDOONDOP)
	{
	}

	public void UnRegisterCooperateEmoteSurvant(BHGGAEEHJCO OBMFMAKFDDL, uint PJMMDOONDOP)
	{
	}

	private void MJGNGIIGONK(uint PJMMDOONDOP, uint HBIECBMJCDO = 0u)
	{
	}

	private void IAOMGPKDHLD(bool CBCAJJJCKLH)
	{
	}

	private void DCCCGKJMAPO(int OCKLGKCODNF)
	{
	}

	public void SetAvatarUpdateWhenOffScreen(bool PIDINBNGILH)
	{
	}

	public void SetAvatarUpdateWhenOffScreenDefault()
	{
	}

	public void StopSurvantCooperateEmote()
	{
	}

	public void JoinCooperateEmote(uint PJMMDOONDOP, int MAIFPPFLCEB, BHGGAEEHJCO JEDILDMEEPP)
	{
	}

	private void EACIFFDMHKB(uint PJMMDOONDOP, int MAIFPPFLCEB, BHGGAEEHJCO JEDILDMEEPP)
	{
	}

	private float HJKCECOADKB(Player DLMPPEIIPIL, uint PJMMDOONDOP)
	{
		return 0f;
	}

	private static AnimationClip NMJBLPDMJMF(ResourceID LIKPJDHGPFG)
	{
		return null;
	}

	public void RequestJoinCooperateEmote(BHGGAEEHJCO MAPAMOKMDMC)
	{
	}

	public void PlayEmoteCameraAnimation(ResourceID JJGJBGCDNFE)
	{
	}

	public void StopEmoteCameraAnimation()
	{
	}

	public Transform GetEmoteCameraReferenceTransform()
	{
		return null;
	}

	public Animator GetEmoteCameraAnimator()
	{
		return null;
	}

	public void StopEmoteWithCameraAnim()
	{
	}

	private void NKGNMFJKAJG(uint JPBDHEELLLK)
	{
	}

	private void NJCOMCJKBHM()
	{
	}

	private void OEFAKDHKMGK()
	{
	}

	public JKBHKINACEN GetExecuteStatus()
	{
		return null;
	}

	public LIAFPDJNAPH GetExecutionSkillData(uint OIIEGGNFDBH)
	{
		return null;
	}

	public uint GetExecutionWeaponSkin()
	{
		return 0u;
	}

	public void OnExecuteSkillEquipChanged(FDAEPHMIEPC MLOAMCCGPCA, bool AEPNFDAIEGA)
	{
	}

	protected void INNBLPMNJMF()
	{
	}

	public void SetAlwaysPlayExecutionSkillData()
	{
	}

	public bool IsValidToExecuteTarget(Player PFJFADHEJLJ, float OKJLMMDMKBN = 1f)
	{
		return false;
	}

	public bool IsValidToExecuteByPose()
	{
		return false;
	}

	public virtual bool RequestExecuteTarget(BHGGAEEHJCO PFJFADHEJLJ)
	{
		return false;
	}

	public void OnExecuteKill(LMGEHAGDMDP AOFCDPKJKJO)
	{
	}

	public void SetWeaponExecuteStatus(bool AOGGADPEFCC)
	{
	}

	public float GetExecutionCameraFinishLerpTime()
	{
		return 0f;
	}

	public void PlayExecuteAnimation()
	{
	}

	public bool IsExecutionResReady(LIAFPDJNAPH JCONDDPFBKK)
	{
		return false;
	}

	private bool FOFDKNBMGJF(ResourceID AOFCDPKJKJO)
	{
		return false;
	}

	public void OnExecuteStateChanged(bool AOGGADPEFCC)
	{
	}

	protected bool PDPPBPPPFGH(BHGGAEEHJCO KJLFMPOFELA)
	{
		return false;
	}

	public Player GetExecutor()
	{
		return null;
	}

	private bool EKPLJPONMNK()
	{
		return false;
	}

	public void OnBeingExecutedStateChanged(bool AOGGADPEFCC)
	{
	}

	public virtual bool RequestStopExecute()
	{
		return false;
	}

	public void StopExecuteLocalInternal()
	{
	}

	public void ChangeExecutionCameToFollow(bool PDGMEKPAMBE = false)
	{
	}

	public static void ChangeCameTypeFromExecutionSkillToFollow(Player PFJFADHEJLJ, bool PDGMEKPAMBE = false)
	{
	}

	public void OnStartExecutionSkill()
	{
	}

	public void PlayUIHudEffect()
	{
	}

	private void HFDLLEGAPEF(LIAFPDJNAPH KGLBALPJMFC, ref Transform BMFPOEMNPHI, Transform PKDLHDPLAJF, bool AJOBLICAJNN, bool FGLDEOEFBIB)
	{
	}

	private void PCCDKCJDAIE()
	{
	}

	public Transform GetCameraReferenceTransform()
	{
		return null;
	}

	public bool CheckCanRequestFastRun()
	{
		return false;
	}

	public virtual bool RequestFastRun()
	{
		return false;
	}

	public void RequestStopFastRunReadyToPlayCustomAnim()
	{
	}

	public virtual bool RequestStopFastRun(bool FAEDJCGABAA = false)
	{
		return false;
	}

	public virtual void RequestChangeFlightRoamState(bool HHMNJMJADCK)
	{
	}

	public virtual void SetFlightRoam(bool OGECPGHMIHA)
	{
	}

	public virtual bool CanFlightRoam()
	{
		return false;
	}

	public void UpdateFlightRoamData(OEMGENOPMAJ APHHNHEDHKD)
	{
	}

	public NAGDAGNPFPD GetFlightRoamData()
	{
		return default(NAGDAGNPFPD);
	}

	public void OnJoinFloatingLand(byte CDKAAILILEL)
	{
	}

	public void OnLeaveFloatingLand()
	{
	}

	public void OnSuccessOnFloatingLand()
	{
	}

	public void OnWaitJoinFloatingLand(int AJLPOFGHBOI)
	{
	}

	public void OnLeaveWaitFloatingLand()
	{
	}

	public void FaceSafeZoneCenter()
	{
	}

	public bool IsShowingFoldWingModel()
	{
		return false;
	}

	public bool IsFoldWingGliding()
	{
		return false;
	}

	public bool IsFoldWingGlideFalling()
	{
		return false;
	}

	public virtual bool RequestStopFoldWing()
	{
		return false;
	}

	public void ShowFoldWingModel()
	{
	}

	public void ShowFoldWingModel(JDFJDBOFKPM BPDGEMBOGAA)
	{
	}

	public void HideFoldWingModel()
	{
	}

	public void OnStopGliding()
	{
	}

	public void OnStartGliding()
	{
	}

	public static bool IsPaidFollowMoveEmote(uint LJECAGELDFD)
	{
		return false;
	}

	private uint FLLKBAONPGC()
	{
		return 0u;
	}

	private uint FLLKBAONPGC(uint OGHIPJNNCDA)
	{
		return 0u;
	}

	private bool BOPEPAIDENL(uint OCKLGKCODNF)
	{
		return false;
	}

	public static bool IsFollowMoveEmoteSkinBypassScene()
	{
		return false;
	}

	public bool CanShowEmoteSkin(uint OCKLGKCODNF)
	{
		return false;
	}

	public bool CanBeFollowEmoteTarget()
	{
		return false;
	}

	private bool MOEDIIGOLIE()
	{
		return false;
	}

	private void NKEGNNEFEBI()
	{
	}

	private void MGJBBEFGJKJ()
	{
	}

	private void BKNLHFABPJH()
	{
	}

	private bool LHPOFHADPIE(Player PFJFADHEJLJ)
	{
		return false;
	}

	public bool TryRequestJoinFollowMoveEmote(BHGGAEEHJCO KPCKNLHLEGK)
	{
		return false;
	}

	private bool KKKBGFAJCMK()
	{
		return false;
	}

	private void FNIPOGHFOHB()
	{
	}

	public bool IsInFollowEmoteState()
	{
		return false;
	}

	public bool IsOutOfControlBlockingPickup()
	{
		return false;
	}

	public bool CanShowEmoteJoinHudAction()
	{
		return false;
	}

	public bool CanShowFollowMoveEmoteJoinHudAction()
	{
		return false;
	}

	public bool CanShowFollowMoveEmoteJoinHudActionForTarget(uint MEIMFKAABDA)
	{
		return false;
	}

	private void AAMJNMEFDJO()
	{
	}

	public bool IsFollowEmoteLeaderPlayingPaidMoveEmote()
	{
		return false;
	}

	private bool HHAJEODKGAL()
	{
		return false;
	}

	private bool AEBKKGPJHMO()
	{
		return false;
	}

	private void IAMNDFINPEL()
	{
	}

	public bool IsFollowEmoteButtonBlocked(bool LJGCBIMOJBC = false)
	{
		return false;
	}

	public bool CanRequestFollowEmoteDriver(bool LJGCBIMOJBC = true)
	{
		return false;
	}

	public bool TryRequestFollowEmoteDriver()
	{
		return false;
	}

	public bool TryRequestFollowEmoteDriverByEmotionItem(uint LJECAGELDFD)
	{
		return false;
	}

	private void FHFJBAEMCDI()
	{
	}

	private void OMLFECONNJE()
	{
	}

	public void SetFollowTarget(BHGGAEEHJCO PFJFADHEJLJ)
	{
	}

	public void SetFollowTarget(BHGGAEEHJCO PFJFADHEJLJ, BHGGAEEHJCO JEBEIHDMJIB)
	{
	}

	public void SetFollowMode(IHACOKBPJEM GGAOKBAMALB, bool EHBCHCKDKEN = false)
	{
	}

	public void RequestCancelFollow()
	{
	}

	public void CancelFollowEmoteByOperationInput(bool MJFPNAJPNID = true)
	{
	}

	private bool PPOKJIJDNBN()
	{
		return false;
	}

	public void InterruptFollowMoveEmoteOnTeleport()
	{
	}

	public void TryCancelFollowEmoteForOperationInput()
	{
	}

	public bool RequestDisbandFollowTeamAsLeader()
	{
		return false;
	}

	public void ApplyServerFollowMoveEmoteStop()
	{
	}

	public void CancelFollow()
	{
	}

	public void RequestPlayFollowDriverEmote(uint LJECAGELDFD = 0u)
	{
	}

	private bool KPBKNHCALLM()
	{
		return false;
	}

	private void KOIDFBKLPKD(bool EOGOGFLCEHL)
	{
	}

	private bool GAGCMMKOOJJ()
	{
		return false;
	}

	private void BFFHFLLHMCA()
	{
	}

	public void RequestJoinOtherFollowEmote(uint LAFMDCCBOEM)
	{
	}

	public void EnsureCabinVisibleForFollowEmote()
	{
	}

	private Player NBJPFNNPBCH()
	{
		return null;
	}

	private static float CPIFAABPGGK(float FOMJCCKNEOL)
	{
		return 0f;
	}

	private float AJOFJGDBKIK(uint PFIMOHKNLDF)
	{
		return 0f;
	}

	private void AIIAACBLENM()
	{
	}

	private void LKIBHJBNBAC()
	{
	}

	private bool COKEBAKHCND(uint LJECAGELDFD, float FOMJCCKNEOL)
	{
		return false;
	}

	private bool IGOGHLADJGG(float FOMJCCKNEOL)
	{
		return false;
	}

	private bool PLFNCJIKGMF(uint GNEIEEEPCLP)
	{
		return false;
	}

	private void JFBPIBEAIAK(uint LJECAGELDFD, int FOCONCNGCAM, bool ENHMDKPKJJK)
	{
	}

	public void PlayFollowMoveEmote(uint OGHIPJNNCDA = 0u, int FOCONCNGCAM = -1, bool BFCJFEBCLHP = true)
	{
	}

	private void DNMHOPEIHDH(uint LJECAGELDFD, int FOCONCNGCAM, bool BFCJFEBCLHP = true)
	{
	}

	public void PlayFollowEmoteSound()
	{
	}

	public void UpdateFollowEmoteSound()
	{
	}

	public void StopFollowEmoteSound()
	{
	}

	public void ChangeFollowEmoteCamera(bool KECEJHOAHCA)
	{
	}

	public void StopAnimPlay()
	{
	}

	private void CGGOCEDNAGB()
	{
	}

	public bool CheckFollowEmoteInterrupt()
	{
		return false;
	}

	private void OAKIOBCDBJB()
	{
	}

	public void InterruptFollowEmoteOnMovePlatformTouch()
	{
	}

	internal bool COLDELOMDPG()
	{
		return false;
	}

	private bool GBGAPPECJCC()
	{
		return false;
	}

	public void InterruptFollowEmoteOnSpecialLocomotionEntry()
	{
	}

	private void IDKMGIHOBOB()
	{
	}

	internal bool KMFBONIMBJB(AJABDHEBMHF APHHNHEDHKD, out BHGGAEEHJCO HHPNCDPEOCM)
	{
		HHPNCDPEOCM = default(BHGGAEEHJCO);
		return false;
	}

	internal void JFCAMKLKCEM()
	{
	}

	private void CHGLDJEPCOD(AJABDHEBMHF APHHNHEDHKD)
	{
	}

	private bool ONHMCOJJIGM(AJABDHEBMHF APHHNHEDHKD, out BHGGAEEHJCO HLOOGMJAGBE)
	{
		HLOOGMJAGBE = default(BHGGAEEHJCO);
		return false;
	}

	private void BHAIHBLGAJI(AJABDHEBMHF APHHNHEDHKD)
	{
	}

	private void HACMFGJMCDJ(Player JEBEIHDMJIB)
	{
	}

	private bool KLBHKHONFNH(BHGGAEEHJCO HLOOGMJAGBE, BHGGAEEHJCO OJMFPMFDLPA, int PEEOFBHEJLO)
	{
		return false;
	}

	private bool LFKCHIBJENM(uint BMLHIKBDBLC)
	{
		return false;
	}

	private bool DPOELGGPNGH(uint JOAFAGCHOHL)
	{
		return false;
	}

	private void NIFHFOAALME(BHGGAEEHJCO HLOOGMJAGBE, BHGGAEEHJCO OJMFPMFDLPA, uint OCKLGKCODNF, int PEEOFBHEJLO)
	{
	}

	private void PEFMDPHFLGE(BHGGAEEHJCO HLOOGMJAGBE, BHGGAEEHJCO OJMFPMFDLPA, uint OCKLGKCODNF, int PEEOFBHEJLO)
	{
	}

	private void PGLLOPFLHDK(int PEEOFBHEJLO)
	{
	}

	public void ChangeFootballVerticalSpeed(float JHLNMNMLGPB)
	{
	}

	private bool JLECMNFCDIH()
	{
		return false;
	}

	private void PCBMJEKHCLK(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public bool IsFootballGrounded()
	{
		return false;
	}

	protected virtual void MCAMDMLKGEF(Vector3 MCCDOOPMMGE)
	{
	}

	protected virtual void DICPCKLJECP(Vector3 MCCDOOPMMGE)
	{
	}

	protected void FKBNFAIOLAB()
	{
	}

	protected virtual void EPFKHHIJMDI(float CKIOPFBGFKB)
	{
	}

	public void DelFootBall()
	{
	}

	protected virtual ResourceID BAGIMMEAOJN()
	{
		return default(ResourceID);
	}

	protected virtual void BFCHGGJEPPD()
	{
	}

	protected virtual void GMLNLEDELIJ(LevelTriggerFootball NFEMHCKDKOB, bool IDCHCEECMBE = false)
	{
	}

	private void JPJLGEMDHME()
	{
	}

	protected virtual void JKGDCNBFFGB()
	{
	}

	protected void EOALOCOKPHD()
	{
	}

	public void StopFootball()
	{
	}

	public void SetVisibleForFootball(bool NDGMENGEGIE)
	{
	}

	private void DGAKMJMFJDH(Vector3 HDFILHFDBKB)
	{
	}

	public void OnFootballGoals()
	{
	}

	public void ResetPlayerWardrobeForFootball()
	{
	}

	public void UpdatePlayerWardrobe(uint FJCPAJEPBOD)
	{
	}

	public virtual float GetFootballAdjustAccForward()
	{
		return 0f;
	}

	public virtual float GetFootballAdjustAccRight()
	{
		return 0f;
	}

	public virtual float GetFootballFadeVelocityXZScale()
	{
		return 0f;
	}

	public void OnFootstepTriggerEnter(Collider GLJGHEAPBOF)
	{
	}

	public void OnFootstepTriggerExit(Collider GLJGHEAPBOF)
	{
	}

	public bool CanPlayFPPAccurateFireAnim()
	{
		return false;
	}

	public bool IsFPPControllerMode()
	{
		return false;
	}

	private bool PFMILBNALKB()
	{
		return false;
	}

	public void UpdateFPPFiringTime(float GCKEGAPLLNL, float HOGHEFNINAE)
	{
	}

	public void UpdateFPPWeaponVibrateRotation(float HOGHEFNINAE)
	{
	}

	private Transform NBGIHFJCJJJ(Transform FKODMCNOBDM)
	{
		return null;
	}

	public void ChangeToFirstPersonMode()
	{
	}

	public void ChangeToThirdPersonControllerMode()
	{
	}

	public void ChangeToThirdPersonMode()
	{
	}

	public void UGCChangeToThirdPersonModel()
	{
	}

	public float GetDashSpeedForFPPMode()
	{
		return 0f;
	}

	public float GetFPPFiringDampRadio()
	{
		return 0f;
	}

	public float GetMoveSpeedForFPPMode()
	{
		return 0f;
	}

	public PGJFGBFBNAD GetMoveAxisDirection()
	{
		return PGJFGBFBNAD.Forward;
	}

	public Vector3 GetFPPIceWallRealPos(Vector3 HDFILHFDBKB)
	{
		return default(Vector3);
	}

	public void SwitchToFPPModel()
	{
	}

	public void SwitchToDefault()
	{
	}

	public void AddPlayerFPPModel()
	{
	}

	public virtual void SwitchIKTarget()
	{
	}

	public virtual void SetConstantFireLimit()
	{
	}

	public void UpdateMountWeapon()
	{
	}

	public void SetIKWeight(float DEKFJOCHLFD)
	{
	}

	public float GetIKWeight()
	{
		return 0f;
	}

	public void PlayUGC1PAim()
	{
	}

	public void MountFPPWeaponGameObject(FDAEPHMIEPC PJMDKPKBBAM)
	{
	}

	public void OnUGCInhalerVisiblityChange(bool BIDKKABBNJF)
	{
	}

	public void PlayUGCInspectorAnim()
	{
	}

	private void BCHGJJJMHPI()
	{
	}

	public void PlayFPPLowHpSound()
	{
	}

	private void BMEHCMMMCMB()
	{
	}

	public void UpdateFPPPlayerOffset()
	{
	}

	private void LEAHHNGECCI()
	{
	}

	private void CHHKNIBEJII()
	{
	}

	private void GBKAKFPFDMO()
	{
	}

	public void SetKingScanVFX(float CNKMEPFCJOM)
	{
	}

	public void CloseKingScanVFX()
	{
	}

	public void ShowKingClown(ResourceID GGMIDNEJGNO)
	{
	}

	public void ShowAngelNDemonVfx(byte MAFBHAFHGFJ)
	{
	}

	public bool IsWantedPlayer(BHGGAEEHJCO JFPADHMCADP)
	{
		return false;
	}

	private bool FOAJGECPBGG()
	{
		return false;
	}

	public bool HasHealingBulletSkill(int NJMMDDMIION, int LJCABDEOFFL)
	{
		return false;
	}

	public bool HasHealingBulletSkill(AGACNOCEEFP NGJDOCHFBKJ)
	{
		return false;
	}

	public void ResetHighFrameParam()
	{
	}

	public bool NeedRunHighFrame()
	{
		return false;
	}

	public void SkipHighFrameWhileForceSync()
	{
	}

	public void SkipHighFrameRotate()
	{
	}

	public bool IsHighFrameUpdatePosition()
	{
		return false;
	}

	public void SkipFallingLandCheck()
	{
	}

	public void ResetHighFrameFlags()
	{
	}

	private void PIGMGNCAEOP(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private void PDOHIMIJJMM(float OKJIFBCMDAD, float HOGHEFNINAE, bool DCEOPIDHNHF, ref Quaternion HOAIBNGIOPP, ref Vector3 BEMGKIDFMHF, ref bool GPKDOONOLLB)
	{
	}

	public Quaternion UpdateFollowEmoteCameraRotationWithInput(Quaternion CHAIDJOMGCJ)
	{
		return default(Quaternion);
	}

	private bool BKLIPOEGBHP()
	{
		return false;
	}

	private void JEKMKFLBBNC(float OKJIFBCMDAD, float HOGHEFNINAE, ref Quaternion HOAIBNGIOPP)
	{
	}

	public bool TryGetHorseAutoDriveSteerByAim(float OKJIFBCMDAD, out float MGAPGCBHDOD)
	{
		MGAPGCBHDOD = default(float);
		return false;
	}

	private void NMNGKBCINMB(Vector3 DEHABKLNDLO)
	{
	}

	private void GGIBEAPEKMP(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public void UpdateClimbCameraHighFrame(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private void FMDPGMJAAJN(float HOGHEFNINAE)
	{
	}

	private bool CEONJCKGOBH()
	{
		return false;
	}

	public void UpdateIceWallMakerProcess(ushort GPFPIAMCEMI)
	{
	}

	public void UpdateIceWallMakerExp(ushort EIOKHLKJEEL)
	{
	}

	private void LFKLHFILHIJ(int EIOKHLKJEEL)
	{
	}

	private void PONBOBNLJLH()
	{
	}

	private bool HFFPHPECMHO()
	{
		return false;
	}

	private void KEPMNIBIGAN(float AHOJNHNOGMA)
	{
	}

	private float NDCKMGEHGDL()
	{
		return 0f;
	}

	private void OALOBMGHLAG(int EIOKHLKJEEL, bool IDCHCEECMBE = true)
	{
	}

	private bool CPFPJNHPDNL()
	{
		return false;
	}

	public void OnIceWallCountChange(int PNLDKNOFPNG)
	{
	}

	public void SetUGCIceWallMakerChargeMaxModify(float GPFPIAMCEMI)
	{
	}

	public uint IceWallLimitedCount()
	{
		return 0u;
	}

	private float MNKJOLKNIHK()
	{
		return 0f;
	}

	public int GetIceWallFillRemainSeconds()
	{
		return 0;
	}

	public void SyncIceWallMakerParams(byte PNLDKNOFPNG, ushort IMKNJGHAHPI)
	{
	}

	public virtual bool RequestStartJetFly()
	{
		return false;
	}

	public virtual bool RequestStopJetFly()
	{
		return false;
	}

	public void ShowJetFlyEffect()
	{
	}

	public void EndJetFlyEffect()
	{
	}

	public void PlayJetFlyFlyingSound(ResourceID FPLAPJHDMCP)
	{
	}

	public virtual bool RequestUsingVEM()
	{
		return false;
	}

	public bool IsUseReinforceAnvil()
	{
		return false;
	}

	public bool CheckNeedRefreshReinforcedAnviUI(BHGGAEEHJCO OBMFMAKFDDL)
	{
		return false;
	}

	private void MMNEAJKHHBA(uint GNBOOELAHNP, uint LAHMCKAGGCO)
	{
	}

	private void HAGIAIHKCOF(bool GNBOOELAHNP, bool LAHMCKAGGCO)
	{
	}

	private void CLBNPKCJEEN(bool HCLGHJNEFIC)
	{
	}

	public void ReqPlaceMapThrowerItem(Vector3 HDFILHFDBKB, uint HBDFBCFBPDI, uint LNLJDGIPNLM, bool POIGMKAOCKK, BBNHJFFAAPM OKOPGEGAANF, NALGEIFKCAB PGNFIPCBGBM)
	{
	}

	public bool IsUseMapThrower()
	{
		return false;
	}

	private void DDDMBBLEAFH(uint GNBOOELAHNP, uint LAHMCKAGGCO)
	{
	}

	private void LFIHIKODEMH(bool HCLGHJNEFIC)
	{
	}

	public bool IsUseTeamBuffSupporter()
	{
		return false;
	}

	private void NFNGFAMJBOK(uint GNBOOELAHNP, uint LAHMCKAGGCO)
	{
	}

	private void JBEJJONEDFA(bool HCLGHJNEFIC)
	{
	}

	private void GGINFPAGDBK()
	{
	}

	public bool EnterLobbySocialAreaZone(SubgameLobbyLWZoneType FBGIGGLPLBI)
	{
		return false;
	}

	public bool ExitLobbySocialAreaZone(OBOHAOFFODK OLBPPGANKJL)
	{
		return false;
	}

	private bool HGJENOMKPMG(out OBOHAOFFODK OLBPPGANKJL)
	{
		OLBPPGANKJL = default(OBOHAOFFODK);
		return false;
	}

	public bool HasActiveQueueZone()
	{
		return false;
	}

	private int KNDLHELHCJJ(OBOHAOFFODK OLBPPGANKJL)
	{
		return 0;
	}

	public void MarkLobbyLWSignUpBlockStateReleaseTime()
	{
	}

	public bool IsLobbyLWSignUpBlockedAfterStateRelease()
	{
		return false;
	}

	public void SetLobbyLWQueueState(byte JJNFMJLKPPK, byte DJNIMMLLMBB, bool CGANHKDFAJF)
	{
	}

	public void ClearLobbyLWQueueState()
	{
	}

	public void SendLobbyLWLeaveQueue(bool FLLMGPAHMKE = false)
	{
	}

	private void EJGKALAIBFI()
	{
	}

	public void OnEnterDancePoolArea(Collider GLJGHEAPBOF)
	{
	}

	public void OnExitDancePoolArea(Collider GLJGHEAPBOF)
	{
	}

	public void OnEnterCarryArea(Collider GLJGHEAPBOF)
	{
	}

	public void OnExitCarryArea(Collider GLJGHEAPBOF)
	{
	}

	public void OnEnterDancePoolDJTrigger(Collider GLJGHEAPBOF)
	{
	}

	public void OnExitDancePoolDJTrigger(Collider GLJGHEAPBOF)
	{
	}

	public void OnEnterLobbyLWInteractTrigger(Collider GLJGHEAPBOF)
	{
	}

	public void OnExitLobbyLWInteractTrigger(Collider GLJGHEAPBOF)
	{
	}

	public void SendDancePoolStartReq(uint HFFPKFJOBLD, uint POAEDFODPFB = 0u)
	{
	}

	public void SendDancePoolStopReq()
	{
	}

	public void OnDancePoolStart(uint HFFPKFJOBLD, uint POAEDFODPFB, uint CFDJHKLJFOK)
	{
	}

	public void OnDancePoolSync(uint HFFPKFJOBLD, uint POAEDFODPFB, uint CFDJHKLJFOK)
	{
	}

	private uint NNJADJALEJA(uint HFFPKFJOBLD, uint POAEDFODPFB)
	{
		return 0u;
	}

	private void CBHEDHPNBMP(uint HFFPKFJOBLD, uint POAEDFODPFB, uint CFDJHKLJFOK)
	{
	}

	public void OnDancePoolStop()
	{
	}

	public void ClearDancePoolState()
	{
	}

	public void CleanupDancePool()
	{
	}

	public void JoinDancePool(BHGGAEEHJCO MMKPKFGIKMN)
	{
	}

	public void OnDancePoolStateSync(uint HFFPKFJOBLD, uint POAEDFODPFB, uint CFDJHKLJFOK)
	{
	}

	private void NAAMDELDFFN(uint LAKAIDIADCL, uint HFFPKFJOBLD, uint POAEDFODPFB, uint CFDJHKLJFOK)
	{
	}

	private void NKBELNCHBJM(uint LAKAIDIADCL, uint HFFPKFJOBLD, uint POAEDFODPFB, uint CFDJHKLJFOK)
	{
	}

	public void UpdateDancePool()
	{
	}

	private float MDNEJJBLNEJ(uint LAKAIDIADCL, bool JNIKCODLIED, uint MAPAMOKMDMC, uint CDGMELDBOPO)
	{
		return 0f;
	}

	private float JODMIBHCOLC(uint LAKAIDIADCL, uint CDGMELDBOPO)
	{
		return 0f;
	}

	private void LDFCBKBDMFF(int OCKLGKCODNF)
	{
	}

	private void GIOPMENKBIN()
	{
	}

	private void JFEHDPNCBIP()
	{
	}

	private void LDPFCBLFKHN()
	{
	}

	private void INHOAHLPFGL()
	{
	}

	public void SetDancePoolEffectActive(bool MIBHDOJIHJE)
	{
	}

	private float EIDMCBEDFHK(uint OCKLGKCODNF)
	{
		return 0f;
	}

	public void OnEnterSubgameLobbyLW(Collider GLJGHEAPBOF)
	{
	}

	public void OnExitSubgameLobbyLW(Collider GLJGHEAPBOF)
	{
	}

	protected void IPPOEHGNPFC(KDOJONOLNKG CBCAJJJCKLH)
	{
	}

	public bool DisableUseConsumableDuringMoving()
	{
		return false;
	}

	public void ChangeMetropolisClothes(List<uint> BAIDALDFDOH, bool IMIDGBJAEKL = false)
	{
	}

	public void SendMetropolisAddBuffMsg()
	{
	}

	public void UpdateMetropolisMissionList(List<CEKDKLLKEAC> HJPKDHDIKDF)
	{
	}

	public void OnPlayerMetropolisZoneTypeChanged(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	private void BBBGCHDEPJH(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	private void LPBIPDCINNJ(uint FBPDOADBOCA, uint LGGHPECLBFN)
	{
	}

	public bool IsInMovePlatform()
	{
		return false;
	}

	public void TryAddPlatformToPendingList(LevelMovePlatform EEGHANDKINF)
	{
	}

	public void TryClearPendingPlatformList()
	{
	}

	public void TryRemovePlatformInPendingList(LevelMovePlatform EEGHANDKINF)
	{
	}

	public LevelMovePlatform TryGetPlatformInPendingList(int NIBBKONKPHP)
	{
		return null;
	}

	public void KeepLocalPositionAndDirectionWhenMovePlatformMove(uint POEJOGDILPP)
	{
	}

	private bool PBGDLMOBDMN()
	{
		return false;
	}

	protected void EOHFLJHBBJA(LevelMovePlatform BKNDIFKMOGD)
	{
	}

	public void TryRefreshDirOnPlatform()
	{
	}

	protected void KFIFPJNJGNM()
	{
	}

	protected void BGACMMHHGFJ()
	{
	}

	public void ForceEnterMovePlatform(LevelMovePlatform EEGHANDKINF)
	{
	}

	public void ForceExitMovePlatform()
	{
	}

	protected bool ALFJLHIPGAH()
	{
		return false;
	}

	public void OnExitMovePlatform(LevelMovePlatform BKNDIFKMOGD)
	{
	}

	private void OJBIINHEDOL(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private void IDPACNDEFMF(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private void HGABBDPKNIM(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private void OGENPMFDGHJ(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private void NOALINJOJCE(Vector3 HAONCKLKNDE)
	{
	}

	public void GetOffMovePlatForm()
	{
	}

	public void CheckExitMotionPlatformOnDead(float KDHIDHDLPEN)
	{
	}

	public void CheckEnterMotionPlatformOnRevive(float GCOEGBJHFLN)
	{
	}

	private void EBDECDFJLEC(uint GNBOOELAHNP, uint LAHMCKAGGCO)
	{
	}

	private void LODANNJBFFL(bool HCLGHJNEFIC)
	{
	}

	private void EJKICOEEFCB(bool GNBOOELAHNP, bool LAHMCKAGGCO)
	{
	}

	public bool IsUsePersonalShop()
	{
		return false;
	}

	private void NJPJINMHJMN()
	{
	}

	public void ForceStopWalking()
	{
	}

	public float GetCurrentDashSpeed()
	{
		return 0f;
	}

	public void StartDashSpeedLerp(bool OFEKLHJECOL)
	{
	}

	public void RefreshDashSpeedLerpValueWhenSpeedChaned()
	{
	}

	public void StopDashSpeedLerp(bool LPBPBKGNBKA)
	{
	}

	public void ClearDashLerp()
	{
	}

	private void JLNDIKLJEDJ()
	{
	}

	private bool HHICKLBAJDN()
	{
		return false;
	}

	protected virtual void BDNICNECMEH(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private bool OJKGLNJNDPJ(Vector3 IGDHIDGLOKG, Vector3 BAFIFNKBHLC, float CGGPBJKCDEG, int PCIHGMPOMPF, out RaycastHit MPLMJFDDNAO)
	{
		MPLMJFDDNAO = default(RaycastHit);
		return false;
	}

	private bool EGEEBBKJFOM(Vector3 NJKAHDCMALC, Vector3 KBMEAIOBPJE)
	{
		return false;
	}

	private bool MMAKIPEGDHC(Vector3 NJKAHDCMALC, Vector3 KBMEAIOBPJE)
	{
		return false;
	}

	private bool LGOFPEEGEIB(Vector3 NJKAHDCMALC, Vector3 KBMEAIOBPJE)
	{
		return false;
	}

	public void UpdateFallingPose(bool JJKGOAGDNAN)
	{
	}

	private void BINILNGHHIA(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private void HIHEPMHKGJB(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private void OFAEFLPOKNP()
	{
	}

	private bool MBEGAOCOGNO()
	{
		return false;
	}

	public void CheckNeedFakeHeight()
	{
	}

	private void MGGBIEHPPCO()
	{
	}

	private void MBMKLEFBEFC(bool CJEEPLCLHMC)
	{
	}

	private void MDMGICCJIJO(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private void PPLCGCEMLCN(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private void BCNOCHLGEFM(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	protected void KGLMHBCNOLI(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	protected void IABHPDJMHJG(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private void CFIPIPBHMOE(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private void CIBLGGGCACM(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private void JABDHEPCHHA(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private void OKOGBPJCIGE(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private void CABCHCJPLOD(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private void ONAJOAPGLNP(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	protected virtual void JKBKCCNDOBA(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private void ALHAGANJEPC(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private void DOEFOOHLPOH(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public void SimOnFerrisWheel(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public bool CanOpenParachuting(float OKJIFBCMDAD)
	{
		return false;
	}

	public void EnableSpeedLineEffect(bool PIDINBNGILH)
	{
	}

	private void HNJBMCCNNIL(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private void GDOPKKFJBBM(LevelTriggerFountain GIHMGEJOFIL)
	{
	}

	public void PostParachutingTransformChange(Transform BOIGMEKIAEL, float HOGHEFNINAE)
	{
	}

	private bool PAHEELFMDHH(Vector3 KGDIJNENMJH, Vector3 JIFPBEEAGEI, float EHGEKKCIGDF, uint CBCKBCPFOAI)
	{
		return false;
	}

	protected void BDOIJBMGNLN()
	{
	}

	public virtual bool IsJumpCanMove()
	{
		return false;
	}

	private void CGBKBCGFGMA(LevelJumpPad FIJOIBNAJOF)
	{
	}

	public NMCBIHOOFFF GetStartFireState()
	{
		return NMCBIHOOFFF.ESTARTFIRESTATE_NONE;
	}

	public bool IsDragonTaskPlayer()
	{
		return false;
	}

	public bool CanSkipragonTask()
	{
		return false;
	}

	public bool GetSkillRemoteRescueCanUse()
	{
		return false;
	}

	protected override int GetMaxRepDataCount()
	{
		return 0;
	}

	protected override void OnUserDefineReplicationInfo()
	{
	}

	private void PNGMBKCIEMM(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	private void BNMLEFKCOFH(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	private void FPKNHDCNFPJ(int OJEPOBEENEK, int EIOKHLKJEEL)
	{
	}

	private void PMMGPMCKFGE(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	private void AAGNIDGCJFF(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	private void HOCHMIIOALH(byte GNBOOELAHNP, byte LAHMCKAGGCO)
	{
	}

	private void GNBFAGJDJFM(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	private void EOJJGGHCCPG(bool OJEPOBEENEK, bool EIOKHLKJEEL)
	{
	}

	private void CFPGGEBOBKG(uint GNBOOELAHNP, uint LAHMCKAGGCO)
	{
	}

	private void EHFHEIFCPKB(sbyte GNBOOELAHNP, sbyte LAHMCKAGGCO)
	{
	}

	private void JAMILHOCDIM(float GNBOOELAHNP, float LAHMCKAGGCO)
	{
	}

	private void LLLAEINCGIP(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	private void DAOGBONINFJ(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	private void DCIDKIJOIPK(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	private void JPABEAIOHBC(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	private void CKDJJFDNMDA(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	private void MPIBBIMIDDL(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	protected override void OnPRIInitialized()
	{
	}

	protected virtual void NEGHOLNOAPP(ushort OJEPOBEENEK, ushort EIOKHLKJEEL)
	{
	}

	protected virtual void LONCHOBEIGO(ushort OJEPOBEENEK, ushort EIOKHLKJEEL)
	{
	}

	protected virtual void BNHLGILAFJG(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	protected virtual void IFEAFGDBOBO(ushort OJEPOBEENEK, ushort EIOKHLKJEEL)
	{
	}

	protected virtual void ONAKOGOPHJM(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	protected void LPEOBAMCIMM(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	protected void KNKHNBLENDO(ushort OJEPOBEENEK, ushort EIOKHLKJEEL)
	{
	}

	protected void BNKMDDENGDL(ushort OJEPOBEENEK, ushort EIOKHLKJEEL)
	{
	}

	protected void NDDECECBGIE(ushort OJEPOBEENEK, ushort EIOKHLKJEEL)
	{
	}

	protected void MDIBLDIPFFD(ushort OJEPOBEENEK, ushort EIOKHLKJEEL)
	{
	}

	protected void EAKIOPPEFBB(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	protected virtual void EDCAPJKBPME(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	protected void NKLNDKDENPB(sbyte OJEPOBEENEK, sbyte EIOKHLKJEEL)
	{
	}

	protected void HOKPLFGFMOH(sbyte OJEPOBEENEK, sbyte EIOKHLKJEEL)
	{
	}

	protected void MELFDNKMIJD(sbyte OJEPOBEENEK, sbyte EIOKHLKJEEL)
	{
	}

	protected virtual void KFOLHOPJBAC(ushort OJEPOBEENEK, ushort EIOKHLKJEEL)
	{
	}

	protected virtual void IFKIHGEBIGA(ushort OJEPOBEENEK, ushort EIOKHLKJEEL)
	{
	}

	protected virtual void AGNOEKCCHPJ(ulong OJEPOBEENEK, ulong EIOKHLKJEEL)
	{
	}

	protected void EAMBEMGNDGH(uint JDHNCLHNJIP, ResourceID JMIMKLAELHE, GameObject KGJNMPHDKAB)
	{
	}

	protected void ANAMHIPDCHO(uint JDHNCLHNJIP, ResourceID JMIMKLAELHE, GameObject KGJNMPHDKAB)
	{
	}

	protected virtual void KOFKIHKCAMB(ulong OJEPOBEENEK, ulong EIOKHLKJEEL)
	{
	}

	protected void LFHMDKJAFFO(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	private void BPKEMLBPANF(ulong CFFJLONLBDM, ulong BEEENABAIFE)
	{
	}

	private void KDDIHDGECMM(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	private void CGMJFJPBHLB(bool OJEPOBEENEK, bool EIOKHLKJEEL)
	{
	}

	private void AIBFHPEFOGA(uint GNBOOELAHNP, uint LAHMCKAGGCO)
	{
	}

	private void CPIHHFBDEEH(ulong OJEPOBEENEK, ulong EIOKHLKJEEL)
	{
	}

	private void ABOPDKFPCHI(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	public void StopBeingExecuted()
	{
	}

	public bool IsBeingExecuted()
	{
		return false;
	}

	private void IPHFCBJOMNM(bool LODLJINCKLF, bool PHCLPAOEAOP)
	{
	}

	private void AMGNGOIJLBI(bool LODLJINCKLF, bool PHCLPAOEAOP)
	{
	}

	private void CLFMDEHBEBH(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	private void NKPHDIKKKJF(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	public void StopSighting()
	{
	}

	public int GetKillCount()
	{
		return 0;
	}

	public int GetDeathCount()
	{
		return 0;
	}

	public int GetMaxKillStacks()
	{
		return 0;
	}

	public virtual byte GetFootballGameTeamID()
	{
		return 0;
	}

	public virtual int GetFootballGameScore()
	{
		return 0;
	}

	public virtual int GetFootballGameAssist()
	{
		return 0;
	}

	public void OnKillCountChanged(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	public void OnPlayerDeadCountChanged(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	public void OnPlayerAssistCountChanged(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	public void OnPlayerTotalDamageChanged(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	public void OnPlayerCurCSShopReinforceChanged(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	public void OnPlayerCurCoinChanged(int OJEPOBEENEK, int EIOKHLKJEEL)
	{
	}

	protected IEnumerator CMHICBPDECF(int OJEPOBEENEK, int EIOKHLKJEEL)
	{
		return null;
	}

	public void OnPlayerEarnedCoinChanged(ushort OJEPOBEENEK, ushort EIOKHLKJEEL)
	{
	}

	public void OnPlayerFactionIDChanged(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	public void OnPlayerSyncMatchStartBuff(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	public void OnScanEnemyCntChange(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	public void OnDetectiveScanStageChanged(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	private void DNKNOEOBFNI(byte OBHFBKHCNMG, byte DFAKKDJBOHC)
	{
	}

	private void HDCMHFNKNKE(int OJEPOBEENEK, int EIOKHLKJEEL)
	{
	}

	private void GNOAILAIGNB(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	public void OnPlayerIdentityChanged(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	public void OnPlayerODFactionChanged(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	public uint GetPVEKillCount()
	{
		return 0u;
	}

	public void OnPlayerPVEKillCountChanged(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	public uint GetSelfReviveCount()
	{
		return 0u;
	}

	protected void CKPEFANBPOE(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	protected void PJDGMFBMFPB(ushort OJEPOBEENEK, ushort EIOKHLKJEEL)
	{
	}

	protected void KHMEMIJNMBK(ushort OJEPOBEENEK, ushort EIOKHLKJEEL)
	{
	}

	public void OnPlayerThrowKnifePhaseChanged(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	public void OnPlayerMaxHypeChanged(ushort OJEPOBEENEK, ushort EIOKHLKJEEL)
	{
	}

	public void OnPLayerMaxHypeLevelChanged(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	public void OnPlayerCurHypeChanged(ushort OJEPOBEENEK, ushort EIOKHLKJEEL)
	{
	}

	public void OnSkillMightyEnergyChanged(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	private void HEKNFNGOELP()
	{
	}

	private void GJMMAMKINBP(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	public void OnEscortTimeChanged(ushort OJEPOBEENEK, ushort EIOKHLKJEEL)
	{
	}

	public void OnPlayerHypeLevelChanged(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	public void OnPlayerTrainingGameQueueInfoChange(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	public void OnPlayerTrainingZoneTypeIamInChanged(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	protected virtual void IBDKOMBKFJC()
	{
	}

	protected virtual void LIAHLMALFIA(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	protected virtual void DFJINNIHGLM(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	private void LIMGHPOGBGL(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	private void FCFAMIMBHHN(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	public NMCBIHOOFFF Get3PFiringStateFromPRI()
	{
		return NMCBIHOOFFF.ESTARTFIRESTATE_NONE;
	}

	private void AEBIPPFLKIM(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	private void IIACAIEFIEP(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	private void ACPPCCOPCEM(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	private void FAFLPMKLLPP(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	private void EHEBMMHEHMI(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	private void BPCLLIFAOCD(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	private void FIJJABAOMEC(ushort OJEPOBEENEK, ushort EIOKHLKJEEL)
	{
	}

	private void IABNBKOFDFL(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	private void CBGCKLOLGNH(ulong OJEPOBEENEK, ulong EIOKHLKJEEL)
	{
	}

	private void NKAKLNENJKA(ulong OJEPOBEENEK, ulong EIOKHLKJEEL)
	{
	}

	private ResourceID FBGDFOLCACI()
	{
		return default(ResourceID);
	}

	public bool ShowHandWeaponHitEffect()
	{
		return false;
	}

	public void PlayHurt(ResourceID AFBJABCGPHB, int HPPACPHIPCP = -10000)
	{
	}

	private void AMBLHAKPEGL()
	{
	}

	private void EGIFHHBPOAK(uint JDHNCLHNJIP)
	{
	}

	private void OFFGMNLNOIJ(uint PLNDNBINKOA, ResourceID CICBIIJABAP, GameObject KGJNMPHDKAB)
	{
	}

	private void IFDICEPEPLG(uint PLNDNBINKOA, ResourceID CICBIIJABAP, GameObject KGJNMPHDKAB)
	{
	}

	public void PlayHeal()
	{
	}

	private void NGGALPNBLPN(uint PLNDNBINKOA, ResourceID CICBIIJABAP, GameObject KGJNMPHDKAB)
	{
	}

	public void OnPlayerInRoomChanged(bool OJEPOBEENEK, bool EIOKHLKJEEL)
	{
	}

	public void OnPlayerTrainingTokenChanged(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	public void OnPlayerMiniGameEffectChanged(ushort OJEPOBEENEK, ushort EIOKHLKJEEL)
	{
	}

	public void OnPlayerAmuseLevelChanged(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	public List<uint> MysteryBoxQualityList()
	{
		return null;
	}

	public void OnPlayerMysteryBoxQualityChanged(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	public void OnPlayerPickedBountyContract(bool OJEPOBEENEK, bool EIOKHLKJEEL)
	{
	}

	public void OnPlayerPickedMissionBountyContract(ulong OJEPOBEENEK, ulong EIOKHLKJEEL)
	{
	}

	public void OnPlayerAndrewSkillEffectCountChange(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	private void MIIILJFGMIB(bool OJEPOBEENEK, bool EIOKHLKJEEL)
	{
	}

	protected virtual void NEELJDFHBFK(int OJEPOBEENEK, int EIOKHLKJEEL)
	{
	}

	private void GMHMPACBAJN(bool GNBOOELAHNP, bool LAHMCKAGGCO)
	{
	}

	private void BHAJBCIJGOO(bool GNBOOELAHNP, bool LAHMCKAGGCO)
	{
	}

	private void KPGCNFINMOP(bool GNBOOELAHNP, bool LAHMCKAGGCO)
	{
	}

	private void PANHMKFPPNJ(bool GNBOOELAHNP, bool LAHMCKAGGCO)
	{
	}

	private void PBIFECHEBMI(uint JDHNCLHNJIP, ResourceID JMIMKLAELHE, GameObject HLOJNJKPNDH)
	{
	}

	private void AEGLCLFJFDE(uint PNKFMAOBNKM, uint FDOIFCNAECL)
	{
	}

	private void GPDIPHLOAGE(ulong GNBOOELAHNP, ulong LAHMCKAGGCO)
	{
	}

	private void LAMBLMHNIKB(float GNBOOELAHNP, float LAHMCKAGGCO)
	{
	}

	private void PDIMAEDBHNG(float GNBOOELAHNP, float LAHMCKAGGCO)
	{
	}

	private void BPCKLDOLONM(float GNBOOELAHNP, float LAHMCKAGGCO)
	{
	}

	private void LJGOPKHODNJ(byte GNBOOELAHNP, byte LAHMCKAGGCO)
	{
	}

	private void AJMHCCKDEGJ(byte GNBOOELAHNP, byte LAHMCKAGGCO)
	{
	}

	private void PBNIJNCJGMA(ushort OJEPOBEENEK, ushort EIOKHLKJEEL)
	{
	}

	private void EMHOGCGDMCN(ulong OJEPOBEENEK, ulong EIOKHLKJEEL)
	{
	}

	private void LAGAMDKKMAG(ushort OJEPOBEENEK, ushort EIOKHLKJEEL)
	{
	}

	public void OnPlayerCurCapacityChange(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	public void OnPlayerExtraCapacityChange(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	public void OnPlayerMaxCapacityChange(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	private void FNKIBLMFDDG(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	private void EFCAMBNKIBH()
	{
	}

	private void MDLAADPKEBO(uint EIOKHLKJEEL)
	{
	}

	private void NLLLNPLICEF(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	private void AMFCFIINNAK(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	private void MJEAHJDMCEN(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	private void PJJPKLHKDJA(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	private void MNPNJHJNKNL(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	private void FOKLAEEJPCF(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	private void FKKFDGMBGON(float OJEPOBEENEK, float EIOKHLKJEEL)
	{
	}

	private void KJOOACJNGLE(float OJEPOBEENEK, float EIOKHLKJEEL)
	{
	}

	private void MCMHNBNLDPD(bool OJEPOBEENEK, bool EIOKHLKJEEL)
	{
	}

	public void OnPlayerMetroArrestChanged(int OJEPOBEENEK, int EIOKHLKJEEL)
	{
	}

	public void OnSpecialCSBattleLevel_LevelChange(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	public void OnSpecialCSBattleLevel_ExpChange(ushort OJEPOBEENEK, ushort EIOKHLKJEEL)
	{
	}

	public void OnBattleStyleLevelChange(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	public void OnBattleStyleExpChange(ushort OJEPOBEENEK, ushort EIOKHLKJEEL)
	{
	}

	private void MLCOCNFGGHB(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	private void JICKHMMNOIJ(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	public void OnGameGlobalMissionKingChanged(bool OJEPOBEENEK, bool EIOKHLKJEEL)
	{
	}

	public void OnPlayerIsRescuredStateChanged(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	private void ENGELBMBFLN(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	private void NALBAFJFLNG(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	private void LIGLCBCJPPD(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	private void LNHIPGHJBHH(bool OJEPOBEENEK, bool EIOKHLKJEEL)
	{
	}

	private void LDPIILAKLOG(ushort OJEPOBEENEK, ushort EIOKHLKJEEL)
	{
	}

	private void HEKMNPJKLHI(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	private void GFDOLAOBJDB(ulong GNBOOELAHNP, ulong LAHMCKAGGCO)
	{
	}

	private void NIMGKDOEPJI(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	public bool IsOnIIVFloatingLand()
	{
		return false;
	}

	private void GKOMKFPKODF(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	private void GFBGKBIFKII(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	private void INLOKLKHFBD(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	private void FJBFHBGDBHA(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	private void GLLIOMMFECO(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	private void GLIFINODNEA(bool OJEPOBEENEK, bool EIOKHLKJEEL)
	{
	}

	private void JADNOECDPPC(int OJEPOBEENEK, int EIOKHLKJEEL)
	{
	}

	private void CLHJJNAIHKN(int OJEPOBEENEK, int EIOKHLKJEEL)
	{
	}

	public void OnEnterIIVEgg(byte AJPCBMBKNJC)
	{
	}

	private void FMDGEJGHLIG(byte EIOKHLKJEEL)
	{
	}

	private void OPJEIJIKLML(uint JDHNCLHNJIP, ResourceID JMIMKLAELHE, GameObject KGJNMPHDKAB)
	{
	}

	private void MEGIKHEBCDN(uint JDHNCLHNJIP, ResourceID JMIMKLAELHE, GameObject KGJNMPHDKAB)
	{
	}

	private void MGLDHIBGFLE()
	{
	}

	private void NDADACHJKKI()
	{
	}

	private void LBLMPFMNOFN(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	private void FFPNMHIGHLC(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	private void DJBACMEFBJH(uint GNBOOELAHNP, uint LAHMCKAGGCO)
	{
	}

	public ulong GetIceWallModuelStartTime()
	{
		return 0uL;
	}

	private void JCKHFPPJCCI(ulong OJEPOBEENEK, ulong EIOKHLKJEEL)
	{
	}

	private void PGBLMDNAKPK(bool OJEPOBEENEK, bool EIOKHLKJEEL)
	{
	}

	private void AEFPOMMAJEP(bool OJEPOBEENEK, bool EIOKHLKJEEL)
	{
	}

	private void FJOFPLPGDKG(bool OJEPOBEENEK, bool EIOKHLKJEEL)
	{
	}

	private IEnumerator APFADGFABBG()
	{
		return null;
	}

	private void CLMDJFKFGBJ(ulong OJEPOBEENEK, ulong EIOKHLKJEEL)
	{
	}

	private void IPNNKLMCJDL(bool OJEPOBEENEK, bool EIOKHLKJEEL)
	{
	}

	private void PENJMDILPMG(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	private void JDCAEFEEOGO(bool OJEPOBEENEK, bool EIOKHLKJEEL)
	{
	}

	public void OnSnowmanModeSnowBallSpeedUpChange(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	public bool IsSnowmanModeSnowBallSpeedUp()
	{
		return false;
	}

	public void OnWeRunRetreatTimeChanged(ulong OJEPOBEENEK, ulong EIOKHLKJEEL)
	{
	}

	public void UpdateRetreatViewWhileObChanged()
	{
	}

	public void OnCurSafeBoxMaxCapacityChanged(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	public void OnSafeBoxCapacityChanged(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	public void OnBringIntoInvPriceChanged(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	public void OnPlayerNextTimeCanUseActiveSkill(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	public void OnPlayerHippoCrisisMissionTokenChanged(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	public uint GetPlayerHippoCrisisMissionToken()
	{
		return 0u;
	}

	public uint PlayerNextTimeCanUseActiveSkill()
	{
		return 0u;
	}

	public void OnSlideGroup(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	public void OnEighthTeamInfoIconChange(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	public void OnIIV1v1BattleSceneChangeProcessOutline()
	{
	}

	public void TryTurnOnIIV1v1Outline()
	{
	}

	public void TryTurnOffIIV1v1Outline()
	{
	}

	private Material MCCODPEGKBM()
	{
		return null;
	}

	private void NDKGHBBFNPC(Material BIDLJGGGGJB, Color NJMGFOAPCGA)
	{
	}

	public void OnAllInvPriceChanged(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	public void OnHippoCrisisInComeScoreChanged(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	private void BJAHNGLGKPD(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	private void DONOCIOLLPK(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	private void JOLALBJEHFJ(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	public void SetFireStatePRIData(byte GPFPIAMCEMI)
	{
	}

	public void SetSightingPRIData(uint GPFPIAMCEMI)
	{
	}

	private void IPCGHBMLCKA(float OJEPOBEENEK, float EIOKHLKJEEL)
	{
	}

	private void EOLNPNDAIAH(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	private void MLJNCHBKFBM(float OJEPOBEENEK, float EIOKHLKJEEL)
	{
	}

	private void INAKIPNBLDB(ulong OJEPOBEENEK, ulong EIOKHLKJEEL)
	{
	}

	private void JHLDJDDIPIJ(bool OJEPOBEENEK, bool EIOKHLKJEEL)
	{
	}

	public bool IsPlayerUnderWater()
	{
		return false;
	}

	private void LHPHDKGIJHF(bool OJEPOBEENEK, bool EIOKHLKJEEL)
	{
	}

	private void AMDGOMEIJBJ(bool OJEPOBEENEK, bool EIOKHLKJEEL)
	{
	}

	private void OHFHJGBIJAH(bool OJEPOBEENEK, bool EIOKHLKJEEL)
	{
	}

	public bool IsInUseTeamGatherPointCD()
	{
		return false;
	}

	public int UseTeamGatherPointLeftTime()
	{
		return 0;
	}

	private void APEIKNEONEN(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	public EHAFOPMKHJO HandleLandingFightProtectionInfoChange(BHGGAEEHJCO OBMFMAKFDDL, uint EIOKHLKJEEL)
	{
		return null;
	}

	protected void MHGIHENEACB()
	{
	}

	protected void JKGPDAOFNEN()
	{
	}

	public bool IsLockFire()
	{
		return false;
	}

	public bool IsShowLockFireUI()
	{
		return false;
	}

	public float GetLockFireFinishProgress()
	{
		return 0f;
	}

	public bool ShouldShowLockFireUI()
	{
		return false;
	}

	public void SetLockSlot(HDAEFOANBGJ DBPNIDJEAAE, uint LKHIALHNOLD, bool FDNEJJLHNIH)
	{
	}

	public bool IsGrenadeBtnLocked(HDAEFOANBGJ DBPNIDJEAAE)
	{
		return false;
	}

	public void StartSAPJumpBeforeGlid()
	{
	}

	public void StartSAPGlid()
	{
	}

	public virtual bool IsApplyingServerAuthorizedPhysXStateSwitch()
	{
		return false;
	}

	public void SwitchPhysXStateByServerAuthorizedCascade(IGJPHDANPJD GCJPAAPKMMA, EOGPGNIDOKF KLDJLKMKKOJ)
	{
	}

	protected virtual void GGGIFHDHFMN(IGJPHDANPJD GCJPAAPKMMA, EOGPGNIDOKF KLDJLKMKKOJ)
	{
	}

	protected virtual void AHDOPMLAKFD(IGJPHDANPJD GCJPAAPKMMA, EOGPGNIDOKF KLDJLKMKKOJ)
	{
	}

	public virtual bool ShouldUseServerAuthorizedPhysXStateSwitch(IGJPHDANPJD LJIIDCPCAEG, IGJPHDANPJD EPHJNAOJPOI, JOLPCBKIKEJ OINKNIGKDMO)
	{
		return false;
	}

	public virtual void RequestOrSwitchPhysXState(IGJPHDANPJD GCJPAAPKMMA, EOGPGNIDOKF KLDJLKMKKOJ, JOLPCBKIKEJ OINKNIGKDMO)
	{
	}

	public virtual bool ShouldIgnoreSyncedPhysXState(IGJPHDANPJD CHDPPLFBCJA, EOGPGNIDOKF DCAINEHMMOA, uint OOEJHOGKNIG)
	{
		return false;
	}

	protected virtual void NEFNEKEKGPC()
	{
	}

	private void LAKGPJFGPOG()
	{
	}

	public void ShowRoleVFX()
	{
	}

	public void ShowRoleUIFX()
	{
	}

	private void BJOBHDODPHD(uint JDHNCLHNJIP, ResourceID JMIMKLAELHE, GameObject KGJNMPHDKAB)
	{
	}

	public void PlayRoleSound()
	{
	}

	public Transform GetChangeRoleVFXTrans()
	{
		return null;
	}

	public void OnTrackerTargetUpdate(BHGGAEEHJCO KPCKNLHLEGK)
	{
	}

	public void OnTrackerTargetUpdateShowHeartVFX()
	{
	}

	public void ClearTracker(bool FJOBGBFFPPO = false)
	{
	}

	public void ShowBeTrackedTips(bool PPLEEBEILFO = false)
	{
	}

	private void HMHKIADLPKE(uint JDHNCLHNJIP, ResourceID JMIMKLAELHE, GameObject KGJNMPHDKAB)
	{
	}

	private void KCJICMDLCPN(uint JDHNCLHNJIP, ResourceID JMIMKLAELHE, GameObject KGJNMPHDKAB)
	{
	}

	private void EDGDPLFBLLP(LBGFNBCJHMN FNONHJPIEFK, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	private void MJFNFFDBPDF(LBGFNBCJHMN FNONHJPIEFK, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	private void GPCEDNGCGHJ()
	{
	}

	private void OFCCAHHBPCH(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	private void HFIAOHLONIE(LBGFNBCJHMN FNONHJPIEFK, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	private void KALAGDEJCJO(LBGFNBCJHMN FNONHJPIEFK, EJOKDFLEONG GGNDHHOPOAC)
	{
	}

	public void PlayUseGhostVFX(Vector3 IGDHIDGLOKG)
	{
	}

	private void HOHEMECGCNN()
	{
	}

	private void FIONPHABHMG(uint JDHNCLHNJIP, ResourceID JMIMKLAELHE, GameObject KGJNMPHDKAB)
	{
	}

	private void NBCJOLALMAP()
	{
	}

	public void OnBeReaper(int CJPOIGAKFPF, BHGGAEEHJCO GEKCACGOBLK)
	{
	}

	public int GetBeReaperReaminTime()
	{
		return 0;
	}

	public bool IsBeReapering()
	{
		return false;
	}

	public void ClearBeReaper()
	{
	}

	private void NDKKMBOMKDH()
	{
	}

	private void GOFJIINNKCB(KDHEPHOMCMD LLGADNLPALG)
	{
	}

	private void PDIPLJFMMDM(uint LKHIALHNOLD)
	{
	}

	public uint AttachLinkPlayerEffect(ResourceID HGOKNGMKOPG, BHGGAEEHJCO MBKEMNMAFFN, uint AAOAKEKLDJD = 0u, ManagedVisualInstanceHolder.OnManagedInstanceAttached IKNHMADBKPE = null, ResourceManager.LoadPriority AJDEHHPFDBF = ResourceManager.LoadPriority.Normal)
	{
		return 0u;
	}

	private void KFEPOBKIPHI(uint JDHNCLHNJIP, ResourceID JMIMKLAELHE, GameObject KGJNMPHDKAB)
	{
	}

	public void DetachLinkPlayerEffect(ref uint LKHIALHNOLD)
	{
	}

	public void ClearAllLinkEffect()
	{
	}

	protected void LIFKONIGIHJ()
	{
	}

	private Vector3 JIPAJDMIFEF()
	{
		return default(Vector3);
	}

	public Vector3 GetSyncStatePos()
	{
		return default(Vector3);
	}

	public bool IsUGCSkateBoarding()
	{
		return false;
	}

	protected bool LBELFCHKAKJ()
	{
		return false;
	}

	public void InitSkateboardCd(float DPOBAELACHL, float LHMEMCGCCBH)
	{
	}

	private void KGKHDPPMCLH()
	{
	}

	public float GetSkateboardCdSecs()
	{
		return 0f;
	}

	public float GetSkateboardRemainingCdSecs()
	{
		return 0f;
	}

	private void MFJEDMPDPCE()
	{
	}

	public void RequestStartSkateboarding()
	{
	}

	private bool GLEMAJOICDF()
	{
		return false;
	}

	public void RequestStopSkateboarding()
	{
	}

	public void RequestStopSkateboarding(LHNKJIAKJKM OINKNIGKDMO)
	{
	}

	public void OnGetOnSkateboard(LHNKJIAKJKM OINKNIGKDMO)
	{
	}

	public void OnGetOffSkateboard(LHNKJIAKJKM OINKNIGKDMO)
	{
	}

	protected virtual void HOKAEHNOJLD()
	{
	}

	protected virtual void EFOODAMNLIK()
	{
	}

	private void NCJADGEJPGF()
	{
	}

	private void BCLIMEFNFLN()
	{
	}

	protected void LNMLDNCBLHM(bool HCLGHJNEFIC)
	{
	}

	protected void LNMLDNCBLHM(bool HCLGHJNEFIC, bool KMIAINMMKDN)
	{
	}

	private void FAGCNAAFLIC(GameObject CLACOPMJHDI)
	{
	}

	protected void KFLPBEBKLDE()
	{
	}

	private void GNBODABPGJO()
	{
	}

	private void HGPNLOEGKCI()
	{
	}

	private static bool PHNJLEGPLDP(GameObject CLACOPMJHDI, bool HCLGHJNEFIC)
	{
		return false;
	}

	public void EnableCapsuleCollider(bool HCLGHJNEFIC)
	{
	}

	protected void PMGPBBPEOMD(bool EMGHOEADFHI)
	{
	}

	protected void COBBLEJDPED()
	{
	}

	public void SetupSkateboardCamera()
	{
	}

	public bool CanSkateboardJump()
	{
		return false;
	}

	public void RequestSkateboardJump()
	{
	}

	public void OnSkateboardJump()
	{
	}

	private void NDKHBBDGPNA()
	{
	}

	private void DNDCMBKKOPK()
	{
	}

	public float GetSkateboardJumpCdSecs()
	{
		return 0f;
	}

	public float GetSkateboardJumpRemainingCdSecs()
	{
		return 0f;
	}

	public bool CanSkateboardDash()
	{
		return false;
	}

	public void RequestSkateboardDash()
	{
	}

	public void OnStateboardDash()
	{
	}

	private void AHBCCKGJHGB()
	{
	}

	private void CKJAJOFGBIC()
	{
	}

	private void HGAKOGHODGC()
	{
	}

	public float GetSkateboardDashRemainingCdSecs()
	{
		return 0f;
	}

	public float GetSkateboardDashCdSecs()
	{
		return 0f;
	}

	private bool IMNCLLJHMLJ()
	{
		return false;
	}

	protected virtual void FLMBAKLJEGD(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	protected void DEJOJIMBJDN(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private bool EEMAPAEIEBE()
	{
		return false;
	}

	private bool EPHEDHHKIBM()
	{
		return false;
	}

	protected virtual void JIOONEOCCBM()
	{
	}

	protected void EBLEMAEFDEK()
	{
	}

	protected void IPFILICAKIL(out bool LBMHEHGEDMF, out bool OBHGGNIDELE)
	{
		LBMHEHGEDMF = default(bool);
		OBHGGNIDELE = default(bool);
	}

	private void HCOEILEBIEK()
	{
	}

	private void MHEJFIBKJGN()
	{
	}

	private void PONEKAMNANB()
	{
	}

	private void IFLNFKCDIPL()
	{
	}

	private void KPOBPNDKLNG()
	{
	}

	private void IIIBJGCDAIF()
	{
	}

	private void IKHKCPMNPPF(string DGDDJLEOPBL)
	{
	}

	public void UpdateSkateboardControllerByUGC()
	{
	}

	public void ResetParachuteInfoLog()
	{
	}

	public virtual bool RequestSkySurfing()
	{
		return false;
	}

	public virtual bool RequestFastFalling()
	{
		return false;
	}

	public virtual bool RequestSkyDiving()
	{
		return false;
	}

	public void InitSnowSlideGetOnCd()
	{
	}

	public float GetSnowSlideGetOnCdSecs()
	{
		return 0f;
	}

	public float GetSnowSlideGetOnRemainingCdSecs()
	{
		return 0f;
	}

	public void RefreshSnowSlideGetOnCd()
	{
	}

	public bool IsInSnowSlideGrab()
	{
		return false;
	}

	public bool CanSnowSlideGrab()
	{
		return false;
	}

	public bool IsPlayerInSnowSlideDash()
	{
		return false;
	}

	public JCEIFNJPLAG GetSnowSlideEquipment()
	{
		return null;
	}

	public bool IsEquippedSnowSlideInventory(PIJKGPDBNJC PIBMPJLGDMO = PIJKGPDBNJC.MAX)
	{
		return false;
	}

	private bool AFOKDKJJIOH()
	{
		return false;
	}

	private bool DGNIDBCEDDA()
	{
		return false;
	}

	public bool CanSnowSlideSpeedTakeEffect()
	{
		return false;
	}

	public void SetSnowSlideSurfBoardVisible(bool OGECPGHMIHA)
	{
	}

	public void LocalStopSnowSlideGrab()
	{
	}

	public void LocalStartSnowSlideGrab()
	{
	}

	protected void HMHOFKNAJNN()
	{
	}

	private bool DLMLPLLAEIP()
	{
		return false;
	}

	private void GEJMIGDCOHD(uint JDHNCLHNJIP, ResourceID AKANMDDBKBP, GameObject KGJNMPHDKAB)
	{
	}

	private void GIAAGBJHJHK()
	{
	}

	public void SwitchSnowSlideLowSpeedMode(bool OGECPGHMIHA)
	{
	}

	public void SwitchSnowSlideState(bool DPHOEKJFJMN)
	{
	}

	public void RequestSnowSlideAction(OCEKKEPPHBK AJGGGMEFCHF = OCEKKEPPHBK.EGetOnSnowSlideReason_PlayerInput)
	{
	}

	private bool IGAFNDDIBLN(OCEKKEPPHBK AJGGGMEFCHF = OCEKKEPPHBK.EGetOnSnowSlideReason_PlayerInput)
	{
		return false;
	}

	public bool CheckCanGetOnSnowSlide()
	{
		return false;
	}

	private void NBDCEKCNNJM()
	{
	}

	private void HCNMKPMBIDF()
	{
	}

	protected void ACDEOMCBCLE()
	{
	}

	public bool CanSnowSlideAutoRotate()
	{
		return false;
	}

	public void StartAutoRotate()
	{
	}

	public void ResetAutoRotateTimer()
	{
	}

	public void StopAutoRotate()
	{
	}

	public void UpdateAutoRotateTimer()
	{
	}

	public void SnowSlideGrabRotate()
	{
	}

	public void UpdateSnowSlideRototeEffect(bool GJMJDOELOPA)
	{
	}

	private uint MFDFIIIDMPL(bool GJMJDOELOPA)
	{
		return 0u;
	}

	public void StopSnowSlideRotateEffect()
	{
	}

	private void MNFLILGABKP()
	{
	}

	public void OnGrabFinishedCircleSyncResult(uint EAEAGPLECPJ)
	{
	}

	public void UpdateSnowSlideMoveEffect()
	{
	}

	private bool MONLAMDOBDF()
	{
		return false;
	}

	public void SnowSlideOnTransformSkillTakeEffect()
	{
	}

	public void UpdateSnowSlideTurnEffect(float AOOCNKPILEO, float IMKNJGHAHPI)
	{
	}

	private uint PBEKLBFGLFE(float AOOCNKPILEO, float IMKNJGHAHPI)
	{
		return 0u;
	}

	public void StopSnowSlideTurnEffect()
	{
	}

	public void StopSnowSlideSpeedEffect()
	{
	}

	public void UpdateSnowSlideSpeedEffect(float IMKNJGHAHPI)
	{
	}

	private uint NCAMJJHMDII(float IMKNJGHAHPI)
	{
		return 0u;
	}

	private void ILDCMFACEMP()
	{
	}

	private Vector3 FEFFEIKMHJN()
	{
		return default(Vector3);
	}

	private void ODLDKJEPCAC(float IMKNJGHAHPI)
	{
	}

	private void CGCFIHLJKFK()
	{
	}

	private ResourceID EPFGGNJBJJA()
	{
		return default(ResourceID);
	}

	private void LGAAAPDNPAB()
	{
	}

	public void OnPlayerSnowSlideVisibleChanged(bool OGECPGHMIHA)
	{
	}

	public bool TryAutoJumpOnSnowSlideWay()
	{
		return false;
	}

	public bool JumpOnSnowSlideWayToDash()
	{
		return false;
	}

	private float PPEBKBPBGPF()
	{
		return 0f;
	}

	private void DLOABJNEADM(float DNKICMMKHJN)
	{
	}

	private void MOGCDJFOAAC()
	{
	}

	public void OnEnterSnowSlideWay(Collider GLJGHEAPBOF)
	{
	}

	public void OnExitSnowSlideWay(Collider GLJGHEAPBOF)
	{
	}

	public void OnEnterSnowSlideWayAutoJumpTrigger(Collider GLJGHEAPBOF)
	{
	}

	private void PLNFCNOHCFO()
	{
	}

	public bool IsInLobbySocialDeform()
	{
		return false;
	}

	public bool IsInScaleUpDeform()
	{
		return false;
	}

	public bool IsInScaleDownDeform()
	{
		return false;
	}

	public bool IsInLegDeform()
	{
		return false;
	}

	private void HENDGHFBANG(ref float AGDFLNEDMHG, ref float KFLAIMOIPPK)
	{
	}

	public bool IsHeadScaleUp(uint CLLNGCEEBDL)
	{
		return false;
	}

	public bool IsHeadScaleDown(uint CLLNGCEEBDL)
	{
		return false;
	}

	public bool IsFootScaleUp(uint CLLNGCEEBDL)
	{
		return false;
	}

	public bool IsFootScaleDown(uint CLLNGCEEBDL)
	{
		return false;
	}

	public bool IsSlotInDeform(uint CLLNGCEEBDL, LobbySocialPropType DBPNIDJEAAE)
	{
		return false;
	}

	private float OACAKNJMFEC(LobbySocialPropType DBPNIDJEAAE)
	{
		return 0f;
	}

	private float PGLKHIMACAM(LobbySocialPropType DBPNIDJEAAE)
	{
		return 0f;
	}

	private float IHCPOMKJBFK(LobbySocialPropType DBPNIDJEAAE)
	{
		return 0f;
	}

	private float DEAPEKFDKPC()
	{
		return 0f;
	}

	private void PEBONDPMLOL(Vector3 FBGGBFJJDIO)
	{
	}

	public void BeginSocialLobbyPrivilegeDeform(uint CLLNGCEEBDL)
	{
	}

	public void ClearSocialLobbyPrivilegeDeformVisual()
	{
	}

	private void AKEBOJLFAIN()
	{
	}

	private void NGLIMBMNHMI()
	{
	}

	public void RequestBigHeadOrSocialLobbyDeformHangSetupAfterAvatarChanged()
	{
	}

	private PlayerSocialLobbyDeformPreHangUpdater HGMFIDICJDH()
	{
		return null;
	}

	public void PlaySocialLobbyDeformEffect()
	{
	}

	private void KGPGFIEKJFM()
	{
	}

	private void OIMCACDJNJG(uint LLPCGNCFPJJ = 0u)
	{
	}

	public void ApplySocialLobbyPrivilegeDeformLateUpdate()
	{
	}

	private void OCCCAPEKBDJ()
	{
	}

	private void NGOODNCGKEG()
	{
	}

	private float AINHJIGKKIO()
	{
		return 0f;
	}

	private void DILPDHDGNNI()
	{
	}

	private static bool CNLKKOFBOMO()
	{
		return false;
	}

	private bool KHOFPJIDBEA()
	{
		return false;
	}

	private bool IHHBJKENMAF()
	{
		return false;
	}

	public void UpdateSprintMeleeSpinePitchCompensation()
	{
	}

	protected virtual void KHLGMLHDMHN()
	{
	}

	public void InitStatus(IGJPHDANPJD GCJPAAPKMMA, EOGPGNIDOKF KLDJLKMKKOJ)
	{
	}

	private bool LJBGMKKCKEL(IGJPHDANPJD GCJPAAPKMMA, EOGPGNIDOKF KCMJONOCMPN)
	{
		return false;
	}

	public virtual void SwitchPhysXState(IGJPHDANPJD GCJPAAPKMMA, EOGPGNIDOKF KLDJLKMKKOJ = EOGPGNIDOKF.EPHYSXPOSE_STANDING)
	{
	}

	protected void HCAFJOPKMCJ(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM, IGJPHDANPJD GCJPAAPKMMA, EOGPGNIDOKF KLDJLKMKKOJ)
	{
	}

	public void CheckAuxAimStatusChanged()
	{
	}

	private void FALHIBNAFNH(bool HCKPEAOIMPI)
	{
	}

	private void CHADAEAHJAK(IGJPHDANPJD OLAHOFPELBC, EOGPGNIDOKF IDAFLIAIKDM, IGJPHDANPJD GCJPAAPKMMA, EOGPGNIDOKF KLDJLKMKKOJ)
	{
	}

	public virtual void SwitchPhysXPose(EOGPGNIDOKF KCMJONOCMPN)
	{
	}

	public void ResumeFootPrintsByPlayerStatus()
	{
	}

	public void PauseFootPrintsByPlayerStatus()
	{
	}

	public virtual IPetsPawnAnimPlayer GetPetsPawnAnimPlayer()
	{
		return null;
	}

	public void SetStealth(bool EMGHOEADFHI, FJICOMELIAG LLGADNLPALG)
	{
	}

	protected void HLGGOLKJCEB()
	{
	}

	private void CLAEPBJDGAO()
	{
	}

	private void OONPPNLIDMM()
	{
	}

	private void KOAFIDOLMFH()
	{
	}

	private void IBACHLCGNCO()
	{
	}

	private void EDKNBENJOAM()
	{
	}

	private bool OJMNFDOFNHO()
	{
		return false;
	}

	private void INFHHEPLODP(Transform AMKCMECCDEB, bool KIGFNFIIJNK = false)
	{
	}

	private void LEBCJCHAIDN()
	{
	}

	private void FHOCPMAANAA()
	{
	}

	private void EEODIAGKENC()
	{
	}

	private void DOJKKPPEJDN()
	{
	}

	public bool IsInStealth()
	{
		return false;
	}

	public bool IsReallyInStealth()
	{
		return false;
	}

	public bool CanBeAimAssistByStealth()
	{
		return false;
	}

	public bool IsReallyInStealthByUID(MKDPGKLHAFK GKKPLFICGFJ)
	{
		return false;
	}

	public void SendHighlightInStealth()
	{
	}

	private bool JHCFAGGJDOP()
	{
		return false;
	}

	public virtual bool RequestPlayBooyahSuperEmote(uint EHCHPPDBJLK)
	{
		return false;
	}

	public void OnRequestPlayBooyahSuperEmoteRes(COOJMNODMOC APHHNHEDHKD)
	{
	}

	private void MPNKGOCJPKO(BHGGAEEHJCO KJLFMPOFELA, uint EHCHPPDBJLK)
	{
	}

	public virtual bool RequestPlaySuperEmote(uint EHCHPPDBJLK)
	{
		return false;
	}

	public void OnRequestPlaySuperEmoteRes1P(COOJMNODMOC APHHNHEDHKD)
	{
	}

	public void OnRequestPlaySuperEmoteRes3P(COOJMNODMOC APHHNHEDHKD)
	{
	}

	private void LLDIHNDGAKD(BHGGAEEHJCO KJLFMPOFELA, uint EHCHPPDBJLK)
	{
	}

	public virtual bool RequestPlaySuperEmoteInteractiveAnimation(uint EHCHPPDBJLK, Player HOGELIPBAJI)
	{
		return false;
	}

	private void GHELCABOEEH(Player HOGELIPBAJI, uint PJMMDOONDOP)
	{
	}

	public void OnRequestPlaySuperEmoteInteractiveAnimationRes(COOJMNODMOC APHHNHEDHKD)
	{
	}

	private void NIBLKFIOBAH(uint PJMMDOONDOP, BHGGAEEHJCO KJLFMPOFELA, BHGGAEEHJCO AKHCFBBGKGF)
	{
	}

	public bool BeforePlaySuperEmoteCheck(bool GNMFDIOLIDA = true)
	{
		return false;
	}

	private void DLHLMEMFDCD()
	{
	}

	public void OnCabinWaitingEndClearSuperEmoteStatus(HashSet<ResourceID> LNKILBPCJNK, HashSet<ResourceID> PPBNIHBFDAO)
	{
	}

	private void IHNCHAKLMNC()
	{
	}

	private void MLJEEIKFDLC(uint EHCHPPDBJLK)
	{
	}

	public Transform GetSuperEmoteCameraReferenceTransform()
	{
		return null;
	}

	public Animator GetSuperEmoteCameraAnimator()
	{
		return null;
	}

	public void ResetUserControl()
	{
	}

	private void KFMPHMAPFBB()
	{
	}

	private void OPIKIGMGACC()
	{
	}

	private void BPJFIDADGGE()
	{
	}

	private void BNACCPNMFFK()
	{
	}

	private void OMIHCNJBJDE()
	{
	}

	private void MIMBCCGBMMN()
	{
	}

	private void HMHEAJCONOE()
	{
	}

	private void KHHIJOPFAHC()
	{
	}

	public void ClearSuperEmoteSound3P()
	{
	}

	private void KDDPGPBNOIO(uint PMLGEDEDPPL = 0u, uint FMNOENNAPMK = 0u, uint DNELEGPMHBF = 0u)
	{
	}

	public virtual bool RequestStartSwimmingSurfing()
	{
		return false;
	}

	public virtual bool RequestStartSwimmingSurfDash()
	{
		return false;
	}

	public virtual bool RequestStopSwimmingSurfing(bool OMLFJGFOGJP = false)
	{
		return false;
	}

	public virtual bool RequestStartSwimming()
	{
		return false;
	}

	public virtual bool RequestStopSwimming()
	{
		return false;
	}

	public void InitTeamParachuteInfo(object LHLIKBIDIIJ)
	{
	}

	public void InitTeamParachuteInfo(byte NIBBKONKPHP, uint MAPAMOKMDMC, uint ABENBDNEBMB)
	{
	}

	protected virtual void BPPIJBDGHMG()
	{
	}

	private void CKNBHIMABHO(uint AGPNEHKOPIC, uint CJEHJFCCGLK)
	{
	}

	private void AMJEFAIGIMP()
	{
	}

	private void OJJAMNOEBGL(bool NNHEDFLLGGH = true)
	{
	}

	private void DJLLAPJEMIM(CCIPIBCIIDA CEPCNEHMHNI, BHGGAEEHJCO JGIPCJHEKKA)
	{
	}

	private void BFADAHLPJKN(CCIPIBCIIDA CEPCNEHMHNI, BHGGAEEHJCO JGIPCJHEKKA)
	{
	}

	private void BLHEAEBMBAC(bool HMFIBLGDCHK)
	{
	}

	public bool IsRestoreOnBoardAfterLeaveTeamFlight()
	{
		return false;
	}

	private void LDJPJCPCNML()
	{
	}

	public void SetOnBoardDefaultSkyDivingPresentation()
	{
	}

	private void IMALKANPIJG()
	{
	}

	public void TryRebindTeamParachuteAfterTeamFlightExit()
	{
	}

	public void ResetTeamParachuteFollowSimState(string OINKNIGKDMO)
	{
	}

	private void OHHAAHKNAKD()
	{
	}

	private void HJHENCIHPGA()
	{
	}

	private void NGHNKECLBGN()
	{
	}

	protected virtual bool BPCIANKBNJF()
	{
		return false;
	}

	private bool EBCOBKAHELO(byte JDEOKBCMLAN)
	{
		return false;
	}

	protected virtual bool ECDHPHFJHIC()
	{
		return false;
	}

	private bool BPGFPGOAHFL()
	{
		return false;
	}

	protected bool BPGFPGOAHFL(Vector3 IGDHIDGLOKG)
	{
		return false;
	}

	private void LKEKNJAECHI()
	{
	}

	public bool IsSharedTeamFlightState()
	{
		return false;
	}

	public bool HasSharedTeamFlightRelation()
	{
		return false;
	}

	public bool HasPersonalTeamFlightPresentation()
	{
		return false;
	}

	public bool IsTeamFlightPresentationActive()
	{
		return false;
	}

	private bool IIMMOIDGNHH()
	{
		return false;
	}

	private void IOMOLEEAFFM()
	{
	}

	private void IEEEJLIGBPL()
	{
	}

	private void DPODKMIILHK(COEDKLIGPPD AHDONPCGJOL)
	{
	}

	private bool JPMOHAIHLED(COEDKLIGPPD AHDONPCGJOL)
	{
		return false;
	}

	private bool IJEMOKCCJBA()
	{
		return false;
	}

	private bool DAGHMBLIBDN(COEDKLIGPPD AHDONPCGJOL)
	{
		return false;
	}

	private bool GAFAFPDEGPL(COEDKLIGPPD AHDONPCGJOL)
	{
		return false;
	}

	protected void LLFLOPBBCKO(COEDKLIGPPD AHDONPCGJOL)
	{
	}

	private void GAAEDGGDLFD()
	{
	}

	private void FFBMMEHLOJI(BHGGAEEHJCO EFCBHBMAALF)
	{
	}

	private void HABPCMLMONP()
	{
	}

	public void SetTeamFlight(uint ABENBDNEBMB, byte CBCAJJJCKLH, uint AGPNEHKOPIC = 0u, uint CJEHJFCCGLK = 0u, bool ABBIAEHPMDN = false)
	{
	}

	private void EDKCCODAGEB()
	{
	}

	private void PCPIBGCCLCO()
	{
	}

	public void SetTeamParachuteLeaderID(BHGGAEEHJCO MAPAMOKMDMC)
	{
	}

	private void MHFJDOHKBOD(BHGGAEEHJCO JGIPCJHEKKA)
	{
	}

	public void OnBecomeFree()
	{
	}

	public void OnBecomeLeader()
	{
	}

	public void OnBecomeFollower()
	{
	}

	private void GMOFBGMEHFD(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private bool MPIDOKFGNPA()
	{
		return false;
	}

	private bool AIIJDPBFBCL(Vector3 KGDIJNENMJH, Vector3 JDAAHCPNKJG)
	{
		return false;
	}

	private void MAPLKPPCKPG()
	{
	}

	public void OnRequestTeamParachuteLeader(uint OBMFMAKFDDL)
	{
	}

	public void ClientForceBecomeFreeMode()
	{
	}

	public void ResetClientTeamParachuteState()
	{
	}

	public void NotifyServerParachuteFree(bool BMDIHCONEED = false)
	{
	}

	public void NotifyServerTransferLeader(BHGGAEEHJCO MAPAMOKMDMC)
	{
	}

	public void NotifyServerFollowLeader()
	{
	}

	public void OnServerTransferLeaderFail()
	{
	}

	public void OnServerFollowLeaderFail()
	{
	}

	public void ShowParachuteActionBtn()
	{
	}

	public bool IsFollowTeamFlight()
	{
		return false;
	}

	public bool TryGetTeamFlightMapForward(out Vector3 BAPEDKECNLH)
	{
		BAPEDKECNLH = default(Vector3);
		return false;
	}

	public void ResetTeamFlightAnim()
	{
	}

	public AnimationID GetTeamFlightAnim()
	{
		return default(AnimationID);
	}

	public uint GetTeamFlightId()
	{
		return 0u;
	}

	public uint GetSharedTeamFlightId()
	{
		return 0u;
	}

	public bool IsSingleTeamFlight()
	{
		return false;
	}

	public PreviewTeamFlightView GetSingleTeamFlight()
	{
		return null;
	}

	public PreviewTeamFlightView GetPersonalTeamFlight()
	{
		return null;
	}

	public void SetTeamFlightOwner(uint GGOONGCDAIE)
	{
	}

	public void MarkTeamFlightOffBoardWorldPositionForBind(Vector3 IMIHEBBAPPF)
	{
	}

	public bool TryConsumeTeamFlightOffBoardWorldPositionForBind(out Vector3 IMIHEBBAPPF)
	{
		IMIHEBBAPPF = default(Vector3);
		return false;
	}

	public void SetTeamFlightSeatIndex(uint OIMPDJMNOFC, bool KGJFAHIDPHA = true)
	{
	}

	public int GetTeamFlightSeatIndex()
	{
		return 0;
	}

	public int GetSharedTeamFlightSeatIndex()
	{
		return 0;
	}

	public void RequestGetOffTeamFlight()
	{
	}

	public bool IsTeamFlightOwner()
	{
		return false;
	}

	public bool IsTeamFlightDriver()
	{
		return false;
	}

	public Player GetTeamFlightOwner()
	{
		return null;
	}

	public void EquipTeamFlight(bool GLAPLHPDKBE = false)
	{
	}

	public bool IsMultiSeatTeamFlightMove()
	{
		return false;
	}

	private bool JDAHBDBNBAK()
	{
		return false;
	}

	public bool TrySyncTeamFlightMoveAnimFromView()
	{
		return false;
	}

	private void HIDONFCKJMH(string OINKNIGKDMO)
	{
	}

	private bool MEFPDEIANJJ(float FDAGGCDDEKJ, float FOMJCCKNEOL)
	{
		return false;
	}

	private void KPDGAFCDFCI(AnimationID IJJHJMBOKEB, float FOMJCCKNEOL)
	{
	}

	private static bool LGAJGDHGFJN(float FOMJCCKNEOL)
	{
		return false;
	}

	private static float NNPOJFHKKBO(float FOMJCCKNEOL)
	{
		return 0f;
	}

	private static float NJFKLJIFHIF(float FOMJCCKNEOL)
	{
		return 0f;
	}

	private void JCAOPDIJKPA()
	{
	}

	public bool HasTeamFlightAnimController()
	{
		return false;
	}

	public bool IsRealTeamFlight()
	{
		return false;
	}

	public bool CheckIsInTeamFlight()
	{
		return false;
	}

	public void UnEquipTeamFlight()
	{
	}

	private bool JHEBDEPKGBM()
	{
		return false;
	}

	private bool ENINMIBMACI()
	{
		return false;
	}

	private void MJHEGBANDNK()
	{
	}

	private bool IPBEKJPPCMO()
	{
		return false;
	}

	private bool GEFAPJNKAMJ()
	{
		return false;
	}

	private void IFGCPNEJBJL(bool IDCHCEECMBE, string OINKNIGKDMO)
	{
	}

	private void FDFDIHHFGPF(bool HMFIBLGDCHK)
	{
	}

	public void SetParent(Transform FKODMCNOBDM)
	{
	}

	public void ReInitTeamFlight(bool KMGFPKNKFEI = false)
	{
	}

	public void ExitTeamflightUnfollowPlayer(bool ABNNBABDDOG)
	{
	}

	private void FNEOPEJDEEE()
	{
	}

	public void UpdateTokenGunProgressUI(uint EEFLCGEOIFN)
	{
	}

	private void ELOPFFJFNEG()
	{
	}

	public void PlayTokenGunGrantExplodeVFX()
	{
	}

	public virtual void RequestTransform(ResourceID GFIBGNOMBHB, GameObject CLACOPMJHDI = null)
	{
	}

	public void EnterTransform(ResourceID GFIBGNOMBHB, GameObject CLACOPMJHDI = null)
	{
	}

	public void EnterTransform(GameObject CCFEOOAJAMG)
	{
	}

	protected virtual void OBANPBHCBLB(JECKDOPHBBJ ADFNDGOCBMN)
	{
	}

	protected virtual void JFDMEGLIOEK(JECKDOPHBBJ ADFNDGOCBMN)
	{
	}

	public virtual void RequestExitTransform()
	{
	}

	public void ExitTransform()
	{
	}

	protected virtual void MPHPENGOJMO()
	{
	}

	public void SetOrgModelVisible(bool LONOBDDEMCI)
	{
	}

	public void UpdateTransparency(float OKJIFBCMDAD)
	{
	}

	private Material PBPMBLAIJMK()
	{
		return null;
	}

	private void HLDMBAJPBIF(bool EFODJDOHAJH)
	{
	}

	private string HKNAPJELCNK(string JCIFFMHHBHK)
	{
		return null;
	}

	private string GILAJHNHECM(string JCIFFMHHBHK)
	{
		return null;
	}

	private void MHNHEDPOFCL(float EJADDPJOOAH)
	{
	}

	private void FIGFBCOKNGL()
	{
	}

	public void ClearTransprancy()
	{
	}

	private void MMNNLGFABKG(Collider GLJGHEAPBOF)
	{
	}

	private void PPBJPLBKMHL()
	{
	}

	public bool CheckCanOpenTreasureHuntUnderTreasury(Collider GLJGHEAPBOF)
	{
		return false;
	}

	public void OpenTreasureHunt(EPreparationTimerType CCNBNLAPJFM, uint LIKPJDHGPFG)
	{
	}

	private IEnumerator GPPBCOOEEIE(EPreparationTimerType CCNBNLAPJFM, uint LIKPJDHGPFG)
	{
		return null;
	}

	public void ShowAstrolGateTeleportUIFX(ResourceID BKHNBIFJGJL)
	{
	}

	public void OnTreasureHuntDoCacheAfterPlayerJoin()
	{
	}

	public bool IsUGCMorphed()
	{
		return false;
	}

	public bool IsUGCHideShadow()
	{
		return false;
	}

	public void SetUGCFPSCameraSpecialState(bool CCLPHADPIAF)
	{
	}

	private bool KIIFMDKLJKM(Collider IIHDALCNINP)
	{
		return false;
	}

	protected virtual void OLGMHOMPFLD(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	protected virtual bool NOHLADHFBGK()
	{
		return false;
	}

	public void SetClimbButtonStatus(bool GPFPIAMCEMI)
	{
	}

	public bool GetClimbButtonStatus()
	{
		return false;
	}

	public void SetPlayerHighlight(bool CCLPHADPIAF)
	{
	}

	public int GetBagSkinID()
	{
		return 0;
	}

	public void UGCStartParachute(DGNALFBNMDP BKNGDAHKPEL)
	{
	}

	public bool IsUGCParachuting()
	{
		return false;
	}

	protected void CEDINGGPLIF(int GPFPIAMCEMI)
	{
	}

	public virtual bool ShouldHideSkins4UGC(string GNJHNAEHEFP)
	{
		return false;
	}

	public virtual void UpdateWeaponSkinsMapping4UGC(List<uint> IFPMKHEHOHL)
	{
	}

	public virtual SortedList<uint, uint> GetWeaponSkinIDs4UGC()
	{
		return null;
	}

	public virtual uint GetWeaponOriginalSkinID4UGC(uint LPHNICDPDBN)
	{
		return 0u;
	}

	public virtual uint GetWeaponPropertySkinID4UGC(uint LPHNICDPDBN)
	{
		return 0u;
	}

	public virtual uint GetWeaponBuffSkinID4UGC(uint LPHNICDPDBN)
	{
		return 0u;
	}

	public virtual void UpdateVehicleSkinMap4UGC(List<uint> OCIEGHKALIJ)
	{
	}

	private void OnControllerColliderHit(ControllerColliderHit HDGIHCBAOEN)
	{
	}

	private void JLNAFOKBILH(ControllerColliderHit HDGIHCBAOEN)
	{
	}

	private bool PFICPMGNFDL(Collider OKHAGMOAOAI, string OKBOIDEDKEA, out string LBNANAJJMHD)
	{
		LBNANAJJMHD = null;
		return false;
	}

	private void NKEEEPEPBGA()
	{
	}

	private void NCOPDMNEICP(string OKBOIDEDKEA)
	{
	}

	private void KIJHCDJKLKE(out Vector3 MNBGJMNHJPH, out Vector3 OLHHAELPLFI, out float KMHCHDLAHCJ)
	{
		MNBGJMNHJPH = default(Vector3);
		OLHHAELPLFI = default(Vector3);
		KMHCHDLAHCJ = default(float);
	}

	private void KJDJIDAAPFM()
	{
	}

	private void ABKLGGLCHJE()
	{
	}

	public int GetXRayingPlayerCount()
	{
		return 0;
	}

	public void SetXRay(bool EMGHOEADFHI, ICFILIBHMAJ LLGADNLPALG)
	{
	}

	public void ChangeXRayObserver(bool OKIHFIABACA = true)
	{
	}

	private void GMMJLAOFOEL()
	{
	}

	private void DOBPFKOOKDH()
	{
	}

	public ICFILIBHMAJ GetXRayController(uint NOIPBLNGABK)
	{
		return null;
	}

	private void PPPHFHBPOFM(ICFILIBHMAJ LLGADNLPALG)
	{
	}

	private void OKFNGCNPLCD(ICFILIBHMAJ LLGADNLPALG)
	{
	}

	public float GetXRayAlphaScale(uint NOIPBLNGABK)
	{
		return 0f;
	}

	public float GetLastXRayAlphaScale(uint NOIPBLNGABK)
	{
		return 0f;
	}

	public void SetLastXRayAlphaScale(uint NOIPBLNGABK, float EDGHIPGINEO)
	{
	}

	public float GetXRayMixedAlphaScale(Player FFHGOACBDMH)
	{
		return 0f;
	}

	public float GetLastXRayMixedAlphaScale(Player FFHGOACBDMH)
	{
		return 0f;
	}

	public void SetLastXRayMixedAlphaScale(Player FFHGOACBDMH, float EDGHIPGINEO)
	{
	}

	private void IGOMFOEPELL()
	{
	}

	private void AKOCMLIOFFL()
	{
	}

	private void AJKNLIDOKEE(Player FFHGOACBDMH, bool LCGBJELJKEH = false)
	{
	}

	private void AMHHJKPEBGA()
	{
	}

	private void CKJGBFHLEFL()
	{
	}

	private void MKNPFPPMMDM()
	{
	}

	private void MJPIFOPEOMJ()
	{
	}

	private void MOLKGGOCFCO()
	{
	}

	private bool EPHPKFFBHCP(BHGGAEEHJCO KJLFMPOFELA)
	{
		return false;
	}

	private static bool CAJPBGLNNMN(Collider NPEMKNFIIHL)
	{
		return false;
	}

	private void OGPDGDKFACJ()
	{
	}

	private void IMAJGGPGJHB(Player PGEGMKJKOKI, CKMIIAEOOKD OOFMPDBGDCB, bool AIAEFBNKNNH = false)
	{
	}

	private void LGHAIAHMEEN()
	{
	}

	private void HPIKOCBFCPN()
	{
	}

	private void ENIBCJDLIOO(string PIEELDNNLPA)
	{
	}

	private void NDKLLPHLIMD()
	{
	}

	public void PlayChargeSkillAnimWholeBody(ResourceID IJJHJMBOKEB, bool MFEKPFKOMIK = false, float JNHKPFFEELH = 0f)
	{
	}

	public void PlayChargeSkillAnimUpper(ResourceID IJJHJMBOKEB, bool MFEKPFKOMIK = false)
	{
	}

	public void StopChargeSkillAnim()
	{
	}

	public void ResetCustomAnim()
	{
	}

	public void BindScout(LevelScout NMENFOKKCHD)
	{
	}

	public void UnBindScout(LevelScout NMENFOKKCHD = null)
	{
	}

	private void LHNCDHNBIMC(bool KGMCEIAGGAH)
	{
	}

	private void LHJMFCAHOMD(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private void JMIBGFMGPCA(uint NJABLGHKFNA, ResourceID LAKJAMPOIFA, GameObject PEGEBLPCHEF)
	{
	}

	private void HJHMCDHLFIA()
	{
	}

	private void GHPMHPJFOCG()
	{
	}

	private void KMHMBBNCIJK()
	{
	}

	private void KEEDPADGKMD()
	{
	}

	private void OJNAJKAJICF()
	{
	}

	private void CEEJBAIEBEI()
	{
	}

	private void DNNPLLGNHNF()
	{
	}

	private void IOGFDLFCFCB(uint JDHNCLHNJIP, ResourceID AKANMDDBKBP)
	{
	}

	private void FHFOFDBCLBP()
	{
	}

	private void FHNKNJLFGLI()
	{
	}

	private void LJAPNHBBOGK(bool HMMNPFJHLEE)
	{
	}

	private void NKENPMOGKLB(bool FFCKGGMFPMF)
	{
	}

	private bool DEJFICNJBIL(CSVBaseData FADOEDJHAGD)
	{
		return false;
	}

	private void JKILGBLDOIC(uint JDHNCLHNJIP, ResourceID JMIMKLAELHE, GameObject KGJNMPHDKAB)
	{
	}

	private void HFFCEBMGPAI(uint JDHNCLHNJIP, ResourceID JMIMKLAELHE, GameObject KGJNMPHDKAB)
	{
	}

	private void KNLPGBHBFOF()
	{
	}

	private void DJMPPLKCBEM()
	{
	}

	private void BKHIFKCOMIJ(uint JPEHNBCECBD, ResourceID LAKJAMPOIFA, GameObject BOMJKCLNOKO)
	{
	}

	private void IKCNANFBGNB()
	{
	}

	private void HCLHHDEPAID()
	{
	}

	private void HJPNCEHBIFC()
	{
	}

	private void IJLJEAIANAB()
	{
	}

	private void NMOIBPNAOBB()
	{
	}

	private void DCIOEKCLIBD(uint PFIHDHGJNLO, bool PCGMOOHAIDE, UnityEngine.Object AOFCDPKJKJO)
	{
	}

	private void JPIDBOIMBBF()
	{
	}

	private void JOEPDIHMMML()
	{
	}

	private void BAALEOFPKOM()
	{
	}

	private void IOLFALAGCHJ()
	{
	}

	private void EFEKELOEEEP()
	{
	}

	private void HGLOLNJJFHL()
	{
	}

	private void PJHDDCDOHBA()
	{
	}

	private void EJFPPLJLOCE()
	{
	}

	private void IEPHCJKLIDD()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	public Vector3 _003C_003EiFixBaseProxy_GetAttackableCenterWS()
	{
		return default(Vector3);
	}

	public float _003C_003EiFixBaseProxy_GetAttackableRadius()
	{
		return 0f;
	}

	public bool _003C_003EiFixBaseProxy_IsVisible()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_IsStreamerVisible()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_InitEntityInfo()
	{
	}

	public void _003C_003EiFixBaseProxy_OnReUse()
	{
	}

	public bool _003C_003EiFixBaseProxy_Recycle()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnRecycleClearData()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnRecycle()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_RecycleForInGameReload()
	{
	}

	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUpdate(float P0, float P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}

	public void _003C_003EiFixBaseProxy_TakeDamage(GLLLEDKLLDA P0, LOAEBBHPMEK P1, List<float> P2, uint P3)
	{
	}

	public void _003C_003EiFixBaseProxy_TakeHealing(DLOFHLEHHNP P0, List<float> P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUpdateVisibleStateByStreamer(Vector3 P0, Vector3 P1)
	{
	}

	public bool _003C_003EiFixBaseProxy_CanAssitByWeapon(Player P0, FDAEPHMIEPC P1)
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_get_CanBeLockedByAimAssist()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_get_IsMovableEntity()
	{
		return false;
	}

	public ITransformNode _003C_003EiFixBaseProxy_GetTransformNode(string P0)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnPRIInitialized()
	{
	}
}
