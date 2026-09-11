using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GCommon;
using UMA;
using UnityEngine;
using message;
using proto;

namespace COW.GamePlay;

internal class AvatarManager : MonoBehaviour
{
	public delegate void AFMONABCHEF();

	private class FLKPALDEEDN
	{
		public IngameAvatarClothEffectComponent.ClothEffectObject DHJMMGHNCKJ;

		public ClothesVFXEffectChange ANABLKKGHOC;

		public bool AJLJBKHLNDA;
	}

	private class DFOFCJCKCEG
	{
		public ResourceID OOFAJACDNGC;

		public ResourceID NNPNFJPECPJ;
	}

	public class JEGKOJDIKEL
	{
		public uint LEEGLICPFDN;

		public uint IBGFPLHLNBJ;

		public List<uint> MCHAPIBAAGP;

		public List<AccountCollectionCustomItemInfo> KOFHILFMFOD;

		public string EICOCFBDMCC;

		public List<uint> LCEJFGJPOPG;

		public bool LEEGKILDMDA;

		[SpecialName]
		public static JEGKOJDIKEL LMCLIKOCCJM(HOFIFODGANJ KJOEFINGOJC)
		{
			return null;
		}
	}

	public enum AHPKGIHIJOG
	{
		None = -1,
		BackMount,
		Eyes,
		Head,
		Feet,
		Hands,
		InnerMouth,
		Legs,
		Torso,
		BackMountLeft,
		BackMountRight,
		BagPack,
		Vest,
		Helmet,
		Legpack,
		ParachuteBag,
		BackMountBottom,
		BackMountRightLeg,
		Hair,
		MAX
	}

	private class HJDBHAHKCAH
	{
		public GameObject HBFGKJPFKMF;

		public BitArrayBoolean LONOBDDEMCI;

		public bool FAGNNCFIBEL;

		public ResourceID BBNEGEGFHOE;

		public uint ENJBDKJIKJO;

		public bool DEKFBBMOHEL;

		public uint OBMGOMNMOAB;

		public uint CJNJIDBKKFF;

		public UnityEngine.Object CMECEAJICAB;

		public UnityEngine.Object ACBMEJFOEGF;

		public void NGFIABNECOM()
		{
		}
	}

	private class PrefabBackPackCtrl : MonoBehaviour
	{
		private GameObject PFKFOICPPLB;

		private Action JFPOBGCEEEG;

		private uint LFGEHDJJPAF;

		private AvatarManager KPMDIPJINJO;

		private List<GameObject> DEBLHJFBNDJ;

		private Dictionary<ResourceID, GameObject> DJGOGDAIMGD;

		private Dictionary<uint, ResourceID> BNFPECDDPGI;

		private FEKBCHODFLE JFMMOLDGAEF;

		private int GGBPGGAFLBJ;

		private int OFDELPADPDM;

		private float PFLHFPJJAGO;

		public void InitAvatarManager(AvatarManager EDKKPKCGCBD, int KIMFAAKFBKL)
		{
		}

		public void Load(ResourceID EDAMDCLBFLA, Action CEHELPAIELA)
		{
		}

		private void BOGMPNJJLFP(uint GGAOIPIHOBP, bool CPBHKACJHLG, UnityEngine.Object IDOMKJCHNMP)
		{
		}

		public void LoadEffect(ResourceID HICHIJIBALE)
		{
		}

		private void NKJGCDMEGEH(uint GGAOIPIHOBP, bool CPBHKACJHLG, UnityEngine.Object HACIJIFIDKM)
		{
		}

		public void SetGameObjectActive(bool KGOHDEBHENF)
		{
		}

		public void PlayAnim(int GLLELPILBOJ, bool LGKMHJCFMIK)
		{
		}

		public void UnEquip()
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<GameObject> _003C_003E9__287_1;

		public static Predicate<GameObject> _003C_003E9__287_0;

		public static Action<uint, bool, UnityEngine.Object> _003C_003E9__291_0;

		internal bool FJHOICJCCBE(GameObject CLACOPMJHDI)
		{
			return false;
		}

		internal bool FDCOBHCKGEO(GameObject CLACOPMJHDI)
		{
			return false;
		}

		internal void PLCCDFCMFBF(uint FFCKGGMFPMF, bool CPBHKACJHLG, UnityEngine.Object DHJMMGHNCKJ)
		{
		}
	}

	private sealed class DHBMKHLBKHN
	{
		public Action<AvatarManager> AEMIEMGAEHO;

		public bool MBHKPBMNMEE;

		public Action<GameObject> AICGECPFGGH;

		internal void HGHEDHJALON(uint GGAOIPIHOBP, bool CPBHKACJHLG, UnityEngine.Object HACIJIFIDKM)
		{
		}

		internal void ONAKKIMJOIL(GameObject CLACOPMJHDI)
		{
		}
	}

	private sealed class EAGAEFIACNP
	{
		public uint HBKDFPAGHCF;

		internal bool EOBKKIPNNJA(AccountCollectionCustomItemInfo FADOEDJHAGD)
		{
			return false;
		}
	}

	private sealed class KICJEDLOCEO
	{
		public AvatarManager KOKNHFGCGLN;

		public bool DKMPDAFCDIF;

		public RenderTexture GDACIHGENBI;

		public byte DBPNIDJEAAE;

		public string JCIFFMHHBHK;

		public int EJDIFNFHKDD;

		public uint INJPMHJKBJH;

		internal void GFOHIHEIKAL(uint GGAOIPIHOBP, bool PHJICGMMFME, UnityEngine.Object HACIJIFIDKM)
		{
		}
	}

	private sealed class LONAEHKLKJF
	{
		public AvatarManager KOKNHFGCGLN;

		public IIIAMPMFMNA PAJHJBNMLPE;

		internal void KOICJLDCDOK()
		{
		}
	}

	private sealed class MEAKKAAIGDK
	{
		public byte OPMHKKPJNGM;

		public LONAEHKLKJF EDIPCAMGBNP;

		internal void EPPKMKCEFKK()
		{
		}
	}

