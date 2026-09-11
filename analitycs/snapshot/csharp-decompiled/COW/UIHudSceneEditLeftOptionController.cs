using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using COW.Gameplay.UGC;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSceneEditLeftOptionController : UIHudUGCTutorialRestrictionBaseController, IUIModelDataChangeObserver
{
	private sealed class _003CCloseAndReopenModeSettingWindowCoro_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudSceneEditLeftOptionController _003C_003E4__this;

		public bool show;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCloseAndReopenModeSettingWindowCoro_003Ed__45(int _003C_003E1__state)
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

	private const string LOCK_VIEW_ICON = "UI_Customize_sj_icon";

	private const string FREE_VIEW_ICON = "UI_Customize_sj_icon1";

	private const string SINGLE_SELECTION_ICON = "FF_ingame_hud_UGC_multiple";

	private const string MULTIPLE_SELECTION_ICON = "FF_ingame_hud_UGC_multiple1";

	private const string BOX_SELECT_ICON = "FF_ingame_hud_UGC_selectbox";

	private const string BOX_SELECT_ACTIVE_ICON = "FF_ingame_hud_UGC_selectbox1";

	private const string ResMgrIconActive = "UI_Customize_Resource-_icon01";

	private const string ResMgrIconInActive = "UI_Customize_Resource _icon";

	private UIHudSceneEditLeftOptionView m_View;

	private HNDHJGJILHC m_Game;

	private UISceneEditGameScene m_Scene;

	private bool m_HasTutorialUrl;

	private UIModelSceneEdit m_ModelSceneEdit;

	private UIModelUGCModeEdit m_ModelUGCModeEdit;

	private bool m_ExportingData;

	private UIHudSceneEditCameraViewportController m_CameraViewportController;

	private UIUGCDebuggerConsole m_DebugConsoleWindow;

	private UIModeEditPanelController m_ModeSettingController;

	private UIHudSceneEditMessageButtonController m_MessageButtonController;

	private UIUnBlockOtherHudScript m_MoreBtnsScript;

	private bool m_ConsoleTips;

	private SceneEditAgent m_Agent;

	private SceneEditAgent Agent => null;

	public UIModeEditPanelController ModeSettingController => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnBtnDescChange()
	{
	}

	protected override void OnAfterTutorialRestrictionApplied()
	{
	}

	private void OnClickMoreSettingBtn()
	{
	}

	private void OnClickUndoBtn()
	{
	}

	private void OnClickRedoBtn()
	{
	}

	private void OnRefreshUndoBtnState()
	{
	}

	private void OnRefreshRedoBtnState()
	{
	}

	private void OnBtnMultipleSelection()
	{
	}

	private void OnBtnBoxSelect()
	{
	}

	private void OnBtnSwitchSigh()
	{
	}

	private void TutorialSetting()
	{
	}

	private void OnSaveBtnRefresh(bool isChanged)
	{
	}

	private void OnErrorRefresh(object[] data)
	{
	}

	private void OpenModeSettingWindow()
	{
	}

	private void CloseAndReopenModeSettingWindow(object[] data)
	{
	}

	private void CloseModeSettingWindow(object[] data)
	{
	}

	private void TryOpenModeSettingWindow(object[] data)
	{
	}

	private IEnumerator CloseAndReopenModeSettingWindowCoro(bool show = true)
	{
		return null;
	}

	private void OnClickOpenHudEditorBtn()
	{
	}

	private void OnPaintModeChange(bool status)
	{
	}

	private void OnTemplateChange(object[] data)
	{
	}

	private void OnModeSettingVarCtrlJump(object[] data)
	{
	}

	private void OnHideExpandTips(object[] data)
	{
	}

	private void OnRefreshExpandTips(object[] data)
	{
	}

	private void OnAttributeChanged(object[] data)
	{
	}

	private void RefreshShow()
	{
	}

	private void OnCameraModeChanged()
	{
	}

	private void UpdateModeRelated(bool defaultBuildSetting)
	{
	}

	private void OnSceneLoaded()
	{
	}

	private void InieModeSettingController()
	{
	}

	private void OnPaintBtnClick()
	{
	}

	private void OnClickSaveSceneBtn()
	{
	}

	private void OnClickBackBtn()
	{
	}

	public void RequestExitEditor()
	{
	}

	private bool CanRepublish()
	{
		return false;
	}

	private static bool TryGetLastTutorialTaskIndex(UGCTutorialSequenceData sequenceData, out int lastLevelIndex, out int lastTaskIndex)
	{
		lastLevelIndex = default(int);
		lastTaskIndex = default(int);
		return false;
	}

	private static bool HasReachedTutorialTask(int currentLevelIndex, int currentTaskIndex, int targetLevelIndex, int targetTaskIndex)
	{
		return false;
	}

	private void OnClickOpenConsoleBtn()
	{
	}

	private void OnSighExpandBtn()
	{
	}

	private void OnClickToCloseMoreBtns(List<GameObject> hits)
	{
	}

	private void OnExtendBtn()
	{
	}

	private void OnClickResMgrBtn()
	{
	}

	private void OnShopEditBtnClick()
	{
	}

	private void OnOpenPlotEditorBtnClick()
	{
	}

	private void OnOpenPerformanceEditorBtnClick()
	{
	}

	private void OnTutorialBtnClick()
	{
	}

	public void OnGraphEditBtnClick()
	{
	}

	private void OnResourceShopBtnClick()
	{
	}

	private void RefreshOpenHudEditorBtn()
	{
	}

	private void OnBoxSelectChanged()
	{
	}

	private void OnGameModeChanged(object[] data)
	{
	}

	private void OnResMgrModeChanged(object[] data)
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public UIWidget GetTutorialBackButtonWidget()
	{
		return null;
	}

	private void _003COnClickSaveSceneBtn_003Eb__59_0(EExportFailReason reason)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnAfterTutorialRestrictionApplied()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
