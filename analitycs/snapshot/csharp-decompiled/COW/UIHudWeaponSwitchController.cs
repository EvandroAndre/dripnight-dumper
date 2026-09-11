using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudWeaponSwitchController : UIBaseController
{
	protected UIHudWeaponSwitchView m_View;

	private UIHudWeaponSwitchInfoController m_Primary1WeaponController;

	private UIHudWeaponSwitchInfoController m_Primary2WeaponController;

	private UIHudWeaponSwitchInfoController m_SecondaryWeaponController;

	private UIHudWeaponSwitchInfoController m_MeleeWeaponController;

	private List<UIHudBuildingSwitchInfoController> m_BuildingSwitchBtns;

	private bool m_IsPlayerEffectForSwithWeaponMode;

	private uint m_DelayCallEffectKord;

	private bool m_NeedReposition;

	private List<FDAEPHMIEPC> m_templist;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	public override bool RecyleDontDestroy()
	{
		return false;
	}

	public static bool DontDestroy()
	{
		return false;
	}

	private void RegisterEvents()
	{
	}

	private void RefreshBuildingVisibility(bool show)
	{
	}

	private void RefreshNormalObjVisibility(bool show)
	{
	}

	private void RefreshAlpha(float alpha)
	{
	}

	private void RefreshCtrlVisibility(bool show)
	{
	}

	private void RefreshGridVisibility(bool show)
	{
	}

	private void OnEquipAttachment(object[] data)
	{
	}

	private void OnMoblieHardwareInput()
	{
	}

	private void RefreshUIByWeaponOnHand(int data)
	{
	}

	private void CheckWeaponInvaid()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnWeaponPinMark(HDAEFOANBGJ equipSlot)
	{
	}

	private void OnWeaponModeSwitched(object[] param)
	{
	}

	private void OnSecondWeaponDataEffectiveChanged(object[] param)
	{
	}

	private void OnChangeDepth(uint data)
	{
	}

	private void EnableClickMask(bool enable)
	{
	}

	private void Update()
	{
	}

	private void ShowSwitchWeaponTutorial(int data)
	{
	}

	private void ShowSwitchWeaponTutorialInForceTutorial(object[] data)
	{
	}

	private void RefreshBuildingInfo(NAELPAAELNO item)
	{
	}

	private void OnShowWeaponAffixTip(object[] param)
	{
	}

	private void _003COnSecondWeaponDataEffectiveChanged_003Eb__27_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_RecyleDontDestroy()
	{
		return false;
	}
}