	private sealed class CKIFNDPGINA
	{
		public BackPackData LOLLEIENPPJ;

		public uint PILKFBFGKDK;

		public MEAKKAAIGDK HIDGOLEIPLE;

		internal void OGDDACNMJIG()
		{
		}
	}

	private sealed class PFJDPBLFAOC
	{
		public ResourceID CDCIOLJMLHI;

		public ResourceID JFBJDGNEGKC;

		public CKIFNDPGINA BMPLBOOPHLH;

		internal void HADEIBNPNOG()
		{
		}
	}

	private sealed class OEMPLHDHHBI : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public AvatarManager KOKNHFGCGLN;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public OEMPLHDHHBI(int CBPPJACCGOH)
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

	private sealed class MLBBNCOMMMH : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public AvatarManager KOKNHFGCGLN;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public MLBBNCOMMMH(int CBPPJACCGOH)
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

	public SharedColorTable SkinColor;

	private OverlayColorData ABPJCALOHJC;

	private OverlayColorData LFDEELBOLOH;

	public bool NeedRebindOnCharacterUpdate;

	public const uint ISVISIBLE_PLAYER = 1u;

	public const uint ISVISIBLE_WEAPON = 2u;

	public const uint ISVISIBLE_CLOTHEFFECT = 4u;

	public const uint ISVISIBLE_EMOTE_SHOW_MASK = 8u;

	public const uint ISVISIBLE_ENEMY_HINT = 16u;

	public const uint ISVISIBLE_HIDE_RESIDENTEFFECT = 32u;

	public const uint ISVISIBLE_ADDITIVE_EFFECT = 64u;

	public const int AuroraBoy3PRenderQ = 2501;

	public const int StealthRenderQ = 3000;

	public const int EclipseTransformSpecialOffset = 510;

	public const uint AvatarID_Eva = 101000001u;

	public const uint AvatarID_Adam = 102000004u;

	public bool IsChangedToDefaultModel;

	public bool IsEquippedParachuteBag;

	public static int LOCAL_PLAYER_TEXTURE_SCALE;

	private static bool PAADDGFDHJH;

	private static int BLCFJIJKKCI;

	private static int KDBHBLAMLJC;

	private int OGPPPAMFCJB;

	private static List<string> AAOIGPCCNJK;

	private static Dictionary<string, Player.DAPOIBANHEH> EBPNGBCPIKG;

	private ulong CCAAHJJGIPO;

	private LazyDictionary<uint, List<int>> OAIBFPOLGJC;

	private bool MLGLFHEIGNJ;

	public AFMONABCHEF OnCustomUMAUpdated;

	private bool MMCPENKEDEJ;

	private List<int> DNLPJEPNKMH;

	private int JPDPMBELFGC;

	private LazyDictionary<int, bool> NJEECHKDJBI;

	private UIModelTailor EPEOEKIHCCG;

	private LazyDictionary<int, List<ParticleSystem>> JBNBEPNCCON;

	private LazyDictionary<uint, FLKPALDEEDN> POJKHOPIBND;

	private LazyDictionary<uint, bool> LNNKEEDANAD;

	private LazyDictionary<uint, bool> NAMFEGIMJAO;

	private LazyDictionary<uint, IngameAvatarClothEffectComponent.ClothEffectObject> LAJGEHACJAE;

	private LazyDictionary<int, DFOFCJCKCEG> HPFKFJGMIEC;

	public bool IsRecycled;

	public JEGKOJDIKEL m_PAvatarData;

	private const string ONDMJOKAKKB = "Chest";

	private const string IHFIAOLOALL = "Vest";

	private const string IBAJCMJKKIH = "Hair";

	private const string FELMDNEGCMG = "Helmet";

	private const string BNCNHNOBDFM = "Legs";

	private const string BABJFIMCHDE = "Feet";

	private const string IHMIFDGMDDB = "Face";

	private const string HLEOIPLJDBF = "HeadAdditive";

	private static readonly Dictionary<int, string> BLIOGNHKGOO;

	private ITransformNode NHDNMJIJMML;

	private ITransformNode FKJADDNFOFK;

	private ITransformNode LGJGONOGMBE;

	private ITransformNode JNJLNMCHFEH;

	private GameObject ECDNPBJEHHJ;

	private ITransformNode BPNPANCKJBH;

	private GameObject AEHBPFBFBPG;

	private ParticleSystem[] HFDKPNJPJIO;

	private GameObject AJOCBMHFENE;

	private GameObject GPKNKGFPMAK;

	private GameObject GAKGDJHHGJH;

	private static readonly Vector3 FLEJGDGFAOL;

	private static readonly Vector3 FGEIBGFHEHL;

	private static readonly Vector3 LFOBGEHKNAP;

	private Dictionary<int, HJDBHAHKCAH> OKAIJDKHLML;

	private Dictionary<uint, HJDBHAHKCAH> NGHHMDNFODF;

	private LazyDictionary<uint, GameObject> GMFGAOIKHEE;

	internal IUmaAvatar GIAMMAADHFN;

	public IngameAvatarClothEffectComponent m_ClothEffectComponent;

	public IngameAvatarMaterialAnimComponent m_MaterialAnimComponent;

	public IngameAvatarWeaponEffectComponent m_WeaponEffectComponent;

	private GameObject MMNOICHJPBB;

	private PrefabBackPackCtrl PMBCPLBGIOJ;

	private int CLFCFBGKOMD;

	private int MGHFDJKIKAO;

	private int KNCHDKNPMFB;

	private int LEAODCABEOF;

	private int CONFLNMIHOB;

	private int FPMDFGGPAKB;

	private int NKELPBBAHKG;

	private int AKMBNABEAAE;

	private readonly Dictionary<string, uint> FHNKNEEGBDI;

	private readonly Dictionary<string, HashSet<string>> OICGHIOOGIC;

	public AvatarSuitData m_AvatarSuit;

	private ResourceID NOMOEKABGBN;

	private bool _003CDKMBNMBLABO_003Ek__BackingField;

