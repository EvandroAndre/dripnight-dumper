using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIDrawShopUnlimitedCardPoolItemController : UIBaseController
{
	private struct StateSkinSpriteData(UISprite sprite)
	{
		public UISprite Sprite = null;

		public string OriginalSpriteName = null;
	}

	public struct ViewSettingData
	{
		public UIButton ItemBtn;

		public BaseItemView2 RewardItem;

		public UISprite Sprite;

		public GameObject MaxState;

		public GameObject OwnState;

		public UILabel MaxNumberLabel;

		public UILabel OwnLabel;

		public Transform BigPrizeVFX;

		public VFXCreateHelper BigPrizeVFXHelper;

		public Transform ClickVFX;

		public UIButton FullScreenPreviewBtn;

		public GameObject SelectedContainer;

		public Animation Ani;

		public AnimEvtForwarderIncludeParam AnimEvtForwarder;

		public AnimatedAlpha AnimatedAlpha;

		public Transform Pos;

		public GameObject ClaimedState;

		public GameObject RedDot;

		public GameObject Mask;

		public GameObject ExchangeVoucher;

		public UILabel VoucherCntLabel;

		public TweenAlpha VoucherTweenAlpha;

		public TweenAlphaWatcher VoucherTweenWatcher;

		public UISprite ExchangeItemTopLeftIcon;

		public GameObject UIFX_Saoguang;

		public VFXCreateHelper UIFX_SaoguangVFXHelper;

		public VFXCreateHelper UIFX_BoomVFXHelper;

		public VFXCreateHelper UIFX_GlowVFXHelper;

		public VFXCreateHelper UIFX_SelectVFXHelper;

		public VFXCreateHelper UIFX_DownVFXHelper;
	}

	private UIDrawShopUnlimitedCardPoolItemView m_View;

	protected UIModelGacha m_ModelGacha;

	protected UIModelDrawShop m_ModelDrawShop;

	private uint m_DrawShopId;

	private uint m_Index;

	private uint m_GoodsId;

	private BaseItemInfo m_ItemInfo;

	private bool m_IsRemove;

	private bool m_IsRare;

	private UIModelDrawShop.RepeatChangeItemInfo m_RepeatChangeInfo;

	private bool m_IsVoucher2;

	private bool m_IsStateSkinSpritesInited;

	private List<StateSkinSpriteData> m_SelectedSkinSprites;

	private List<StateSkinSpriteData> m_OwnedSkinSprites;

	public ViewSettingData m_ViewSettingData;

	private readonly Dictionary<VFXCreateHelper, ResourceID> m_CardPoolVFXResIds;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected virtual void InitViewSettingData()
	{
	}

	public void SetViewData(uint drawShopId, uint indexId, uint goodsId, BaseItemInfo itemInfo, bool isRemove, bool isRare)
	{
	}

	public void SetViewData(uint drawShopId, uint indexId, uint goodsId, BaseItemInfo itemInfo, bool isRemove, bool isRare, UIModelDrawShop.RepeatChangeItemInfo repeatChangeInfo)
	{
	}

	private void RefreshCardPoolVFXResources()
	{
	}

	private void ApplyCardPoolVFX(VFXCreateHelper helper, ResourceID resId)
	{
	}

	private ResourceID GetVFXResourceID(string protocolVFXName, string localVFXName)
	{
		return default(ResourceID);
	}

	private void ReplayCardPoolVFX(VFXCreateHelper vfxHelper)
	{
	}

	private void RefreshItemDisplay()
	{
	}

	protected virtual void RefreshQualityBG(uint quality)
	{
	}

	private void EnsureSkinDataInited()
	{
	}

	private void CacheStateSkinSprites(GameObject container, string[] spriteNameList, List<StateSkinSpriteData> output)
	{
	}

	private bool IsSpriteNameInList(string spriteName, string[] spriteNameList)
	{
		return false;
	}

	private void RefreshChangeSkinDisplay(uint quality)
	{
	}

	private bool IsBRCardPoolSkin()
	{
		return false;
	}

	private void RefreshStateSkinSprites(List<StateSkinSpriteData> spriteDataList, bool isBRSkin, string brSpriteName)
	{
	}

	private string GetBRQualitySpriteName(uint quality)
	{
		return null;
	}

	private void SetSkinSprite(UISprite sprite, string spriteName)
	{
	}

	private void SetQualitySpriteName(string spriteName)
	{
	}

	public virtual void RefreshItemState()
	{
	}

	private bool HasRepeatChangeItem()
	{
		return false;
	}

	private bool HasRepeatChangeItem2()
	{
		return false;
	}

	private void RefreshRepeatChangeDisplay(bool isOwned)
	{
	}

	private void SetRepeatChangeVoucherDisplay(uint itemId, uint itemNum)
	{
	}

	private void StartVoucherCarousel()
	{
	}

	private void StopVoucherCarousel()
	{
	}

	protected void SetVoucherTweenEnabled(bool enabled)
	{
	}

	protected void VoucherCarousel()
	{
	}

	protected void ChangeItemSelectedState(object[] param)
	{
	}

	protected void RefreshItemSelectedState(bool isSelected)
	{
	}

	public void ClearSelectedState()
	{
	}

	protected void OnItemBtnClick()
	{
	}

	public void PlayAnimation()
	{
	}

	public void PlayQuickRefreshVFX()
	{
	}

	private GameObject GetQuickRefreshVFX()
	{
		return null;
	}

	public void SetMaskActive(bool active)
	{
	}

	public void SetVisible(bool visible)
	{
	}

	public void PlayEntranceAnimation()
	{
	}

	public void StopAnimationAndReset()
	{
	}

	protected void OnAnimEvtOccur(object[] param)
	{
	}

	private void RequestRefreshItem()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
