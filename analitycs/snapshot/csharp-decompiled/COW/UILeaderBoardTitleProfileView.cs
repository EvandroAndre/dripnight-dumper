using GCommon;
using UnityEngine;

namespace COW;

public class UILeaderBoardTitleProfileView : UIBaseView
{
	public UIButton ConfirmBtn;

	public UIScrollView TitleScrollView;

	public UITable2 TitleTable;

	public GameObject Label;

	public UIButton RemoveBtn;

	public UIToggleButton BattleRoyalBtn;

	public UIToggleButton CounterStrikeBtn;

	public GameObject EmptyNode;

	public GameObject ButtonGroup;

	public GameObject ToggleGroup;

	public UIToggleButtonGroup ToggleButtonGroup;

	public UILabel NoMessageHint;

	public UIButton BtnSetRegion;

	public UILabel LabelSet;

	public GameObject WeaponTitleEquipment;

	public UIToggleButton Clanbtn;

	public UILeaderBoardTitleProfileTable2Item TitleSplit;

	public UILeaderBoardTitleProfileTable2Item EmptyGopos;

	public UIGrid ToggleGrid;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
