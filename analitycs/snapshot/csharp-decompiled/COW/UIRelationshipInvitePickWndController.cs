using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIRelationshipInvitePickWndController : UIPopupWindowController, IEasyList
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<FriendAccountInfo> _003C_003E9__10_0;

		internal int _003CSetUIData_003Eb__10_0(FriendAccountInfo a, FriendAccountInfo b)
		{
			return 0;
		}
	}

	private UIRelationshipInvitePickWndView m_View;

	private bool m_HasSearch;

	private uint m_WinkCall;

	private List<FriendAccountInfo> m_CachedFriends;

	protected override void OnDestroy()
	{
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void SetUIData(List<FriendAccountInfo> needShowFriendList)
	{
	}

	private void ResetSearchInput()
	{
	}

	private void RefreshScrollView()
	{
	}

	private void OnSearchInputGetFocus()
	{
	}

	private void OnSearchInputChange()
	{
	}

	private void OnSearchBtnClick()
	{
	}

	private void _003COnSearchBtnClick_003Eb__15_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
