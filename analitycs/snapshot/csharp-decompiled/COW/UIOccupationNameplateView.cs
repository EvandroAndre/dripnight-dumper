using GCommon;
using UnityEngine;

namespace COW;

public class UIOccupationNameplateView : UIBaseView
{
	public UIButton Shrink;

	public UILabel ShrinkTitle;

	public UIButton Extend;

	public UILabel ExtendTitle;

	public UILabel ShownInfoValueOne;

	public UILabel ShownInfoValueTwo;

	public UILabel ShownInfoValueThree;

	public UILabel ShownInfoTitleOne;

	public UILabel ShownInfoTitleTwo;

	public UILabel ShownInfoTitleThree;

	public UILabel ShrinkRateLabel;

	public UILabel ExtendRateLabel;

	public UIMultiColorAdptor ColorAdptor;

	public GameObject ShrinkBG;

	public GameObject ExtendBG;

	public Animation UIOccupationNameplate;

	public UIPanel Panel;

	public GameObject ExtendBG2;

	public UILabel ExtendRateLabelReverse;

	public UILabel ExtendTitleReverse;

	public UILabel ShrinkTitle01;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
