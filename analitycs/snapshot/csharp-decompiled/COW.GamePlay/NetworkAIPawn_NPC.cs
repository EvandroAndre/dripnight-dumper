using GCommon;
using UMA;
using UnityEngine;
using message;

namespace COW.GamePlay;

internal class NetworkAIPawn_NPC : NetworkAIPawn
{
	public delegate void APKJOPPAGAN(NetworkAIPawn_NPC KDJNEHDAAFL);

	public delegate void DLHALNEFAFL(uint FPGIOPMJFBP);

	private const float EOIEILELLAF = 3f;

	public APKJOPPAGAN OnNPCTriggerEnter;

	public DLHALNEFAFL onNPCTalkingFinished;

	public TextMesh m_NPCName;

	public NPCPlayerGroupChatTrigger groupChatTrigger;

	public Transform m_AvatarRoot;

	public float m_SpecialAnimInterval;

	public LevelPhotograph m_lvlPhotograph;

	public uint NPCID;

	public uint NPCDataID;

	public bool m_IsTalking;

	private uint IGPKHHNPBPK;

	private float EIBEGCDODEJ;

	private AvatarManager KPMDIPJINJO;

	private Animator EPJICDJEIKN;

	private float CPGNDLHIHNH;

	private PartyNPCConfigData LCNBLGGOBPM;

	private UIHudPartyNPCChatBubbleController CFAFEHEMIGA;

	private Quaternion LEAAFOMPPOC;

	private BoxCollider POLHFAOFGNJ;

	private CapsuleCollider MPILPDICDBL;

	public bool IsInteractive()
	{
		return false;
	}

	public override void CreateInit(Transform MLBAMPFOCGP, DNFBGBPINLE GDEKAGHDGKC)
	{
	}

	protected override void FNHECJEMNCB()
	{
	}

	protected override void IEGLNDCGOOE(Transform NAGHAPBBLKF)
	{
	}

	private void CHIEBEOELEK()
	{
	}

	private void JEBOJEJOILL(UMAData JCONDDPFBKK)
	{
	}

	public void OnPlayerEnterTrigger()
	{
	}

	public void StartTalking(uint FPGIOPMJFBP, string KAEPDGADBPN)
	{
	}

	public override void OnUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public override void UpdateBehavior(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public override void UpdateKinematics(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public void PlayNPCAnim(ResourceID AOFCDPKJKJO, bool MFEKPFKOMIK = false, float FOMJCCKNEOL = 0f)
	{
	}

	private void NEKOLJOMJML(string CHHBBHIFPEP, AnimRef KAHPOGNMIJB)
	{
	}

	protected override void OnDead()
	{
	}

	public void HideNPCName(bool KPMNLHPKIMN)
	{
	}

	public void OnStartInteract()
	{
	}

	public void OnEndInteract()
	{
	}

	public void _003C_003EiFixBaseProxy_CreateInit(Transform P0, DNFBGBPINLE P1)
	{
	}

	public void _003C_003EiFixBaseProxy_FNHECJEMNCB()
	{
	}

	public void _003C_003EiFixBaseProxy_IEGLNDCGOOE(Transform P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUpdate(float P0, float P1)
	{
	}

	public void _003C_003EiFixBaseProxy_UpdateBehavior(float P0, float P1)
	{
	}

	public void _003C_003EiFixBaseProxy_UpdateKinematics(float P0, float P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnDead()
	{
	}
}
