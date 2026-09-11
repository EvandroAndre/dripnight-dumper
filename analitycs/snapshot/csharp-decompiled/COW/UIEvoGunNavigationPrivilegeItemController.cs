using GCommon;

namespace COW;

public class UIEvoGunNavigationPrivilegeItemController : UIBaseController
{
	private UIEvoGunNavigationPrivilegeItemView m_View;

	private WeaponSkinUpgradeInfoData m_UpgeadeInfoData;

	private SkinOwnAndOpenInfo m_WeaponSkinOpenInfoData;

	private UIEvoGunNavigationPrivilegeSubItemController m_SubItemCtrl;

	private bool m_HasSubItem;

	private UIModelWeaponSkinUpgrader m_ModelWeaponSkinUpgrader;

	private int _003CIndex_003Ek__BackingField;

	public int Index
	{
		get
		{
			return _003CIndex_003Ek__BackingField;
		}
		private set
		{
			_003CIndex_003Ek__BackingField = value;
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitView()
	{
	}

	public void SetPrivilegeData(WeaponSkinUpgradeInfoData upgradeInfoData, SkinOwnAndOpenInfo skinOpenInfo, int index)
	{
	}

	public void SetSubItemReference(UIEvoGunNavigationPrivilegeSubItemController subItem)
	{
	}

	public void OnItemClick()
	{
	}

	public void OnItemSelect()
	{
	}

	public void OnItemUnselect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
