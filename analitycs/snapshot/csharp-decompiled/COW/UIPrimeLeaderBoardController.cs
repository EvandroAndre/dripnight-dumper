using System.Collections.Generic;
using GCommon;
using UMA;
using UnityEngine;
using UnityEngine.Events;
using proto;

namespace COW;

public class UIPrimeLeaderBoardController : UIBaseController, IUIModelDataChangeObserver, IEasyList
{
	public enum FriendFilter
	{
		Region,
		Friend
	}

	public enum TimeFilter
	{
		Monthly,
		Yearly,
		Totally
	}

	private sealed class _003C_003Ec__DisplayClass70_0
	{
		public UINewDownloadInfoController downloadCtrl;

		public List<ResourceID> needDownloadResources;

		internal void _003CConfigureDownloadController_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass79_0
	{
		public UIPrimeLeaderBoardController _003C_003E4__this;

		public UMAData umaData;

		public UnityAction<UMAData> characterUpdatedCallback;

		internal void _003CChangeAvatarMaterial_003Eb__0(UMAData data)
		{
		}
	}

	private UIPrimeLeaderBoardView m_View;

	private GameObject m_GlaiveObj;

	private UIMaleAvatar m_FirstPlaceAvatar;

	private UIMaleAvatar m_SecondPlaceAvatar;

	private UIMaleAvatar m_ThirdPlaceAvatar;

	private UIBaseProfileInfoController m_FirstProfileInfoController;

	private UIBaseProfileInfoController m_SecondProfileInfoController;

	private UIBaseProfileInfoController m_ThirdProfileInfoController;

	private List<bool> m_AvatarAnonymous;

	private UIModelPrime m_ModelPrime;

	private UIModelLeaderBoard m_ModelLeaderBoard;

	private UIModelAvatarProfile m_ModelAvatarProfile;

	private UIModelOptionalDownload m_ModelOptionalDownload;

	private UIModelCollectionCustom m_ModelCollectionCustom;

	private UIPopMenuSmallControler m_FriendPopMenuCtrl;

	private UIPopMenuSmallControler m_TimePopMenuCtrl;

	private UIPopMenuSmallControler m_LeaderBoardTimePopMenuCtrl;

	private List<PopMenuData> m_TimePopMenuList;

	private List<PopMenuData> m_FriendPopMenuList;

	private Dictionary<uint, string> m_PopMenuToKey;

	private Dictionary<uint, string> m_TimePopMenuToKey;

	private FriendFilter m_CurrentFriendFilter;

	private TimeFilter m_CurrentTimeFilter;

	private int m_RequestPropIDs;

	private uint m_RequestBoardID;

	public LeaderBoardInfo m_SelectedInfo;

	private UILeaderBoardItemNewController m_SelfRankUI;

	private bool m_HasInitExpandLeaderBoard;

	private bool m_LeaderBoardExpand;

	private List<ulong> m_CurrentTop3AccountIds;

	private uint m_RankUpDelayCall;

	private List<LeaderBoardInfo> m_LeaderBoardDatas;

	private bool m_HasRefreshExpandLeaderBoard;

	private List<ResourceID> m_PrimeRankingAnimationResourceIDs;

	private UINewDownloadInfoController m_FirstDownloadCtrl;

	private UINewDownloadInfoController m_SecondDownloadCtrl;

	private UINewDownloadInfoController m_ThirdDownloadCtrl;

	private GameObject m_GoMixCamera;

	private bool showDoNotUseBtn;

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

	protected override void OnVisibilityChanged()
	{
	}

	private void OnExpandLeaderBoardBtnClick()
	{
	}

	private void OnCloseLeaderBoardBtnClick()
	{
	}

	private void InitExpandLeaderBoard()
	{
	}

	private void RefreshLeaderBoard()
	{
	}

	public int GetPrimePointsByCurrentFilter(LeaderBoardInfo info)
	{
		return 0;
	}

	public UILeaderBoardItemNewController.DisplayType GetDisplayTypeByFilter()
	{
		return UILeaderBoardItemNewController.DisplayType.PersonKills;
	}

	public LeaderBoardIDV2.EBoardType GetEBoardTypeByFilter()
	{
		return LeaderBoardIDV2.EBoardType.None;
	}

	public ELeaderboard.LeaderboardMainType GetLeaderBoardMainTypeByFilter()
	{
		return ELeaderboard.LeaderboardMainType.Leaderboard_REGULAR;
	}

	private void RequestCurrentSelectedLeaderBoard()
	{
	}

	private void BeforeRequestData(int propID, uint boardV2ID = 0u)
	{
	}

	private void SetItemBGInfo(UILeaderBoardItemNewController ctrl)
	{
	}

	private void HideTop3Preview()
	{
	}

	private void SetPreviewVisible(int place, bool visible)
	{
	}

	private void ShowTop3Preview()
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

	private void Update()
	{
	}

	public bool IsLeaderBoardExpand()
	{
		return false;
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

	private List<ResourceID> GetNeedDownloadPrimeRankingResources()
	{
		return null;
	}

	private void InitPrimeRankingDownloadButton()
	{
	}

	public void HideAllDownloadButton()
	{
	}

	private void ConfigureDownloadController(UINewDownloadInfoController downloadCtrl, List<ResourceID> needDownloadResources)
	{
	}

	private bool ArePrimeRankingAnimationsReady()
	{
		return false;
	}

	private void TryShowPreviewAvatar()
	{
	}

	public void ShowLoading(int place, bool show)
	{
	}

	private void HideAllLoading()
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

	private void ChangeAvatarMaterial(UIMaleAvatar MaleAvatar)
	{
	}

	private void ApplyFresnelMaterial(UMAData umaData)
	{
	}

	private void OnTabChanged(object[] param)
	{
	}

	private void InitTopRight()
	{
	}

	private void InitDoNotUseBtn()
	{
	}

	private void InitPopMenu()
	{
	}

	private void GenerateFriendPopMenuData()
	{
	}

	private void GenerateTimePopMenuData()
	{
	}

	private void GenerateLeaderBoardTimePopMenuData()
	{
	}

	private void OnFriendPopMenuSelect(object data)
	{
	}

	private void OnTimePopMenuSelect(object data)
	{
	}

	private void OnLeaderBoardTimePopMenuSelect(object data)
	{
	}

	private void UpdateLeaderBoardScoreLabel()
	{
	}

	private void OnDoNotUseBtnChanged()
	{
	}

	private void RefreshFriendLeaderboardEmpty()
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

	private void CheckAndShowRankUpOrEnterLeaderboardNotice()
	{
	}

	private void ShowReachTopNotice(LeaderBoardInfo selfRankData)
	{
	}

	private void OnReachTopContinueBtnClick()
	{
	}

	private void ShowRankUpNotice(uint beforeRank, uint afterRank)
	{
	}

	private void ShowEnterLeaderBoardNotice(uint rank)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void _003CInitExpandLeaderBoard_003Eb__45_0()
	{
	}

	private void _003CInitExpandLeaderBoard_003Eb__45_1()
	{
	}

	private void _003CShowRankUpNotice_003Eb__101_0()
	{
	}

	private void _003CShowEnterLeaderBoardNotice_003Eb__102_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
