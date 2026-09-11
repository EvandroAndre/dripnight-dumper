using GCommon;

namespace COW;

public class UIBigEvent_CustomTC_MissionBtnItemController : UIBigEvent_Template_BtnItemBaseController
{
	private UIBigEvent_CustomTC_MissionBtnItemView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void RefreshViewInternal()
	{
	}

	public bool GetMissionGuide(out UIWidget targetWidget, out UIButton finishButton)
	{
		targetWidget = null;
		finishButton = null;
		return false;
	}

	protected override void OpenPeakDayPopupWnd()
	{
	}

	protected override void OpenMissionPopupWnd()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshViewInternal()
	{
	}

	public void _003C_003EiFixBaseProxy_OpenPeakDayPopupWnd()
	{
	}

	public void _003C_003EiFixBaseProxy_OpenMissionPopupWnd()
	{
	}
}
