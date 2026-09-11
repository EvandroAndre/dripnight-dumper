using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIPeriodicRankMapSelectItemController : UIEasyListItemController, IUIModelDataChangeObserver
{
	private UIRankMapSelectItemView m_View;

	private MapOpeningInfo m_Data;

	private UINewDownloadInfoController m_Downloader;

	protected List<ResourceID> m_NeedDownloadRes;

	private UIModelOptionalDownload m_ModelDownload;

	private UIModelMapOpeningInfo m_ModelMap;

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

	public override void SetViewData(object data, int data_index)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void OnSelectedButtonClick()
	{
	}

	private void OnItemButtonClick()
	{
	}

	private void UpdateDownloadList()
	{
	}

	private void RefreshDownloader(object[] data)
	{
	}

	private void MapPanelVisibilityChanged(object[] data)
	{
	}

	private void _003CSetViewData_003Eb__9_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
