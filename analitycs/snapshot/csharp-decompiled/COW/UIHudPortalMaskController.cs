using System;
using GCommon;

namespace COW;

public class UIHudPortalMaskController : UIBaseController
{
	private UIHudPortalMaskView m_View;

	private bool m_IsToBlack;

	private Action m_OnBackCallBack;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void StartMask(Action black_call_back = null, float dur = 1f)
	{
	}

	private void OnTweenEnd()
	{
	}

	public void ShowMaskOnlyForward(float dur = 1f)
	{
	}

	public void EnableTween(bool enable)
	{
	}

	public void ResetTween()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
