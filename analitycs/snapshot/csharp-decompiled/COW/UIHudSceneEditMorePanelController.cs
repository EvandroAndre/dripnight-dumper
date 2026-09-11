using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSceneEditMorePanelController : UIBaseController
{
	private UIHudSceneEditMorePanelView m_View;

	private SceneEditAgent m_Agent;

	private HNDHJGJILHC m_Game;

	private UISceneEditGameScene m_Scene;

	private UIModelSceneEdit m_ModelSceneEdit;

	private UIModelUGCModeEdit m_ModelUGCModeEdit;

	private UIUGCDebuggerConsole m_DebugConsoleWindow;

	private bool m_IsShowAttributeTips;

	private bool m_IsShowSkyBoxTips;

	private bool m_IsShowPerformanceEditorTips;

	private bool m_IsShowSocialTips;

	private bool m_IsShowProblemFeedbackTips;

	private SceneEditAgent Agent => null;

	protected override void OnUIInit()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	private void OnClickToHide(List<GameObject> hits)
	{
	}

	private void HidePanel()
	{
	}

	private void OnClickOpenHudEditorBtn()
	{
	}

	private void OnClickLocalFileBtn()
	{
	}

	private void OnClickResMgrBtn()
	{
	}

	private void OnClickOpenConsoleBtn()
	{
	}

	public void OnGraphEditBtnClick()
	{
	}

	private void OnShopEditBtnClick()
	{
	}

	private void OnPhysicsEditBtnClick()
	{
	}

	private void OnOpenPlotEditorBtnClick()
	{
	}

	private void OnOpenPerformanceEditorBtnClick()
	{
	}

	private void OnClickAttributeBtn()
	{
	}

	private void OnClickSkyBoxBtn()
	{
	}

	private void OnClickDataBaseBtn()
	{
	}

	private void OnClickSocialBtn()
	{
	}

	private void OnClickProblemFeedbackBtn()
	{
	}

	private void ShowPanel()
	{
	}

	private void OnErrorRefresh(object[] data)
	{
	}

	private void OnTemplateChange(object[] data)
	{
	}

	private void UpdateModeRelated(bool defaultBuildSetting)
	{
	}

	private void CheckErrorGuide()
	{
	}

	private void _003COnUIInit_003Eb__14_0(object[] args)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
