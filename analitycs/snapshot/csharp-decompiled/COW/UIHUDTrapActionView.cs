using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDTrapActionView : UIBaseView
{
	public GameObject InTrapRoot;

	public UILabel InTrapCountDownLabel;

	public UISprite InTrapCountDownSprite;

	public GameObject RescureTrapRoot;

	public UIButton RescureBtn;

	public GameObject SpriteOther;

	public GameObject RescureCountDownRoot;

	public UILabel RescureCountDownLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
