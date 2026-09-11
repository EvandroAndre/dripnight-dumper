using System;
using GCommon;

namespace COW;

public class UIHudUGCTutorialCongratulationsController : UIPopupWindowController
{
	private UIHudUGCTutorialCongratulationsView m_View;

	private Action m_OnConfirmCallback;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public void SetConfirmCallback(Action callback)
	{
	}

	private void OnClickOKBtn()
	{
	}

	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}
}
