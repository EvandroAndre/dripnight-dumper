using GCommon;

namespace COW;

public class UICSMapPickItemController : UIBaseController
{
	private UICSMapPickItemView m_View;

	private ADCSMapData m_Data;

	private int m_Index;

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

	public void RefreshViewData(ADCSMapData data, int index)
	{
	}

	private void OnClickItemBtn()
	{
	}

	private void OnMapPickItemSelect(object[] args)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
