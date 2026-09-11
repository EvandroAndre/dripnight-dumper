using System.Collections.Generic;
using GCommon;
using proto;
using proto.Login;

namespace COW;

public class UIProfilePlayerPreferenceSettingPopWndController : UIPopupWindowController, IUIModelDataChangeObserver
{
	public enum EToggle
	{
		BasicSetting,
		PregameInfo,
		LeaderBoardTitle,
		TitleShow
	}

	public enum ESubToggle
	{
		TitleShowCurrentWeek,
		TitleShowHighest,
		PregameInfoBR,
		PregameInfoCS,
		PregameInfoCSPeak
	}

	private ulong m_accoutid;

	private UIProfilePlayerPreferenceSettingPopWndView m_View;

	private UIModelProfile m_ModelProfile;

	private ulong m_MyAccountID;

	private bool m_IsLocalPlayer;

	private EToggle m_MainToggle;

	private ESubToggle m_SubToggle;

	private EGLJDBDMENB m_UserData;

	private SocialBasicInfo m_SocailBasicInfo;

	private BadgeInfo m_BadgeInfo;

	private const int TOGGLE_GROUP_ID = 117;

	private LocLang m_SelectedLan;

	private List<PopMenuData> m_LanDataList;

	private List<PopMenuData> m_SexDataList;

	private List<PopMenuData> m_DefaultShowDataList;

	private List<PopMenuData> m_OnLineTimeDataList;

	private List<PopMenuData> m_ActiveTimeDataList;

	private List<PopMenuData> m_ModePreferDataList;

	private List<PopMenuData> m_PrivilegeBadgeDataList;

	private List<string> m_SexList;

	private List<string> m_DefaultShowList;

	private List<string> m_OnLineTimeList;

	private List<string> m_ActiveTimeList;

	private List<string> m_ModePreferList;

	private List<PrivilegeIconConfig> m_PrivilegeBadgeList;

	private uint m_SelectedSexIndex;

	private uint m_SelectedDefaultShowIndex;

	private uint m_SelectedOnLineTimeIndex;

	private uint m_SelectedActiveTimeIndex;

	private uint m_SelectedModePreferIndex;

	private uint m_SelectedPrivilegeBadgeIndex;

	private uint m_CurrentWeaponPowerBrTitleID;

	private uint m_CurrentWeaponPowerCsTitleID;

	private uint m_CurrentRankBrTitleID;

	private uint m_CurrentRankCsTitleID;

	private uint m_CurrentPeakCsTitleID;

	private uint m_CurrentClanTitleID;

	private bool m_IsLeaderBoardTitleDirty;

	private UIPopMenuSmallControler m_SexPop;

	private UIPopMenuSmallControler m_DefaultShowPop;

	private UIPopMenuSmallControler m_OnLineTimePop;

	private UIPopMenuSmallControler m_ActiveTimePop;

	private UIPopMenuSmallControler m_ModePreferPop;

	private UIPopMenuSmallControler m_PrivilegeBadgePop;

	private UIPopWndStandardDrawerTabRemakeController m_UIPrepareInfoTabController;

	private readonly float GREY_ALPHA;

	private UISelectLanguageController m_UISelectLanguageController;

	private UICommonGuideController m_GuideCtrl;

	private ulong mytime;

	private const uint Claimed_COLOR = uint.MaxValue;

	private const uint Lock_COLOR = 2105509631u;

	private PlayerSocialTagsDataManager m_SocialTagsInstance;

	private UILoadingPlayerInfoController m_LoadingPlayerInfoCtrl;

	private UITitleShowController m_TitleShowCtrl;

	private List<UIProfileSettingPregameInfoDataItemController> m_ListPregameInfoDataCtrl;

	private List<UIProfileSettingPregameInfoSubDataItemController> m_ListPregameInfoSubDataCtrl;

	private UILeaderBoardTitleProfileController m_LeaderBoardTitleProfileCtrl;

	private UIProfileHistoryHighestTitleController m_HistoryHighestTitleController;

	private UIModelLadderMatch m_ModelLadderMatch;

	private UIModelRole m_ModelRole;

	private UIModelGroup m_ModelGroup;

	private UIModelCustomRoom m_ModelRoom;

	private UIModelAreaLeaderBoard m_ModelAreaLeaderBoard;

	private UIModelCSPeakTournamentLadderMatch m_ModelCSPeakTournamentLadderMatch;

	public uint CurrentWeaponPowerBrTitleID
	{
		set
		{
		}
	}

	public uint CurrentWeaponPowerCsTitleID
	{
		set
		{
		}
	}

	public uint CurrentRankBrTitleID
	{
		set
		{
		}
	}

