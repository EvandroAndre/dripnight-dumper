using System;
using GCommon;

namespace COW;

public class UINinthSYSLobbyModelSelectWndController : UIPopupWindowController
{
	private UINinthSYSLobbyModelSelectWndView m_View;

	private Action m_LobbyBtnClick;

	private Action m_SocialBtnClick;

	private uint m_DelayCallKey;

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

	protected override void OnUIOpen()
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	public UINinthSYSLobbyModelSelectWndController AddOnLobbyBtnClick(Action onLobbyBtnClick)
	{
		return null;
	}

	public UINinthSYSLobbyModelSelectWndController AddOnSocialBtnClick(Action onSocialBtnClick)
	{
		return null;
	}

	private void OnLobbyBtnClick()
	{
	}

	private void OnSocialBtnClick()
	{
	}

	private void _003COnLobbyBtnClick_003Eb__11_0()
	{
	}

	private void _003COnSocialBtnClick_003Eb__12_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}
}
