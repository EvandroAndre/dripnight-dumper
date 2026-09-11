using GCommon;
using UnityEngine;

namespace COW;

public class UIHudAuxAimView : UIBaseView
{
	public UIButton BtnAuxAim;

	public GameObject SpriteSelectedRoot;

	public UISprite SpriteSelected;

	public UISprite SpriteNormal;

	public Transform iconFire;

	public UISprite iconWidget;

	public UISprite OuterCircleBG;

	public GameObject DirectionGroup;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
