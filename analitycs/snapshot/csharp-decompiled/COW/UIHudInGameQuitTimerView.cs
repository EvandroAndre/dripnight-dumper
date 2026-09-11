using GCommon;
using UnityEngine;

namespace COW;

public class UIHudInGameQuitTimerView : UIBaseView
{
	public UILabel Time;

	public Animator UIHudTimer_Ani;

	public AudioSource UIHudTimerAudio;

	public UILabel MsgTxt;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
