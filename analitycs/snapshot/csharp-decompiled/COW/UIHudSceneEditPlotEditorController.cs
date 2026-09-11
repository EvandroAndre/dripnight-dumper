using System.Collections.Generic;
using GCommon;
using message;

namespace COW;

public class UIHudSceneEditPlotEditorController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private enum EState
	{
		EditPlot,
		EditDialogue,
		EditOption
	}

	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public UIHudSceneEditPlotEditorDropdownController dropdown;

		public UIModelUGCPlotEdit model;

		internal void _003CInitDialogueListPlotDropdown_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass24_1
	{
		public MPGMIACDBGN plot;

		public _003C_003Ec__DisplayClass24_0 CS_0024_003C_003E8__locals1;

		internal void _003CInitDialogueListPlotDropdown_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass33_0
	{
		public UIHudSceneEditPlotEditorPlotItemController controller;

		internal void _003CRefreshPlots_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass36_0
	{
		public UIHudSceneEditPlotEditorDialogueItemController controller;

		public UIHudSceneEditPlotEditorController _003C_003E4__this;

		internal void _003CRefreshDialogues_003Eb__0()
		{
		}
	}

	private UIHudSceneEditPlotEditorView m_View;

	private UIModelUGCPlotEdit m_Model;

	private EState m_CurState;

	private List<UIHudSceneEditPlotEditorPlotItemController> m_PlotItemControllers;

	private List<UIHudSceneEditPlotEditorDialogueItemController> m_DialogueItemControllers;

	private UIHudSceneEditPlotEditorDialogueInspectorController m_DialogueInspectorController;

	private UIHudSceneEditPlotEditorOptionInspectorController m_OptionInspectorController;

	private UIHudSceneEditPlotEditorDropdownController m_DialogueListPlotDropdownController;

	private MPGMIACDBGN m_CurSelectPlot
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private int m_CurSelectPlotIndex => 0;

	private HMJODCEJBFF m_CurSelectDialogue
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private int m_CurSelectDialogueIndex => 0;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	private void TurnToState(EState state)
	{
	}

	private void InitDialogueListPlotDropdown()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void OnBtnLeaveClick()
	{
	}

	private void OnBtnReturnClick()
	{
	}

	private void OnBtnNewPlotClick()
	{
	}

	private void OnDialogueListBtnEditPlotClick()
	{
	}

	private void OnDialogueListBtnEditActorClick()
	{
	}

	private void OnBtnPlotPopupClick()
	{
	}

	private void RefreshPlots()
	{
	}

	private void RefreshSelectedPlot()
	{
	}

	private void RefreshPlotDisplay(MPGMIACDBGN plot)
	{
	}

	private void RefreshDialogues()
	{
	}

	public void RefreshSelectedDialogue(bool recenter = false)
	{
	}

	public void RefreshEmpty()
	{
	}

	private void _003CTurnToState_003Eb__23_2()
	{
	}

	private void _003CTurnToState_003Eb__23_3()
	{
	}

	private void _003CTurnToState_003Eb__23_4()
	{
	}

	private void _003CTurnToState_003Eb__23_0()
	{
	}

	private void _003CTurnToState_003Eb__23_5()
	{
	}

	private void _003CTurnToState_003Eb__23_1()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
