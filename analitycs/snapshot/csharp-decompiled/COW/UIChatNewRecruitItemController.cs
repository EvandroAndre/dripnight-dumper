using System.Collections.Generic;
using GCommon;
using tcp;

namespace COW;

public class UIChatNewRecruitItemController : UIEasyListItemController
{
	private UIChatNewRecruitItemView m_View;

	private GroupRecruitTeamInfo m_teamInfoData;

	private const string BRRANK_BG = "FF_UI_chatbg_01";

	private const string CSRANK_BG = "FF_UI_chatbg_02";

	private const string CSPEAK_BG = "FF_UI_chatbg_CSPeakTournament_01";

	private const string NORMAL_BG = "FF_UI_chatbg_03";

	private const string HCRANK_BG = "FF_UI_chatbg_HC";

	private List<UIGroupRecruitHeadItemController> m_RecruitHeadItemList;

	private List<UIGroupRecruitTagItemController> m_TagItems;

	private UIModelGroup m_ModelGroup;

	private UIModelRecruit m_ModelRecruit;

	private UIBRRankIconController m_MaxBRRankIconController;

	private UIBRRankIconController m_MinBRRankIconController;

	private UICSPeakTournamentRankIconController m_MaxCSPeakRankIconController;

	private UICSPeakTournamentRankIconController m_MinCSPeakRankIconController;

	private bool m_IsGroupRecruit;

	private bool m_CanClick;

	private RecruitRoomInfo m_RoomInfo;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void SetTagItemView(uint[] tagIds)
	{
	}

	private void SetHeadItemView(uint maxGroupNum, List<GroupRecruitTeamMemberInfo> members, EGameModeCategory gameModeCategory, ulong groupId, uint matchMode, string recruitCode, bool hasMapBonus)
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void SetGroupRecruitView(GroupRecruitTeamInfo groupRecruitTeamInfo)
	{
	}

	private bool ShowSocialBuff(List<GroupRecruitTeamMemberInfo> members)
	{
		return false;
	}

	private void SetRankIconView()
	{
	}

	public GroupRecruitTeamInfo GetTeamInfo()
	{
		return null;
	}

	public RecruitRoomInfo GetRoomInfo()
	{
		return null;
	}

	public bool IsGroupRecruit()
	{
		return false;
	}

	private void SetRoomRecruitView(RecruitRoomInfo recruitRoomInfo)
	{
	}

	private void OnRoomJoinBtnClick()
	{
	}

	private void OnRoomJoinSecondConfirmSuccess()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
