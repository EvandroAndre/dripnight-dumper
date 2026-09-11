using GCommon;
using UnityEngine;

namespace COW;

public class UIHudActionView : UIBaseView
{
	public UIButton BtnAction;

	public UILabel ActionNameTxt;

	public UISprite SpriteBg;

	public UISprite BtnIcon;

	public UISprite Cooldown;

	public UIButton Block;

	public UISprite BlockSprite;

	public GameObject FalconIcon;

	public ParticleSystem CDReadyEffect;

	public UISprite IconDisable;

	public UILabel AvailableCnt;

	public GameObject UIHudAction;

	public VFXCreateHelper ClickEffect;

	public GameObject CdReady;

	public GameObject TipJumpEffectRoot;

	public UISprite Progress;

	public UIButton CooldownBtn;

	public GameObject BountPostPriceRoot;

	public UILabel BountyPriceLabel;

	public UISprite BountPriceIcon;

	public UISprite ActionSprite;

	public UILabel ExtraInfoTxt;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
