using System;
using GCommon;

namespace COW;

public class UINinthSYSSecondConfirmWndController : UIPopupWindowController
{
	private UINinthSYSSecondConfirmWndView m_View;

	private Action m_CancelBtnClick;

	private Action m_ConfirmBtnClick;

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

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	public UINinthSYSSecondConfirmWndController AddOnCancelBtnClick(Action onCancelBtnClick)
	{
		return null;
	}

	public UINinthSYSSecondConfirmWndController AddOnConfirmBtnClick(Action onConfirmBtnClick)
	{
		return null;
	}

	public UINinthSYSSecondConfirmWndController SetDesc(string desc)
	{
		return null;
	}

	private void OnCancelBtnClick()
	{
	}

	private void OnConfirmBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}
}
