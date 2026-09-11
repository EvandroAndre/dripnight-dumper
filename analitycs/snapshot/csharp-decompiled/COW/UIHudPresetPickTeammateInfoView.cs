using GCommon;
using UnityEngine;

namespace COW;

public class UIHudPresetPickTeammateInfoView : UIBaseView
{
	public UILabel SelfName;

	public UILabel TeamIndex;

	public UISprite TeamIndexBG;

	public Transform SkillContainer;

	public GameObject LoadoutContainer;

	public UISprite LoadoutIcon;

	public GameObject LoadoutChangingVFX;

	public Transform SkillChangingVFX;

	public UISprite EmptyLoadoutIcon;

	public Transform SkillChangeSuccessVFX;

	public Transform LoadoutChangeSuccessVFX;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
