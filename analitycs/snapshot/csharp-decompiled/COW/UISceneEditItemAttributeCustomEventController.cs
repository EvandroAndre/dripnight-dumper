using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

public class UISceneEditItemAttributeCustomEventController : UIBaseController, IUIHudSceneEditInspectorItemAttribute
{
	private UISceneEditItemAttributeEventClipView m_View;

	private List<UISceneEditItemAttributeCustomEventItemController> m_ChildrenCtrls;

	private Action m_OnRefreshListRequested;

	public Action<NPDBPIJFAHH, List<ItemEditAttributeUIData_V2>> OnNavigateToSubMenu;

	public Action<NPDBPIJFAHH, List<ItemEditAttributeUIData_V2>, SceneEditObjectBase> OnRefreshInspetor;

	private UISceneEditItemAttributeCustomEventItemController m_CurrentEventItem;

	private ItemEditAttributeUIDataCustomEventSelector mData;

	public event Action OnRefreshListRequested
	{
		add
		{
		}
		remove
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

	public void OnItemRemove(UISceneEditItemAttributeCustomEventItemController item)
	{
	}

	public void OnItemJump(UISceneEditItemAttributeCustomEventItemController item)
	{
	}

	public void InitShowData(ItemEditAttributeUIData_V2 data)
	{
	}

	private void RefreshList()
	{
	}

	private void OnBtnAddClick()
	{
	}

	public void TriggerRefresh()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
