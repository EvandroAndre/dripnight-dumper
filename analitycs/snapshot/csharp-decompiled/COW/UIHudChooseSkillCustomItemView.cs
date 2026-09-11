using GCommon;
using UnityEngine;

namespace COW;

public class UIHudChooseSkillCustomItemView : UIBaseView
{
	public UISprite SkillSprite;

	public UILabel SkillName;

	public UILabel SkillDesc;

	public GameObject RecommandIcon;

	public UIButton SelectBtn;

	public GameObject SelectedByCurSlot;

	public UILabel OrderMarkLabel;

	public GameObject SelectedMark;

	public UIButton DetailBtn;

	public UISprite AvatarSprite;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
