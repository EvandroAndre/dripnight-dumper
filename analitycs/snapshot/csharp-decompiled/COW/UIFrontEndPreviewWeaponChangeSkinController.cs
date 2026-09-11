using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIFrontEndPreviewWeaponChangeSkinController : UIFrontEndPreviewUIComponentTemplateBaseController<UIFrontEndPreviewWeaponChangeSkinBaseView>
{
	protected List<UIToggleButton> m_ChangeSkinBtns;

	private uint m_OriginId;

	private uint m_FirstId;

	private uint m_SecondId;

	private uint m_ThirdId;

	private UIChangeWeaponSkinStatsController m_SkinStatsController;

	private bool m_AutoChange;

	private bool m_IsShow;

	private UIFrontEndPreviewWeaponChangeSkinView m_UIView;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void InitView()
	{
	}

	protected override void InitBaseUIView()
	{
	}

	protected override UIFrontEndPreviewWeaponChangeSkinBaseView InitBaseView()
	{
		return null;
	}

	private void RefreshSwitchCon()
	{
	}

	private void RefreshCollectionItemByWeaponSkinAppear(int index)
	{
	}

	private void ShowWeaponSkin(uint weaponSkinID, bool needWeaponAutoChange = true)
	{
	}

	public void ClickPreviewWeaponChangeSkin()
	{
	}

	public void RefreshCon()
	{
	}

	public bool IsAutoChange()
	{
		return false;
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	public bool IsShowWeaponChangeSkin()
	{
		return false;
	}

	private void _003CRefreshSwitchCon_003Eb__13_0()
	{
	}

	private void _003CRefreshSwitchCon_003Eb__13_1()
	{
	}

	private void _003CRefreshSwitchCon_003Eb__13_2()
	{
	}

	public void _003C_003EiFixBaseProxy_InitView()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}
}
