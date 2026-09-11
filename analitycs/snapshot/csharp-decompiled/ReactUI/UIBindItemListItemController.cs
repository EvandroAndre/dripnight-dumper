using GCommon;

namespace ReactUI;

public class UIBindItemListItemController : UIEasyListItemController
{
	private int DataIndex;

	public UIVariableBindItemList Owner;

	private bool m_isRegisterButtonCallback;

	private bool m_isHaveSelfButton;

	public override void SetViewData(object data, int data_index)
	{
	}

	protected virtual void OnSelect(bool selected)
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}
}
