using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;
using proto;

namespace COW.GamePlay;

internal class PlayerNetwork : Player, JKADJKOFGEM
{
	public class LJBAALIHDEE : ShadowStateBase
	{
		public Vector3 AALEAHDJAMC;

		public Vector3 PHEOMEDPGED;

		public Quaternion DOGHPBHDLCJ;

		public Quaternion GBHPAJHAAMF;

		public Quaternion JLKECIKIBPN;

		public Quaternion KMPECEDDJLC;

		public IGJPHDANPJD OGGJIIHFHMM;

		public EOGPGNIDOKF BGDKLEHDFJO;

		public float CCFMBPKLPEE;

		public float BCHNBNCLCHP;

		public Vector3 FAEAMHFNBPD;

		public uint POEJOGDILPP;

		public Vector3 CKBILFIAFKP;

		public Vector3 BOMAMFBCOGK;

		public int MNAFFIEBGAD;

		public override void Clear()
		{
		}

		public void _003C_003EiFixBaseProxy_Clear()
		{
		}
	}

	private enum NNBIDBCJBEK
	{
		None,
		SpeedUp,
		SpeedDown,
		HealReduce
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<EADOMEKFHBE> _003C_003E9__277_0;

		internal bool GJHHHKOBPPM(EADOMEKFHBE NBLHNPAHGNA)
		{
			return false;
		}
	}

	private sealed class DEAFNAPNMHL
	{
		public PlayerNetwork KOKNHFGCGLN;

		public uint ODBHABBADHF;

		internal void AOGGLEICKHG()
		{
		}
	}

	private sealed class HBPKCAIIGGG
	{
		public PlayerNetwork KOKNHFGCGLN;

		public IGJPHDANPJD FKBFGALFHKP;

		public EOGPGNIDOKF PDEFEPLFLPA;

		public JOLPCBKIKEJ OINKNIGKDMO;

		internal void GGEENOANOPA()
		{
		}
	}

	private sealed class ONOBOGBCNFN
	{
		public PlayerNetwork KOKNHFGCGLN;

		public KKHHIILGECK APHHNHEDHKD;

		internal void JCALBIINBPL(bool HMMNPFJHLEE)
		{
		}
	}

	private bool NBMJBFDAKLB;

	private bool MPODOLJGHMP;

	protected float KMNJDMOHJBO;

	protected float OKNPEOCMOIN;

	private bool ALAPDEMAFGO;

	private float JCNKKCBHMIM;

	private float IJOALDDCOPF;

	private float FKAEHDGAEMI;

	public uint m_LastValidTickCount;

	public LJBAALIHDEE m_ShadowState;

	private List<AGACNOCEEFP> PGDAJGDOIPK;

	public List<MNIGBOFNIEF> PresetLoadoutInfos;

	public List<EADOMEKFHBE> PresetSkillInfos;

	protected uint EDECFNBADCC;

	protected BaseProfileInfo KAKEEBABBIP;

	public EOGPGNIDOKF PreKnockDownState;

	protected bool FPDMJGHFDJN;

	protected bool BANFCMAGPEL;

	private SortedList<uint, uint> MOGEALNCEFC;

	private SortedList<uint, uint> NGDGIKJFFCL;

	private readonly SortedList<uint, uint> NJHDABAAGOK;

	private SortedList<uint, uint> FDBNNPPEGMD;

	private uint HGOJCJCCJGO;

	private Dictionary<uint, uint> MEFCCFABKMB;

	private const float BJDDIGHICBP = 10000f;

	protected float PNEEICGMOGG;

	protected EPreparationTimerType JOJOJDCFNAK;

	private uint BCKBCDGNLAK;

	private uint FPKKOANGHLF;

	private uint NLGBBBFGONA;

	private float BBJCHDAJIBC;

	private float JFOPDHIHIIC;

	private const float EDCNMGAGLJO = 0.5f;

	private const float PDFEPDEHPFM = 0.01f;

	private const float PABLMEGBNFJ = 0.0001f;

	private const float DKDONCALKEB = 0.7f;

	private float JIABJHJGDKL;

	private static HashSet<int> EJJNMPFAFDN;

	private List<uint> ABJIDDOEEBN;

	private float EJKGAPAHABD;

	private static readonly object[] DJGMNEGEKKN;

	private static readonly object[] KKFOMAIFCGB;

	private Vector3 FFNPEOGCLCB;

	private uint DOELEOOOMJN;

	private float OCJBIHDMFMG;

	private float JCKFBLPOELP;

	private float DBJOIBLJPLD;

	private float AOEJHEEHABD;

	private float JECBECCDNGK;

	private float AKGNACCNNOO;

	private float EHOOFLOFFEO;

	private uint KJKMDEHOIBI;

	private bool PGKJJHGJMMJ;

	private float IECJMKOLPNM;

	private const float PJMMMPEJCPN = 1f / 30f;

	private bool MGBLPGEOHGF;

	private bool MFBGPEJBDJM;

	private static Dictionary<uint, CEKLEBBHLIG> HLLDNLILEDI;

	private static HashSet<uint> LHECPIJOLKK;

	private static HashSet<uint> PJNNFJHHMOC;

	private static HashSet<uint> NMBPLEMNBMJ;

	private static HashSet<uint> JFPPMFAJMNK;

	private static Dictionary<uint, uint> OOOEKEIBFAE;

	private static List<CEKLEBBHLIG> HOMMMCMCPOA;

	private const int JLPDFDLPPNK = 1;

