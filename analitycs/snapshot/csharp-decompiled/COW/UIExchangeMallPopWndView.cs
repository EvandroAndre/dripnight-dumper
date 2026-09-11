using GCommon;
using UnityEngine;

namespace COW;

public class UIExchangeMallPopWndView : UIBaseView
{
	public UIScrollView ScrollView;

	public UIEasyList EasyList;

	public UILabel LabelLimitedCount;

	public UIButton BtnExchange;

	public UISprite ExchangeBtnBG;

	public UILabel ExchangePriceLabel;

	public UISprite ExchangeBuyIcon;

	public UILabel LabelOwnNum;

	public UISprite ExchangeIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
