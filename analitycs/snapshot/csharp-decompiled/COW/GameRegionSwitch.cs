using System;
using System.Collections.Generic;
using GCommon;
using message;
using proto;

namespace COW;

public class GameRegionSwitch : SingletonModule<GameRegionSwitch>
{
	private Dictionary<uint, SwitchDesc> m_Switchs;

	private Random m_PopupCraftlandSubscribeRandom;

	public bool Initalized;

	private const int DefaultCDNIconMaxDownloadNum = 5;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public void ProcessRegionSwitch(CSGetAllSwitchsRes switchsRes)
	{
	}

	private int GetMaxCDNDownloadNumInSwitch()
	{
		return 0;
	}

	private bool CheckPlayerEnableAutoDownload()
	{
		return false;
	}

	public uint GetPlayerAutoDownloadLowMemory()
	{
		return 0u;
	}

	public bool IsOptionalRepairOpen()
	{
		return false;
	}

	public bool IsPlayerNeedDeleteOptionalResOnTime()
	{
		return false;
	}

	public uint GetAutoClearLowMemory()
	{
		return 0u;
	}

	public SwitchDesc GetSwitchDesc(ESwitch.SwitchFunc func)
	{
		return null;
	}

	public bool IsGiftStoreShow()
	{
		return false;
	}

	public bool IsCatapultEnable()
	{
		return false;
	}

	public bool IsMicPressedVoiceEnable()
	{
		return false;
	}

	public bool IsOpen(ESwitch.SwitchFunc switchfunc, bool defaultValue = false)
	{
		return false;
	}

	public bool IsOpenWithoutTimeValidation(ESwitch.SwitchFunc switchfunc, bool defaultValue = false)
	{
		return false;
	}

	public bool IsPeakTournamentSquadOpen()
	{
		return false;
	}

	public bool IsGachaEntranceOpen()
	{
		return false;
	}

	public bool IsDrawshopEntranceOpen()
	{
		return false;
	}

	public bool IsDrawShopReplaceGacha()
	{
		return false;
	}

	public bool ShouldShowDrawShopInLobby()
	{
		return false;
	}

	public bool ShouldShowGachaInLobby()
	{
		return false;
	}

	public bool IsShowGachaWarning()
	{
		return false;
	}

	public string GetTreasureBoxWarning()
	{
		return null;
	}

	public bool IsShowSeasonReplay()
	{
		return false;
	}

	public bool IsSeasonReplaySocialV2(bool isBR)
	{
		return false;
	}

	public bool IsCsInGameEnermyRankHide()
	{
		return false;
	}

	public bool IsNewPlayerEntranceOpen()
	{
		return false;
	}

	public bool IsShareButtonOpen()
	{
		return false;
	}

	public bool IsSignATureFuncOpen()
	{
		return false;
	}

	public bool IsRecentVisitorOpen()
	{
		return false;
	}

	public bool IsFriendRelationshipFuncOpen()
	{
		return false;
	}

	public bool IsSmoothHighFrameFuncOpen()
	{
		return false;
	}

	public bool IsWorkshopRoomRelatedFuncOpen()
	{
		return false;
	}

	public bool IsFriendSpectateOpen(uint level)
	{
		return false;
	}

	public bool IsWorkshopFuncOpen()
	{
		return false;
	}

	public bool IsTreasureBoxProbabilityFuncOpen()
	{
		return false;
	}

	public bool IsMysteryShopProbabilityFuncOpen()
	{
		return false;
	}

	public bool IsMysteryBonusProbabilityFuncOpen()
	{
		return false;
	}

	public bool IsInInGameBonusProbabilityFuncOpen()
	{
		return false;
	}

	public bool IsHeroicMarkMasterFuncOpen()
	{
		return false;
	}

	public bool IsGameBufCallSignFuncOpen()
	{
		return false;
	}

	public bool IsFriendRoomMemberOpen()
	{
		return false;
	}

	public bool IsUGCCreateRoomFreeOpen()
	{
		return false;
	}

	public bool IsBRMultiKillOpen()
	{
		return false;
	}

	public bool IsUGCCommentOpen()
	{
		return false;
	}

	public bool IsBannedBRTrioRank()
	{
		return false;
	}

	public bool IsDisplayBRScoreBoard()
	{
		return false;
	}

	public bool IsSettingUploadOpen()
	{
		return false;
	}

	public bool IsSettingDownloadOpen()
	{
		return false;
	}

	public bool IsBannedCSTrioRank()
	{
		return false;
	}

	public bool IsWeaponPermanentOpen()
	{
		return false;
	}

	public bool IsSplashBannerDontShowOpen()
	{
		return false;
	}

