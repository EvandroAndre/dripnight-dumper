using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIPaymentGrowthFundV2Controller : UIPaymentController.PaymentTabContentController, IEasyList, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public uint id;

		internal bool _003CPlayUnlockVFXByLevel_003Eb__0(PayBundleWindowDesc desc)
		{
			return false;
		}
	}

	private sealed class _003COnEnableRoutine_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIPaymentGrowthFundV2Controller _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COnEnableRoutine_003Ed__27(int _003C_003E1__state)
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

	private UIPaymentGrowthFundV2View m_View;

	private UIModelPayment m_ModelPayment;

	private int m_ScrollOffset;

	private bool m_NeedPlayVFX;

	private uint m_NeedPlayVFXId;

	private bool m_HasShowEnd;

	private uint m_PlayVFXDelayCall;

	public bool HasShowEnd => false;

	public bool NeedPlayVFX
	{
		set
		{
		}
	}

	public uint NeedPlayVFXId
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

	public override void Show()
	{
	}

	protected override void OnVisibilityChanged()
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

	private void OnEnable()
	{
	}

	public override void RefreshContent()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void PlayUnlockVFXByLevel(uint id)
	{
	}

	private void OnClickHint()
	{
	}

	private void ShowEffect()
	{
	}

	private IEnumerator OnEnableRoutine()
	{
		return null;
	}

	private void ScrollToCertainLevelItem()
	{
	}

	private void RefreshRebateLabel(List<PayBundleWindowDesc> payBundleDescList)
	{
	}

	private void RefreshCDN()
	{
	}

	private void PlayAnimation()
	{
	}

	private void _003CPlayAnimation_003Eb__31_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshContent()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
