using System.Collections.Generic;

namespace COW;

public class HippoCrisisInventoryData
{
	public uint Totalcapacity;

	public uint CurrentUsageCapacity;

	private uint m_CurrentUIDataUsageCapacity;

	public uint InventoryLevel;

	public List<HippoCrisisOutGameItemUIData> InventoryItems;

	public List<HippoCrisisOutGameItemUIData> InventoryUIItems;

	public uint CurrentInventoryItemsTotalValue => 0u;

	public uint CurrentInventoryItemTotalBuyPrice => 0u;

	public uint CurrentUIDataUsageCapacity
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public uint RemainCapacity => 0u;
}