	private const float FGCFMOHJEFA = 1.25f;

	private const float DGLLHMHHNHA = 1E-06f;

	private bool MNPFAKHGJEB;

	private bool OMDFKGDMBED;

	private Vector3 BEGJDHGPBAO;

	private Vector3 NAFFNIKGFKM;

	private Vector3 JEALNDNJNPK;

	private Vector3 BMNCJGICJCJ;

	private Quaternion EDIACEPGLFB;

	private Quaternion NNGDEPPFGOJ;

	private Quaternion AIPMDFOGLII;

	private Quaternion CCLMMKMHFLO;

	private int DCFPNALFNLN;

	private int KOLJFKNKKMM;

	private float BGHGPHBIFHD;

	private bool AGHDLEBMGBN;

	private bool FLJPLCOAALJ;

	private uint KAKEBIIHBFJ;

	private uint FAELFCLKENM;

	private IGJPHDANPJD DJBGNCPIFND;

	private EOGPGNIDOKF OCMPEPFIDLB;

	private JOLPCBKIKEJ JDFKIGDEDPO;

	private uint HOHFAEINHOJ;

	private uint MELBKFIKGHN;

	private uint DLFCMJGNDAA;

	private float DBPJDANGAGA;

	private List<AGACNOCEEFP> LLOBALKFAIC => null;

	public override BaseProfileInfo JALNGENAEIK => null;

	protected ushort GDBFNAAEOFL => 0;

	public ESocialHall.TitleType FJNBEDNALLD => ESocialHall.TitleType.TitleType_NONE;

	public override bool DFAKEBBLEBA => false;

	public override void SendChangeToGBFootBall()
	{
	}

	public override void SendCancelGBFootBall()
	{
	}

	public uint GetLastValidTickCount()
	{
		return 0u;
	}

	public void ResetShadowStateToCurrentPhysX()
	{
	}

	protected override bool BPCIANKBNJF()
	{
		return false;
	}

	protected override bool ECDHPHFJHIC()
	{
		return false;
	}

	public override bool HaveFlight()
	{
		return false;
	}

	public SortedList<uint, uint> GetPlayerWeaponSkinMap()
	{
		return null;
	}

	public void SetIsInWaitingRoom(bool PIDINBNGILH)
	{
	}

	public void UpdateVehicleSkinMap(List<uint> OCIEGHKALIJ)
	{
	}

	public uint GetVehicleSkinIDByVehicleID(uint FFOAOKAFODF)
	{
		return 0u;
	}

	public override BaseProfileInfo PlayerBaseProfile()
	{
		return null;
	}

	public bool CanUseTreasureMap()
	{
		return false;
	}

	public override void InitProperties(object OOCMJCKJHMG, bool PGGEHAIHHFG = true)
	{
	}

	private void BNKGBDKMDGJ(uint DNIANGNBCNF)
	{
	}

	private void NFCENFJPOPD(JPEOBBKALLB MPKDLBNMIJO)
	{
	}

	private void BEIFMMBIMIF(uint OPICPLLMPFE)
	{
	}

	private void DKDBFPMIPFN(uint KCEKOJAJGHB)
	{
	}

	private bool HKJPCLMCAOJ(COEDKLIGPPD AHDONPCGJOL)
	{
		return false;
	}

	protected bool IMHEGKMCPMM(string GNJHNAEHEFP)
	{
		return false;
	}

	private void LAKNOIHGBGL(COEDKLIGPPD AHDONPCGJOL)
	{
	}

	protected virtual bool GFDMAGPCFGN()
	{
		return false;
	}

	protected override void BPPIJBDGHMG()
	{
	}

	protected void NKNCNFCCBGL()
	{
	}

	private static void LFNIHKPENOF(FLPGKKGLKOG MNLLMDKFFNO, ALCBKBHIOAJ CBCAJJJCKLH)
	{
	}

	public virtual void PushPlayerSyncedOptimizedStateData(object CHDPPLFBCJA, uint OJFBGFOOKEK)
	{
	}

	private void HNNFPNPLGLB(ALCBKBHIOAJ EPOOCGNJOFD, ref Quaternion IPKKCHLDJMA, ref Quaternion HEEEBLJBDNI, uint OJFBGFOOKEK)
	{
	}

	public void PushPlayerSyncedPosition(object CALPJEEOCIC, uint OJFBGFOOKEK)
	{
	}

	private void DAMFEBOGJAB(uint OJFBGFOOKEK, uint MICLJKJCFIE)
	{
	}

	private bool EDPOPFHKIHJ(IGJPHDANPJD KCJFPPPJCGK, EOGPGNIDOKF BJJAEOLEFGH, uint OJFBGFOOKEK)
	{
		return false;
	}

	private void KKHPMAEEKFM()
	{
	}

	private void CNOAPIHDCMJ(IGJPHDANPJD KCJFPPPJCGK)
	{
	}

	public virtual void PushPlayerSyncedStateData(object CHDPPLFBCJA, uint OJFBGFOOKEK)
	{
	}

	public virtual void SyncStartFire(byte CBCAJJJCKLH)
	{
	}

	public virtual void SyncStartWholeBodyFire(byte CBCAJJJCKLH, uint JFAOBKKPAHD)
	{
	}

	public void SyncStartWeaponExpansionAbility()
	{
	}

	public void SyncExecuteWeaponExpansionAbility(HOKIGPKKDJO KAEPDGADBPN)
	{
	}

	public void SyncExecuteWeaponExpansionAbilityState(CEIFDKNFJJH KAEPDGADBPN)
	{
	}

