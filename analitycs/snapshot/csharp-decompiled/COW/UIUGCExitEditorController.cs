using System;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCExitEditorController : UIPopupWindowController
{
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public UIUGCExitEditorController _003C_003E4__this;

		public Action<bool> callback;

		internal void _003CSave_003Eb__0(bool success)
		{
		}
	}

	private UIUGCExitEditorView m_View;

	private UIModelSceneEdit m_ModelSceneEdit;

	private UIModelUGCMyWorks m_ModelUGCMyWorks;

	private HNDHJGJILHC m_CurrentGame;

	private SceneEditSlotInfo m_CurrentSlotInfo => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override bool ClosedByEsc()
	{
		return false;
	}

	private void OnBtnSaveAndPublishClick()
	{
	}

	private void OnBtnSaveAndExitClick()
	{
	}

	private void OnBtnExitWithoutSavingClick()
	{
	}

	private void OnBtnUpdateClick()
	{
	}

	private void OnBtnExitClick()
	{
	}

	private void OnBgBtnClick()
	{
	}

	private void Save(Action<bool> callback)
	{
	}

	private void OpenPublishWindow(Action<uint, uint, bool> confirmCallback)
	{
	}

	private void ExitToMainMenu(bool saveLocal)
	{
	}

	private void TryPrepareTutorialCongratulationsOnReturnToLobby(bool isPublish)
	{
	}

	public UIWidget GetTutorialSaveAndPublishButtonWidget()
	{
		return null;
	}

	public UIWidget GetTutorialUpdateButtonWidget()
	{
		return null;
	}

	public UIWidget GetTutorialActivePublishEntryButtonWidget()
	{
		return null;
	}

	public GameObject GetTutorialSaveAndPublishClickGameObject()
	{
		return null;
	}

	public GameObject GetTutorialUpdateClickGameObject()
	{
		return null;
	}

	private void _003COnBtnSaveAndPublishClick_003Eb__9_0(bool isSuccess)
	{
	}

	private void _003COnBtnSaveAndPublishClick_003Eb__9_1(uint slotId, uint serverSlotId, bool isPublish)
	{
	}

	private void _003COnBtnSaveAndExitClick_003Eb__10_0(bool isSuccess)
	{
	}

	private void _003COnBtnUpdateClick_003Eb__12_0(uint slotId, uint serverSlotId, bool isPublish)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_ClosedByEsc()
	{
		return false;
	}
}
