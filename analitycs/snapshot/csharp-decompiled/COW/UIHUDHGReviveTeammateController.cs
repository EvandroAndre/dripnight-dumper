using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDHGReviveTeammateController : UIBaseController
{
	private UIHUDHGReviveTeammateView m_View;

	private bool m_IsShowDetail;

	private Dictionary<BHGGAEEHJCO, UIHUDHGTeammateReviveItem> m_UsedReviveItemMap;

	private Queue<UIHUDHGTeammateReviveItem> m_EmptyReviveItem;

	private Dictionary<BHGGAEEHJCO, bool> m_IsSelectedPlayerIDs;

	private uint m_CurOwnCoinNum;

	private bool m_IsTokenEnough;

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

	private void InitCoinNum()
	{
	}

	private void ShowDetailInfo(bool isShowDetail)
	{
	}

	private void OnShowDetailPanle()
	{
	}

	private void OnHideDetailPanle()
	{
	}

	private int ItemCompareWithReviveEndTime(Transform a, Transform b)
	{
		return 0;
	}

	private void OnLocalPlayerReviveCoinChange(uint coinNum)
	{
	}

	private void OnPlayerQuit(object[] data)
	{
	}

	private void OnPlayerRevive(object[] data)
	{
	}

	private void OnPlayerItemInfoChange()
	{
	}

	private UIHUDHGTeammateReviveItem GetPlayerItem(BHGGAEEHJCO playerID)
	{
		return null;
	}

	public void NewPlayerHelpInfoCome(BHGGAEEHJCO playerID, uint reviveLeftTimeMS)
	{
	}

	private void OnItemSelect(BHGGAEEHJCO playerId, bool isSelect)
	{
	}

	private void RefreshTokenShowData()
	{
	}

	private void SwitchConfirmState(bool isCanRevive)
	{
	}

	private void BindPlayer(BHGGAEEHJCO playerId, uint reviveLeftTimeMS, UIHUDHGTeammateReviveItem item)
	{
	}

	private void TryUnBindPlayer(BHGGAEEHJCO playerId)
	{
	}

	private void OnReviveConfirm()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