	public bool init;

	private Player _003CDJCGIMPBMIG_003Ek__BackingField;

	private EntityVisualEffectManager EINPMFNJINA;

	private VisualEffectLoadMethod NGNJGENIAJN;

	private EPPlayerInfo _003COMKAEDMABMH_003Ek__BackingField;

	private bool AHDIDAKNHDN;

	private bool KFPPJJEBAFJ;

	private string FFHKJGHEEOM;

	private uint BMFPAPJOHPB;

	private bool OJFKIMNLNKI;

	private bool MBEJCBPIMLC;

	private uint POPLFGBLLNA;

	private bool CFOLJFJEJEP;

	private UMAContextSimple DPLMBOKJDEK;

	private float FAJDBFJECFG;

	private bool DMMJPDCIPKM;

	private bool EOCKNADJPBE;

	private bool OCHHFEOLNLG;

	private bool IKHBAOFNJJD;

	private bool DICIKLLAIGG;

	public bool SkipBuildForSyncPropertyIfNotVisible;

	private bool MIKGAMOAOIC;

	private static ResourceID[] MDAKNMLBDPA;

	private bool OMLCKCGEINL;

	private uint HCIEAHHOLIL;

	private uint HGBFFAHDODP;

	private bool MBGFIBLBCDE;

	private bool JHOOGPNLJAF;

	private bool AINOPBGDPNH;

	private int KKNKHAEIJNI;

	public Dictionary<uint, RenderTexture> JerseyNumberTextureDic;

	public int JerseyNumber;

	public string Nickname;

	public uint LastCustomClothSlot;

	private List<uint> CKIBIIHCNIA;

	private bool CNMMGGAHOHK;

	private bool LPDIDPMCEGN;

	private Dictionary<string, int> KKHPJMPLNAB;

	private uint CGNHGGMHEGJ;

	private uint LPAMJEOIGNC;

	private uint PDJBJDPKGEO;

	private uint OLIIOLONKKK;

	private bool IKBGLHDPBCJ;

	public UMAData.EffectType m_NoUmaEffectType;

	private bool JHGPNDIPBKO;

	private List<EventClothEffectsData> MCGMBLCJGAI;

	private List<EventClothEffectsData> FLBANKMODGJ;

	private List<string> INOCNGMHDEJ;

	private List<int> PBDNEBIFNGD;

	private const int BKEHJAGGAAN = 100;

	public const int GameModeEffectIndex1 = 101;

	public const int KnockDownShowOnTargetEffectIndex = 102;

	private const int BOIMOOCIAPE = 2;

	private uint DLFMDBNMIJN;

	private uint GNDBJHOACHC;

	private EpicClothesTextData HOLGEHIIEAN;

	private ResourceID IMGKIGNKEJF;

	private GameObject HNCJPIDEEIL;

	private bool NHFLBGIBPBG;

	private bool HKKDOHMHIBO;

	private ResourceID EPHPNGOPEFF;

	public static int GBEKFLOGIFP => 0;

	public static int AENOHADABIH => 0;

	private int HNKIFFMGMOH => 0;

	public ulong CMMOGEMJCDO => 0uL;

	private UIModelTailor IBIDBDEAMFI => null;

	public GameObject KCDFHILCLJA => null;

	public bool JCJOBGIJMHF
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Player BGDKPCKDDKN
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public EPPlayerInfo BHHIIPFLGDO
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	private bool NHOOMMDCCKH => false;

	public bool IOMHJLJDCEF => false;

	public uint LEEGLICPFDN => 0u;

	public UMAData.EffectType MGGNLEEAPEP => UMAData.EffectType.EFFECTTYPE_NONE;

	public void EnterEffectTriggerClientInNeed()
	{
	}

	public void OnMapEnemyEffectStart()
	{
	}

	public void Recycle()
	{
	}

	public void OnReUse()
	{
	}

	public void OnMapEnemyEffectStop(object[] DJAPBCKDFKA)
	{
	}

	public void OnMapEnemyEffectStop()
	{
	}

	public void OnEffectTriggerClientValueChanged(object[] DJAPBCKDFKA)
	{
	}

	private static ResourceID GDGIPHPGKJL(bool PFBAFDMCGPF, bool MBHKPBMNMEE, bool FDCNBOFFJOI)
	{
		return default(ResourceID);
	}

	public static AvatarManager CreateEpAvatar(bool MBHKPBMNMEE)
	{
		return null;
	}

	public static uint CreateEpAvatarAsync(bool MBHKPBMNMEE, Action<AvatarManager> AEMIEMGAEHO)
	{
		return 0u;
	}

	public static AvatarManager CreateUGCAvatar(bool MBHKPBMNMEE, bool PPNGLFCBGHA)
	{
		return null;
	}

	public void Init(Player LDCIMNAAGNO)
	{
	}

	public void SetIsWithoutPlayerAvatar()
	{
	}

	public void UGCInitCustom()
	{
	}

	public bool InitArtModel(bool LEKFFNFLMAP)
	{
		return false;
	}

	public void InitElitePassPlayer(bool LEKFFNFLMAP)
	{
	}

	public void UGCSyncCustomAvatar(uint CDMHGFHHJFA, uint DPGMPFDHCLL, uint AFFPOIBKFKK)
	{
	}

	public static ResourceID CalcAnimatorResIDByWeaponInfo(FDAEPHMIEPC.DBENAPILEBC NJMMDDMIION, int KJAEDIGHOMN, bool PPNGLFCBGHA)
	{
		return default(ResourceID);
	}

	public void UGCChangeACByWeaponWithoutPlayer(uint DPGMPFDHCLL, bool PPNGLFCBGHA)
	{
	}

	private bool KBHFCBLPPCC(SkinDataManager.SkinType MJIFGJPGLAM)
	{
		return false;
	}

	private bool PLOADCDJGGF()
	{
		return false;
	}

	private bool IBEJOKJHHAH()
	{
		return false;
	}

	private GameObject JOEIAADIFKL(string JCIFFMHHBHK)
	{
		return null;
	}

