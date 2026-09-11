using GCommon;
using UnityEngine;

namespace COW;

public class UIForgeItemView : UIBaseView
{
	public UIButton UIForgeItem;

	public GameObject Default;

	public UITexture LocalImg;

	public UINetworkTexture NetworkTexture;

	public GameObject HighLightBG;

	public SetRelativeDepth ItemVFX;

	public UISprite BG;

	public UISprite BigAward;

	public UITable PriceContainer;

	public UISprite Material1Icon;

	public UILabel Material1Cnt;

	public GameObject Add;

	public UISprite Material2Icon;

	public UILabel Material2Cnt;

	public UISprite PriceBG;

	public GameObject OwnedTitle;

	public UILabel TimeLabel;

	public GameObject Duration;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
