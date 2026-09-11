using GCommon;
using UnityEngine;

namespace COW;

public class UIHudBlockEditCustomEventWndView : UIBaseView
{
	public GameObject Empty;

	public GameObject NotEmpty;

	public UIInput EventNameInput;

	public UIGrid ParamListGrid;

	public UIButton ParamListBtnAdd;

	public UIButton BtnNewEvent;

	public UIButton BtnLeave;

	public UIGrid EventListGrid;

	public UIPanel PopupRoot;

	public UIButton PopupRootBtn;

	public UILabel EventNameTitle;

	public UILabel ParamListTitle;

	public UILabel DispatchTargetTitle;

	public UIClickInputView EventNameClickInput;

	public UISprite ParamListBtnAddIcon;

	public GameObject ParamListNotEmpty;

	public GameObject ParamListEmpty;

	public UILabel ParamListEmptyLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
