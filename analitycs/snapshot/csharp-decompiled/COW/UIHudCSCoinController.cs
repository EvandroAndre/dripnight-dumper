using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudCSCoinController : UIBaseController
{
	private sealed class _003CRollCoinValue_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudCSCoinController _003C_003E4__this;

		public int targetValue;

		public float duration;

		private int _003CstartValue_003E5__2;

		private float _003CelapsedTime_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRollCoinValue_003Ed__24(int _003C_003E1__state)
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

	private UIHudCSCoinView m_View;

	private int m_CurrentCoinValue;

	private int m_CachedCoinTargetValue;

	private float m_CoinRollDuration;

	private Vector3 OriginalPosition;

	private Coroutine m_CoinRollCoroutine;

	private UIHudCSReinforceTokenTipController m_ReinforceTokenTipController;

	private uint m_StopReinforceTokenVFXDelayCallID;

	private bool m_CanSendCoinMsg;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void RefreshReinforceTokenNode()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void OnEnable()
	{
	}

	private void OnHudSettingChanged(object[] param)
	{
	}

	private void OnCurCoinChanged(int data)
	{
	}

	private void OnReinforceTokenChanged(int newTokenCount, int oldTokenCount)
	{
	}

	private void StopReinforceTokenVFX()
	{
	}

	private void OnReinforceTokenBtnClick()
	{
	}

	private void OnSpectatorTargetChanged(object[] data)
	{
	}

	private void OnPinMark()
	{
	}

	private void OnCommonCoinsGot(int cnt, int reason)
	{
	}

	public void StartCoroutineUpdateCoinValue(int targetValue, float duration)
	{
	}

	public void StopCoroutineUpdateCoinValue()
	{
	}

	private IEnumerator RollCoinValue(int targetValue, float duration)
	{
		return null;
	}

	private void ONShowRoundSettleCoinChange()
	{
	}

	private void _003COnPinMark_003Eb__20_0()
	{
	}

	private void _003COnCommonCoinsGot_003Eb__21_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
