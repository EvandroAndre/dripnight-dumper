using System;
using System.Collections.Generic;
using COW.GamePlay;
using COW.Gameplay.UGC;
using COW.Gameplay.UGC.BlockEdit;
using GCommon;
using message;

namespace COW;

public class UIModelUGCResourceSelect : UIBaseModel
{
	public enum ETableType
	{
		enIcon = 1,
		enVFX = 2,
		enSound = 4,
		enObject = 8,
		enItem = 0x10,
		enSkyEnv = 0x20,
		enTexture = 0x40,
		enItemGenerator = 0x80,
		enWeaponGenerator = 0x100,
		enClothes = 0x200,
		enWeaponSkin = 0x400,
		enEmote = 0x800,
		enVehicleSkin = 0x1000,
		enBagSkin = 0x2000,
		enAvatarSkill = 0x4000,
		enNPCAvatar = 0x8000,
		enPetClothes = 0x10000,
		enPetEmote = 0x20000,
		enNPCRigName = 0x40000,
		enNPCAnimStateClip = 0x80000,
		enDialogueStyle = 0x100000,
		enHud = 0x200000,
		enTimeline = 0x400000,
		enPetSkill = 0x800000
	}

	public enum EAvatarFirstTab
	{
		enNone = 0,
		enClothTShirt = 3,
		enClothLeg = 4,
		enClothShoes = 5,
		enClothFace = 8,
		enClothHead = 11,
		enClothSet = 12,
		enClothTattoo = 14,
		enClothWeapon = 201,
		enClothBag = 202,
		enAnimationState = 210,
		enAnimationEmote = 211,
		enAnimationState_AI = 212,
		enModel = 101,
		enCloth = 102,
		enBone = 103,
		enAnimation = 104,
		enFemaleAvatar = 1001,
		enMaleAvatar = 1002,
		enPetAvatar = 1003
	}

	public class AvatarEditorTabData
	{
		public int TabID;

		public string TabNameKey;

		public string TabIcon;

		public int ChildItemCount;

		public bool IsEnable;
	}

	public enum EAvatarEditorItemType
	{
		enNone,
		enCloth,
		enAvatar,
		enPet,
		enWeapon,
		enEmote,
		enBag,
		enNull,
		enAnimationState
	}

	public class AvatarEditorItemData
	{
		public EAvatarEditorItemType FFItemType;

		public int FFItemID;

		public FCAJEKECGME BaseResData;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<UGCAssetMetadata> _003C_003E9__15_0;

