using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIEVOGunPropertyController : UIBaseController
{
	private UIEVOGunPropertyView m_View;

	private List<UICollectionScoreItemController> m_CollectionScoreItemList;

	private EVOGunPropertyType m_EVOGunPropertyType;

	private uint m_PropertySkinID;

	private uint m_SkillSkinID;

	private uint m_CurSkinID;

	private EvoWeaponType m_CurSkinWeaponType;

	private List<WeaponScoreName> m_WpScoreNotZeroNameList;

	private UIModelWeaponSkinUpgrader m_ModelWeaponSkinUpgrader;

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

	private void SetupDefaultState()
	{
	}

	private void RegisterDelegate()
	{
	}

	private void SetPropertyData()
	{
	}

	private void SetWpSkillData()
	{
	}

	private void OnChangeFeatureClick()
	{
	}

	public void SetViewData(SkinOwnAndOpenInfo curSkinAndOwnInfo, uint propertySkinID = 0u, uint skillSkinID = 0u, List<WeaponScoreName> wpScoreNotZeroNameList = null, bool isClick = false)
	{
	}

	private void RefreshChangedIconSorite(uint prevWeaponSetID)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
