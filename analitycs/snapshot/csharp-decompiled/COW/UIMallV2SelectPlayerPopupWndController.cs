using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIMallV2SelectPlayerPopupWndController : UIPopupWindowController, IEasyList, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass33_0
	{
		public FriendInfo friendInfo;

		public EGiftStore_BuddyType buddyType;

		internal bool _003CCreateFriendInfo_003Eb__0(FriendInfo temp)
		{
			return false;
		}

		internal bool _003CCreateFriendInfo_003Eb__1(FriendInfo temp)
		{
			return false;
		}
	}

	private const int GETFRIENDSLIST = 1;

	private const int GETFRIENDSPRESENCE = 2;

	private UIMallV2SelectPlayerPopupWndView m_View;

	private UIModelClan m_ModelClan;

	private UIModelFriends m_ModelFriends;

	private UIModelGift m_ModelGift;

	private List<FriendInfo> m_FriendsList;

	private List<FriendInfo> m_ClanFriendsList;

	private EGiftStore_BuddyType m_FriendType;

	private FriendInfo m_SelectFriendInfo;

	private int m_GetClanFriendNtfState;

	private EGiftStore_BuddyType m_LobbySelectFriendType;

	private bool m_Prime;

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

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	private void RefreshScrollViewSize()
	{
	}

	public void SetSelectFriendInfo(FriendInfo info, bool isPrimeGift)
	{
	}

	private void OnFriendSelected(object[] data)
	{
	}

	private void RefreshFriendList(FriendInfo info, bool isSelected)
	{
	}

	private void GetFriendDataList()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void OnCloseSelectFriendPanelBtnClick()
	{
	}

	private void OnFriendBtnClick()
	{
	}

	private void OnClanFriendBtnClick()
	{
	}

	private void RefreshFriendListView()
	{
	}

	private void RefreshViewData(List<FriendInfo> dataList, bool needResort = true)
	{
	}

	private int SortFriendsBySelected(FriendInfo a, FriendInfo b)
	{
		return 0;
	}

	private int SortFriendsByIntimacyValue(FriendInfo a, FriendInfo b)
	{
		return 0;
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void CreateFriendInfo(FriendInfo friendInfo, EGiftStore_BuddyType buddyType, List<FriendInfo> list, bool isPrime = false)
	{
	}

	private void OnSearchBtnClick()
	{
	}

	private void OnCancelSearchBtnClick()
	{
	}

	private void OnSearch()
	{
	}

	private void OnRefreshBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}
}
