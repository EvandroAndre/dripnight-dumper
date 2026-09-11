using System.Collections.Generic;
using GCommon;
using message;

namespace COW;

public class UIHudSceneEditPlotEditorPlotPopupEditorController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public UIHudSceneEditPlotEditorPlotPopupEditorPlotItemController controller;

		public UIHudSceneEditPlotEditorPlotPopupEditorController _003C_003E4__this;

		internal void _003CRefreshPlots_003Eb__0()
		{
		}
	}

	private UIHudSceneEditPlotEditorPlotPopupEditorView m_View;

	private UIModelUGCPlotEdit m_Model;

	private List<UIHudSceneEditPlotEditorPlotPopupEditorPlotItemController> m_ItemControllers;

	private int m_CurSelectPlotIndex;

	private bool m_FieldNameInputFocused;

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

	private void RefreshViewData()
	{
	}

	private void RefreshEmpty()
	{
	}

	private void OnUIInitFieldPlotId()
	{
	}

	private void OnRefreshViewDataFieldPlotId()
	{
	}

	private void OnUIInitFieldName()
	{
	}

	private void OnRefreshViewDataFieldName()
	{
	}

	private void OnUIInitFieldTriggerType()
	{
	}

	private void OnRefreshViewDataFieldTriggerType()
	{
	}

	private void OnBtnLeave()
	{
	}

	private void OnBtnNewPlot()
	{
	}

	private void OnBtnOpen()
	{
	}

	private void OnBtnCopy()
	{
	}

	private void OnBtnDelete()
	{
	}

	private void OnFieldTriggerTypeBtnHelp()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
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

	private void _003COnUIInitFieldName_003Eb__15_0()
	{
	}

	private void _003COnUIInitFieldName_003Eb__15_1()
	{
	}

	private void _003COnUIInitFieldName_003Eb__15_2()
	{
	}

	private void _003COnBtnDelete_003Eb__23_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
