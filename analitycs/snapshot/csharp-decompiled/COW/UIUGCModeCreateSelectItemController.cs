using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIUGCModeCreateSelectItemController : UIUGCCreateSelectItemController, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public UIUGCModeCreateSelectItemController _003C_003E4__this;

		public List<ResourceID> remainIds;

		internal void _003CRefreshOptionalMapResDownloader_003Eb__0()
		{
		}
	}

	private WorkshopCreateNewConfigData m_ConfigData;

	private bool m_NeedCheckAutoDownload;

	private UIModelOptionalDownload m_ModelDownload;

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

	private void _003CSetViewData_003Eb__5_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