		internal int _003CGetListFromExplorer_003Eb__15_0(UGCAssetMetadata a, UGCAssetMetadata b)
		{
			return 0;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec__41<T> where T : FCAJEKECGME
	{
		public static readonly _003C_003Ec__41<T> _003C_003E9;

		public static Func<FCAJEKECGME, int> _003C_003E9__41_0;

		internal int _003CLoadSortAndBuild_003Eb__41_0(FCAJEKECGME item)
		{
			return 0;
		}
	}

	private Dictionary<uint, List<FCAJEKECGME>> DataMaps;

	private Dictionary<uint, Dictionary<string, FCAJEKECGME>> DataResIDDictionary;

	private Dictionary<uint, Dictionary<uint, FCAJEKECGME>> DataIDDictionary;

	private Dictionary<uint, Dictionary<uint, int>> PlayerDynamicResDic;

	private UGCAssetExplorer m_ugcExplorer;

	private uint m_generatedUniqueID;

	private List<AvatarEditorTabData> m_avatarEditorFirstTabs;

	private List<AvatarEditorTabData> m_avatarEditorAvatarTabs;

	private List<AvatarEditorTabData> m_avatarEditorClothTabs;

	private List<AvatarEditorTabData> m_avatarEditorAnimationTabs;

	private AvatarEditorItemData m_avatarEditorNullItem;

	private List<AvatarEditorTabData> m_avatarEditorMaleAvatarItems;

	private List<AvatarEditorTabData> m_avatarEditorFemaleAvatarItems;

	private List<AvatarEditorTabData> m_avatarEditorPetAvatarItems;

	private Dictionary<int, List<AvatarEditorItemData>> m_avatarEditorMaleAllClothItems;

	private Dictionary<int, List<AvatarEditorItemData>> m_avatarEditorFemaleAllClothItems;

	private Dictionary<int, List<AvatarEditorItemData>> m_avatarEditorCommonClothItems;

	private Dictionary<int, List<AvatarEditorItemData>> m_avatarEditorAllAvatarItems;

	private Dictionary<uint, List<AvatarEditorItemData>> m_avatarEditorPetClothesItems;

	private Dictionary<uint, List<AvatarEditorItemData>> m_avatarEditorPetEmoteItems;

	private Dictionary<uint, AvatarEditorItemData> m_avatarEditorFFItemID2Item;

	private Dictionary<int, List<AvatarEditorItemData>> m_avatarEditorEmotes;

	private Dictionary<int, List<AvatarEditorItemData>> m_avatarEditorAnimationStates;

	private Dictionary<int, List<AvatarEditorItemData>> m_avatarEditorAnimationStates_AIGenerate;

	private Dictionary<int, List<AvatarEditorItemData>> m_avatarEditorAnimationStates_FF;

	private List<WorkshopNPCRigName> m_avatarEditorNPCRigNameList;

	public UGCAssetExplorer UGCAssetExplorer => null;

	public override uint GetModelType()
	{
		return 0u;
	}

	private uint GenerateUniqueID()
	{
		return 0u;
	}

	private void EnsureUGCExplorer()
	{
	}

	public void DestroyUGCExplorer()
	{
	}

	public void RegisterRefreshResourcesEvent()
	{
	}

	private void OnLocalFileChanged(object[] data)
	{
	}

	private List<FCAJEKECGME> GetListFromExplorer(IHDACHNBFNG resourceType, string tag, Func<UGCAssetMetadata, FCAJEKECGME> createStub)
	{
		return null;
	}

	private List<FCAJEKECGME> GetTextureListFromExplorer()
	{
		return null;
	}

	private List<FCAJEKECGME> GetIconListFromExplorer()
	{
		return null;
	}

	private List<FCAJEKECGME> GetVfxListFromExplorer()
	{
		return null;
	}

	private List<FCAJEKECGME> GetSkyEnvListFromExplorer()
	{
		return null;
	}

	private List<FCAJEKECGME> GetSoundListFromExplorer()
	{
		return null;
	}

	private List<FCAJEKECGME> GetTimelineList()
	{
		return null;
	}

	private List<FCAJEKECGME> GetHudListFromExplorer()
	{
		return null;
	}

	private List<FCAJEKECGME> GetObjectListFromExplorer()
	{
		return null;
	}

	private List<FCAJEKECGME> GetItemListFromExplorer()
	{
		return null;
	}

	private List<FCAJEKECGME> GetItemGeneratorListFromExplorer()
	{
		return null;
	}

	private List<FCAJEKECGME> GetWeaponGeneratorListFromExplorer()
	{
		return null;
	}

	private List<FCAJEKECGME> GetClothesListFromExplorer()
	{
		return null;
	}

	private List<FCAJEKECGME> GetNPCAvatarListFromExplorer()
	{
		return null;
	}

	private List<FCAJEKECGME> GetPetClothesListFromExplorer()
	{
		return null;
	}

	private List<FCAJEKECGME> GetPetEmoteListFromExplorer()
	{
		return null;
	}

	private List<FCAJEKECGME> GetNPCAnimStateClipListFromExplorer()
	{
		return null;
	}

	private List<FCAJEKECGME> GetWeaponSkinListFromExplorer()
	{
		return null;
	}

	private List<FCAJEKECGME> GetEmoteListFromExplorer()
	{
		return null;
	}

	private List<FCAJEKECGME> GetVehicleSkinListFromExplorer()
	{
		return null;
	}

	private List<FCAJEKECGME> GetBagSkinListFromExplorer()
	{
		return null;
	}

	private List<FCAJEKECGME> GetAvatarSkillListFromExplorer()
	{
		return null;
	}

	private List<FCAJEKECGME> GetPetSkillListFromConfig()
	{
		return null;
	}

	public void LoadTables(ETableType tableFlags)
	{
	}

	public void MarkReload(ETableType tableTypes)
	{
	}

	private void MakeSureTableLoaded(ETableType tableType)
	{
	}

	private void LoadSortAndBuild<T>(ETableType tableType, List<T> rawList) where T : FCAJEKECGME
	{
	}

	public void GetResourceTypeList(ETableType tableType, List<int> retTypeIDList, List<string> retTypeLocKeyList)
	{
	}

	public void GetResourceSubTypeList(ETableType tableType, List<int> retSubTypeIDList, List<string> retSubTypeLocKeyList)
	{
	}

	public List<FCAJEKECGME> GetResourceDataList(ETableType tableType)
	{
		return null;
	}

	public void GetResourceDataByType(ETableType tableType, int itemType, List<object> retDataList)
	{
	}

	public void GetResourceDataByType(ETableType tableType, int itemType, int itemSubType, List<object> retDataList)
	{
	}

	public void GetResourceData(ETableType tableType, List<object> retDataList)
	{
	}

	public FCAJEKECGME GetResourceDataByResID(ETableType tableType, string resID)
	{
		return null;
	}

	public FCAJEKECGME GetResourceDataByID(ETableType tableType, uint id)
	{
		return null;
	}

	public static void TryPreviewResource(ValueData valueData)
	{
	}

	public static bool TryExtSelect(ValueData valueData, Action<string, int> callback)
	{
		return false;
	}

	public static string GetEntityName(ETableType tableType, int itemID)
	{
		return null;
	}

	public static string GetEntityName(uint itemID)
	{
		return null;
	}

	public void AddUGCDynamicLegalRes(ETableType resType, uint resID)
	{
	}

	public void RemoveUGCDynamicLegalRes(ETableType resType, uint resID)
	{
	}

	public bool CheckIsDynamicRes(ETableType type, uint resID)
	{
		return false;
	}

	public List<AvatarEditorTabData> GetAvatarEditorFirstTabList()
	{
		return null;
	}

	public List<AvatarEditorTabData> GetAvatarEditorAvatarTabList()
	{
		return null;
	}

	public List<AvatarEditorTabData> GetAvatarEditorAnimationTabList()
	{
		return null;
	}

	public List<AvatarEditorTabData> GetAvatarEditorClothTabList(bool refreshCount, bool isFemale)
	{
		return null;
	}

	public List<AvatarEditorItemData> GetAvatarEditorClothItemsNoSex(EAvatarFirstTab tabIDEnum)
	{
		return null;
	}

	public List<AvatarEditorItemData> GetAvatarEditorItems(EAvatarFirstTab tabIDEnum, bool isFemale)
	{
		return null;
	}

	public List<AvatarEditorItemData> GetAvatarEditorAvatarItems(EAvatarFirstTab tabIDEnum)
	{
		return null;
	}

	public List<AvatarEditorItemData> GetAvatarEditorPetClothesItems(uint petID)
	{
		return null;
	}

	public List<AvatarEditorItemData> GetAvatarEditorPetEmoteItems(uint petID)
	{
		return null;
	}

	public List<AvatarEditorItemData> GetAvatarEditorAnimationStateItems(int avatarType, int subAnimationType = -1)
	{
		return null;
	}

	public List<AvatarEditorItemData> GetAvatarEditorEmoteItems(int avatarType)
	{
		return null;
	}

	public List<WorkshopNPCRigName> GetAvatarEditorRigNames()
	{
		return null;
	}

	public AvatarEditorItemData LookupAvatarEditorItem(uint FFItemID)
	{
		return null;
	}

	public AvatarEditorItemData GetAvatarEditorNullItem()
	{
		return null;
	}

	public AvatarEditorItemData GetAvatarEditorItemByWeaponID(uint nWeaponID)
	{
		return null;
	}

	private FCAJEKECGME GetNoneSkin()
	{
		return null;
	}

	private FCAJEKECGME _003CGetTextureListFromExplorer_003Eb__16_0(UGCAssetMetadata md)
	{
		return null;
	}

	private FCAJEKECGME _003CGetSoundListFromExplorer_003Eb__20_0(UGCAssetMetadata md)
	{
		return null;
	}

	private FCAJEKECGME _003CGetHudListFromExplorer_003Eb__22_0(UGCAssetMetadata md)
	{
		return null;
	}
}
