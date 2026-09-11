using System;
using System.Collections.Generic;
using COW.Gameplay.UGC;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIUGCMyWorksV2Controller : UIBaseController, IEasyList, IUIModelDataChangeObserver
{
	public class SlotDisplayData
	{
		public UIUGCMyWorksSlotItemController.ESpecialSlot SpecialSlot;

		public SceneEditSlotInfo SlotInfo;

		public SlotDisplayData(SceneEditSlotInfo slotInfo, UIUGCMyWorksSlotItemController.ESpecialSlot specialSlot = UIUGCMyWorksSlotItemController.ESpecialSlot.None)
		{
		}
	}

	private enum EInspectorType
	{
		OnlineData,
		LocalEdit
	}

	private enum EmapTipIcon
	{
		Warning,
		Error,
		Clock
	}

	private enum ETopMapTipType
	{
		None,
		MapBug,
		CoverAuditFailed,
		ExpiringCountdown
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<SceneEditSlotInfo> _003C_003E9__99_0;

		public static Comparison<SceneEditSlotInfo> _003C_003E9__99_1;

		public static Action _003C_003E9__107_0;

		internal int _003CRefreshSlotList_003Eb__99_0(SceneEditSlotInfo a, SceneEditSlotInfo b)
		{
			return 0;
		}

		internal int _003CRefreshSlotList_003Eb__99_1(SceneEditSlotInfo a, SceneEditSlotInfo b)
		{
			return 0;
		}

		internal void _003COnCreatorLvTipClick_003Eb__107_0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass168_0
	{
		public UIUGCMyWorksV2Controller _003C_003E4__this;

		public UIModelSceneEdit.EWorkshopDelType type;

		public Action callback;

		internal void _003CRequestDelPop_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass185_0
	{
		public UIUGCMyWorksV2Controller _003C_003E4__this;

		public bool isNewPublish;

		internal void _003COpenPublishCheckWindow_003Eb__0(uint slotId, uint serverSlotId, bool isPublish)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass68_0
	{
		public UIUGCMyWorksV2Controller _003C_003E4__this;

		public UGCSimpleDownloadTask resDownloadTask;

		internal void _003CRefreshDownloadTaskOnDownloader_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass69_0
	{
		public UIUGCMyWorksV2Controller _003C_003E4__this;

		public List<ResourceID> remainIds;

		internal void _003CRefreshNecessaryResourcesOnDownloader_003Eb__0()
		{
		}
	}

	private UIUGCMyWorksV2View m_View;

	private UIModelSceneEdit m_ModelSceneEdit;

	private UIModelUGCMyWorks m_ModelUGCMyWorks;

	private UIModelOptionalDownload m_ModelOptionalDownload;

	private UIWaitingForRequestCircleController m_LoadingUI;

	private UIModelCraftlandProfile m_ModelCraftlandProfile;

	private const string m_NewbiePopGuideKey = "NewbiePopGuide";

	private int m_CurrentSlotInfoIndex;

	private uint m_RefreshSlotScrollBoundsDelayCallKey;

	private uint m_RestoreSelectedSlotAfterNavigationDelayCallKey;

	private UIRoomCardListController m_RoomCardCtrl;

	private Transform m_BtnUpdateLogOriginalParent;

	private Vector3 m_BtnUpdateLogOriginalLocalPos;

	private Transform m_BtnGoToCreatorCenterOriginalParent;

	private Vector3 m_BtnGoToCreatorCenterOriginalLocalPos;

	private bool m_ButtonsReparented;

	private bool m_NeedNaviToCreateMap;

	private int m_NaviModeID;

	private int m_NaviMapID;

	private int m_NaviTemplateMap;

	private UINavigationUtil.UINavigationFrom m_NaviFrom;

	private string m_NaviFromInfo;

	private Dictionary<string, UGCResourceForGameData.PackageOrABFileInfo> m_EditResourceBytesFileInfos;

	private List<UGCResInfo> m_EditResInfos;

	private bool m_IsRequestingEditResourceBytes;

	private bool m_HasEditDownloadSlotKey;

	private uint m_EditDownloadSlotId;

	private uint m_EditDownloadServerSlotId;

	private EWorkshop.SlotType m_EditDownloadSlotType;

	private UINewDownloadInfoController m_OptionalEditMapResDownloader;

	private UINewDownloadInfoController m_OptionalCreateNewResDownloader;

	private bool m_NeedCheckEditAutoDownload;

	private bool m_NeedCheckCreateNewAutoDownload;

	private EUGCSlotDisplayType m_CurrentSlotTypeValue;

	private List<SceneEditSlotInfo> m_DraftSlotInfos;

	private List<SceneEditSlotInfo> m_PublishedSlotInfos;

	private List<SlotDisplayData> m_DraftSlotDisplayDatas;

	private List<SlotDisplayData> m_PublishedSlotDisplayDatas;

	private int m_DraftCount;

	private int m_PublishedCount;

	private uint m_CreatorLevel;

	private int m_CreatorLevelUnlockDelta;

	private int m_DraftMinSlotCount;

	private bool m_DraftHasListChanged;

	private bool m_PublishedHasListChanged;

	private EInspectorType m_CurrentInspectorType;

	private ETopMapTipType m_CurrentTopMapTipType;

	private UIClickMask m_ClickMask;

	private Vector3 m_MoveUpOriginalPos;

	private Color m_BtnMoreWhiteLabelColor;

	private Color m_BtnMoreRedLabelColor;

	private Color m_BtnPublishOriginalDefaultColor;

	private Color m_BtnPublishOriginalHover;

	private Color m_BtnEditOriginalDefaultColor;

	private Color m_BtnEditOriginalHover;

	private Color m_BtnPlayOriginalDefaultColor;

	private Color m_BtnPlayOriginalHover;

	private Color m_BtnShareOriginalDefaultColor;

	private Color m_BtnShareOriginalHover;

	private float m_TopMapTipLabelOriginalPosX;

	private int m_TopMapTipLabelOriginalWidth;

	private int m_TopMapTipSpriteOriginalLeftAnchorAbsolute;

	private bool m_TopMapTipLayoutInited;

	private const string m_AnimationInspectorInName = "UIFX_UIUGCMyWorksV2_Right_In";

	private const string m_AnimationInspectorOutName = "UIFX_UIUGCMyWorksV2_Right_Out";

	private uint m_AnimationDelayCallKey;

	private string m_CacheUnpublishTweenTipKey;

	private UIWorkshopTipBubbleController m_ShareGuideCtrl;

	private SceneEditSlotInfo m_CurrentSlotInfo => null;

	private EUGCSlotDisplayType m_CurrentSlotType
	{
		get
		{
			return EUGCSlotDisplayType.Draft;
		}
		set
		{
		}
	}

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

	private void RequestRefreshSlotScrollBoundsOnce()
	{
	}

	private void RefreshSlotScrollBounds()
	{
	}

	private void OnBtnCreateMapClickForTutorial()
	{
	}

	private void RefreshSlotListAndResetDisplay(uint selectedSlotId = 0u, uint selectedServerSlotId = 0u, bool allowEmptyPublishedSlot = false)
	{
	}

	private void RefreshSelectedSlot()
	{
	}

	private void RefreshSelectedSlot(uint selectedSlotId, uint selectedServerSlotId, bool allowEmptyPublishedSlot, bool processRequestedSlot)
	{
	}

	public void StoreBeforeClose()
	{
	}

	public void CacheSelectedSlotBeforeNavigation()
	{
	}

	public void RestoreSelectedSlotAfterNavigation()
	{
	}

	public void BindRoomCardController(UIRoomCardListController roomCardCtrl)
	{
	}

	private void ReorderButtonsInTable()
	{
	}

	public void SetButtonsVisible(bool visible)
	{
	}

	private void RestoreButtons()
	{
	}

	public void SetNavigationParams(int mode, int map, int template, UINavigationUtil.UINavigationFrom from, string fromInfo)
	{
	}

	private void NavigationToCreateMap()
	{
	}

	private void RefreshOptionalMapResDownloaders()
	{
	}

	public bool RefreshEditOptionalMapResDownloader(bool showDownloadPop = false)
	{
		return false;
	}

	private bool CompleteEditOptionalMapResDownloaderRefresh(bool result, bool wasMapTipBlocked)
	{
		return false;
	}

	private bool IsEditDownloadMapTipActive()
	{
		return false;
	}

	public bool RefreshCreateNewOptionalMapResDownloader(bool showDownloadPop = false)
	{
		return false;
	}

	private bool RefreshCreateNewOptionalMapResDownloader(bool showDownloadPop, bool useTutorialTask)
	{
		return false;
	}

	private bool CheckEditOptionalDownload()
	{
		return false;
	}

	private bool CheckCreateNewOptionalDownload(bool useTutorialTask)
	{
		return false;
	}

	private SceneEditSlotInfo GetResolvedCurrentEditSlotInfo()
	{
		return null;
	}

	private bool CanCheckEditMapResources(SceneEditSlotInfo info)
	{
		return false;
	}

	private bool ShouldCheckEditNecessaryResources(SceneEditSlotInfo info)
	{
		return false;
	}

	private void EnsureEditDownloadCacheForSlot(SceneEditSlotInfo info)
	{
	}

	private void ResetEditDownloadCache()
	{
	}

	private bool TryBuildCreateNewTutorialDownloadTask(out UGCSimpleDownloadTask resDownloadTask)
	{
		resDownloadTask = null;
		return false;
	}

	private bool RefreshDownloadTaskOnDownloader(UINewDownloadInfoController downloader, UGCSimpleDownloadTask resDownloadTask, bool showDownloadPop, ref bool needCheckAutoDownload)
	{
		return false;
	}

	private bool RefreshNecessaryResourcesOnDownloader(UINewDownloadInfoController downloader, bool showDownloadPop, ref bool needCheckAutoDownload)
	{
		return false;
	}

	private UINewDownloadInfoController GetEditMapResDownloader()
	{
		return null;
	}

	private UINewDownloadInfoController GetCreateNewMapResDownloader()
	{
		return null;
	}

	private void RefreshDownloadMainGroup(UINewDownloadInfoController downloader, bool visible)
	{
	}

	private void OnUGCResDownloaderClick(List<ResourceID> resList)
	{
	}

	private void OnUGCResDownloaderTaskClick(UGCSimpleDownloadTask resDownloadTask, bool autoDownload = false)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private bool ShouldShowRedPoint(EUGCSlotDisplayType slotType)
	{
		return false;
	}

	private void RefreshRedPoints()
	{
	}

	private void MarkListChange(EUGCSlotDisplayType slotType)
	{
	}

	private bool IsTutorialSlot(SceneEditSlotInfo slotInfo)
	{
		return false;
	}

	private void SetLocalSlotTutorialFlag(SceneEditSlotInfo slotInfo, bool isTutorial)
	{
	}

	private SceneEditSlotInfo GetSlotInfoFromDisplayData(object data)
	{
		return null;
	}

	private bool ShouldShowUnlockPublishedSlot()
	{
		return false;
	}

	private void RefreshSlotList(bool init = false)
	{
	}

	private void RefreshSlotDisplay()
	{
	}

	private void RefreshCreatorLevelSlotData(bool isDraft)
	{
	}

	private bool TryGetRealNextCreatorLevelInfo(out WorkShopCreatorLevel currentLevelInfo, out WorkShopCreatorLevel nextLevelInfo)
	{
		currentLevelInfo = null;
		nextLevelInfo = null;
		return false;
	}

	UIEasyListItemController IEasyList.OpenItemController(Transform parent)
	{
		return null;
	}

	void IEasyList.CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void OnBtnDraftClick()
	{
	}

	private void OnBtnPublishedClick()
	{
	}

	private void OnCreatorLvTipClick()
	{
	}

	private void OnBtnUpdateLogClick()
	{
	}

	private void GotoCreatorCenter()
	{
	}

	private void GotoCreatorCenterByTabName(string tabName, int subType)
	{
	}

	private void OnUIInitRightDisplay()
	{
	}

	private void RefreshRightDisplay()
	{
	}

	private void OnBtnOnlineDataClick()
	{
	}

	private void OnBtnLocalEditClick()
	{
	}

	private void OnBtnCreateMapClick()
	{
	}

	private bool CheckNewbiePopGuideLevel()
	{
		return false;
	}

	private void OnBtnMoreClick()
	{
	}

	private void OnBtnSaveAsClick()
	{
	}

	private void OnLobbySaveAsComplete(bool success, uint destSlotId)
	{
	}

	private void OnBtnUnpublishClick()
	{
	}

	private void OnBtnDeleteClick()
	{
	}

	private void OnBtnResetClick()
	{
	}

	private void OnBtnExpiringCountdownClick()
	{
	}

	private void HideTopMapTip()
	{
	}

	private void SetTopMapTip(ETopMapTipType tipType, string tipText)
	{
	}

	private void CaptureTopMapTipLayout()
	{
	}

	private void RefreshTopMapTipLayout(bool showExpiringIcon)
	{
	}

	private void RestoreTopMapTipLayout()
	{
	}

	private bool HasMapBugTip()
	{
		return false;
	}

	private void RefreshMapBugTopMapTip()
	{
	}

	private void RefreshCoverAuditFailedTopMapTip()
	{
	}

	private bool HasCoverAuditFailedTip()
	{
		return false;
	}

	private int GetExpiringCountdownDay()
	{
		return 0;
	}

	private void RefreshTopMapTip()
	{
	}

	private void SetButtonGray(UIButton button, bool gray, Color originalDefaultColor, Color originalHover)
	{
	}

	private bool IsCurrentSlotExpired()
	{
		return false;
	}

	private void RefreshBtnPublish()
	{
	}

	private void RefreshBtnEdit()
	{
	}

	private void RefreshBtnPlay()
	{
	}

	private void RefreshBtnShare()
	{
	}

	private bool HasLocalCoverEdited(SceneEditSlotInfo slotInfo)
	{
		return false;
	}

	private void SetMapTipIcon(EmapTipIcon icon)
	{
	}

	private void RequestDelPop(UIModelSceneEdit.EWorkshopDelType type, Action callback = null)
	{
	}

	private void RefreshOnlineDataDisplay()
	{
	}

	private void OnBtnNotCrossRegionClick()
	{
	}

	private string GetMapTipLocKey(string normalKey, string feKey)
	{
		return null;
	}

	private void RefreshOnlineDataMapTip()
	{
	}

	private void RefreshRankDisplay()
	{
	}

	private void OnBtnBanDetailClick()
	{
	}

	private void OnBtnShareClick()
	{
	}

	private void OnBtnPlayClick()
	{
	}

	private void OnBtnRankTipClick()
	{
	}

	private void OnBtnStatisticalDetailsClick()
	{
	}

	private void OnBtnVisitDatabaseClick()
	{
	}

	private void RefreshLocalEditDisplay()
	{
	}

	private void RefreshLocalEditMapTip()
	{
	}

	private void OnBtnEditClick()
	{
	}

	private void OnBtnPublishClick()
	{
	}

	private void OpenPublishCheckWindow(SceneEditSlotInfo slotInfo)
	{
	}

	private void TryOpenPendingPublishCheck()
	{
	}

	private void _003CRequestRefreshSlotScrollBoundsOnce_003Eb__16_0()
	{
	}

	private void _003CRestoreSelectedSlotAfterNavigation_003Eb__24_0()
	{
	}

	private void _003COnBtnOnlineDataClick_003Eb__137_0()
	{
	}

	private void _003COnBtnLocalEditClick_003Eb__138_0()
	{
	}

	private void _003COnBtnMoreClick_003Eb__141_0()
	{
	}

	private void _003COnBtnUnpublishClick_003Eb__145_0()
	{
	}

	private void _003COnBtnResetClick_003Eb__147_0()
	{
	}

	private void _003COnBtnResetClick_003Eb__147_1(bool succeed)
	{
	}

	private void _003COnBtnPlayClick_003Eb__177_0(bool succeed)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
