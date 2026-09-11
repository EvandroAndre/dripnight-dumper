using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class AvatarWardrobeDataManager : SingletonModule<AvatarWardrobeDataManager>
{
	public enum EPlayerIdentity
	{
		LocalPlayer,
		Teammate,
		Enemy
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<LegendClothData> _003C_003E9__56_0;

		internal int _003CGetSortedLegendClothDataByLegendId_003Eb__56_0(LegendClothData a, LegendClothData b)
		{
			return 0;
		}
	}

	private const int CapacityClothData = 7000;

	private IntervalTreeDic<AvatarWardrobeData> m_dictIdToWardrobeDataTree;

	private Dictionary<uint, AvatarWardrobeData> m_dictIdToWardrobeData;

	private List<ClothesExt_Effect> m_ClothesExtEffect;

	private List<ClothesExt> m_ClothesExt;

	private Dictionary<uint, LegendClothData> m_dictIdToLegendClothData;

	private Dictionary<uint, LegendClothPrivilegeData> m_dicIdToLegendClothPrivilegeData;

	private Dictionary<uint, ClothesHairUpData> m_dictIdToHairUpData;

	private Dictionary<uint, ClothEffectData> m_dictIdToClothEffectData;

	private Dictionary<uint, MaterialRefData> m_dictIdToMaterialRefData;

	private Dictionary<uint, MaterialDataList> m_dictIdToBackpackMaterialRefData;

	private Dictionary<uint, List<AvatarWardrobeData>> m_dictWardrobeSets;

	private Dictionary<uint, ClothesUpData> m_dictIdToClothUpData;

	private Dictionary<uint, EpicClothesTextData> m_dictIdToEpicClothesData;

	private Dictionary<int, AvatarHDRecipeData> m_dictHDRecipeData;

	private Dictionary<uint, ClothesPrivilegeData> m_dictClothesPrivilegeData;

	private Dictionary<uint, ClothesLinkSetID> m_dictIdToClothesLinkSetID;

	private Dictionary<int, List<AvatarRecipeMappingData>> m_dictResipeMappingTargetData;

	private Dictionary<int, List<AvatarRecipeMappingData>> m_dictResipeMappingConditionData;

	private List<ResourceID> m_resourceIDList;

	private CSVAsyncDataMap<uint, ClothesTriggerData> m_DictClothIdToSkeletonEffectData;

	public const uint EPICDEFAULTCLOTHID = 203000619u;

	public const uint EPICHACKDEFAULTCLOTHID = 203001180u;

	private const uint EPICMAXLEVELCLOTHID = 203000621u;

	protected override void OnCleanup()
	{
	}

	private void PreLoadCSVText()
	{
	}

	public void MultiThreadLoad(object o)
	{
	}

	public void MultiThreadInit()
	{
	}

	protected override void OnInit()
	{
	}

	private void LoadCSVData()
	{
	}

	private AvatarWardrobeData GetAvatarWardrobeDataFromList(List<AvatarWardrobeData> typeList, uint id)
	{
		return null;
	}

	public bool HairIsLevelUpClothes(uint id)
	{
		return false;
	}

	public List<uint> FindHairsAllLevel(uint id)
	{
		return null;
	}

	public uint FindHairByLevel(uint id, int level)
	{
		return 0u;
	}

	private void AddRecipeMapping(int key, AvatarRecipeMappingData wData, ref Dictionary<int, List<AvatarRecipeMappingData>> map)
	{
	}

	public IEnumerable<AvatarWardrobeData> FindAllAvatarWardrobeData()
	{
		return null;
	}

	public Dictionary<uint, LegendClothData> GetLegendData()
	{
		return null;
	}

	public List<uint> GetSameSeriesIds(AvatarWardrobeData cloth, uint seriesId)
	{
		return null;
	}

	public bool IsSeriesClothItem(uint clothId)
	{
		return false;
	}

	public bool IsSeriesClothItem(AvatarWardrobeData data)
	{
		return false;
	}

	public uint GetSeriesId(uint clothId)
	{
		return 0u;
	}

	public uint GetSeriesId(AvatarWardrobeData data)
	{
		return 0u;
	}

	public uint GetSeriesIndex(AvatarWardrobeData data)
	{
		return 0u;
	}

	public ESeriesClothType GetSeriesType(uint clothId)
	{
		return ESeriesClothType.None;
	}

	public ESeriesClothType GetSeriesType(AvatarWardrobeData data)
	{
		return ESeriesClothType.None;
	}

	public uint GetSeriesClothBaseLevelItemId(uint clothId)
	{
		return 0u;
	}

	public uint GetLegendClothIdByClothId(uint clothId)
	{
		return 0u;
	}

	public bool IsClothItemLegend(uint clothId)
	{
		return false;
	}

	public bool IsClothItemLegend(AvatarWardrobeData data)
	{
		return false;
	}

	public bool IsSetLegend(uint setId)
	{
		return false;
	}

	public uint GetLegendLevelByClothId(uint clothId)
	{
		return 0u;
	}

	public uint GetLegendTypeByClothId(uint clothId)
	{
		return 0u;
	}

	public uint GetLegendLevelBySet(uint setId)
	{
		return 0u;
	}

	public uint GetLegendTypeBySet(uint setId)
	{
		return 0u;
	}

	public uint GetLegendGroupAnimIdBySet(uint setId)
	{
		return 0u;
	}

	public bool HaveOwnedLegendClothByLegendId(uint legendId)
	{
		return false;
	}

	public LegendClothData GetLegendClothLockLevel(uint legendId, out int unlockLevelMax)
	{
		unlockLevelMax = default(int);
		return null;
	}

	public ResourceID GetLegendClothColorIconByLegendIdAndLevel(uint legendId, uint level)
	{
		return default(ResourceID);
	}

	public LegendClothData GetLegendClothDataByLegendIdAndLevel(uint legendId, uint level)
	{
		return null;
	}

	public List<LegendClothData> GetSortedLegendClothDataByLegendId(uint legendId)
	{
		return null;
	}

	public uint GetLegendClothIdByBundleId(uint bundleId)
	{
		return 0u;
	}

	public LegendClothPrivilegeData GetLegendClothPrivilegeDataById(uint id)
	{
		return null;
	}

	public uint GetLegendClothPrivilegeSortIdById(uint id)
	{
		return 0u;
	}

	public ClothesExt_Effect GetClothesExtEffectByIndex(ushort index)
	{
		return null;
	}

	public ClothesExt GetClothesExtByIndex(ushort index)
	{
		return null;
	}

	public List<AvatarWardrobeData> GetLegendAvatarWardrobeData(uint legendId, uint level = 1u)
	{
		return null;
	}

	public AvatarWardrobeData GetLegendAvatarWardrobeData(uint legendId, uint level, UIModelAvatarBase.EWardrobeType wardrobeType)
	{
		return null;
	}

	public AvatarWardrobeData FindAvatarWardrobeDataById(uint InId)
	{
		return null;
	}

	public List<AvatarRecipeMappingData> FindRecipeMappingForTarget(int recipe)
	{
		return null;
	}

	public List<AvatarRecipeMappingData> FindRecipeMappingForCondition(int recipe)
	{
		return null;
	}

	public ClothEffectData FindClothEffectDataByQuality(uint quality)
	{
		return null;
	}

	public ResourceID FindMatRefIDByClothID(uint clothID, bool female = false, bool inGame = false)
	{
		return default(ResourceID);
	}

	public ResourceID FindMatRefIDByBackpackID(uint clothID, int level, bool female = false)
	{
		return default(ResourceID);
	}

	public List<ResourceID> FindMatRefIDByBackpackID(uint back_pack_id)
	{
		return null;
	}

	public bool ShowClothEffect(EPlayerIdentity pId, bool isFrontEndGame = false)
	{
		return false;
	}

	public List<AvatarWardrobeData> GetWardrobeSet(uint setID)
	{
		return null;
	}

	public bool HasAnimationInCloth(AvatarWardrobeData wData)
	{
		return false;
	}

	private V FincData<K, V>(Dictionary<K, V> dic, K k) where V : class
	{
		return null;
	}

	public ClothesUpData FindFirstClothesUpDataByClothesID(uint clothesID)
	{
		return null;
	}

	public ClothesUpData FindClothesUpDataByClothesAndIndex(uint clothesID, uint index)
	{
		return null;
	}

	public ClothesUpData FindEpicClothesUpDataByLevel(uint clothesID, int targetLevel)
	{
		return null;
	}

	public EpicClothesTextData FindEpicClothesTextData(uint id)
	{
		return null;
	}

	public bool IsEpicClothes(uint id)
	{
		return false;
	}

	public int GetHDRecipe(int defaultRecipe)
	{
		return 0;
	}

	public ClothesPrivilegeData FindClothesPrivilegeByID(uint privilegeId)
	{
		return null;
	}

	public int GetLobbyRecipe(uint dataID, uint avatarId, bool isFemale)
	{
		return 0;
	}

	public int GetLobbyRecipe(AvatarWardrobeData wData, uint avatarId, bool isFemale)
	{
		return 0;
	}

	public bool CheckHasTeamIdById(uint Id)
	{
		return false;
	}

	public uint GetTeamIdById(uint Id)
	{
		return 0u;
	}

	public ClothesTriggerData FindSkeletonEffectDataById(uint id)
	{
		return null;
	}

	public bool CheckClothesBySetID(uint setID, AvatarWardrobeData wData)
	{
		return false;
	}

	public uint[] GetLinkSetIdListByClothesID(uint clothesID)
	{
		return null;
	}
}
