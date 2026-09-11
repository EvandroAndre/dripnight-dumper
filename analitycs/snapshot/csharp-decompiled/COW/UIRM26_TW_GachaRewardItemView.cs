using GCommon;
using UnityEngine;

namespace COW;

public class UIRM26_TW_GachaRewardItemView : UIBaseView
{
	public TweenScale UICommonRewardItem;

	public GameObject RewardItem;

	public UILabel LimitLabel;

	public UIToggle RewardToggle;

	public UISprite SelectedSprite;

	public UISprite UnSelectedSprite;

	public UILabel QuantityLabel;

	public GameObject ExchangeVoucher;

	public UISprite VoucherSprite;

	public UILabel VoucherCntLabel;

	public TweenAlpha VoucherTweenAnim;

	public UIProgressBar BeforBar;

	public UIProgressBar AfterBar;

	public GameObject UnPermanent;

	public GameObject Permanent;

	public UILabel BeforeLbl;

	public UILabel AfterLbl;

	public GameObject AfterBarVFX;

	public UIButton TipsBtn;

	public Transform TipsPos;

	public GameObject CantSeleted;

	public UIButton ButtonCantSelected;

	public UISprite UnPermanentIcon;

	public GameObject Finished;

	public UILabel ClanPrivilegeTimeLabel;

	public GameObject ClanPrivilegeContainer;

	public GameObject PermanentContainer;

	public Transform PermenentVFXContainer;

	public UISprite QualityBG;

	public GameObject UIRM26_TW_GachaRewardItem;

	public UISprite PlusSprite;

	public GameObject GotoVault;

	public UIButton GotoVaultBtn;

	public GameObject Quantity;

	public GameObject UIFX_BigReward;

	public GameObject UIFX_CommonReward;

	public GameObject IconBg_Small;

	public GameObject IconBg_Big;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
