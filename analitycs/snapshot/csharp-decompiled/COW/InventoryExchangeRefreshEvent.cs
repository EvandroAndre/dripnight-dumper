using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

public class InventoryExchangeRefreshEvent : GEvent
{
	public List<ICLMFONIIKB> CurrentPickUpList;

	public void Reset(List<ICLMFONIIKB> paramList)
	{
	}
}
