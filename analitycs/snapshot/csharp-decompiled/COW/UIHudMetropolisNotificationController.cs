using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMetropolisNotificationController : UIBaseController
{
	public class FMessageData
	{
		public HKNJPFCPFOH type;

		public float endtime;

		public FMessageData(HKNJPFCPFOH type)
		{
		}
	}

	private UIHudMetropolisNotificationView m_View;

	private List<FMessageData> m_MessageList;

	private List<UIHudMetropolisCommonItemController> m_ItemList;

	private string CASH_ITEM_NAME;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public Vector3 GetTokenFlyPlayerMsgStartPos()
	{
		return default(Vector3);
	}

	public Vector3 GetTokenFlyMissionMsgStartPos()
	{
		return default(Vector3);
	}

	public Vector3 GetTokenFlySettleMsgStartPos()
	{
		return default(Vector3);
	}

	public void Update()
	{
	}

	private void OnBroadCastMessage(GEvent data)
	{
	}

	private void OnPlayerMessage(GEvent data)
	{
	}

	private void OnScoreChanged(object[] data)
	{
	}

	private void OnCurCoinAdd(int delta)
	{
	}

	private void AddMessage(FLPBLFEPIKH data)
	{
	}

	private void UpdateRewardMessageItemReward(List<BNEBJDGNGIG> list)
	{
	}

	private void ClearAllMessage()
	{
	}

	private void ClearMessage(HKNJPFCPFOH type)
	{
	}

	private FMessageData GetMessage(HKNJPFCPFOH type)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
