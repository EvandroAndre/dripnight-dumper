using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudCubicMapController : UIMapBaseController
{
	private sealed class _003CCubicMapHideCoroutine_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudCubicMapController _003C_003E4__this;

		private Vector3 _003Cpos_003E5__2;

		private Vector3 _003CposEnd_003E5__3;

		private Quaternion _003CrotEnd_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCubicMapHideCoroutine_003Ed__43(int _003C_003E1__state)
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

	private UIHudCubicMapView m_View;

	private KPCBDCMDOOJ m_CubicMapDummy;

	private Coroutine m_CubicMapMomentCoroutine;

	private float m_MomentDuration;

	private float m_fEndRotationDuration;

	private Vector3 m_vMomentPositionOffset;

	private float m_fEulerAnglesX;

	private float m_fMoveFact;

	private Vector3 m_vStartPosition;

	private float m_fMaxValue;

	private float m_fMinValue;

	private float m_fMaxHeightLimitEulerAngle;

	private float m_fEulerAngleXAniDuration;

	private float m_fLimitRotateAnglesY;

	private uint m_CurveTicket;

	private float m_ScaleDest;

	private uint m_uDelayHideAirLine;

	private float m_ScreenHeight;

	private float m_ScreenWidth;

	private const int ZoomStep = 9;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	private void InitMapContentCtrl()
	{
	}

	private void InitEvents()
	{
	}

	private void InitUIElements()
	{
	}

	private void InitData()
	{
	}

	private void InitAirLine()
	{
	}

	protected override void RegisterEvents()
	{
	}

	protected override void UnRegisterEvents()
	{
	}

	private void Update()
	{
	}

	private void Update2DMap()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public void CloseCubicMap()
	{
	}

	public void ExitCubicMap()
	{
	}

	protected void OnBtnCloseClick()
	{
	}

	protected void OnBtnZoomInClick()
	{
	}

	protected void OnBtnZoomOutClick()
	{
	}

	protected void OnFindClick()
	{
	}

	protected void OnSliderChange()
	{
	}

	private void OnShowMap(object[] data)
	{
	}

	private void SetSliderValue(float fValue)
	{
	}

	private IEnumerator CubicMapHideCoroutine()
	{
		return null;
	}

	private void OnEditAndDebugParam()
	{
	}

	private void OnUpdateMapMark(object[] param)
	{
	}

	private void OnRemoveMapMark(object[] param)
	{
	}

	private void _003CInitData_003Eb__25_0(uint ticket, bool succeeded, UnityEngine.Object obj)
	{
	}

	private void _003CInitAirLine_003Eb__26_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_RegisterEvents()
	{
	}

	public void _003C_003EiFixBaseProxy_UnRegisterEvents()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
