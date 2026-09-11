using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UILeaderBoardAwarWndController : UIPopupWindowController, IEasyList
{
	private UILeaderBoardAwarWndView m_View;

	private List<LeaderBoardAwarWndItemData> m_ItemsDataList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(List<List<BaseItemInfo>> itemsDataList, List<string> labelList, string title = "")
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
}
