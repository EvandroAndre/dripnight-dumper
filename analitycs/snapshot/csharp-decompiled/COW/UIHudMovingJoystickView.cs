using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMovingJoystickView : UIBaseView
{
	public UIWidget MainWidget;

	public Transform Joystick;

	public Transform JoystickBG;

	public Transform Outjoystick;

	public UISprite RunningTag;

	public GameObject NoLock;

	public UISprite Runing_filing;

	public GameObject HighlightSpr;

	public GameObject VfxObj;

	public GameObject Lock;

	public GameObject Root;

	public GameObject MainPhotoSprite;

	public UIWidget GuideWidget;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
