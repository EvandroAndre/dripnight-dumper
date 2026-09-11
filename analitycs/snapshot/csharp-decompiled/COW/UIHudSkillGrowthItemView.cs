using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSkillGrowthItemView : UIBaseView
{
	public UISprite SkillIcon;

	public UILabel SkillName;

	public UILabel SkillType;

	public UILabel SkillDesc;

	public GameObject Selected;

	public GameObject Unselected;

	public GameObject Unselectable;

	public GameObject UpgradeSkillIcon;

	public UISprite SkillBgCurLevel;

	public UISprite SkillBgNextLevel;

	public UISprite SkillIconCurLevel;

	public UISprite SkillIconNextLevel;

	public UIButton UIHudSkillGrowthItem;

	public UILabel SkillDescAdditional;

	public UITable Table;

	public UIButton DragScroll;

	public GameObject IsRecommended;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
