using System;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIUGCHudInternalPurchaseItemController : UIBaseController, UITable2.IUITable2Item
{
	private enum BackgroundStyle
	{
		Default,
		Highlight
	}

	private static readonly Color32 m_PurchaseLimitedTextColor;

	private static readonly Color32 m_PurchaseNotLimitedTextColor;

	private static readonly Color32 m_PurchaseLimitedBgColor;

	private static readonly Color32 m_PurchaseNotLimitedBgColor;

	private static readonly Color32 m_ContrastItemNameColor;

	private static readonly Color32 m_DefaultItemNameColor;

	private const float m_UnderMaskGroupActiveMaskAlpha = 0.7f;

	private const float m_UnderMaskGroupNoMaskAlpha = 1f;

	private UIUGCHudInternalPurchaseItemView m_View;

	private UIModelUGCCommerceIAP m_Model;

	private WorkshopProductInfo m_Data;

	private UITimeLabelHelper m_LimitTimer;

	private Action<bool> m_OnGrayMaskActiveStateChanged;

	private readonly BitArrayBoolean m_GrayMaskVisibility;

	private bool m_CanPurchase;

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

	private void OnLimitTimerFinish()
	{
	}

	private UITimeLabelHelper EnsureLimitTimerCreated()
	{
		return null;
	}

	private void ResetMembersBeforePopulate()
	{
	}

	private void SetupDefaultState()
	{
	}

	private BackgroundStyle GetBackgroundStyle()
	{
		return BackgroundStyle.Default;
	}

	private Color GetItemNameColor()
	{
		return default(Color);
	}

	private void CheckLimitLackGrayCondition()
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

	private void UpdateItemName()
	{
	}

	private void UpdateIcon()
	{
	}

	private void UpdateBackground()
	{
	}

	private void UpdatePriceContent()
	{
	}

	private void UpdateTimeLimitContent()
	{
	}

	private void UpdateLimitations(bool isLimited)
	{
	}

	private void CheckAllGrayConditions()
	{
	}

	private void PopulateShopItem()
	{
	}

	public void CheckGrayConditionExternal(uint conditionType)
	{
	}

	public void UpdatePriceContentExternal()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
