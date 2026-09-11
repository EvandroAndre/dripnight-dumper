using GCommon;
using proto;

namespace COW;

public class UISkinModCheckPopWndController : UIPopupWindowController
{
	private UISkinModCheckPopWndView m_View;

	private UICountDownLabel m_CountDownLabel;

	private ulong m_StartShowTime;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	public void SetDesc(HackWarningInfoDesc info)
	{
	}

	private void SetCountDown(uint time)
	{
	}

	private void OnConfirmBtnClick()
	{
	}

	private void OnDisabledBtnClick()
	{
	}

	private void ChangeBtnStateHandle()
	{
	}

	public override bool ClosedByEsc()
	{
		return false;
	}

	public void OnRepairClientBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public bool _003C_003EiFixBaseProxy_ClosedByEsc()
	{
		return false;
	}
}
