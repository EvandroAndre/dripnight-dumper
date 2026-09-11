using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSceneEditPlotEditorActorPopupEditorView : UIBaseView
{
	public UIButton BtnLeave;

	public UILabel TitleLabel;

	public UIButton BtnNewActor;

	public UIGrid ActorListGrid;

	public UIInput FieldActorNameInput;

	public UIGrid FieldIconGrid;

	public UIButton BtnDelete;

	public GameObject FieldActorName;

	public GameObject FieldIcon;

	public UIScrollView FieldIconScrollView;

	public UIScrollView ActorListScrollView;

	public GameObject Empty;

	public GameObject NotEmpty;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
