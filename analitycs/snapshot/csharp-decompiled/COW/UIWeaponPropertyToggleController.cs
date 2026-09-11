using GCommon;

namespace COW;

public class UIWeaponPropertyToggleController : UIBaseController
{
	private UIWeaponPropertyToggleView m_View;

	private uint m_WeaponID;

	private WeaponSpecialMode m_SpecialMode;

	private bool m_IsSelected;

	private uint m_Level;

	public uint WeaponID => 0u;

	public WeaponSpecialMode SpecialMode => WeaponSpecialMode.None;

	public bool IsSelected => false;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnBtnClick()
	{
	}

	public void SetUIData(uint weaponID, bool selected, WeaponSpecialMode specialMode, bool isOriginal, uint level = 0u)
	{
	}

	public void SetSelected(bool selected)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
