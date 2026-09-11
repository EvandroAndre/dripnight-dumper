using GCommon;

namespace COW;

internal class UIHudCombineWeaponController : UIHudButtonBaseController
{
	private UIHudCombineWeaponView m_View;

	private bool m_CanCombine;

	private bool m_ObserverOnVehicle;

	private bool HideCombineWeaponCtrl => false;

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

	private void InitIsNewUI()
	{
	}

	private void DebugCombineBtnWrongVisibility()
	{
	}

	private void OnCanCombineChanged(object[] param)
	{
	}

	private void OnSightingStateChanged(object[] data)
	{
	}

	private void OnCombineStatusChanged(object[] param)
	{
	}

	private void FreshCombineStatus(bool isCombine)
	{
	}

	protected override string GetMappingName()
	{
		return null;
	}

	private void RefreshCtrlVisibility()
	{
	}

	private void OnObserverGetOnVehicle(object[] data)
	{
	}

	private void OnObserverGetOffVehicle(object[] data)
	{
	}

	private void OnLocalPlayerRevive(object[] data)
	{
	}

	protected override void OnBtnDown()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnBtnDown()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
