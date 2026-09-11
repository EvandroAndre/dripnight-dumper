using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudInventoryEntryController : UIBaseController
{
	public const uint VISIBILITY_STATE_EighthLand = 1073741824u;

	public const uint VISIBILITY_STATE_IIVFloatingLand = 536870912u;

	public const uint VISIBILITY_STATE_GB_GPGulag = 268435456u;

	private UIHudInventoryEntryView m_View;

	public static readonly Color32 CommonColor;

	public static readonly Color32 MaxColor;

	public bool InventoryDisabled;

	private uint m_DelayCall;

	private uint m_UpgradeGemGetTypeDelayCall;

	private uint m_TransferItemGetEffectID;

	private UIHudLoadoutV3QuickUseController m_LoadoutV3QuickUseCtrl;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
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

	private void OnBtnInventoryClick()
	{
	}

	private void OnAddLocalPlayer(object[] param)
	{
	}

	private void OnCapacityRefresh(bool param = false)
	{
	}

	private void OnInventoryPickup(object[] param)
	{
	}

	private void OnInventoryNoCapacityToPickup(object[] param)
	{
	}

	private void ShowTutoDropCamouflageOpenBag(object[] param)
	{
	}

	private void OnInventoryUpdateLevel(object[] param)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void OnRichInventory(object[] param)
	{
	}

	private void OnUpgradeGemGetType(bool isFragment)
	{
	}

	private void OnEnableInventory(object[] param)
	{
	}

	private void OnTrainingZoneChanged(object[] param)
	{
	}

	private void OnAmmoCountGuide()
	{
	}

	private void RemoveAmmoCountGuide()
	{
	}

	private void OnTransferItemGet(uint resIcon)
	{
	}

	private void HideTransferEffect()
	{
	}

	private void CheckLoadoutV3QuickUse(NAELPAAELNO item)
	{
	}

	private void _003COnRichInventory_003Eb__21_0()
	{
	}

	private void _003COnUpgradeGemGetType_003Eb__22_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
