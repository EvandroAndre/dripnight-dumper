using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIProfileEPWindowController : UIPopupWindowController
{
	private UIProfileEpWindowShowView m_View;

	private const uint ROW_ITEM_MAX_NUM = 6u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetUIdata(List<BasicEPInfo> info, int type = 0)
	{
	}

	private void SetOldData(List<BasicEPInfo> info)
	{
	}

	private void SetNewData(List<BasicEPInfo> info)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
