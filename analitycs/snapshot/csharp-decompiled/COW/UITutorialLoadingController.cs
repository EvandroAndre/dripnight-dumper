using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UITutorialLoadingController : UIBaseController, IUIModelDataChangeObserver
{
	public enum ETutorialLoadingFailType
	{
		Success,
		DownloadInfoNull,
		DownloadTimeOut,
		DownloadError,
		Max
	}

	private UITutorialLoadingView m_View;

	private List<TutorialLoadingCDNInfo> m_TutorialLoadingCdnInfos;

	private List<UITutorialLoadingItemController> m_LoadingItemControllers;

	private uint m_AutoScrollDelayCallID;

	private int m_LastIndex;

	private Vector2 m_Size;

	private UIModelOptionalDownload m_Model;

	private UIModelForceTutorial m_ModelForceTutorial;

	private float m_Time;

	private Action m_LoadAction;

	private Action m_FailAction;

	private const uint DOWNLOAD_TAGID = 9999u;

	private int m_TutorialLoadingFailType;

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

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void InitCdnInfos()
	{
	}

	private void ProcessCDNUrlData()
	{
	}

	public void SetViewData()
	{
	}

	private void SetPanelSize()
	{
	}

	private void OnAutoScrollHLItem()
	{
	}

	private void GetCenterItem(GameObject centerGo)
	{
	}

	private void SetDefaultCdn()
	{
	}

	private void GetOptioanlDownload()
	{
	}

	private void Update()
	{
	}

	private void SetProcessForceTutorialFlag()
	{
	}

	private void OnTutorialGameDownLoadFinish()
	{
	}

	public void SetCallBackAction(Action loadAction, Action failAction)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
