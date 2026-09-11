using GCommon;
using proto;

namespace COW;

public class UIVeteranReturnBarrageController : UIBarrageItemBaseController
{
	private UIVeteranReturnBarrageView m_View;

	private BarrageData m_barrageData;

	private UILeaderBoardTitleSingleController m_LeaderBoardTitleSingleCtrl;

	private UIModelVeteran m_ModelVeteran;

	private UIModelLadderMatch m_ModelLadderMatch;

	private UIModelCSLadderMatch m_ModelCSLadderMatch;

	private UIBRRankIconController m_BRRankIconController;

	private UICSRankIconController m_CSRankIconController;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override bool SetBarrageData(BarrageData data)
	{
		return false;
	}

	private void SetFriendOnlineStyle(VetBarrageInfo vetBarrageInfo)
	{
	}

	private void SetRankAndStreakStyle(VetBarrageInfo vetBarrageInfo, EAttendance.VeteranBarrageType type)
	{
	}

	private void SetWeaponPowerAndGMRankStyle(VetBarrageInfo vetBarrageInfo, EAttendance.VeteranBarrageType type)
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
