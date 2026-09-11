using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW.GamePlay;

internal class NewPlayerAnimationSystemComponent : AnimationSystemComponent
{
	private enum KDKGCDLJMLN
	{
		AnimIndex3,
		AnimIndex1,
		AnimIndex2
	}

	public enum IEICKHANHAD
	{
		Default,
		CustomAnim,
		ActionCollection,
		AboveActionCollection,
		UGC,
		Count
	}

	private class EJAACHKNHMG
	{
		public int LGCLPMJLKMM;

		public int KOANKNNBAGP;

		public AnimationClip[] JNJMGKIDDKJ;
	}

	private bool KNANPAJBDDL;

	private bool MELPBKJLOJI;

	private bool LDOAJDODPPK;

	private bool COGIHIJILNO;

	private int BDKGAPJEKBI;

	protected Player MBPMMLMJOHL;

	protected bool OLOIDPBLKJO;

	private bool GHAEHBKCHIJ;

	private float CBOCHONLDJD;

	private bool OJOOOCPDEGO;

	protected bool LCJOKDOEPNG;

	protected bool KINDEMEKOHH;

	private static bool PAADDGFDHJH;

	protected static int CDOPJNPGKKH;

	protected static int MMCKOLMODEK;

	protected static int KINDKHICBCC;

	protected static int GOHAINNNDJB;

	private static int IHKGEMNCGHM;

	private static int BICDJEPCAKO;

	private static int CHDEFMFANMP;

	private static int JIEIALHAIJI;

	private static int KGCCPABPGAO;

	protected static int KCANLCCBOON;

	protected static int FEPELADPMID;

	private bool? CCKMAKIDJFL;

	private HashSet<int> CGDKIJBKAPD;

	private bool OGAHMCIBAJB;

	private const string CNJOECOFKHN = "CustomAnim";

	private const string FFOKAKFHFGO = "ExecutionAnim";

	private const string OAPDKNAEACP = "OnChair";

	private const string FIFIMEEGNDB = "PartyDance";

	public const string FreezeEmoteAnimName = "FreezeEmote";

	public const string FreezeEmoteAnimIdleName = "EmoteIdle";

	private const string GKEAIFFMPCO = "LastKillCustom";

	private AnimRef GLBENAEAKBI;

	private bool HFOIBKPKICG;

	private bool GEFPAACNHCM;

	private bool CAEHNKAANDC;

	private int LEOBPGNCAGH;

	private ResourceID EDKIOIPCJNP;

	private bool ODBKMKPKAAC;

	public bool UGCCorrectOverrideClipByOriginClip;

	protected float AFHLNMOCNDL;

	private bool FFMFKPMMMJL;

	protected float NKIIFHNBFLC;

	protected float PGOLHNDIILI;

	protected float LKNIEJBEMMB;

	private bool NDDBJLJNOGJ;

	private float ELGIEGBFDGA;

	private float FABMBDKIDPO;

	private bool JAOPIFGOBHK;

	private LazyDictionary<RuntimeAnimatorController, AnimationClip> LJCOCPKFIKA;

	private static List<KeyValuePair<AnimationClip, AnimationClip>> IPGNNMMINIO;

	private static List<KeyValuePair<AnimationClip, AnimationClip>> BCKKDKKFPKC;

	private static List<KeyValuePair<AnimationClip, AnimationClip>> GOKIIDLLANM;

	private static List<KeyValuePair<string, AnimationClip>> IIAGHFCHLLJ;

	private static Dictionary<string, AnimationClip> KFHFLEHFEBP;

	private static List<string> MCOIPEGAILO;

	private const string LKMAKNAJMPK = "NewBaseAnimController";

	private const string MKGFHAFJIBL = "NewBaseFemaleAnimController";

	private static readonly bool FPENJJKPBMI;

	private static List<AnimationClip> DHJIHONFMCB;

	private static List<AnimationClip> KPALMGLGEDI;

	private static Dictionary<string, int> LACHBFPDHID;

	private static Dictionary<string, int> KFHNKLMKFJJ;

	private static List<KeyValuePair<int, int>> CMOLDGKLAKH;

	private static List<KeyValuePair<int, int>> IKIPKMOJEJO;

