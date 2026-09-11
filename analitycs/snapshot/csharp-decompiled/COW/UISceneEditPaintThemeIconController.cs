using System;
using System.Collections.Generic;
using COW.GamePlay;
using COW.Gameplay.UGC;
using GCommon;

namespace COW;

public class UISceneEditPaintThemeIconController : UIBaseController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<int> _003C_003E9__20_0;

		internal void _003CRefreshOptionalMapResDownloader_003Eb__20_0(int codeOfLoadingCustomRes)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public UISceneEditPaintThemeIconController _003C_003E4__this;

		public List<ResourceID> remainIds;

		internal void _003CRefreshOptionalMapResDownloader_003Eb__1()
		{
		}

		internal void _003CRefreshOptionalMapResDownloader_003Eb__2()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public UGCCustomLevelObjectEditorPackageInfo packageInfo;

		internal bool _003CCollectNecessaryOptionalRes_003Eb__0(UGCCustomLevelObjectEditorPackageInfo p)
		{
			return false;
		}
	}

	private SceneEditPaintTool mPaintTool;

	private UIModelOptionalDownload m_ModelDownload;

	private UINewDownloadInfoController m_OptionalResDownloader;

	private bool m_NeedCheckAutoDownload;

	private bool m_NeedCheckAutoDownloadForDownloadTask;

	private UISceneEditPaintThemeIconView m_View;

	private int m_id;

	private List<ResourceID> m_NecessaryResOfPfbs;

	private List<UGCCustomLevelObjectEditorPackageInfo> m_CustomPackageList;

	private UGCSimpleDownloadTask m_DownloadTask;

	private bool m_HaveAdjustCollider;

	private SceneEditPaintTool PaintTool => null;

	public int ID => 0;

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

	public void SetViewData(UGCAI_Procedural_ThemeInfo info)
	{
	}

	public void SetViewData(UGCAI_Procedural_Racing_Info info)
	{
	}

	public bool RefreshOptionalMapResDownloader()
	{
		return false;
	}

	private void CollectNecessaryOptionalRes()
	{
	}

	public bool StartDownloadIfNeeded()
	{
		return false;
	}

	public void OnUGCResDownloaderClick(List<ResourceID> resList, bool auto = false)
	{
	}

	private void OnUGCResDownloaderClickForCustomLevelObject(bool auto = false)
	{
	}

	public bool IsDownloading(bool forceUpdate = false)
	{
		return false;
	}

	private void OnThemeSelect()
	{
	}

	public void OnItemBtnSelect()
	{
	}

	public void OnItemBtnUnSelect()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void _003CSetViewData_003Eb__14_0()
	{
	}

	private void _003CSetViewData_003Eb__15_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
