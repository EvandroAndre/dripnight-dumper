using GCommon;
using UnityEngine;

namespace COW;

public class UIActivityScoreItemView : UIBaseView
{
	public UILabel Title;

	public UILabel AccumulateLabel;

	public UIDragScrollView DragView;

	public GameObject ItemRoot;

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
