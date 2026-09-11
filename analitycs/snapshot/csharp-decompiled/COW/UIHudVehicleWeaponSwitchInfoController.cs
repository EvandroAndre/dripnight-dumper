using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudVehicleWeaponSwitchInfoController : UIBaseController
{
	public UIHudVehicleWeaponSwitchInfoView m_View;

	private string EmptyWeaponSpriteIcon;

	private string EmptyAmmoSpriteIcon;

	private bool m_EmptyAmmo;

	private bool m_DisplayCleared;

	private FDAEPHMIEPC m_LastWeapon;

	private DALCIFJKFGO m_LastVehicleWeapon;

	private int m_LastAmmoCapacity;

	private int m_LastAmmoLeft;

	private int m_LastAmmoLeftInClip;

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

	private void Update()
	{
	}

	private void ClearWeaponDisplay()
	{
	}

	private void SetIcon(string s)
	{
	}

	private void SetIcon(ResourceID id)
	{
	}

	private void SetWeaponIcon(FDAEPHMIEPC currentWeapon)
	{
	}

	private void SetWeaponIcon(DALCIFJKFGO vWeapon)
	{
	}

	private bool HasIcon(DALCIFJKFGO vWeapon)
	{
		return false;
	}

	private void UpdateWeaponIcon(DALCIFJKFGO vehWeapon)
	{
	}

	private void UpdateAmmoDisplay(DALCIFJKFGO vehWeapon)
	{
	}

	private void UpdateAmmoDisplay(bool infinityAmmo)
	{
	}

	private void UpdateAutoIcon(DALCIFJKFGO vehWeapon)
	{
	}

	private void ShowAutoIcon(bool b)
	{
	}

	private void _003COnUIInit_003Eb__11_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
