using GCommon;
using proto;

namespace COW;

internal class UINewPlayerV3MissionItemController : UIEasyListItemController, IUIModelDataChangeObserver
{
	private NewPlayerMissionData m_MissionData;

	private NewPlayerSevenDaysData m_NormalMissionDesc;

	private UINewPlayerV3MissionItemView m_View;

	private EActivity.State m_MissionStatus;

	private UIModelNewPlayerV3 m_ModelNewPlayer;

	private UIModelNewPlayerUpGrades m_ModelNewPlayerUpGrades;

	private ENewbieGuideType m_GotoGuideId;

	private UIStandardItemMiniController m_Reward;

	private UIStandardItemMiniController m_RewardLimit;

	private int m_DefaultMissonDescWidth;

	private bool m_IsLocked;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void RefreshMissionView()
	{
	}

	private void RefreshBigRewardView()
	{
	}

	private void RefreshNormalMissionView()
	{
	}

	private void RefreshNormalMissionText(NewPlayerSevenDaysData missionDesc)
	{
	}

	private void ProcessMissionState(ActivityInfo missionInfo)
	{
	}

	private void RefreshDailyBigRewardProgressTips()
	{
	}

	private void RefreshNormalMissionProgressTips(ActivityInfo missionInfo, NewPlayerSevenDaysData missionDesc)
	{
	}

	private void RefreshButtonView()
	{
	}

	private void RefreshBigRewardButtonView()
	{
	}

	private void RefreshAward(AwardDesc award, bool isLimit, bool isBigMission)
	{
	}

	private void RefreshLogo(bool isBigMission, bool bShowLogo)
	{
	}

	private void NormalMissionButtonClick()
	{
	}

	private void DailyBigRewardButtonClick()
	{
	}

	private void CheckGoToTrainIsland()
	{
	}

	private void CheckGoToRankGame(ENewbieGuideType ranktype)
	{
	}

	private void CheckGoToMatchState(object[] args)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
