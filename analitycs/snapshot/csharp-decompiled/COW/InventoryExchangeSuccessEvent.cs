using GCommon;

namespace COW;

public class InventoryExchangeSuccessEvent : GEvent
{
	public bool Success;

	public uint PickupDataID;

	public uint DropDataID;

	public uint DropCount;

	public void Reset(bool paramSuccess, uint paramPickupDataID, uint paramDropDataID, uint paramDropCount)
	{
	}
}
