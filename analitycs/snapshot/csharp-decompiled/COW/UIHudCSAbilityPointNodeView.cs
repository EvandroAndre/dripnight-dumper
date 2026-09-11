using GCommon;
using UnityEngine;

namespace COW;

public class UIHudCSAbilityPointNodeView : UIBaseView
{
	public UIButton AbilityPointBtn;

	public GameObject SelectedState;

	public GameObject DisableState;

	public UISprite DisableGg;

	public GameObject EnableState;

	public UISprite EnableBG;

	public UISprite DisableIcon;

	public UISprite EnableIcon;

	public TweenScale EnableIconTweenScale;

	public GameObject BreathVFX;

	public GameObject UIHudCSAbilityPointNode;

	public Animation RandomNodeAnim;

	public GameObject WeaponPrivilegeContainer;

	public GameObject TechDeviceConatiner;

	public GameObject NormalItemConatiner;

	public UISprite WeaponPrivilegeIcon;

	public UISprite NormalItemIcon;

	public UISprite TechDeviceIcon;

	public UISprite TechDeviceBG;

	public GameObject RandomContainer;

	public VFXCreateHelper CanChooseStateVFX;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
