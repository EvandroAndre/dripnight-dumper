using System;
using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyV2PurchaseEventBtnController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static OnFinished _003C_003E9__12_0;

		internal void _003CRefreshPurchaseEventEntrance_003Eb__12_0()
		{
		}
	}

	private UILobbyNewPurchaseEventBtnView m_View;

	private UICountDownController m_PurchaseEventCountCtrl;

	private const int BG_MAX_WIDTH = 94;

	private GameObject m_VFXOBJ;

	private uint m_DelayCallId;

	private bool m_TagActive;

	private float m_TagAnimLength;

	private uint m_DelayCallShowCountDownId;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnPurchaseEventClick()
	{
	}

	private void SetCDNIcon()
	{
	}

	public void RefreshPurchaseEventEntrance()
	{
	}

	public void ResetTipsContainer(bool isShow)
	{
	}

	private void DelayCallCreateVFX()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void _003CSetCDNIcon_003Eb__11_0()
	{
	}

	private void _003CDelayCallCreateVFX_003Eb__14_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
