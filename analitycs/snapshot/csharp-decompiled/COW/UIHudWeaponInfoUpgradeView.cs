using GCommon;
using UnityEngine;

namespace COW;

public class UIHudWeaponInfoUpgradeView : UIBaseView
{
	public UIButton GoldWeaponUpgradeBtn;

	public VFXCreateHelper VFXUpgradeBtn;

	public GameObject WeaponAwakenConatiner;

	public UIButton WeaponAwakenCancelBtn;

	public UIButton WeaponAwakenClickBtn;

	public UIButton WeaponAwakenSelection1;

	public UILabel WeaponAwakenSelection1Txt;

	public UIButton WeaponAwakenSelection2;

	public UILabel WeaponAwakenSelection2Txt;

	public GameObject WeaponAwakenChooseState;

	public Animation WeaponAwakenChooseAnim;

	public GameObject GradeProgressMaxOnce;

	public VFXCreateHelper NinthVFXNode;

	public VFXCreateHelper NinthFlyVFXNode;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
