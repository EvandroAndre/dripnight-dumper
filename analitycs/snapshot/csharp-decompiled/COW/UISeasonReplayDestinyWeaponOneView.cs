using GCommon;
using UnityEngine;

namespace COW;

public class UISeasonReplayDestinyWeaponOneView : UIBaseView
{
	public Animation Animation;

	public UILabel Kills;

	public UILabel Demage;

	public UILabel UsedTimes;

	public UILabel WeaponName;

	public GameObject WeaponNameBg;

	public GameObject WeaponTitle;

	public UILabel WeaponTitleRank;

	public UISprite WeaponTitleIcon;

	public UISprite WeaponTitleBg;

	public UIWidget PreviewBorder;

	public GameObject EventListener;

	public UIInput Input;

	public Transform TitleVFXPos;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
