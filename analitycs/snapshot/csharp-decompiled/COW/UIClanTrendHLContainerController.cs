using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

internal class UIClanTrendHLContainerController : UIBaseController
{
	private UIClanTrendHLContainerView m_View;

	private List<UIClanTrendHighLightShowItemController> m_HLShowItemList;

	public int HLConatinerIndex;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void AddNewHighLightItem(ClanHighLightInfo info)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
