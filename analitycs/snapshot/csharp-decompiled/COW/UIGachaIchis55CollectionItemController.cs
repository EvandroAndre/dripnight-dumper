using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIGachaIchis55CollectionItemController : UIBaseController
{
	private UIGachaIchis55CollectionItemView m_View;

	private Ichis55CollectionItemData m_Data;

	private Action m_OnAnimDone;

	private static readonly Dictionary<uint, string> ITEM_ICON_SPRITE_NAME_MAP;

	private static readonly Dictionary<uint, Vector3> ITEM_ICON_POSITION_MAP;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetData(Ichis55CollectionItemData data, bool needActivateAnim, Action onAnimDone = null)
	{
	}

	private void RefreshView(bool needActivateAnim)
	{
	}

	private void RefreshIconSprite()
	{
	}

	private void OnIconBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
