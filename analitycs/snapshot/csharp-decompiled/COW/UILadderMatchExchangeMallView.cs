using GCommon;
using UnityEngine;

namespace COW;

public class UILadderMatchExchangeMallView : UIBaseView
{
	public GameObject AnimationMain;

	public UILabel Title;

	public GameObject SliderNode;

	public GameObject ExchangeMallTypeContainer;

	public UIToggleButton NormalMallToggle;

	public UIToggleButton PreviousRankMallToggle;

	public UIEasyList ExchangeMallEasyList;

	public UINetworkTexture BigPrizeCDN;

	public UIWidget PreviewContainer;

	public UIScrollView ExchangeMallScrollView;

	public UILabel LabelLimitedCount;

	public UILabel BuyBtnLabel;

	public UISprite BuyIcon;

	public UIButton BuyBtn;

	public UILabel BigPrizePeriodLabel;

	public GameObject UILadderMatchExchangeMall;

	public UILabel ExchangeCurrencyNum;

	public GameObject ExchangeCurrencyBtn;

	public GameObject BuyBtnGrayBG;

	public GameObject BuyBtnBG;

	public UILabel BuyBtnGrayLabel;

	public UIButton RuleButton;

	public UILabel SeasonIconLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
