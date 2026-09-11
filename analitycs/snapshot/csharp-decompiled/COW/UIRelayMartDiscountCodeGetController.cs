using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIRelayMartDiscountCodeGetController : UIBaseController, IUIModelDataChangeObserver, IEasyList
{
	private UIRelayMartDiscountCodeGetView m_View;

	private UIModelRelayMart m_ModelRelayMart;

	private UIModelFriends m_ModelFriends;

	private ulong m_LastBtnRefreshTime;

	private ulong m_LastOpenRefreshTime;

	private List<UIRelayMartDiscountCodeGetItemData> m_DataList;

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

	private void OnEnable()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void SetKellyCDNData()
	{
	}

	private void SetDiscountCodeListUIData()
	{
	}

	public void OpenGetList()
	{
	}

	private void OnRefreshBtnClick()
	{
	}

	private void OnMaskClick()
	{
	}

	private void UpdateRefreshState(bool inCD = false)
	{
	}

	private void RemoveUnfriendShareItems()
	{
	}

	private void RemoveInvalidDiscountCode(string invalidDiscountCode)
	{
	}

	private void _003COnRefreshBtnClick_003Eb__17_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
