using GCommon;

namespace COW;

public class UIPrimePrivilegeSmallItemController : UIBaseController
{
	private UIPrimePrivilegeSmallItemView m_View;

	private UIModelPrime m_ModelPrime;

	private bool m_Selected;

	private uint m_PrivilegeId;

	private uint m_Level;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetViewData(uint privilegeId, uint level)
	{
	}

	public void RefreshSelected(uint privilegeId, uint level)
	{
	}

	private void OnSelected()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
