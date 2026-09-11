using System.Collections.Generic;
using COW.GamePlay;
using proto;

namespace COW;

public class HippoCrisisStoreItemData
{
	public class HippoCrisisStoreCostHippoItemData
	{
		public uint m_CostId;

		public uint m_CostNum;

		public int m_Level;

		public HippoCrisisStoreCostHippoItemData(uint costId, uint costNum, int level)
		{
		}
	}

	public uint m_StoreId;

	public uint m_SortId;

	public uint m_ItemID;

	public uint m_Weight;

	public uint m_HippoMoneyPrice;

	public uint m_PurchaseCnt;

	public List<HippoCrisisStoreCostHippoItemData> m_CostHippoItems;

	public HippoStoreDesc m_StoreDesc;

	public PIJKGPDBNJC m_Type;

	private HENEHAGJCLI m_ItemData;

	public HippoCrisisStoreItemData(uint itemId)
	{
	}

	public HippoCrisisStoreItemData(HippoStoreDesc storeDesc)
	{
	}
}
