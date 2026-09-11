using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIChatWhisperContainerController : UIChatBaseContainerController, IUIModelDataChangeObserver, IEasyList
{
	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public string name;

		internal bool _003COnSearchClick_003Eb__0(ChatWhisperNameData a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass40_0
	{
		public List<ChatChannelInfo> list;

		public int i;

		public Predicate<FriendAccountInfo> _003C_003E9__1;

		internal bool _003CConstructCacheList_003Eb__1(FriendAccountInfo x)
		{
			return false;
		}
	}

	private UIChatWhisperContainerView m_View;

	private UIModelFriends m_FriendsModel;

	private UIModelChat m_Chat;

	private List<ChatWhisperNameData> m_CacheList;

	private FriendAccountInfo curWhisperTo;

	private ulong m_LastRefreshTime;

	private bool m_HasSearch;

	private bool m_InputNodeShow;

	private const float NAMELIST_CLIP_OFFSET_Y = 90f;

	private bool m_IsRefreshingRecentWhisperNameList;

	private bool m_IsRefreshingFriendNameList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnFriendBtnClick()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public void GoToWhisperChannel(ulong id, bool forceToFriendTab)
	{
	}

	protected override void OnUIDestroy()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void OnSentGiftClick()
	{
	}

	private void OnProfileClick()
	{
	}

	private void OnSearchInputGetFocus()
	{
	}

	private void OnSearchClick()
	{
	}

	private void ResetInput()
	{
	}

	private void OnRefreshClick()
	{
	}

	private void OnRecentTabClick(UIToggleButton button)
	{
	}

	private void RefreshRecentWhisperNameList()
	{
	}

	private void OnFriendTabClick(UIToggleButton button)
	{
	}

	private void RefreshFriendNameList()
	{
	}

	public override GameObject GetContentNode()
	{
		return null;
	}

	public override GameObject GetEmptyNode()
	{
		return null;
	}

	public override UIScrollView GetMessageList()
	{
		return null;
	}

	public override UITable2 GetMessageListTable2()
	{
		return null;
	}

	public override void RefreshContentNode()
	{
	}

	public override void InitWidget(Transform parent)
	{
	}

	void IUIModelDataChangeObserver.OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	uint IUIModelDataChangeObserver.GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	UIEasyListItemController IEasyList.OpenItemController(Transform parent)
	{
		return null;
	}

	void IEasyList.CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void OnItemSelect(object[] param)
	{
	}

	private void OnDeleteClick(object[] param)
	{
	}

	private int ConstructCacheList(EWhipserContainerShowTab tab)
	{
		return 0;
	}

	private void OnBaseProfileUpdate(object[] data)
	{
	}

	private bool _003CInitWidget_003Eb__33_0(FriendAccountInfo x)
	{
		return false;
	}

	private int _003CConstructCacheList_003Eb__40_0(FriendAccountInfo x, FriendAccountInfo y)
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_InitWidget(Transform P0)
	{
	}
}
