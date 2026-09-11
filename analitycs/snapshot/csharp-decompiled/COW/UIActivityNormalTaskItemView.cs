using GCommon;
using UnityEngine;

namespace COW;

public class UIActivityNormalTaskItemView : UIBaseView
{
	public UIScrollView ItemScrollView;

	public UIGrid ItemsGrid;

	public UILabel Title;

	public UILabel AccumulateLabel;

	public UIDragScrollView DragView;

	public UISprite Daily;

	public GameObject main;

	public UITable ButtonTable;

	public UIButton Operation;

	public GameObject BGWhite;

	public GameObject BGGray;

	public GameObject BGYellow;

	public GameObject Gained;

	public UILabel GainedLabel;

	public UILabel OperationTitle;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
