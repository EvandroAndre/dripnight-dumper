using GCommon;
using UnityEngine;

namespace COW;

public class UIHudTrainingDeadSummaryView : UIBaseView
{
	public UILabel title;

	public UILabel KillLabel;

	public UILabel AssisLabel;

	public UILabel HitRateLabel;

	public UILabel HeadShotRate;

	public GameObject assisNums;

	public UITable Table;

	public UIButton DetailBtn;

	public UILabel KillTitle;

	public UILabel AssisTitle;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
