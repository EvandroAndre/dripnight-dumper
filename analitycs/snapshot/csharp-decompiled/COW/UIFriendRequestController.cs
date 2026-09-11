using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIFriendRequestController : UIPopupWindowController, IUIModelDataChangeObserver, ITipsDelegate, IEasyList
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__13_0;

		internal void _003COnBtnRefuseAllClick_003Eb__13_0()
		{
		}
	}

	private UIFriendRequestView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void ShowFriendRequest()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnTipsDataChange(ETipsType type, int num)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void UpdateShareUI()
	{
	}

	private void RefreshViewInfo()
	{
	}

	private void OnBtnRefuseAllClick()
	{
	}

	private void RefreshList(List<FriendAccountInfo> accountList, bool keep_page = false)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