	public uint CurrentRankCsTitleID
	{
		set
		{
		}
	}

	public uint CurrentPeakCsTitleID
	{
		set
		{
		}
	}

	public uint CurrentClanTitleID
	{
		set
		{
		}
	}

	public bool IsLeaderBoardTitleDirty
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override string Rule()
	{
		return null;
	}

	protected override void OnUIInit()
	{
	}

	private void PostOnUIInit()
	{
	}

	private void SetFrameTitle()
	{
	}

	private void CreateTab()
	{
	}

	private void RefreshLoadingPlayerInfo(ELoadingBattleType loadingBattleType, List<uint> listLoadingPregameInfo, BattleStatsInfo statsInfo)
	{
	}

	private void RefreshTitleKey(int count, int pregameDataTypeListCount)
	{
	}

	private void PreparePregamePlayerInfo()
	{
	}

	private void CreatePregameInfoPreviewController()
	{
	}

	private void OnCsPrepareInfoClick()
	{
	}

	private void OnCSPeakPrepareInfoClick()
	{
	}

	private void RefreshCSPeakPrepareInfoPanel()
	{
	}

	private void OnBRPrepareInfoClick()
	{
	}

	private void RefreshBRPrepareInfoPanel()
	{
	}

	private void RefreshPregameInfoDataItems(ELoadingBattleType loadingBattleType, List<uint> listData, BattleStatsInfo statsInfo)
	{
	}

	private void RefreshCSPeakPregameInfoDataItems(Dictionary<uint, List<uint>> pregameDataTypeDict, BattleStatsInfo statsInfo)
	{
	}

	public void InitCloseUI()
	{
	}

	private void OnMyClose()
	{
	}

	private void InitTagString()
	{
	}

	private void InitDefaultTagString()
	{
	}

	private void InitPopMenu()
	{
	}

	private void InitSelectedState()
	{
	}

	private void TryShowGuide()
	{
	}

	private void OnMainGuideClose()
	{
	}

	private void SetGoRightPanelShow(EToggle eToggle)
	{
	}

	private void OnClickBasicSetting()
	{
	}

	private void OnClickToggleBtnPregameInfo()
	{
	}

	private void OnClickToggleLeaderBoardTitle()
	{
	}

	public void OnLederBoardTitleClick()
	{
	}

	public void OnHistoryHighestTitleClick()
	{
	}

	public void OnTitleShowClick()
	{
	}

	private bool CheckCanSend()
	{
		return false;
	}

	private ESocial.ModePrefer GetPreferBySelect()
	{
		return ESocial.ModePrefer.ModePrefer_NONE;
	}

	private ESocial.Gender GetGenderBySelect()
	{
		return ESocial.Gender.Gender_NONE;
	}

	private ESocial.TimeActive GetActiveBySelect()
	{
		return ESocial.TimeActive.TimeActive_NONE;
	}

	private ESocial.TimeOnline GetTimeBySelect()
	{
		return ESocial.TimeOnline.TimeOnline_NONE;
	}

	private ESocial.RankShow GetShowBySelect()
	{
		return ESocial.RankShow.RankShow_NONE;
	}

	protected override void OnUIClose()
	{
	}

	private void CheckAddEquipBadge()
	{
	}

	private bool CheckLoadingPlayerInfoChoiceHasChanged(out List<uint> changedBattleType)
	{
		changedBattleType = null;
		return false;
	}

	protected override void OnUIDestroy()
	{
	}

	private void OnBtnRenameClick()
	{
	}

	private void OnSelectLanguageClick()
	{
	}

	private void InitLanguageList()
	{
	}

	private void GenerateSexList()
	{
	}

	private void GenerateDefaultShowList()
	{
	}

	private void GenerateOnLineTimeList()
	{
	}

	private void GenerateActiveTimeList()
	{
	}

	private void GenerateModePreferList()
	{
	}

	private void GenerateBadgeList()
	{
	}

	public void AutoShowBadgeList()
	{
	}

	private void OnLocLanSelect(object obj)
	{
	}

	private void OnSexSelect(object obj)
	{
	}

	private void OnDefaultShowSelect(object obj)
	{
	}

	private void OnOnLineTimeSelect(object obj)
	{
	}

	private void OnActiveTimeSelect(object obj)
	{
	}

	private void OnModePreferSelect(object obj)
	{
	}

	private void OnPrivilegeBadgeSelect(object obj)
	{
	}

	private void UpdateData()
	{
	}

	public void RefreshAccoutId(ulong accid)
	{
	}

	public void RefreshLoadingTitleBG(uint titleId)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void GotoPrepareInfoTab(object expara, bool goSubTab = false)
	{
	}

	public string _003C_003EiFixBaseProxy_Rule()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
