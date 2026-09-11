using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEventFriendCallbackController : UIPopupWindowController, IUIModelDataChangeObserver, IEasyList
{
	private UIBigEventFriendCallbackView m_View;

	private UIModelShare m_ModelShare;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void SetData()
	{
	}

	private void RefreshList(List<FriendAccountInfo> accountList, bool keep_page = false)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void OnInviteButtonClick()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private List<FriendAccountInfo> GetCallbackData()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
