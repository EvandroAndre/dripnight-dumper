using GCommon;
using UnityEngine;

namespace COW;

public class UIGachaIchis55RewardItemView : UIBaseView
{
	public TweenScale UICommonRewardItem;

	public Animation UICommonRewardItemAnimation;

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

	public TweenAlphaWatcher VoucherTweenWatcher;

	public GameObject GotoGroup;

	public UILabel GotoPageName;

	public UIButton GotoPageBtn;

	public UISprite GotoPageIcon;

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

	public GameObject PermanentContainer;

	public Transform PermenentVFXContainer;

	public GameObject GotoVault;

	public UIButton GotoVaultBtn;

	public UIButton GotoPhotoGroupBtn;

	public GameObject GotoPhotoGroup;

	public GameObject GotoWeapon;

	public UIButton GotoWeaponBtn;

	public GameObject BeforeOpenBundleVFX;

	public GameObject AfterOpenBundleVFX;

	public UISprite QualityBG;

	public GameObject Plus;

	public Transform VFX;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
