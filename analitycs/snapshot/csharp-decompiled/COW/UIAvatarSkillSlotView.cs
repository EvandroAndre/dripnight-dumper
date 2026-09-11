using GCommon;
using UnityEngine;

namespace COW;

public class UIAvatarSkillSlotView : UIBaseView
{
	public AvatarSelectionSkillSlot SlotScript;

	public UIButton SlotBtn;

	public GameObject SelectedHL;

	public GameObject NormalBG_G;

	public GameObject NormalBG_Y;

	public GameObject NormalBG_R;

	public GameObject NormalBG_N;

	public GameObject Empty;

	public GameObject ActiveSkillLock;

	public GameObject RedTips;

	public GameObject SpeicalGo;

	public GameObject SharedSkillIcon;

	public GameObject SkillSpirte;

	public UISprite EmptySKillIcon;

	public GameObject NotOwnIconBG;

	public UISprite NotOwnIcon;

	public GameObject line01;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
