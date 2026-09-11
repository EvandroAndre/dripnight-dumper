using System;
using GCommon;
using proto;

namespace COW;

public class UISecondConfirmBigController : UIPopupWindowController
{
	private UISecondConfirmBigView m_View;

	private Action m_ConfirmAction;

	private Action m_CancelAction;

	private Action m_OnDestroyAction;

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

	public void SetTitle(string title)
	{
	}

	public void SetConfirmBtnText(string text)
	{
	}

	public void SetCancelBtnText(string text)
	{
	}

	public void ShowCancelButton()
	{
	}

	public void SetConfirmCallback(Action action)
	{
	}

	public void SetCancelCallback(Action action)
	{
	}

	public void SetOnDestroyCallback(Action action)
	{
	}

	public void SetCloseCallback(EventDelegate.Callback action)
	{
	}

	public void SetOneText(string text, UIWidget.Pivot pivot = UIWidget.Pivot.Center)
	{
	}

	public void SetPrice(EInventory.CurrencyType priceType, int count)
	{
	}

	protected virtual void OnCancelClick()
	{
	}

	protected virtual void OnConfirmClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
