using System.Collections.Generic;
using COW.Gameplay.UGC;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UIUGCCreateNewWorkshopController : UINavigationController, IUIModelDataChangeObserver
{
	private class UIUGCCreateModeSelectItemEasyList : IEasyList
	{
		private UIUGCCreateNewWorkshopController m_Ctrl;

		public UIUGCCreateModeSelectItemEasyList(UIUGCCreateNewWorkshopController ctrl)
		{
		}

		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		public void CloseItemController(UIEasyListItemController itemController)
		{
		}
	}

	private class UIUGCCreateMapTemplateItemEasyList : IEasyList
	{
		private UIUGCCreateNewWorkshopController m_Ctrl;

		public UIUGCCreateMapTemplateItemEasyList(UIUGCCreateNewWorkshopController ctrl)
		{
		}

		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		public void CloseItemController(UIEasyListItemController itemController)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass38_0
	{
		public UIUGCCreateNewWorkshopController _003C_003E4__this;

		public UGCSimpleDownloadTask downloadTask;

		internal void _003CRefreshTutorialOptionalResDownloader_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass47_0
	{
		public uint mapID;

		internal bool _003COnModeSelected_003Eb__1(WorkshopCreateNewConfigData mapdata)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass48_0
	{
		public UIUGCCreateNewWorkshopController _003C_003E4__this;

		public WorkshopTemplateConfigDesc templateConfig;

		internal void _003COnTemplateSelected_003Eb__0()
		{
		}

		internal void _003COnTemplateSelected_003Eb__1()
		{
		}

		internal void _003COnTemplateSelected_003Eb__2()
		{
		}

		internal void _003COnTemplateSelected_003Eb__3()
		{
		}

		internal void _003COnTemplateSelected_003Eb__4(WorkshopBasicInfo info)
		{
		}
	}

	private UIUGCCreateNewWorkshopView m_View;

	private UIWaitingForRequestController m_WaitforReqCtrl;

	private UIUGCBigMapAreaController m_BigMapAreaCtrl;

	private UIUGCCreateMapSelectItemController m_LastSelectedMapCtrl;

	private List<UIUGCCreateMapSelectItemController> m_MapCtrlCache;

	private IEasyList m_ModeEasyList;

	private IEasyList m_TemplateEasyList;

	private List<WorkshopCreateNewConfigData> m_ModeList;

	private List<WorkshopTemplateConfigDesc> m_TemplateList;

	private List<WorkshopCreateNewConfigData> m_MapList;

	private List<WorkshopCreateNewConfigData> m_ActiveMapList;

	private uint m_SelecteSlotId;

	private string m_MapName;

	private bool m_MapNameEdited;

	private MapTemplateType m_SelectedType;

	private WorkshopCreateNewConfigData m_CurModeConfig;

	private WorkshopCreateNewConfigData m_CurMapConfig;

	private uint m_SelectedArea;

	private string m_SelectedTemplateCode;

	private SceneEditSlotInfo m_SelectedTemplateInfo;

	private bool m_IsClassicTab;

	private bool m_FirstSelectTab;

	private string m_TutorialUrl;

	private string m_TutorialTitle;

	protected UIModelSceneEdit m_ModelSceneEdit;

	private UIModelOptionalDownload m_ModelOptionalDownload;

	private UINewDownloadInfoController m_TutorialOptionalResDownloader;

	private int m_NaviModeID;

	private int m_NaviMapID;

	private int m_NaviTemplateMap;

	private UINavigationUtil.UINavigationFrom m_NaviFrom;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private bool CheckNewbieGuideLevel()
	{
		return false;
	}

	private void RefreshBeginnerGuideEntry()
	{
	}

	private bool RefreshTutorialOptionalResDownloader(bool showDownloadPop = false)
	{
		return false;
	}

	private bool TryBuildBeginnerGuideDownloadTask(out UGCSimpleDownloadTask downloadTask)
	{
		downloadTask = null;
		return false;
	}

	private UINewDownloadInfoController GetTutorialOptionalResDownloader()
	{
		return null;
	}

	private void RefreshTutorialDownloadMainGroup(bool visible)
	{
	}

	private void OnBtnBeginnerGuideClick()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	private void OnBtnModeClick()
	{
	}

	private void OnBtnTemplateClick()
	{
	}

	public void OnMapSelected(object[] data)
	{
	}

	public void OnModeSelected(object[] data)
	{
	}

	public void OnTemplateSelected(object[] data)
	{
	}

	private void OnGotTemplateInfo(WorkshopBasicInfo info)
	{
	}

	public void OnBtnApplyClick()
	{
	}

	private void OnEnterSceneEditGame()
	{
	}

	private void OnBtnTutorialClick()
	{
	}

	private void OnBtnLimitedClick()
	{
	}

	private void OnGoToRewardButtonClick()
	{
	}

	private void OnUGCResDownloaderClick(UGCSimpleDownloadTask resDownloadTask, bool autoDownload = false)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public override void OnNavigationClosed()
	{
	}

	private void _003COnUIInit_003Eb__34_0()
	{
	}

	private void _003COnUIInit_003Eb__34_2()
	{
	}

	private void _003COnUIInit_003Eb__34_1()
	{
	}

	private void _003COnModeSelected_003Eb__47_0()
	{
	}

	private void _003COnBtnApplyClick_003Eb__50_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}
}
