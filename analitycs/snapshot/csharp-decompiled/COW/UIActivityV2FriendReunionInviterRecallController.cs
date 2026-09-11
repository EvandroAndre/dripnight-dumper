using GCommon;
using UnityEngine;

namespace COW;

internal class UIActivityV2FriendReunionInviterRecallController : UIBaseController, IEasyList, IUIModelDataChangeObserver
{
	private UIActivityV2FriendReunionInviterRecallView m_View;

	private UIModelFriendReunion m_ModelFriendReunion;

	private UIModelFriends m_ModelFriends;

	private bool m_UseBigType;

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

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void RefreshView()
	{
	}

	public void ChangeWidthForOnlyOne(bool flag)
	{
	}

	public void SetBigType(bool flag)
	{
	}

	private void OnBtnQuickRecallClick()
	{
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public virtual UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
