using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIClanWarV2InfoController : UIBaseController
{
	private const string FAST_MSG_TEAMLEADER_CHOOSE_CLANWAR_KEY = "T_42_ZZ_CHANGEMODE";

	private const uint COLOR_GRAY = 2037742847u;

	private const uint COLOR_WHITE = uint.MaxValue;

	private const int REWARD_INFO_POS_FIX = -11;

	private const string TITLE_LABEL_BG_COUNTRY = "UI_ClanWars_TitleLabelBg_01";

	private const string TITLE_LABEL_BG_PROVINCE = "UI_ClanWars_TitleLabelBg_02";

	private const string TITLE_LABEL_BG_CITY = "UI_ClanWars_TitleLabelBg_03";

	private const string ON_LIST_ANIM = "UIFX_UIClanWarV2Info_On";

	private const string NOT_ON_LIST_ANIM = "UIFX_UIClanWarV2Info_NotOn";

	private string[] m_DayInWeekStrDict;

	private UIModelLeaderBoard m_ModelLeaderBoard;

	private UIModelClanWarV2 m_ModelWar;

	private UIModelMapOpeningInfo m_ModelMapOpeningInfo;

	private UIClanWarV2InfoView m_View;

	private UIClanWarV2ProgressController m_ProgressCtrl;

	private UIClanWarV2LeaderBoardMiniController m_LeaderBoardMiniCtrl;

	private ClanWarV2Stage m_Stage;

	private UICountDownController m_CountDownCtrl;

	private UICountDownController m_CountDownSettlingCtrl;

	private UIClanWarV2CdnTipsController m_CdnTipsCtrl;

	private UIStandardItemMiniController m_ItemCtrl;

	private UIStandardCarouselController m_CarouselController;

	private Vector3 m_RewardInfoPosition_Normal;

	private Vector3 m_RewardInfoPosition_Fix;

	private uint m_NotifyID;

	private ELeaderBoardTitleRegionType m_SelectedRegion;

	private GameObject m_OnTheList_FX_Country;

	private GameObject m_OnTheList_FX_Province;

	private GameObject m_OnTheList_FX_City;

	private Color m_WhiteColor;

	private Color m_GrayColor;

	private uint m_OpeningTurnNum;

	private List<UILabel> m_OpeningTimeLabelList;

	private int m_OpeningTimeBgHeight;

	private bool m_EnableClanWar;

	private bool m_IsMatchFull;

	private const int ITEMWIDTH = 120;

	private const int ITEMHEIGHT = 150;

	private const int GRIDDOTWIDTH = 25;

	private const int GRIDDOTHEIGHT = 6;

	private const int DOTWIDTH = 22;

	private const int DOTHEIGHT = 6;

	private const string LOBBY_BANNER_DOT_ENABLE_SPRITE_NAME = "FF_UI_Lobby_BannerTab01";

	private const string LOBBY_BANNER_DOT_DISABLE_SPRITE_NAME = "FF_UI_Lobby_BannerTab02";

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIDestroy()
	{
	}

	protected override void OnUIInit()
	{
	}

	public void RefreshView()
	{
	}

	private void RefreshRoundStage()
	{
	}

	private void RefreshTrans()
	{
	}

	private void RefreshSeasonPre()
	{
	}

	private void RefreshContentModeString(EClan.GuildWarSeasonType type)
	{
	}

	private string GetOpeningTimeLabel(long startTime, long endTime, string key)
	{
		return null;
	}

	private void RefreshSettled()
	{
	}

	private string GetTitleLabelBgName()
	{
		return null;
	}

	private void RefreshWarmUp()
	{
	}

	private void RefreshOpening()
	{
	}

	public void RefreshCSGameButtonState()
	{
	}

	private void RefreshIntermission()
	{
	}

	private void RefreshIntermissionLabel()
	{
	}

	private void RefreshSettling()
	{
	}

	private void RefreshProgressCtrl()
	{
	}

	private void RefreshLeaderBoardMini()
	{
	}

	private void RefreshAwardBanner()
	{
	}

	public void RefreshViewBySelectedRegion(uint boardID = 0u, ELeaderBoardTitleRegionType type = ELeaderBoardTitleRegionType.None)
	{
	}

	private void RefreshWaitingLabel()
	{
	}

	private void OnCdnTipBtnClick()
	{
	}

	private void OnJoinBtnClick()
	{
	}

	private void SendLobbyClanWarMsg()
	{
	}

	private void OnRewardRuleBtnClick()
	{
	}

	private void OnOpeningTimeRuleBtnClick()
	{
	}

	private void ChooseClanWarMode()
	{
	}

	private void OnEquipBtnClick()
	{
	}

	private void OnRewardCDNBtnClick()
	{
	}

	public void OpenMatchResultWnd()
	{
	}

	private void ShowSettleFX()
	{
	}

	private void LoadResource(ref GameObject go, ResourceID res, Transform parent)
	{
	}

	private void UnloadResource(ref GameObject go)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
