using GCommon;
using UnityEngine;

namespace COW;

public class UIFriendCallbackItemController : UIEasyListItemController, IUIModelDataChangeObserver
{
	private UIFriendCallbackItemView m_View;

	private FriendAccountInfo m_Data;

	private UIDragScrollView m_DragComponent;

	private BoxCollider m_ItemCollider;

	private bool m_NeedShowOnline;

	public UIDragScrollView DragComponent => null;

	public Vector2 ItemViewSize => default(Vector2);

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

	public void SetData(FriendAccountInfo accountInfo)
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void SetBigEventBg()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void SetNeedShowOnlineFlag()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
