using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIFriendExtraInfoWindowController : UIPopupWindowController, IEasyList
{
	private UIFriendExtraInfoWindowView m_View;

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

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void RefreshList<T>(List<T> dataList)
	{
	}

	public void ShowCommonFriendsList(List<FriendAccountInfo> commonFriends, string playerName)
	{
	}

	private int CompareByIntimacy(FriendAccountInfo a, FriendAccountInfo b)
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
