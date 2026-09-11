using GCommon;
using UnityEngine;

namespace COW;

public class UIWeaponExpItemView : UIBaseView
{
	public UISprite WeaponExpIcon;

	public UILabel WeaponName;

	public UIProgressBar ProgressBarBefore;

	public UIProgressBar ProgressBarIncrease;

	public GameObject UIFX;

	public GameObject ProgressBar;

	public UILabel ReachMaxLabel;

	public UIButton GoPosBtn;

	public UIColor BgColor1;

	public UIColor BgColor2;

	public GameObject WeaponV1Container;

	public GameObject WeaponV2Container;

	public UILabel WeaponV2ExpLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
