using System;
using GCommon;

namespace COW;

public class UICommonCountDownBoxController : UIPopupWindowController
{
	private UICommonCountDownBoxView m_View;

	private float m_AcculatedTime;

	private bool m_HasExpired;

	private Action m_ExpireAction;

	private Action m_ConfirmAction;

	private Action m_LaterAction;

	private int m_CountDownLabelTime;

	private float m_ConstCountDownLabelTime;

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

	public void SetView(string title, string descInfo, float countDownTime)
	{
	}

	public void SetView(string title, string descInfo, float countDownTime, string leftLabel, string rightLabel)
	{
	}

	public void SetConfirmCallback(Action action)
	{
	}

	public void SetLaterCallback(Action action)
	{
	}

	public void OnBtnLaterClick()
	{
	}

	public void OnBtnConfirmClick()
	{
	}

	private void CloseAndInvokeCallBack()
	{
	}

	public void OnTipsBoxClose()
	{
	}

	public void SetExpireDelegate(Action action)
	{
	}

	private void Update()
	{
	}

	private void _003COnUIInit_003Eb__9_0()
	{
	}

	private void _003COnUIInit_003Eb__9_1()
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
}
