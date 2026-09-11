using System;
using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCBigMapAreaItemController : UIBaseController
{
	private UIUGCParadiseRegionItemView m_View;

	public Action OnAreaAppyClick;

	private uint m_areaID;

	public static float SIZE_MAP_PIXEL_X;

	private static Vector4 CurrentMapOffset;

	public uint AreaID => 0u;

	public UIToggleButton Toggle => null;

	public static float MIN_OFFSET_X => 0f;

	public static float MAX_OFFSET_X => 0f;

	public static float MIN_OFFSET_Z => 0f;

	public static float MAX_OFFSET_Z => 0f;

	public static float SIZE_MAP_X => 0f;

	public static float OFFSET_SCALE_RATIO_X => 0f;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(WorkShopEditAreaConfigData data)
	{
	}

	public void AddButtonSelectAnim()
	{
	}

	private void OnAreaSelect(UIToggleButton button)
	{
	}

	private Vector2 GetRegionMappingPos(Vector3 regionCenter)
	{
		return default(Vector2);
	}

	private Vector3 GetMapCenter()
	{
		return default(Vector3);
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