	private bool ODECAADMPEH()
	{
		return false;
	}

	public void UGCEquipBagSkinWithoutPlayer(uint DHEIPNHAIKM)
	{
	}

	public void RefreshBackPackSkinForSocialLobby(uint DHEIPNHAIKM)
	{
	}

	public void ResetEventClothesEffectsInited()
	{
	}

	public void RefreshClothesForSocialLobby(List<uint> EDMBEEHCMOB, bool HOBBAIAIIEG = false, List<AccountCollectionCustomItemInfo> KJGEGBPHIPJ = null, string BNMIMCLFNII = "")
	{
	}

	public bool UpdateClothesForSocialLobbyLight(List<uint> EDMBEEHCMOB, List<AccountCollectionCustomItemInfo> KJGEGBPHIPJ = null, string BNMIMCLFNII = "")
	{
		return false;
	}

	private int MLKKKCOCBEO(List<uint> BAIDALDFDOH, uint CDMHGFHHJFA)
	{
		return 0;
	}

	private void OPGBPKIOCFG()
	{
	}

	private static bool BNMGFLJNNIB(List<uint> MDFHMBHHGGF, List<uint> OGECPGHMIHA)
	{
		return false;
	}

	private static bool GEGPNGPBJHB(List<AccountCollectionCustomItemInfo> MDFHMBHHGGF, List<AccountCollectionCustomItemInfo> OGECPGHMIHA)
	{
		return false;
	}

	private bool BOADINJFNLA(List<uint> BAIDALDFDOH, bool EFOKHJJMELP, bool OAEEFCHIKDD, bool KNJCEHOLKCM, bool JHFPHCPFILN)
	{
		return false;
	}

	public bool HasReadyJerseyClothForSocialLobby()
	{
		return false;
	}

	private bool EBFJMFFOJNK(List<uint> BAIDALDFDOH)
	{
		return false;
	}

	public void BindBattleBoardPlayerAnimation(JEGKOJDIKEL PAJHJBNMLPE, bool FEMIBFLGFOO = true)
	{
	}

	public void BindTargetAnimatorController(ResourceID DGNJEDDMKCD, ResourceID MOALAJPMMEM)
	{
	}

	public void BindEPPlayerAndUpdateAnimation(EPPlayerInfo LDCIMNAAGNO, bool GJLAKMJIALE = true)
	{
	}

	public void BindEPPlayer(EPPlayerInfo LDCIMNAAGNO)
	{
	}

	public void UpdateEPPlayerAnimation()
	{
	}

	public void UpdateEPPlayerAnimation(ResourceID OCCLMDNGINA)
	{
	}

	public void BindArenaNPCPLayer(EPPlayerInfo LDCIMNAAGNO, ResourceID GFPAIBLKMHC)
	{
	}

	public void UpdateAreanaNPCPlayerAnimation(ResourceID GFPAIBLKMHC)
	{
	}

	public void ChangeRace(string HNPAPCCAIEE)
	{
	}

	public void SyncGenderFromAvatarId(uint CDMHGFHHJFA)
	{
	}

	public void ClearPlayerSlots()
	{
	}

	public void ClearSetSlot()
	{
	}

	public void UpdateAvatarForce()
	{
	}

	public void AddUMAFinishUpdateCallBack(UMAData.CharacterUpdatedDelgate CEHELPAIELA)
	{
	}

	public void RemoveUMAFinishUpdateCallBack(UMAData.CharacterUpdatedDelgate CEHELPAIELA)
	{
	}

	public void SetLocalPosition(Vector3 HDFILHFDBKB)
	{
	}

	public void ResetLocalPosition()
	{
	}

	public void SetSwimSurfDeadPostion()
	{
	}

	public Vector3 GetLocalPosition()
	{
		return default(Vector3);
	}

	public void SetAnimator(Animator EHKHGICCIEG, bool PBOLJALBIJJ, bool MJLFKNAHCMB)
	{
	}

	public void SetForceAnimatorAlwaysAnimate(bool IDCHCEECMBE)
	{
	}

	private bool NPHFMBFGNOG()
	{
		return false;
	}

	private bool NBACJICEGNO()
	{
		return false;
	}

	public bool IsFemale()
	{
		return false;
	}

	private void BGFMDBEJOLJ(bool JELMDMNDIOJ = false)
	{
	}

	private void IEBEOGKGNBL(uint HBKDFPAGHCF, ref bool LDGJNABIMDM, ref bool HEEBCNHDOEI, ref bool LBFFECNKMFO, ref bool BEBPFDBJNIK, ref bool HGLJCEFMGEO, ref bool NHGMKCKOPJO, ref bool PDHEDMHNDEA)
	{
	}

	private void FNIKOCGDCCM(bool LDGJNABIMDM, bool HEEBCNHDOEI, bool LBFFECNKMFO, bool BEBPFDBJNIK, bool HGLJCEFMGEO, bool NHGMKCKOPJO, bool PDHEDMHNDEA)
	{
	}

	public void UGCHideClothesEffect(bool CGFFMKHJADO)
	{
	}

	private void EHMOKMHDNCN()
	{
	}

	private void EGPADPEPEBM(Dictionary<int, IngameAvatarClothEffectComponent.ClothEffectObject> ICANOFNHAJE, bool PALMMEMFBKF)
	{
	}

	private bool DKNNGPBIFEL()
	{
		return false;
	}

	private void KLMIHGCNJJP()
	{
	}

	private void NIGPEIJHHEC()
	{
	}

	private void NIGPEIJHHEC(List<uint> BAIDALDFDOH)
	{
	}

	private void OIEILOIHJIO(AvatarWardrobeData JCONDDPFBKK)
	{
	}

	private ResourceID OFNCAGOJIDE(ClothesTriggerData PCNJAGDHFKE, bool PPNGLFCBGHA)
	{
		return default(ResourceID);
	}

