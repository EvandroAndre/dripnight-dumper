using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudMatchResultLikePopupController : UIBaseController
{
	private UIHudMatchResultLikePopupView m_View;

	private uint m_DelayCallID;

	private Animator m_Animator;

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

	protected override void OnUIDestory()
	{
	}

	public void SetMessage(string message, float duration)
	{
	}

	private void AutoHide()
	{
	}

	private void CancelDelayCall()
	{
	}

	protected override void OnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
