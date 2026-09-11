using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

internal class UISceneEditPaintStepItemPickController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass38_0
	{
		public int themeId;

		internal bool _003CDownloadOptionalResIfNecessary_003Eb__0(UISceneEditPaintThemeIconController x)
		{
			return false;
		}

		internal bool _003CDownloadOptionalResIfNecessary_003Eb__1(UISceneEditPaintThemeIconController x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass47_0
	{
		public int id;

		internal bool _003CRefreshItemSmallIcons_003Eb__1(UGCAI_Procedural_ThemeInfo x)
		{
			return false;
		}

		internal bool _003CRefreshItemSmallIcons_003Eb__2(UGCAI_Procedural_Racing_Info x)
		{
			return false;
		}
	}

	private SceneEditAgent mAgent;

	private SceneEditPaintTool mPaintTool;

	private UIHudNewSceneEditItemPanelController mItemPanel;

	private bool m_IsSelect;

	private bool m_Ready;

	public Action<bool> m_OnSelectedCallback;

	public Action OnGridRepisionNow;

	private List<UGCAI_Procedural_ThemeInfo> m_Datas;

	private List<UGCAI_Procedural_Racing_Info> m_RaceDatas;

	private List<UISceneEditPaintThemeIconController> m_ThemeCtrls;

	private List<UISceneEditPaintThemeIconController> m_RaceCtrls;

	private List<UISceneEditPaintItemIconController> m_BasicItemCtrlList;

	private List<UISceneEditPaintItemIconController> m_CloudItemCtrlList;

	private UISceneEditPaintStepItemPickView m_View;

	private SceneEditAgent Agent => null;

	private SceneEditPaintTool PaintTool => null;

	private UIHudNewSceneEditItemPanelController ItemPanel => null;

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

	public bool IsReady
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public List<UGCAI_Procedural_ThemeInfo> Datas => null;

	public List<UGCAI_Procedural_Racing_Info> RaceDatas => null;

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

	private void OnEnableMultiClick()
	{
	}

	private void OnItemPanelSelectItem(uint itemID)
	{
	}

	private void OnThemeSVDragStart()
	{
	}

	private void OnThemeSVDragFinish()
	{
	}

	public void RegisterStepSelectedCallback(Action<bool> callback)
	{
	}

	public bool DownloadOptionalResIfNecessary()
	{
		return false;
	}

	public void ShowWarning()
	{
	}

	public void RefreshCtrlByPaintStyle()
	{
	}

	public void RefreshUIByPaintState()
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

	private void RefreshItemPanel()
	{
	}

	private void RefreshReadyStatus()
	{
	}

	private void RefreshItemSmallIcons()
	{
	}

	private void RefreshBasicGrid()
	{
	}

	private void RefreshCloudToggle()
	{
	}

	private void RefreshCloudGrid()
	{
	}

	private void RefreshRaceThemeGrid()
	{
	}

	private void _003COnUIInit_003Eb__31_0()
	{
	}

	private void _003COnUIInit_003Eb__31_1()
	{
	}

	private void _003COnUIInit_003Eb__31_2()
	{
	}

	private void _003CRefreshItemSmallIcons_003Eb__47_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
