using System.Collections.Generic;
using GCommon;

namespace COW;

public class UILobbyWeaponRackItemController : UIEasyListItemController, IUIModelDataChangeObserver
{
	private UILobbyWeaponRackItemView m_View;

	private WeaponItemData m_Itemdata;

	private bool m_ABReady;

	private List<ResourceID> m_NeedDownloadList;

	private UINewDownloadInfoController m_Downloader;

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

	private void SetQualityBG(uint Quality)
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

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void _003CSetViewData_003Eb__8_2()
	{
	}

	private void _003CSetViewData_003Eb__8_1()
	{
	}

	private bool _003CSetViewData_003Eb__8_0(uint x)
	{
		return false;
	}

	private bool _003COnDataChanged_003Eb__14_0(uint x)
	{
		return false;
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
