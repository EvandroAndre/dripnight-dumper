using System.Collections.Generic;
using COW.GamePlay;
using message;

namespace COW;

internal class UIHudLobbySocialPrivilegeManager
{
	private Dictionary<uint, BMLJJJLOCDE> m_PlayerPrivilegeMapping;

	public void BuildPrivilegeTable(ref Dictionary<uint, int> itemCountTables)
	{
	}

	public void SyncPrivilegeItemFromLocalPlayer()
	{
	}

	private void SetPrivilegeItems(List<BMLJJJLOCDE> privilegeItemInfos)
	{
	}

	public bool TryGetSlotItemForPlayer(LobbySocialPropType slot, out NAELPAAELNO item)
	{
		item = null;
		return false;
	}

	public bool IsPrivilegeItem(uint ItemDataID)
	{
		return false;
	}

	public bool IsPrivilegeItem(NAELPAAELNO item)
	{
		return false;
	}

	public bool IsAvailablePrivilegeItem(NAELPAAELNO item)
	{
		return false;
	}

	public BMLJJJLOCDE TryGetPrivilegeItem(uint dataId)
	{
		return null;
	}

	public bool IsPrivilegeItemAvailable(uint dataId)
	{
		return false;
	}

	public int GetExpireRemainingSecondsFromWarehouseByDataId(uint dataId)
	{
		return 0;
	}

	public bool IsPrivilegeItemExpired(uint dataId)
	{
		return false;
	}

	public ulong GetExpireEndUnixFromWarehouseForCountdown(uint dataId)
	{
		return 0uL;
	}
}
