using GCommon;
using UnityEngine;

namespace ReactUI;

public class UIDropdownListItemController : UIEasyListItemController
{
	private int DataIndex;

	private UILabel NameLabel;

	private UIButton SelectButton;

	private GameObject SelectedFrame;

	public UIVariableBindDropdownList Owner;

	public override void SetViewData(object data, int data_index)
	{
	}

	private void OnSelectButtonClick()
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}
}
