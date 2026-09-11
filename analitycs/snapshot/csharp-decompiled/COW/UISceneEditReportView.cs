using GCommon;
using UnityEngine;

namespace COW;

public class UISceneEditReportView : UIBaseView
{
	public UILabel Author;

	public UIButton btnConfirm;

	public UIButton btnCancel;

	public UILabel WorkshopName;

	public UIWidget Violation;

	public UIGrid ViolationGrid;

	public GameObject ViolationInputContainer;

	public UICheckboxButton ToggleInstance;

	public UIWidget OtherViolation;

	public UIGrid OtherViolationGrid;

	public GameObject OtherViolationInputContainer;

	public UITable Table;

	public GameObject BeforeConfirm;

	public GameObject AfterConfirm;

	public UIButton BtnAfterConfirm;

	public UIInput ViolationInput;

	public UIInput OtherViolationInput;

	public UIScrollView ScrollView;

	public UILabel LabelTitle;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