	private static Dictionary<string, AnimationClip> MFCKCCJHOFJ;

	private static Dictionary<string, AnimationClip> EKKLCPEJOBD;

	private static List<AnimatorOverrideController> JMENIODIBIK;

	private bool JFHOLJMLKPI;

	private int DPMPCCMMOPE;

	private AnimatorOverrideController BHLLLOKBDAK;

	private AnimatorOverrideController JCHDBDIIDOH;

	private static AnimatorOverrideController EDAGBIJADME;

	private static AnimatorOverrideController PNKDALJJLKO;

	private bool KNBIILIHFDL;

	private RuntimeAnimatorController CGNLMDADPCG;

	private bool DDFIMKCDAFO;

	private static int IDPDJIKOBBL;

	private static int JLCLNPKDIHJ;

	public static bool ClearInvisibleController;

	public static bool ClearInvisibleAnimatorCache;

	public EJBIFHAFKOD m_UGCPlayAnimCallback;

	private static Dictionary<string, AnimationClip> MFFCDDHEABC;

	private static Dictionary<string, Dictionary<string, string>> LJMGABCLKNN;

	private static bool IHGKIELADGC;

	private static Dictionary<string, AnimationClip> HPJAFLEBHFG;

	private static bool CDKIIKOBLEN;

	private static Dictionary<string, AnimationClip> ABHHEDBPNID;

	private static List<AnimatorOverrideController> DKLENJPEGBH;

	private static Dictionary<string, int> PGOBGAGFNLL;

	private static Dictionary<string, int> KFPHBPJLCGO;

	private const int CFPNOHNLCGL = 5;

	private const int JIAMFLCEKCO = 0;

	private const bool ILFAKMGHFMI = true;

	private const bool BNGNGFGBFGJ = false;

	private bool AFGOHBEHOCO;

	private int FHCEBPBEHDE;

	private Dictionary<string, EJAACHKNHMG> JCMECLCMJBE;

	private int MFBNEOKFDOE;

	private AnimatorOverrideController ENIDHGFPDFD;

	private static bool CFGGDGJLCCD => false;

	public bool FAAGKGONEJF
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool ECMJABBJOPF => false;

	private bool CAABGBGEDHL => false;

	private bool PIFIIKALCGJ => false;

	public bool GCMPLCPNCEH
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool DOBIBFNDPKC
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float CICDNICGLCF => 0f;

	private AnimatorOverrideController FGGIALKEGIC => null;

	private bool IDFIDMKOJAL => false;

	public override float GetRealSpeed()
	{
		return 0f;
	}

	public void ResetAnimationSpeed()
	{
	}

	public void SetAnimationSpeed(float IMKNJGHAHPI)
	{
	}

	public virtual void Init(Player LDCIMNAAGNO)
	{
	}

	public AnimationRuntimeHandle PlayCustomAnimUpper(ResourceID AOFCDPKJKJO, bool MFEKPFKOMIK = false, float FOMJCCKNEOL = 0f)
	{
		return null;
	}

	public AnimationRuntimeHandle PlayCustomAnim(ResourceID AOFCDPKJKJO, bool MFEKPFKOMIK = false, float FOMJCCKNEOL = 0f, bool NNFPDFIBENC = false, Action CEHELPAIELA = null, float JNHKPFFEELH = 0f)
	{
		return null;
	}

	public void ClearCustomAnim()
	{
	}

	public void ClearFreezeEmote()
	{
	}

	public void ClearEmoteIdle()
	{
	}

	public AnimationRuntimeHandle PlayCustomAnim(AnimationClip KGAAKHKEJLB, bool MFEKPFKOMIK = false, float FOMJCCKNEOL = 0f)
	{
		return null;
	}

	public AnimationRuntimeHandle PlayExecutionAnim(ResourceID AOFCDPKJKJO, bool MFEKPFKOMIK = false, float FOMJCCKNEOL = 0f)
	{
		return null;
	}

	public void LoadCustomLastKillAnim(ResourceID MMGPJBOJIED)
	{
	}

	public void PlayFreezeCustomAnim(ResourceID JMGAFFAAPGK, ResourceID ADKDMFJGCMM)
	{
	}

