using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudSceneEditShopChosenPanelController : UIBaseController, IEasyList
{
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public uint optionId;

		internal bool _003COnSelectMainTab_003Eb__0(uint e)
		{
			return false;
		}
	}

	private UIHudSceneEditShopChosenPanelView m_View;

	private BGBANEBBDCH m_ShopManager;

	private List<uint> m_SortedMainTypeList;

	private List<List<uint>> m_SortedSubTypeList;

	private List<UIHudSceneEditItemPanelTabView> m_CachedMainTabViewList;

	private List<UIHudSceneEditItemPanelTabView> m_CachedSubTabViewList;

	private bool m_Inited;

	private uint m_CurrentSelectedModeWithTemplate;

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

	private void RefreshUI()
	{
	}

	private void CalModeRelatedItem()
	{
	}

	private void RefreshItemUI()
	{
	}

	private void OnSelectMainTab(UIToggleButton button)
	{
	}

	private void OnSelectSubTab(UIToggleButton button)
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

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
