using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using ReactUI;
using UnityEngine;

namespace COW;

public class UIHudSceneEditSettingPanelController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass41_0
	{
		public UIModelSceneEdit model;

		public UIHudSceneEditSettingPanelController _003C_003E4__this;

		internal void _003COnBtnSwitchModeClick_003Eb__0(WorkshopCreateNewConfigData value)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass42_0
	{
		public UIHudSceneEditSettingPanelController _003C_003E4__this;

		public UIModelSceneEdit model;

		internal void _003COnDirectSaveAsToEmptySlot_003Eb__0(bool success, uint destSlotId)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass60_0
	{
		public HNDHJGJILHC game;

		public UIHudSceneEditSettingPanelController _003C_003E4__this;

		internal void _003COpenClearSceneConfirmWindow_003Eb__0()
		{
		}

		internal void _003COpenClearSceneConfirmWindow_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass85_0
	{
		public UIHudSceneEditSettingPanelController _003C_003E4__this;

		public UIModelSceneEdit m_ModelSceneEdit;

		internal void _003CExportAllDataAndSave_003Eb__0(bool result)
		{
		}
	}

	private sealed class _003CJump2TargetCtrl_003Ed__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameObject targetObj;

		public UIWidget targetWidget;

		public UIHudSceneEditSettingPanelController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CJump2TargetCtrl_003Ed__68(int _003C_003E1__state)
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

	private bool m_isShow;

	private UIModelUGCModeEdit m_Model;

	private HNDHJGJILHC m_Game;

	private UISceneEditGameScene m_Scene;

	private UIHudSceneEditSettingPanelView m_View;

	private uint m_DelayCall;

	private uint m_CurrentSelectedModeWithTemplate;

	private List<UIBaseController> m_ModeSettingController;

	private Dictionary<int, UIRuleUnionSettingController> m_DictUnionCtrls;

	private SceneEditAgent m_Agent;

	private bool m_IsInAutoSaving;

	private UIHudAutoSavePopupController m_AutoSavePopupCtrl;

	private UIHudSceneEditUnionSettingController m_GridCtrl;

	private UIPopMenuSmallControler m_EditGraphCtrl;

	private List<PopMenuData> m_EditGraphDataList;

	private Dictionary<string, string> m_GraphPopMap;

	private string m_SelectedGraph;

	private List<string> m_AutoSaveDropDownNames;

	private UIVariable var_CurrentGridGranList;

	private UIVariable var_CurrentGridGranID;

	private UIVariable var_CurrentGridGranShow;

	private List<float> m_CurrentGridGranIDList;

	private UIVariable var_CurrentAutoSaveTimeList;

	private UIVariable var_CurrentAutoSaveTimeID;

	private UIVariable var_CurrentAutoSaveTimeShow;

	private uint m_delayCallId;

	private List<int> m_delayTimeList;

	private SceneEditAgent Agent => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitUIGridSettings()
	{
	}

	private void RefreshCustomModeSetting()
	{
	}

	private UIBaseController BuildChildComponent(Transform container, IModeEditComponentData data, int width, int index)
	{
		return null;
	}

	private void Reposition()
	{
	}

	private void SaveVariables()
	{
	}

	private bool CheckFullCustomVariableValid()
	{
		return false;
	}

	private bool CheckShowWebTutorial()
	{
		return false;
	}

	private void ShowPointDragTips()
	{
	}

	private void OnSliderDragFinished()
	{
	}

	private void OnSliderDragStart()
	{
	}

	private void OnClickToHide(List<GameObject> hits)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void InitPopMenu()
	{
	}

	public void GenerateEditGraphList()
	{
	}

	private void Tutorial()
	{
	}

	private void OnGraphSelect(object obj)
	{
	}

	public void OnGraphEditBtnClick()
	{
	}

	private void OnShopEditBtnClick()
	{
	}

	private void OnBtnSwitchModeClick()
	{
	}

	private void OnDirectSaveAsToEmptySlot(UIModelSceneEdit model)
	{
	}

	private void SwitchEditingToNewSlot(UIModelSceneEdit model, uint destSlotId)
	{
	}

	private void OnBtnHudDescClick()
	{
	}

	private void OnBtnAIAssitClick()
	{
	}

	private void OnGridSettingChanged(bool isOn)
	{
	}

	private void RefreshToggleGrid(bool isOn)
	{
	}

	private void OnBtnGripSnapClick()
	{
	}

	private void RefreshToggleGridSnap(bool isOn)
	{
	}

	private void OnBtnFriendGroupInvitationClick()
	{
	}

	private void OnBtnDepthMapModeClick()
	{
	}

	private void RefreshBtnDepthMapMode(bool isOn)
	{
	}

	private void ResetUIState()
	{
	}

	private void ShowPanel()
	{
	}

	private void HidePanel()
	{
	}

	private void ShowTip(string key)
	{
	}

	private void OnTemplateChange()
	{
	}

	private void UpdateModeRelated()
	{
	}

	private void OpenClearSceneWindow()
	{
	}

	private void OpenClearSceneConfirmWindow()
	{
	}

	private void OpenModeSettingWindow()
	{
	}

	private void PlayToggleAudio()
	{
	}

	private void OnSliderChanged()
	{
	}

	private void OnSliderInputSubmit()
	{
	}

	private void OnToggleEditMode(UIToggleButton selectBtn)
	{
	}

	private void OnToggleSetUp(UIToggleButton selectBtn)
	{
	}

	private void OnModeSettingVarCtrlJump(object[] data)
	{
	}

	private IEnumerator Jump2TargetCtrl(GameObject targetObj, UIWidget targetWidget)
	{
		return null;
	}

	private void OnEditValueModify(object[] data)
	{
	}

	private void event_OnSelectGridGran(object[] args)
	{
	}

	private void RefreshGridGranList()
	{
	}

	private void event_OnSelectAutoSaveTime(object[] args)
	{
	}

	private void StopAutoSave()
	{
	}

	private void RefreshAutoSaveTimeList()
	{
	}

	private void ResetAutoSaveTimer()
	{
	}

	private void ExportAllDataAndSave()
	{
	}

	private void ShowAutoSavePopup()
	{
	}

	private void HideAutoSavePopup()
	{
	}

	private void OnReturnToLobby(object[] args)
	{
	}

	private void OnManuallySave(object[] args)
	{
	}

	private void _003COnUIInit_003Eb__21_0()
	{
	}

	private void _003COnUIInit_003Eb__21_1()
	{
	}

	private void _003COnUIInit_003Eb__21_2(object[] args)
	{
	}

	private void _003COnUIInit_003Eb__21_3(object[] args)
	{
	}

	private void _003COnUIInit_003Eb__21_4(object[] args)
	{
	}

	private void _003CShowPanel_003Eb__54_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
