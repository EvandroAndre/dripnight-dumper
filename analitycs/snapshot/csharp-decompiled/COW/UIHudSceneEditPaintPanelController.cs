using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudSceneEditPaintPanelController : UIBaseController
{
	private UIHudSceneEditPaintPanelView m_View;

	private SceneEditAgent mAgent;

	private SceneEditPaintTool mPaintTool;

	private UIToggleButton m_CurSelectedShapeBtn;

	private UIHudSceneEditCameraViewportController m_CameraViewportCtrl;

	private UISceneEditPaintStepAreaDrawController m_AreaDrawCtrl;

	private UISceneEditPaintStepIntervalAdjustController m_IntervalAdjustCtrl;

	private UISceneEditPaintStepItemPickController m_ItemPickCtrl;

	private Vector3 m_RaceStartPoint;

	private Vector3 m_RaceEndPoint;

	private UICommonGuideController m_ShapeSelectGuideCtrl;

	private SceneEditAgent Agent => null;

	private SceneEditPaintTool PaintTool => null;

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

	private bool DownloadOptionResIfNecessary()
	{
		return false;
	}

	private void OnSolidOrHollowToggleClick(bool isSolid)
	{
	}

	private void OnExitPaintModeClick()
	{
	}

	private void OnPaintModeToggleSelected(UIToggleButton button)
	{
	}

	private void OnRacePaintBtnClick()
	{
	}

	private void OnPreviewTabSelect(SceneEditPaintTool.KPIFDHNOJHD index)
	{
	}

	private void OnPlanBtnClick()
	{
	}

	private void OnQuitPaintBtnClick()
	{
	}

	private void OnGenerateBtnClick()
	{
	}

	private void OnEditBtnClick()
	{
	}

	private void OnFinishBtnClick()
	{
	}

	public void OnHidePaintPanel()
	{
	}

	public void RefreshCtrlByPaintStyle()
	{
	}

	public void RefreshCtrlByPaintState()
	{
	}

	private void ShowShapeSelectTutorial()
	{
	}

	private void RefreshChildControllers()
	{
	}

	public void RefreshCtrlByShape()
	{
	}

	public void RefreshCtrlBySolidOrHollow()
	{
	}

	public void RefreshCtrlByInterval()
	{
	}

	public void SetStartAndEndPoint(Vector3 startPoint, Vector3 endPoint)
	{
	}

	public void ShowStartAndEndPoint(bool show)
	{
	}

	public void RefreshCtrlIndicators()
	{
	}

	public void RefreshCtrlByCloudMode()
	{
	}

	public void RefreshCtrlByBasicMode()
	{
	}

	public void RefreshCtrlByRaceMode()
	{
	}

	public void RefreshCtrlByPrevieIndex()
	{
	}

	private void RefreshGenerateBtnStatus()
	{
	}

	private void RefreshIconSolidOrHollow()
	{
	}

	private void RefreshThemePanel()
	{
	}

	private void RefreshTips()
	{
	}

	public void RefreshAearWarning(bool active)
	{
	}

	public void RefreshGenerateRemind(bool remind, bool confirm)
	{
	}

	private void OnAreaPaintStepSelect(bool isselected)
	{
	}

	private void OnItemPickStepSelect(bool isselected)
	{
	}

	private void OnIntervalAdjustStepSelect(bool isselected)
	{
	}

	private void UpdateStepGrid()
	{
	}

	public void LateUpdate()
	{
	}

	private void _003COnUIInit_003Eb__15_0()
	{
	}

	private void _003COnUIInit_003Eb__15_1()
	{
	}

	private void _003COnUIInit_003Eb__15_2()
	{
	}

	private void _003COnUIInit_003Eb__15_3()
	{
	}

	private void _003COnExitPaintModeClick_003Eb__19_0()
	{
	}

	private void _003CShowShapeSelectTutorial_003Eb__32_0()
	{
	}

	private void _003CRefreshCtrlByCloudMode_003Eb__40_0()
	{
	}

	private void _003CRefreshCtrlByRaceMode_003Eb__42_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
