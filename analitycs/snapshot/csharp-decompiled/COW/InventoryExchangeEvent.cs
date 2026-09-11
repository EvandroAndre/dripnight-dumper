using COW.GamePlay;
using GCommon;

namespace COW;

public class InventoryExchangeEvent : GEvent
{
	public ICLMFONIIKB CurrentItem;

	public bool CheckClickCD;

	public void Reset(ICLMFONIIKB item, bool paramCheckClickCD)
	{
	}
}