	public bool IsBirthIslandInteractionOpen()
	{
		return false;
	}

	public bool IsHideSceneEditItem(uint prefabID)
	{
		return false;
	}

	public bool IsHideUGCAPI(string apiName)
	{
		return false;
	}

	public int GetUGCHalfWayJoinTimesSwitch()
	{
		return 0;
	}

	public bool IsEnableDetailedGroupPresence()
	{
		return false;
	}

	public bool IsUGCShowToken()
	{
		return false;
	}

	public bool IsMobileReplayHighlightMergeOpen()
	{
		return false;
	}

	public bool IsBuildOpen()
	{
		return false;
	}

	public bool IsIOSReviewSupportSubscription()
	{
		return false;
	}

	public bool IsPetRestClosed()
	{
		return false;
	}

	public bool IsLoadoutAutoSwitchOpen()
	{
		return false;
	}

	public bool IsForcePreferHotMapSwitchOpen()
	{
		return false;
	}

	public bool IsNecessaryResPartialDownload()
	{
		return false;
	}

	public bool IsCSRankLoserMVPAddStarOpen()
	{
		return false;
	}

	public bool IsResultOptOpenByGameMode(bool isSolo, uint gameMode)
	{
		return false;
	}

	public bool IsCSRankScoreBoardShowStreakWins(bool isLocalTeam)
	{
		return false;
	}

	public bool IsOpenWinPassByMatchMode(DLBMPCCFKKM matchMode, ref int OpenSeasonID)
	{
		return false;
	}

	public bool IsOpenQuickNext(uint interfaceType, uint matchMode, uint gameMode, uint groupMode)
	{
		return false;
	}

	public bool IsCrossModeBounsOpen()
	{
		return false;
	}

	public bool IsShowBriefMatchResult()
	{
		return false;
	}

	public bool NeedShowFrontEndFictionDisclaimer()
	{
		return false;
	}

	public bool NeedShowIngameFictionDisclaimer(uint gameMode)
	{
		return false;
	}

	public bool IsUseCraftlandLocalizationLogo()
	{
		return false;
	}

	public bool IsUGCMatchMakingReturnToLobby()
	{
		return false;
	}

	public bool IsMediumFrameRateOpen()
	{
		return false;
	}

	public void SetTCPBackgroundDetectiveTime()
	{
	}

	public bool GetCSBoardShowRank_PersonRank()
	{
		return false;
	}

	public void GetCSBoardShowRank_TeamRank(out bool showTeam, out bool byWeights, out int weight1, out int weight2, out int weight3, out int weight4)
	{
		showTeam = default(bool);
		byWeights = default(bool);
		weight1 = default(int);
		weight2 = default(int);
		weight3 = default(int);
		weight4 = default(int);
	}

	public bool CanPopupCraftlandSubscribe()
	{
		return false;
	}

	public float GetRefuseSubscribeCraftlandCDTimeM()
	{
		return 0f;
	}

	public bool GetDisplayLobbyCoinsEvoPass()
	{
		return false;
	}

	public bool GetEvoPassOpen()
	{
		return false;
	}

	public bool GetUGCBigMapAreaEditOpen()
	{
		return false;
	}

	public int GetUGCParadiseEditOpenLevel()
	{
		return 0;
	}

	public bool GetWorkshopLobbyEntranceOpen()
	{
		return false;
	}

	public bool GetSubscribeCraftlandUpdateOpen()
	{
		return false;
	}

	public bool IsTestUGCTemplate(uint templateID)
	{
		return false;
	}

	public uint GetUGCTemplateLevelLimit()
	{
		return 0u;
	}

	public int GetEvoPassDaysAheadForRenewalReminding()
	{
		return 0;
	}

	public bool IsUGCVipOpen()
	{
		return false;
	}

	public List<uint> GetWorkshopValidTemplate()
	{
		return null;
	}

	public bool GetWorkshopCodeVisibleSwitch()
	{
		return false;
	}

	public int GetBRLeaderBoardNewSortingRule()
	{
		return 0;
	}

	public int GetCSLeaderBoardNewSortingRule()
	{
		return 0;
	}

	public bool IsProfileCraftlandResident()
	{
		return false;
	}

	public ulong GetOB47NewbieRegisterTimeLimit()
	{
		return 0uL;
	}

	public List<uint> GetInGameFullCameraModeGameModes()
	{
		return null;
	}

	public bool IsNewBeeRecFriendOpen()
	{
		return false;
	}

	public uint GetRecPresetVersion()
	{
		return 0u;
	}

	public string GetUGCActivityEventTabNavigationContent()
	{
		return null;
	}

	public bool IsSocialHall3DOpen()
	{
		return false;
	}
}
