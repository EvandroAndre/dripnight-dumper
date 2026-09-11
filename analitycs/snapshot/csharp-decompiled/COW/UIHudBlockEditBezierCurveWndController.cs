using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudBlockEditBezierCurveWndController : UIPopupWindowController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<double, float> _003C_003E9__35_1;

		internal float _003CInternalAddPreset_003Eb__35_1(double num)
		{
			return 0f;
		}
	}

	private sealed class _003C_003Ec__DisplayClass35_0
	{
		public UIHudBlockEditBezierCurveWndController _003C_003E4__this;

		public HPGDCJIMPHB preset;

		internal void _003CInternalAddPreset_003Eb__0()
		{
		}
	}

	private sealed class _003CSetPosition_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudBlockEditBezierCurveWndController _003C_003E4__this;

		public Vector3 Pos;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSetPosition_003Ed__18(int _003C_003E1__state)
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

	private UIHudBlockEditBezierCurveWndView m_View;

	private MBMMLJMAGBD m_BezierTexture;

	private AnimationCurve m_Curve;

	public Action<HPGDCJIMPHB> onConfirmPreset;

	public Action<string, AnimationCurve> onConfirmCurve;

	private const float TangentLength = 80f;

	private int selectedPointIndex;

	private int selectedKeyframIndex;

	private const float m_HeightSpace = 40f;

	private UIRoot m_UIRoot;

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

	private void OnMaskClick()
	{
	}

	public void SetCurve(string curveName, AnimationCurve curve)
	{
	}

	private void RefreshBoard()
	{
	}

	private void RefreshControlPoints()
	{
	}

	public void SetPos(Vector3 pos)
	{
	}

	private IEnumerator SetPosition(Vector3 Pos)
	{
		return null;
	}

	private Vector2 GetBoardSize()
	{
		return default(Vector2);
	}

	private void OnDragControlPoint1(GameObject go, Vector2 delta)
	{
	}

	private void OnDragControlPoint2(GameObject go, Vector2 delta)
	{
	}

	private float slope2Degree(float slope)
	{
		return 0f;
	}

	private void OnDragTangentPoint1(GameObject go, Vector2 delta)
	{
	}

	private void OnDragTangentPoint2(GameObject go, Vector2 delta)
	{
	}

	private void CheckBoundary(int pointIndex = 0)
	{
	}

	private void OnControlPointDragStart()
	{
	}

	private void OnControlPointDragEnd(GameObject go)
	{
	}

	private void OnTangentPointDragStart()
	{
	}

	private void OnTangentPointDragEnd(GameObject go)
	{
	}

	private void OnSelectControlPoint1(GameObject go, bool state)
	{
	}

	private void OnSelectControlPoint2(GameObject go, bool state)
	{
	}

	private float degree2Slope(float degree)
	{
		return 0f;
	}

	private void RecalcCurveOnSubmit()
	{
	}

	private void SetAngleInputValue(float angle)
	{
	}

	private void InternalAddPreset(HPGDCJIMPHB preset)
	{
	}

	private void OnClickPreset(HPGDCJIMPHB preset)
	{
	}

	private void RefreshGrid()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
