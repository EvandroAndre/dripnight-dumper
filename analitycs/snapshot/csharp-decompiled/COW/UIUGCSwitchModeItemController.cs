using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIUGCSwitchModeItemController : UIEasyListItemController, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		public UIUGCSwitchModeItemController _003C_003E4__this;

		public List<ResourceID> remainIds;

		internal void _003CRefreshOptionalMapResDownloader_003Eb__0()
		{
		}
	}

	private UIUGCSwitchModeItemView m_View;

	private WorkshopCreateNewConfigData m_ConfigData;

	private UINewDownloadInfoController m_OptionalMapResDownloader;

	private UIModelOptionalDownload m_ModelDownload;

	private bool m_NeedCheckAutoDownload;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	public bool RefreshOptionalMapResDownloader(bool showDownloadPop = false)
	{
		return false;
	}

	private void ShowDownload()
	{
	}

	private void HideDownload()
	{
	}

	private void OnUGCResDownloaderClick(List<ResourceID> resList)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void _003CSetViewData_003Eb__7_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
