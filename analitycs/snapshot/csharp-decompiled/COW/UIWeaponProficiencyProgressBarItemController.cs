using GCommon;
using proto;

namespace COW;

public class UIWeaponProficiencyProgressBarItemController : UIBaseController, IUIModelDataChangeObserver
{
	private UIWeaponProficiencyProgressBarItemView m_View;

	private UIModelWeaponProficiency m_ModelWeaponProficiency;

	private uint m_Level;

	private uint m_WeaponId;

	private UIStandardItemMiniController m_ItemCtrl;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	void IUIModelDataChangeObserver.OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	uint IUIModelDataChangeObserver.GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void SetLevel(uint level)
	{
	}

	public void SetWeaponId(uint weaponId)
	{
	}

	public void RefreshView()
	{
	}

	private void RefreshItem()
	{
	}

	private EActivity.State GetRewardState()
	{
		return EActivity.State.State_RECEIVED;
	}

	private void OnClickBtnAward()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