	protected override void OnHandleAnimationFinished(AnimationID IJJHJMBOKEB)
	{
	}

	public void PlayPartyDance(ResourceID AOFCDPKJKJO, float GGBEMOEJDBF = 0f)
	{
	}

	public void PlaySitting()
	{
	}

	public float GetCurrentAnimationnNormalizedTime()
	{
		return 0f;
	}

	public float GetCurrentAnimationLength()
	{
		return 0f;
	}

	public bool CurrentAnimationIsName(string JCIFFMHHBHK)
	{
		return false;
	}

	public void PlayBeginCreep(EOGPGNIDOKF IDAFLIAIKDM)
	{
	}

	public bool IsDuringCreep()
	{
		return false;
	}

	public virtual void PlayEndCreep(EOGPGNIDOKF KCMJONOCMPN)
	{
	}

	private bool BBEEKBKPFKM()
	{
		return false;
	}

	public virtual void PlayFireAnim(bool NLFMEPEJOJJ = false)
	{
	}

	protected virtual void CAPCNJFMHMM()
	{
	}

	protected virtual bool KCCPKOLMKHA()
	{
		return false;
	}

	protected virtual bool AIAMJMGAPFA()
	{
		return false;
	}

	public virtual void PlayWholeBodyFireAnim(float FOMJCCKNEOL = 0f)
	{
	}

	public virtual void PlayMeleeEnergyChargeAnimation(float FOMJCCKNEOL = 0f)
	{
	}

	public virtual void PlayMeleeEnergyEndAnimation(float FOMJCCKNEOL = 0f)
	{
	}

	public virtual void PlayMeleeEnergyAttackAnimation(float FOMJCCKNEOL = 0f)
	{
	}

	public virtual void PlayWholeBodyStopFireAnim(int JFAOBKKPAHD)
	{
	}

	public virtual void PlayStopFire()
	{
	}

	public virtual void PlayReloadAnim(float NKNNPEMLIGD = 1f)
	{
	}

	public virtual void ChangeReloadAnimSpeed(float NKNNPEMLIGD = 1f)
	{
	}

	protected virtual void BKAAEKDJPAK()
	{
	}

	public virtual bool IsPlayingStandReloadAnim()
	{
		return false;
	}

	public virtual bool IsPlayingCrawlToStandAnim()
	{
		return false;
	}

	public void PlayFallingLandAnim(float FAAGLFFGJBN = 1f, bool OAKJCJHDDCM = false)
	{
	}

	private static bool LGAJGDHGFJN(float FOMJCCKNEOL)
	{
		return false;
	}

	public void PlayParartureAmim(bool ABCAHBJMJOA, float FOMJCCKNEOL = 0f)
	{
	}

	public virtual void PlayHitFlyEndAnimation(float IMKNJGHAHPI = 1f)
	{
	}

	public virtual void PlayCarryingAnim()
	{
	}

	public virtual void StopCarryingAnim()
	{
	}

	public virtual void UpdateCarryingAnim()
	{
	}

	public virtual void PlayPassiveMovingStartAnim()
	{
	}

	public virtual void PlayPassiveMovingEndAnim()
	{
	}

	public virtual void PlayBeingCarriedAnim()
	{
	}

	public virtual void StopBeingCarriedAnim()
	{
	}

	public virtual void UpdateBeingCarriedAnim()
	{
	}

	private bool GNFAANKBHJM()
	{
		return false;
	}

	private void OLMPNILLNPA()
	{
	}

	public virtual void PlayChangeWeaponAnim(FDAEPHMIEPC PJMDKPKBBAM, float IMKNJGHAHPI = 1f)
	{
	}

	protected virtual void OIMGMIHPOBF()
	{
	}

	private bool KIEPIFPMFDE(string OINKNIGKDMO)
	{
		return false;
	}

	public virtual void Play1PSightAnim()
	{
	}

	public void PlayStartSkyDiving(bool BKNCALEFCOJ)
	{
	}

	public void PlayStartTeamFlightSkyDiving(bool BKNCALEFCOJ = false, float FOMJCCKNEOL = 0f)
	{
	}

	public void PlayStartTeamSkyDriving(bool MGLHDLJHDMO, float FOMJCCKNEOL = 0f)
	{
	}

