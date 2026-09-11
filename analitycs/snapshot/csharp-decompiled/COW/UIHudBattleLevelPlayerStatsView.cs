using GCommon;
using UnityEngine;

namespace COW;

public class UIHudBattleLevelPlayerStatsView : UIBaseView
{
	public UIWidget GuideWidget;

	public UIButton GuideBtn;

	public UISprite BuildIcon;

	public UILabel LevelText;

	public UISprite ExpBar;

	public UIEventListener PopoverPressBtn;

	public Transform PopoverPivot;

	public UISprite LevelAbilityIcon;

	public UILabel LevelAbilityDescText;

	public GameObject LevelUpBannerGroup;

	public Animation LevelUpAnim;

	public UISprite ExpBarBg;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
