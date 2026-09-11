using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudWeaponExpansionAbilityController : UIBaseController
{
	private UIHudWeaponExpansionAbilityView m_View;

	private readonly List<UIWeaponExpansionAbilityContentController> m_ContentControllers;

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

	private void OnLocalPlayerInventoryOnHandChanged(object[] data)
	{
	}

	private void OnLocalPlayerEquippedInventoryDropped(object[] data)
	{
	}

	private void HideAllDisplayedContent()
	{
	}

	private bool CleanupMatchedContent(uint inventoryID)
	{
		return false;
	}

	private void CleanupContent()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void TryDisplayContent(uint inventoryID, JLOFMCKFFHB ability)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
