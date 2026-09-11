using GCommon;
using proto;

namespace COW;

public class UIprofileEpsmallController : UIBaseController
{
	private UIProfileEPSMallItemView m_View;

	private UIModelBooyahPass m_BPModel;

	private uint m_EPEventId;

	private BasicEPInfo m_EPInfo;

	private const uint EVENT_BASE = 1001000000u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void RefreshData(BasicEPInfo info)
	{
	}

	protected override void OnUIClose()
	{
	}

	private void OnTipsButtonHover(bool flag)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
