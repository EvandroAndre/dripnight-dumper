using GCommon;
using UnityEngine;

namespace COW;

public class UIHudTakeTurnsShopItemBaseView : UIBaseView
{
	public UIToggleButton ItemBtn;

	public UIWidget ItemWidget;

	public UIEventListener UIEventListener;

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

	public GameObject CSMysteryBoxVFX;

	public UISprite TagNew;

	public UILabel LabelLimitNum;

	public UILabel LabelStackNum;

	public UIButton OthersChoosingMask;

	public UIButton InfoBtn;

	public UILabel InfoLabel;

	public GameObject UIHudTakeTurnsShopItemBase;

	public GameObject stateicon;

	public GameObject ReplacerTip;

	public UILabel ReplacerMaxTip;

	public GameObject ReplacerEffectRoot;

	public GameObject ReplacerNormallEffect;

	public GameObject ReplacerMaxEffect;

	public UISprite IconBuff;

	public GameObject BuffLevel1;

	public GameObject BuffLevel2;

	public GameObject BuffLevel3;

	public UIEventListener DetailBtn;

	public GameObject DetailInfo;

	public UIEventListener BuffDetailBtn;

	public Transform AdditionalContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
