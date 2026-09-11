using COW.GamePlay;
using COW.Gameplay.UGC.BlockEdit;
using GCommon;

namespace COW;

public class UIHudUGCBlockTemplateItemController : UIEasyListItemController
{
	private UIHudUGCBlockTemplateItemView m_View;

	private BlockTemplateData m_BlockTemplateData;

	private BlockTemplateDragDropItem m_DragDropItem;

	public BlockTemplateDragDropItem DragDropItem => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
