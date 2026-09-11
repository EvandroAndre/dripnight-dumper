using GCommon;
using UnityEngine;

namespace COW;

public class UISPReplayListController : UINavigationController, IUIModelDataChangeObserver, IEasyList
{
	private UISPReplayListView m_View;

	private UIModelReplay m_Model;

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

	private void OnInputChanged()
	{
	}

	private void OnBtnInputClear()
	{
	}

	private void OnBtnRoomSearch()
	{
	}

	public void RefreshUI()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
