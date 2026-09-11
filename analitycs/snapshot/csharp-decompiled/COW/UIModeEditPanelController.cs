using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIModeEditPanelController : UIPopupWindowController, IEasyList
{
	public class TabData
	{
		public string Label;

		public int Index;

		public bool enabled;
	}

	private sealed class _003C_003Ec__DisplayClass23_0
	{
		public string key;

		internal bool _003CTrySelectTabByLocKey_003Eb__0(TabData e)
		{
			return false;
		}
	}

	private UIModeEditPanelView m_View;

	private UIModelUGCModeEdit m_Model;

	private UIModelSceneEdit m_ModelSceneEdit;

	private List<UIBaseController> m_Components;

	private int m_CurrentComponentIndex;

	private List<TabData> m_TabData;

	private float m_Width;

	public CFullScreenWindow_VTabsPanelData Data;

	public ModeVariables Variables;

	private uint m_CurrentSelectedModeWithTemplate;

	private bool m_IsFeedBackInCD;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void CalCurrentSelectedModeWithTemplate()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData(CFullScreenWindow_VTabsPanelData data, ModeVariables variables)
	{
	}

	public override int MinGroupDepth()
	{
		return 0;
	}

	public void ResetVariable()
	{
	}

	private void BuildChildComponent(Transform container, IModeEditComponentData data)
	{
	}

	private void OnSelectTab(object[] param)
	{
	}

	private void OnItemIndexChanged()
	{
	}

	public void TrySelectTabByLocKey(string key)
	{
	}

	public void Jump2TargetCtrl(int id)
	{
	}

	public void Jump2TargetShop(string shopID)
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void OnBtnResetClick()
	{
	}

	private void OnBtnHelpClick()
	{
	}

	private void OnBtnSwitchModeClick()
	{
	}

	private void OnDirectSaveAsToEmptySlot()
	{
	}

	private void SwitchEditingToNewSlot(uint destSlotId)
	{
	}

	private void OnFeedBackBtnClick()
	{
	}

	public void RefreshFeedBackBtn()
	{
	}

	private void OnBtnOKClick()
	{
	}

	private bool CheckFullCustomVariableValid()
	{
		return false;
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public override bool IgnoreEsc()
	{
		return false;
	}

	private void _003COnBtnSwitchModeClick_003Eb__29_0(WorkshopCreateNewConfigData value)
	{
	}

	private void _003COnDirectSaveAsToEmptySlot_003Eb__30_0(bool success, uint destSlotId)
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

	public int _003C_003EiFixBaseProxy_MinGroupDepth()
	{
		return 0;
	}

	public bool _003C_003EiFixBaseProxy_IgnoreEsc()
	{
		return false;
	}
}
