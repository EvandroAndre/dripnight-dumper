using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIMemberShipSubscriptionPreviewWindowController : UIPopupWindowController
{
	private sealed class _003CInitHelper_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIMemberShipSubscriptionPreviewWindowController _003C_003E4__this;

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

	private UIModelMemberShip m_ModelMemberShip;

	private UIMemberShipSubscriptionPreviewWindowView m_View;

	private EVipCard.VipCardType m_MemberShipCardType;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void RefreshMemberShipCompliance()
	{
	}

	private void SetLegalTexts()
	{
	}

	public void SetViewData(EVipCard.VipCardType type)
	{
	}

	private void UpdateBonus()
	{
	}

	private void UpdatePeriodLabel(PayItemData csv, PayItemData sdk)
	{
	}

	private void GetProduct(out PayItemData csv, out PayItemData sdk)
	{
		csv = null;
		sdk = null;
	}

	private void UpdatePriceLabel(PayItemData csv, PayItemData sdk)
	{
	}

	private void OnBtnCloseClick()
	{
	}

	private void OnBtnSubscribeClick()
	{
	}

	private void OnBtnCancelClick()
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

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
