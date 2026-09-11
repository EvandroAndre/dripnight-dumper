using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSkillGrowthView : UIBaseView
{
	public UIButton BtnClose;

	public UIButton BtnConfirm;

	public GameObject ConfirmEnabled;

	public GameObject ConfirmDisabled;

	public UILabel LabelPlayerLevel;

	public UITable Table;

	public UIGrid GridNewSkills;

	public UIGrid GridOwnedSkills;

	public GameObject NewSkills;

	public GameObject OwnedSkills;

	public UILabel Tips;

	public UIButton BtnRerandom;

	public UILabel RerandomCntDesc;

	public UIButton Mask;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
