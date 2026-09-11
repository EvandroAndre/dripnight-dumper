using GCommon;
using UnityEngine;

namespace COW;

public class UIHudBlockEditMainView : UIBaseView
{
	public UIGrid GridBlockType;

	public UITable TBBlockPreset;

	public GameObject TrashArea;

	public GameObject BlockPresetContainer;

	public UIButton BtnClose;

	public UIHudBlockTypeBtnItemController BtnItem;

	public UILabel BlockName;

	public UIScrollView SVBlockItems;

	public UIButton BtnHelp;

	public UILabel TitleLabel;

	public UIPanel MainPanel;

	public UIButton BtnCreateDynamicBlock;

	public UIHudBlockTypeBtnItemController BtnLocalGraphContent;

	public UIHudBlockTypeBtnItemController BtnGlobalGraphContent;

	public UILabel LabelCreateDynamicBlock;

	public UIScrollBar ScrollBar;

	public Transform BlockCategoryPanel;

	public UIDragScrollView PanelDragScrollView;

	public UIWidget SwitchScriptMenu;

	public UILabel ErrMsgLabel;

	public Transform ErrMsgRoot;

	public UIWidget GuideMask;

	public UIButton BtnSearch;

	public GameObject SearchIcon;

	public GameObject DeleteIcon;

	public GameObject SearchResNormal;

	public UIWidget SearchResAI;

	public GameObject NoResNormalLabel;

	public GameObject NoResAILabel;

	public GameObject AILoadingSmall;

	public GameObject ParameterResultContainer;

	public Transform ParameterResultPanel;

	public UIScrollBar ParameterResultUIScrollBar;

	public UIScrollView ParameterResultUIScrollView;

	public UITable ParameterResultUITable;

	public UILabel ReturnTypeName;

	public UIDragScrollView ParameterResultBG;

	public GameObject Search;

	public GameObject ParameterResultEmptyContainer;

	public UIButton PinBtn;

	public UIButton UnpinBtn;

	public UILabel SearchResNormalTitle;

	public UILabel SearchResAITitle;

	public GameObject BlockTypeMenu;

	public UIButton SearchEnter;

	public UIInput SearchInput;

	public GameObject TrashPanel;

	public GameObject OptionPanel;

	public UIButton BtnDebug;

	public UIButton BtnLog;

	public GameObject MoreBtns;

	public UIButton BtnMore;

	public UISprite BtnMoreIcon;

	public Transform BlockAdjustContainer;

	public UIButton BtnUndo;

	public UISprite SpriteUndo;

	public UIButton BtnRedo;

	public UISprite SpriteRedo;

	public GameObject SearchContainer;

	public Transform SwitchScriptMenuOri;

	public GameObject SwitchPlatform;

	public UIButton BtnOpenSwitchGraph;

	public GameObject FrameSelected;

	public UILabel TitlePlatfrom;

	public GameObject PlatformContainer;

	public UIButton BtnGS;

	public GameObject SelectedGS;

	public UILabel LabelGS;

	public UIButton BtnClient;

	public GameObject SelectedClient;

	public UILabel LabelClient;

	public UIButton PlatformMask;

	public GameObject ClientEmpty;

	public GameObject ClientNew;

	public UIButton BtnTutorial;

	public GameObject SearchDefaultLabel;

	public GameObject ShowTypeContainer;

	public UIButton ShowTypeArrowBtn;

	public UILabel ShowTypeLabel;

	public Transform ShowTypeButtom;

	public UIButton FunctionalBtn;

	public UIButton BtnAttribute;

	public UIButton BtnOpenBlockTemplate;

	public Transform RightContainer;

	public GameObject GSEmpty;

	public GameObject OpenBlockTemplateNew;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