	private void EKDCOEGHIKH(uint CDMHGFHHJFA, uint INJPMHJKBJH, AvatarWardrobeData KDLBINOMLGC, bool PPNGLFCBGHA, bool LMLNCGHHEBA, bool PBOLJALBIJJ)
	{
	}

	private void DMFGLKKLHAJ(UIModelAvatarBase.EWardrobeType CCNBNLAPJFM, uint GEHJJDLAGJJ, int FJCPAJEPBOD = 0)
	{
	}

	private void OIEILOIHJIO(List<uint> BAIDALDFDOH)
	{
	}

	private void ONCIDFMPNCD(ResourceID OHNBNEHCJIE, UIModelAvatarBase.EWardrobeType CCNBNLAPJFM, bool PKGPGMNJPED = false, bool EJOGLAFBDFC = false)
	{
	}

	private void OKNLAEMDFBA(ResourceID OHNBNEHCJIE, UIModelAvatarBase.EWardrobeType CCNBNLAPJFM, bool EJOGLAFBDFC = false, uint[] FKOFECNAOGF = null, bool ECCOFLNFIOH = false)
	{
	}

	private void FKEHMKBJDIP(ResourceID OHNBNEHCJIE, UIModelAvatarBase.EWardrobeType CCNBNLAPJFM, bool PKGPGMNJPED = false, bool EJOGLAFBDFC = false, uint[] FKOFECNAOGF = null, bool DGCADKNNFLN = false, bool GKNHGPIOAPP = false)
	{
	}

	protected Transform ICLONJBOPKE(UIModelAvatarBase.EWardrobeType NHINNMCNBIL)
	{
		return null;
	}

	private void EHOOFJAMKCF()
	{
	}

	public void InitSingleGameAvatarData()
	{
	}

	public void SyncAvatarProperties(JEGKOJDIKEL DKIIMBMLFHG = null, bool BCHDKJGBGNF = true, bool JPDAPEBKOAC = false)
	{
	}

	private void BMJCHHIGFKJ()
	{
	}

	public string GetNickname()
	{
		return null;
	}

	public void ClearSlotsTextures()
	{
	}

	public void RefreshJerseyNumber()
	{
	}

	public void RefreshJerseyNumberInternal(int EJDIFNFHKDD, uint INJPMHJKBJH)
	{
	}

	private void CLCFCGNNDJN(bool DKMPDAFCDIF, RenderTexture GDACIHGENBI, uint DBPNIDJEAAE, string JCIFFMHHBHK, int EJDIFNFHKDD, uint INJPMHJKBJH)
	{
	}

	public void SetJerseyNumberTexture(RenderTexture GDACIHGENBI, uint DBPNIDJEAAE, bool JHEPPHECBJB = true, uint INJPMHJKBJH = 0u)
	{
	}

	public bool CanSimple3P()
	{
		return false;
	}

	public bool IsSimple3PModel(bool PGIEMBGPAPC = false)
	{
		return false;
	}

	public bool IsSimple3PAttachment()
	{
		return false;
	}

	public static bool SkipAllVestSlotAttachment()
	{
		return false;
	}

	public void ChangeAvatarIdToDefault()
	{
	}

	public void TryEnableSharedUMA()
	{
	}

	public void DisableSharedUMA()
	{
	}

	public void EndCabinWaitingPhase(bool BCHDKJGBGNF, bool DDOPPPIBKIO)
	{
	}

	private bool FOFNDJDEDHP()
	{
		return false;
	}

	public bool HasCloth(uint BCGFIJHEDBO)
	{
		return false;
	}

	private void APOPIHBEDFG()
	{
	}

	private bool BMAIHJNAGFN()
	{
		return false;
	}

	private bool HOFPFNDEHGG()
	{
		return false;
	}

	private void ECHGJDIDGHJ(bool GOPJNJKPHGJ)
	{
	}

	public void UGCChangeAvatarCloth(List<uint> EDMBEEHCMOB, bool HOBBAIAIIEG = false, List<AccountCollectionCustomItemInfo> KJGEGBPHIPJ = null, string BNMIMCLFNII = "")
	{
	}

	public void ClearAllClothes(bool POJANAIGNEF = true, bool AMLPDCMMHDA = false)
	{
	}

	public void MetropolisChangeAvatarCloth(List<uint> EDMBEEHCMOB, bool HOBBAIAIIEG = false, List<AccountCollectionCustomItemInfo> KJGEGBPHIPJ = null, string BNMIMCLFNII = "")
	{
	}

	public void ChangeAvatarCloth(List<uint> EDMBEEHCMOB, bool CLHJEPNJNHO)
	{
	}

	public void ClearAllSlots(bool AMLPDCMMHDA = false)
	{
	}

	public void OnDebugTestRecipe(int MBPMOCALJHN, List<uint> ACHIJKGJIKA)
	{
	}

	public void T_SyncAvatarProperties(List<uint> MGKOHHMCGFM = null, bool CGLIILCHFHD = false)
	{
	}

	public void autotestUMA(List<uint> MGKOHHMCGFM = null, uint LIKPJDHGPFG = 102000004u, bool CGLIILCHFHD = false)
	{
	}

	public void T_UpdateAvatar(List<uint> MGKOHHMCGFM = null, bool CGLIILCHFHD = false)
	{
	}

	private void OBKBGJILJLP(UMAData JCONDDPFBKK)
	{
	}

	public void SetClothEffectEmoteShowMaskVisibility(UIModelAvatarBase.EWardrobeType JLKLOAIKNNC, bool OGFBADGIDMF)
	{
	}

	public void ResetClothEffectEmoteShowMaskVisibility()
	{
	}

	public Vector3 GetAvatarScale()
	{
		return default(Vector3);
	}

	private bool KLOMMPCICMK()
	{
		return false;
	}

	public void LocalPlayerCastShadow(bool LKFBNKCNLNL)
	{
	}

	public void DebugUpdateCloth(uint INJPMHJKBJH, bool PFBAFDMCGPF)
	{
	}

	public bool UpdateCloth(uint INJPMHJKBJH, bool PPNGLFCBGHA = false, bool AMLPDCMMHDA = false)
	{
		return false;
	}

