using GCommon;

namespace COW;

internal class UIHudInvUpgradeItemController : UIBaseController
{
	private UIHudInvUpgradeItemView m_View;

	private int m_Level;

	private int m_Exp;

	private bool m_Last;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetUIData(InGameLevelUpgrade upgradeLevel, bool last)
	{
	}

	public void UpdateUpgradeItemState()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
