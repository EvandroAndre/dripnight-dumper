using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIBriefBoxController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass104_0
	{
		public UIBriefBoxController _003C_003E4__this;

		public ulong targetAccountId;

		internal void _003COnGotoSocialLobbyBtnClick_003Eb__0()
		{
		}
	}

	private UIModelProfile m_Model;

	private UIModelClan m_ModelClan;

	private UIModelGroup m_ModelGroup;

	private UIModelProfileCustom m_ModelCustom;

	private UIModelPrime m_ModelPrime;

	private UIBriefBoxView m_View;

	private LayoutTable m_Table;

	private BaseTableItem m_ProfileContainerItem;

	private float m_DefaultWidth;

	private UIBaseProfileInfoController m_Control;

	private GameObject m_EliteVFX;

	private List<CommonPopMenuData> m_MenuDatas;

	private List<CommonPopMenuData> m_SideDatas;

	private Vector3 m_CheckWindowLeftOrRightPos;

	private Vector3 m_WindowPos;

	private BaseProfileInfo m_BaseProfileInfo;

	private AccountBriefInfo m_Data;

	private UIClickMask m_ClickMask;

	private bool m_HasRequestData;

	private bool m_HasRequestClan;

	private ClanInfo m_ClanInfo;

	private bool m_ShowSwitchButton;

	private uint m_BriefBoxIndex;

	private EventLogger.BriefBoxClickData m_ClickData;

	private UISprite m_BGBorder;

	private UIPrivilegeIconController m_PrivilegeIconController;

	private UIBriefBoxInteractionItemController m_BanDeleteFriendItemCtrl;

	private List<GameObject> m_HistoryStarList;

	private List<GameObject> m_HistoryBlackStarList;

	private TweenPosition m_TweenPos;

	private TweenScale m_TweenScale;

	private Vector3 m_FromPos;

	private UICommonSocialHighlightController m_SocialHighlightCtrl;

	private UILeaderBoardTitleSingleController m_LeaderBoardTitleSingleCtrl;

	private UISparkpetProfileTagController m_SparkPetProfileTagCtrl;

	private UIModelLadderMatch m_ModelLadderBR;

	private UIModelCSPeakTournamentLadderMatch m_ModelCSPeakTournamentLadderMatch;

	private UIModelMatch m_ModelMatch;

	private bool m_IsFirstGetPlayerBriefInfo;

	private List<UIBriefBoxInteractionItemController> m_InteractionCtrls;

	private List<UIBriefBoxSideItemController> m_SideItemCtrls;

	private UIBRRankIconController m_BRRankIconController;

	private UICSRankIconController m_CSRankIconController;

	private UICSPeakTournamentRankIconController m_CSPeakTRankIconController;

	private UIProfileCustomCellGridController m_LeftGridCtrl;

	private readonly uint MAX_100K_LIKE_NUM;

	private readonly uint MAX_100M_LIKE_NUM;

	private Vector3 m_ToogleGroupTitlePosPrime;

	private Vector3 m_ToogleGroupTitlePosNormal;

	private bool m_HasCreatedClanBriefBox;

	private bool m_IsPendingDestory;

	private bool m_IsBriefInfoReady;

	private bool m_IsCustomProfileReady;

	private bool m_IsLobbySocialBriefBoxVisible;

	private Action m_OnCloseAction;

	private bool m_IsInGame;

	private const float m_OverBoundAdjustOffset = 20f;

	private string m_PrimeProfileBtnBg;

	private GameObject m_CacheHeroicBREffect;

	private GameObject m_CacheHeroicCSEffect;

	private UIModelOptionalDownload m_ModelDownload;

	private UINewDownloadInfoController m_DownloadCtrl;

	private float m_NextCheckTime;

	public uint BriefBoxIndex => 0u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void AddMaskRegion(object[] param)
	{
	}

	public void DelMaskRegion(object[] param)
	{
	}

	public override void Show()
	{
	}

	public void ShowNoClearData()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void NotifyLobbySocialBriefBoxVisible(bool visible)
	{
	}

	private void Clear()
	{
	}

	public void UpdateMenuData(List<CommonPopMenuData> list, BaseProfileInfo profileInfo, Vector3 checkWindowLeftOrRightPos, string region = "", Vector3 windowPos = default(Vector3), bool showSwitchButton = true, Action OnCloseAction = null, EventLogger.BriefBoxClickData clickData = null)
	{
	}

	private void RefreshSideData()
	{
	}

	private void UpdateMenuDataInternal(List<CommonPopMenuData> list, BaseProfileInfo profileInfo, Vector3 WindowPos)
	{
	}

	private void RefreshContainer(float width)
	{
	}

	private void RefreshContainerByWindowPos(float width)
	{
	}

	private void AddMask()
	{
	}

	private UIWidget GetPhotoWallBtnMaskRegion()
	{
		return null;
	}

	private int GetMaskExpandWidth(UIWidget widget)
	{
		return 0;
	}

	private void ExpandMaskToIncludeSideBtns()
	{
	}

	private void RequestData()
	{
	}

	private void RefreshItem()
	{
	}

	private void FilterMenuDataForBannedState()
	{
	}

	private float RefreshProfile()
	{
		return 0f;
	}

	private void RefreshSimulatorIcon()
	{
	}

	private void OnSimulatorIconClick()
	{
	}

	private void RefreshHonorContainer()
	{
	}

	private void RefreshSocialHighlights()
	{
	}

	private void RefreshLeaderBoardTitle()
	{
	}

	private void RefreshSparkPetInfo()
	{
	}

	private void RefreshRank()
	{
	}

	private void ShowBrLadder(int rank, uint peakRankPos, int rankScore)
	{
	}

	private void ShowOccupationInfo(bool isBR)
	{
	}

	private void OnOccupationGoposBtnClicked()
	{
	}

	private void ShowBrRankInfo()
	{
	}

	private void ShowCsCurrentRankInfo()
	{
	}

	private void OnHeroicMarkBRIconClick()
	{
	}

	private void OnHeroicMarkCSIconClick()
	{
	}

	private void OnCSPeakTournamentRankIconBtnClick()
	{
	}

	private void RefreshHeroicMarkInfo()
	{
	}

	private void UpdateMenuDataWithFixedWidth()
	{
	}

	private void RefreshGotoSocialLobby()
	{
	}

	private void OnGotoSocialLobbyBtnClick()
	{
	}

	private void OnPhotoWallBtnClick()
	{
	}

	private void RefreshUserLike(uint likeNum)
	{
	}

	private void OnNoLikeIconClick()
	{
	}

	private void RefreshPrimeIcon()
	{
	}

	private void RefreshLikeContainer()
	{
	}

	private void RefreshLikeContainer(object[] param)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void OnClanInfoBtnClick()
	{
	}

	private void UpdateBriefBoxState(object[] param)
	{
	}

	private void UpdateBriefBoxStateFromWishBrief(object[] param)
	{
	}

	private void CloseFromWishBriefBox(object[] param)
	{
	}

	private void OnTweenFinish()
	{
	}

	private void TryGetClanInfo()
	{
	}

	private void RefreshClanSwitchButton()
	{
	}

	public Vector3 GetContainerPosition()
	{
		return default(Vector3);
	}

	public ulong GetAccountId()
	{
		return 0uL;
	}

	public bool ChangePrimeSkin()
	{
		return false;
	}

	private void CheckIsOverBound()
	{
	}

	private void RefreshCustomProfile()
	{
	}

	private void LogBriefBoxClick(bool isGuild = false)
	{
	}

	private void UpdateBannedInfo()
	{
	}

	private bool GetBanState(ulong accountID)
	{
		return false;
	}

	private void RefreshCSPeakTInfo(object[] data)
	{
	}

	private void ShowCSPeakTournamentCurrentRankInfo()
	{
	}

	private void FixedUpdate()
	{
	}

	private void RefreshDownloadState()
	{
	}

	private void OnDownloadStateChangeCallback()
	{
	}

	private void SetDownloadContainerVisable(bool isShow)
	{
	}

	private bool IsNinthResDownloadReady()
	{
		return false;
	}

	private bool _003CRefreshLikeContainer_003Eb__109_0(ulong id)
	{
		return false;
	}

	private bool _003CRefreshLikeContainer_003Eb__110_0(ulong id)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
