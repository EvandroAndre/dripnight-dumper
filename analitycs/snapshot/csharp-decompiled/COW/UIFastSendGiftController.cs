using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIFastSendGiftController : UIPopupWindowController, IUIModelDataChangeObserver, IEasyList
{
	private UIFastSendGiftView m_View;

	private BaseItemInfo m_BaseItemInfo;

	private UIModelGift m_ModelGift;

	private UIModelUser m_ModelUser;

	private UIModelFriends m_ModelFriends;

	private UIModelWishList m_ModelWishList;

	private UIModelPrime m_ModelPrime;

	private UIModelMall m_ModelMall;

	private uint m_SelectedItemId;

	private FriendInfo m_SelectFriendInfo;

	private List<FriendInfo> m_TeamMatesList;

	private bool m_IsIngame;

	private EGiftSendSource m_GiftSource;

	private bool m_IsPrimeGiftSelected;

	private List<UIFastSendGiftFriendItemController> m_FriendItemCtrlList;

	private int m_CurSelectedFriendIndex;

	private bool m_IsFirstSelectGiftForFriend;

	private bool m_IsPrimeShopOpen;

	private bool m_IsNormalGiftStoreDataReady;

	private bool m_IsPrimeGiftStoreDataReady;

	private bool m_IsStoreDataReady;

	private bool m_IsWishListDataReady;

	private bool m_IsOwnedDataReady;

	private bool m_IsPrimeOwnedDataReady;

	public bool IsPrimeGiftSelected => false;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnSendBtnClick()
	{
	}

	private void OnGiftItemSelected(object[] data)
	{
	}

	private void OnGiftFriendSelected(object[] data)
	{
	}

	private void RefreshFriendList(FriendInfo info)
	{
	}

	private void RefreshFriendInfoIsPrimeGift()
	{
	}

	private void RefreshSendBtnView()
	{
	}

	private void RequestWishListAndOwnedData()
	{
	}

	private void RefreshAllItemIntimacyVaule()
	{
	}

	public GiftItem GetSelectedItem()
	{
		return null;
	}

	private void RefreshItemView(uint commodityID)
	{
	}

	private void OnCloseBtnClick()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void RefreshAllGiftItem()
	{
	}

	private void RefreshDataListView(List<GiftItem> giftItemList, List<PrimeStoreItemDesc> primeGiftItemList)
	{
	}

	private void RemoveOwnedGiftItem(List<GiftItem> giftItemList)
	{
	}

	private void RemoveOwnedOrSoldOutPrimeGiftItem(List<PrimeStoreItemDesc> primeGiftItemList)
	{
	}

	private int SortPrimeStoreItem(PrimeStoreItemDesc x, PrimeStoreItemDesc y)
	{
		return 0;
	}

	private int SortWishListItemData(UIFastSendGiftItemData x, UIFastSendGiftItemData y)
	{
		return 0;
	}

	private void RefreshTeamMateInfo()
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

	public void SetTeamMatesData(List<FriendInfo> teamMatesList)
	{
	}

	public void SetGiftSendSouce(EGiftSendSource source)
	{
	}

	public void IsIngame(bool isInGame = false)
	{
	}

	protected override void OnUIClose()
	{
	}

	private void CheckIsGiftStoreDataReady()
	{
	}

	private void OnGiftStoreDataReady()
	{
	}

	private void OnWishListReady(ulong accountID)
	{
	}

	private void OnOwnedGiftListReady(bool isPrime, ulong accountID)
	{
	}

	private void CheckIsWishListDataAndOwnedDataReady()
	{
	}

	private void OnWishListDataAndOwnedDataReady()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
