using GCommon;
using UnityEngine;

namespace COW;

public class UIHudWereWolvesQuickChatScrollController : UIBaseController, IEasyList
{
	private uint m_Select;

	private UIHudWereWolvesQuickChatScrollView m_View;

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

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void SetData(uint playerId)
	{
	}

	private void OnSendWereWolvesQuickChat(object[] data)
	{
	}

	private void OnBgClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
