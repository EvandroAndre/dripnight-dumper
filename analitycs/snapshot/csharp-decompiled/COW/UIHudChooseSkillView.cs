using GCommon;
using UnityEngine;

namespace COW;

public class UIHudChooseSkillView : UIBaseView
{
	public UILabel CountDown;

	public GameObject PresetPage;

	public GameObject CustomPage;

	public UIGrid PresetGrid;

	public UIGrid CustomGrid;

	public UIToggleButtonGroup PageToggleContainer;

	public UIToggleButton PresetToggle;

	public UIToggleButton CustomToggle;

	public UIButton CloseBtn;

	public UILabel SelectedNum;

	public GameObject ActiveSkill2;

	public GameObject ActiveSkill1;

	public GameObject Popover;

	public UILabel PopSkillName;

	public UILabel PopSkillDesc;

	public UITable PassiveTable;

	public UILabel PassiveLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
