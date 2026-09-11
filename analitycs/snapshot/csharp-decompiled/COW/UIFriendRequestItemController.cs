using GCommon;
using UnityEngine;

namespace COW;

public class UIFriendRequestItemController : UIEasyListItemController, IUIModelDataChangeObserver
{
	private UIFriendRequestItemView m_View;

	private FriendAccountInfo m_Data;

	private UIDragScrollView m_DragComponent;

	private BoxCollider m_ItemCollider;

	private EFriendTabType tabType;

	private UIBaseProfileInfoController m_BaseProfile;

	public UIDragScrollView DragComponent => null;

	public Vector2 ItemViewSize => default(Vector2);

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
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

	private void OnRefuseBtnClick()
	{
	}

	private void OnBlockBtnClick()
	{
	}

	private void OnAgreeBtnClick()
	{
	}

	private void OnExtraInfoButtonClick()
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

	private void _003COnBlockBtnClick_003Eb__17_0()
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
