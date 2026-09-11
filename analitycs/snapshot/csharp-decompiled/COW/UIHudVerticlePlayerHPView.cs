using GCommon;
using UnityEngine;

namespace COW;

public class UIHudVerticlePlayerHPView : UIBaseView
{
	public UILabel LabelName;

	public Transform BulletNode;

	public UIWidget BulletRoot;

	public UIGrid BulletGrid;

	public TweenPosition TweenBulletEmpty;

	public UISprite HPBarNormal;

	public UILabel LabelHP;

	public UILabel DamageLabel;

	public UIWidget BarWidget;

	public GameObject Arrow;

	public GameObject HPNode;

	public Animation HpChangeAnim;

	public UISprite BarBullet;

	public UISprite HPBarYellowShine;

	public UISprite HPBarRedShine;

	public UISprite HPBarChanged;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
