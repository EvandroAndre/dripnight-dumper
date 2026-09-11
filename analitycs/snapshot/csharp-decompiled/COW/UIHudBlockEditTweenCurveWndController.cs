using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudBlockEditTweenCurveWndController : UIPopupWindowController
{
	private class PresetBinding
	{
		public LGKIGCEDJDC m_Preset;

		public GameObject m_Go;
	}

	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public UIHudBlockEditTweenCurveWndController _003C_003E4__this;

		public LGKIGCEDJDC preset;

		internal void _003CInternalAddPreset_003Eb__0()
		{
		}

		internal void _003CInternalAddPreset_003Eb__1(GameObject go, bool state)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public UIHudBlockEditTweenCurveWndController _003C_003E4__this;

		public LGKIGCEDJDC preset;

		internal void _003CShowPresetOp_003Eb__0()
		{
		}

		internal void _003CShowPresetOp_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public LGKIGCEDJDC preset;

		public UIInput input;

		internal bool _003COnRenamePreset_003Eb__0(PresetBinding x)
		{
			return false;
		}

		internal void _003COnRenamePreset_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass25_0
	{
		public LGKIGCEDJDC preset;

		internal bool _003COnDeletePreset_003Eb__0(PresetBinding x)
		{
			return false;
		}

		internal bool _003COnDeletePreset_003Eb__1(PresetBinding x)
		{
			return false;
		}
	}

	private UIHudBlockEditTweenCurveWndView m_View;

	private MBMMLJMAGBD m_BezierTexture;

	private GBANAIHCIHN m_Curve;

	public Action<LGKIGCEDJDC> onConfirmPreset;

	public Action<GBANAIHCIHN> onConfirmCurve;

	private bool m_Pressed;

	private LGKIGCEDJDC m_PressedPreset;

	private Vector2 m_TouchPos;

	private float m_PressedTime;

	private bool m_PresetOpVisible;

	private List<PresetBinding> m_PresetBindings;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void RecalcCurveOnInput()
	{
	}

	private void OnClickOperationMask()
	{
	}

	private void InternalAddPreset(LGKIGCEDJDC preset)
	{
	}

	private void RefreshControlPoints()
	{
	}

	public void SetCurve(GBANAIHCIHN curve)
	{
	}

	private void OnMaskClick()
	{
	}

	private void OnPressPreset(GameObject go, bool pressed, LGKIGCEDJDC preset)
	{
	}

	private void Update()
	{
	}

	private void ShowPresetOp(LGKIGCEDJDC preset)
	{
	}

	private void HidePresetOp()
	{
	}

	private void OnRenamePreset(LGKIGCEDJDC preset)
	{
	}

	private void OnDeletePreset(LGKIGCEDJDC preset)
	{
	}

	private void RefreshGrid()
	{
	}

	private void OnClickAddPresetBtn()
	{
	}

	private void OnClickPreset(LGKIGCEDJDC preset)
	{
	}

	private Vector2 GetBoardSize()
	{
		return default(Vector2);
	}

	private void OnDragControlPoint2(GameObject go, Vector2 delta)
	{
	}

	private void OnDragControlPoint1(GameObject go, Vector2 delta)
	{
	}

	private void RefreshBoard()
	{
	}

	protected override void OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
