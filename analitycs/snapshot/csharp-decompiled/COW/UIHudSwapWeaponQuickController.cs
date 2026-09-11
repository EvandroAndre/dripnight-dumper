using GCommon;

namespace COW;

internal class UIHudSwapWeaponQuickController : UIHudButtonBaseController
{
	private UIHudSwapWeaponQuickView m_View;

	private EChangeWeaponSetting m_Setting;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override string GetMappingName()
	{
		return null;
	}

	protected override void OnUIInit()
	{
	}

	private void InitIsNewUI()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnUIOpen()
	{
	}

	private void OnHudSettingChange(object[] param)
	{
	}

	private void UpdateShowTiming()
	{
	}

	private void UpdateShowHide()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
