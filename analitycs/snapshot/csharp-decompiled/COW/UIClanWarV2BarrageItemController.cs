using GCommon;

namespace COW;

public class UIClanWarV2BarrageItemController : UIBarrageItemBaseController
{
	private UIClanWarV2BarrageItemView m_View;

	private UIModelClan m_ModelClan;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override bool SetBarrageData(BarrageData barrageData)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
