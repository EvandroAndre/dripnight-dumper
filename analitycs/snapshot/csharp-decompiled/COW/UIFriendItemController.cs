using GCommon;
using UnityEngine;

namespace COW;

public class UIFriendItemController : UIEasyListItemController, IUIModelDataChangeObserver
{
	private UIFriendItemView m_View;

	private FriendAccountInfo m_Data;

	private FriendAccountInfoData m_InfoData;

	private UIDragScrollView m_DragComponent;

	private BoxCollider m_ItemCollider;

	private EFriendTabType tabType;

	private UIBaseProfileInfoController m_BaseProfile;

	private string m_GiftCondition;

	private uint m_friend_tag;

	private bool m_HasPlayedAnim;

	public UIDragScrollView DragComponent => null;

	public Vector2 ItemViewSize => default(Vector2);

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnFriendCountLimitReject(object[] data)
	{
	}

	public void SetWidth(int width)
	{
	}

	private void OnSendGiftBtnClick()
	{
	}

	private void OnNewVersionBtnClick()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public override void OnItemBtnClick()
	{
	}

	public void SetData(FriendAccountInfo accountInfo)
	{
	}

	private void OnFriendIntimacyClick()
	{
	}

	private void OnChatBtnClick()
	{
	}

	private void OnAddBtnClick()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void SetClanIconCarousel(bool isShowClanIcon)
	{
	}

	private void OnCommonFriendsButtonClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnClick()
	{
	}
}
