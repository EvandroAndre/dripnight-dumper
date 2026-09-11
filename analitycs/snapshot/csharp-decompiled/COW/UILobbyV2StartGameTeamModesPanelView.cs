using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyV2StartGameTeamModesPanelView : UIBaseView
{
	public UISprite teamIconDulicate;

	public UIToggleButton soloBtn;

	public UIWidget soloBtnWidget;

	public UIGrid ModesGrid;

	public UIToggleButtonGroup ModesBtnGroup;

	public UISprite BGFilter;

	public UIScrollView GroupModesScrollView;

	public UIButton PublicBtn;

	public GameObject PublicToggleOn;

	public GameObject PublicToggleOff;

	public UILabel publicLabel;

	public UIToggleButton duoBtn;

	public UIWidget duoBtnWidget;

	public UIToggleButton teamBtn;

	public UIWidget teamBtnWidget;

	public UIToggleButton pentaBtn;

	public UIWidget pentaBtnWidget;

	public UIWidget AutoMatch;

	public UILabel autoLabel;

	public UICheckboxButton checkBtn;

	public UISprite AutoMatchSelect;

	public UISprite AutoMatchUnSelect;

	public UIWidget PublicRoot;

	public GameObject ModesBg;

	public GameObject ModesBigBg;

	public GameObject GroupCodePivot;

	public UIButton CodeCopyBtn;

	public UILabel CodeLabel;

	public UIButton GroupCodeBtn;

	public GameObject GroupCodeDisplay;

	public GameObject BGBigFilter;

	public GameObject scrollbar3;

	public GameObject scrollbar3Big;

	public UIButton GroupCodeHelperBtn;

	public UIPanel UILobbyV2StartGameTeamModesPanel;

	public UIToggleButton teamSoloBtn;

	public UIWidget teamSoloBtnWidget;

	public UIButton GroupQRCodeBtn;

	public GameObject ForceNotAutoMatchLabel;

	public GameObject main;

	public GameObject CheckBoxGrid;

	public GameObject CSPeakContainer;

	public GameObject CSPeakSquadDesc;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