	public void UpdateFace(uint CDMHGFHHJFA, bool JELMDMNDIOJ = false)
	{
	}

	public void SetObservered(bool OMACMJCMKGD, bool DGCAPEHDKAO)
	{
	}

	private void MEOEPPAEEEM(bool JELMDMNDIOJ = false)
	{
	}

	public void LoadDefaultAvatar()
	{
	}

	private void OnDestroy()
	{
	}

	public void CharacterCreatedCB(UMAData JGFHHNDDKDJ)
	{
	}

	public void UpdateOffset(bool DFDJPPJEMIG, bool ODBECFEKBNJ)
	{
	}

	public void SetLayerRecursively(GameObject HACIJIFIDKM, int PNLKPJNLDGB)
	{
	}

	public void SetVisible(bool FKJMCGEFJMD, bool BKKLMANNGJE = false)
	{
	}

	private void CJDFFMEIDIN(bool EGBCPBOGGNC)
	{
	}

	private IEnumerator ILDMGCEGPBM()
	{
		return null;
	}

	public void SetUMARendererActive(bool MIBHDOJIHJE)
	{
	}

	public void SetUMARendererMaterial(Material ACJKGIJMPOO)
	{
	}

	public void UpdateBigHeadAvatar(uint MICIEPIOMDB, ResourceID HEJKEMNFIBI)
	{
	}

	public void UpdateAvatarSlot(AHPKGIHIJOG FCHIFENCNDM, int AGCCIILDALC, bool AMLPDCMMHDA = false)
	{
	}

	public void UpdateAvatarSlot(string JAHPMBJNCMC, int AGCCIILDALC, bool AMLPDCMMHDA = false)
	{
	}

	public bool UpdateAvatarSlotGeneral(string JAHPMBJNCMC, int AGCCIILDALC)
	{
		return false;
	}

	private bool FBLGIFCLGEH(string BHCJFEBDKIE)
	{
		return false;
	}

	private int BMMKNPPCIFH(string JAHPMBJNCMC, int AGCCIILDALC)
	{
		return 0;
	}

	private int LJCBOFEDJKG(string IFLLNIKBOCI)
	{
		return 0;
	}

	private int BAKPOKKHPHI(string IFLLNIKBOCI)
	{
		return 0;
	}

	private bool NOIECBCAEIL(string JAHPMBJNCMC, int AGCCIILDALC)
	{
		return false;
	}

	public void OnSyncAvatarEquip(NAELPAAELNO BPDGEMBOGAA)
	{
	}

	private void MMNCKCMPAFJ(HENEHAGJCLI BGDIPMPKKCE, HDAEFOANBGJ DANAHHMMDOD, uint HMJFDNFJPNN = 0u)
	{
	}

	private bool PJHCDJPELBE()
	{
		return false;
	}

	private void FGDBFKOALNH(HENEHAGJCLI BGDIPMPKKCE, HDAEFOANBGJ DANAHHMMDOD)
	{
	}

	private void MIHMDCKGLKF(IIIAMPMFMNA PAJHJBNMLPE, BackPackData LOLLEIENPPJ, uint PILKFBFGKDK)
	{
	}

	private void ONFEKELDNMH()
	{
	}

	public void RemoveClothEffect(UIModelAvatarBase.EWardrobeType JLKLOAIKNNC)
	{
	}

	public void OnSyncAvatarUnEquip(NAELPAAELNO BPDGEMBOGAA)
	{
	}

	public void OnSyncDropItem(NAELPAAELNO BPDGEMBOGAA)
	{
	}

	public void InitAvatarEquipments(List<NAELPAAELNO> EKKFAJACCBO)
	{
	}

	private bool FPBGNDLLKKL(OMELKCOGCBK HBHCJFPGFND, HDAEFOANBGJ DBPNIDJEAAE, bool AACCHNPDDPG, bool OHBJAEMAEAL = false)
	{
		return false;
	}

	public void RefreshBackMountWeaponForSwimming(bool AACCHNPDDPG, bool OHBJAEMAEAL = false, HDAEFOANBGJ DBPNIDJEAAE = HDAEFOANBGJ.Unknown)
	{
	}

	public void RefreshBackMountWeaponForBackMounted(bool GPLJHHCJODJ, HDAEFOANBGJ DBPNIDJEAAE = HDAEFOANBGJ.Unknown)
	{
	}

	public void SetBackMountWeaponVisibility(bool KGOHDEBHENF)
	{
	}

	public bool ShowSecondaryWeaponModel()
	{
		return false;
	}

	public void RefreshBackMountWeapon()
	{
	}

	public void RefreshBackMountWeapon(HDAEFOANBGJ DBPNIDJEAAE)
	{
	}

	public void RefreshBackMountWeaponForGettingOffSkateboard()
	{
	}

	public void RefreshPendingBackWeaponSkins()
	{
	}

	private AHPKGIHIJOG IIDPKMLBDDK(uint GGAOIPIHOBP)
	{
		return AHPKGIHIJOG.BackMount;
	}

	private void MHIIOAPBJAN(uint GGAOIPIHOBP, bool BBPCHCNOECP, UnityEngine.Object HACIJIFIDKM)
	{
	}

	private void IKELFFJJDJL(uint GGAOIPIHOBP, bool BBPCHCNOECP, UnityEngine.Object HACIJIFIDKM)
	{
	}

	public void RefreshWeaponModel()
	{
	}

	private void LJKFGBIDKEH(uint CIOOJLPEDDP, AHPKGIHIJOG DBPNIDJEAAE = AHPKGIHIJOG.None)
	{
	}

	private void GOGPAECFDLF(uint CIOOJLPEDDP, AHPKGIHIJOG DBPNIDJEAAE = AHPKGIHIJOG.None)
	{
	}

	public void DebugRefreshBackWeaponModel()
	{
	}

	public Transform GetBackWeaponAttachPoint(AHPKGIHIJOG DBPNIDJEAAE)
	{
		return null;
	}

