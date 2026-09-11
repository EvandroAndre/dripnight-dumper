using GCommon;
using UnityEngine;

namespace COW;

public class UIWeaponSkinCustomAppearanceItemView : UIBaseView
{
	public UISprite WeaponIcon;

	public UILabel Name;

	public UISprite QualityBg;

	public UISprite SpriteQualityPlus;

	public UISprite SpriteOrangeQualityPlus;

	public GameObject DownloadInfo;

	public UIButton ItemBtn;

	public UIWidget GuideWidget;

	public GameObject time;

	public UILabel timeLabel;

	public GameObject SeletedHL;

	public GameObject IconEvoPass;

	public GameObject MutliSelectState;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
