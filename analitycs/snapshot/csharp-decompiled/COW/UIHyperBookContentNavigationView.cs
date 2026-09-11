using GCommon;
using UnityEngine;

namespace COW;

public class UIHyperBookContentNavigationView : UIBaseView
{
	public GameObject BookPageDetailsPanel;

	public UISprite BookPageDetailsBG;

	public UILabel PageIndexLabel;

	public UIButton PageHelpBtn;

	public UILabel PageDetailsLabel;

	public GameObject FunctionWidget;

	public UIButton FunctionBtn;

	public UILabel FunctionBtnLabel;

	public UILabel RemainSpinCountLabel;

	public GameObject UnlockProgressGroup;

	public UICenterTargetHelper UnlockProgressGroupHelper;

	public UILabel UnlockProgessTokenLabel;

	public UISprite UnlockProgressTokenIcon1;

	public UIButton GotoLockedPageBtn;

	public UILabel GotoLockedPageLabel;

	public UIGrid BookProgressPageGrid;

	public UIWidget PreviewBorderWidget;

	public UIButton GotoStoreBtn;

	public GameObject NormalPageDecoLine;

	public GameObject HiddenPageDecoLine;

	public GameObject GuideMaskPanel;

	public UIButton GuideMask;

	public Animation OnNaviPushAnim;

	public GameObject PreviewChangedVFX;

	public GameObject PageUnlockVFX;

	public Animation PageUnlockAnim;

	public GameObject TurnNextPageVFX;

	public GameObject TurnPreviousPageVFX;

	public GameObject ParticleGatheringVFX;

	public UILabel DebugBookModelContentLabel;

	public GameObject BookHiddenPageHead;

	public UILabel HiddenPageHeadLabel;

	public GameObject ProbablityUPShining;

	public UISprite UnlockProgressTokenIcon2;

	public GameObject Equip;

	public UIButton EquipBtn;

	public UISprite StoreIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
