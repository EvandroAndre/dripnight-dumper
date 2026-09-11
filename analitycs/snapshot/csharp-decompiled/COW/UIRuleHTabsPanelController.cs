using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIRuleHTabsPanelController : UIRuleTabPanelBaseController, IEasyList
{
	public class TabData
	{
		public string Label;

		public string SubLabel;

		public int Index;

		public int ComponentIndex;
	}

	private UIRuleHTabsPanelView m_View;

	private UIModelUGCModeEdit m_Model;

	private List<UIRuleVScrollTableContainerController> m_Components;

	private int m_CurrentComponentIndex;

	private List<TabData> m_TabData;

	private float m_Width;

	public CHTabsPanelData Data;

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

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData(CHTabsPanelData data, float width)
	{
	}

	private void BuildChildComponent(Transform container, IModeEditComponentData data, TabData tabData)
	{
	}

	public override void ScrollToTargetUIRuleCtrl(int id)
	{
	}

	public override void ScrollToTargetShopCtrl(string shopID)
	{
	}

	private void OnItemIndexChanged()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
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

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_ScrollToTargetUIRuleCtrl(int P0)
	{
	}

	public void _003C_003EiFixBaseProxy_ScrollToTargetShopCtrl(string P0)
	{
	}
}
