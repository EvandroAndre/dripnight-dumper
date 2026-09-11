using GCommon;
using UnityEngine;

namespace COW;

public class UINB1RESYS_LobbyWarmUpView : UIBaseView
{
	public UINetworkTexture BgTexture;

	public UICountDownLabel CountDown;

	public UILabel ActivityDesc;

	public UINetworkTexture TitleTexture;

	public UINetworkTexture LeftUpperGiftTex;

	public UINetworkTexture RightGiftTex;

	public UIButton BtnClose;

	public GameObject main;

	public UINetworkTexture CloseTexture;

	public UINetworkTexture LeftLowerGiftTex;

	public UIButton LeftSelectGiftBtn;

	public UIButton RightBigPrizeBtn;

	public UINetworkTexture LeftSelectGiftTex;

	public UINetworkTexture LeftLabelTex;

	public GameObject Select;

	public Animation SelectAnim;

	public UIButton SelectMaskBtn;

	public UIButton SelectBtnClose;

	public UINetworkTexture SelectCloseTexture;

	public UINetworkTexture SelectTitleTexture;

	public UILabel SelectActivityDesc;

	public UINetworkTexture SelectActivityDescTex;

	public UIButton SelectBundleLeftBtn;

	public UINetworkTexture SelectBundleLeftShowTex;

	public UINetworkTexture SelectBundleLeftBgSelectTex;

	public UINetworkTexture SelectBundleLeftBgUnselectTex;

	public UILabel SelectBundleLeftFree;

	public GameObject SelectBundleLeftDiscount;

	public UILabel SelectBundleLeftDiscountTagLabel;

	public UILabel SelectBundleLeftOriginalPriceLabel;

	public UILabel SelectBundleLeftDiscountPriceLabel;

	public GameObject SelectBundleLeftOwned;

	public GameObject SelectBundleLeftChoose;

	public UIButton SelectBundleRightBtn;

	public UINetworkTexture SelectBundleRightShowTex;

	public UINetworkTexture SelectBundleRightBgSelectTex;

	public UINetworkTexture SelectBundleRightBgUnselectTex;

	public UILabel SelectBundleRightFree;

	public GameObject SelectBundleRightDiscount;

	public UILabel SelectBundleRightDiscountTagLabel;

	public UILabel SelectBundleRightOriginalPriceLabel;

	public UILabel SelectBundleRightDiscountPriceLabel;

	public GameObject SelectBundleRightOwned;

	public GameObject SelectBundleRightChoose;

	public UIButton SelectBundleLeftShowBtn;

	public UIButton SelectBundleRightShowBtn;

	public UINetworkTexture SelectBundleLeftOwnedTex;

	public UINetworkTexture SelectBundleLeftPriceMaskTex;

	public UINetworkTexture SelectBundleRightPriceMaskTex;

	public Animation ChangeAni;

	public UINetworkTexture LeftLowerGiftFgTex;

	public UINetworkTexture LeftUpperGiftFgTex;

	public UINetworkTexture SelectBundleLeftFgUnselectTex;

	public UINetworkTexture SelectBundleLeftFgSelectTex;

	public UIButton SelectConfirmBtn;

	public UINetworkTexture SelectConfirmBtnTex;

	public UILabel SelectBundleLeftOwnedTime;

	public GameObject UIFX_SelectBundleLeftBgSelectTex_Glow_L_Once;

	public GameObject UIFX_SelectBundleLeftBgSelectTex_Glow_L_Loop;

	public GameObject UIFX_SelectBundleLeftBgSelectTex_Glow_R_Once;

	public GameObject UIFX_SelectBundleLeftBgSelectTex_Glow_R_Loop;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
