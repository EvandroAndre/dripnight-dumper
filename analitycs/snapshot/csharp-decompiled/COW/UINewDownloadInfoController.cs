using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UINewDownloadInfoController : UIBaseController, IUIModelDataChangeObserver
{
	private UINewDownloadInfoView m_View;

	private Action m_Callback1;

	private Action m_Callback2;

	private DownloadShowStyle m_style;

	private EDownloadShowState m_DownloadState;

	public Action DownloadStateChangeCallback;

	public Action DownLoadStateChangeToNotDownLoading;

	private List<ResourceID> m_downloadlist;

	private bool m_NeedShowAll;

	private bool m_NeedShowCommon;

	private ResDownloadType m_DownloadType;

	private bool m_OnlyShowIcon;

	private bool m_NotShowDownloadTxt;

	private List<ResVersionInfo.FileInfo> m_NeedDownloadFileInfoList;

	private uint m_MapConfig;

	private const string PRECENT = "{0} %";

	private bool m_HasBranchGroup;

	private uint m_itemid;

	private DownloadInfoSpecific m_downloadinfo;

	private string m_CustomStyle1PreDownloadTxt;

	private string m_DownloadingTxt;

	private bool m_IsInGame;

	public void RefreshItemId(uint id, DownloadInfoSpecific downloadInfo)
	{
	}

	public DownloadInfoSpecific GetDownloadInfo()
	{
		return null;
	}

	public uint GetItemId()
	{
		return 0u;
	}

	public void RefreshMainGroup(bool flag)
	{
	}

	public void ActiveStyle1DownloadBg()
	{
	}

	public void RefreshBranchGroup(bool flag)
	{
	}

	public bool GetMainGroupVisble()
	{
		return false;
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	public EDownloadShowState GetDownloadState(bool forceUpdate = false)
	{
		return EDownloadShowState.None;
	}

	void IUIModelDataChangeObserver.OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	uint IUIModelDataChangeObserver.GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	protected override void OnUIInit()
	{
	}

	private void OnDownloadALL()
	{
	}

	private void UpdateDownloadState()
	{
	}

	private void OnDownloadStateChange()
	{
	}

	public void SetDownLoadStateChangeToNotDownLoading(Action action)
	{
	}

	private void OnDownloadStateChangeToNotDownLoading()
	{
	}

	public void SetDownloadTxtColor(Color color)
	{
	}

	public void SetStyle1DownloadIconDepth(int depth)
	{
	}

	public void RefreshDownloadStyle1AlphaAndScale(float alpha, float scale)
	{
	}

	private void UpdateUIDownloadStyle1()
	{
	}

	private void UpdateUIDownloadStyle2()
	{
	}

	public void SetHotFixDownloadBtn8Pos(Vector3 pos)
	{
	}

	public void SetDownloadIcon8Pos(Vector3 pos)
	{
	}

	public void SetDownloadTxt8Pos(Vector3 pos)
	{
	}

	public void SetDownloadIcon1Pos(Vector3 pos)
	{
	}

	public void SetDownloadIcon6Pos(Vector3 pos)
	{
	}

	public void SetDownloadIconing1Pos(Vector3 pos)
	{
	}

	public void ShowNewNodeEffect(bool show)
	{
	}

	public void ShowDownloadBg1(bool show)
	{
	}

	public void HideHotFixDownloadTxt4()
	{
	}

	private void UpdateUIDownloadStyle4()
	{
	}

	private void UpdateUIDownloadStyle5()
	{
	}

	private void UpdateUIDownloadStyle3()
	{
	}

	private void UpdateUIDownloadStyle6()
	{
	}

	private void UpdateUIDownloadStyle7()
	{
	}

	private void UpdateUIDownloadStyle8()
	{
	}

	private void OnDownload()
	{
	}

	public void OnDownloadExternal()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetHasBranchInfo(bool flag)
	{
	}

	public void RefreshAllDownloadDataInfo(DownloadShowAllInfo info)
	{
	}

	public void RefreshCommonDownloadDataInfo(DownloadShowInfo info)
	{
	}

	public void DisAbleStyleBoxSize()
	{
	}

	public void SetStyleBoxSize(int sizeX, int sizeY, int depth = 0, bool enableBoxCollider = true)
	{
	}

	public void SetBoxColliderRegion(Vector3 center, Vector3 size)
	{
	}

	private UIButton TryGetDownloadBtn()
	{
		return null;
	}

	public void AttachDragScrollViewOnDownloadBtn(UIScrollView targetScrollView)
	{
	}

	private void Update()
	{
	}

	public void Download()
	{
	}

	public string GetDownloadingProcessText()
	{
		return null;
	}

	public float GetCurrentDownloadSize(out float remainDownloadSize, out long totalNeedDownloadSize)
	{
		remainDownloadSize = default(float);
		totalNeedDownloadSize = default(long);
		return 0f;
	}

	public void SetMainGroupRoate(Vector3 roate)
	{
	}

	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
