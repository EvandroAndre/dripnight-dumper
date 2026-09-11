using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHUDPlayerAttributeUpController : UIBaseController
{
	private const int MAX_ITEM_COUNT = 4;

	private float m_ItemDeltaY;

	private UIHUDPlayerAttributeUpItem m_ItemTemplate;

	private Vector3 m_TemlateLocPos;

	private Queue<UIHUDPlayerAttributeUpItem> m_ItemQ;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void ShowMessage(string msg)
	{
	}

	public UIHUDPlayerAttributeUpItem DequeueItem()
	{
		return null;
	}

	public void Reposition()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
