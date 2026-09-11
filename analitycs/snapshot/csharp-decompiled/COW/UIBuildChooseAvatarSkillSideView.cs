using GCommon;
using UnityEngine;

namespace COW;

public class UIBuildChooseAvatarSkillSideView : UIBaseView
{
	public GameObject PassivePart;

	public GameObject NoPassiveSkillTips;

	public GameObject ActivePart;

	public GameObject ActiveReason2;

	public GameObject SkillTip2;

	public UIPanel HelpPanel;

	public Transform TipsTr;

	public UIPanel PassiveSkillPanel;

	public UIScrollView PassiveSkillScrollView;

	public UITable2 PassiveSkillList;

	public UITable2Item PositiveSkillSplit;

	public UIWidget GuideWidget;

	public UIPanel ActiveSkillPanel;

	public UIScrollView ActiveSkillScrollView;

	public UITable2 ActiveSkillList;

	public UITable2Item EquippedActiveSkill;

	public Transform SkillIcon;

	public UISprite AvatarIcon;

	public UILabel AlreadyEquipTip;

	public GameObject ActiveSkillTip;

	public GameObject LoveNode;

	public UIToggleButton ActiveSkilMenu;

	public UIToggleButton PassiveSkillMenu;

	public GameObject RightArrowButton;

	public UIButton SharedSkillBtn;

	public UIButton BtnClose;

	public UIButton EquippedActiveSkillBtn;

	public UITable2Item ActiveSkillSplit;

	public Animation main;

	public UIToggleButton AllBtn;

	public UIToggleButton GroupBtn;

	public UIToggleButton SurviveBtn;

	public UIToggleButton AttackBtn;

	public UIToggleButton InfoBtn;

	public UIInput SearchInput;

	public UIButton SearchButton;

	public UIButton ClearButton;

	public GameObject SearchNoResultContainer;

	public Transform PassivePosWithActiveSkill;

	public Transform PassivePosWithoutActiveSkill;

	public Transform ActiveSkillIcon;

	public UITable2Item PassiveRecSkillSplit;

	public Transform PassiveScrollViewContainer;

	public UIButton SearchEntrence;

	public UIButton SearchQuitBtn;

	public GameObject SearchContainer;

	public UIWidget DragCollider;

	public GameObject AutoScrollBottom;

	public GameObject AutoScrollTop;

	public Transform NewCharacterGuideTransform;

	public GameObject ActiveSkillMenuRedTips;

	public GameObject PassiveSkillMenuRedTips;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
