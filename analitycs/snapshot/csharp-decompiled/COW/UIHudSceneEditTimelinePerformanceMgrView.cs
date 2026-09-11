using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSceneEditTimelinePerformanceMgrView : UIBaseView
{
	public UITable InspectorTable;

	public UIGrid PerformanceGrid;

	public UIButton BtnNew;

	public GameObject FieldName;

	public UIButton BtnCopy;

	public UIButton BtnDelete;

	public UIButton BtnOpen;

	public UIButton BtnLeave;

	public UILabel LabelTitle;

	public UILabel FieldDurationLabel;

	public UIScrollView PerformanceScrollView;

	public UIInput FieldNameInput;

	public UIButton BtnRename;

	public GameObject EmptyTips;

	public GameObject Inspector;

	public UIToggleButton ToggleHideUI;

	public UIButton BtnHideUI;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
