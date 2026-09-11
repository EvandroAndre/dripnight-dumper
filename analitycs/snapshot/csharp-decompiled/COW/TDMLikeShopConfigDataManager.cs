using System.Collections.Generic;
using GCommon;
using message;

namespace COW;

internal class TDMLikeShopConfigDataManager
{
	private bool hasSyncWithServer;

	private Dictionary<uint, List<TDMLikeShopConfigData>> m_TDMLikeShopDataDic;

	private Dictionary<uint, TDMLikeShopConfigData> m_TDMLikeShopDataExpandDic;

	public void LoadTDMLikeShopData()
	{
	}

	public void OnServerSyncTDMLikeShop(List<LBCPODNGKEI> tdmShopItems)
	{
	}

	public List<uint> GetTDMShopFilterList()
	{
		return null;
	}

	public TDMLikeShopConfigData GetTDMShopDataByIndex(uint index)
	{
		return null;
	}

	public uint GetMainItemDataIDByIndexId(uint indexId)
	{
		return 0u;
	}

	public List<TDMLikeShopConfigData> GetTDMShopItemListByFilter(uint filter)
	{
		return null;
	}

	public void OnCleanUp()
	{
	}

	private ResourceID GetShopConfigRes()
	{
		return default(ResourceID);
	}

	public ResourceID GetTDMLikeConfigName(uint map_id, uint mode_id)
	{
		return default(ResourceID);
	}
}
