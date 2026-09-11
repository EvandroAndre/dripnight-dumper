using GCommon;

namespace COW;

public class UIPrimePrivilegeSuperBadgeController : UIBaseController
{
	private UIPrimePrivilegeSuperBadgeView m_View;

	private UIPrimePrivilegeBadgeController m_badgeCtrl;

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

	public void RefreshCDNPreviewSize(bool expand)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
