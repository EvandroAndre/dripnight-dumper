using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSceneEditPlotEditorPlotPopupEditorView : UIBaseView
{
	public UITable InspectorTable;

	public UIGrid PlotGrid;

	public UIButton BtnNewPlot;

	public GameObject FieldPlotId;

	public GameObject FieldName;

	public GameObject FieldTriggerType;

	public UIInput FieldNameInput;

	public UIButton BtnCopy;

	public UIButton BtnDelete;

	public UIButton BtnOpen;

	public UIButton BtnLeave;

	public UILabel LabelTitle;

	public UILabel FieldPlotIdLabel;

	public UILabel FieldTriggerTypeLabel;

	public UIButton FieldTriggerTypeBtnHelp;

	public UIScrollView PlotScrollView;

	public GameObject Empty;

	public GameObject NotEmpty;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