	public void PlayFlightGetOffBoard()
	{
	}

	public void PlayFlightOpenAnim(float FOMJCCKNEOL = 0f)
	{
	}

	public void PlayFlightGetOnBoard(CBEPFDCGBKB HHEFDOMPAGG = CBEPFDCGBKB.AnimationType_Normal)
	{
	}

	public void PlayStartFlightSkyDiving(bool BKNCALEFCOJ, CBEPFDCGBKB HHEFDOMPAGG = CBEPFDCGBKB.AnimationType_Normal)
	{
	}

	public void PlayStartFlightParachuting(bool MGLHDLJHDMO, CBEPFDCGBKB HHEFDOMPAGG = CBEPFDCGBKB.AnimationType_Normal, float FOMJCCKNEOL = 0f)
	{
	}

	public void PlayStartSkyDriving(bool MGLHDLJHDMO, CBEPFDCGBKB HHEFDOMPAGG = CBEPFDCGBKB.AnimationType_Normal)
	{
	}

	public void PlayStartSkySurfing(bool MGLHDLJHDMO)
	{
	}

	public void PlayStartParachuting()
	{
	}

	public void PlayStartSwimming(Player.IGJPHDANPJD OLAHOFPELBC)
	{
	}

	public void PlaySwimmingToSurf()
	{
	}

	public void PlayJump(bool ILFIKFNLDPC = false)
	{
	}

	public virtual void PlayJumpLand()
	{
	}

	public void PlaySecondJump()
	{
	}

	public void PlaySecondJumpRush()
	{
	}

	public void PlayHitAnimation()
	{
	}

	public void PlayDead(bool IECLLKLGNME, NCJFJGFECHB LJADOJKNALD = NCJFJGFECHB.DEAD_ANIM_DIR_FRONT)
	{
	}

	public void PlayLastKillAnimation()
	{
	}

	public void SetDeadAnimation()
	{
	}

	public void PlayCureAnimation(bool AOGGADPEFCC)
	{
	}

	public void PlayEatMushRoomAnimation(bool AOGGADPEFCC)
	{
	}

	public void PlayRepairingAnimation(bool AOGGADPEFCC)
	{
	}

	public float PlaySummoningAnimation(ResourceID EEOJGIGGNAA, bool MFEKPFKOMIK, bool NIHKIDGLKKB)
	{
		return 0f;
	}

	public void PlayBatteryAnimation(bool AOGGADPEFCC)
	{
	}

	public void PlayPreparationAnimation(bool AOGGADPEFCC)
	{
	}

	public virtual void PlayTriggerGrenade()
	{
	}

	public virtual void PlayStartGrenade(bool AOGGADPEFCC)
	{
	}

	public virtual void PlayStartThrowKnife(bool AOGGADPEFCC)
	{
	}

	public void PlayPullBolt(float LGKCKMCEPJK = 1f)
	{
	}

	public void PlaySkateboard()
	{
	}

	public void PlaySkateboardDash()
	{
	}

	public void PlaySkateboardJump()
	{
	}

	public void PlaySkateboardLand(float FAAGLFFGJBN = 1f)
	{
	}

	public virtual void PlayInspectorAnim()
	{
	}

	public void SetParachutingSpeed(float NAGFHDCCOMN, float HCGJCOGLGDL)
	{
	}

	public void SetJetFlySpeed(float NAGFHDCCOMN, float HCGJCOGLGDL)
	{
	}

	public void SetSkydivingSpeed(float HCGJCOGLGDL)
	{
	}

	public void SetSkysurfingSpeed(float HCGJCOGLGDL)
	{
	}

	public void SetFlightRoamSpeed(float NAGFHDCCOMN, float HCGJCOGLGDL)
	{
	}

	public virtual void GetOnVehicle(int HDFILHFDBKB)
	{
	}

	public virtual void GetOffVehicle()
	{
	}

	private void BJOEADHEILK(float HDFILHFDBKB)
	{
	}

	protected virtual float PHGPODIKCMO(float OPFDOJNODPD)
	{
		return 0f;
	}

	public virtual void SetSpeed(float NAGFHDCCOMN, float HCGJCOGLGDL, bool CCKOMJBNMNE = false)
	{
	}

