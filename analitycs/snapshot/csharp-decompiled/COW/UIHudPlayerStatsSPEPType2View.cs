using GCommon;
using UnityEngine;

namespace COW;

public class UIHudPlayerStatsSPEPType2View : UIBaseView
{
	public UILabel LabelSP;

	public GameObject SPNode;

	public GameObject SPItemList;

	public UIHudPlayerSPItem SPItem;

	public GameObject EPNode;

	public GameObject BloodPoolUseEpMinMark;

	public GameObject BloodPoolUseEpMaxMark;

	public GameObject EPItemList;

	public UIHudPlayerEPItem EPItem;

	public VFXCreateHelper VFXPlayerSkillPersonaEPUp;

	public VFXCreateHelper VFXPlayerSkillPersonaEPDown;

	public UISprite VFXPlayerSkillPersonaBar;

	public UIWidget EPBarGuideWidget;

	public VFXCreateHelper UIFXPersonaBreakSP;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
