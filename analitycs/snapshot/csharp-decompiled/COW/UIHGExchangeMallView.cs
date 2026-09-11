using GCommon;
using UnityEngine;

namespace COW;

public class UIHGExchangeMallView : UIBaseView
{
	public UILabel Title;

	public GameObject ExchangeMallTypeContainer;

	public UIToggleButton NormalMallToggle;

	public UIToggleButton PreviousRankMallToggle;

	public UIEasyList ExchangeMallEasyList;

	public UIWidget PreviewContainer;

	public UILabel LabelLimitedCount;

	public UILabel BuyBtnLabel;

	public UIButton BuyBtn;

	public UILabel ExchangeCurrencyNum;

	public GameObject BuyBtnGrayBG;

	public GameObject BuyBtnBG;

	public UILabel BuyBtnGrayLabel;

	public UIButton RuleButton;

	public UISprite ExchangeIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
