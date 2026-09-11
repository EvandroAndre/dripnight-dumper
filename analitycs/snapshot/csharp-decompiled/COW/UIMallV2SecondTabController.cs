using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIMallV2SecondTabController : UIBaseController, IEasyList
{
	private UIMallV2SecondTabView m_View;

	private int count;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void RefreshEasyListNoClear(List<UIMallV2SecondTabItemViewData> dataList)
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

	public void ShowAni()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
