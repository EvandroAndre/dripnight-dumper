using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIOTPController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private UIOTPView m_View;

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

	protected override void OnUIOpen()
	{
	}

	public override bool ClosedByEsc()
	{
		return false;
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

	private void OnCloseBtnClick()
	{
	}

	public void InitCloseBtnAndTitle()
	{
	}

	private void RefreshUIDataWhenPushStack()
	{
	}

	private void RefreshUIDataWhenPopStack()
	{
	}

	private void RefreshTitle()
	{
	}

	private void RefreshCloseBtn()
	{
	}

	private bool CheckSecondConfirmPopupNeedShowWhenClose()
	{
		return false;
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void _003COnCloseBtnClick_003Eb__11_0()
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

	public bool _003C_003EiFixBaseProxy_ClosedByEsc()
	{
		return false;
	}
}
