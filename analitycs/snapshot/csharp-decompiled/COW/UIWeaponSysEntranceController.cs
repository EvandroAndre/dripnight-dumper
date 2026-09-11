using GCommon;

namespace COW;

internal class UIWeaponSysEntranceController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private UIWeaponSysEntranceView m_View;

	private UIModelWeaponSkinUpgrader m_ModelWsu;

	private UIModelWeaponProficiency m_ModelWeaponProficiency;

	private UIModelUser m_ModelUser;

	private UILockController m_WeaponProficiencyLockCtrl;

	private UILockController m_WeaponSkinUpgraderLockCtrl;

	private uint m_VfxDelayCallId;

	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

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

	protected override void OnUIDestory()
	{
	}

	protected override void OnInitDepth()
	{
	}

	protected override void OnRecycleUIGameObject()
	{
	}

	private void OnWeaponSkinUpgraderClick()
	{
	}

	private void GotoEvoGun()
	{
	}

	private void GotoSkinLobby()
	{
	}

	private void GotoWeaponProficiency()
	{
	}

	private void StopVfx()
	{
	}

	private void OnWeaponSkiEnternClick()
	{
	}

	private void OnWeaponProficiencyClick()
	{
	}

	private void RefreshEntranceCDNBG()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void RefreshWsuRedPoint()
	{
	}

	private void RefreshWeaponProficiencyEntrance()
	{
	}

	private void RefreshLevelEntrance()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void _003CRefreshEntranceCDNBG_003Eb__21_0()
	{
	}

	private void _003CRefreshEntranceCDNBG_003Eb__21_1()
	{
	}

	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnInitDepth()
	{
	}

	public void _003C_003EiFixBaseProxy_OnRecycleUIGameObject()
	{
	}
}
