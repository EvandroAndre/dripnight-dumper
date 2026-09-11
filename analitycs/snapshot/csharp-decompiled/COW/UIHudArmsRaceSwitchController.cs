using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudArmsRaceSwitchController : UIBaseController
{
	private UIHudArmsRaceSwitchView m_View;

	private uint m_LastDisplayWeaponDataID;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private bool IsHoldingFist(Player p)
	{
		return false;
	}

	private int GetCurrentArmsWeaponDataID()
	{
		return 0;
	}

	private FDAEPHMIEPC FindArmsRaceWeapon(Player p)
	{
		return null;
	}

	private bool IsCurrentArmsWeaponMelee()
	{
		return false;
	}

	private void UpdateDisplay()
	{
	}

	private void OnSwitchClick()
	{
	}

	private void OnPlayerARMLevelUpdate(object[] param)
	{
	}

	private void OnItemOnHandChanged(object[] param)
	{
	}

	private void OnArmsInfoReady(object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
