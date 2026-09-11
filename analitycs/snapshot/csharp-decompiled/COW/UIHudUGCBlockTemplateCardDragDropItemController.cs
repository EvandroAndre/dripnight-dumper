using COW.Gameplay.UGC.BlockEdit;
using GCommon;

namespace COW;

public class UIHudUGCBlockTemplateCardDragDropItemController : UIBaseController
{
	private UIHudUGCBlockTemplateCardDragDropItemView m_View;

	private BlockTemplateData m_BlockTemplateData;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(BlockTemplateData data, int depth)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
