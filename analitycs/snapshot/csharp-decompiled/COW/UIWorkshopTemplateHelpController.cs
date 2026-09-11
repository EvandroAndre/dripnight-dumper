using System;
using System.Collections.Generic;
using COW.Gameplay.UGC;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIWorkshopTemplateHelpController : UIPopupWindowController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<WorkshopCommentTag> _003C_003E9__55_0;

		internal int _003CRefreshComments_003Eb__55_0(WorkshopCommentTag a, WorkshopCommentTag b)
		{
			return 0;
		}
	}

	private UIWorkshopTemplateHelpView m_View;

	private UIModelSceneEdit m_Model;

	private UIModelOptionalDownload m_ModelDownload;

	private SceneEditSlotInfo m_Info;

	private string m_Code;

	private Vector3 m_FirstPos;

	private Vector3 m_SecondPos;

	private List<UIWorkshopModeTagController> m_Tags;

	private List<UIWorkshopTagCommentController> m_Comments;

	private bool m_UGCCommentOpen;

	private UIUGCHotIndicatorController m_IndicatorController;

	private EUGCScene m_Scene;

	private EUGCWndFrom m_WndFrom;

	private UINewDownloadInfoController m_OptionalMapResDownloader;

	protected UGCSimpleDownloadTask m_ResDownloadTask;

	private EOpenWorkshopDetailFrom m_WorkshopDetailWndFrom;

	private int m_WorkshopDetailWndTab;

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

	public void DelayCallClose(object[] data)
	{
	}

	private void UpdateCommentUI()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public override int GlassDelay()
	{
		return 0;
	}

	public void SetUIDataBySceneEditSlotInfo(SceneEditSlotInfo info, EUGCScene scene, EUGCWndFrom wndFrom)
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

	private void OnShareClick()
	{
	}

	private void OnReportClick()
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

	private void OnAddCommentClick()
	{
	}

	private void OnBtnSaveClick()
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

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private bool RefreshOptionalMapResDownloader(bool showDownloadPop = false)
	{
		return false;
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

	private void OnCrownBtnClick()
	{
	}

	private void OnBtnCloseClick()
	{
	}

	private void RefreshTags(uint[] tagsInfo, uint gameMode)
	{
	}

	private void RefreshComments()
	{
	}

	private void _003COnUIInit_003Eb__16_0(object[] obj)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public int _003C_003EiFixBaseProxy_GlassDelay()
	{
		return 0;
	}
}
