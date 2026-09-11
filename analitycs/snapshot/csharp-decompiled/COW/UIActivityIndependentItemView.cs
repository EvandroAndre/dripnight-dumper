using GCommon;
using UnityEngine;

namespace COW;

public class UIActivityIndependentItemView : UIBaseView
{
	public UILabel Title;

	public UIScrollView ItemScrollView;

	public UILabel AccumulateLabel;

	public UITable ItemsTable;

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
