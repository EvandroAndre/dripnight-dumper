using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UILeaderBoardItemNewController : UIEasyListItemController
{
	public enum DisplayType
	{
		PersonKills,
		PersonWins,
		PersonKD,
		PersonBagdges,
		GuildRegionHonor,
		GuildRegionHonorTotal,
		GuildGlobalHonor,
		CSPersonKills,
		CSPersonWins,
		CSPersonKD,
		PVEDamage,
		PVEPassTime,
		PVEInfiniteData,
		PVETotalScore,
		PVEHighestScore,
		GuildActivityRank,
		GuildActivityRankGlobal,
		GuildWarGuild,
		GuildWarIndividual,
		GuildWarChampionshipGuild,
		HCRank,
		HCWorth,
		HCProfit,
		PrimeMonthly,
		PrimeYearly,
		PrimeTotally,
		WishListRanking
	}

	public enum TabType
	{
		BRRank,
		CSRank,
		Other
	}

	public enum RankFormat
	{
		Normal,
		TopPercent
	}

	private RankFormat m_RankFormat;

	private uint m_MaxSize;

	private DisplayType m_DisplayType;

	private UILeaderBoardItemNewView m_View;

	private LeaderBoardInfo m_info;

	private WishListLeaderboardItem m_WishListRankingInfo;

	private UIBaseProfileInfoController m_BaseProfileUI;

	private UITeamBaseProfileController m_TeamBaseProfileUI;

	private UIStandardItemMiniController m_WishListRankingItemCtrl;

	private UIWidget m_ProfileWidget;

	private int m_BGWidth;

	private ulong m_AccountID;

	private bool m_IsSelf;

	private int m_LockRank;

	private TabType m_TabType;

	private UIModelCSLadderMatch m_ModelCSLadderMatch;

	private UIModelLadderMatch m_ModelLadderMatch;

	private UIModelLeaderBoard m_ModelLeaderBoard;

	private UIModelClanWarV2 m_ModelClanWar;

	private UIModelClan m_ModelClan;

	private UIModelWishList m_ModelWishList;

	private UILeaderBoardTitleCommonController m_TitleCommonCtrl;

	private bool m_RankPositionFixed;

	private Vector3 m_GotoModeWithIconTrans;

	private Vector3 m_GotoModeWithNoIconTrans;

	private int m_LeaderBoardType;

	private int m_currentReqProp;

	private Dictionary<uint, GameObject> m_RankCupIcon;

	private Dictionary<uint, string> m_RankBG;

	private bool m_CanSelect;

	private bool m_SelfInLeaderBoard;

	private bool m_IsPrimeNotInLeaderBoard;

	public TabType CurrentTabType => TabType.BRRank;

	public void SetCurrentReqProp(int currentReqProp)
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitWishJumpButton()
	{
	}

	private void OnWishJumpButtonClick()
	{
	}

	public void SetClosedViewData(LeaderBoardInfo info)
	{
	}

	public void SetLeaderBoardType(int leaderBoardType)
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void HideAllUIs()
	{
	}

	public void SetMyselTabType(uint tabType)
	{
	}

	private void SetIconView(int lockRank)
	{
	}

	private void LockBtnOnClick()
	{
	}

	public void SetLockContainnerView(bool forceShow = false)
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnClick2()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	private Vector2 GetProfileHalfSize(Transform baseProfileTopLeft, float w, float h)
	{
		return default(Vector2);
	}

	private Vector3 GetProfileCenterPos(Transform baseProfileTopLeft, Vector2 baseProfileHalfSize, float w, float h)
	{
		return default(Vector3);
	}

	private bool IsInProfileRange(Vector3 centerPos, Vector2 size)
	{
		return false;
	}

	public void HideBriefBoxBtn()
	{
	}

	public void HideBG()
	{
	}

	public void SetIsSelf(bool isSelf)
	{
	}

	private void SetClosedRankUI()
	{
	}

	public void SetRankUI()
	{
	}

	private void SetWishListRanking(WishListLeaderboardItem info)
	{
	}

	private void SetWishListRankingRankUI()
	{
	}

	private void SetWishListRankingState()
	{
	}

	private int GetEasylistMaxCount()
	{
		return 0;
	}

	private void SetPersonKills()
	{
	}

	private void SetPersonWins()
	{
	}

	private void SetPersonKD()
	{
	}

	private void SetCSPersonKills()
	{
	}

	private void SetCSPersonWins()
	{
	}

	private void SetCSPersonKD()
	{
	}

	private void SetPersonBadges()
	{
	}

	private void SetGuildActivityRank()
	{
	}

	private void SetGuildActivityRankGlobal()
	{
	}

	private void SetGuildWarInfoIndividual()
	{
	}

	private void SetGuildWarInfoGuild()
	{
	}

	private void SetGuildRegionHonor()
	{
	}

	private void SetGuildRegionHonorTotal()
	{
	}

	private void SetGuildGlobalHonor()
	{
	}

	private string TryGetGuildScoreFromInfo()
	{
		return null;
	}

	private void SetHCRank()
	{
	}

	private void SetHCWorth()
	{
	}

	private void SetHCProfit()
	{
	}

	private void SetSelfGoto(bool withIcon)
	{
	}

	public void SetGoToPrimeBtnShow(bool show)
	{
	}

	private void SetPersonBaseProfile(Transform attachPoint)
	{
	}

	private void SetAnonymousProfile(Transform attachPoint)
	{
	}

	private void SetGuildLogo(UISprite logoSprite, UINetworkTexture logoCDN)
	{
	}

	private void SetGuildLogoByInfo(UISprite logoSprite, UINetworkTexture logoCDN, ClanInfo info)
	{
	}

	private void SetGuildLogoByInfo(UISprite logoSprite, UINetworkTexture logoCDN, LeaderBoardInfo info)
	{
	}

	private void SetPVEPassTime()
	{
	}

	private void SetPVEDamage()
	{
	}

	private void SetPVEPassedLevel()
	{
	}

	private void SetPVETotalScore()
	{
	}

	private void SetPVEHighestScore()
	{
	}

	public void SetPrimePointsMonthly(bool isFromPrimeLeaderboard = false)
	{
	}

	public void SetPrimePointsYearly(bool isFromPrimeLeaderboard = false)
	{
	}

	public void SetPrimePointsTotally(bool isFromPrimeLeaderboard = false)
	{
	}

	public uint GetLeaderBoardRank()
	{
		return 0u;
	}

	private void SetTeamBaseProfile(Transform attachPoint)
	{
	}

	public void SetRankFormat(RankFormat format, uint maxSize)
	{
	}

	public void SetDisplayType(DisplayType displayType)
	{
	}

	public void SetItemSelect(bool flag)
	{
	}

	public void SetBGInfo(int bgWidth)
	{
	}

	private void OnClanInfoActivenessClicked()
	{
	}

	private void OnClanInfoClicked()
	{
	}

	private void OnClickGotoMode()
	{
	}

	private void OnClickPrimeGotoBtn()
	{
	}

	private void OnScrollToSelfBtnClick()
	{
	}

	public void SetSelfLocationBtnShow()
	{
	}

	public int GetSelfIndex()
	{
		return 0;
	}

	public void CheckBelowStartScore()
	{
	}

	private void FixRankPosition(bool target)
	{
	}

	private EventLogger.BriefBoxClickData GetBriefBoxClickData(ulong accountId)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnClick2()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
