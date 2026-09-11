using GCommon;
using UnityEngine;

namespace COW;

public class UIHudChooseSkillSlotView : UIBaseView
{
	public UISprite AvatarSprite;

	public UIButton SelectBtn;

	public UILabel ActiveSkillName;

	public GameObject SlotEmpty;

	public UISprite SlotSprite;

	public GameObject Selected;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
