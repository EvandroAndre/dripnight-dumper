using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIEvoGunNavigationPrivilegeSubItemController : UIBaseController
{
	private UIEvoGunNavigationPrivilegeSubItemView m_View;

	private SkinOwnAndOpenInfo m_WeaponSkinOpenInfoData;

	private UIModelWeaponSkinUpgrader m_ModelWeaponSkinUpgrader;

	private List<UICollectionScoreItemController> m_CollectionScoreItemList;

	private WeaponSkinFeature m_WeaponSkinFeature;

	private bool m_IsSoundSpecial;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(SkinOwnAndOpenInfo weaponSkinOpenInfoData, WeaponSkinFeature skinFeature)
	{
	}

	private void SetPropertyDesc()
	{
	}

	private void SetSkillDesc()
	{
	}

	public void PropertyReposition()
	{
	}

	private void RefreshSoundToggleBtnState(bool isSpecial)
	{
	}

	public void OnSoundOriginalToggleBtnClick()
	{
	}

	public void OnSoundSpecialToggleBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
