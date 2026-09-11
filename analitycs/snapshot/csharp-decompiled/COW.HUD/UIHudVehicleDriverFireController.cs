using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW.HUD;

internal class UIHudVehicleDriverFireController : UIHudVehicleItemButtonController
{
	private sealed class _003CDelayInitTouchingThroughArea_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudVehicleDriverFireController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayInitTouchingThroughArea_003Ed__27(int _003C_003E1__state)
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

	private UIHudVehicleDriverFireView m_View;

	private Player m_LocalPlayer;

	private DALCIFJKFGO m_Weapon;

	private bool m_Active;

	private const int AxisKey = 1;

	private const float ENTER_AIMING_TIME = 0.15f;

	private float m_ButtonDownTime;

	private int m_RightBoard;

	private float m_BGRangeRadius;

	private bool m_Aiming;

	private UserControlHandler m_Handler;

	private UserControlAxisData m_AxisData;

	private Vector3 m_DefaultPos;

	private bool m_PendingResetIgnore;

	private bool m_TouchingThroughAreaInited;

	private Color m_ActiveNormalColor;

	private Color m_ActiveIconColor;

	private Color m_DeactiveNormalColor;

	private Color m_DeactiveIconColor;

	private float GameTime => 0f;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override string GetMappingName()
	{
		return null;
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void OnLocalPlayerAdd(object[] data)
	{
	}

	private void InitTouchingThroughAreaInNeed()
	{
	}

	private IEnumerator DelayInitTouchingThroughArea()
	{
		return null;
	}

	private void InitTouchingThroughArea()
	{
	}

	protected override void OnBtnDown()
	{
	}

	protected override void OnBtnUp()
	{
	}

	private void UpdateRefs()
	{
	}

	protected override void Update()
	{
	}

	private void SetActive(bool e)
	{
	}

	private void EnterAiming()
	{
	}

	private void ExitAiming()
	{
	}

	private bool UpdateAiming()
	{
		return false;
	}

	private void OnStopAiming(object[] ps)
	{
	}

	private void IgnoreNextButtonUp()
	{
	}

	private void ResetIgnoreButtonUpInNeed()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnBtnDown()
	{
	}

	public void _003C_003EiFixBaseProxy_OnBtnUp()
	{
	}

	public void _003C_003EiFixBaseProxy_Update()
	{
	}
}
