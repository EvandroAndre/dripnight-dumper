using GCommon;
using proto;

namespace COW;

public class UITopUpEventProgressItemController : UIBaseController
{
	private UIModelActivity m_Model;

	private UITopUpEventProgressItemView m_View;

	private ClientActivityDesc m_Desc;

	private ActivityClientInfo m_Info;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(ClientActivityDesc desc, bool isLast = false)
	{
	}

	public void SetWidth(int width)
	{
	}

	public uint GetCdtValue()
	{
		return 0u;
	}

	public void CalculateProgressValue(uint lastcdtValue)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
