using GCommon;
using UnityEngine;

namespace COW;

public class UICommonPopMenuItemController : UIBaseController
{
	protected UICommonPopMenuItemView m_View;

	protected CommonPopMenuData m_Data;

	private Vector3 m_localPostition;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public virtual void SetItemData(CommonPopMenuData data, int width, int height)
	{
	}

	public int getTextPixelWidth()
	{
		return 0;
	}

	public void setContainerWidth(int width)
	{
	}

	protected virtual void OnPopMenuItemClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
