using GCommon;
using UnityEngine;

namespace COW;

public class UIWeaponKillNotificationItemView : UIBaseView
{
	public TweenPosition tween;

	public UISprite qualityBG;

	public UISprite iconQualityBG;

	public UISprite icon;

	public UILabel content;

	public UIRelocateToLabelSprite epKillerGlowEffect;

	public UIRelocateToLabelSprite epBeKillerGlowEffect;

	public UIRelocateToLabelSprite bpKillerGlowEffect;

	public UIRelocateToLabelSprite bpBeKillerGlowEffect;

	public UISprite EvoGun2BG;

	public GameObject EvoGun2BGGameObject;

	public UIRelocateToLabelSprite m_BadgeKiller;

	public UIRelocateToLabelSprite m_BadgeBeKiller;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
