using GCommon;

namespace COW;

public class UIEVOGunPrivilegeToggleController : UIBaseController
{
	private UIEVOGunPrivilegeToggleView m_View;

	private SkinOwnAndOpenInfo m_SkinOwnAndOpenInfo;

	private UIModelWeaponSkinUpgrader m_ModelWeaponSkinUpgrader;

	private bool m_IsSpecial;

	private bool m_OriginalState;

	private WeaponSkinFeature m_Feature;

	private EVOGunUIPrivilegeType m_PrivilegeType;

	private int m_Index;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void SetupDefaultState()
	{
	}

	private void OnSoundConBtnClick()
	{
	}

	private void OnOriginalToggleBtnClick()
	{
	}

	private void OnSpecialToggleBtnClick()
	{
	}

	private void AddEventDelegate()
	{
	}

	private void RefreshToggleBtnState(bool isSpecial)
	{
	}

	public void SetData(SkinOwnAndOpenInfo skinOwndAndOpenInfo, WeaponSkinFeature feature = WeaponSkinFeature.FireSound, EVOGunUIPrivilegeType privilegeType = EVOGunUIPrivilegeType.QuickSwitch, int index = 0)
	{
	}

	public void OnSelectNotify()
	{
	}

	public WeaponSkinFeature GetCurrentFeature()
	{
		return WeaponSkinFeature.None;
	}

	public bool IsSpecialSelected()
	{
		return false;
	}

	public void OnSelect()
	{
	}

	public void OnCancelSelect()
	{
	}

	public void RequestChangeSoundStat()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
