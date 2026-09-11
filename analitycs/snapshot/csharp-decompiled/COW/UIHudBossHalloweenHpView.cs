using GCommon;
using UnityEngine;

namespace COW;

public class UIHudBossHalloweenHpView : UIBaseView
{
	public UIProgressBar HpProgress;

	public GameObject HittingVfx;

	public GameObject BuffGroup;

	public GameObject BuffActive;

	public GameObject BuffDeActive;

	public UILabel BuffTips;

	public UIEventListener BuffClickArea;

	public GameObject BuffClickTips;

	public GameObject BuffActionBg;

	public GameObject BuffDeActionBg;

	public GameObject BuffChangeTips;

	public TweenAlpha BuffTweenAlpha;

	public Transform BuffActionIcon;

	public Transform BuffDeActionIcon;

	public UILabel BuffClickTipsContent;

	public UISprite BossIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
