using GCommon;
using UnityEngine;

namespace COW;

public class UIHudUGCPremiumCenterView : UIBaseView
{
	public UIButton CloseBtn;

	public UIButton BuyBtn;

	public UILabel Price;

	public UIGrid CardContainer;

	public UIButton IntroBtn;

	public UIButton ViewMoreBtn;

	public UILabel SubTitle;

	public UIButton HelpBtn;

	public UILabel Title;

	public UINetworkTexture BGTexture;

	public UINetworkTexture CDN01;

	public UINetworkTexture CDN02;

	public UINetworkTexture CDN03;

	public UILabel RemainMoney;

	public UIButton SubscribeRuleBtn;

	public UILabel CardInfo;

	public UILabel Title01;

	public UILabel Name01;

	public UILabel Name02;

	public UILabel Name03;

	public GameObject ActiveTitle;

	public UILabel ActiveTimeLabel;

	public UILabel ActiveLabel;

	public GameObject Benefit1;

	public GameObject Benefit2;

	public GameObject Benefit3;

	public UICheckboxButton SubscribeBtn;

	public GameObject SubscribeContainer;

	public GameObject DisablePrice;

	public GameObject EnablePrice;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
