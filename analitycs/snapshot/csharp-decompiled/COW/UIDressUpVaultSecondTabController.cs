using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIDressUpVaultSecondTabController : UIBaseController, IEasyList
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

	public void RefreshEasyList(List<UINewVaultSecondTabItemViewData> datas)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void SelectTabItemByIndex(int index)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
