using GCommon;
using UnityEngine;

namespace COW;

public class UIHudInGameShopItemView : UIBaseView
{
	public UIToggleButton ItemBtn;

	public UIWidget ItemWidget;

	public UIEventListener ItemEventListener;

	public UISprite bg02;

	public GameObject OneObjectContainer;

	public UISprite itemSprite;

	public UILabel LabelItemCount;

	public GameObject TwoObjectContainer;

	public UISprite itemSprite1;

	public UISprite itemSprite2;

	public UILabel ItemName;

	public GameObject Highlight;

	public UISprite CoinIcon;

	public UILabel Price;

	public GameObject CD;

	public TweenAlpha CDTweenA;

	public UILabel LabelCD;

	public GameObject GrayMask;

	public TweenAlpha GrayMaskTweenA;

	public UILabel Limitation;

	public UILabel SoldOut;

	public UISprite qualityBg;

	public UISprite bonus;

	public UISprite TagNew;

	public UILabel LabelLimitNum;

	public UILabel LabelStackNum;

	public UIButton OthersChoosingMask;

	public UIButton InfoBtn;

	public UILabel InfoLabel;

	public GameObject UIHudInGameShopItem;

	public Animation RootAnim;

	public GameObject stateicon;

	public GameObject Recommend;

	public GameObject Level1;

	public GameObject Grade;

	public GameObject Level2;

	public GameObject Level3;

	public UISprite IconBuff;

	public GameObject IconTeam;

	public GameObject BuffLevel3;

	public GameObject BuffLevel2;

	public GameObject BuffLevel1;

	public UIEventListener DetailBtn;

	public UIWidget DetailBtnWidget;

	public GameObject DetailInfo;

	public UISprite DetailInfoSprite;

	public UIEventListener BuffDetailBtn;

	public UILabel ResetTime;

	public GameObject NewItemTag;

	public GameObject TechPoint;

	public UIGrid TechGrid;

	public UILabel TimeLimit;

	public GameObject TimeLimitRoot;

	public GameObject BattleLevelLimitedGroup;

	public UILabel BattleLevelLimitedText;

	public UISprite SpecialItemBG;

	public UISprite lockIcon;

	public GameObject BooyahBountyPoint;

	public UILabel BooyahBountyPointLabel;

	public VFXCreateHelper BooyahBountyVFX;

	public UISprite BooyahBountyIcon;

	public Transform AdditionalContainer;

	public GameObject NewbieRecommendIcon;

	public Transform MysteryBoxVfx;

	public GameObject bg;

	public UISprite ActivityBg;

	public UISprite ActivityIcon;

	public UISprite TechDeviceBG;

	public GameObject TagNewIcon;

	public GameObject EffectRoot;

	public GameObject PriceRoot;

	public UILabel TeamLimitation;

	public GameObject TeamLimitationBg;

	public GameObject TeamLimitationDisableBg;

	public GameObject UpgradedBg;

	public VFXCreateHelper LoadoutReinforceVFX;

	public GameObject WeaponMountgrenade;

	public UIButton LoadoutReinforceBtn;

	public UILabel ReinforceTokenLabel;

	public GameObject LoadoutReinforceNormalBg;

	public GameObject LoadoutReinforceDisableBg;

	public GameObject UnlockShopBg;

	public GameObject HighlightCSAbilityPoint;

	public GameObject CSAbilityPointObtainLabel;

	public VFXCreateHelper CSAbilityReplaceVFX;

	public UISprite SurpriseItemTag;

	public GameObject SurpriseItem;

	public VFXCreateHelper CSAbilityCanChooseVFX;

	public UILabel OriginalPrice;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
