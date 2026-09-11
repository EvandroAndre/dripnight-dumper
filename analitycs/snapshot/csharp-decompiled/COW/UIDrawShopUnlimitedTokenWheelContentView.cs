using GCommon;
using UnityEngine;

namespace COW;

public class UIDrawShopUnlimitedTokenWheelContentView : UIBaseView
{
	public UINetworkTexture CDNTitle;

	public UICountDownLabel CountdownLabel;

	public GameObject PrimeTimeCountDown;

	public GameObject VFXContainer;

	public UIButton TitleBtn;

	public GameObject OneAward;

	public GameObject TwoAward;

	public Transform TwoAwardTransformFirst;

	public Transform TwoAwardTransformSecond;

	public GameObject ThreeAward;

	public Transform ThreeAwardTransformFirst;

	public Transform ThreeAwardTransformSecond;

	public Transform ThreeAwardTransformThird;

	public GameObject FourAward;

	public Transform FourAwardTransformFirst;

	public Transform FourAwardTransformSecond;

	public Transform FourAwardTransformThird;

	public Transform FourAwardTransformFourth;

	public GameObject QuickExchange;

	public UIButton ExchangeBtn;

	public UISprite ExchangeIcon;

	public UINetworkTexture CDNExchangeIcon;

	public UILabel OriginalTxt;

	public UILabel ChangedTxt;

	public GameObject ExchangeTips;

	public Transform ChestContainer;

	public Transform DrawShopBuyContainer;

	public GameObject GuaranteedDrop;

	public GameObject NotPrimeLimitBuyTipsTr;

	public GameObject LocalTitle;

	public GameObject TimeContains;

	public UITable ItemTable;

	public UISprite Token1;

	public UILabel Token1Label;

	public UISprite Token2;

	public UILabel Token2Label;

	public UILabel GuaranteedDropOriginalLabel;

	public GameObject GuaranteedDropHighlightContainer;

	public GameObject TokenChangeVFX;

	public Animation Ani;

	public GameObject Local_Bg;

	public GameObject CdnBgGameObject;

	public UINetworkTexture CdnBg;

	public UIWidget WheelGuideWidget2;

	public UIWidget WheelGuideWidget1;

	public UIWidget WheelGuideWidget3;

	public UIWidget WheelGuideWidget4;

	public GameObject TimeBg;

	public GameObject CDNTimeBg;

	public UINetworkTexture CDNTimeBgNetworkTexture;

	public GameObject AniReplayBtnNode;

	public UIButton PlayButton;

	public Transform AnimDownloadCtrlPos;

	public GameObject SubCDNTitleBg;

	public UINetworkTexture SubCDNTitleBgNetworkTexture;

	public GameObject Local_SubTItle;

	public GameObject ExchangeBtnVFXContainer;

	public GameObject BigAwardVFXContainer;

	public VFXCreateHelper UIFX_In;

	public VFXCreateHelper UIFX_DrawShopWheel_In;

	public VFXCreateHelper UIFX_DrawShopWheel_Busrt;

	public VFXCreateHelper UIFX_DrawShopWheel_Loop;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
