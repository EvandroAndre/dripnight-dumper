using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIHudCollectionTrialPrivilegeShowController : UIBaseController
{
	private UIHudCollectionTrialPrivilegeShowView m_View;

	private UIModelCollectionTrial m_ModelCollectionTrial;

	private UIModelWeaponSkinUpgrader m_ModelWeaponSkinUpgrader;

	private List<UIPrivilegeItemIconController> m_PrivilegeItemIconControllers;

	private uint m_WeaponSkinId;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void RefreshPrivilege()
	{
	}

	private void OnPrivilegeGridClick(int index)
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
