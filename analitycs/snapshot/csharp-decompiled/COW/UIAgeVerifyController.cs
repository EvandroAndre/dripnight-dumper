using System;
using GCommon;
using proto;

namespace COW;

public class UIAgeVerifyController : UIPopupWindowController
{
	public UIAgeVerifyView m_View;

	public Action m_OnClose;

	private UIModelAntiAddiction m_AntiAddictionModel;

	private EAntiAddiction.AgeState m_SelectedAge;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void SetOnClose(Action onClose)
	{
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	private void BindAndSend()
	{
	}

	private void Send()
	{
	}

	private void OnLowAgeClick()
	{
	}

	private void OnHighAgeClick()
	{
	}

	protected override void OnUIClose()
	{
	}

	private void OnSkipClick()
	{
	}

	public override bool IgnoreEsc()
	{
		return false;
	}

	private void _003CSend_003Eb__9_0()
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

	public bool _003C_003EiFixBaseProxy_IgnoreEsc()
	{
		return false;
	}
}
