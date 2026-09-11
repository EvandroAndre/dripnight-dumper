using GCommon;
using UnityEngine;

namespace COW;

public class UIHudHippoCrisisIncomeMatchResultView : UIBaseView
{
	public GameObject SuccessContainer;

	public GameObject FailedContainer;

	public UILabel IncomeLabel;

	public UISprite GradeIcon;

	public UIButton BackMaskBtn;

	public UIButton NextBtn;

	public UIButton ShareBtn;

	public UILabel NewRecordLabel;

	public UIEasyList IncomeEasyList;

	public UILabel GotNothingLabel;

	public Transform BriefBoxRoot;

	public Transform ColorGroup;

	public UILabel ShareGameModeTxt;

	public UILabel userIDTxt;

	public UITexture BG;

	public UIButton SkipBtn;

	public Transform LevelB;

	public Transform LevelA;

	public Transform LevelS;

	public Transform LevelSS;

	public Transform LevelSSS;

	public Transform UIFX_SSSRoot;

	public Transform UIFX_SSRoot;

	public Transform UIFX_SRoot;

	public Transform UIFX_ARoot;

	public Transform UIFX_Money;

	public Transform SkipLabel;

	public Animation IncomeContainer;

	public Transform GradeIconVFX;

	public UISprite GradeIcon2;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
