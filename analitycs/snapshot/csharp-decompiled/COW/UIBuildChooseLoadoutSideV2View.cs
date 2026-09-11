using GCommon;
using UnityEngine;

namespace COW;

public class UIBuildChooseLoadoutSideV2View : UIBaseView
{
	public UIEasyList V2LoadoutItems;

	public UILabel LoadoutName;

	public UILabel LoadoutDesc;

	public UIButton BrBtn;

	public UIButton CsBtn;

	public UIEasyList LoadoutLevels;

	public GameObject CsSelect;

	public GameObject CsUnselect;

	public GameObject BrSelect;

	public GameObject BrUnselect;

	public UIWidget GuideWidget;

	public UIButton GuideBtn;

	public UILabel LockTips;

	public GameObject Guide;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
