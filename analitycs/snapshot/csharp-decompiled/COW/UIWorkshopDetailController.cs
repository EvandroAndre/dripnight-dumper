using System;
using System.Collections.Generic;
using COW.Gameplay.UGC;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIWorkshopDetailController : UIPopupWindowController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<WorkshopCommentTag> _003C_003E9__106_0;

		internal int _003CRefreshComments_003Eb__106_0(WorkshopCommentTag a, WorkshopCommentTag b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass107_0
	{
		public UIWorkshopDetailController _003C_003E4__this;

		public UGCMapLabelConfig mapLabelConfig;

		public UGCCreatorLabelConfig authorLabelConfig;

		internal void _003CRefreshKolMap_003Eb__0()
		{
		}

		internal void _003CRefreshKolMap_003Eb__1()
		{
		}
	}

	public const uint BanRoomTagID = 84u;

	private UIWorkshopDetailView m_View;

	private UIModelSceneEdit m_Model;

	private UIModelOptionalDownload m_ModelDownload;

	private UIModelGroup m_GroupModel;

	private UIModelMapOpeningInfo m_MapModel;

	private SceneEditSlotInfo m_Info;

	private string m_Code;

	private Vector3 m_FirstPos;

	private Vector3 m_SecondPos;

	private List<UIWorkshopModeTagController> m_Tags;

	private List<UIWorkshopTagCommentController> m_Comments;

	private bool m_CanBeSub;

	private bool m_CanQuickJoin;

	private bool m_UGCCommentOpen;

	private UIUGCHotIndicatorController m_IndicatorController;

	private UIUGCLikeIndicatorController m_LikeCtrl;

	private UIWorkshopTipBubbleController m_ShareGuideCtrl;

	private UIUGCCreatorLevelIconController m_CreatorLevelIconCtrl;

	private float m_CountDownTime;

	private EUGCScene m_Scene;

	private EUGCWndFrom m_WndFrom;

	private UINewDownloadInfoController m_OptionalMapResDownloader;

	private bool m_IsSmallSizeResAutoDownloadStarted;

	private bool m_TurnOnTranslation;

	private bool m_TranslationFailed;

	private bool m_TranslationEventLogSent;

	private string m_SurveyUrl;

	private uint m_SurveyClickNum;

	private UGCSimpleDownloadTask m_ResDownloadTask;

	private EDownloadShowState m_PreState;

	private bool m_ForbidCreateRoom;

	private bool m_NeedOfflineModeUpdate;

	private bool m_NeedCheckDismiss;

	private EOpenWorkshopDetailFrom m_WorkshopDetailWndFrom;

	private int m_WorkshopDetailWndTab;

	private EditorConnectionMode m_EditorConnectionMode;

	private bool ForbidCreateRoom
	{
		set
		{
		}
	}

	public EOpenWorkshopDetailFrom WorkshopDetailWndFrom
	{
		get
		{
			return EOpenWorkshopDetailFrom.None;
		}
		set
		{
		}
	}

	public int WorkshopDetailWndTab
	{
		get
		{
			return 0;
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

	protected override void OnUIOpen()
	{
	}

	public void DelayCallClose(object[] data)
	{
	}

	private void OnGroupChangeNtf(object[] data)
	{
	}

	private void OnGroupDismissNtf(object[] data)
	{
	}

	public void Update()
	{
	}

	private bool CanUpdateCountDown()
	{
		return false;
	}

	private void UpdateCreateRoomBtn()
	{
	}

	private void UpdateQuickJoinBtn()
	{
	}

	private void UpdatePreviewAndMatchBtn()
	{
	}

	private void UpdateCommentUI()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	protected override void OnUIClose()
	{
	}

	public override int GlassDelay()
	{
		return 0;
	}

	public void SetUIDataBySceneEditSlotInfo(SceneEditSlotInfo info, EUGCScene scene, EUGCWndFrom wndFrom, EditorConnectionMode editorConnectionMode)
	{
	}

	private void RefreshMapInfo()
	{
	}

	public void SetUIDataBySceneEditSlotInfo(SceneEditSlotInfo info, EUGCWndFrom wndFrom)
	{
	}

	private void ShowShareGuide()
	{
	}

	private void SetShowRankButtonVisible(bool visible)
	{
	}

	private void OnSurveyBtnClick()
	{
	}

	private void PopCreateRoomWindow()
	{
	}

	private void OnCopyWorkshopCodeClick()
	{
	}

	private void OnSubscribeClick()
	{
	}

	private void ShowConfirmWindow()
	{
	}

	private void OnOkBtnClick()
	{
	}

	private void OnCancelBtnClick()
	{
	}

	private void OnBtnShareClick()
	{
	}

	private void OnReportClick()
	{
	}

	private void OnQuickJoinClick()
	{
	}

	private void OnCreateRoomClick()
	{
	}

	private void OnBtnPreviewClick()
	{
	}

	private void OnFullScreenClick()
	{
	}

	private void OnAuthorNameClick()
	{
	}

	private void OpenAuthorProfile()
	{
	}

	private void OnAddCommentClick()
	{
	}

	private void SetTranslationState(bool enable)
	{
	}

	private void OnBtnTranslateClick()
	{
	}

	private void OnBtnSoloPlayClick(bool autoLeaveGroup = false)
	{
	}

	private void CopyToClipBoard(string code)
	{
	}

	private void UpdateSubscribeState()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void RefreshBottomIcon()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void RefreshQuickJoinState()
	{
	}

	public void OnBtnSelectMapClick()
	{
	}

	private bool RefreshOptionalMapResDownloader(bool showDownloadPop = false)
	{
		return false;
	}

	public bool CheckResourceInfoStateReady(EUGCMapResourceInfoState resInfoState)
	{
		return false;
	}

	private void RefreshBtns()
	{
	}

	private void ShowDownload()
	{
	}

	private void HideDownload()
	{
	}

	private void OnUGCResDownloaderClick()
	{
	}

	private void OnMaskClick()
	{
	}

	private void OnMaskBtnClick()
	{
	}

	private void OnCrownBtnClick()
	{
	}

	private void OnBtnCloseClick()
	{
	}

	private bool ShouldNavigateToUGCCenterFromClipboard()
	{
		return false;
	}

	private void OnShowLeaderboardBtnClick()
	{
	}

	public bool OpenLeaderboard(int index)
	{
		return false;
	}

	private bool NeedSkipTag(string tagKey)
	{
		return false;
	}

	private void RefreshTags(uint[] tagsInfo, uint[] limitTagsInfo)
	{
	}

	private void RefreshLabelTag()
	{
	}

	private void RefreshComments()
	{
	}

	private void RefreshKolMap()
	{
	}

	private void RefreshCreatorLevelIcon()
	{
	}

	private void OnForbidCreateRoom()
	{
	}

	public static bool ContainRoomBanTag(uint[] taginfo)
	{
		return false;
	}

	private void ShowTip(string key)
	{
	}

	private void RefreshLabelWorkshopName()
	{
	}

	private void RefreshLabelDesc()
	{
	}

	private void CheckTranslationFailed()
	{
	}

	private void SendTranslationEventLog()
	{
	}

	private void RefreshBtnTranslate()
	{
	}

	private void ShowPlayBtns(bool show)
	{
	}

	public void SetIsBlockRoom(bool isBlockRoom)
	{
	}

	public void SetEditorConnectionMode(EditorConnectionMode editorConnectionMode)
	{
	}

	public void SetOfflineUIDataBySceneEditSlotInfo(SceneEditSlotInfo info, EUGCWndFrom wndFrom, EditorConnectionMode editorConnectionMode)
	{
	}

	private void RefreshOfflineBtns()
	{
	}

	private void RefreshOfflineDesc(bool needToDownload = false)
	{
	}

	private void PlayOffline()
	{
	}

	private void UpdateOfflineDownload()
	{
	}

	private void UpdatePartialOfflineMetaData()
	{
	}

	private void _003COnUIInit_003Eb__37_0()
	{
	}

	private void _003COnUIInit_003Eb__37_1()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public int _003C_003EiFixBaseProxy_GlassDelay()
	{
		return 0;
	}
}
