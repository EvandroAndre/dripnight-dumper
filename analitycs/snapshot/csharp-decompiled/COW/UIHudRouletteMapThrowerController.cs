using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudRouletteMapThrowerController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__16_0;

		public static Action _003C_003E9__16_1;

		internal void _003CSetControllerCursorEvent_003Eb__16_0()
		{
		}

		internal void _003CSetControllerCursorEvent_003Eb__16_1()
		{
		}
	}

	private static float MaxMoveDis;

	private static float CancelRadius;

	private static float CancelRadiusSquare;

	private UIHudRouletteMapThrowerView m_View;

	private List<UIHudMapThrowerItem> m_ItemList;

	private UIHudMapThrowerItem m_SelectItem;

	private int m_SelectIndex;

	private float m_FixedRatio;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public void SetViewData(Vector3 curDirection, bool isShow, bool globalStop)
	{
	}

	private void SetSelectItem(UIHudMapThrowerItem item)
	{
	}

	protected override void SetControllerCursorEvent(Action OnShowOrCreate, Action OnHideOrDestory)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
