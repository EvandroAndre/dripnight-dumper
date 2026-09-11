using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

internal class ClanConfigDataManager : SingletonModule<ClanConfigDataManager>
{
	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public ClanAreaData data;

		internal bool _003CGetAreaList_003Eb__0(MultiPopMenuListData temp)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass19_1
	{
		public ClanAreaData data;

		internal bool _003CGetAreaList_003Eb__1(MultiPopMenuListData temp)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public uint areaId;

		internal bool _003CGetClanAreaData_003Eb__0(ClanAreaData e)
		{
			return false;
		}
	}

	private string[] m_FilterPool;

	private List<MultiPopMenuListData> m_RankCondDatas;

	private List<MultiPopMenuListData> m_LevelCondDatas;

	private List<ClanAreaData> m_ClanAreaDatas;

	private Dictionary<uint, ClanTagData> m_DictTagIdToTagData;

	public static uint CASUAL_MAIN_TAG_ID;

	public static uint HARDCORE_MAIN_TAG_ID;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public ClanAreaData GetClanAreaData(uint areaId)
	{
		return null;
	}

	public bool IsOpenArea()
	{
		return false;
	}

	public string StringArrayToLabel(List<string> strs)
	{
		return null;
	}

	public string GetTagStringLabelFromID(uint tagId)
	{
		return null;
	}

	public string GetTagStringKeyFromID(uint tagId)
	{
		return null;
	}

	public List<MultiPopMenuListData> GetTags()
	{
		return null;
	}

	public void ProcessClanPresetRanksRankMapping()
	{
	}

	public void ProcessClanPresetCSRanksRankMapping()
	{
	}

	public string GetRankCondStringFromID(uint rank, bool isBR = true)
	{
		return null;
	}

	public string GetLevelCondStringFromID(uint level)
	{
		return null;
	}

	public List<MultiPopMenuListData> GetAreaList()
	{
		return null;
	}

	public string GetAreaStringFromID(uint areaId)
	{
		return null;
	}

	public int GetPlayerMaxRequestsPerDay()
	{
		return 0;
	}

	public bool GetPromotionCost(out int cost, out EInventory.CurrencyType tokenType)
	{
		cost = default(int);
		tokenType = default(EInventory.CurrencyType);
		return false;
	}

	private void ProcessTagData()
	{
	}

	public ClanTagData GetClanTagDataById(uint id)
	{
		return null;
	}

	public List<ClanTagData> GetClanTagDataList(List<uint> ClanTagIdList)
	{
		return null;
	}

	public List<ClanTagData> GetClanTagDataListByType(EClanTagType type)
	{
		return null;
	}

	public List<uint> GetClanTagIDListByType(EClanTagType type)
	{
		return null;
	}
}
