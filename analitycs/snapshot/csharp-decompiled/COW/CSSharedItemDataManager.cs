using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class CSSharedItemDataManager : SingletonModule<CSSharedItemDataManager>
{
	public enum ItemType
	{
		ITEMTYPENONE = 0,
		Avatar = 1,
		Clothes = 2,
		LimitedCard = 3,
		TreasureBox = 4,
		Props = 5,
		RoomCard = 6,
		Bundle = 7,
		Debris = 8,
		Collection = 9,
		VirtualGoods = 10,
		BonusCard = 11,
		WeaponSkin = 12,
		Pet = 13,
		BattleFlag = 14,
		ElitePassDebris = 15,
		RelationItem = 16,
		OptionalBundle = 17,
		HyperBook = 18,
		ClothEffect = 19,
		BooyahPassExp = 20,
		HippoCrisisItem = 21,
		HippoCrisisMoney = 22,
		SparkPet = 24,
		ItemHide = 99
	}

	public enum CollectionSubType
	{
		NOTCOLLECTION,
		Banner,
		HeadPic,
		LootBox,
		BackPack,
		Parachute,
		Skyboard,
		Weapon,
		VehicleSkin,
		Emote,
		Pin,
		Flight,
		GroupAnim,
		Music,
		Transformer,
		HyperBook,
		Title,
		ActionJump,
		ActionUseMedkit,
		ActionCrossWindow,
		ActionFallingHigh,
		QuickMessage,
		SkillEffect,
		FinalShot,
		SuperEmote,
		LoadingCard,
		PhotoFrame,
		AvatarFrame,
		PhotoGroupTemplate,
		PhotoSticker,
		FinishMove,
		Max
	}

	public enum CharacterSubType
	{
		NONE,
		Avatar,
		AvatarBundle,
		AvatarDebirs,
		AvatarUpgradeCard,
		AvatarBox
	}

	public enum StoreQuality
	{
		StoreQuality_NONE = 0,
		StoreQuality_WHITE = 1,
		StoreQuality_GREEN = 2,
		StoreQuality_BLUE = 3,
		StoreQuality_PURPLE = 4,
		StoreQuality_ORANGE = 5,
		StoreQuality_Red = 7,
		StoreQuality_PURPLE_PLUS = 8,
		StoreQuality_ORANGE_PLUS = 9,
		Capacity = 10
	}

	public enum PetSubType
	{
		PetSubType_NONE,
		PetSubType_PET_AND_FOOD,
		PetSubType_PET_ANIM,
		PetSubType_PET_SKIN,
		PetSubType_PET_CHEST,
		PetSubType_PET_BOX
	}

	public enum ItemSubType
	{
		ItemSubType_NONE = 0,
		ItemSubType_GACHACOUPON = 2,
		ItemSubType_ELITEPASS = 3,
		ItemSubType_VOUCHER = 4,
		ItemSubType_RENAMECARD = 5,
		ItemSubType_REDENVELOPE = 6,
		ItemSubType_PETFOOD = 7,
		ItemSubType_FORGECURRENCY = 8,
		ItemSubType_PETANIM = 9,
		ItemSubType_PETSKIN = 10,
		ItemSubType_REVIVETOKEN = 11,
		ItemSubType_CHARACTER_PROFILE_UPGRADE_CARD = 12,
		ItemSubType_CHIP = 13,
		ItemSubType_PetSkill = 15,
		ItemSubType_CrateBox = 16,
		ItemSubType_UNIVERSALDEBRIS = 17,
		ItemSubType_GACHACOUPON_LIMIT = 19,
		ItemSubType_EVENTITEMFORHISTORY = 20,
		ItemSubType_FLASH_GEM = 29,
		ItemSubType_RANK_NO_DEDUCT_CARD = 30,
		ItemSubType_RANK_TIMES_RP_CARD = 31,
		ItemSubType_LINK_AVATAR_LIMITED_CARD = 32,
		ItemSubType_SKILL_MAX_LEVEL_CARD = 33,
		ItemSubType_CS_KEEP_SCORE_CARD = 34,
		ItemSubType_CLOTHEFFECTSUBTYPE_EVENTTRIGGEREFFECT = 36,
		ItemSubType_CLOTHEFFECTSUBTYPE_SPOTLIGHT = 37,
		ItemSubType_CLOTHEFFECTSUBTYPE_FOOTHALO = 38,
		ItemSubType_CLOTHEFFECTSUBTYPE_PERMANENTEFFECT = 39,
		ItemSubType_GACHA_EXCHANGE_TOKEN = 40,
		ItemSubType_LIMITED_CARD_BOOYAHPASS = 41,
		ItemSubType_LIMITED_CARD_ALLPET = 42,
		ItemSubType_LIMITED_CARD_ALLLOADOUT = 43,
		ItemSubType_PVE_REVIVE_TOKEN = 46,
		ItemSubType_PVE_ONE_TIME_BUFF = 47,
		ItemSubType_EvoGun_Token = 50,
		ItemSubType_HyperBook_Token = 51,
		ItemSubType_Tailor_Token = 52,
		ItemSubType_WORKSHOP_VIP_WEEKLY_CARD = 58,
		ItemSubType_WORKSHOP_VIP_MONTHLY_CARD = 59,
		ItemSubType_DRAWSHOP_GACHACOUPON_LIMIT = 66,
		ItemSubType_SOCIAL_LOBBY_9TH_RED_PACKET_GUN = 68,
		ItemSubType_SOCIAL_LOBBY_9TH_FUN_HAMMER = 69,
		ItemSubType_SOCIAL_LOBBY_9TH_SCALE_UP = 70,
		ItemSubType_SOCIAL_LOBBY_9TH_SCALE_DOWN = 71,
		ItemSubType_SOCIAL_LOBBY_9TH_DEFORM = 72,
		ItemSubType_SOCIAL_LOBBY_9TH_PARTY_FIREWORK = 73,
		ItemSubType_SOCIAL_LOBBY_9TH_FIREWORK = 74,
		ItemSubType_SOCIAL_LOBBY_9TH_DANCE_GRENADE = 75,
		ItemSubType_SOCIAL_LOBBY_9TH_FROZEN_GRENADE = 76,
		ItemSubType_SOCIAL_LOBBY_9TH_SKATEBOARD = 77,
		ItemSubType_SOCIAL_LOBBY_9TH_SLOT10 = 78,
		ItemSubType_SOCIAL_LOBBY_9TH_SLOT11 = 79
	}

	private const int CapacityItemData = 24000;

	private IntervalTreeDic<CSSharedItemData> m_dictIdToCSItemDataTree;

	private Dictionary<uint, CSSharedItemData> m_dictIdToCSItemData;

	private Dictionary<uint, CSSharedLikeItemData> m_dictIdToCSLikeItemData;

	private Dictionary<uint, string> m_dictIdToCSItemDataEndtime;

	private Dictionary<uint, byte> m_dictIdToCSItemDataSubType;

	private Dictionary<uint, ItemBigIconData> m_dictIdToItemBigIconData;

	private Dictionary<uint, DiscolorationCollectionData> m_dictIdToDiscolorationCollectionData;

	private Dictionary<uint, CSSharedLoadoutData> m_dictIdtoCSLoadoutData;

	private Dictionary<uint, LoadoutTagData> m_dictIdtoLoadoutTagData;

	private Dictionary<uint, BattleFlagConfigData> m_dictIdToBattleFlagConfigData;

	private Dictionary<uint, BattleFlagConfigData> m_dictLinkIdToBattleFlagConfigData;

	private List<CSSharedItemData> m_DefaultPVEWeapons;

	private List<ResourceID> m_resourceIDList;

	private Dictionary<ResourceID, ResourceID> m_IconInABDefaultIconDict;

	private Dictionary<ResourceID, ResourceID> m_dictIconResNoBloodAlt;

	private Dictionary<uint, string> m_iconResList_HasNoBloodAlt;

	private List<string> m_NoBloodIconResList;

	protected override void OnCleanup()
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

	private void LoadCSVItermData()
	{
	}

	public void SetCSItemDataEndtime(uint id, string endTime)
	{
	}

	public string GetCSItemDataEndtime(uint id)
	{
		return null;
	}

	public void SetCSItemDataSubType(uint id, byte subtype)
	{
	}

	public byte GetCSItemDataSubType(uint id)
	{
		return 0;
	}

	public bool IsLoadoutPlayCard(uint InId)
	{
		return false;
	}

	public uint GetCSLoadoutPlayCardIdById(uint InId)
	{
		return 0u;
	}

	public Dictionary<uint, CSSharedLoadoutData> GetLoadoutConfigDict()
	{
		return null;
	}

	public List<Item> GetLoadoutList()
	{
		return null;
	}

	public CSSharedLoadoutData GetCSLoadoutData(uint InId)
	{
		return null;
	}

	public bool IsCSLoadoutSold(uint InId)
	{
		return false;
	}

	public IEnumerable<CSSharedItemData> GetItemDict()
	{
		return null;
	}

	public CSSharedItemData FindCSSharedItemDataById(uint InId)
	{
		return null;
	}

	public Dictionary<uint, ItemBigIconData> GetAllItemBigIcon()
	{
		return null;
	}

	public Dictionary<uint, DiscolorationCollectionData> GetAllDiscolorData()
	{
		return null;
	}

	public DiscolorationCollectionData GetDiscolorDataByID(uint itemID)
	{
		return null;
	}

	public ResourceID GetItemBigIconById(uint ItemId)
	{
		return default(ResourceID);
	}

	public CSSharedLikeItemData FindCSSharedLikeItemDataById(uint InId)
	{
		return null;
	}

	public CSSharedItemData FindCSSharedItemDataByTypeAndId(EInventory.AwardType awardType, uint InId)
	{
		return null;
	}

	public CSSharedItemData FindCSSharedItemDataByBaseItemInfo(BaseItemInfo baseItemInfo)
	{
		return null;
	}

	public CSSharedItemData FindFirstTicket(IEnumerable<uint> idList)
	{
		return null;
	}

	public bool IsCSSharedItemSpriteNameContainsResId(uint InId)
	{
		return false;
	}

	public string FindCSSharedItemTypeSpriteNameById(uint InId)
	{
		return null;
	}

	public BattleFlagConfigData FindBattleFlagConfigDataByID(uint id)
	{
		return null;
	}

	public BattleFlagConfigData FindBattleFlagConfigDataByLinkID(uint id)
	{
		return null;
	}

	public static Color GetRareColor(uint rare)
	{
		return default(Color);
	}

	public static CollectionSubType GetCollectionSubTypeByID(uint iid)
	{
		return CollectionSubType.NOTCOLLECTION;
	}

	public static ItemType GetItemTypeByID(uint id)
	{
		return ItemType.ITEMTYPENONE;
	}

	public bool IsTheBundleItemsTimeSame(uint itemId, ref uint award_time)
	{
		return false;
	}

	public LoadoutTagData GetLoadoutTagData(uint InId)
	{
		return null;
	}

	public List<LoadoutTagData> GetAllLoadoutTagData()
	{
		return null;
	}

	public ResourceID GetIndiaNoBloodIconRes(ResourceID resID)
	{
		return default(ResourceID);
	}

	public ResourceID GetIconInAbDefaultIcon(ResourceID res)
	{
		return default(ResourceID);
	}

	public void SetIconInABDefaultIcon(CSSharedItemData data)
	{
	}
}
