using System;
using GCommon;

namespace COW;

public class UIMatchMakingWatingController : UIPopupWindowController
{
	private UIMatchMakingWaitingView m_View;

	private float m_Time;

	public Action OnCancel;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void Update()
	{
	}

	private void OnSimulateClickBtnCancel(object[] data)
	{
	}

	protected void OnBtnCancel()
	{
	}

	public override bool ClosedByEsc()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public bool _003C_003EiFixBaseProxy_ClosedByEsc()
	{
		return false;
	}
}
