using System;
using COW.GamePlay;
using GCommon;

namespace COW;

internal class UISceneEditPaintStepAreaDrawController : UIBaseController
{
	private SceneEditPaintTool mPaintTool;

	private bool m_IsSelect;

	public Action<bool> m_OnSelectedCallback;

	private UISceneEditPaintStepAreaDrawView m_View;

	private SceneEditPaintTool PaintTool => null;

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

	public void RegisterStepSelectedCallback(Action<bool> callback)
	{
	}

	private void OnRedrawBtnClick()
	{
	}

	public void RefreshUIByPaintState()
	{
	}

	public void RefreshUIByPaintShapeAndSolidOrHollow()
	{
	}

	public void ShowWarning()
	{
	}

	private void _003COnUIInit_003Eb__10_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
