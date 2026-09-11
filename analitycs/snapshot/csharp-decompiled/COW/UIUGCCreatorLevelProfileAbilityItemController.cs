using GCommon;

namespace COW;

public class UIUGCCreatorLevelProfileAbilityItemController : UIBaseController
{
	private UIUGCCreatorLevelProfileAbilityItemView m_View;

	private WorkshopCreatorPrivilegeWarp m_PrivilegeInfo;

	private bool m_IsUnlocked;

	public bool IsSelfPrivilege;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(WorkshopCreatorPrivilegeWarp privilegeInfo, uint currentLevel)
	{
	}

	private void OnBackBtnClick()
	{
	}

	private void OnGoposBtnClick()
	{
	}

	private void ShowTips()
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
