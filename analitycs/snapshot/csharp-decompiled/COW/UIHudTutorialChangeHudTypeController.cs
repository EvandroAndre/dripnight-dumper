using System;
using GCommon;

namespace COW;

internal class UIHudTutorialChangeHudTypeController : UIPopupWindowController
{
	private float m_Time;

	private int m_Second;

	private UIHudTutorialChangeHudTypeView m_View;

	private bool m_UseHudType4;

	private Action m_HideAction;

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

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void InitCDN()
	{
	}

	private void Update()
	{
	}

	private void OnBtnType1Click()
	{
	}

	private void OnBtnType2Click()
	{
	}

	private void OnConfirmBtnClick()
	{
	}

	public void SetHideAction(Action hideAction)
	{
	}

	private void SendChooseHudEventLog(bool isTrigger, bool isChooseHud4)
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

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
