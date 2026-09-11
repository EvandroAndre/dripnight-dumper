using GCommon;
using UnityEngine;

namespace COW;

public class UIHudReviveNotifyController : UIBaseController
{
	private UIHudReviveNotifyView m_View;

	private UIHudSFRoleplayReviveNotifySummonerNodeController m_SummonerNode;

	private GameObject m_IIVIcon;

	private GameObject m_EnergyDeviceIcon;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(int reviveCardID, string useRevivePlayerName, string customKey = "")
	{
	}

	public void RefreshRootView(bool isShow)
	{
	}

	private EReviveType GetReviveType(int reviveCardID)
	{
		return EReviveType.HighRankCard;
	}

	public bool IsShowReviveTips(int reviveCardID)
	{
		return false;
	}

	private void _003CSetData_003Eb__6_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
