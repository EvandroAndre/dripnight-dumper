using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIOTPBindController : UIPopupWindowController
{
	private UIOTPBindView m_View;

	private UIModelOTP m_ModelOTP;

	private Stack<UIBaseController> m_StackShowedCtrls;

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

	public override bool ClosedByEsc()
	{
		return false;
	}

	private void OnCloseBtnClick()
	{
	}

	private void OnGoNextState(object[] data)
	{
	}

	private void OnBackLastState()
	{
	}

	private void OnBackJumpState(object[] data)
	{
	}

	private void OnSavePassword()
	{
	}

	private void RefreshUIDataWhenPushStack()
	{
	}

	private void RefreshUIDataWhenPopStack()
	{
	}

	private void RefreshProgress()
	{
	}

	private void RefreshTitle()
	{
	}

	private void RefreshLeftImage()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_ClosedByEsc()
	{
		return false;
	}
}
