using System.Collections.Generic;
using GCommon;

namespace COW;

public class TailorConfigDataManager : SingletonModule<TailorConfigDataManager>
{
	private sealed class _003C_003Ec__DisplayClass40_0
	{
		public uint itemID;

		internal bool _003CGetTailorIDByItemID_003Eb__0(TailorPreviewData x)
		{
			return false;
		}

		internal bool _003CGetTailorIDByItemID_003Eb__1(TailorPreviewData x)
		{
			return false;
		}
	}

	private CSVAsyncDataMap<uint, TailorTriggerEffectData> m_DictEffectItemIdToTriggerEffectData;

	private CSVAsyncDataMap<uint, TailorEffectData> m_DictEffectItemIdToEffectData;

	private Dictionary<uint, uint> m_DictClothIdToEffectItemID;

	private CSVAsyncDataMap<uint, TailorHaloData> m_DictEffectItemIdToHaloData;

	private Dictionary<uint, uint> m_DictClothIdToHaloEffectItemID;

	private CSVAsyncDataMap<uint, TailorSpotlightData> m_DictEffectItemIdToSpotLightData;

	private Dictionary<uint, uint> m_DictClothIdToSpotLightItemID;

	private CSVAsyncDataMap<uint, TailorPreviewData> m_DictTailorIDToTailorPreviewData;

	private Dictionary<uint, uint> m_DictTailorClothBasicItemIDToRecommendItemID;

	private List<TailorPreviewData> m_TailorPreviewDatas;

	private List<TailorUnlockData> m_TailorUnlockDatas;

	private HashSet<uint> m_TailorClothList;

	private Dictionary<uint, uint> m_EffectItemIDTotailorIDDic;

	private Dictionary<uint, TailorSeriesData> m_TailorSeriesData;

	private Dictionary<uint, bool> m_DictTailorClothBasicItemIDToBasicShowOn;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public void LoadWithRegion()
	{
	}

	public Dictionary<uint, TailorSeriesData> GetTailorSeriesData()
	{
		return null;
	}

	public bool IsTailorCloth(uint clothID)
	{
		return false;
	}

	public uint GetTailorIndex(uint clothID, uint tailorId = 0u)
	{
		return 0u;
	}

	public List<uint> GetClothsByTailorId(uint id, byte wardobeType)
	{
		return null;
	}

	public uint GetTailorIdBySetId(uint setId)
	{
		return 0u;
	}

	public uint GetTailorIdByClothId(uint clothId)
	{
		return 0u;
	}

	public bool IsTailorItemByTwoId(uint tailorId, uint clothId)
	{
		return false;
	}

	public uint GetTailorIDByEffectItemID(uint effecItemID)
	{
		return 0u;
	}

	public TailorPreviewData GetTailorPreviewDataByEffectItemID(uint effectItemID)
	{
		return null;
	}

	public uint GetEffectItemIDByClothID(uint clothID)
	{
		return 0u;
	}

	public uint GetHaloEffectItemIDByClothID(uint clothID)
	{
		return 0u;
	}

	public uint GetSpotLightEffectItemIDByClothID(uint clothID)
	{
		return 0u;
	}

	public TailorTriggerEffectData GetTailorTriggerEffectDataByItemID(uint itemID)
	{
		return null;
	}

	public HashSet<uint> GetPermenentEffectClothListByEffectItemIDs(uint itemID)
	{
		return null;
	}

	public TailorSpotlightData GetSpotlightEffectDataByEffectID(uint effectID)
	{
		return null;
	}

	public bool IsBasicTailorCloth(uint itemID)
	{
		return false;
	}

	public uint GetRecommendTailorClothItemID(uint itemID)
	{
		return 0u;
	}

	public bool IsRecommendTailorClothItemID(uint itemID)
	{
		return false;
	}

	public uint GetBasicBundleidByRecommendid(uint itemID)
	{
		return 0u;
	}

	public bool IsBasicShowOn(uint basicItemID)
	{
		return false;
	}

	private void InitDictTailorClothBasicItemIDToBasicShowOn()
	{
	}

	private void InitDictTailorClothBasicItemIDToRecommendItemID()
	{
	}

	public uint GetTailorIDByItemID(uint itemID)
	{
		return 0u;
	}

	public TailorPreviewData GetTailorPreviewDataByTailorID(uint tailorID)
	{
		return null;
	}

	public bool IsOwnedBasicBundle(uint clothID)
	{
		return false;
	}

	public List<AvatarWardrobeData> GetBasicTailorAvatarWardrobeDataByTailorID(uint TailorId)
	{
		return null;
	}
}