	public void SyncEndWeaponExpansionAbility()
	{
	}

	public virtual void SyncStopFire()
	{
	}

	public virtual void SyncStartReload(float NKNNPEMLIGD)
	{
	}

	public virtual void SyncStartSegmentReload(float NKNNPEMLIGD, float OPGOLPJOEGO)
	{
	}

	public virtual void SyncStopReload(EIMGDHFECAL APHHNHEDHKD)
	{
	}

	private void EPDLFPAAPKM()
	{
	}

	private void GFOCLOFMFLH(float HOGHEFNINAE)
	{
	}

	public virtual void SyncPlayEmotionAnimation(KKHHIILGECK APHHNHEDHKD)
	{
	}

	private void FBBEHEAPCKP(KKHHIILGECK APHHNHEDHKD)
	{
	}

	public virtual void SyncPickupInventory(BDEEPLNDDPD APHHNHEDHKD)
	{
	}

	public virtual void SyncLoadoutRuntimeValue(KFEOHKFMACA APHHNHEDHKD)
	{
	}

	public virtual void SyncDropInventory(uint DBPPPOBFJNP, uint NHPFOMNHMGM, byte OINKNIGKDMO, uint LADDHFKOBJG)
	{
	}

	public virtual void SyncDropInventoryForDeath(CAOFOMKBHBD APHHNHEDHKD)
	{
	}

	public virtual void SyncUpdateTeamScoreboardInventory(List<KGCINJIENNL> IPCPKIPFHKF)
	{
	}

	public virtual void SyncUpdateScoreboardInventory(DCHICBJFCKB APHHNHEDHKD)
	{
	}

	public virtual void SyncRemoveInventoryList(NBHDGJCAOFK APHHNHEDHKD)
	{
	}

	public override void OnUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private void JMLAJAMMKOE()
	{
	}

	private bool DFHPPPLBFLI(float GAECLHHKCFC, bool IOJGGGFBOKM, float LBGBFFLDANJ)
	{
		return false;
	}

	private bool FEKLFEKIDDA(float GAECLHHKCFC, bool IOJGGGFBOKM, float LBGBFFLDANJ)
	{
		return false;
	}

	private bool GNBKAENFKLD()
	{
		return false;
	}

	private void JNANELNGLEK(EntityVisualEffectManager NPMGCKHIMKH, NNBIDBCJBEK AHMBGMMPGAJ, bool OBNHENOEEBE)
	{
	}

	private static ResourceID DBNBHAHJOOC(NNBIDBCJBEK AHMBGMMPGAJ)
	{
		return default(ResourceID);
	}

	private void LAHLONKDJCG(EntityVisualEffectManager NPMGCKHIMKH, NNBIDBCJBEK AHMBGMMPGAJ)
	{
	}

	private uint MHIBDIPDBBG(NNBIDBCJBEK AHMBGMMPGAJ)
	{
		return 0u;
	}

	private void ECFCGIMPOKG(NNBIDBCJBEK AHMBGMMPGAJ, uint OPHACENOMIL)
	{
	}

	private void LAINEDLEJJG(EntityVisualEffectManager NPMGCKHIMKH, NNBIDBCJBEK AHMBGMMPGAJ)
	{
	}

	private void HMLIBNNNIEG()
	{
	}

	private void HDLFMOIOHJH(EntityVisualEffectManager NPMGCKHIMKH, ref uint OPHACENOMIL)
	{
	}

	private static HashSet<int> EJOEHDOJLLO()
	{
		return null;
	}

	private bool HLPNOLKDCOC()
	{
		return false;
	}

	public void SyncDoAction(BDKHPEHCEFN APHHNHEDHKD)
	{
	}

	public void SyncTryUseInventory(bool AOGGADPEFCC, uint HIDANNMJCDP)
	{
	}

	public override void RequestStopEmote4Plant()
	{
	}

	public override void RequestPlayEmote4Plant(OPICPDCLKAG FDJBPCFOEHM, uint ONFPCIABJJC)
	{
	}

	public override void RequestStoreInWareHouse(uint ONFPCIABJJC)
	{
	}

	public override void RequestStopStoringInWarehouse()
	{
	}

	public override void RequestOpenTreasury()
	{
	}

	public override void RequestOpenTimingTreasureBox()
	{
	}

	public override void RequestHayrickJump()
	{
	}

	public override void RequestPray4EscortBoss(uint ONFPCIABJJC)
	{
	}

	public override void RequestStopPraying4EscortBoss()
	{
	}

	public override void DoUpdateActionState(EAcationState LIJCJHEAOOK, EPreparationTimerType NDMAKMHCKLG, float CNKMEPFCJOM, object[] KHDEFOMIAPK)
	{
	}

	public virtual void SyncEquipmentChanged(HFMMCIINEED APHHNHEDHKD)
	{
	}

	public virtual void SyncEquipmentChangedForDeath(JIJCIPNLFMJ APHHNHEDHKD)
	{
	}

	public void SyncUnEquipAttachment(NILPAOHDCPC APHHNHEDHKD)
	{
	}

	public virtual void SyncAttachmentChanged(OCLFCDOMGLA APHHNHEDHKD)
	{
	}

	public virtual void SyncAttachmentChangedForDeath(CPNGLJFOPKC APHHNHEDHKD)
	{
	}

	public virtual void SyncSafeBoxInventoryChanged(LPEIDOGINNA APHHNHEDHKD)
	{
	}

	public virtual void SyncPlayersVisibility(ulong EIOKHLKJEEL)
	{
	}

