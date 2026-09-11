using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIIAPBundleController : UIPreviewPopUpWindowController, IUIModelDataChangeObserver, IEasyList
{
	private sealed class _003CShowItemControlers_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIIAPBundleController _003C_003E4__this;

		private int _003Ci_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowItemControlers_003Ed__32(int _003C_003E1__state)
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

	private UIIAPBundleView m_View;

	private IAPBundleStoreData m_Data;

	private bool m_IsFirstShow;

	private bool m_HasPlayedAnimation;

	private const int MAX_ITEM = 5;

	private Transform[] m_ItemRoots;

	private uint m_ItemID;

	private List<UIIAPBundleContentItemController> m_GridItemControllers;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnClickHint()
	{
	}

	public void SetData(IAPBundleStoreData data)
	{
	}

	private void ShowFirstItem()
	{
	}

	private void ShowInternal()
	{
	}

	private void HideInternal()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public void OnPurchaseButtonClick()
	{
	}

	public void OnDiamondPurchaseButtonClick()
	{
	}

	public virtual uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public virtual void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void UpdateItemControllers(List<BundleShowData> bundleShowDataList)
	{
	}

	private void ToggleUI(bool show)
	{
	}

	private void ShowNameContent()
	{
	}

	protected virtual EAdIAPBundle GetAdType()
	{
		return EAdIAPBundle.IAPBundle;
	}

	private void OnSuccessfullyDownloadTitleCDN()
	{
	}

	protected void UpdateData()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
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

	protected override FrontendPreviewType GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}

	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	public void ShowPreviewInternal(BundleShowData bBundleData)
	{
	}

	private void PrintDebuggerLogError(string debuggerLogError)
	{
	}

	private void PrintDebuggerLog(string debuggerLog)
	{
	}

	public virtual bool IsPurchasable()
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

	public virtual IAPBundleStoreData GetIapBundleStoreData()
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

	private void _003COnDiamondPurchaseButtonClick_003Eb__18_0()
	{
	}

	private bool _003CShowNameContent_003Eb__24_0(AdvertDesc x)
	{
		return false;
	}

	private void _003CUpdateData_003Eb__27_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