	private void EEFEFBDLJJH(AHPKGIHIJOG DBMFDCJAEMG, NAELPAAELNO BPDGEMBOGAA)
	{
	}

	private void PBEELKPJBJL(NAELPAAELNO BPDGEMBOGAA, GameObject HEEPHHIEIBN)
	{
	}

	private ResourceID KHMMADCCAOC(AFOLPMOCBOG LBANGCILPHD, NAELPAAELNO BPDGEMBOGAA)
	{
		return default(ResourceID);
	}

	private ResourceID IBJEFOIKCBP(AFOLPMOCBOG LBANGCILPHD, NAELPAAELNO BPDGEMBOGAA)
	{
		return default(ResourceID);
	}

	private void GABKACKNDNI(NAELPAAELNO BPDGEMBOGAA, HJDBHAHKCAH NOFJFDAAGMH)
	{
	}

	private void GABKACKNDNI(NAELPAAELNO BPDGEMBOGAA, GameObject HBFGKJPFKMF)
	{
	}

	public void OnSyncSwapWeapon(HDAEFOANBGJ GBMBHDPENCA, HDAEFOANBGJ NJENBJEGCMP)
	{
	}

	public void EquipParachuteBag()
	{
	}

	public void UnequipParachuteBag()
	{
	}

	public void UnequipBagByAvatarUnequip()
	{
	}

	public void UnequipBackpack()
	{
	}

	public void ClearWardrobe4SnowMan()
	{
	}

	public void ResetSnowManAvatar()
	{
	}

	public void InitPartyComboEffet()
	{
	}

	public void SetPartyEffectShow(uint FJCPAJEPBOD = 0u)
	{
	}

	public void OnEnterSurf()
	{
	}

	public void OnExitSurf()
	{
	}

	public void OnEnterWater()
	{
	}

	public void OnExitWater()
	{
	}

	public void OnSurfMove(bool PLNBKKNHAKO)
	{
	}

	public void OnWaterMove(bool PLNBKKNHAKO)
	{
	}

	public void OnWaterMoveEffectCallBack(uint PLNDNBINKOA, ResourceID CICBIIJABAP, GameObject CLACOPMJHDI)
	{
	}

	public void PlayHitProtectionEffect()
	{
	}

	public static int FindReplacedRecipe(int OABDNBPMOOH, int AKJLLDBCGDB)
	{
		return 0;
	}

	private bool JCOLNJNGMKN()
	{
		return false;
	}

	private void MPFHKEKEBJB()
	{
	}

	private bool GKNBGJDPEKD(IEnumerable<uint> CCLPHADPIAF, uint LIKPJDHGPFG)
	{
		return false;
	}

	public ResourceID GetSuitAnimation()
	{
		return default(ResourceID);
	}

	public ResourceID GetAvatarSpecialAnimation()
	{
		return default(ResourceID);
	}

	public byte EnableBackpackLogo(Player PGEGMKJKOKI)
	{
		return 0;
	}

	private ResourceID IBCLMBIEPHE(int FJCPAJEPBOD)
	{
		return default(ResourceID);
	}

	private void ICBHMKDBDEO(GameObject HKCMFCNPFBI, byte IKMGPLIHPFE)
	{
	}

	public void SwitchEffect(UMAData.EffectType MGGNLEEAPEP)
	{
	}

	public void SwitchEffectInNoUMAClothCheck(UMAData.EffectType DHJMMGHNCKJ)
	{
	}

	private void MJKDIKILBEB(UMAData.EffectType MGGNLEEAPEP)
	{
	}

	private void OCMBALAGBCN(Dictionary<int, IngameAvatarClothEffectComponent.ClothEffectObject> ICANOFNHAJE)
	{
	}

	public void SetAvatarColor(Color NJMGFOAPCGA)
	{
	}

	public bool GetMeshBounds(ref Bounds KGHCCJBCLJL)
	{
		return false;
	}

	public void SetShader(string NKOEPMIECFC, HELBFMHHPBI NBLHNPAHGNA = null, Shader BGBLINMCBGD = null)
	{
	}

	public void RevertToDefaultShader()
	{
	}

	public void SetRenderQ(int MMNAILAPJFN, bool IDCHCEECMBE = false, bool MNMOFPDPGGN = false)
	{
	}

	public void RevertToDefaultRenderQ()
	{
	}

	public void SetThermalView(bool HCLGHJNEFIC)
	{
	}

	public void SetThermalViewByModel(bool HCLGHJNEFIC, GameObject NAGHAPBBLKF)
	{
	}

	public void SetMaskColors(Color[] FBHJGLNIIPE, Color[] NMNIHCFDIIE, bool GCACOEGFCHO = false)
	{
	}

	public void SetOverrideDecalTexture(Texture IIHOIKOFPJK, uint INJPMHJKBJH, int AGCCIILDALC)
	{
	}

	private void INDABDBCDBD()
	{
	}

	public List<EventClothEffectsData> GetEventClothEffectsDataByType(uint CCNBNLAPJFM)
	{
		return null;
	}

	private EventClothEffectsData FCBANMLGHED(int NIBBKONKPHP)
	{
		return null;
	}

	private ResourceID BHDENGHPGNN(int NIBBKONKPHP, bool CJCLGBOFDKL = false, bool OAMDPBGLDJL = false)
	{
		return default(ResourceID);
	}

	public bool CheckClothIsBackPack(int NIBBKONKPHP)
	{
		return false;
	}

	private bool PLAPNPJAJOK(int NIBBKONKPHP)
	{
		return false;
	}

	public void StartTriggeredEffect(int NIBBKONKPHP)
	{
	}

	private bool FGKHBHFIAKA(int NIBBKONKPHP, ResourceID OCCLMDNGINA)
	{
		return false;
	}

	private bool OGFLOEJMBAE(int NIBBKONKPHP)
	{
		return false;
	}

	private void IGFCOCNHFAH(int NIBBKONKPHP)
	{
	}

	private ResourceID PHEGOAHHFKP(int NIBBKONKPHP)
	{
		return default(ResourceID);
	}

