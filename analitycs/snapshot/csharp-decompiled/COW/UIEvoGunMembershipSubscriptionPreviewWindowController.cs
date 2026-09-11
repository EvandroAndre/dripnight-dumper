using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIEvoGunMembershipSubscriptionPreviewWindowController : UIPopupWindowController
{
	private sealed class _003CInitHelper_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIEvoGunMembershipSubscriptionPreviewWindowController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CInitHelper_003Ed__18(int _003C_003E1__state)
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

	private UIModelEvoPass m_ModelEvoPass;

	private UIEvoGunMembershipSubscriptionPreviewWindowView m_View;

	private EVipCard.MembershipRebateType m_EvoPassType;

	private UIStandardItemMAXBController m_EvoAccessItemCtrl;

	private Vector3 m_SubscribeBtnOriginalPosition;

	private Vector3 m_DiamondPurchaseBtnOriginalPosition;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void SetLegalTexts()
	{
	}

	private void UpdateFirstSubscribeBonus()
	{
	}

	private void UpdatePeriodLabel(PayItemData sdk)
	{
	}

	private void UpdateDiamondPriceLabel()
	{
	}

	private PayItemData GetProduct()
	{
		return null;
	}

	private void UpdatePriceLabel(PayItemData sdk)
	{
	}

	private void OnBtnSubscribeClick()
	{
	}

	private void OnBtnTermsOfServiceClick()
	{
	}

	private void OnBtnPrivacyPolicyClick()
	{
	}

	private void OnBtnManageSubscriptionClick()
	{
	}

	private IEnumerator InitHelper()
	{
		return null;
	}

	private void OnDiamondPurchaseBtnClick()
	{
	}

	private void UpdateEvoAccessItem()
	{
	}

	private void RefreshContent()
	{
	}

	public void SetViewData(EVipCard.MembershipRebateType evoPassType)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
