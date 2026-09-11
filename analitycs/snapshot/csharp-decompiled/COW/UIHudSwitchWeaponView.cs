using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSwitchWeaponView : UIBaseView
{
	public UIButton BtnSwitch;

	public GameObject SpriteFirst;

	public UILabel LabelInfo;

	public ParticleSystem PaticleEffect;

	public UISprite SpriteSecond;

	public Transform EffectRoot;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
