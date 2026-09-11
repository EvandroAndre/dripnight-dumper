using GCommon;
using UnityEngine;

namespace COW;

public class UIHudFloatingLandProgressBarView : UIBaseView
{
	public UILabel TimeLabel;

	public UIProgressBar ProgressBar;

	public UIWidget TutorialWidget;

	public UIWidget BarPos;

	public UILabel AddTimeLabel;

	public GameObject InfoLabel;

	public UIButton BarInfo;

	public UISprite BarValue;

	public GameObject TeamIcon;

	public Animation Ani;

	public UITexture BarEffectMask;

	public GameObject Booyah;

	public Animator UIHudTimer_Ani;

	public AudioSource UIHudTimerAudio;

	public GameObject ProgressContainer;

	public UITexture BarEffectMask2;

	public UILabel TimerTips;

	public GameObject mask;

	public GameObject UIFX_Time;

	public UITexture BarEffectMask3;

	public TweenPositionArc addScoreEffect;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
