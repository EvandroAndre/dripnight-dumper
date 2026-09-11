using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIRuleHTabsContentController : UIBaseController, IEasyList
{
	public class TabData
	{
		public string Label;

		public string SubLabel;

		public int Index;

		public int ComponentIndex;
	}

	private sealed class _003C_003Ec__DisplayClass13_0
	{
		public UIRuleHTabsContentController _003C_003E4__this;

		public UIRuleHTabItemStyle2Controller item;

		internal void _003COpenItemController_003Eb__0(bool selected)
		{
		}
	}

	public CHTabsPanelData Data;

	private UIRuleHTabsContentView m_View;

	private UIModelUGCModeEdit m_Model;

	private List<UIBaseController> m_Components;

	private List<TabData> m_TabData;

	protected UIModeEditGeneralComponentHelper m_GeneralHelper;

	private Action m_DimensionsChanged;

	private int m_CurrentComponentIndex;

	private float m_Width;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void SetViewData(CHTabsPanelData data, float width)
	{
	}

	private void BuildChildComponent(Transform container, IModeEditComponentData data, TabData tabData)
	{
	}

	private void OnItemIndexChanged()
	{
	}

	private void Reposition()
	{
	}

	public void AddDimensionsChanged(Action callback)
	{
	}

	private void _003COnUIInit_003Eb__11_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
