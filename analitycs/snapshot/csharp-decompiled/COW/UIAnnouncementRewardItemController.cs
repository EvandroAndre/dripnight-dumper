using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIAnnouncementRewardItemController : UIBaseController
{
	private UIAnnouncementRewardItemView m_View;

	private UIWidget m_ItemWiget;

	private const uint SIGNED_COLOR = 2779096575u;

	private static Dictionary<uint, string> ID_TO_LOCKEY_MAP;

	public Vector2 ItemSize => default(Vector2);

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void ShowChoosedSprite()
	{
	}

	public void SetData(AttendaceItemInfo attendaceInfo)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
