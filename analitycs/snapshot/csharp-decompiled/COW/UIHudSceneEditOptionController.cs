using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudSceneEditOptionController : UIHudUGCTutorialRestrictionBaseController, IUIModelDataChangeObserver
{
	private UIHudSceneEditOptionView m_View;

	private UIModelSceneEdit m_ModelSceneEdit;

	private UIHudSceneEditCodeSearchController m_SceneEditCodeSearchCtrl;

	private HNDHJGJILHC m_Game;

	private SceneEditAgent m_Agent;

	private UIUGCDebuggerOpen m_DebugOpenWindow;

	private bool m_ItemPanelShown;

	private bool m_ItemPanelFold;

	private bool m_MoreSettingPanelPop;

	private bool m_MorePanelPop;

	private bool m_PaintModePanelPop;

	private bool m_ItemGenPanelPop;

	private bool m_ResMrgPanelPop;

	private bool m_AttributePanelPop;

	private bool m_SkyBoxPanelPop;

	private SceneEditAgent Agent => null;

	private UIUGCDebuggerOpen DebugOpenWindow => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void Update()
	{
	}

	private void OnBtnDescChange()
	{
	}

	private void OnItemPanelChanged(object[] data)
	{
	}

	private void OnMoreSettingAppear(object[] data)
	{
	}

	private void OnMoreAppear(object[] data)
	{
	}

	private void OnSkyBoxAppear(object[] data)
	{
	}

	private void OnSkyBoxDisappear(object[] data)
	{
	}

	private void OnMoreDisappear(object[] data)
	{
	}

	private void OnMoreSttingDisappear(object[] data)
	{
	}

	private void OnPaintModePanelAppear()
	{
	}

	private void OnPaintModePanelDispear(object[] data)
	{
	}

	private void OnItemGenPanelAppear()
	{
	}

	private void OnItemGenPanelDispear(object[] data)
	{
	}

	private void OnResMgrModeChanged(object[] data)
	{
	}

	private void OnAttributeChanged(object[] data)
	{
	}

	private void OnPaintModeChange(bool value)
	{
	}

	private void OnSceneEditPrefabChosen()
	{
	}

	private void OnCameraModeChange()
	{
	}

	private void RefreshPositionBtn()
	{
	}

	private void RefreshPos()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	protected override void OnAfterTutorialRestrictionApplied()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void OnClickChangeLookBtn(object[] data)
	{
	}

	private void OnClickChangeEditBtn()
	{
	}

	private void OnQuitPreviewBtn()
	{
	}

	private void OnPreviewModeBtn()
	{
	}

	private void OnFocusBtnClick()
	{
	}

	private void OnClickGoToMatchBtn()
	{
	}

	private void OnClickDebugSettingBtn()
	{
	}

	private void OnModeChanged(object[] data)
	{
	}

	private void RefreshButtonVisible()
	{
	}

	private void OnEnterPreviewMode(object[] data)
	{
	}

	private void OnGameModeChange(object[] data)
	{
	}

	private void OnClickGMVerifyBtn()
	{
	}

	private void OnOpenDebugFromGraph(object[] data)
	{
	}

	private void TutorialDebugOpenBtn(object[] data)
	{
	}

	public UIWidget GetTutorialChangeLookButtonWidget()
	{
		return null;
	}

	public UIWidget GetTutorialChangeEditButtonWidget()
	{
		return null;
	}

	private void _003COnUIInit_003Eb__20_0()
	{
	}

	private void _003COnGameModeChange_003Eb__55_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnAfterTutorialRestrictionApplied()
	{
	}
}
