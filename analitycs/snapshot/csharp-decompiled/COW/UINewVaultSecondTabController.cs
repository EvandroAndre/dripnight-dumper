using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UINewVaultSecondTabController : UIBaseController, IEasyList
{
	private UINewVaultSecondTabView m_View;

	private int count;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void RefreshEasyListNoClear(List<UINewVaultSecondTabItemViewData> dataList)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public UIEasyListItemController[] GetAllTabItemCtrl()
	{
		return null;
	}

	public void SelectTabItemByIndex(int index)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
