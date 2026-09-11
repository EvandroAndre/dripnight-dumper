using GCommon;
using UnityEngine;

namespace COW;

public class UIActivityFestivalContentView : UIBaseView
{
	public UILabel OperationTips;

	public UIButton Operation;

	public GameObject OperateBtnGray;

	public GameObject OperateBtnWhite;

	public GameObject OperateBtnYellow;

	public UILabel OperateBtnTitle;

	public GameObject Gained;

	public UILabel GainedLabel;

	public UIToggleButtonGroup AwardSelectGroup;

	public GameObject ScrollView_NoTabs;

	public GameObject ScrollView;

	public UITable ContentTable;

	public UILabel Introduction;

	public UILabel Time;

	public GameObject AwardTemplate;

	public UIDragScrollView DragArea;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
