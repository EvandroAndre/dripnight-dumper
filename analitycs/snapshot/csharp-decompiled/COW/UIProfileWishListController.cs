using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIProfileWishListController : UIPreviewBaseController, IEasyList, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<WishListItem> _003C_003E9__32_1;

		public static Comparison<WishListItem> _003C_003E9__32_2;

		internal int _003CSortWishListItems_003Eb__32_1(WishListItem a, WishListItem b)
		{
			return 0;
		}

		internal int _003CSortWishListItems_003Eb__32_2(WishListItem a, WishListItem b)
		{
			return 0;
		}
	}

	private sealed class _003CDelayRefreshPreviewBorder_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIProfileWishListController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayRefreshPreviewBorder_003Ed__24(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private UIProfileWishListView m_View;

	private UIPopMenuSmallControler m_PopMenu;

	private List<PopMenuData> m_FilterData;

	private WishListSortFiltersType m_CurrentSortType;

	private UIModelWishList m_modelWishList;

	private UIModelFriends m_modelFriend;

	private UIModelClan m_ModelClan;

	private UIModelGift m_modelGift;

	private UIModelUser m_modelUser;

	private UIModelInventory m_modelInventory;

	private List<UIProfileWishListItemController> m_ChildItemCtrls;

	private List<WishListItem> m_WishList;

	private FriendInfo m_TargetFriendInfo;

	public bool? m_IsCanSendGift;

	private int m_CurSelectIdx;

	private uint m_CurItemId;

	private ulong TargetAccoundId;

	private const string LocalChooseSortTypeKeyLocal = "WishListSortTypeLocal";

	private const string LocalChooseSortTypeKeyOther = "WishListSortTypeOther";

	private List<uint> TmpListToRequestChannel;

	private ItemChannelInfo m_TargetItemChannelInfo;

	private bool WishListItemReady;

	private bool FriendListReady;

	private bool ClanMemberListReady;

	private bool GiftStoreDataReady;

	private bool OwnedGiftListReady;

	private bool ItemChannelDataReady;

	private WishListSortFiltersType LocalChooseSortType
	{
		get
		{
			return WishListSortFiltersType.CanGetOrSendGift;
		}
		set
		{
		}
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	private IEnumerator DelayRefreshPreviewBorder()
	{
		return null;
	}

	public void InitData(ulong targeAccountId)
	{
	}

	public bool IsPreviewHiding()
	{
		return false;
	}

	private void InitSendGiftData()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void RefreshView(bool reRequestChannel = false)
	{
	}

	private bool IsLocalUser()
	{
		return false;
	}

	private void SortWishListItems(List<WishListItem> list, WishListSortFiltersType sortType)
	{
	}

	private void InitPopMenu()
	{
	}

	private void RefreshPopMenuData()
	{
	}

	private void RefreshViewBySort(int sortType)
	{
	}

	private void SetPopMenuData()
	{
	}

	UIEasyListItemController IEasyList.OpenItemController(Transform parent)
	{
		return null;
	}

	void IEasyList.CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void OnItemClick(WishListItem wishListItem, int index)
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

	private void OnSendGiftBtnClick()
	{
	}

	private void OnGoPosBtnClick()
	{
	}

	private void OnWishListRankGoToBtnClick()
	{
	}

	private void RefreshWishListRankGoToBtn()
	{
	}

	private void OnSkipAnimMaskBtnClick()
	{
	}

	private void OnAvatarPlayChangeClothAnim()
	{
	}

	private void OnAvatarFinishChangeClothAnim()
	{
	}

	private void OnOwnedGiftListReady()
	{
	}

	public void RequestItemChannelInfo()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void RefreshGiftView()
	{
	}

	private void RefreshGopos()
	{
	}

	public bool IsLocalPlayer()
	{
		return false;
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	protected override void OnUIDestory()
	{
	}

	private void _003C_003En__0(UIWidget previewBorder)
	{
	}

	private int _003CSortWishListItems_003Eb__32_0(WishListItem a, WishListItem b)
	{
		return 0;
	}

	private void _003CRefreshPopMenuData_003Eb__34_0(object obj)
	{
	}

	private void _003CRefreshGopos_003Eb__60_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