	private ResourceID JJJCIMFDKBE(int NIBBKONKPHP)
	{
		return default(ResourceID);
	}

	private void LHFCEBCHJND(int NIBBKONKPHP, bool CMCMJHNMNGO)
	{
	}

	private void CEHHNPHEAOB(UIModelAvatarBase.EWardrobeType CCNBNLAPJFM, ResourceID GPODIDJBEOO, int NIBBKONKPHP, bool CMCMJHNMNGO)
	{
	}

	private void GCMDMLDCEII(bool KCLNMCBAAAL, bool IPNPKMJDIPC, int CCNBNLAPJFM)
	{
	}

	private bool BPEGJOEHPCE(int CCNBNLAPJFM, bool MBNAAHBIFEN)
	{
		return false;
	}

	private void AFLCKHEHJDA()
	{
	}

	public void ClearTriggerEffect()
	{
	}

	private void OOEMLHEFDDC(int NIBBKONKPHP)
	{
	}

	private UIModelAvatarBase.EWardrobeType IAELOBHBBDF(int NIBBKONKPHP)
	{
		return UIModelAvatarBase.EWardrobeType.CLOTHESTYPENONE;
	}

	public void StartTriggeredEffect(int NIBBKONKPHP, ResourceID OCCLMDNGINA)
	{
	}

	public bool IsTransformEffect(int NIBBKONKPHP)
	{
		return false;
	}

	public void StopTriggeredEffect(int NIBBKONKPHP, bool FAEDJCGABAA = false)
	{
	}

	public void StopTriggeredEffect(int NIBBKONKPHP, ResourceID OCCLMDNGINA)
	{
	}

	private void GKFEJJBEOJF()
	{
	}

	private void NFGOLHINOFN(bool MIBHDOJIHJE)
	{
	}

	private void NHCNJAAMOAA(Dictionary<int, IngameAvatarClothEffectComponent.ClothEffectObject> ICANOFNHAJE, bool MIBHDOJIHJE)
	{
	}

	private EffectsRegulatorData OLAHNMBIEKD(int NIBBKONKPHP, bool JHMLGFBCFLA)
	{
		return null;
	}

	private bool MMIIDCAPEKE()
	{
		return false;
	}

	private IEnumerator KAEHBMJGENC()
	{
		return null;
	}

	private void KDPDOJIBPBE()
	{
	}

	private void ENMPDFKFBHD(int NIBBKONKPHP, bool KGOHDEBHENF)
	{
	}

	private bool GFCPLMJLBPD(int NIBBKONKPHP)
	{
		return false;
	}

	private void HBMODOLOCLM()
	{
	}

	private bool DFKFHCCEONE()
	{
		return false;
	}

	public void UpdateEpicClothes(uint FJCPAJEPBOD, uint NIBBKONKPHP, bool HAFOHABMLAC)
	{
	}

	internal void APIPOEKJPKD(ClothesUpData JCONDDPFBKK, bool HAFOHABMLAC)
	{
	}

	private bool JHDMFLNCKFB()
	{
		return false;
	}

	private bool PNBFKDKMJLM()
	{
		return false;
	}

	private void BDGDBIGKALI(ResourceID GGMIDNEJGNO)
	{
	}

	private void MJINPILIPMB()
	{
	}

	private void MFMFJKBBFAB()
	{
	}

	private void KGFFGFHJECM()
	{
	}

	private bool AIHFGBIELCF()
	{
		return false;
	}

	public void UpdateSpotLight()
	{
	}

	private bool BHDDHAPFMEA()
	{
		return false;
	}

	public void SetAnimatorTickManually(bool MOBFJLHPFNK)
	{
	}

	public void SetUpdateWhenOffScreen(bool PIDINBNGILH)
	{
	}

	public void SetUpdateWhenOffScreenDefault()
	{
	}

	public GameObject GetBackWeaponGameObject(uint AGIDPNGKIMO)
	{
		return null;
	}

	private void JGADBFHDADK(NAELPAAELNO BPDGEMBOGAA)
	{
	}

	public void RefreshBackWeaponHitProtectColliderInternal(FDAEPHMIEPC KEDHIAANLGO)
	{
	}

	public void SwapBackWeapon()
	{
	}

	private void HCCDODFLEMA(uint[] GAOILECBKAF, bool MLOCMDOLFEM, bool KNJLHFBPIGN)
	{
	}

	private bool NIDHOPLPKKJ(uint IFKNEFNGAKC)
	{
		return false;
	}

	private bool KJEMHJGAHED(uint IFKNEFNGAKC)
	{
		return false;
	}

	private uint[] JNELHPDBMBI(uint[] NDJHEOONPHO, uint[] EIGCHGBEGCD)
	{
		return null;
	}

	private void FLHHDGLNOPI(List<uint> EMANEBGLLJG, uint[] GAOILECBKAF)
	{
	}

	private void NMJFDBLDELN(Player.DAPOIBANHEH JKPPNGPCCHN)
	{
	}

	private void MIMPOLECOEJ(Player.DAPOIBANHEH JKPPNGPCCHN)
	{
	}

	private void ABFOCCODHDD(Player.DAPOIBANHEH JKPPNGPCCHN)
	{
	}

	private void PGFHAPJEGLO(Player.DAPOIBANHEH JKPPNGPCCHN)
	{
	}

	private void EJNEHLNICMG(Player.DAPOIBANHEH JKPPNGPCCHN)
	{
	}

	private void NHPBELGDGCF(Player.DAPOIBANHEH JKPPNGPCCHN)
	{
	}

	private void ICLOPCMDHKE(Player.DAPOIBANHEH JKPPNGPCCHN)
	{
	}

	private void EIPDBHPFKBJ(Player.DAPOIBANHEH JKPPNGPCCHN)
	{
	}

	private void HDPCIHCJPFE(Player.DAPOIBANHEH JKPPNGPCCHN)
	{
	}

	private void KHMKMPKBFBC(Player.DAPOIBANHEH JKPPNGPCCHN)
	{
	}
}
