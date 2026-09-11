using GCommon;

namespace COW;

public class UICloseFriendBarrageItemController : UIBarrageItemBaseController
{
	private UICloseFriendBarrageItemView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override bool SetBarrageData(BarrageData data)
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
