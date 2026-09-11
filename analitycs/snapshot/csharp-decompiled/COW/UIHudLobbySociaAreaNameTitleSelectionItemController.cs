using GCommon;
using proto;

namespace COW;

public class UIHudLobbySociaAreaNameTitleSelectionItemController : UIEasyListItemController
{
	private UIHudLobbySociaAreaNameTitleSelectionItemView m_View;

	private UILobbySocialAreaTitleCommonController m_LobbySocialTitleCtrl;

	private ESocialHall.TitleType m_TitleType;

	private bool m_Selected;

	public ESocialHall.TitleType TitleType => ESocialHall.TitleType.TitleType_NONE;

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

	private void RefreshTitle()
	{
	}

	private void OnSelectBtnClick()
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	public void SetSelected(bool selected)
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
