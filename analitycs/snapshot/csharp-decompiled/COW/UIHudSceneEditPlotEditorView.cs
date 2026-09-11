using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSceneEditPlotEditorView : UIBaseView
{
	public GameObject PlotList;

	public UIButton BtnLeave;

	public UIButton BtnNewPlot;

	public UIGrid PlotListGrid;

	public UITable DialogueListTable;

	public GameObject DialogueList;

	public TweenPosition DialogueListOnEditTween;

	public GameObject Inspector;

	public TweenPosition InspectorOnEditTween;

	public GameObject InspectorContainer;

	public UIButton BtnReturn;

	public UILabel PlotListCountLabel;

	public TweenPosition PlotListLeaveTween;

	public UIScrollView DialogueListScrollView;

	public UIPanel DialogueListPanel;

	public GameObject DialogueListTopLeft;

	public UIWidget DialogueListPlotDropdownContainer;

	public UIButton DialogueListBtnEditPlot;

	public UIButton DialogueListBtnEditActor;

	public UIButton BtnPlotPopup;

	public GameObject Empty;

	public GameObject NotEmpty;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
