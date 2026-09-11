using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudReinforcedAnviWeaponInfoController : UIBaseController
{
	private UIHudReinforcedAnviWeaponInfoView m_View;

	private Dictionary<int, UIHudReinforcedAnviWeaponAttachmentItemController> m_AttachmentsDict;

	private FDAEPHMIEPC m_BindWeapon;

	private uint m_BindWeaponUniqueID;

	private uint m_ReinforceAnimEffectHideDelayID;

	private uint m_LastRequestedUniqueID;

	private uint m_RefreshAttachmentDelayCallID;

	public static uint CurrentSelectedWeaponUniqueID;

	private int m_CurTokenCnt;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnItemSelect()
	{
	}

	private void OnReinforceBtnClick()
	{
	}

	private void OnNotEnoughTokenBtnClick()
	{
	}

	private void OnWeaponSelected()
	{
	}

	private void OnTokenChanged(int data)
	{
	}

	private void OnReinforceRefresh(uint uniqueID)
	{
	}

	private void TryStopAndHideReinforceAnimEffect()
	{
	}

	private void OnReinforceSuccess(uint uniqueID)
	{
	}

	public void UpdateWeaponData(FDAEPHMIEPC weapon, bool force = false)
	{
	}

	public uint GetBindWeaponUniqueID()
	{
		return 0u;
	}

	public void UpdateWeaponAttachmentData(FDAEPHMIEPC weapon)
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void RefreshAttachmentState()
	{
	}

	public void RefreshWeaponState()
	{
	}

	private void InitUIData(FDAEPHMIEPC weapon)
	{
	}

	private void UpdateSelectedState()
	{
	}

	private void RefreshPriceLabel()
	{
	}

	private void _003COnReinforceRefresh_003Eb__16_0()
	{
	}

	private void _003COnReinforceSuccess_003Eb__18_0()
	{
	}

	private void _003CUpdateWeaponAttachmentData_003Eb__21_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
