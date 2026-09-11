using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIMallV2GiftController : UIPreviewNavigationController, IEasyList, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass46_0
	{
		public EGiftStore_BuddyType buddyType;

		public FriendInfo friendInfo;

		internal bool _003CCreateFriendInfo_003Eb__0(FriendInfo temp)
		{
			return false;
		}
	}

	private UIMallV2GiftView m_View;

	private UIModelClan m_ModelClan;

	private UIModelFriends m_ModelFriends;

	private UIModelGift m_ModelGift;

	private UIModelUser m_ModelUser;

	private List<FriendInfo> m_FriendsList;

	private List<FriendInfo> m_ClanFriendsList;

	private EGiftStore_BuddyType m_FriendType;

	private EGiftSendSource m_GiftSource;

	private Dictionary<uint, bool> m_AllSelectStateDict;

	private GiftItem m_SelectedGift;

	private UINavigationData m_LastNavigationData;

	private bool m_IsSelectMax;

	private string m_ReceiversName;

	private int m_GetFriendNtfState;

	private int m_GetClanFriendNtfState;

	private const int GETFRIENDSLIST = 1;

	private const int GETFRIENDSPRESENCE = 2;

	private EGiftStore_BuddyType m_LobbySelectFriendType;

	private bool m_Prime;

	private bool m_lastPrimeState;

	protected int m_Count;

	protected int m_MaxCount;

	protected int ItemCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnUpdateBuyVoucher(object[] data)
	{
	}

	private void InitNavigationData(UINavigationData navigationData)
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public void SetGiftViewData()
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

	private int GetSelectNum()
	{
		return 0;
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
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

	private int SortFriendsAfterSelected(FriendInfo a, FriendInfo b)
	{
		return 0;
	}

	private void OnNextBtnClick()
	{
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

	private void OnCancelSearchBtnClick()
	{
	}

	private void OnSearchBtnClick()
	{
	}

	private void OnRuleBtnClick()
	{
	}

	protected void CanShowModifyCountContainer()
	{
	}

	protected void EnableInput(bool enable)
	{
	}

	private void RefreshCountInput()
	{
	}

	private void OnCountInputSubmit()
	{
	}

	private void OnCountInputChanged()
	{
	}

	protected void OnPlusBtnClick()
	{
	}

	protected void OnMinsBtnClick()
	{
	}

	private void OnAddTenBtnClick()
	{
	}

	private void RefreshSelectNum()
	{
	}

	private void SetVoucherVisual()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	protected override FrontendPreviewType GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}

	public GiftItem GetSelectedItem()
	{
		return null;
	}

	public uint GetSelectedItemCount()
	{
		return 0u;
	}

	private void UpdateSelectedItemCount()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
