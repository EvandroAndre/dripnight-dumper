using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIActivityV2FriendReunionInviteeCallBackController : UIPopupWindowController, IEasyList
{
	private UIActivityV2FriendReunionInviteeCallBackView m_View;

	private UIModelFriendReunion m_ModelFriendReunion;

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

	public void SetData(List<FriendReunionInviterData> dataList)
	{
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public virtual UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
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
