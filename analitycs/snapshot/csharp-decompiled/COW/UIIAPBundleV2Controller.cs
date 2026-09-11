using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIIAPBundleV2Controller : UIPreviewPopUpWindowController, IUIModelDataChangeObserver, IEasyList
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<BundleShowData, uint> _003C_003E9__37_1;

		public static Func<int, string> _003C_003E9__53_0;

		internal uint _003CProcessBundleShowData_003Eb__37_1(BundleShowData p)
		{
			return 0u;
		}

		internal string _003CRefreshLeftTab_003Eb__53_0(int p)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass37_0
	{
		public BaseItemInfo info;

		internal bool _003CProcessBundleShowData_003Eb__0(BundleShowData id)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass54_0
	{
		public uint storeId;

		internal bool _003COnTabBtnClick_003Eb__0(uint id)
		{
			return false;
		}
	}

	private sealed class _003CShowItemControlers_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIIAPBundleV2Controller _003C_003E4__this;

		private int _003Ci_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowItemControlers_003Ed__42(int _003C_003E1__state)
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

	private UIIAPBundleV2View m_View;

	private UIModelIAPBundle m_ModeIAPBundle;

	private IAPBundleStoreData m_Data;

	private List<UIIAPBundleContentItemController> m_GridItemControllers;

	private Transform[] m_ItemRoots;

	private GameObject[] m_HightLights;

	private bool m_IsFirstShow;

	private const int MAX_ITEM = 5;

	private int m_PreviewItemIndex;

	private bool m_IsIAPBundlePreview;

	private bool m_HasLeftTab;

	private List<UIIAPBundleV2TabItemController> m_TabItemControllers;

	private List<uint> m_StoreIdList;

	private uint m_CurrentStoreId;

	private bool m_IsShowedBooyahPass;

	private bool m_IsCheckedBooyahPassAnim;

	private bool m_IsShowingBooyahPassPreview;

	private int m_LastSelectBPItemIndex;

	private float m_FlyTime;

	private uint m_AnimDelayCall;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	public override bool IsAutoCalculatePreviewPanelSize()
	{
		return false;
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override FrontendPreviewType GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}

	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	public virtual uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public virtual void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void SetData(IAPBundleStoreData data, bool showVFX = false)
	{
	}

	private void UpdateData(uint storeId)
	{
	}

	private void UpdateItemControllers(List<BundleShowData> bundleShowDataList)
	{
	}

	private void UpdateItemControllers(BaseItemInfo itemInfo)
	{
	}

	private void RefreshBooyahPassList(List<BundleShowData> bundleShowDataList)
	{
	}

	private void RefreshBooyahPassList(BaseItemInfo itemInfo)
	{
	}

	private void ResetItemController()
	{
	}

	private void RefreshToggleUI(bool show)
	{
	}

	private void ProcessBundleShowData()
	{
	}

	private bool CheckCanShowToggleUI(uint storeId)
	{
		return false;
	}

	private void RefreshPurchaseView()
	{
	}

	private bool ShowDiamondPurchaseBtn()
	{
		return false;
	}

	private bool ShowPurchaseBtn()
	{
		return false;
	}

	private IEnumerator ShowItemControlers()
	{
		return null;
	}

	private void ShowPreviewItem()
	{
	}

	public void ShowPreviewInternal(object data, int itemIndex)
	{
	}

	public void RefreshPreviewLabel(EInventory.AwardType awardType, uint awardNum)
	{
	}

	public void RefreshHighLight(int itemIndex)
	{
	}

	private bool IsPreviewCoveredByPopup()
	{
		return false;
	}

	private void PrintDebuggerLogError(string debuggerLogError)
	{
	}

	private void PrintDebuggerLog(string debuggerLog)
	{
	}

	private void OnPurchaseButtonClick()
	{
	}

	private void OnDiamondPurchaseButtonClick()
	{
	}

	private void OnPendingHelpBtnClick()
	{
	}

	private void RefreshLeftTab()
	{
	}

	public void OnTabBtnClick(uint storeId)
	{
	}

	private void ExecuteFlyEffect()
	{
	}

	public virtual bool IsPurchasable()
	{
		return false;
	}

	public virtual bool IsPurchasable(uint storeId)
	{
		return false;
	}

	public virtual bool ReviewMode()
	{
		return false;
	}

	public virtual bool IsIAPVisible()
	{
		return false;
	}

	public virtual bool IsIAPVisible(uint storeId)
	{
		return false;
	}

	public virtual IAPBundleStoreData GetIapBundleStoreData()
	{
		return null;
	}

	public virtual IAPBundleStoreData GetIapBundleStoreData(uint storeId)
	{
		return null;
	}

	public virtual int GetIapBundleStoreDataID()
	{
		return 0;
	}

	public virtual string GetIAPBundleFirstShow()
	{
		return null;
	}

	public virtual void Purchase(IAPBundleStoreData data)
	{
	}

	public virtual void RequestDiamondPurchase(IAPBundleStoreData data)
	{
	}

	public virtual ulong GetEndTime()
	{
		return 0uL;
	}

	public virtual void SetIsFirstTime(bool isFirstTime)
	{
	}

	public virtual EventLogger.ClickType GetClickLogType()
	{
		return EventLogger.ClickType.None;
	}

	public virtual string GetControllerName()
	{
		return null;
	}

	public virtual void RegisterModel()
	{
	}

	private void OnBooyahPassPreviewSmallItemClick(object[] data)
	{
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	private void _003CRefreshPurchaseView_003Eb__39_0()
	{
	}

	private void _003COnDiamondPurchaseButtonClick_003Eb__51_0()
	{
	}

	private void _003CExecuteFlyEffect_003Eb__57_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public bool _003C_003EiFixBaseProxy_IsAutoCalculatePreviewPanelSize()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
