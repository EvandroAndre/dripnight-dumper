using GCommon;

namespace COW;

internal class UIWeaponSkinPokedexPreviewController : UIPreviewPopUpWindowController, IUIModelDataChangeObserver
{
	private UIWeaponSkinPokedexPreviewView m_View;

	private uint m_WeaponSkinId;

	private uint m_WeaponId;

	private WeaponSkinData m_WeaponSkinData;

	private UIModelCollection m_ModelCollection;

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

	protected override void OnUIDestroy()
	{
	}

	protected override void OnUIClose()
	{
	}

	public override void OnNavigationClosed()
	{
	}

	public void SetPreviewInfo(uint itemID, BaseItemInfo itemInfo)
	{
	}

	private void RefreshZoomBtn()
	{
	}

	private void OnEquipBtnClick()
	{
	}

	private bool IsWeaponSkinExpired()
	{
		return false;
	}

	private void RefreshEquipBtn()
	{
	}

	private void SetEquipBtnActive(bool wantActive)
	{
	}

	private bool CanShowEquipBtn()
	{
		return false;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	protected override FrontendPreviewType GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}

	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}
}
