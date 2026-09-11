using GCommon;
using UnityEngine;

namespace COW;

public class UIHudFireView : UIBaseView
{
	public UIButton BtnFire;

	public Transform ShowEffectPos;

	public UISprite BgCore;

	public UISprite SpriteNormal;

	public Transform iconFire;

	public UISprite iconWidget;

	public Transform DamageBuffGo;

	public Transform fire_BG;

	public UISprite CDProgress;

	public GameObject CDMask;

	public UIWidget UIHudFire;

	public GameObject IconDisable;

	public UISprite SpriteProgMask;

	public GameObject WeaponProficiency;

	public GameObject Decorate01;

	public GameObject Decorate02;

	public GameObject PhantomNode;

	public UISprite PhantomIcon;

	public VFXCreateHelper QTEEffect;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
