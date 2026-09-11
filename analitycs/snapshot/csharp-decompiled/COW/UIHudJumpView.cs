using GCommon;
using UnityEngine;

namespace COW;

public class UIHudJumpView : UIBaseView
{
	public UISprite BGJump;

	public GameObject Effect_VFX;

	public UIButton BtnJump;

	public UISprite BtnSprite;

	public UISprite EnergyBar;

	public GameObject IconDisable;

	public GameObject Container;

	public VFXCreateHelper ClickEffect;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
