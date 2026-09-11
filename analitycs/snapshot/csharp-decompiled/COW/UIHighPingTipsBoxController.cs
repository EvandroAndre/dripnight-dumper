using System;
using GCommon;

namespace COW;

public class UIHighPingTipsBoxController : UIPopupWindowController
{
	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public UIHighPingTipsBoxController _003C_003E4__this;

		public Action onOfflinePlayClick;

		internal void _003COpenOfflinePlayTips_003Eb__0()
		{
		}
	}

	protected UIHighPingTipsBoxView m_View;

	private UIModelLobbyPing m_ModelLobbyPing;

	private float m_AcculatedTime;

	private bool m_HasExpired;

	private Action m_callBack;

	private int m_CountDownLabelTime;

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

	public void OnBtnLaterClick()
	{
	}

	private void CloseAndInvokeCallBack(UIHighPingPopUpUserChoice choice)
	{
	}

	public void OnTipsBoxClose()
	{
	}

	public bool GetExpiredState()
	{
		return false;
	}

	public void SetExpireDelegate(Action action)
	{
	}

	public void SetLabelDescription(string description)
	{
	}

	public void SetOfflineTipsVisible(bool visible)
	{
	}

	public void OpenOfflinePlayTips(Action onOfflinePlayClick)
	{
	}

	private void Update()
	{
	}

	protected virtual float GetHighPingCountDownTime()
	{
		return 0f;
	}

	private void _003COnUIInit_003Eb__7_0()
	{
	}

	private void _003COnUIInit_003Eb__7_1()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
