using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIMallV2ItemWeaponBaseController : UIEasyListItemController
{
	protected CSSharedItemData m_ItemData;

	protected UIModelMall m_ModelMall;

	protected UIModelGift m_ModelGift;

	protected UIModelRankingItem m_ModelRankingItem;

	protected UIModelLadderMatch m_LadderModel;

	protected CSSharedItemData m_EffectedItemData;

	protected bool m_IsUniqueAndOwned;

	protected bool m_HavePurchaseTimes;

	protected uint m_ItemIconGrey;

	protected uint m_ItemIconWhite;

	protected bool m_NeedClearCache;

	protected bool m_IsItemABReady;

	protected bool m_ShowInstallmentInfo;

	protected ShowBoostAvatarParams m_ShowBoostAvatarParams;

	protected BaseItemInfo m_BaseItemInfo;

	private UIStandardItemWeaponTagController m_ItemTagController;

	protected bool m_NeedRefreshUIOnPreview;

	protected UIButton ItemBtn;

	protected UIWidget ItemWidget;

	protected GameObject NormalContainer;

	protected MallWeaponItemView BaseInfoView;

	protected GameObject HighLightBG;

	protected UISprite BG;

	protected UISprite BGQualityLine;

	protected UISprite SpriteQualityPlus;

	protected UISprite SpriteOrangeQualityPlus;

	protected GameObject BG_grey;

	protected GameObject LimitedTitle;

	protected UISprite Descargar;

	protected Transform GoldContainer;

	protected UILabel GoldPriceLabel;

	protected Transform DiamondContainer;

	protected UILabel DiamondPriceLabel;

	protected Transform ExchangeContainer;

	protected UILabel ExchangePriceLabel;

	protected UISprite ExchangeIcon;

	protected GameObject UniquedTitle;

	protected GameObject OtherChannelContainer;

	protected UILabel DiscountTag;

	protected UISprite RankIcon;

	protected GameObject DefaultContainer;

	protected UILabel ClanLevelTitle;

	protected Transform ClanDiamondContainer;

	protected UILabel ClanDiamondPriceLabel;

	protected GameObject OverDueTitle;

	protected GameObject Default;

	protected UINetworkTexture NetworkTexture;

	protected UIGrid PriceContainer;

	protected UISprite IPTag;

	protected GameObject GemsAndGoldContainer;

	protected UILabel DualCurrencyGemsPrice;

	protected UILabel DualCurrencyGoldPrice;

	protected UILabel OriginalGemsPriceLabel;

	protected UILabel OtherChannelTitle;

	protected UISprite OtherChannelIcon;

	protected Transform ApadtTrans;

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public override void OnItemBtnClick2()
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	protected bool IsWeaponBox()
	{
		return false;
	}

	protected virtual void SendItemClickEvent()
	{
	}

	protected virtual void SendClothClickEvent()
	{
	}

	protected virtual void OnClothItemClick()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	public virtual void SetHighLightBGState(bool show)
	{
	}

	public void RefreshTag(EInventory.StoreTag tag_type, uint tag_value, ulong expireTime)
	{
	}

	public void HideAllTag(UIStandardItemWeaponTagController itemTagCtrl)
	{
	}

	protected virtual bool CanShowDiscountTag()
	{
		return false;
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	protected virtual void RefreshItemView()
	{
	}

	protected virtual void ResetState()
	{
	}

	protected void InitItemData(uint itemID, uint displayRare = 0u)
	{
	}

	protected virtual void SetLimitedTitleState()
	{
	}

	protected virtual void SetUniquedTitleState()
	{
	}

	public virtual void RefreshItemBGState()
	{
	}

	protected void SetOtherChannelState(StoreDesc storeDesc)
	{
	}

	private void AnimationEventHandler(object[] data)
	{
	}

	protected virtual void OnStartToggleMove()
	{
	}

	protected virtual void OnFinishToggleMove()
	{
	}

	public UIStandardItemWeaponTagController GetItemTagCtrl(bool ensureCreated)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnClick2()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}
}
