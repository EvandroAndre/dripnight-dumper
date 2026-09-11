using System.Collections.Generic;
using GCommon;

namespace COW;

public class UILobbyVehicleDisplayItemController : UIEasyListItemController, IUIModelDataChangeObserver
{
	private UILobbyVehicleDisplayItemView m_View;

	private UIModelVehicleDisplay m_Model;

	private UIModelOptionalDownload m_optionalDownloadModel;

	private VehicleSkinBaseInfo m_Info;

	private UINewDownloadInfoController m_Downloader;

	private List<ResourceID> m_NeedDownloadList;

	private bool m_LastAbReadyState;

	private bool m_LastIconAbReadyState;

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

	private void OnButtonClicked()
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	private void RemoveVehicle(object[] data)
	{
	}

	private void ChangeVehicle(object[] data)
	{
	}

	private void _003CSetViewData_003Eb__10_0()
	{
	}

	private void _003CChangeVehicle_003Eb__19_0()
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
