using System.Collections.Generic;
using GCommon;
using message;

namespace COW;

public class UIHudSceneEditPlotEditorDialogueItemController : UIBaseController, IUIModelDataChangeObserver
{
	public HMJODCEJBFF DialogueData;

	private MPGMIACDBGN m_PlotBelongs;

	private UIHudSceneEditPlotEditorDialogueItemView m_View;

	private UIModelUGCPlotEdit m_Model;

	private List<UIHudSceneEditPlotEditorDialogueOptionItemController> m_OptionControllers;

	private float m_HeightPadding;

	private float m_SelectedHeightPading;

	private UIAtlas m_ActorOriginAtlas;

	private UISpriteData m_ActorOriginSpriteData;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(HMJODCEJBFF dialogueData, int index, MPGMIACDBGN plotBelongs)
	{
	}

	public void AddCallback(EventDelegate.Callback callback)
	{
	}

	public void SetSelected(bool value)
	{
	}

	private void OnBtnDeleteClick()
	{
	}

	private void RefreshDeleteBtn()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void RefreshDisplay()
	{
	}

	private void RefreshSelectedOption()
	{
	}

	private void _003COnBtnDeleteClick_003Eb__14_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
