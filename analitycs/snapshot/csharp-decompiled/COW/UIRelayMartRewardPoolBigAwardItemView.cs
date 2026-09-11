using GCommon;
using UnityEngine;

namespace COW;

public class UIRelayMartRewardPoolBigAwardItemView : UIBaseView
{
	public GameObject UIRelayMartRewardPoolBigAwardItem;

	public Transform RewardItemContainer;

	public UIButton BtnCartAction;

	public GameObject NormalState;

	public GameObject AddedState;

	public UILabel DiscountLabel;

	public GameObject CoreItemVFX;

	public GameObject OwnedState;

	public GameObject PreviewFemale;

	public GameObject PreviewMale;

	public GameObject PreviewCommon;

	public GameObject LimitedTitle;

	public GameObject OwnedTitle;

	public UISprite QualityBG;

	public GameObject GreyBg;

	public GameObject HighLightBG;

	public UISprite SpriteQualityPlus;

	public UISprite QualityNameBG01;

	public UISprite SpriteOrangeQualityPlus;

	public BaseItemView2 BaseItemView;

	public GameObject ClaimedTitle;

	public UISprite Descargar;

	public UISprite IPTag;

	public UILabel NotReadyLabel;

	public GameObject Lock;

	public UIButton ItemBtn;

	public UIWidget ItemWidget;

	public Animation Animation;

	public GameObject DiamondPriceContainer;

	public UILabel ActualPrice;

	public UILabel OriginalPrice;

	public GameObject GrayState;

	public UINetworkTexture CDNBG;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
