using System.Text;
using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudTKWeaponInfoController : UIBaseController
{
	private UIHudTKWeaponInfoView m_View;

	private FDAEPHMIEPC m_LastWeaponInHand;

	private bool m_weaponChanged;

	private StringBuilder m_Sb;

	private int m_GenStartTime;

	private int m_GenEndTime;

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

	private void Update()
	{
	}

	private void OnLastWeaponInit(object[] args)
	{
	}

	private void OnInventoryItemChanged(object[] param)
	{
	}

	private void OnThrowKnifePhaseChanged(object[] param)
	{
	}

	private void SetProgressBarAndCntUI(bool equipThrowKnife, int cnt)
	{
	}

	private void OnShowKnifeAutoGenTutorial(object[] data)
	{
	}

	private void OnObserverInfoListVisibleChanged(object[] data)
	{
	}

	private void _003COnUIInit_003Eb__7_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
