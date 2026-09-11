using GCommon;
using UnityEngine;
using message;

namespace COW.GamePlay;

public class LevelSeesaw : BaseLevelObject
{
	public AnimRef SittingAnimation0;

	public AnimRef SittingAnimation1;

	public AnimRef SittingAnimationFemale0;

	public AnimRef SittingAnimationFemale1;

	public Transform Seat0;

	public Transform Seat1;

	public Transform JumpOffSeat0;

	public Transform JumpOffSeat1;

	public GameObject VirtualPlayerOnSeat;

	public Animator VirtualMaleAnimator0;

	public Animator VirtualMaleAnimator1;

	public Animator VirtualFemaleAnimator0;

	public Animator VirtualFemaleAnimator1;

	public Animator SeesawAnimator;

	protected BHGGAEEHJCO LOPEIGLCJCN;

	protected BHGGAEEHJCO NKMOGGLIIAO;

	private GameObject MFALCBOHJFD;

	protected uint GAPNBGFALMP;

	protected bool KGBAOELJMEO;

	protected BHGGAEEHJCO HFKFFEONCJG;

	protected BHGGAEEHJCO FMBAIOCCCKG;

	protected override string GetObjectTag()
	{
		return null;
	}

	protected override void OnAwake()
	{
	}

	protected override void OnStart()
	{
	}

	protected override void OnOnDestroy()
	{
	}

	private void MKHMKNBDHOC(uint OBMFMAKFDDL)
	{
	}

	private void PKAELFOOMEF(bool NODKMKAAJMJ)
	{
	}

	private void MKFPGHOGFAL(GEvent JCONDDPFBKK)
	{
	}

	private void BDALGJCLBIG(Player KDJNEHDAAFL)
	{
	}

	public bool HasFreeSeat()
	{
		return false;
	}

	private int HHDOBOJOKAB()
	{
		return 0;
	}

	internal bool LLPCJOIPIDB(Player PGEGMKJKOKI)
	{
		return false;
	}

	internal bool JDCBJBFPMJE(Player DCAPIHJMMBL)
	{
		return false;
	}

	internal bool LABDHCNIDMG(Player DCAPIHJMMBL)
	{
		return false;
	}

	public bool IsServerPhaseDual()
	{
		return false;
	}

	public bool IsServerPhaseSingle()
	{
		return false;
	}

	public static string GetLocKeyForSeesawError(byte EMANEBGLLJG)
	{
		return null;
	}

	public void ApplyServerState(HOHDGCCPKAH APHHNHEDHKD)
	{
	}

	private void OHMPLOHDKIP(BHGGAEEHJCO IJMFNOLJLDM, BHGGAEEHJCO EGKIPNEKCAD)
	{
	}

	private void MDPGLOKJIKO()
	{
	}

	private int EBFHACPGECI(BHGGAEEHJCO OBMFMAKFDDL)
	{
		return 0;
	}

	public BHGGAEEHJCO GetSeatPlayerIDOnSeat()
	{
		return default(BHGGAEEHJCO);
	}

	public BHGGAEEHJCO GetOtherSeatPlayerID(BHGGAEEHJCO DCAPIHJMMBL)
	{
		return default(BHGGAEEHJCO);
	}

	public BHGGAEEHJCO GetNearestSeatPlayerID(Vector3 IGDHIDGLOKG)
	{
		return default(BHGGAEEHJCO);
	}

	public int GetTargetSeatIndexForPlayer(Vector3 IGDHIDGLOKG)
	{
		return 0;
	}

	private int LLPFBIOGNEL(Player PGEGMKJKOKI)
	{
		return 0;
	}

	public override void DoAction(object[] DJAPBCKDFKA)
	{
	}

	public override void OnFixedUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	internal bool HFPBJGEFEAJ(Player PGEGMKJKOKI)
	{
		return false;
	}

	private void OCHJIGNBHJO(Player PGEGMKJKOKI, int OIMPDJMNOFC)
	{
	}

	private void EEHBECGFPGE(Player PGEGMKJKOKI)
	{
	}

	public Vector3 GetSeatOnPositionForSeatIndex(int OIMPDJMNOFC)
	{
		return default(Vector3);
	}

	public Vector3 GetOffPositionForSeat(int OIMPDJMNOFC)
	{
		return default(Vector3);
	}

	private Vector3 MOIOBNGDDGJ(int OIMPDJMNOFC)
	{
		return default(Vector3);
	}

	private void HAKKLODFGON(Player PGEGMKJKOKI, bool CELKGHPNIKO = false)
	{
	}

	private void GNGEGEOHHBF(Player DCAPIHJMMBL, bool CELKGHPNIKO)
	{
	}

	private void NLANLFIIMDN()
	{
	}

	private void LGNDGMMOJLN(int DPMPFEEALNI)
	{
	}

	private void AGNFBOGPLKC()
	{
	}

	private void FLPDCICKABL(int DPMPFEEALNI)
	{
	}

	private void ADPLBJOLBLB(Transform MAIFPPFLCEB)
	{
	}

	private void EMECGEFOELP()
	{
	}

	public override bool CreateDynamicallyForUGC(string GDDEBLAFLLG)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_DoAction(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}

	public bool _003C_003EiFixBaseProxy_CreateDynamicallyForUGC(string P0)
	{
		return false;
	}
}