	public void NotifyServerGotForceSyncState(uint DNLOGLJJDCJ, bool CCIAJLDHJMI)
	{
	}

	public void SyncStateWithServer(PGABPEBFLOK APHHNHEDHKD)
	{
	}

	public override void OnWeaponReloadImmediateStarted(float ABPKDCKICLA, bool BOJIDHIFINO = false)
	{
	}

	public override void OnWeaponReloadImmediateFinished(bool NMLHNDMIOOD)
	{
	}

	public void SendStartReload(float ABPKDCKICLA, bool BOJIDHIFINO)
	{
	}

	public void SendFinishReload(bool NMLHNDMIOOD)
	{
	}

	public override void OnWeaponReloadStarted(float ABPKDCKICLA, bool BOJIDHIFINO = false)
	{
	}

	public override void OnWeaponReloadFinished(bool NMLHNDMIOOD)
	{
	}

	public override void OnWeaponLift(bool DKLNGCHAKOJ = false)
	{
	}

	public override void UpdateAI(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	protected override void HLGHCAFHBGD()
	{
	}

	private void OEFNAGOPKBN(bool LKPIHANPKIE, float HOGHEFNINAE, out bool POGFBIPEGPM, out float IBPJBLPCANO)
	{
		POGFBIPEGPM = default(bool);
		IBPJBLPCANO = default(float);
	}

	public override void UpdateBehavior(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private void PPGKACJNJAK()
	{
	}

	private void LLDHBCBODKA()
	{
	}

	protected Vector3 MLIKKCIHJEC(Vector3 KLGGIFKBCGP, IGJPHDANPJD LNKELIPAHHE, float EFMLCKBMOEJ = 0f)
	{
		return default(Vector3);
	}

	protected override void FPIBBHGKPOM()
	{
	}

	private void JNHIFGCOPEN(float HOGHEFNINAE, out bool POGFBIPEGPM, out float IBPJBLPCANO)
	{
		POGFBIPEGPM = default(bool);
		IBPJBLPCANO = default(float);
	}

	public override void UpdateKinematics(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public void ComputePosition(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private void PCPGNAAGILM(Transform INCBAMDEBAO, float FIHMGOCIADK, Quaternion FOALBMBCJLF)
	{
	}

	private void KLIOECHDILE(Transform INCBAMDEBAO, float FIHMGOCIADK, float HOGHEFNINAE)
	{
	}

	private void DIFGGMAMEFG(Transform INCBAMDEBAO, float FIHMGOCIADK, float HOGHEFNINAE)
	{
	}

	private void HEGMDBECBKA(float GGNMINOLKNC)
	{
	}

	private void DOLEGBHPCHJ(float GGNMINOLKNC)
	{
	}

	private void IBINPKGMBOA(float GGNMINOLKNC, Transform PFJFADHEJLJ)
	{
	}

	public override void OnRecycleClearData()
	{
	}

	public override void OnGetOffSeesaw(LevelSeesaw OMHKFPABEGF)
	{
	}

	public override void OnGetOffChair(LevelChair CNLHOCFGMCK)
	{
	}

	public override void OnGetOffVehicle()
	{
	}

	public override void OnGetOnVehicle(Vehicle FKJMCGEFJMD)
	{
	}

	public override void OnGetOnFerrisWheel(LevelFerrisWheel OPFDOJNODPD, byte ABHFDDCCINN, byte JALHHJFCJAF)
	{
	}

	public override void OnGetOffFerrisWheel(byte ABHFDDCCINN, byte JALHHJFCJAF)
	{
	}

	public override void ClientSetOnBoard()
	{
	}

	public override int TakeDamage(int PMNNBDDKCCE, BHGGAEEHJCO FNOOENEHBJP, GLLLEDKLLDA PMMCGNJHOOA = null, int HPPACPHIPCP = -1, Vector3 BAAJEMEJACH = default(Vector3), Vector3 KHNFEFFKMEB = default(Vector3), List<float> LFLPGCMLPFM = null, LOAEBBHPMEK AOJANNHGCEA = null, uint AHPBOLHPNMH = 0u)
	{
		return 0;
	}

	public override void TakeHealing(DLOFHLEHHNP LDOJBPIKBIK, List<float> LFLPGCMLPFM = null)
	{
	}

	public override void OnWeaponReloadSpeedChanged(float NKNNPEMLIGD)
	{
	}

	public override void StartFiring(FDAEPHMIEPC KEDHIAANLGO)
	{
	}

	public override void StartWholeBodyFiring(FDAEPHMIEPC KEDHIAANLGO)
	{
	}

	public override void StartWarmUp(FDAEPHMIEPC KEDHIAANLGO)
	{
	}

	public override void StopCharge(FDAEPHMIEPC KEDHIAANLGO)
	{
	}

	public override void StopFire(FDAEPHMIEPC KEDHIAANLGO)
	{
	}

	public override void SwapWeapon(int GCIIEDANPOA, bool MIBDIFEEABJ = false, List<int> EOGKJGMGCAN = null)
	{
	}

	public override void SwapWeapon(HDAEFOANBGJ GAHHIGCMCHD, bool MIBDIFEEABJ = false)
	{
	}

	public override void OnLandFinsish()
	{
	}

	public virtual void SyncStartGrenade()
	{
	}

	public virtual void SyncStopGrenade()
	{
	}

	private bool FJFPLHIEGOJ(FDAEPHMIEPC KEDHIAANLGO)
	{
		return false;
	}

	public virtual void SyncTriggerGrenade()
	{
	}

	public virtual void SyncStopSighting()
	{
	}

	public override bool GetSightingState()
	{
		return false;
	}

	public override bool RequestExecuteTarget(BHGGAEEHJCO PFJFADHEJLJ)
	{
		return false;
	}

	public void OnRequestExecuteTargetRes(MNJALCHBDLJ AOFCDPKJKJO)
	{
	}

	public void OnBeExecutedRes(MNJALCHBDLJ AOFCDPKJKJO)
	{
	}

	public override bool RequestStopExecute()
	{
		return false;
	}

	public void OnRequestStopExecuteTargetRes(MFCEALDIPEK AOFCDPKJKJO)
	{
	}

	public void SyncBeExecuted(MNJALCHBDLJ APHHNHEDHKD)
	{
	}

	public override bool RequestRescureTarget(BHGGAEEHJCO PFJFADHEJLJ)
	{
		return false;
	}

	public override bool RequestRescueAssistTarget(BHGGAEEHJCO PFJFADHEJLJ)
	{
		return false;
	}

	public void OnRequestResureTargetRes(DFGBGPMMPJA AOFCDPKJKJO)
	{
	}

	public override bool RequestStopResure()
	{
		return false;
	}

	public override bool RequestStopAssistingRescure()
	{
		return false;
	}

	public void OnRequestStopResureTargetRes(JHNDCJKBCGA AOFCDPKJKJO)
	{
	}

	public void SyncBeRescured(DFGBGPMMPJA APHHNHEDHKD)
	{
	}

	public override void Dead(int LPHNICDPDBN, uint ENJBDKJIKJO, BHGGAEEHJCO FNOOENEHBJP, bool IECLLKLGNME = false, bool GGLDMJEFGCG = false, bool FCGHCIOGMGK = false, bool FAJBOHLHDHO = false)
	{
	}

	public void SyncKnockDown(FKEKGMFJALP APHHNHEDHKD)
	{
	}

	private void AMBKPGIMJOO(BHGGAEEHJCO GEKCACGOBLK, BHGGAEEHJCO LIABBMKLCPE, bool IECLLKLGNME)
	{
	}

	public void SyncRevive(CFIGAMOOFLH LJLOKNOKHOH)
	{
	}

	public void SyncRevive3P(uint HDMGPPFLPBA = 0u)
	{
	}

	public override bool InKnockRevivedSafeTime()
	{
		return false;
	}

	public void SyncBeginFootball(KMGIFFBOEFN APHHNHEDHKD)
	{
	}

	public void SyncReviveFromFootball()
	{
	}

	public virtual void SyncLocalPlayerSimpleChangeFootballState(bool CKHJAIFHCKN)
	{
	}

	public virtual void RequestFoceSyncPosition()
	{
	}

	public override bool RequestPlayCustomAnimation()
	{
		return false;
	}

	public override bool RequestUseBattleFlag()
	{
		return false;
	}

	public override bool RequestPlayEmotionAnimation(uint AMHLKPHLPNH = 1u, float PILDEDAAMON = 0f, Action<bool> CEHELPAIELA = null, bool PEGODMGMOCL = false, bool PMJBPOLFEEF = false, bool CEGFHCJIGOG = false)
	{
		return false;
	}

	public void SendEmoteRequest(uint AMHLKPHLPNH, bool PEGODMGMOCL, bool CEGFHCJIGOG)
	{
	}

	public void SyncDeadPosition(Vector3 HDFILHFDBKB)
	{
	}

	public void SyncInventoryInfo(LKIPCGKEMOH AOFCDPKJKJO)
	{
	}

	public void SyncAttachmentInfo(List<FLJKANILEDD> LNDBIIGBHEK)
	{
	}

	public void SyncSecondWeaponDataStatus(IHPDFMDPOAC AOFCDPKJKJO)
	{
	}

	public void SyncWeaponAmmoInClip(ICJIHBEPBDG AOFCDPKJKJO)
	{
	}

	public override void ReviveInitMotionState(Vector3 HDFILHFDBKB, Quaternion IPKKCHLDJMA, Quaternion HEEEBLJBDNI, uint LLGKAPEFODF)
	{
	}

	private void HCOLMIEJLPB()
	{
	}

	public virtual void SyncTeleportInfo(PGABPEBFLOK APHHNHEDHKD)
	{
	}

	private bool GCNANJHMOEC()
	{
		return false;
	}

	private void EIBGOJJGFKJ(float ENOMLCNFGMC, Vector3 OCLFLNINDAP, Vector3 BMEBLGLGMNK, Vector3 PCLDEICDDKF)
	{
	}

	private bool IGEMJKHMNAC()
	{
		return false;
	}

	private float JJAFEFDJDDG(ushort CBMEJNFIINK)
	{
		return 0f;
	}

	protected void HDCKMPKJPFB(ushort LODLJINCKLF, ushort PHCLPAOEAOP)
	{
	}

	protected void BBIOEACDIAO(ushort LODLJINCKLF, ushort PHCLPAOEAOP)
	{
	}

	protected void ADFEFNJGNPD(ushort LODLJINCKLF, ushort PHCLPAOEAOP)
	{
	}

	protected void LOBHBBEEFBL(ushort LODLJINCKLF, ushort PHCLPAOEAOP)
	{
	}

	protected void ANBNCAFDMOM(ushort LODLJINCKLF, ushort PHCLPAOEAOP)
	{
	}

	protected void KBJMGNOKJLG(ushort LODLJINCKLF, ushort PHCLPAOEAOP)
	{
	}

	protected void FDKLGICLFBH(ushort LODLJINCKLF, ushort PHCLPAOEAOP)
	{
	}

	protected void LMEIHLJGJCD(ushort LODLJINCKLF, ushort PHCLPAOEAOP)
	{
	}

	protected void JGCJBBEDOCG(ushort LODLJINCKLF, ushort PHCLPAOEAOP)
	{
	}

	protected void BAJDJBLGFON(ushort LODLJINCKLF, ushort PHCLPAOEAOP)
	{
	}

	protected void DPIJFPONGBK(ushort LODLJINCKLF, ushort PHCLPAOEAOP)
	{
	}

	public virtual void ShowAttMsg(string APHHNHEDHKD)
	{
	}

	public void OnSyncPlayerCollectionSkin(uint CJCOBKDPFEB)
	{
	}

	public override void OnSwitchWeaponSkin(uint ABINGMDHKJD, uint CJCOBKDPFEB)
	{
	}

	public void ResetWeaponSkinToOriginal(uint HPPACPHIPCP)
	{
	}

	public bool OnDebugSetSkinID(uint FMDBNCGNKME, uint CJCOBKDPFEB)
	{
		return false;
	}

	public void SocialLobbyRefreshSkyboard()
	{
	}

	public void SocialLobbyUpdateNickName(string ECOFJLIHODK)
	{
	}

	public void SetSocialHallChosenTitleType(ESocialHall.TitleType NPJEJJJJHGH)
	{
	}

	public void SocialLobbyRefreshBackPackIfVisible()
	{
	}

	public void SocialLobbyRefreshFistWeaponIfDirty()
	{
	}

	protected override void OnUserDefineReplicationInfo()
	{
	}

	private static void PKPFOCGCIJC()
	{
	}

	public void OnLoadoutChanged(uint BLLCOCFMNEO)
	{
	}

	public void OnSyncPresetInfo(HLKHBLBHJCL APHHNHEDHKD)
	{
	}

	public EADOMEKFHBE GetCurPresetSchema()
	{
		return null;
	}

	public void OnPetSkillsChanged(List<message.ECAIGDLJKJO> CCFHAPMGEOE)
	{
	}

	public void OnPresetChanged(LBNHLNMIHFJ APHHNHEDHKD)
	{
	}

	public void OnSkillsChanged(List<PJOMHKEJBAK> GILFPGABMPL, NOEPOMJAAIE OINKNIGKDMO)
	{
	}

	private void JMMDELNONAC(uint LPHNICDPDBN, uint ENJBDKJIKJO)
	{
	}

	internal void HMDEOBGEMBB()
	{
	}

	private void DFMIINFHFON()
	{
	}

	public void UpdateWeaponSkinsMapping(List<uint> IFPMKHEHOHL)
	{
	}

	private void OFOEKLNDENE(uint ALADKOOMGMI)
	{
	}

	private void ONJHOJEAJBP(uint LPHNICDPDBN, uint ENJBDKJIKJO)
	{
	}

	public override void LocalStopSquareDancing()
	{
	}

	public uint GetWeaponOriginalSkinID(uint LPHNICDPDBN)
	{
		return 0u;
	}

	public uint GetWeaponPropertySkinID(uint LPHNICDPDBN)
	{
		return 0u;
	}

	public override uint GetWeaponRelatedFinalShotID()
	{
		return 0u;
	}

	public override uint GetWeaponRelatedPropertySkinID(uint LPHNICDPDBN)
	{
		return 0u;
	}

	public override void DoEnterGameCache3P()
	{
	}

	public uint GetWeaponBuffSkinID(uint LPHNICDPDBN)
	{
		return 0u;
	}

	public override void OnResetServerTime()
	{
	}

	public override bool RequestPlayBooyahSuperEmote(uint EHCHPPDBJLK)
	{
		return false;
	}

	public override bool RequestPlaySuperEmote(uint EHCHPPDBJLK)
	{
		return false;
	}

	public override bool RequestPlaySuperEmoteInteractiveAnimation(uint EHCHPPDBJLK, Player HOGELIPBAJI)
	{
		return false;
	}

	public override void DoCacheAfterPlayerJoin()
	{
	}

	private bool IDIAKPDNDKN()
	{
		return false;
	}

	private bool IOAEGNINANF()
	{
		return false;
	}

	private bool AKCDNPKDMHG()
	{
		return false;
	}

	internal bool LDOBLNGGLPA(bool POGFBIPEGPM)
	{
		return false;
	}

	internal void CNBKJPDKCGN(float HOGHEFNINAE)
	{
	}

	private void PMJHOFGODFN()
	{
	}

	private void PLLNIGIEDKC(Transform INCBAMDEBAO)
	{
	}

	private void LOEEGNLMMNO(Vector3 IGDHIDGLOKG, Quaternion FOALBMBCJLF)
	{
	}

	private void NAMGBDEDFOH()
	{
	}

	private void ACHBKLHEOOD()
	{
	}

	private void LBMJKLBMICE(Transform INCBAMDEBAO)
	{
	}

	private void KDBGHHHDEDD(Transform INCBAMDEBAO, float HOGHEFNINAE)
	{
	}

	private Vector3 BFGFDEHHFEC()
	{
		return default(Vector3);
	}

	private Quaternion EEAPKLOJCKC()
	{
		return default(Quaternion);
	}

	internal bool CIGOHIKFELJ()
	{
		return false;
	}

	internal void BAALLLOOLHF()
	{
	}

	private void FBDHGGKBGJP(Transform INCBAMDEBAO, Vector3 HDFILHFDBKB, Quaternion IPKKCHLDJMA, float HOGHEFNINAE)
	{
	}

	public override bool IsApplyingServerAuthorizedPhysXStateSwitch()
	{
		return false;
	}

	public override bool ShouldUseServerAuthorizedPhysXStateSwitch(IGJPHDANPJD LJIIDCPCAEG, IGJPHDANPJD EPHJNAOJPOI, JOLPCBKIKEJ OINKNIGKDMO)
	{
		return false;
	}

	public override void RequestOrSwitchPhysXState(IGJPHDANPJD GCJPAAPKMMA, EOGPGNIDOKF KLDJLKMKKOJ, JOLPCBKIKEJ OINKNIGKDMO)
	{
	}

	public void SyncServerAuthorizedSwitchPhysXState(BHPADHHHPNN APHHNHEDHKD)
	{
	}

	private void ACIANKCIHAI(uint ODBHABBADHF)
	{
	}

	private void FNHCENNFCKG(IGJPHDANPJD FKBFGALFHKP, EOGPGNIDOKF PDEFEPLFLPA, JOLPCBKIKEJ OINKNIGKDMO)
	{
	}

	private bool NLKCFBLGABH(JOLPCBKIKEJ OINKNIGKDMO)
	{
		return false;
	}

	private void NGAFNECKBAH(IGJPHDANPJD GCJPAAPKMMA, EOGPGNIDOKF KCMJONOCMPN, BHPADHHHPNN APHHNHEDHKD)
	{
	}

	private Vector3 ONGDJLLPGKF(Vector3 MKEMOMFLBCF, JOLPCBKIKEJ OINKNIGKDMO)
	{
		return default(Vector3);
	}

	private Vector3 EENHFPCPDEL(Vector3 KMFMICABCFL, Vector3 NFKJEIAKGGD, JOLPCBKIKEJ OINKNIGKDMO)
	{
		return default(Vector3);
	}

	private bool DAGFFDILGEA(JOLPCBKIKEJ OINKNIGKDMO)
	{
		return false;
	}

	protected override void GGGIFHDHFMN(IGJPHDANPJD GCJPAAPKMMA, EOGPGNIDOKF KLDJLKMKKOJ)
	{
	}

	protected override void AHDOPMLAKFD(IGJPHDANPJD GCJPAAPKMMA, EOGPGNIDOKF KLDJLKMKKOJ)
	{
	}

	private void HBNGMBJIDCP(IGJPHDANPJD GCJPAAPKMMA, EOGPGNIDOKF KLDJLKMKKOJ)
	{
	}

	private void OGCHKFDBICJ()
	{
	}

	public override bool ShouldIgnoreSyncedPhysXState(IGJPHDANPJD CHDPPLFBCJA, EOGPGNIDOKF DCAINEHMMOA, uint OOEJHOGKNIG)
	{
		return false;
	}

	private void JHDODPAKIHH(uint ODBHABBADHF)
	{
	}

	private void OALDBDMNKNK(uint ODBHABBADHF)
	{
	}

	private void DANLOINAPHK()
	{
	}

	private void KCICHFJGJAC()
	{
	}

	protected override void NEFNEKEKGPC()
	{
	}

	private void LIPDJLGLMFJ()
	{
	}

	private void NEAGNFIDKAO()
	{
	}

	private void KCFLOEMGJII()
	{
	}

	private void BLEPEJLBLAJ()
	{
	}

	private void JCDNLOMNJOM()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	public void _003C_003EiFixBaseProxy_SendChangeToGBFootBall()
	{
	}

	public void _003C_003EiFixBaseProxy_SendCancelGBFootBall()
	{
	}

	public bool _003C_003EiFixBaseProxy_BPCIANKBNJF()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_ECDHPHFJHIC()
	{
		return false;
	}

	public BaseProfileInfo _003C_003EiFixBaseProxy_get_Profile()
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_HaveFlight()
	{
		return false;
	}

	public BaseProfileInfo _003C_003EiFixBaseProxy_PlayerBaseProfile()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_InitProperties(object P0, bool P1)
	{
	}

	public void _003C_003EiFixBaseProxy_BPPIJBDGHMG()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUpdate(float P0, float P1)
	{
	}

	public void _003C_003EiFixBaseProxy_RequestStopEmote4Plant()
	{
	}

	public void _003C_003EiFixBaseProxy_RequestPlayEmote4Plant(OPICPDCLKAG P0, uint P1)
	{
	}

	public void _003C_003EiFixBaseProxy_RequestStoreInWareHouse(uint P0)
	{
	}

	public void _003C_003EiFixBaseProxy_RequestStopStoringInWarehouse()
	{
	}

	public void _003C_003EiFixBaseProxy_RequestOpenTreasury()
	{
	}

	public void _003C_003EiFixBaseProxy_RequestOpenTimingTreasureBox()
	{
	}

	public void _003C_003EiFixBaseProxy_RequestHayrickJump()
	{
	}

	public void _003C_003EiFixBaseProxy_RequestPray4EscortBoss(uint P0)
	{
	}

	public void _003C_003EiFixBaseProxy_RequestStopPraying4EscortBoss()
	{
	}

	public void _003C_003EiFixBaseProxy_DoUpdateActionState(EAcationState P0, EPreparationTimerType P1, float P2, object[] P3)
	{
	}

	public void _003C_003EiFixBaseProxy_OnWeaponReloadImmediateStarted(float P0, bool P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnWeaponReloadImmediateFinished(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnWeaponReloadStarted(float P0, bool P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnWeaponReloadFinished(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnWeaponLift(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_UpdateAI(float P0, float P1)
	{
	}

	public void _003C_003EiFixBaseProxy_HLGHCAFHBGD()
	{
	}

	public void _003C_003EiFixBaseProxy_UpdateBehavior(float P0, float P1)
	{
	}

	public void _003C_003EiFixBaseProxy_FPIBBHGKPOM()
	{
	}

	public void _003C_003EiFixBaseProxy_UpdateKinematics(float P0, float P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnRecycleClearData()
	{
	}

	public void _003C_003EiFixBaseProxy_OnGetOffSeesaw(LevelSeesaw P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnGetOffChair(LevelChair P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnGetOffVehicle()
	{
	}

	public void _003C_003EiFixBaseProxy_OnGetOnVehicle(Vehicle P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnGetOnFerrisWheel(LevelFerrisWheel P0, byte P1, byte P2)
	{
	}

	public void _003C_003EiFixBaseProxy_OnGetOffFerrisWheel(byte P0, byte P1)
	{
	}

	public void _003C_003EiFixBaseProxy_ClientSetOnBoard()
	{
	}

	public int _003C_003EiFixBaseProxy_TakeDamage(int P0, BHGGAEEHJCO P1, GLLLEDKLLDA P2, int P3, Vector3 P4, Vector3 P5, List<float> P6, LOAEBBHPMEK P7, uint P8)
	{
		return 0;
	}

	public new void _003C_003EiFixBaseProxy_TakeHealing(DLOFHLEHHNP P0, List<float> P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnWeaponReloadSpeedChanged(float P0)
	{
	}

	public void _003C_003EiFixBaseProxy_StartFiring(FDAEPHMIEPC P0)
	{
	}

	public void _003C_003EiFixBaseProxy_StartWholeBodyFiring(FDAEPHMIEPC P0)
	{
	}

	public void _003C_003EiFixBaseProxy_StartWarmUp(FDAEPHMIEPC P0)
	{
	}

	public void _003C_003EiFixBaseProxy_StopCharge(FDAEPHMIEPC P0)
	{
	}

	public void _003C_003EiFixBaseProxy_StopFire(FDAEPHMIEPC P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SwapWeapon(int P0, bool P1, List<int> P2)
	{
	}

	public void _003C_003EiFixBaseProxy_SwapWeapon(HDAEFOANBGJ P0, bool P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnLandFinsish()
	{
	}

	public bool _003C_003EiFixBaseProxy_GetSightingState()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_RequestExecuteTarget(BHGGAEEHJCO P0)
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_RequestStopExecute()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_RequestRescureTarget(BHGGAEEHJCO P0)
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_RequestRescueAssistTarget(BHGGAEEHJCO P0)
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_RequestStopResure()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_RequestStopAssistingRescure()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_Dead(int P0, uint P1, BHGGAEEHJCO P2, bool P3, bool P4, bool P5, bool P6)
	{
	}

	public bool _003C_003EiFixBaseProxy_InKnockRevivedSafeTime()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_RequestPlayCustomAnimation()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_RequestUseBattleFlag()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_RequestPlayEmotionAnimation(uint P0, float P1, Action<bool> P2, bool P3, bool P4, bool P5)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_ReviveInitMotionState(Vector3 P0, Quaternion P1, Quaternion P2, uint P3)
	{
	}

	public void _003C_003EiFixBaseProxy_OnSwitchWeaponSkin(uint P0, uint P1)
	{
	}

	public void _003C_003EiFixBaseProxy_LocalStopSquareDancing()
	{
	}

	public uint _003C_003EiFixBaseProxy_GetWeaponRelatedFinalShotID()
	{
		return 0u;
	}

	public uint _003C_003EiFixBaseProxy_GetWeaponRelatedPropertySkinID(uint P0)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_DoEnterGameCache3P()
	{
	}

	public void _003C_003EiFixBaseProxy_OnResetServerTime()
	{
	}

	public bool _003C_003EiFixBaseProxy_RequestPlayBooyahSuperEmote(uint P0)
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_RequestPlaySuperEmote(uint P0)
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_RequestPlaySuperEmoteInteractiveAnimation(uint P0, Player P1)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_DoCacheAfterPlayerJoin()
	{
	}

	public bool _003C_003EiFixBaseProxy_get_IsServerAuthorizedPhysXStateSwitchPending()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_IsApplyingServerAuthorizedPhysXStateSwitch()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_ShouldUseServerAuthorizedPhysXStateSwitch(IGJPHDANPJD P0, IGJPHDANPJD P1, JOLPCBKIKEJ P2)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_RequestOrSwitchPhysXState(IGJPHDANPJD P0, EOGPGNIDOKF P1, JOLPCBKIKEJ P2)
	{
	}

	public void _003C_003EiFixBaseProxy_GGGIFHDHFMN(IGJPHDANPJD P0, EOGPGNIDOKF P1)
	{
	}

	public void _003C_003EiFixBaseProxy_AHDOPMLAKFD(IGJPHDANPJD P0, EOGPGNIDOKF P1)
	{
	}

	public bool _003C_003EiFixBaseProxy_ShouldIgnoreSyncedPhysXState(IGJPHDANPJD P0, EOGPGNIDOKF P1, uint P2)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_NEFNEKEKGPC()
	{
	}
}
