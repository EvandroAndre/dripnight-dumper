using GCommon;
using UnityEngine;

namespace COW;

public class UIChooseSkillWindowView : UIBaseView
{
	public GameObject PassivePart;

	public GameObject NoPassiveSkillTips;

	public GameObject ActivePart;

	public GameObject NoActiveSkillTips;

	public UIPanel HelpPanel;

	public Transform TipsTr;

	public UIPanel PassiveSkillScrollView;

	public UITable2 PassiveSkillList;

	public UITable2Item PassiveSkillSplit;

	public UIWidget GuideWidget;

	public UIPanel ActiveSkillScrollView;

	public UITable2 ActiveSkillList;

	public UITable2Item EquippedActiveSkill;

	public Transform SkillIcon;

	public UISprite AvatarIcon;

	public UILabel AlreadyEquipTip;

	public GameObject ActiveSkillTip;

	public UITable2Item ActiveSkillSplit;

	public GameObject LoveNode;

	public UIToggleButton ActiveSkilMenu;

	public UIToggleButton PassiveSkillMenu;

	public GameObject TailArrow;

	public UIButton SharedSkillBtn;

	public Animation UIChooseSkillWindow;

	public UIToggleButton AllBtn;

	public UIToggleButton GroupBtn;

	public UIToggleButton SurviveBtn;

	public UIToggleButton AttackBtn;

	public UIToggleButton InfoBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
