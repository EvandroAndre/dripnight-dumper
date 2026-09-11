using System.Collections.Generic;
using GCommon;

namespace COW;

public abstract class UIFrontEndPreviewWeaponSkinUpgradeBaseController : UIFrontEndPreviewUIComponentTemplateBaseController<UIFrontEndPreviewWeaponSkinUpgradeBaseView>
{
	private List<UIToggleButton> m_WeaponUpgradeBtn;

	private const string PRIVILEGE_KEY = "WeaponSkinUpgradeNewPrivilege";

	private bool m_IsHasNewPrivilege;

	private uint m_CachedItemID;

	protected override void InitView()
	{
	}

	private void InitWeaponSkinUpgradeBtnList()
	{
	}

	private void OnGotoWeaponSkinUpgraderClick()
	{
	}

	public void OnSetWeaponSkinUpgradeLevel(bool isMaxLv)
	{
	}

	public void OnRefreshWeaponPropertyScore(int maxLevel)
	{
	}

	public void RefreshTipsContainer()
	{
	}

	public void RefreshWeaponSkinUpgradeItemByLv(ECollectionLevel collectionLevel)
	{
	}

	public void _003C_003EiFixBaseProxy_InitView()
	{
	}
}
