using GCommon;
using UnityEngine;

namespace COW;

public class UIPaymentSquadTreasureTeamCreatePopupWindowView : UIBaseView
{
	public GameObject main;

	public UILabel NameLabel;

	public UILabel PropertyLabel;

	public UILabel TeamNameLabel;

	public UIButton IsPulicCheckBox;

	public UISprite SpriteToggleBg;

	public UISprite SpriteSelect;

	public UILabel IsPublicLabel;

	public UIButton CancelBtn;

	public UIButton ConfirmBtn;

	public UIButton LeaveBtn;

	public UIButton SaveBtn;

	public UILabel TitleLabel;

	public UIButton Close;

	public UILabel DetailLabel;

	public GameObject TimeGroup;

	public UIToggleButtonGroup TimeLimitToggleGroup;

	public UILabel TimeLimitDescLabel;

	public UISprite BG;

	public UIGrid CheckGroup;

	public GameObject TimeContainer;

	public GameObject ActiveCreateState;

	public GameObject UnActiveCreateState;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
