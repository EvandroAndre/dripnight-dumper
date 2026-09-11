using System.Collections.Generic;
using GCommon;

namespace COW;

public class UILobbySkyboardDisplayItemController : UIEasyListItemController, IUIModelDataChangeObserver
{
	private UILobbySkyboardDisplayItemView m_View;

	private UIModelSkyboardDisplay m_Model;

	private UIModelOptionalDownload m_OptionalDownloadModel;

	private SkyboardBaseInfo m_skyboardInfo;

	private UINewDownloadInfoController m_Downloader;

	private List<ResourceID> m_NeedDownloadList;

	private bool m_LastABReady;

	private bool m_LastIconAbReady;

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

	public override void SetViewData(object data, int data_index)
	{
	}

	private void RefreshDownloadState(bool isAbReady)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void SetQualityBG(uint quality)
	{
	}

	private void RemoveSkyboard(object[] data)
	{
	}

	private void ChangeSkyboard(object[] data)
	{
	}

	private void OnButtonItemClicked()
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	private void _003CSetViewData_003Eb__11_0()
	{
	}

	private void _003CChangeSkyboard_003Eb__17_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