	public void SetFPPFiringTime(float GCKEGAPLLNL)
	{
	}

	public void SetInShoal(bool FFJCGLNLMAL)
	{
	}

	public void UpdateAnimSpeed(float IMKNJGHAHPI)
	{
	}

	public void SetVehicleSteeringAngle(float PCOPDDLBLMI)
	{
	}

	public void SetHasDriver(float PCOPDDLBLMI)
	{
	}

	public void RefreshBaseLayerDefaultState(bool BJLMOJDDFID = false)
	{
	}

	public void ResetToAnimatorDefaultState()
	{
	}

	public void UpdateSpeedScale(float COKDFCKFHEM)
	{
	}

	private Dictionary<string, AnimationClip> LKHAJNABJGL(Dictionary<string, AnimationClip> KLHMJAKIJJM, AnimatorOverrideController NPKBJMJFCGA)
	{
		return null;
	}

	private void IPGINJFBMMH(RuntimeAnimatorController NPKBJMJFCGA)
	{
	}

	private void BIGNOKBJBNE(RuntimeAnimatorController NPKBJMJFCGA)
	{
	}

	public void ReplaceJumpLandingClip()
	{
	}

	public void RecoverJumpLandingClip()
	{
	}

	protected override uint GetMaxLayerUsed()
	{
		return 0u;
	}

	protected override void BeforeTransitionToDefaultStateAfterFinish()
	{
	}

	public virtual bool IsNotNeedRefreshUpbodyLayer()
	{
		return false;
	}

	public bool IsPlayingStandFire()
	{
		return false;
	}

	public bool IsPlayingGrendaFireEnd()
	{
		return false;
	}

	protected override void OnTransitionToDefaultState(int KEPNPINHFJP, bool OAKJCJHDDCM = false, bool BJLMOJDDFID = false)
	{
	}

	private void KHGEPJBEOOL(bool OAKJCJHDDCM = false, bool BJLMOJDDFID = false)
	{
	}

	protected override void Awake()
	{
	}

	public bool GetNeedUpdateValue()
	{
		return false;
	}

	public void SetAnimatorCullingMode(AnimatorCullingMode NOMECPENDNA)
	{
	}

	public void SetForceAnimatorAlwaysAnimate(bool IDCHCEECMBE, string OINKNIGKDMO)
	{
	}

	public void ReSetAnimatorCullingMode()
	{
	}

	public override void EnableAnimator(bool FMDGJDIELLK)
	{
	}

	public override void OnAnimControllerSwitched()
	{
	}

