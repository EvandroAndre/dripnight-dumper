using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIGrowthFundAnnounceController : UIPopupWindowController, IUIModelDataChangeObserver, IEasyList
{
	private sealed class _003CPlayAnimationWithLevelUp_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGrowthFundAnnounceController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayAnimationWithLevelUp_003Ed__20(int _003C_003E1__state)
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

	private UIGrowthFundAnnounceView m_View;

	private UIModelPayment m_ModelPayment;

	private UIModelUser m_ModelUser;

	private PayBundleWindowDesc m_Data;

	private Action m_CloseAction;

	public Action ClosAction
	{
		set
		{
		}
	}

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

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	uint IUIModelDataChangeObserver.GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	void IUIModelDataChangeObserver.OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void SetViewData(bool hasLevelUpReward, bool isEveryWeekPopup)
	{
	}

	private void RefreshContent()
	{
	}

	private void RefreshInfo()
	{
	}

	private void RefreshBundleList()
	{
	}

	private void CheckPlayCloseAnimation()
	{
	}

	public void PlayAnimationWithoutLevelUp()
	{
	}

	public IEnumerator PlayAnimationWithLevelUp()
	{
		return null;
	}

	private void OnCloseBtnClick()
	{
	}

	private void OnGoBtnClick()
	{
	}

	private void OnPurchaseBtnClick()
	{
	}

	private void TryHandleOfflineTransaction()
	{
	}

	private void RefreshCDN()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
