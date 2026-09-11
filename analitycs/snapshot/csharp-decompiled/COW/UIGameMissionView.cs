using GCommon;
using UnityEngine;

namespace COW;

public class UIGameMissionView : UIBaseView
{
	public GameObject EmptyMissionRoot;

	public GameObject GameMissionTitleBG;

	public UITable GameMissionRoot;

	public Transform OpenArrowRoot;

	public UIScrollView GameMissionScroll;

	public GameObject EmptyBRRoot;

	public GameObject EmptyCSRoot;

	public GameObject DetailContentRoot;

	public Transform CloseArrowRoot;

	public UIButton CloseArrowBtn;

	public Transform CloseSidebar;

	public UIButton OpenArrowBtn;

	public Transform OpenPos;

	public GameObject MissionTab;

	public GameObject GameplayAffixTab;

	public UIButton GotoMissionTabBtn;

	public UIButton GotoAffixTabBtn;

	public GameObject GameplayAffixEmptyContentRoot;

	public UIScrollView GameplayAffixScrollView;

	public UIPanel GameplayAffixScrollViewPanel;

	public Transform GameplayAffixTableBottom;

	public UITable GameplayAffixTable;

	public GameObject GameplayAffixContentRoot;

	public GameObject MissionTabSelected;

	public GameObject MissionTabNotSelected;

	public GameObject AffixTabSelected;

	public GameObject AffixTabNotSelected;

	public UIButton GotoLegendTabBtn;

	public GameObject LegendNotSelected;

	public GameObject LegendSelected;

	public Transform ClosePos;

	public GameObject LegendTab;

	public UIScrollView ItemScrollView;

	public Transform LegendGridTrans;

	public UIGrid LegendGrid;

	public Transform ArrowGroup;

	public UIColor ArrowBg;

	public UISprite AffixTabSelectedIcon;

	public UISprite AffixTabNotSelectedIcon;

	public Transform TopEventContentRoot;

	public Transform GameAffixContentAllRoot;

	public UISprite CustomizedAffixTabSelectedIcon;

	public UISprite CustomizedAffixTabNotSelectedIcon;

	public Transform GameAffixContentAllRootDefaultPos;

	public UIButton GotoFFWSFlagTabBtn;

	public GameObject FFWSFlagTabSelected;

	public GameObject FFWSFlagtNotSelected;

	public GameObject FFWSFlagTab;

	public UISprite FFWSNotSelectedMissionIcon;

	public UISprite FFWSSelectedMissionIcon;

	public GameObject UpgradeGemSrcTrans;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
