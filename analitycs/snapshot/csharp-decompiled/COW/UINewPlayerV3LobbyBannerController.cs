using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UINewPlayerV3LobbyBannerController : UIBaseController
{
	public enum EState
	{
		ShowKelly,
		HideKelly
	}

	private UIStandardItemMiniController m_StandardItemMiniCtrl;

	private UINewPlayerV3LobbyBannerView m_View;

	private EState m_State;

	private Vector3 m_DefaultLabelLocPos;

	private Vector3 m_DefaultRewardConLocPos;

	private const int HideKellyLabelX = 26;

	private const int HideKellyRewardContX = -91;

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

	public void SetViewData(AwardDesc itemInfo, bool showKelly)
	{
	}

	private void SetState(EState state)
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
}
