using System;
using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyV2RelayMartEntranceController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static OnFinished _003C_003E9__17_0;

		internal void _003CRefreshRelayMartEntrance_003Eb__17_0()
		{
		}
	}

	private UILobbyV2RelayMartEntranceView m_View;

	private UICountDownController m_CountDownCtrl;

	private UIModelRelayMart m_ModelRelayMart;

	private UITipsNormalController m_TipsCtrl;

	private ResourceID m_VFXResId;

	private GameObject m_VFXObj;

	private bool m_IsShowCDNIcon;

	private bool m_HasShowEntranceAnim;

	public bool HasShowEntranceAnim
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

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

	private void OnRelayMartEntranceClick()
	{
	}

	private void SetCDNIcon()
	{
	}

	public void RefreshRelayMartEntrance()
	{
	}

	public void ResetTipsContainer(bool isShow)
	{
	}

	private void InitTipsView()
	{
	}

	private void RefreshVFX()
	{
	}

	private void InstantVFXObj()
	{
	}

	private void DestroyVFXObj()
	{
	}

	private void _003CSetCDNIcon_003Eb__16_0()
	{
	}

	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
