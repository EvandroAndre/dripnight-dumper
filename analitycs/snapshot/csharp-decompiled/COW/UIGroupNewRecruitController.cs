using System.Collections.Generic;
using System.Text;
using GCommon;

namespace COW;

public class UIGroupNewRecruitController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private UIGroupNewRecruitView m_View;

	private UIModelChat m_ChatModel;

	private UIModelGroup m_GroupModel;

	private UIModelRecruit m_ModelRecruit;

	private UIModelMapOpeningInfo m_ModelMap;

	private UIModelLadderMatch m_ModelLadderMatch;

	private UIModelCSLadderMatch m_ModelCSLadderMatch;

	private UIModelCSPeakTournamentLadderMatch m_ModelCSPeakTournamentLadderMatch;

	private StringBuilder m_Builder;

	private bool m_LastInCDState;

	private uint m_WorldDelayCallID;

	private readonly float GREY_ALPHA;

	private bool m_HasWorldToggleInit;

	private bool m_NeedHighlightSaveBtn;

	private bool m_FirstRecruit;

	private uint m_ModeID;

	private uint m_MatchID;

	private uint m_MapID;

	private uint m_GroupID;

	private int m_LadderLimitID;

	private int m_LadderLimitMaxID;

	private uint m_Tag1;

	private uint m_Tag2;

	private List<uint> m_TeamTags;

	private uint m_SpecialModeEventId;

	private bool m_OpenMapBonus;

	private bool m_CanChangeMapBonus;

	private string m_RankMinName;

	private string m_RankMaxName;

	private string m_RankMinSpriteName;

	private string m_RankMaxSpriteName;

	private EGameModeCategory m_GameModeCategory;

	private UIModelRecruit.ERecruitSource m_RecruitSource;

	private List<int> m_BRRankListForGroupRecruit;

	private List<int> m_BRMaxRankListForGroupRecruit;

	private List<int> m_CSRankListForGroupRecruit;

	private List<int> m_CSMaxRankListForGroupRecruit;

	private List<int> m_PeakScoreListForGroupRecruit;

	private List<int> m_PeakMaxScoreListForGroupRecruit;

	private List<UIGroupRecruitTagItemController> m_TagItems;

	private UIRecruitPopMenuController m_RankMinMenuCtrl;

	private UIRecruitPopMenuController m_RankMaxMenuCtrl;

	private List<MultiPopMenuData> m_ModeMenuData;

	private List<MultiPopMenuData> m_GroupMenuData;

	private List<PopMenuData> m_RankMinMenuData;

	private List<PopMenuData> m_CSRankMinMenuData;

	private List<PopMenuData> m_RankMaxMenuData;

	private List<PopMenuData> m_CSRankMaxMenuData;

	private List<PopMenuData> m_PeakScoreMinMenuData;

	private List<PopMenuData> m_PeakScoreMaxMenuData;

	private const string HARD_ISOLATION_DISABLED_TIP = "";

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetRecruitSource(UIModelRecruit.ERecruitSource source)
	{
	}

	private void SetMapBonusView()
	{
	}

	private void SetCSPeakTournamentView()
	{
	}

	private void SetCSSpecialView()
	{
	}

	private void SetExtraView()
	{
	}

	private void SetTeamTagView()
	{
	}

	private void SetSendToView(bool isInit)
	{
	}

	private void InitDefaultSelection()
	{
	}

	public void ProcessDefaultLimitIDByMatchMode(uint matchMode, bool setByRecruitInfoValue)
	{
	}

	private void TryResolveDefaultLimitIDWithoutHardIsolation(uint matchMode)
	{
	}

	private bool IsRecruitRankRangeEmpty()
	{
		return false;
	}

	private bool IsRecruitRankMode(uint matchMode)
	{
		return false;
	}

	private bool IsTeamRankLimitedForRecruitMode(uint matchMode)
	{
		return false;
	}

	private bool WouldRecruitRangeTriggerHardIsolation(uint matchMode, int minRank, int maxRank)
	{
		return false;
	}

	private void DefaultWorldState()
	{
	}

	private void SetGroupAndBtnView()
	{
	}

	private void UpdateSendChannelView()
	{
	}

	private void OnRecruitBtnClick()
	{
	}

	private void OnStopRecruitBtnClick()
	{
	}

	private void OnMapBonusToggleChange()
	{
	}

	private void OnCSSpecialToggleChange()
	{
	}

	private void OnChannelWorldToggleChange()
	{
	}

	private void OnChannelWorldToggleChangeWithTips(bool needTips = true)
	{
	}

	private void OnChannelClanToggleChange()
	{
	}

	private void RefreshBannedTrioTips()
	{
	}

	private void OnModeBtnClick()
	{
	}

	private List<MultiPopMenuData> GetOrConstructModeMenu(ref string defaultID)
	{
		return null;
	}

	private void OnGroupBtnClick()
	{
	}

	private void OnRankTipsBtnClick()
	{
	}

	private bool SetSelectModeID(uint modeid, uint matchid)
	{
		return false;
	}

	private void SetLadderLimitView()
	{
	}

	private void ConstructLadderPopData()
	{
	}

	private void InitRankPopUpData()
	{
	}

	private void UpdateLadderPopData()
	{
	}

	private void SelectRankMinCallBack(object obj)
	{
	}

	private void SelectRankMaxCallBack(object obj)
	{
	}

	private bool SetSelectMapID(uint mapid, uint modeId)
	{
		return false;
	}

	private void ConstructGroupMenuList()
	{
	}

	private void OnTeamTagSelected(object[] data)
	{
	}

	private void OnSendRecruitSuccess()
	{
	}

	void IUIModelDataChangeObserver.OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	uint IUIModelDataChangeObserver.GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void _003COnModeBtnClick_003Eb__78_0(List<string> ids)
	{
	}

	private void _003COnGroupBtnClick_003Eb__80_0(List<string> ids)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
