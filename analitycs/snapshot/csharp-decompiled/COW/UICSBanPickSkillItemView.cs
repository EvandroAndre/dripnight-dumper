using GCommon;
using UnityEngine;

namespace COW;

public class UICSBanPickSkillItemView : UIBaseView
{
	public GameObject ActiveSkill;

	public UISprite SkillIcon;

	public UISprite EmptyIcon;

	public GameObject Unusable;

	public UISprite BanLine;

	public GameObject BanBg;

	public GameObject InBan;

	public UISprite SharedSkillIcon;

	public GameObject SelectedBg;

	public GameObject BottomSlot;

	public UISprite SkillSpirte;

	public GameObject Empty;

	public UIButton ClickButton;

	public GameObject BanlResultBG;

	public GameObject SkillBg;

	public GameObject TopInBanVfx;

	public GameObject UnusableTop;

	public Animation SkillAnimation;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
