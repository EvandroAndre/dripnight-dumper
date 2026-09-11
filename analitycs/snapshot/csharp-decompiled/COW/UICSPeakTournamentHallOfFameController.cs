using System.Collections.Generic;
using GCommon;
using UMA;
using UnityEngine;

namespace COW;

public class UICSPeakTournamentHallOfFameController : UINavigationController, IUIModelDataChangeObserver, IEasyList
{
	private sealed class _003C_003Ec__DisplayClass58_0
	{
		public uint seaonID;

		public UICSPeakTournamentHallOfFameController _003C_003E4__this;

		internal void _003CCreateTabs_003Eb__0()
		{
		}
	}

	private UICSPeakTournamentHallOfFameView m_View;

	private UILadderLeaderBoardItemController m_SelfRankUI;

	private bool m_LeaderBoardExpand;

	private List<ulong> m_CurrentTop3AccountIds;

	private List<LeaderBoardInfo> m_LeaderBoardDatas;

	private bool m_HasRefreshExpandLeaderBoard;

	private const float SCROLL_BUTTON_OFFSET_Y = 40f;

	private GameObject m_GlaiveObj;

	private UIMaleAvatar m_FirstPlaceAvatar;

	private UIMaleAvatar m_SecondPlaceAvatar;

	private UIMaleAvatar m_ThirdPlaceAvatar;

	private UIBaseProfileInfoController m_FirstProfileInfoController;

	private UIBaseProfileInfoController m_SecondProfileInfoController;

	private UIBaseProfileInfoController m_ThirdProfileInfoController;

	private UIModelCSPeakTournamentLadderMatch m_ModelCSPeakTournamentLadderMatch;

	private UIModelAvatarProfile m_ModelAvatarProfile;

	private UIModelCollectionCustom m_ModelCollectionCustom;

	public LeaderBoardInfo m_SelectedInfo;

	private uint m_CurrentTabSeasonID;

	private uint m_LastSeasonID;

	private AutoPopup m_AutoPopup;

	private UICSPeakTournamentHallOfFameTabController m_TabCtrl;

	private List<StandardTabItemViewData> m_MainTabDataList;

	public int LastSelectIndex;

	private GameObject m_GoMixCamera;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public override void OnNavigationClosed()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void SetPreviewVisible(int place, bool visible)
	{
	}

	private void InitCamera()
	{
	}

	private void SetCameraFovAccordingToResolution(Camera camera)
	{
	}

	private void InitKingsglaive()
	{
	}

	private void TryShowPreviewAvatar()
	{
	}

	public void ShowLoading(int place, bool show)
	{
	}

	private bool ShowAvatar(int place, ulong accountID)
	{
		return false;
	}

	private void OnFirstCheckBtnClick()
	{
	}

	private void OnSecondCheckBtnClick()
	{
	}

	private void OnThirdCheckBtnClick()
	{
	}

	private void ApplyFresnelMaterial(UMAData umaData)
	{
	}

	public void SetSelectInfo(LeaderBoardInfo info)
	{
	}

	public void Update()
	{
	}

	private void OnScrollBtnClick()
	{
	}

	public void ScrollToIndex(int index)
	{
	}

	public bool IsSelfRankUIInCurrentPage(int index)
	{
		return false;
	}

	public void SetSelfLocationBtnShow()
	{
	}

	public int GetEasylistMaxCount()
	{
		return 0;
	}

	public bool IsLeaderBoardExpand()
	{
		return false;
	}

	private void OnExpandLeaderBoardBtnClick()
	{
	}

	private void OnCloseLeaderBoardBtnClick()
	{
	}

	private void RefreshSelfRankUI()
	{
	}

	private void RefreshLeaderBoard()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	private void OnShareBtnClick()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void OnTipsBtnClick()
	{
	}

	private void CreateTabs()
	{
	}

	private void SelectDefaultTab()
	{
	}

	private void RequestSeasonData(uint seasonID)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public new void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public new void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
