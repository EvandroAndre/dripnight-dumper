using GCommon;
using UnityEngine;

namespace COW;

public class UIWeaponSkinCustomSkillItemView : UIBaseView
{
	public UISprite SkillIcon;

	public UILabel SkillLabel;

	public UIButton ItemBtn;

	public GameObject Selected;

	public GameObject UnSelected;

	public UISprite UnSelectedSkillIcon;

	public UILabel UnSelectedSkillLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
