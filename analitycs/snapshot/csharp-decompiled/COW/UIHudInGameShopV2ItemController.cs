using System;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIHudInGameShopV2ItemController : UIBaseController, UITable2.IUITable2Item
{
	private enum TopRightContent
	{
		None,
		TimeLimit,
		HotTag,
		NewTag,
		StartSaleTimeLimit
	}

	private enum BackgroundStyle
	{
		Default,
		Customized,
		Highlight,
		TreasureHunt,
		Carni25,
		Ninth
	}

	public class ViewState
	{
		public bool Selected;

		public HEOJAGLBHLJ ShopType;
	}

	private static readonly Color32 m_PurchaseLimitedTextColor;

	private static readonly Color32 m_PurchaseNotLimitedTextColor;

	private static readonly Color32 m_PurchaseLimitedBgColor;

	private static readonly Color32 m_PurchaseNotLimitedBgColor;

	private static readonly Color32 m_ContrastItemNameColor;

	private static readonly Color32 m_RareItemNameColor;

	private static readonly Color32 m_DefaultItemNameColor;

	public static readonly Color DiscountPriceColor;

	private const float m_UnderMaskGroupActiveMaskAlpha = 0.7f;

	private const float m_UnderMaskGroupNoMaskAlpha = 1f;

	private HEOJAGLBHLJ m_ParentShopType;

	private UIHudInGameShopV2ItemView m_View;

	private BGMFPPDLCBB m_ItemInfo;

	private UITimeLabelHelper m_LimitTimer;

	private Action<bool> m_OnGrayMaskActiveStateChanged;

	private readonly BitArrayBoolean m_GrayMaskVisibility;

	private bool m_HasDiscount;

	private UITimeLabelHelper m_StartSaleLimitTimer;

	private uint m_POIMissionTagEffectID;

	private UIHudShopV2ItemPOIMissionTag m_POIMissionTag;

	private Vector3 m_ItemSpriteScale;

	private Quaternion m_ItemSpriteRotation;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void Update()
	{
	}

	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	public void SetPosition(Vector2 position)
	{
	}

	public void SetTable2Visible(bool visible)
	{
	}

	private void AddEventDelegates()
	{
	}

	private void OnItemBtnClicked()
	{
	}

	private static string GetDisplayedPriceContent(int priceForDisplay)
	{
		return null;
	}

	private bool IsCustomizedStyle()
	{
		return false;
	}

	private void OnLimitTimerFinish()
	{
	}

	private UITimeLabelHelper EnsureLimitTimerCreated()
	{
		return null;
	}

	private void OnStartSaleLimitTimerFinish()
	{
	}

	private UITimeLabelHelper EnsureStartSaleLimitTimerCreated()
	{
		return null;
	}

	private void ResetMembersBeforePopulate()
	{
	}

	private void SetupDefaultState()
	{
	}

	private void SetTopRightContentActive(TopRightContent content)
	{
	}

	private TopRightContent GetTargetTopRightContent()
	{
		return TopRightContent.None;
	}

	private BackgroundStyle GetBackgroundStyle(HENEHAGJCLI itemData)
	{
		return BackgroundStyle.Default;
	}

	private Color GetItemNameColor(HENEHAGJCLI itemData)
	{
		return default(Color);
	}

	private void CheckTokenLackGrayCondition()
	{
	}

	private void CheckTimeLimitGrayCondition()
	{
	}

	private void CheckStartSaleTimeLimitGrayCondition()
	{
	}

	private void CheckLimitLackGrayCondition()
	{
	}

	private void CheckCapacityLackGrayCondition()
	{
	}

	private void CheckGameMissionLockGrayCondition()
	{
	}

	private void CheckBattleStyleAbilityGrayCondition()
	{
	}

	private void UpdateGrayCondition(uint condType, bool condValue)
	{
	}

	private void OnGrayMaskActiveStateChanged(bool active)
	{
	}

	private void OnGrayConditionValueUpdated(uint condType, bool condValue)
	{
	}

	private void UpdateItemName(HENEHAGJCLI itemData)
	{
	}

	private void UpdateItemCount()
	{
	}

	private void UpdateIcon(HENEHAGJCLI itemData)
	{
	}

	private void OnItemSpriteSetSpriteNameAsyncSuccess()
	{
	}

	private void UpdateCustomizedBackground(HENEHAGJCLI itemData)
	{
	}

	private void UpdatePriceContent()
	{
	}

	private void UpdatePriceContentColor(bool shortCoin)
	{
	}

	private void UpdateConflictedTopRightContent()
	{
	}

	private void UpdateLimitations()
	{
	}

	private void UpdateLimitationsColor(bool isLimited)
	{
	}

	private void UpdateBattleStyleLimitationContent(bool limited)
	{
	}

	private void CheckAllGrayConditions()
	{
	}

	private void PopulateShopItem(ViewState viewState)
	{
	}

	public void ToggleSelect(bool selected)
	{
	}

	private void SetSkinElement(UISprite sprite, string name)
	{
	}

	public void CheckGrayConditionExternal(uint conditionType)
	{
	}

	public void UpdateLimitationsExternal()
	{
	}

	public void UpdateConflictedTopRightContentExternal()
	{
	}

	private void UpdateActivityItemIconShowState()
	{
	}

	private void UpdateWeaponMountGrenade()
	{
	}

	private void UpdatePOIMissionCardState()
	{
	}

	private void DetachPOIMissionTagEffect()
	{
	}

	private void OnPOIMissionTagLoaded(uint uniqueID, ResourceID vfxResID, GameObject instance)
	{
	}

	private void RefreshPOIMissionTagState()
	{
	}

	private void OnReviveCardDiscountChanged(object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
