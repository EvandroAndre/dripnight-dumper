using GCommon;

namespace COW;

internal class UIEvoGunSpecialGiftPopupWndController : UIPopupWindowController
{
	private UIEvoGunSpecialGiftPopupWndView m_View;

	private UIModelWeaponSkinUpgrader m_ModelWeaponSkinUpgrader;

	private SkinOwnAndOpenInfo m_SkinOwnAndOpenInfo;

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

	public void SetData(BaseItemInfo itemInfo, SkinOwnAndOpenInfo skinOwnAndOpenInfo)
	{
	}

	public void OnClaimButtonClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
