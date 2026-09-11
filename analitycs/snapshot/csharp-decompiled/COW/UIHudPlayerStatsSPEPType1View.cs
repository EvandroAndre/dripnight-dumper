using GCommon;
using UnityEngine;

namespace COW;

public class UIHudPlayerStatsSPEPType1View : UIBaseView
{
	public GameObject EPNode;

	public UILabel LabelEP;

	public UISprite EPBarBG;

	public UISprite EPBar;

	public VFXCreateHelper VFXPlayerSkillPersonaEPUp;

	public VFXCreateHelper VFXPlayerSkillPersonaEPDown;

	public UISprite EPBarGradient;

	public UISprite MushRoomEPBar;

	public GameObject SPNode;

	public GameObject SPItemList;

	public UIHudPlayerSPItem SPItem;

	public GameObject BloodPoolUseEpMinMark;

	public GameObject BloodPoolUseEpMaxMark;

	public VFXCreateHelper UIFXPersonaBreakSP;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
