using GCommon;
using UnityEngine;

namespace COW;

public class UIHudRMDFoodTipsView : UIBaseView
{
	public UILabel LabelHint;

	public GameObject EatIcon;

	public GameObject EatFull;

	public UISprite EatProgress;

	public UISprite ProgressFinished;

	public GameObject AnimGo;

	public Animation Anim;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
