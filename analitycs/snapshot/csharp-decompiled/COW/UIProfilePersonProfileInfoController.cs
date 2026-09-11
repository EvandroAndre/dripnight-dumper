using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIProfilePersonProfileInfoController : UIBaseController, IUIModelDataChangeObserver
{
	private UIProfilePersonProfileInfoView m_View;

	private UIModelProfile m_Model;

	private UIModelClan m_ModelClan;

	private UIModelEvoPass m_ModelEvoPass;

	private UIModelCSLadderMatch m_ModelCSLadderMatch;

	private UIModelUser m_ModelUser;

	private UIModelPrime m_ModelPrime;

	private UIModelRole m_ModelRole;

	private UIModelCSPeakTournamentLadderMatch m_ModelCSPeakTournamentLadderMatch;

	private UIBRRankIconController m_BRRankIconController;

	private UICSRankIconController m_CSRankIconController;

	private UIProfilePlayerPreferenceSettingPopWndController m_UIProfilePlayerPreferenceSettingPopWndCtrl;

	private UICSPeakTournamentRankIconController m_CSPeakTournamentRankIconController;

	private BaseItemInfo m_PinItemInfo;

	private ClanInfo m_ClanInfo;

	private bool m_IsUserSelf;

	private bool m_IsFirstShowLevelUpBubble;

	private bool m_IsInEditMode;

	private bool m_IsCurrentBRModeShow;

	private uint m_SetLikesLabelDelayCall;

	private ulong m_AccountId;

	private string m_SelectedOnLineTime;

	private string m_SelectedActiveTime;

	private string m_SelectedModePrefer;

	private uint m_LikesNum;

	private GameObject m_CacheHeroicBREffect;

	private GameObject m_CacheHeroicCSEffect;

	private GameObject m_LoadingPrefab;

	private const uint MAX_100K_LIKE_NUM = 100000u;

	private const uint MAX_100M_LIKE_NUM = 100000000u;

	private const int CUSTOM_PROFILE_LINE_PREVIEW_LENGTH = 890;

	private const int CUSTOM_PROFILE_LINE_ORIGINAL_LENGTH = 430;

	private GameObject m_EliteVFX;

	private UIPrivilegeIconController m_PrivilegeIconController;

	private GameObject m_PrimeAvatarFrame;

	private ResourceID m_AvatarFrameRes;

	private UIFFLogoController m_UIFFLogoCtrl;

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

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void SetViewData(ulong accountId, bool isUserSelf, bool isInEditMode)
	{
	}

	public void ShowPersonalBoard()
	{
	}

	public void SetCustomProfilePreviewUIState(bool isPreview)
	{
	}

	public void RefreshUserName()
	{
	}

	private void OnPersonHeadBtnClick()
	{
	}

	private void OnBtnChangeNameClick()
	{
	}

	private void OnCopyBtnClick()
	{
	}

	private void OnLevelGiftButtonClick()
	{
	}

	private void OnHeroicMarkBRIconBtnClick()
	{
	}

	private void OnHeroicMarkCSIconBtnClick()
	{
	}

	private void OnCSPeakTournamentRankIconBtnClick()
	{
	}

	private void ShowPersonalSetting()
	{
	}

	public void ShowPersonalSettingFromPrime()
	{
	}

	private void RefreshCsInfo(object[] data)
	{
	}

	private void OnEnterProfileSettingTabLoadingInfo(object[] data)
	{
	}

	private void RefreshCSPeakTInfo(object[] data)
	{
	}

	private void OnSeasonSwitchBtnClick()
	{
	}

	private void InitView()
	{
	}

	private void SetDefaultLangr()
	{
	}

	private void RefreshBg()
	{
	}

	private void UpdateHeadPic(uint iid, ulong accountId, string externalIcon, EAccount.ExternalIconStatus externalIconStatus, EAccount.ExternalIconShowType externalIconShowType)
	{
	}

	private void UpdateHeadPic(HeadPicData data)
	{
	}

	private void UpdatePin(uint pinId)
	{
	}

	private void UpdateBanner(uint bannerId)
	{
	}

	private void UpdateBanner(BannerData bannerData)
	{
	}

	private void SetButtonHoverAction()
	{
	}

	private void CopyToClipBoard(ulong uid)
	{
	}

	private void RequestSetRankShow()
	{
	}

	private void ShowPlatformHeadPicGuide()
	{
	}

	private void OnNoLikeIconClick()
	{
	}

	private void RefreshLikeContainer()
	{
	}

	private void SetLikesLabel()
	{
	}

	private void RefreshLikeContainer(object[] param)
	{
	}

	private void ShowBrRankInfo()
	{
	}

	private void ShowBrLadder(int rank, uint peakRankPos, int rankScore, bool isSelf, UILabel go)
	{
	}

	private void TryRefreshCSCrossModeView()
	{
	}

	private void TryRefreshBRCrossModeView()
	{
	}

	private void onSeasonBrBtnClick()
	{
	}

	private void onSeasonCSBtnClick()
	{
	}

	public void RefreshHeroicMarkInfo()
	{
	}

	private void RefreshShowBoardOccupationInfo(bool isBr)
	{
	}

	public void ShowCsCurrentRankInfo()
	{
	}

	private void RefreshSeasonInfo()
	{
	}

	private void ShowCSPeakTournamentCurrentRankInfo()
	{
	}

	private void OnClanPopupBtnClick()
	{
	}

	private void RefreshClanInfo(bool request = true)
	{
	}

	private void UpdateClanIconAndName()
	{
	}

	public void RefreshLevelUpBubble()
	{
	}

	private void RefreshLogo()
	{
	}

	public void ShowNetworkBlock(bool show)
	{
	}

	private void RefreshPrimeRelated()
	{
	}

	private void RefreshBadge()
	{
	}

	private void SetPrivilegeIcon(uint mainType, uint subType)
	{
	}

	private void _003CSetButtonHoverAction_003Eb__67_0(bool flag)
	{
	}

	private void _003CSetButtonHoverAction_003Eb__67_1(bool flag)
	{
	}

	private void _003CSetButtonHoverAction_003Eb__67_2(bool flag)
	{
	}

	private void _003CSetButtonHoverAction_003Eb__67_3(bool flag)
	{
	}

	private void _003CSetButtonHoverAction_003Eb__67_4(bool flag)
	{
	}

	private void _003CSetButtonHoverAction_003Eb__67_5(bool flag)
	{
	}

	private bool _003CRefreshLikeContainer_003Eb__72_0(ulong id)
	{
		return false;
	}

	private bool _003CRefreshLikeContainer_003Eb__74_0(ulong id)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
