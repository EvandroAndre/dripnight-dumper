using GCommon;
using proto;

namespace COW;

public class UIPrimePrivilegeNormalItemController : UIBaseController
{
	private UIPrimePrivilegeNormalItemView m_View;

	private PrimePrivilegeDesc m_PrimeDesc;

	private uint m_Level;

	private uint m_PrivilegeId;

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

	public void SetViewData(uint privilegeId, uint level, bool isLong = false)
	{
	}

	public void EnableClick(bool enable)
	{
	}

	private void OnButtonClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
