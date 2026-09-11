using GCommon;
using UnityEngine;

namespace COW;

public class UIHudUpgradeGemGetView : UIBaseView
{
	public UISprite ToGem;

	public UISprite FromGem;

	public UIHudUpgradeGemStateItem CompleteGemGroup;

	public UILabel ProgressLabel;

	public UIHudUpgradeGemStateItem AbilityGemGroup;

	public UISprite AbilityIcon;

	public UILabel AbilityGetLabel;

	public GameObject FragmentGetAnim;

	public GameObject CompleteGetAnim;

	public Animation AbilityAnim;

	public GameObject AbilityGetAnim;

	public GameObject PreShow;

	public GameObject NextShow;

	public VFXCreateHelper VFXGemFlash01;

	public VFXCreateHelper VFXGemFlash02;

	public VFXCreateHelper VFXGemFlash03;

	public VFXCreateHelper VFXGemFlash04;

	public VFXCreateHelper VFXFragmentGet;

	public VFXCreateHelper VFXCompleteGet;

	public UILabel FragProgressLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
