using GCommon;
using UnityEngine;

namespace COW;

public class UIHudHumanlikeTargetDamageResultView : UIBaseView
{
	public UIButton FoldBtn;

	public GameObject Setting;

	public UILabel DPSVal;

	public UILabel RealDamageVal;

	public UILabel ShieldVal;

	public UILabel HeadShotVal;

	public UILabel BodyShotVal;

	public UILabel LimbShotVal;

	public UILabel DPSLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
