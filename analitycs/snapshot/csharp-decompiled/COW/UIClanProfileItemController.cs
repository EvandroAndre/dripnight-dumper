using GCommon;

namespace COW;

public class UIClanProfileItemController : UIBaseController
{
	private UIClanProfileItemView m_View;

	private ClanInfo m_Data;

	private UIModelClan m_ModelClan;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(ClanInfo info)
	{
	}

	private void RefreshView()
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
