using System;
using System.Collections.Generic;
using COW.Gameplay.UGC;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIUGCHudEditorController : UIPopupWindowController
{
	private UIUGCHudEditorView m_View;

	private UGCEditPanel m_EditPanel;

	private UIUGCHudWidgetSelectorController m_WidgetSelector;

	private UIUGCHudWidgetInspectorController m_Inspector;

	private UIUGCHudWidgetHierarchyController m_Hierarchy;

	private UIModelUGCHudEdit m_Model;

	private UIModelSceneEdit m_ModelScene;

	private List<UGCHudWidget> m_HudWidgetList;

	private UGCHudPrefabRoot m_PrefabRoot;

	private UGCHudWidget m_CurrentWidget;

	private Action m_CloseAction;

	private float PANEL_MIN_ZOOM_RATIO;

	private float PANEL_MAX_ZOOM_RATIO;

	private Color m_TransformDefaultColor;

	private Color m_TransformChangeColor;

	private uint m_DelayHideTransformInfoId;

	public static uint MaxHierarchy;

	private bool m_ShowHudBg;

	private bool m_IsDirty;

	private Vector2 m_MouseCurrentPos;

	private Color m_FrameDefaultColor;

	private Color m_FrameChangeColor;

	public bool IsDirty => false;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void Hide()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetData(NLNAMPBAGDC prefabData)
	{
	}

	private void StopAllTutorial()
	{
	}

	private void OnDragGroundGuide(object[] data)
	{
	}

	private void OnZoomGroundGuide(object[] data)
	{
	}

	private void OnUnShelectGuide(object[] data)
	{
	}

	private void OnCreateButtonGuide(object[] data)
	{
	}

	private void OnCategoryGuide(object[] data)
	{
	}

	public void SetCloseCallback(Action close)
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void RefreshCommandBtn()
	{
	}

	private void OnUndoClick()
	{
	}

	private void OnRedoClick()
	{
	}

	private void OnInputBtnClick()
	{
	}

	private void OnLabelBtnClick()
	{
	}

	private void OnImageBtnClick()
	{
	}

	private void OnButtonBtnClick()
	{
	}

	private void OnEmptyBtnClick()
	{
	}

	private void OnHudBtnClick()
	{
	}

	private UGCHudWidget CreateHudItem(UGCHudWidgetType hudType)
	{
		return null;
	}

	private void OnPressHudItem(GameObject target, bool pressed)
	{
	}

	private void OnClickPanel()
	{
	}

	private void OnCurrentHudItemChanged(UGCHudWidget widget)
	{
	}

	private void OnAddHudWidget(UGCHudWidget widget)
	{
	}

	private void OnRemoveHudWidget(UGCHudWidget widget)
	{
	}

	private void OnCloneHudWidget(UGCHudWidget widget)
	{
	}

	private void OnPinchAndSpreadPanel(float start, float end)
	{
	}

	private void InitWidgetTransformShow()
	{
	}

	private void OnWidgetPositionChanged()
	{
	}

	private void OnWidgetSizeChanged()
	{
	}

	private void OnWidgetRotationChanged()
	{
	}

	private void OnWidgetNameChanged()
	{
	}

	private void OnWidgetParentChanged(Transform parent)
	{
	}

	private void SetTransformInfoColor(UIWidget widget, Color c)
	{
	}

	private void CancelDelayHideTransformInfo()
	{
	}

	private void _003COnCurrentHudItemChanged_003Eb__49_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
