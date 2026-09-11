using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudEscortBossNameController : UIBaseController
{
	private enum EArrowDirection
	{
		NONE,
		UP,
		DOWN,
		LEFT,
		RIGHT
	}

	private sealed class _003CRemoveNameInfo_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delayTime;

		public UIHudEscortBossNameController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRemoveNameInfo_003Ed__29(int _003C_003E1__state)
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

	private UIHudEscortBossNameView m_View;

	private Camera m_FollowCamera;

	private Camera m_UICamera;

	private StringBuilder m_Distance;

	private int m_PrevDistance;

	private float viewPortBoundary;

	private LevelEscortMatchBoss m_Boss;

	private const float ARROW_ICON_HALF_SIZE = 21f;

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

	private void InitCamera()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void OnWheelHPChanged(object[] data)
	{
	}

	private void OnBodyHPChanged(object[] data)
	{
	}

	private void OnVehicleStateChanged(object[] data)
	{
	}

	private void UpdateRepairStatus()
	{
	}

	private void UpdateWheelHPUI()
	{
	}

	private void UpdateBodyHPUI()
	{
	}

	private void SetContainerActive(bool active)
	{
	}

	public void BindTarget(LevelEscortMatchBoss boss)
	{
	}

	private void LateUpdate()
	{
	}

	private void UpdateNamePosition()
	{
	}

	private void SetDistance(int distance)
	{
	}

	private Vector3 GetRefPos()
	{
		return default(Vector3);
	}

	private void SetViewActive(GameObject obj, bool active)
	{
	}

	private void ShowArrow(EArrowDirection direction)
	{
	}

	private IEnumerator RemoveNameInfo(float delayTime)
	{
		return null;
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

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
