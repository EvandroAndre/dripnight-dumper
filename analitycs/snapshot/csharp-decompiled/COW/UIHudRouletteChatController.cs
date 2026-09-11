using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudRouletteChatController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__21_0;

		public static Action _003C_003E9__21_1;

		internal void _003CSetControllerCursorEvent_003Eb__21_0()
		{
		}

		internal void _003CSetControllerCursorEvent_003Eb__21_1()
		{
		}
	}

	private static float MaxMoveDis;

	private static float CancelRadius;

	private static float CancelRadiusSquare;

	private UIHudRouletteChatView m_View;

	private List<UIHudRouletteItem> m_ItemList;

	private UIHudRouletteItem m_SelectItem;

	private int m_SelectIndex;

	private UIModelQuickMessage m_QuickMsgModel;

	private float m_FixedRatio;

	private bool m_ShowedServerData;

	private bool m_ShowedDefaultData;

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

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void RefreshMsg()
	{
	}

	private void SetMsgs()
	{
	}

	private void PlayAnimation(bool flag)
	{
	}

	public void SetViewData(Vector3 curDirection, bool isShow, bool globalStop)
	{
	}

	protected override void SetControllerCursorEvent(Action OnShow, Action OnHideOrDestory)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
