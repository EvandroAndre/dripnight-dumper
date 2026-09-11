using GCommon;
using UnityEngine;

namespace COW;

public class UIFlashStoreNavigationView : UIBaseView
{
	public Transform CountDownContainer;

	public UIButton FreeAcessBtn;

	public UIWidget FreeAcessWidget;

	public GameObject MallContentContainer;

	public UIButton BuyBtn;

	public GameObject TogglesContentContainer;

	public UIScrollView NormalMallTabScrollView;

	public UIGrid TabGrid;

	public UIToggleButtonGroup TabToggleButtonGroup;

	public UIWidget PreviewContainer;

	public UINetworkTexture DiamondStoreLabelCDN;

	public UILabel PeriodIllustrationLabel;

	public GameObject main;

	public UIScrollView ExchangeMallScrollView;

	public UIEasyList ExchangeMallEasyList;

	public UILabel BuyBtnLabel;

	public UILabel LabelLimitedCount;

	public UIToggleButton mallToggle;

	public UIButton RuleButton;

	public GameObject DiamondStoreLabelDefaultSprite;

	public UIPanel GuideMaskPanel;

	public UIButton GuideMaskBtn;

	public UILabel FreeAcessLabel;

	public GameObject FreeAcessCountDownContainer;

	public UIWidget ItemListGuideWidget;

	public Transform CountDownContinerForTitle;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
