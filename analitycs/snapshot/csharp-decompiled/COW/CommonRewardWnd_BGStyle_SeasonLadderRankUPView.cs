using GCommon;
using UnityEngine;

namespace COW;

public class CommonRewardWnd_BGStyle_SeasonLadderRankUPView : UIBaseView
{
	public UILabel TitleLabel;

	public GameObject VFX;

	public UIGrid BtnGroup;

	public UIButton RepurchaseBtn;

	public UILabel RepurchaseLabel;

	public UILabel FreeLabel;

	public UICountDownIcon CountDownIcon;

	public UICountDownLabel GachaCountDownLabel;

	public UISprite CurrencyIcon;

	public UILabel CurrencyCountLabel;

	public UIButton OKBtn;

	public UIButton CancelBtn;

	public UIButton OpenBtn;

	public UIButton FastEquipBtn;

	public UIButton ChooseBtn;

	public GameObject VoucherGroup;

	public UIButton ExchangeBtn;

	public GameObject VoucherBtn;

	public Animation VoucherCarousel;

	public UILabel TotalVoucherCnt1;

	public UILabel CurVoucherCnt1;

	public UISprite VoucherIcon1;

	public GameObject Voucher2;

	public UILabel TotalVoucherCnt2;

	public UILabel CurVoucherCnt2;

	public UISprite VoucherIcon2;

	public UILabel Tips;

	public GameObject PurchaseSingle;

	public GameObject PurchaseMixed;

	public UISprite PurchaseMixedConsumeIcon;

	public UILabel PurchaseMixedConsumeCountLabel;

	public UISprite PurchaseMixedCurrencyIcon;

	public UILabel PurchaseMixedCurrencyCountLabel;

	public GameObject TokenTowerProgress;

	public UISprite TokenTowerToken;

	public UILabel TokenTowerTokenNum;

	public UIProgressBar TokenTowerProgressBar;

	public UISprite SpotSprite;

	public UIWidget VoucherGuideWidget;

	public Transform VoucherGuideContainer;

	public GameObject UIFX_ProgressComplete;

	public UISprite Token;

	public GameObject OKBtnFastEquip;

	public UICheckboxButton OKBtnFastEquipCheckBox;

	public GameObject TokenObtained;

	public UISprite RankIcon;

	public UILabel GuideLabel;

	public UILabel RankLabel;

	public GameObject RankRewardGuide;

	public GameObject Box;

	public Transform UnlockMatchRewardItemGridPos;

	public UIButton RankRewardGoposBtn;

	public GameObject RankRewardGoposContainer;

	public GameObject FirstRankRewardContainer;

	public Transform FirstRankRewarPos;

	public Transform FirstRankRankUpRewardPos;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
