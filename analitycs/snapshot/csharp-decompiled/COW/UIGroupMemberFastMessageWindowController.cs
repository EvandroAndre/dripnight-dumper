using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIGroupMemberFastMessageWindowController : UIBaseController, IEasyList
{
	private UIGroupMemberFastMessageWindowView m_View;

	private List<AroundGameQuickChatData> m_CurrentDataList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void CloseWithIcon()
	{
	}

	private void OnMaskClick()
	{
	}

	private void RefreshViewData()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
