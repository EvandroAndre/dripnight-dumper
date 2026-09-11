using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudVehicleStatsController : UIBaseController
{
	private sealed class _003CCloseBackEffect_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudVehicleStatsController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCloseBackEffect_003Ed__35(int _003C_003E1__state)
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

	private sealed class _003CCloseFrontEffect_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudVehicleStatsController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCloseFrontEffect_003Ed__34(int _003C_003E1__state)
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

	private sealed class _003CShowHelicopterVFX_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudVehicleStatsController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowHelicopterVFX_003Ed__32(int _003C_003E1__state)
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

	private UIHudVehicleStatsView m_View;

	private Vehicle m_Vehicle;

	private const int SPEED_SAMPLE_COUNT = 10;

	private float m_SpeedSum;

	private Queue<float> m_Speeds;

	private MutableString mLabelBuilder;

	private int mLastSpeed;

	private float eulerPerKm;

	private float zRotation;

	private Vector3 m_InitPosition;

	private Vector3 m_SpeedModeDriverPosition;

	private uint m_CurrentVehicleChipDataID;

	private UIClickMask m_chipDescClickMask;

	private DDOADCIBEGG m_VehicleSubType;

	private UIClickMask m_LimitTimeClickMask;

	private MutableString m_LimitTimeStr;

	private Color m_LimitTimeHintColor;

	private int m_CurrentLimitTime;

	private float m_NextTimeHitVfxTime;

	private bool m_InitShowLockMoveStr;

	private bool IsHelicopter => false;

	private bool IsMountableAnimal => false;

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

	protected override void OnUIDestory()
	{
	}

	private void ShowHPNode(bool isDriver)
	{
	}

	private void OnHPChanged(object[] data)
	{
	}

	private void RefreshHud(bool isDriver)
	{
	}

	private void OnPlayerGetOn(Player player)
	{
	}

	private IEnumerator ShowHelicopterVFX()
	{
		return null;
	}

	public void OnHitIceWall(object[] data)
	{
	}

	private IEnumerator CloseFrontEffect()
	{
		return null;
	}

	private IEnumerator CloseBackEffect()
	{
		return null;
	}

	public void OnGetOn(object[] data)
	{
	}

	public void OnObserverGetOn(object[] data)
	{
	}

	private void OnObserverGetOff(object[] data)
	{
	}

	private void OnObserverSwitch(object[] data)
	{
	}

	private void Update()
	{
	}

	private void UpdateSpeed()
	{
	}

	private void UpdateLimitTime()
	{
	}

	private void UpdateSpeedPointer(int speed)
	{
	}

	private void RefreshHP()
	{
	}

	private void OnLimitTimeBtnClick()
	{
	}

	private void OnClickVehicleStats()
	{
	}

	private void OnVehicleChipStateChange(uint chipDataID)
	{
	}

	private void OnVehicleHealStateChange(int value)
	{
	}

	public void OnVehicleHelicopterChange(object[] data)
	{
	}

	private void CloseVehicleDesc()
	{
	}

	private void CloseLimitTimeDesc()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
