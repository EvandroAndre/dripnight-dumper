using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSceneEditPaintPanelView : UIBaseView
{
	public GameObject NormalState;

	public GameObject SolidOrHollow;

	public UIToggleButtonGroup ToggleGroup;

	public UIToggleButton SquareBtn;

	public UIToggleButton TriangleBtn;

	public UIToggleButton CircleBtn;

	public UIToggleButton CustomBtn;

	public UILabel TipsLabel;

	public UIToggleButton Solid;

	public UIToggleButton Hollow;

	public GameObject Tips;

	public UIToggleButtonGroup ShapeToggleBtnGroup;

	public UISprite UnselectSquare;

	public UISprite SelectedSquare;

	public UISprite UnselectTriangle;

	public UISprite SelectedTriangle;

	public UISprite UnselectCircle;

	public UISprite SelectedCircle;

	public UISprite SelectedCustom;

	public UISprite UnselectCustom;

	public Transform OptionGroup;

	public UIButton BackBtn;

	public Transform StepTable;

	public UITable StepGrid;

	public UIButton QuitPaintBtn;

	public GameObject StepContainer;

	public UIButton FinishBtn;

	public UIButton EditBtn;

	public UILabel ThemeName;

	public UILabel ThemeDesc;

	public GameObject ThemeIntro;

	public GameObject ShapeBottom;

	public GameObject TipArrow;

	public UINetworkTexture ThemePic;

	public UIButton GenerateBtn;

	public UISprite GenerateSprite;

	public UILabel ItemsDesc;

	public UIToggleButton Tab1;

	public UIToggleButton Tab2;

	public UIButton Plan1Btn;

	public UIButton Plan2Btn;

	public UISprite Refresh1;

	public UISprite Stop1;

	public UISprite Refresh2;

	public UISprite Stop2;

	public GameObject PaintingState;

	public GameObject GenerateState;

	public GameObject PaintRemind;

	public GameObject GenerateRemind;

	public GameObject QuitPaint;

	public GameObject RaceGroup;

	public GameObject ThemePanel;

	public GameObject RaceObj;

	public UILabel BackLabel;

	public GameObject RaceIcons;

	public Transform StartPoint;

	public Transform EndPoint;

	public UIButton RaceBtn;

	public UIWidget BottomBound;

	public GameObject ShapeSelect;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
