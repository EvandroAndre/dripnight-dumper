using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyIAPBundleView : UIBaseView
{
	public UIButton IAPBundleButton;

	public UISprite IconSpriteBG;

	public GameObject SrcCountDown;

	public UICountDownLabel SrcCountdownLabel;

	public GameObject CountDownContainer;

	public GameObject IAPBundleNumContainer;

	public UILabel IAPBundleNumLabel;

	public GameObject VFX_shine;

	public VFXCreateHelper VFXCreateHelper;

	public EffectMovement EffectMovement;

	public GameObject VFX_birth;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
