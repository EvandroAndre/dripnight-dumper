using System.Collections.Generic;
using GCommon;
using message;

namespace COW;

public class UIHudSceneEditPlotEditorActorPopupEditorController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public UIHudSceneEditPlotEditorActorPopupEditorActorIconItemController controller;

		public UIHudSceneEditPlotEditorActorPopupEditorController _003C_003E4__this;

		internal void _003COnUIInitFieldActorIcon_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public UIHudSceneEditPlotEditorActorPopupEditorActorItemController controller;

		internal void _003CRefreshActorData_003Eb__0()
		{
		}
	}

	private UIHudSceneEditPlotEditorActorPopupEditorView m_View;

	private UIModelUGCPlotEdit m_Model;

	private List<UIHudSceneEditPlotEditorActorPopupEditorActorItemController> m_ActorItemControllers;

	private bool m_FieldActorNameInputFocused;

	private List<UIHudSceneEditPlotEditorActorPopupEditorActorIconItemController> m_IconControllers;

	public CHEOJCABHJJ m_CurSelectActor
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int m_CurSelectActorIndex => 0;

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

	private void OnBtnNewActorClick()
	{
	}

	private void OnBtnDeleteClick()
	{
	}

	private void OnUIInitFieldActorName()
	{
	}

	private void OnRefreshViewDataFieldActorName()
	{
	}

	private void OnUIInitFieldActorIcon()
	{
	}

	private void OnRefreshViewDataFieldActorIcon(bool recenter = false)
	{
	}

	private void RefreshActorData()
	{
	}

	private void RefreshSelectedActor()
	{
	}

	private void _003COnUIInitFieldActorName_003Eb__19_0()
	{
	}

	private void _003COnUIInitFieldActorName_003Eb__19_1()
	{
	}

	private void _003COnUIInitFieldActorName_003Eb__19_2()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
