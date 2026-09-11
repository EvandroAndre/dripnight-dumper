using GCommon;
using UnityEngine;

namespace COW;

public class UIHudLuckyDrawBoxView : UIBaseView
{
	public UIButton RefreshBtn;

	public UILabel RefreshPrice;

	public UILabel BuyPrice;

	public UIGrid ItemGrid;

	public UIButton CloseBtn;

	public UISprite LevelBg;

	public UILabel Level;

	public UILabel CountDownDesc;

	public GameObject NormalRefreshVfx;

	public GameObject LevelUpRefreshVfx;

	public UIWidget GuideWidget;

	public UIButton GuideBtn;

	public UIButton BuyBtn;

	public UIWidget BuyBtnWidget;

	public ParticleSystem LevelUpRefreshVfx1;

	public ParticleSystem LevelUpRefreshVfx2;

	public ParticleSystem LevelUpRefreshVfx3;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
