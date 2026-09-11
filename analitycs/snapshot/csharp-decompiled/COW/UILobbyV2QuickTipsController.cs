using GCommon;
using UnityEngine;

namespace COW;

internal class UILobbyV2QuickTipsController : UIPopupWindowController
{
	private UILobbyV2QuickTipsView m_View;

	private AroundGameQuickChatData m_Data;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetPosition(Transform parent)
	{
	}

	public void SetViewData(string text, uint quickId)
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	private void OnQuickMsgClick()
	{
	}

	private void OnClickMaskClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}
}
