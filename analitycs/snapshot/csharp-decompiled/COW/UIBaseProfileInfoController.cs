using System;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UIBaseProfileInfoController : UIBaseController, IUIModelDataChangeObserver, ITipsDelegate
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__86_0;

		internal void _003CStartChangeHeadPicGuide_003Eb__86_0()
		{
		}
	}

	private bool IsVertical;

	private UIBaseProfileInfoView m_View;

	public Action BtnCallBack;

	private ESocial.Gender m_Gender;

	private ulong m_AccountID;

	private string m_NickName;

	private UIModelCSLadderMatch m_ModelLadderCS;

	private UIModelLadderMatch m_ModelLadderBR;

	private UIModelCSPeakTournamentLadderMatch m_ModelCSPeakTournamentLadderMatch;

	private UIModelEvoPass m_ModelEvoPass;

	private UIModelPrime m_ModelPrime;

	private UIModelRole m_ModelRole;

	private UICommonGuideController m_GuideCtrl;

	private const string GUIDECHANGEHEADPICKEY = "T_40_L_PLATFORMICON_GUIDE1";

	private const float GUIDECHANGEHEADPICTIME = 5f;

	private UIBRRankIconController m_BRRankIconController;

	private UICSRankIconController m_CSRankIconController;

	private UIHippoCrisisRankIconController m_HCRankIconCtrl;

	private UISocialHighlightIconController m_SocialHighlightController;

	private UILeaderBoardTitleIconController m_LeaderBoardTitleController;

	private UILimitedTimeRankIconController m_LimitedTimeRankIconController;

	private UIPrivilegeIconController m_PrivilegeIconController;

	private UICSPeakTournamentRankIconController m_CSPeakTournamentRankIconController;

	private UITipsNormalController m_TipsCtrl;

	private bool m_IsShowLobbyTip;

	private bool m_IsCurShowBRRank;

	private bool m_IsShowClanIcon;

	private bool m_ShowRank;

	private TweenAlpha m_TweenLogo;

	private TweenAlpha m_TweenBRIcon;

	private TweenAlpha m_TweenCSIcon;

	private GameObject m_PrimeAvatarFrame;

	private ResourceID m_AvatarFrameRes;

	private ulong m_ClanId;

	private UIModelClan m_ModelClan;

	private UIModelGroup m_ModelGroup;

	private BaseProfileInfo m_ProfileData;

	private bool m_IsBannedState;

	private bool m_MaskPanelDepthCalculated;

	private bool m_ShowCallSign;

	private bool m_IsUGCScene;

	private bool m_EnableCreatorNameColor;

	private bool m_LastGrayOffline;

	public bool IsShowClanIcon
	{
		set
		{
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	private void SetMaskPanelDepth()
	{
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetBoxColliderDisabled()
	{
	}

	public void UpdateLevelRankUI(bool showLevel, bool showRank)
	{
	}

	public void SetCSUIwithScore(uint rank, uint rankpoint, uint peakRankPos, bool isShowCSIcon = true, uint rankIconDisplayType = 1u, ERankIconSpecialAdaptTypes adaptType = ERankIconSpecialAdaptTypes.CSBiggerMaxRankText, uint brRank = 0u, bool isShowCSPeakIcon = false, uint csPeakPoints = 0u)
	{
	}

	private void SetAutoSwitchIcon(bool showCS, bool showPeak)
	{
	}

	public void SetHCUIwithScore(uint rank, uint rankpoint, uint rankIconDisplayType = 1u)
	{
	}

	public void SetLimitedTimeRankWithScore(uint score)
	{
	}

	public void CancelAnimation()
	{
	}

	public void SetPeriodicUIwithScore(uint rank, uint rankpoint)
	{
	}

	public void SetBRUIwithScore(uint rank, uint rankpoint, uint peakRankPos, bool isShowBRIcon = true, uint rankIconDisplayType = 1u, uint csRank = 0u)
	{
	}

	private void ShowBROrCSIcon(bool showBRIcon)
	{
	}

	public void SetGender(ESocial.Gender gender)
	{
	}

	private void UpdateGender()
	{
	}

	public void SetNameColorStyleOptions(bool isUGCScene, bool enableCreatorNameColor = false)
	{
	}

	public void SetUIData(BaseProfileInfo data, uint showState = 0u, ShowCallSignRank showCallsignRank = ShowCallSignRank.None)
	{
	}

	public void SetOnlineText(string text, Color color)
	{
	}

	private void RefreshBannedState()
	{
	}

	public void SetBannedState()
	{
	}

	public void SetSeasonReplayDesc(string desc)
	{
	}

	public void UpdatePin(uint pinId)
	{
	}

	public void SetPinIconState(bool value, bool isBigIcon = false)
	{
	}

	public void UpdateBanner(uint bannerId)
	{
	}

	public void SetVertical()
	{
	}

	public void UpdateBanner(BannerData bannerdata)
	{
	}

	public void UpdateHeadPic(HeadPicData data)
	{
	}

	public void ShowInfoContainer(bool v)
	{
	}

	public void OnHeadBtnClick()
	{
	}

	private void OnNewVersionClick()
	{
	}

	public void UpdateScrollText()
	{
	}

	public void UpdateRank(int rank, uint peakRankPos, bool isBr = true, int anotherRank = 0)
	{
	}

	public void UpdateRank(BaseProfileInfo data)
	{
	}

	public void EnableHeadClick(bool enabled)
	{
	}

	private void UpdateNickNameAndAlias()
	{
	}

	public void ShowLadderRankChangeEffect()
	{
	}

	public void ShowRoomLimitation(uint level, ulong clanId)
	{
	}

	uint IUIModelDataChangeObserver.GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	void IUIModelDataChangeObserver.OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void SetGuideVisable(bool show)
	{
	}

	private void StartChangeHeadPicGuide()
	{
	}

	private void OnGuideMaskBtnClick()
	{
	}

	public void SetClanIconCarousel()
	{
	}

	private void RefreshClanIcon()
	{
	}

	private void RefreshSocialHighlight(bool isShowSocialHighlight, bool isHideLeaderboardTitle)
	{
	}

	private void RefreshSocialStatus(bool isShowSocialStatus)
	{
	}

	public void OnTipsDataChange(ETipsType type, int num)
	{
	}

	public void RefreshHeadpic()
	{
	}

	public UIWidget ProfileWidget()
	{
		return null;
	}

	public UIButton ProfileButton()
	{
		return null;
	}

	private void SetPrivilegeIcon(uint mainType, uint subType)
	{
	}

	private void RefreshAvatarFrame()
	{
	}

	public void UpdateAvatarFrame(CollectionAvatarFrameData avatarFrameData)
	{
	}

	private void RefreshBadge()
	{
	}

	public void SetUIDataAnonymous()
	{
	}

	public void ShowPrimeBadge(uint level)
	{
	}

	public void ShowAvatarFrame()
	{
	}

	private void ApplyNickNameColor(bool grayOffline)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
