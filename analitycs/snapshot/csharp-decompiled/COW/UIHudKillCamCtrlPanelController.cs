using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudKillCamCtrlPanelController : UIBaseController
{
	private UIHudKillCamCtrlPanelView m_View;

	private BHGGAEEHJCO m_TargetPlayerID;

	private ulong m_TargetUserID;

	private string m_TargetPlayerName;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnBtnBackClick()
	{
	}

	private void OnBtnReportClick()
	{
	}

	private void OnReviveNotify()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
