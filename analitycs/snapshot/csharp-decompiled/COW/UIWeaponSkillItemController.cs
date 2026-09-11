using GCommon;

namespace COW;

internal class UIWeaponSkillItemController : UIBaseController
{
	private UIWeaponSkillItemView m_View;

	private uint m_Currentwpid;

	private uint m_CurrentSkinId;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnClear()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetData(uint wpid, uint skinid)
	{
	}

	private void SetUIData(uint wpid, uint skinId = 0u)
	{
	}

	private void OnWeaponSkinChanged(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
