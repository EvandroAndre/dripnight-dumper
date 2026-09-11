using GCommon;
using UnityEngine;

namespace COW;

public class UIWeaponSkinCustomAttributeItemView : UIBaseView
{
	public UISprite WeaponIcon;

	public GameObject DownloadInfo;

	public UIButton SwitchBtn;

	public GameObject SwitchTip;

	public GameObject NormalTip;

	public UIButton ItemBtn;

	public UIWidget GuideWidget;

	public GameObject time;

	public UILabel timeLabel;

	public GameObject SelectedHL;

	public GameObject PvpProperty;

	public GameObject PveProperty;

	public UIGrid PvpGrid;

	public UIGrid PveGrid;

	public UISprite WeaponIconWithoutSwitchBtn;

	public UISprite QualityBg;

	public UISprite SpriteQualityPlus;

	public UISprite SpriteOrangeQualityPlus;

	public GameObject ZombieTip;

	public GameObject IconEvoPass;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
