using GCommon;
using UnityEngine;

namespace COW;

public class UIWeaponSkinLobbyMainShareController : UIBaseController
{
	private UIWeaponSkinLobbyMainShareView m_View;

	private UIEvoGunKillCountController m_EvoGunKillCountCtrl;

	private UIModelWeaponSkinUpgrader m_ModelWeaponSkinUpgrader;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetShareData(uint weaponid, WeaponSkinData data, Color qualityColor)
	{
	}

	private void RefreshWeaponName(WeaponSkinData skinData)
	{
	}

	private bool SetEvoGunKillCountView(WeaponSkinData lData)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
