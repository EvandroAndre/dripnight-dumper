using GCommon;
using UnityEngine;

namespace COW;

public class UIHudPresetPickSkillItemView : UIBaseView
{
	public UISprite SkillIcon;

	public UIButton SkillBtn;

	public GameObject NormalSkillBG;

	public GameObject EmptyPetSkillContainer;

	public GameObject EmptyTeammateSkillBG;

	public GameObject SkillContainer;

	public GameObject ActiveSkillBG;

	public UISprite NormalSkillBGSprite;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
