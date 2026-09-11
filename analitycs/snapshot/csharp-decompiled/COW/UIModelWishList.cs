using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIModelWishList : UIBaseModel
{
	public class WishListItemChangeInfo
	{
		public int timeStamp;

		public string source;
	}

	private sealed class _003C_003Ec__DisplayClass134_0
	{
		public UIModelWishList _003C_003E4__this;

		public ulong account_id;

		internal void _003CRequestAccountOutFit_003Eb__0(HttpErrorCode errorCode, object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass135_0
	{
		public UIModelWishList _003C_003E4__this;

		public CSChangeWishListItemReq req;

		internal void _003CRefreshWishListToBackend_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass135_1
	{
		public KeyValuePair<uint, WishListItemChangeInfo> keyValue;

		internal bool _003CRefreshWishListToBackend_003Eb__1(WishListItem o)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass135_2
	{
		public KeyValuePair<uint, WishListItemChangeInfo> keyValuePair;

		internal bool _003CRefreshWishListToBackend_003Eb__2(WishListItem o)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass72_0
	{
		public CSGetItemsWishCntsReq req;

		public UIModelWishList _003C_003E4__this;

		internal void _003CRequestWishNumInternal_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass81_0
	{
		public UIModelWishList _003C_003E4__this;

		public ulong accoundId;

		internal void _003CRequestWishListItemData_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass85_0
	{
		public UIModelWishList _003C_003E4__this;

		public uint baseLevelItemId;

		internal bool _003CCheckNotBundleOneItemExistInLocalUserWishList_003Eb__0(WishListItem o)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass87_0
	{
		public CSSharedItemData itemdata;

		internal bool _003CCheckBundleExistInLocalUserWishList_003Eb__0(WishListItem o)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass90_0
	{
		public UIModelWishList _003C_003E4__this;

		public uint baseLevelItemId;

		internal bool _003CCheckItemIsExistInWishList_003Eb__0(WishListItem o)
		{
			return false;
		}
	}

	private const string PlayerObtainTag = "PlayerObtain";

	public const uint PropID_WishListItemReady = 1u;

	public const uint PropID_WishListChange = 2u;

	public const uint PropID_GetAccountOutfit = 4u;

	public const uint PropID_InventoryNewItemsNtf = 8u;

	public const uint PropID_WishNumReady = 16u;

	public const uint PropID_WishListLeaderboardReady = 32u;

	private const string GetWishListLeaderboardCmd = "GetWishListLeaderboard";

	private const float WishListLeaderboardRequestCDTime = 30f;

	private const bool UseWishListLeaderboardTestData = false;

	private static readonly uint[] WishListLeaderboardTestItemIds;

	private Dictionary<ulong, List<WishListItem>> m_WishListItemListDic;

	private Dictionary<uint, uint> m_ItemIdToBaseLevelItemIdCache;

	private Dictionary<ulong, uint> m_WishListReuqestTimeStampDic;

	private WishSettingDesc m_wishSettingDesc;

	private Dictionary<ulong, List<uint>> m_WishListBriefDict;

	private Dictionary<ulong, ulong> m_WishListBriefCoolDownDict;

	private HashSet<uint> m_HotItemSet;

	private Dictionary<WishListLeaderboardPeriod, List<WishListLeaderboardItem>> m_WishListLeaderboardItems;

	private HashSet<uint> m_WishListLeaderboardHotItems;

	private bool m_IsRequestingWishListLeaderboard;

	private bool m_HasRequestedWishListLeaderboard;

	private float m_WishListLeaderboardLastRequestTime;

	public Dictionary<int, string> m_DicBriefShowInfo;

	public Dictionary<int, string> m_HudDicBriefShowInfo;

	public Dictionary<int, uint> m_DicDefultBriefShowInfo;

	public const string FIRSTADDWISHLISTTIPKEY = "FirstAddWishListTip_Key";

	public const string FIRSTBRIEFBOXOPENKEY = "FirstBriefBoxIOpenTip_Key";

	private bool m_IsFirstWishListClick;

	private bool m_HasGetFirstWishListClickKey;

	private bool m_IsFirstBriefBoxOpen;

	private bool m_HasGetFirstBriefBoxOpenKey;

	private bool m_IsFirstAddWishListAfterLogin;

	private UIModelMall m_ModelMall;

	private UIModelUser m_ModelUser;

	private UIModelInventory m_ModelInventory;

	private UIModelWeaponSkinUpgrader m_ModelWeaponSkinUpgrader;

	private UIModelGroup m_ModelGroup;

	private UIModelNewVault m_ModelNewVault;

	private Dictionary<string, LanguageNumberData> m_LanguageNumberDataDic;

	private Dictionary<uint, uint> m_WishNumDic;

	private List<uint> m_NeedRequestWishNumIds;

	private List<uint> m_AlreadyWishNumIds;

	private uint[] m_ItemIdArrayTmp;

	private HashSet<uint> m_IsRequestingWishValueIdSet;

	private const uint GetItemsWishCntsMaxCnt = 50u;

	private HashSet<ulong> AleadySendAccountId;

	private Dictionary<uint, WishListItemChangeInfo> AddWishListBackendItemCache;

	private Dictionary<uint, WishListItemChangeInfo> DeleteWishItemBackendItemCache;

	private List<CSSharedItemData> m_NeedDeleteWishItems;

	public bool IsFirstAddWishListAfterLogin
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public List<WishListItem> LocalUserWishListItemList => null;

	private UIModelMall ModelMall => null;

	private UIModelUser ModelUser => null;

	private UIModelInventory ModelInventory => null;

	private UIModelWeaponSkinUpgrader ModelWeaponSkinUpgrader => null;

	private UIModelGroup ModelGroup => null;

	private UIModelNewVault ModelNewVault => null;

	public uint WishListItemsNumLimit => 0u;

	public uint WishListEndTimeLimit => 0u;

	private Dictionary<string, LanguageNumberData> LanguageNumberDataDic => null;

	public void RequestWishValue(uint itemId)
	{
	}

	public void RequestWishNum(uint[] itemIds)
	{
	}

	private void BatchRequestWishNumCache()
	{
	}

	private void RequestWishNumInternal(uint[] itemIds)
	{
	}

	public bool CheckIsHasWishNumById(uint itemId)
	{
		return false;
	}

	public uint GetWishNum(uint itemId)
	{
		return 0u;
	}

	public LanguageNumberData GetLanguageNumberData(LocLang lang)
	{
		return null;
	}

	public uint RefreshWishNumView(uint itemId, UILabel wishNum, GameObject hotGo, bool needSimplify = true)
	{
		return 0u;
	}

	public string GetLanguageNumberStrByNum(uint num, bool needSimplify = true)
	{
		return null;
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public List<WishListItem> GetWishListByAccoundId(ulong accountId)
	{
		return null;
	}

	public void RequestWishListItemData(ulong accoundId, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public int GetLocalUserWishListCount()
	{
		return 0;
	}

	public List<WishListItem> GetWishListByAccountId(ulong accountId)
	{
		return null;
	}

	public ItemStateInWishList CheckOneItemExistInLocalUserWishList(CSSharedItemData itemdata)
	{
		return ItemStateInWishList.None;
	}

	private ItemStateInWishList CheckNotBundleOneItemExistInLocalUserWishList(CSSharedItemData itemdata)
	{
		return ItemStateInWishList.None;
	}

	private bool CheckOwnedBaseLevelItem(CSSharedItemData itemdata)
	{
		return false;
	}

	private ItemStateInWishList CheckBundleExistInLocalUserWishList(CSSharedItemData itemdata)
	{
		return ItemStateInWishList.None;
	}

	private bool IsBundlingTypeItem(CSSharedItemData itemdata)
	{
		return false;
	}

	public ItemStateInWishList CheckOneItemExistInLocalUserWishList(uint itemId)
	{
		return ItemStateInWishList.None;
	}

	private WishListItem CheckItemIsExistInWishList(CSSharedItemData itemData)
	{
		return null;
	}

	public bool CheckCanAddToWishList(CSSharedItemData itemdata)
	{
		return false;
	}

	private bool CheckBundleCanAddToWishList(CSSharedItemData itemdata)
	{
		return false;
	}

	public uint GetBaseLevelItemIdByItemData(uint itemId)
	{
		return 0u;
	}

	public uint GetBaseLevelItemIdByItemData(CSSharedItemData itemdata)
	{
		return 0u;
	}

	public AddItemToWishListReturnState AddItemToWishListLocalCache(uint itemId, string source)
	{
		return AddItemToWishListReturnState.AddError;
	}

	public DeleteItemToWishListReturnState DeleteItemToWishListLocalCache(uint itemId, string source)
	{
		return DeleteItemToWishListReturnState.DeleteError;
	}

	public DeleteItemToWishListReturnState DeleteItemToWishListLocalCache(CSSharedItemData itemdata, string source)
	{
		return DeleteItemToWishListReturnState.DeleteError;
	}

	private HashSet<uint> UnBoxedBundleOrBoxToList(CSSharedItemData itemData)
	{
		return null;
	}

	private uint IsContainItemIdConsiderDerivedItems(Dictionary<uint, WishListItemChangeInfo> dic, uint itemId)
	{
		return 0u;
	}

	private uint IsContainItemIdConsiderDerivedItems(Dictionary<uint, WishListItemChangeInfo> dic, CSSharedItemData itemData)
	{
		return 0u;
	}

	public string RequestBGIconInfo(int Type)
	{
		return null;
	}

	public string GetHudItemIconName(int Type)
	{
		return null;
	}

	public uint GetDefaultItemIDByPreviewType(int Type)
	{
		return 0u;
	}

	public List<uint> GetWishListBriefByAccountID(ulong Id)
	{
		return null;
	}

	public void AddWishListBriefByAccountID(ulong id, CSGetAccountOutfitRes Data)
	{
	}

	public bool ShowFirstWishListNodeClickPopWnd(string tips)
	{
		return false;
	}

	public void OnInventoryNewItemsNtf(InventoryChangeMessage message)
	{
	}

	public void UpdateBundelStateInWishList()
	{
	}

	public override void Logout(object[] data)
	{
	}

	public void InitWishListSetting(LoginDescRes loginDescRes)
	{
	}

	public bool IsWishListOpen()
	{
		return false;
	}

	public bool IsWishListValueOpen()
	{
		return false;
	}

	public bool IsWishListRankingOpen()
	{
		return false;
	}

	public uint GetWishListRankingNumber()
	{
		return 0u;
	}

	public bool IsWishListLeaderboardHotItem(uint itemId)
	{
		return false;
	}

	public List<WishListLeaderboardItem> GetWishListLeaderboardItems(WishListLeaderboardPeriod period)
	{
		return null;
	}

	public void RequestWishListLeaderboard(bool force = false)
	{
	}

	private bool IsWishListLeaderboardRequestInCD()
	{
		return false;
	}

	public void RefreshWishListLeaderboardChannelInfo()
	{
	}

	private void TryRequestWishListLeaderboardForHotItem()
	{
	}

	private void SetWishListLeaderboardData(CSGetWishListLeaderboardRes data)
	{
	}

	private CSGetWishListLeaderboardRes CreateWishListLeaderboardTestData()
	{
		return null;
	}

	private void AddWishListLeaderboardTestItems(List<CSWishListLeaderboardItem> result, uint baseChangeCnt, bool reverse)
	{
	}

	private void SetWishListLeaderboardData(WishListLeaderboardPeriod period, List<CSWishListLeaderboardItem> data)
	{
	}

	private void RequestWishListLeaderboardChannelInfo()
	{
	}

	private void RefreshWishListLeaderboardObtainState(List<WishListLeaderboardItem> items)
	{
	}

	private void RefreshWishListLeaderboardObtainState(WishListLeaderboardItem item)
	{
	}

	private void ClearWishListLeaderboardData()
	{
	}

	public bool IsShowRemoveCountDown(long end_timestamp)
	{
		return false;
	}

	public void RequestAccountOutFit(ulong account_id = 0uL, bool silence = false)
	{
	}

	public void RefreshWishListToBackend()
	{
	}

	public void NavigateToWishList(UINavigationUtil.UINavigationFrom from = UINavigationUtil.UINavigationFrom.None)
	{
	}

	private void _003CRequestWishListLeaderboard_003Eb__121_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
