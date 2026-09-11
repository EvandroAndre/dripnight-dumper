using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudWeaponInfoUpgradeController : UIBaseController
{
	private UIHudWeaponInfoUpgradeView m_View;

	private uint m_CurAwakeningWeaponUID;

	private readonly Dictionary<uint, float> m_WeaponAwakenReadyTime;

	private readonly Dictionary<uint, float> m_WeaponUpgradeReadyTime;

	private readonly Dictionary<uint, float> m_WeaponDamageUpgradeReadyTime;

	private readonly Dictionary<uint, float> m_WeaponReplacerUpgradeReadyTime;

	private List<UIHudWeaponInfoAwakenTermSelectItem> m_AwakenTermSelectItems;

	private const string WEAPON_AWAKEN_SELECT_ANI_IN = "UIFX_UIHudWeaponInfoUpgrade_WeaponAwakenChooseState_In";

	private const string WEAPON_AWAKEN_SELECT_ANI_OUT = "UIFX_UIHudWeaponInfoUpgrade_WeaponAwakenChooseState_Out";

	private uint m_NinthVFXDelayCallID;

	private uint m_NinthFlyVFXDelayCallID;

	private static readonly HashSet<uint> s_AliveWeaponUIDTmp;

	private static readonly List<uint> s_DictPurgeTmp;

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

	private void RegisterEvents()
	{
	}

	private void RefreshCtrlVisibility(bool show)
	{
	}

	private void OnInventoryItemChanged(object[] param)
	{
	}

	private void OnReplacerCountChange(object[] param)
	{
	}

	private void RefreshWeaponUpgradeBtnShow()
	{
	}

	private void UpdateAllWeaponReadyTimes(OMELKCOGCBK inventory)
	{
	}

	private void UpdateUpgradeReadyAggregate(uint weaponUID)
	{
	}

	private static void UpdateReadyTime(Dictionary<uint, float> dict, uint weaponUID, bool ready, float now)
	{
	}

	private static void PurgeDroppedFrom(Dictionary<uint, float> dict, HashSet<uint> aliveUIDs)
	{
	}

	private void OnNinthFlyVFXEnd()
	{
	}

	private void HideNinthFlyVFX()
	{
	}

	private void CancelHideNinthFlyVFXDelayCall()
	{
	}

	private void PlayAwakenBtnNinthVFX()
	{
	}

	private void HideAwakenBtnNinthVFX()
	{
	}

	private void CancelAwakenBtnNinthVFXDelayCall()
	{
	}

	private void OnWeaponAwakenRandomTermsUpdate(uint weaponUID)
	{
	}

	private void OnWeaponAwakenTermSelected(uint termId)
	{
	}

	private void OnWeaponProgressMaxOnce()
	{
	}

	private void RefreshWeaponAwakenTermItems(List<uint> termIds)
	{
	}

	private void RefreshWeaponUpgradeBtnShow(bool showUpgrade)
	{
	}

	private void OnClickGoldWeaponUpgrade()
	{
	}

	private void OnClickWeaponAwaken()
	{
	}

	private void OnClickWeaponAwakenCancel()
	{
	}

	private void OnAddObserver(uint data)
	{
	}

	private void OnLocalPlayerRevive(object[] data)
	{
	}

	private void OnPlayerDead(object[] data)
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
