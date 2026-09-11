using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UILobbyV2LobbyGachaBtnController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<AdvertDesc> _003C_003E9__10_0;

		internal int _003CSetCDNIcon_003Eb__10_0(AdvertDesc x, AdvertDesc y)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public uint entranceType;

		internal void _003CRefreshLobbyGachaEntrance_003Eb__0()
		{
		}
	}

	private UILobbyNewLobbyGachaBtnView m_View;

	private UICountDownController m_LobbyGachaCountCtrl;

	private UIModelGacha m_ModelGacha;

	private List<UINetworkTexture> m_CDNIconList;

	public static uint LobbyGachaId;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void SetCDNIcon()
	{
	}

	private void OnBtnLobbyGachaClick()
	{
	}

	public void RefreshLobbyGachaEntrance()
	{
	}

	public bool ShowLobbyGachaIntroIfNeed()
	{
		return false;
	}

	private void SetCDNBubble()
	{
	}

	private void SetVFX()
	{
	}

	private bool IsIchis55Gacha()
	{
		return false;
	}

	public void ResetLobbyGachaBubble()
	{
	}

	public void ResetTipsContainer(bool isShow)
	{
	}

	private void _003CSetCDNIcon_003Eb__10_1()
	{
	}

	private void _003CSetCDNBubble_003Eb__14_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
