using GCommon;
using UnityEngine;

namespace COW;

public class UIMallV2ExchangeCDNItemView : UIBaseView
{
	public UIButton UIMallV2ExchangeCDNItem;

	public UIWidget Widget;

	public TweenAlpha TweenAlpha;

	public GameObject Default;

	public UINetworkTexture NetworkTexture;

	public GameObject HighLightBG;

	public GameObject UniquedTitle;

	public GameObject ExchangeContainer;

	public UILabel ExchangePriceLabel;

	public UISprite ExchangeIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
