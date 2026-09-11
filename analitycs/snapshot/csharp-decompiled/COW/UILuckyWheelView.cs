using GCommon;
using UnityEngine;

namespace COW;

public class UILuckyWheelView : UIBaseView
{
	public GameObject Title;

	public UINetworkTexture TitileCDN;

	public Transform DrawContainer;

	public GameObject DrawHintVfx;

	public Transform Reward0;

	public Transform Reward1;

	public Transform Reward2;

	public Transform Reward3;

	public Transform Reward4;

	public Transform Reward5;

	public Transform Reward6;

	public Transform Reward7;

	public GameObject ResetCircleVfx;

	public GameObject glow01;

	public GameObject glow02;

	public GameObject glow03;

	public GameObject glow04;

	public GameObject glow05;

	public GameObject glow06;

	public GameObject glow07;

	public GameObject glow08;

	public UIButton DrawBtn;

	public Animation DrawBtnAnimation;

	public UISprite DrawBtnSprite;

	public GameObject DrawBtnVfx;

	public UILabel DrawLabel;

	public GameObject CurrentDiscount;

	public UILabel CurrentDiscountLabel;

	public GameObject CurrentPrice;

	public UILabel CurrentPriceLabel;

	public GameObject RewardPoolRefreshVfx;

	public UIButton RewardPoolBtn;

	public UIButton RewardPoolCloseBtn;

	public GameObject CanNotRefreshLabel;

	public GameObject RewardPoolContainer;

	public UILabel DescriptionLabel;

	public UIGrid ItemGrid;

	public UIButton RefreshRewardPoolBtn;

	public UILabel RefreshPriceLabel;

	public UISprite RefreshPriceIcon;

	public UILabel FreeRefreshLabel;

	public UILabel RewardPoolDiscountLabel;

	public UILabel OffLabel;

	public UILabel OffLabelWidget;

	public UILabel RewardPoolPriceLabel;

	public GameObject ShowDiscountVfx;

	public GameObject RewardPoolPreviewContainer;

	public UIScrollView ScrollView;

	public UIEasyList PreviewItemEasyList;

	public GameObject FinishedHintLabel;

	public GameObject OwnDiscountVfx;

	public GameObject DrawResultVfx;

	public UINetworkTexture BGCDN;

	public UIButton InterfaceMask;

	public Transform TimeContainer;

	public GameObject Content;

	public UILabel RefreshTipLabel;

	public GameObject FreeTag;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
