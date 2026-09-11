using System;
using GCommon;

namespace COW;

public class UIRelayMartDiscountCodeGetItemController : UIEasyListItemController
{
	private UIRelayMartDiscountCodeGetItemView m_View;

	private UIModelRelayMart m_ModelRelayMart;

	private UIRelayMartDiscountCodeGetItemData m_Data;

	private string m_DiscountCode;

	private UIModelFriends m_ModelFriends;

	private ulong m_OwnerID;

	private UIRelayMartDiscountCodeGetController m_ParentCtrl;

	public Action InviteCallback;

	private UIRelayMartDiscountCodeGetController ParentCtrl => null;

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

	public void RefreshFriendState()
	{
	}

	private void RefreshItemView()
	{
	}

	private void OnUseBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
