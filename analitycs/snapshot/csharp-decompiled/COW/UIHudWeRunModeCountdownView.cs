using GCommon;
using UnityEngine;

namespace COW;

public class UIHudWeRunModeCountdownView : UIBaseView
{
	public UILabel CountDownLabel;

	public Animator UIHudTimer_Ani;

	public AudioSource UIHudTimerAudio;

	public GameObject Time;

	public GameObject GameStartGameObject;

	public GameObject CountDownGameObject;

	public AudioSource CountDownAudio;

	public UILabel CountDownLabel2;

	public UILabel Desc;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
