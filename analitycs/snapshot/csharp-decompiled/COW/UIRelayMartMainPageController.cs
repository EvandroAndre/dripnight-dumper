using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIRelayMartMainPageController : UIPreviewNavigationController, IUIModelDataChangeObserver
{
	public enum ERewardPoolItemType
	{
		BigAward = 1,
		Normal
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static EventDelegate.Callback _003C_003E9__55_0;

		public static Action _003C_003E9__122_0;

		internal void _003CRefreshTopBar_003Eb__55_0()
		{
		}

		internal void _003CShowRebateEntranceGuide_003Eb__122_0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass111_0
	{
		public UIRelayMartMainPageController _003C_003E4__this;

		public Action callback;

		internal void _003CExecuteFlyEffect_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass113_0
	{
		public UIRelayMartMainPageController _003C_003E4__this;

		public Vector3 endPointWorld;

		public int shoppingCartCnt;

		internal void _003CPlayAddToCartVFX_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass114_0
	{
		public UIRelayMartMainPageController _003C_003E4__this;

		public Vector3 endPointWorld;

		internal void _003CPlayRebateFlyingVFX_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass69_0
	{
		public UIRelayMartMainPageController _003C_003E4__this;

		public bool isSuccess;

		public bool isTimeout;

		public string errorMsg;

		internal void _003COnDiscountCodeLockResponseReceived_003Eb__0()
		{
		}
	}

	private sealed class _003CDelayRefreshPreviewBorder_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIRelayMartMainPageController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayRefreshPreviewBorder_003Ed__44(int _003C_003E1__state)
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

	private sealed class _003CRefreshDiscountProgressBarCoroutine_003Ed__58 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIRelayMartMainPageController _003C_003E4__this;

		public float targetFillAmount;

		public int level;

		public bool isAdd;

		private float _003CstartFillAmount_003E5__2;

		private float _003CelapsedTime_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRefreshDiscountProgressBarCoroutine_003Ed__58(int _003C_003E1__state)
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

	private sealed class _003CRollToTargetCoroutine_003Ed__100 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIRelayMartMainPageController _003C_003E4__this;

		public bool needPlayVFX;

		public uint targetDiscount;

		private uint _003CstartValue_003E5__2;

		private float _003CelapsedTime_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRollToTargetCoroutine_003Ed__100(int _003C_003E1__state)
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

	private UIRelayMartMainPageView m_View;

	private UIModelRelayMart m_ModelRelayMart;

	private UIModelInventory m_ModelInventory;

	private UIModelMall m_ModelMall;

	private UICountDownController m_CountDownCtrl;

	private string m_CurrentShareDiscountCode;

	private UIRelayMartDiscountCodeShareController m_DiscountCodeShareCtrl;

	private UIRelayMartDiscountCodeGetController m_DiscountCodeGetCtrl;

	private UIRelayMartPurchaseController m_PurchaseCtrl;

	private UITipsNormalController m_TipsCtrl;

	private List<GameObject> m_DiscountProgressBarItemList;

	private List<UIRelayMartDiscountProgressBarItemController> m_DiscountProgressBarItemControllerList;

	private List<UIRelayMartShoppingCartBoxItemController> m_ShoppingCartBoxItemControllerList;

	private string m_CurInputDiscountCode;

	private bool m_IsDiscountCodeChecking;

	private ulong m_DiscountCodeCheckStartTime;

	private bool m_DiscountCodeCheckResponseReceived;

	private uint m_DiscountCodeCheckDelayCallID;

	private Coroutine m_DiscountValueRollCoroutine;

	private uint m_CurrentDisplayedDiscount;

	private uint m_ShowBubbleDelayCallID;

	private int m_LastShoppingCartCount;

	private Coroutine m_ProgressBarAnimCoroutine;

	private bool m_FirstAddItemToShoppingCart;

	private const float FINAL_LERP_TIME = 0.3f;

	private const float SHOW_BUBBLE_DELAY_TIME = 5f;

	private Vector2 REWARD_POOL_BIG_AWARD_ITEM_SIZE;

	private Vector2 REWARD_POOL_ITEM_SIZE;

	private Vector2 SPECAIL_BG_SIZE;

	private Vector2 COMMON_BG_SIZE;

	private float m_FlyTime;

	private uint m_AnimDelayCall;

	private Vector3 m_CenterWorldPos;

	public bool IsDiscountCodeChecking => false;

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public override void OnNavigationClosed()
	{
	}

	private void HandleDiscountCodeParams(UINavigationData navigationData)
	{
	}

	private void ProcessDiscountCodeInfo(string discountCode, ulong sharerAccountID, bool hasLocked)
	{
	}

	protected override void OnUIOpen()
	{
	}

	private void ProcessDeepLinkDiscountCode()
	{
	}

	private IEnumerator DelayRefreshPreviewBorder()
	{
		return null;
	}

	protected override FrontendPreviewType GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}

	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	public void OnScrollToItemByMartGoodsId(uint martGoodsId)
	{
	}

	public void ClearDiscountCodeInput()
	{
	}

	private void InitView()
	{
	}

	private void InitEvent()
	{
	}

	private void SetBG()
	{
	}

	private void CheckAndPlayClaimRebateAnim()
	{
	}

	private void RefreshTime()
	{
	}

	private void OnCountDownFinished()
	{
	}

	private void RefreshTopBar()
	{
	}

	private void InitDiscountProgressBar()
	{
	}

	private void RefreshDiscountProgressBar(int level, bool isAdd = false)
	{
	}

	private IEnumerator RefreshDiscountProgressBarCoroutine(float targetFillAmount, int level, bool isAdd = false)
	{
		return null;
	}

	private void RefreshDiscountProgressBarItemState(int level, bool isAdd = false)
	{
	}

	private void RefreshRewardPool()
	{
	}

	private int SortRewardPoolItem(RelayMartShopDesc x, RelayMartShopDesc y)
	{
		return 0;
	}

	private int GetSinkPriority(bool isSoldOut, bool isOwned, bool isBigReward)
	{
		return 0;
	}

	private void SelectFirstItem()
	{
	}

	private void InitDiscountCodeContainer()
	{
	}

	private void OnDiscountCodeChecked(bool isSuccess, bool isTimeout, string errorMsg)
	{
	}

	private void OnDiscountCodeCheckedFailed(string errorKey)
	{
	}

	private void RefreshDiscountCodeCheckingView(bool isChecking)
	{
	}

	private void RefreshDiscountCodeActiveView(bool isActive, int currentShoppingCartCount = 0)
	{
	}

	private void OnDiscountCodeLockResponseReceived(bool isSuccess, bool isTimeout, string errorMsg)
	{
	}

	private void OnDiscountCodeUnlockResponseReceived(bool isSuccess)
	{
	}

	private void CancelDiscountCodeCheckDelayCall()
	{
	}

	private void CheckUnLockDiscountCode()
	{
	}

	private int GetDisplayOriginalPrice()
	{
		return 0;
	}

	private void InitRewardPoolItemTemplate()
	{
	}

	private void OnHelpBtnClick()
	{
	}

	private void OnDiamondPurchaseBtnClick()
	{
	}

	private void OnDiamondRebateBtnClick()
	{
	}

	private void OnPasteDiscountCodeBtnClick()
	{
	}

	private void OnDiscountCodeInputLostFocus()
	{
	}

	private void RefreshDiscountCodeBeginCheckingView()
	{
	}

	private void OnDiscountCodeInputChange()
	{
	}

	private void OnMoreCouponsBtnClick()
	{
	}

	private void OnRelayMartRewardPoolItemClick(object[] param)
	{
	}

	private void OnClearDiscountCodeBtnClick()
	{
	}

	public void OnShowShareList(object[] data)
	{
	}

	private void OnClearDiscountCodeInputEvent()
	{
	}

	private void OnShowGenerateDiscountCodePopup()
	{
	}

	private void OnGenerateDiscountCodePopupClosed()
	{
	}

	private void RefreshMainPageView()
	{
	}

	private void RefreshTitle()
	{
	}

	private void OnTitleCDNDownloadSuccess()
	{
	}

	private void RefreshDiamondPrice()
	{
	}

	private void RefreshDiamondPriceWithCount(int count)
	{
	}

	private void ClearShowBubbleDelayCall()
	{
	}

	private void CheckShowRebateWnd()
	{
	}

	private void PreloadCDN()
	{
	}

	private void InitTipsView()
	{
	}

	private void SetNumberText(uint value)
	{
	}

	private void RollToTargetDiscount(bool needPlayVFX)
	{
	}

	private IEnumerator RollToTargetCoroutine(uint targetDiscount, bool needPlayVFX)
	{
		return null;
	}

	private void RefreshCodeCheckSuccessVFX()
	{
	}

	private void RefreshDiamondPurchaseVFX()
	{
	}

	private void InitShoppingCartContainer()
	{
	}

	private void RefreshShoppingCartContainer()
	{
	}

	private void RefreshShoppingCartContainerWithCount(int displayCount)
	{
	}

	private void OnShoppingCartItemChanged(int currentCount, bool isImmediate = false, bool isAdd = false)
	{
	}

	private void RefreshCartTipLabel(int currentCount, bool isAdd = false)
	{
	}

	private void ExecuteFlyEffect(Vector3 startPointWorld, Vector3 endPointWorld, string vfxResIDStr, Action callback)
	{
	}

	private void ClearAnimDelayCall()
	{
	}

	private void PlayAddToCartVFX()
	{
	}

	private void PlayRebateFlyingVFX()
	{
	}

	private void PlayDiscountCodeBrustVFX(Vector3 endPointWorld)
	{
	}

	private void RefreshFirstAddItemToShoppingCartVFX(bool isAdd)
	{
	}

	private void LogRelayMartAddCart()
	{
	}

	private void CheckAndShowFreeDiamondPopup()
	{
	}

	private void ShowFreeDiamondPopup()
	{
	}

	private void ShowAddItemGuide()
	{
	}

	private void ShowUseDiscountCodeGuide()
	{
	}

	private void ShowRebateEntranceGuide()
	{
	}

	private void _003C_003En__0(UIWidget previewBorder)
	{
	}

	private UITable2.IUITable2Item _003CInitRewardPoolItemTemplate_003Eb__74_0()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitRewardPoolItemTemplate_003Eb__74_1()
	{
		return null;
	}

	private void _003CCheckShowRebateWnd_003Eb__95_0()
	{
	}

	private void _003CCheckShowRebateWnd_003Eb__95_1()
	{
	}

	private void _003CShowFreeDiamondPopup_003Eb__119_0()
	{
	}

	private void _003CShowAddItemGuide_003Eb__120_0()
	{
	}

	private void _003CShowUseDiscountCodeGuide_003Eb__121_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
