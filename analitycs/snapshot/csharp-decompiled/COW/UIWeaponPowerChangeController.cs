using GCommon;

namespace COW;

public class UIWeaponPowerChangeController : UIBaseController
{
	private UIWeaponPowerChangeView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(string weaponName, int deltaPower, int prePower = -1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
