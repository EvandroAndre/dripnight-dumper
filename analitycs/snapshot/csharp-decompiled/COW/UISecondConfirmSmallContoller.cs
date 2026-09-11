using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UISecondConfirmSmallContoller : UIPopupWindowController
{
	private UISecondConfirmSmallView m_View;

	private Action m_ConfirmAction;

	private Action m_ExtraConfirmAction;

	private Action m_CancelAction;

	private Action m_CloseAction;

	private bool m_IgnoreESC;

	private bool m_ConfirmNoClose;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override int MinGroupDepth()
	{
		return 0;
	}

	protected void OnCancelClick()
	{
	}

	private void OnConfirmClick()
	{
	}

	private void OnExtraBtnClick()
	{
	}

	public void SetExtraContainerVisible(bool visible, string extraLabel = "")
	{
	}

	public void SetData(string text = "")
	{
	}

	public void SetData(string text, List<ResourceID> iconResList)
	{
	}

	public void SetOneTextOverflow(UILabel.Overflow overflow)
	{
	}

	public void SetOneTextAlignment(NGUIText.Alignment alignment)
	{
	}

	public void SetTitle(string title)
	{
	}

	public void SetCloseBtnView(bool isShow)
	{
	}

	public void ShowCancelButton()
	{
	}

	public void SetConfirmView(bool isShow = true)
	{
	}

	public void SetConfirmBtnLabel(string key)
	{
	}

	public void SetCancelBtnLabel(string key)
	{
	}

	public void SetConfirmCallback(Action action)
	{
	}

	public void SetExtralConfirmCallback(Action action)
	{
	}

	public void SetCancelCallback(Action action)
	{
	}

	public void SetIgnoreESC(bool ignoreESC = false)
	{
	}

	public void SetConfirmNotClose(bool confirmNotClose = false)
	{
	}

	public override void EnterByReturn()
	{
	}

	public override bool IgnoreEsc()
	{
		return false;
	}

	public void SetCloseAction(Action act)
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public int _003C_003EiFixBaseProxy_MinGroupDepth()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_EnterByReturn()
	{
	}

	public bool _003C_003EiFixBaseProxy_IgnoreEsc()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
