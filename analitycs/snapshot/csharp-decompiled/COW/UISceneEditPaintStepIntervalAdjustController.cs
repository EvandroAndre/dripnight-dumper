using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UISceneEditPaintStepIntervalAdjustController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public float valueX;

		public float valueZ;

		internal float _003COnStopChangeSlider_003Eb__0(float x)
		{
			return 0f;
		}

		internal float _003COnStopChangeSlider_003Eb__1(float z)
		{
			return 0f;
		}
	}

	private SceneEditPaintTool mPaintTool;

	private SceneEditAgent mAgent;

	public Action<bool> m_OnSelectedCallback;

	private UISceneEditPaintStepIntervalAdjustView m_View;

	private bool m_IsSelect;

	private List<float> mXIntervalList;

	private List<float> mZIntervalList;

	private float mSliderLen;

	private List<GameObject> m_IndicatorCacheX;

	private List<GameObject> m_IndicatorCacheZ;

	private SceneEditPaintTool PaintTool => null;

	private SceneEditAgent Agent => null;

	private float INTERVAL_MAX => 0f;

	public bool IsSelect
	{
		get
		{
			return false;
		}
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

	protected override void OnUIDestroy()
	{
	}

	private float GetIntervalValue(float value)
	{
		return 0f;
	}

	private float GetIntervalPercent(float value)
	{
		return 0f;
	}

	private void OnSliderXChange()
	{
	}

	private void OnSliderZChange()
	{
	}

	private void OnInputXSubmit()
	{
	}

	private void OnInputZSubmit()
	{
	}

	private void OnStartChangeSlider()
	{
	}

	private void OnStopChangeSlider()
	{
	}

	public void RegisterStepSelectedCallback(Action<bool> callback)
	{
	}

	public void RefreshUIByPaintState()
	{
	}

	public void RefreshSolidOrHollowShow()
	{
	}

	public void RefreshCtrlByInterval()
	{
	}

	public void RefreshIndicatorByItems()
	{
	}

	private void _003COnUIInit_003Eb__15_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
