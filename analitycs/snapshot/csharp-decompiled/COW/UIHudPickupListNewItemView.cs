using GCommon;
using UnityEngine;

namespace COW;

public class UIHudPickupListNewItemView : UIBaseView
{
	public GameObject light_mask;

	public UITexture Texture;

	public UILabel LabelCount;

	public UIButton BtnItemAction;

	public UILabel ItemName;

	public UIEventListener BtnEventListener;

	public UISprite SpriteItemIcon;

	public UISprite SpriteBackground;

	public GameObject StateIconGO;

	public UISprite StateIcon;

	public UISprite EquipmentDurabilityLostRateMask;

	public GameObject AutoPickupMask;

	public GameObject BountyIcon;

	public GameObject BountyOtherIcon;

	public UISprite IconBuff;

	public GameObject HotTag;

	public GameObject NewTag;

	public GameObject StackBG;

	public Animation UIFXLabelEffect;

	public UILabel LabelEffectCount;

	public Transform UIFXContainer;

	public UISprite SpecialItemBG;

	public GameObject SelectedStateIcon;

	public GameObject NewbieRecommendIcon;

	public UISprite TechDeviceBG;

	public UISprite ActivityBg;

	public GameObject ActivityContainer;

	public UIButton PickToBagBtn;

	public UISprite toBagIcon;

	public Transform HCQualityContainer;

	public UIColor QuailtyBg;

	public UISprite LightBG;

	public UILabel ValueLabel;

	public UILabel WeightLabel;

	public UILabel ScrollItemName;

	public GameObject ReinforcedBG;

	public UISprite WLGP25CoinBG;

	public UISprite EffectLevelBg;

	public UISprite AwakenIcon;

	public UISprite TreasureHuntBG;

	public GameObject Term;

	public UISprite TermIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
