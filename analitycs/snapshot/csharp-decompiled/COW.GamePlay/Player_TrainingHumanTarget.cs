using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW.GamePlay;

internal class Player_TrainingHumanTarget : Player, IBridgingEntity
{
	private static ulong MEJLKGDHLFH;

	private static readonly uint EDDOEAEOONA;

	private const uint CNCLPNFNJMC = 17u;

	public static bool CanBeKilled;

	public static bool ShowDamageInfo;

	public static int TrainingHP;

	public static uint MoveType;

	public static uint TargetCountType;

	public static uint TargetDistanceType;

	public static uint TrainingVestLevel;

	public static uint TrainingHelmetLevel;

	public static int[] TargetCountByTypes;

	public static float[] BotStopMoveTime;

	public static float[] BotSlowMoveTime;

	public static float[] BotBornTime;

	private MatchModelKillData GFBHKKMBJLJ;

	private bool HAPDJKEOMBK;

	private new Camera OHEPMNHMJMK;

	private float HOAHJKGLHOH;

	private new AvatarManager KPMDIPJINJO;

	private OMELKCOGCBK NGFJNAFKHHJ;

	private uint PFPJICLMMOG;

	private uint GMLELBDHLIA;

	private Dictionary<uint, uint> HIJKENGOOLG;

	public int BornPointIndex;

	public bool notShowByGrenadeDamage;

	private uint JCOJPFJBALF;

	private bool GJPJOIOHEIA;

	private float GGJOOAIGHDJ;

	private float LDBGGDMCNEH;

	private string KJIDFCKDFIG;

	private uint BCHDOCACANP;

	private Vector3 OLCNHIHACOI;

	private float DNHLBHCHNHN;

	private bool JLIAPKEMHAE;

	private UGCEntityDataStore EHCIGGPOGOH;

	public virtual bool NFAJDGJLJLI => false;

	public virtual bool KIOANNIBFJD => false;

	public uint PANBPDCHBKM => 0u;

	public static ulong GenerateHumanTargetId()
	{
		return 0uL;
	}

	public static void ResetValue()
	{
	}

	public override void OnPlayerBeTouch()
	{
	}

	public void InitHumanTargetPlayer(Transform HGHIIAFNEAE, BHGGAEEHJCO LDGAFOHBHJN)
	{
	}

	protected override void LMNGOJOJFNM()
	{
	}

	public override int TakeDamage(int PMNNBDDKCCE, BHGGAEEHJCO FNOOENEHBJP, GLLLEDKLLDA PMMCGNJHOOA = null, int HPPACPHIPCP = -1, Vector3 BAAJEMEJACH = default(Vector3), Vector3 KHNFEFFKMEB = default(Vector3), List<float> LFLPGCMLPFM = null, LOAEBBHPMEK AOJANNHGCEA = null, uint FKDEIFDNMJD = 0u)
	{
		return 0;
	}

	public bool TryApplyTrainingProtectHelmet(ref int LEFJOGGGJFN, int HPPACPHIPCP, LLEDPGIGCMO CCFHNBDPCOE, GPKIJNDCLPD OMHIJEKNFGF)
	{
		return false;
	}

	protected virtual void LPJOHBOGMCN(LLEDPGIGCMO CCFHNBDPCOE, int HPPACPHIPCP)
	{
	}

	private void PNMNGMJCNEL()
	{
	}

	protected virtual void NNKKMPMEEIK()
	{
	}

	public override Vector3 GetCharacterControllerTopPosition()
	{
		return default(Vector3);
	}

	private void LateUpdate()
	{
	}

	private void DJJCLEKJCGG()
	{
	}

	public override bool NeedAssit()
	{
		return false;
	}

	public override bool CanAssitByWeapon(Player KALJPOOLDAD, FDAEPHMIEPC KEDHIAANLGO)
	{
		return false;
	}

	private void EOCJGOAMBPJ()
	{
	}

	protected override void OnOnDestroy()
	{
	}

	private void IHKMEDCFKKN(object[] JCONDDPFBKK)
	{
	}

	public void ChangeEquipToggle(ETrainingToggleType HIFGHICFKDG)
	{
	}

	public virtual void OnMoveTypeChanged()
	{
	}

	public override void OnFixedUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	protected virtual void NCKBGIOHCOJ(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public void SetTrainingVisible(bool GPFPIAMCEMI)
	{
	}

	private void KPODJAEAOFL(ETrainingToggleType MJIFGJPGLAM, uint JKNLMKFADBG)
	{
	}

	private uint NHKCJCEIFBI(ETrainingToggleType MJIFGJPGLAM, uint JKNLMKFADBG)
	{
		return 0u;
	}

	private void BANICDICNAP()
	{
	}

	public void OnLogicEntityCreated(string GDDEBLAFLLG)
	{
	}

	public new string UGCEntityID()
	{
		return null;
	}

	public int BridgingTypeID()
	{
		return 0;
	}

	public void InitByUGC(Transform MLBAMPFOCGP, BHGGAEEHJCO LDGAFOHBHJN, int OMNHBNENPLL, UGCEntityDataStore HAJLGDFECFA)
	{
	}

	private void LIEHDKBPNLK()
	{
	}

	protected virtual void OLCEOEPILOB(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public bool BridgingPropSetter(long DLOFKFKIMGC, UGCSimpleValue GPFPIAMCEMI)
	{
		return false;
	}

	public IUGCValue BridgingPropGetter(long DLOFKFKIMGC)
	{
		return null;
	}

	private void PBEABFOKKEH()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPlayerBeTouch()
	{
	}

	public void _003C_003EiFixBaseProxy_LMNGOJOJFNM()
	{
	}

	public int _003C_003EiFixBaseProxy_TakeDamage(int P0, BHGGAEEHJCO P1, GLLLEDKLLDA P2, int P3, Vector3 P4, Vector3 P5, List<float> P6, LOAEBBHPMEK P7, uint P8)
	{
		return 0;
	}

	public Vector3 _003C_003EiFixBaseProxy_GetCharacterControllerTopPosition()
	{
		return default(Vector3);
	}

	public bool _003C_003EiFixBaseProxy_NeedAssit()
	{
		return false;
	}

	public new bool _003C_003EiFixBaseProxy_CanAssitByWeapon(Player P0, FDAEPHMIEPC P1)
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}
}
