using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UIHudCSShopController : UIHudInGameShopBaseController, IUIModelDataChangeObserver
{
	private sealed class _003CDelayCall_003Ed__55 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float timer;

		public Action action;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayCall_003Ed__55(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CRefreshShopScrollViewBoundsNextFrame_003Ed__88 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudCSShopController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRefreshShopScrollViewBoundsNextFrame_003Ed__88(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private List<uint> m_ChoosedItemList;

	protected Dictionary<uint, UIHudCSEquipCategoryController> m_CategroyMap;

	private uint MYSTERYBOX_FILTER;

	protected uint m_FirstCategoryFilter;

	private UIHudAskPurchaseListController m_AskListCtrl;

	private float m_AskListYOffset;

	private List<UIPanel> m_Panels;

	private uint m_QuickBuyItemId;

	private Vector3 m_QuickBuyNormalPos;

	private bool _003CIsInShowPhase_003Ek__BackingField;

	public bool IsHideDetail;

	private uint m_CurSelectedItemId;

	private uint m_CurSelectedAbilityPointLevelForDetailCtrl;

	private uint m_CurSelectedAbilityPointLevel;

	private bool m_MysteryBoxDataDirty;

	private TweenPosition m_ShopTweenPosition;

	private uint m_ItemIndex;

	private bool m_IsResetToTop;

	private bool m_NeedResetToTop;

	private bool m_IsDelayRefreshCSShop;

	private string m_RoundShopBuffKey;

	private const string LOC_KEY_ASK_BTN = "T_29_HI_TEAMREQ_BTN";

	private const string LOC_KEY_CANCEL_BTN = "TXT_MESSAGEBOX_CANCEL";

	private StringBuilder m_DetailDescSb;

	private UIHudCSShopTeammateWeaponInfoController m_TeammateWeaponInfoController;

	private UIHudCSShopTeammateWeaponInfoV2Controller m_TeammateWeaponInfoV2Controller;

	private UIHudNewCSShopWeaponDetailController m_NewCSShopWeaponDetailController;

	private UITutorialIndicatorHandController m_IndicatorHandCtrl;

	private uint m_HideCSAIECAGuideDelayID;

	private OHEMKKOKJKL m_PurchaseBuyType;

	protected Vector3 m_TitleRootPosDefault;

	protected Color m_TitleLabelColorDefault;

	protected Vector3 m_CloseBtnPosDefault;

	protected Color m_CloseIconColorDefault;

	protected string m_CloseIconNameDefault;

	protected Vector3 m_LeftTimeShowPosDefault;

	protected Color m_BuyBtnLabelColorTopDefault;

	protected Color m_BuyBtnLabelColorBottomDefault;

	protected string m_BuyBtnIconDefault;

	protected Color m_AskBtnLabelColorTopDefault;

	protected Color m_AskBtnLabelColorBottomDefault;

	protected string m_AskBtnIconDefault;

	private VisualInstanceHolder m_AdditionalUIHolder;

	private bool m_HideByPanel;

	private float m_AskPurchaseBtnChatTime;

	private bool m_CanSendCoinMsg;

	private uint m_ShowNewbieCSShopDragUpGuideDelayCallId;

	public bool IsInShowPhase
	{
		get
		{
			return _003CIsInShowPhase_003Ek__BackingField;
		}
		set
		{
			_003CIsInShowPhase_003Ek__BackingField = value;
		}
	}

	protected bool IsShowHideByPanelEnabled => false;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override bool IsSuspendingEnabled()
	{
		return false;
	}

	public static bool KillCamDontDestroy()
	{
		return false;
	}

	public override bool KillCamRecyleDontDestroy()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	public override void Show()
	{
	}

	private void OnChanegSpecialFilterVisible(bool show)
	{
	}

	private void OnCSRefreshShopOnRefresh(uint filter)
	{
	}

	private void OnCSRefreshShopRefreshCountChange(uint count)
	{
	}

	private void OpenTeammateWeaponInfo()
	{
	}

	protected override void RefreshCoinBtnStyle()
	{
	}

	private void OnShowCSGuideSecondWeaponBuy(object[] data)
	{
	}

	private void OnShowCSGuideStoreGold(object[] data)
	{
	}

	private void OnShowCSGuideStoreArmorBuy(object[] data)
	{
	}

	private void OnAniFinishedShowGoldGuide()
	{
	}

	private void OnShowCSGuideStoreArmorItem(object[] data)
	{
	}

	private void OnShowCSGuideStoreWeaponClose(object[] data)
	{
	}

	private void OnShowCSGuideStoreWeaponBuy(object[] data)
	{
	}

	private void OnAniFinishedShowWeaponGuide()
	{
	}

	private void OnAniFinishedShowSecondWeaponGuide()
	{
	}

	private void AdjustTutorialDepthAboveTeammateInfo()
	{
	}

	private IEnumerator DelayCall(float timer, Action action)
	{
		return null;
	}

	private void OnShowCSGuideSecondWeaponItem(object[] data)
	{
	}

	private void OnShowCSGuideStoreWeaponItem(object[] data)
	{
	}

	protected override void OnInitSpecialUIElement()
	{
	}

	protected override void RecordDefaultSkinInfo()
	{
	}

	private void SetSkin(bool resetToDefault = false)
	{
	}

	protected override void OverrideCountDownColor()
	{
	}

	private void SetSkinElement(UISprite sprite, string name, string defaultName = null)
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void TryGetChildPanels()
	{
	}

	protected virtual void SetUIData()
	{
	}

	private void SetItems(Player player)
	{
	}

	private void InitAbilityPointLevelSelection()
	{
	}

	private void OnReplaceRefreshShop()
	{
	}

	private void OnRefreshShop()
	{
	}

	private void DelayRefreshCSShop()
	{
	}

	protected virtual void ResetShopItems()
	{
	}

	private void RestrictShopScrollViewYWithinBounds()
	{
	}

	private void RefreshShopScrollViewBounds()
	{
	}

	private IEnumerator RefreshShopScrollViewBoundsNextFrame()
	{
		return null;
	}

	protected virtual void RefreshUIData(bool isPurchaseRefresh = false)
	{
	}

	protected virtual UIHudCSEquipCategoryController CreateCategory(Transform container)
	{
		return null;
	}

	private void OnItemDoubleClickBuy(uint itemId)
	{
	}

	protected override void OnPurchaseBtnClick()
	{
	}

	protected override void OnCloseBtnClick()
	{
	}

	public override void Hide()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected virtual bool OnCheckItemCanPurchase(Player player, CSShopItemData item, HENEHAGJCLI itemData)
	{
		return false;
	}

	public override bool IsVisible()
	{
		return false;
	}

	protected override void RefreshVisibility(bool move = false)
	{
	}

	private bool CheckBooyahBountyCanBuy()
	{
		return false;
	}

	private bool CheckTechPointCanBuy()
	{
		return false;
	}

	private bool CheckMushRoomCanBuy()
	{
		return false;
	}

	private bool CheckGhostEffectCanBuy()
	{
		return false;
	}

	private bool CheckGhostEffectCanAskBuy()
	{
		return false;
	}

	private void OnAskPurchaseBtnClick()
	{
	}

	private void ClearUIData()
	{
	}

	protected override void OnItemSelected(object[] data)
	{
	}

	private void ShowSelectedItemDetail(CSShopItemData shopItem)
	{
	}

	private bool TryShowCSAbilityPointSkillDetail(CSShopItemData shopItem, uint itemId)
	{
		return false;
	}

	private void SortTransformUnderDetailContainer()
	{
	}

	private void OnAbilityPointSelected(uint level)
	{
	}

	private void SetCurSelectedAbilityPointLevel(uint level)
	{
	}

	private void RepositionShopTableKeepingCategoryX()
	{
	}

	private void OnCSAbilityPointCanChooseLevelChanged(uint newValue, uint oldValue)
	{
	}

	private void OnCSAbilityPointLevelInfoUpdated()
	{
	}

	private void OnCSAbilityPointInited()
	{
	}

	private void OnReinforceTokenChanged(int newTokenCount, int oldTokenCount)
	{
	}

	private void RefreshLoadoutReinforceTip()
	{
	}

	private void RefreshQuickBuy(uint itemId)
	{
	}

	private void OnBtnQuickBuyClick()
	{
	}

	private void RefreshPrices(uint purchaseCnt = 0u)
	{
	}

	private void RefreshAskBtn(uint cost, bool isItemValid)
	{
	}

	private void RefreshAskBtnLabelAndState()
	{
	}

	private static bool IsItemListEqual(List<uint> a, List<uint> b)
	{
		return false;
	}

	private void OnMysteryBoxChanged(object[] data)
	{
	}

	private void UpdateMysteryBoxUI()
	{
	}

	private void OnFreeCardCountChanged(object[] data)
	{
	}

	private void OnMysteryBoxOpen(object[] data)
	{
	}

	private void OnMysteryBoxClose(object[] data)
	{
	}

	private void ResetAnim()
	{
	}

	private void OnTeammateCoinChange(object[] data)
	{
	}

	private void ClearData()
	{
	}

	void IUIModelDataChangeObserver.OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	uint IUIModelDataChangeObserver.GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void OnItemCountChanged(GEvent data)
	{
	}

	private void OnPurchaseSuccess(object[] data)
	{
	}

	private void OnBuyBuffItemSuccess(uint buffId)
	{
	}

	public void SetFreeShowView()
	{
	}

	private void RefreshCSShopTipsValue()
	{
	}

	public void SetCloseLeftTime(float time)
	{
	}

	private uint GetItemBuffId(int itemId)
	{
		return 0u;
	}

	private void OnRoundShopBuffChange(object[] data)
	{
	}

	private void OnCoinBtnClick()
	{
	}

	private void OnFilterSingleEffectChanged(int filterID, int itemID)
	{
	}

	private void OnDetailBtnClick()
	{
	}

	public void SetDetailBtnVisible(bool isShow)
	{
	}

	public void RefreshDetailGrid()
	{
	}

	private static void OnWithdrawEnabledBtnClicked()
	{
	}

	private static void OnWithdrawDisabledBtnClicked()
	{
	}

	private void RefreshWithdrawBtnGroup()
	{
	}

	private void OnFinancialTrackedTransactionsChanged()
	{
	}

	private void OnFinancialTransactionWithdrawalSuccess()
	{
	}

	private void OnBattleLevelLocalPlayerSelectionConfirm()
	{
	}

	private void TryShowNewbieCSShopEntryGuide()
	{
	}

	private void TryShowNewbieCSShopDragUpGuide()
	{
	}

	private void TryShowNewbieCSShopPurchaseGuide()
	{
	}

	private void ClearShowNewbieCSShopDragUpGuideDelayCallId()
	{
	}

	private void TryShowNewbieCSShopGuide()
	{
	}

	public void ChangeCSAIECAHandGuideState(bool isShow)
	{
	}

	public void ShowCSAIECAHandGuide()
	{
	}

	public void CloseCSAIECAHandGuide()
	{
	}

	public void OnItemBelowScrollViewBottom(object[] data)
	{
	}

	private void OnCSAgentReinforceGuide(uint itemID)
	{
	}

	public void UpdateDepth(UIBaseController ctrl, int depth)
	{
	}

	private void _003COnCoinBtnClick_003Eb__147_0()
	{
	}

	private void _003CTryShowNewbieCSShopDragUpGuide_003Eb__160_0()
	{
	}

	public bool _003C_003EiFixBaseProxy_IsSuspendingEnabled()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_KillCamRecyleDontDestroy()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshCoinBtnStyle()
	{
	}

	public void _003C_003EiFixBaseProxy_OnInitSpecialUIElement()
	{
	}

	public void _003C_003EiFixBaseProxy_RecordDefaultSkinInfo()
	{
	}

	public void _003C_003EiFixBaseProxy_OverrideCountDownColor()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPurchaseBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnCloseBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public bool _003C_003EiFixBaseProxy_IsVisible()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_RefreshVisibility(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemSelected(object[] P0)
	{
	}
}