	public void Tick(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	protected virtual void LateUpdate()
	{
	}

	public void SetEnableOptAnimationIntervalByFrustum(bool CBCAJJJCKLH)
	{
	}

	public void UpdateAnimator(bool MGGFGEHLKOE = false)
	{
	}

	public void DisableCrossFrameUpdate()
	{
	}

	public void ResetCrossFrameUpdate()
	{
	}

	public void ForceUpdateAnimator(bool LDJNGEIHDEP = false)
	{
	}

	protected override T PlayAnimInternal<T>(AnimationConfigData JCONDDPFBKK, bool OAKJCJHDDCM, float IKKDHHOBHJG = 0f, bool MFEKPFKOMIK = false)
	{
		return null;
	}

	public void AddAnimSkip(AnimationID IJJHJMBOKEB)
	{
	}

	public void RemoveAnimSkip(AnimationID IJJHJMBOKEB)
	{
	}

	private bool AODOMBPDHLJ(AnimationID IJJHJMBOKEB)
	{
		return false;
	}

	public static void ReleaseStaticResources()
	{
	}

	public bool IsEmoteAnim(AnimationID IJJHJMBOKEB)
	{
		return false;
	}

	public bool IsPlayingEmoteAnim()
	{
		return false;
	}

	public bool IsPlayingSameCustomAnimation(ResourceID IJJHJMBOKEB)
	{
		return false;
	}

	public void BindTransformerAnimator(Animator IIDGAOHNPKI, bool AKOBAHAJNBF = false)
	{
	}

	public void SetAnimatorFloat(int LIKPJDHGPFG, float GPFPIAMCEMI)
	{
	}

	public void SetAnimatorBool(int LIKPJDHGPFG, bool GPFPIAMCEMI)
	{
	}

	public void SetAnimatorTrigger(int JCIFFMHHBHK, bool NFEMHCKDKOB)
	{
	}

	public void SlavePlay(int BNCBFFPPNEJ, int PNLKPJNLDGB, float FOMJCCKNEOL)
	{
	}

	protected virtual void HCBJGINBFPN(Player LDCIMNAAGNO)
	{
	}

	public void DisableDynamicAnimationFlag(bool NPHAJOAELIL)
	{
	}

	public void Clear()
	{
	}

	private static void FHEFOONEJEL(string APHHNHEDHKD)
	{
	}

	private void NEKOLJOMJML(string CHHBBHIFPEP, AnimRef KAHPOGNMIJB, float JNHKPFFEELH = 0f)
	{
	}

	private AnimatorOverrideController MAAMDOPAIJB(string CHHBBHIFPEP, AnimationClip KGAAKHKEJLB)
	{
		return null;
	}

	private AnimatorOverrideController LDLMCIFKJOP(string CHHBBHIFPEP, AnimationClip KGAAKHKEJLB)
	{
		return null;
	}

	private static void GNCIFMGDHPM(RuntimeAnimatorController PPPAJPHDKBJ, AnimatorOverrideController PGJBLGAECNI)
	{
	}

	private static void EBNLACEMKEC(AnimatorOverrideController EONDLJEPGIO, AnimatorOverrideController PGJBLGAECNI)
	{
	}

	private AnimatorOverrideController HNICHHGOGCI(string CHHBBHIFPEP, AnimationClip KGAAKHKEJLB)
	{
		return null;
	}

	public void ClearControllerAndCache()
	{
	}

	public void ClearAnimatorControllerAndCache()
	{
	}

	public void ClearAnimatorCache()
	{
	}

	private void JHPMLKLOAPE(ref AnimatorOverrideController PKOFNIADHHN)
	{
	}

	public bool NeedSetController()
	{
		return false;
	}

	public void RevertController()
	{
	}

	private void JDBHJAPPCMM(AnimatorOverrideController EHKHGICCIEG)
	{
	}

	private bool HAFIJKPHGJL()
	{
		return false;
	}

	private void CGAIEEHJEJH()
	{
	}

	private void FIHBLPMNBPJ(string CHHBBHIFPEP, string IKGLBPIBLLB, Dictionary<string, AnimationClip> FLBAGKLNIHC)
	{
	}

	private void CBNKMDOMEJA(AnimatorOverrideController EHKHGICCIEG)
	{
	}

	public override AnimationRuntimeHandle PlayAnim(AnimationID IJJHJMBOKEB, bool EIBCNMILKFP = false, float GJGJIFANHBN = 0f, bool OAKJCJHDDCM = false, bool MFEKPFKOMIK = false)
	{
		return null;
	}

	private bool ILLNKGEEIGG()
	{
		return false;
	}

	private bool PHCNMJLJBBK()
	{
		return false;
	}

	private bool HPDJKKCLFDF(AnimationConfigData JCONDDPFBKK)
	{
		return false;
	}

	private bool MOMMEFINHAB(AnimationConfigData JCONDDPFBKK)
	{
		return false;
	}

	private AnimatorOverrideController NAMKKHENDAH()
	{
		return null;
	}

	private AnimatorOverrideController ECEIAOBFCHI()
	{
		return null;
	}

	private AnimatorOverrideController HNGGHLEKCHK(RuntimeAnimatorController GJNDEBNIJAI, ref AnimatorOverrideController BHJBNLGOIHB)
	{
		return null;
	}

	private void BJCMKAGPDNL(AnimationID IJJHJMBOKEB)
	{
	}

	private void MPBJKENKEKH(List<string[]> HFPCBGPIDPD, AnimationID IJJHJMBOKEB)
	{
	}

	private void LOLEBCNEPLN(List<AnimRef> ABDCKCJAIIP, AnimationID MCMMEMONPCG)
	{
	}

	private void FEFCFDECMGE(AnimatorOverrideController KLHMJAKIJJM)
	{
	}

	private bool AMEJGKPNPHF(List<AnimRef> ABDCKCJAIIP, AnimatorOverrideController KLHMJAKIJJM)
	{
		return false;
	}

	private void BJCMKAGPDNL(AnimationClip KGFLHKIPGCL)
	{
	}

	private bool IJMJMCADDKF(AnimatorOverrideController POLCFEPEODF)
	{
		return false;
	}

	private bool IJMJMCADDKF(List<AnimationClip> FALOHGKAMOD, AnimatorOverrideController POLCFEPEODF)
	{
		return false;
	}

	private void HOINPINCBAJ(string JCIFFMHHBHK, AnimationClip KGAAKHKEJLB)
	{
	}

	private AnimatorOverrideController LMNIFDHJKDN(AnimatorOverrideController EHKHGICCIEG)
	{
		return null;
	}

	private AnimatorOverrideController DOENCOEACCO(string CHHBBHIFPEP, AnimationClip KGAAKHKEJLB)
	{
		return null;
	}

	private void PEDHMJDGJCG(AnimationID IJJHJMBOKEB)
	{
	}

	private AnimatorOverrideController OODHBEJCEKB(AnimatorOverrideController HMILPEFONCC)
	{
		return null;
	}

	private List<AnimationClip> IFCOLPLICNN()
	{
		return null;
	}

	protected virtual AnimatorOverrideController MDONKLCBLHI(List<KeyValuePair<AnimationClip, AnimationClip>> HNFMHAOAAEF)
	{
		return null;
	}

	private void BNLFHCAEGMJ(List<KeyValuePair<AnimationClip, AnimationClip>> HNFMHAOAAEF)
	{
	}

	private void BNLFHCAEGMJ(ref AnimatorOverrideController DEEBEKJPMOB, List<KeyValuePair<AnimationClip, AnimationClip>> HNFMHAOAAEF)
	{
	}

	private void JAFHCIENDKJ(bool PFBAFDMCGPF, ref int DMHNGDNFCCO, string[] IGEKPNKJEOE)
	{
	}

	private void NADFCOIBJBD(List<KeyValuePair<AnimationClip, AnimationClip>> HMDMHDNIHAE, bool FMINIFIAALB)
	{
	}

	private void LEBELGJILHN(List<KeyValuePair<AnimationClip, AnimationClip>> HMDMHDNIHAE)
	{
	}

	private void IJKACAMICIG(List<KeyValuePair<AnimationClip, AnimationClip>> HMDMHDNIHAE)
	{
	}

	private void CEGJFDAGFFH(List<KeyValuePair<AnimationClip, AnimationClip>> HNFMHAOAAEF)
	{
	}

	private void FDOECLLHJAD(AnimatorOverrideController JELJKAKHDDH)
	{
	}

	private void NIHOELOOKDG()
	{
	}

	private void AHLKGMLCNFE(Dictionary<string, AnimationClip> KGOHCBMJLMN)
	{
	}

	private void ENANCJJFMPA(string[] IHJPEPOMBBC, Dictionary<string, AnimationClip> KGFLHKIPGCL)
	{
	}

	private void GGNCGCONPMM(RuntimeAnimatorController NPKBJMJFCGA)
	{
	}

	private bool DJEFPELCNAL(RuntimeAnimatorController FHLMOLBJFEF)
	{
		return false;
	}

	public void SwitchWeaponAnimController(AnimatorOverrideController EHKHGICCIEG)
	{
	}

	public override void SwitchAnimController(AnimatorOverrideController NPKBJMJFCGA)
	{
	}

	private void AOEGIAAPDDK()
	{
	}

	protected AnimatorOverrideController OCFNEOGGKMI(AnimatorOverrideController NPKBJMJFCGA)
	{
		return null;
	}

	private AnimatorOverrideController MCJCIJAOJDE(Dictionary<string, AnimationClip> BONBNIOCGHN, AnimatorOverrideController GJNDEBNIJAI)
	{
		return null;
	}

	private void PMLJEBDMPFL(Dictionary<string, AnimationClip> BONBNIOCGHN, AnimatorOverrideController KLHMJAKIJJM)
	{
	}

	private AnimatorOverrideController IOJNDFLJOOB(RuntimeAnimatorController GJNDEBNIJAI)
	{
		return null;
	}

	private AnimatorOverrideController IOJNDFLJOOB(RuntimeAnimatorController GJNDEBNIJAI, ref bool BIHGPBGJEJL)
	{
		return null;
	}

	private static AnimatorOverrideController MDONKLCBLHI(RuntimeAnimatorController GJNDEBNIJAI)
	{
		return null;
	}

	private void CGDHHDNGJGC(AnimatorOverrideController EHKHGICCIEG)
	{
	}

	private void CHCOIICJKBP(IEICKHANHAD GKMFJPIEFGH, Dictionary<string, AnimationClip> ABJHFFGHCNO)
	{
	}

	public void SetOverrideClips(Dictionary<string, AnimationClip> ABJHFFGHCNO, IEICKHANHAD GKMFJPIEFGH)
	{
	}

	public void SetOverrideClip(string JCIFFMHHBHK, AnimationClip KGAAKHKEJLB, IEICKHANHAD GKMFJPIEFGH)
	{
	}

	public void ClearOverrideClip(string JCIFFMHHBHK, IEICKHANHAD GKMFJPIEFGH)
	{
	}

	public void ClearOverrideClips(IEICKHANHAD GKMFJPIEFGH)
	{
	}

	private bool JNEMKOGIBKL(EJAACHKNHMG NBLHNPAHGNA, IEICKHANHAD GKMFJPIEFGH, AnimationClip KGAAKHKEJLB)
	{
		return false;
	}

	private bool JNEMKOGIBKL(string JCIFFMHHBHK, AnimationClip KGAAKHKEJLB, IEICKHANHAD GKMFJPIEFGH)
	{
		return false;
	}

	private bool PAJEFFKMIOJ(IEICKHANHAD KDJNEHDAAFL)
	{
		return false;
	}

	private AnimatorOverrideController GNDDNFJOPMK(string CHHBBHIFPEP, AnimationClip KGAAKHKEJLB, IEICKHANHAD GKMFJPIEFGH)
	{
		return null;
	}

	private void DMEGDPMNKCJ(AnimatorOverrideController NPKBJMJFCGA)
	{
	}

	private void MEDJMONCAMI(AnimatorOverrideController OJPPJMMIIMI)
	{
	}

	private AnimatorOverrideController KLDNJONDLHO(AnimatorOverrideController IPNFMPKKODK, AnimatorOverrideController OJPPJMMIIMI, bool OPFJKEIBHMK, bool IEKODNNLBGE)
	{
		return null;
	}

	private bool MDCEOELNKJL(AnimatorOverrideController EONDLJEPGIO)
	{
		return false;
	}

	private void CLHICHPLKMH(AnimatorOverrideController PGJBLGAECNI, ref bool CPOCBPJPDDD)
	{
	}

	private void ANHKIAOAPFK(AnimatorOverrideController PGJBLGAECNI, ref bool CPOCBPJPDDD)
	{
	}

	private void ACAMJGPILJG(AnimatorOverrideController PGJBLGAECNI)
	{
	}

	private void PMELIJBKMIH(AnimatorOverrideController PKOFNIADHHN)
	{
	}

	public float _003C_003EiFixBaseProxy_GetRealSpeed()
	{
		return 0f;
	}

	public void _003C_003EiFixBaseProxy_OnHandleAnimationFinished(AnimationID P0)
	{
	}

	public uint _003C_003EiFixBaseProxy_GetMaxLayerUsed()
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_BeforeTransitionToDefaultStateAfterFinish()
	{
	}

	public void _003C_003EiFixBaseProxy_OnTransitionToDefaultState(int P0, bool P1, bool P2)
	{
	}

	public void _003C_003EiFixBaseProxy_Awake()
	{
	}

	public void _003C_003EiFixBaseProxy_EnableAnimator(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnAnimControllerSwitched()
	{
	}

	public AnimationRuntimeHandle _003C_003EiFixBaseProxy_PlayAnim(AnimationID P0, bool P1, float P2, bool P3, bool P4)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_SwitchAnimController(AnimatorOverrideController P0)
	{
	}
}
