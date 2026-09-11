using GCommon;
using UnityEngine;

namespace COW;

public class UIHudTKWeaponInfoView : UIBaseView
{
	public UIWidget NormalWidget;

	public TweenAlpha EquipHint;

	public UILabel WeaponName;

	public UISprite WeaponIcon;

	public UILabel WeaponCnt;

	public UIProgressBar progressBar;

	public UISprite foreground;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
