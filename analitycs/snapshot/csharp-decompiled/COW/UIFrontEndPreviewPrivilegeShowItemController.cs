using GCommon;

namespace COW;

public class UIFrontEndPreviewPrivilegeShowItemController : UIBaseController
{
	private UIFrontEndPreviewPrivilegeShowItemView m_View;

	private UIModelTailor m_ModelTailor;

	private UIModelWeaponSkinUpgrader m_ModelWeaponSkinUpgrader;

	private bool m_IsWeaponPrivilege;

	private uint m_DataID;

	private bool m_IsExpandItem;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetWeaponPrivilegeData(uint featureId, bool isExpandItem = false)
	{
	}

	public void SetTriggerEffectData(uint triggerID, bool isExpandItem = false)
	{
	}

	private void OnItemClick()
	{
	}

	public bool IsWeaponPrivilege()
	{
		return false;
	}

	public uint GetDataID()
	{
		return 0u;
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
