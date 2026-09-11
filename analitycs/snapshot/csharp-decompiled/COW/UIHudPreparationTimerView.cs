using GCommon;
using UnityEngine;

namespace COW;

public class UIHudPreparationTimerView : UIBaseView
{
	public GameObject Alien_Skill;

	public UISprite content;

	public UISprite Progress;

	public UILabel TimeLabel;

	public UISprite Progress2;

	public UIButton CancelBtn;

	public UISprite CancelBtnSprite;

	public GameObject Progress3;

	public UIPanel PacemakerAccelerate;

	public VFXCreateHelper PacemakerAccelerateLoop;

	public VFXCreateHelper PacemakerAccelerateProgress;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
