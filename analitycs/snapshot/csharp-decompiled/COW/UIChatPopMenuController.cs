using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIChatPopMenuController : UIBasePopMenuController<UIChatPopMenuItemContoller>
{
	private UICommonPopMenuView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void UpdateMenuData(List<CommonPopMenuData> list, ulong userid)
	{
	}

	public void UpdateMenuData(List<CommonPopMenuData> list, ulong userid, Vector3 WindowPos)
	{
	}

	private void UpdateMenuDataWithFixedWidth(List<CommonPopMenuData> list, int width)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
