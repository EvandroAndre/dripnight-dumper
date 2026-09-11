using GCommon;
using UnityEngine;

namespace COW;

public class UIEventTriggerView : UIBaseView
{
	public UISprite triggerImg;

	public UISprite triggerBG;

	public TweenAlpha TweenAlphaBg;

	public UILabel Distance;

	public UILabel BGM;

	public UILabel Time;

	public UILabel BGS;

	public GameObject VFX;

	public GameObject VFXKnockdown;

	public UISprite TriggerProgress;

	public UISprite TriggerProgressbg;

	public VFXCreateHelper ProgressTintEffect;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
