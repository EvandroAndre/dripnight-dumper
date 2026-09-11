using System.Collections.Generic;
using GCommon;
using proto;
using tcp;

namespace COW;

public class UIModelVirtualBrand : UIBaseModel, IUIModelDataChangeObserver
{
	public enum BrandSetState
	{
		Error,
		Normal_UnPurchaseable,
		Normal_Purchaseable,
		Owned,
		Warmup,
		New_UnPurchaseable,
		New_Purchaseable
	}

	private sealed class _003C_003Ec__DisplayClass107_0
	{
		public uint conditionID;

		public VirtualBrandInfo vbInfo;

		public UIModelVirtualBrand _003C_003E4__this;

		internal bool _003CRequestVirtualBrandReward_003Eb__1(uint value)
		{
			return false;
		}

		internal void _003CRequestVirtualBrandReward_003Eb__0(HttpErrorCode err, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass53_0
	{
		public ConditionNode curNode;

		internal bool _003CCheckIsAbleToClaimeAward_003Eb__0(uint value)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass54_0
	{
		public ConditionNode conditionNode;

		internal bool _003CGetCurConditionNodeByBrandId_003Eb__0(uint conditionId)
		{
			return false;
		}
	}

	private CSGetVirtualBrandDescRes m_virtualBrandDesc;

	private CSGetVirtualBrandInfoRes m_virtualBrandInfo;

	public const string VIRTUAL_BRAND_KEY_SET_CNT_IN_SINGLE_BRAND = "VIRTUAL_BRAND_KEY_CLOTH_CNT_IN_SINGLE_BRAND_{0}_{1}";

	public const string VIRTUAL_BRAND_KEY_BRAND_TAB_ITEM_CNT = "VIRTUAL_BRAND_KEY_BRAND_TAB_ITEM_CNT_{0}_{1}_{2}";

	private const uint DESC_READY = 1u;

	private const uint INFO_READY = 2u;

	private BitArrayBoolean m_CurReadyFlag;

	private Dictionary<uint, VirtualBrandBannerData> m_dicBannerCfg;

	private Dictionary<uint, VirtualBrandGainData> m_dicGainCfg;

	private Dictionary<uint, VirtualBrandLogoTouch> m_dicLogoTouch;

	private Dictionary<uint, VirtualBrandLogoDesc> m_dicLogoDesc;

	private Dictionary<uint, HashSet<uint>> m_dicBrandContainConditionIDs;

	private Dictionary<uint, VirtualBrandCollectionValueRewardDesc> m_dicCollectionValueRewardDesc;

	private Dictionary<uint, HashSet<uint>> m_dicTabClothIDs;

	private Dictionary<uint, VirtualBrandClothesDesc> m_dicClothDesc;

	private Dictionary<uint, VirtualBrandCollectionValueDesc> m_dicCollectionValueDesc;

	private Dictionary<uint, HashSet<uint>> m_dicSetContainItemIDs;

	private Dictionary<uint, VirtualBrandStoryDesc> m_dicStoryDesc;

	private Dictionary<uint, VirtualBrandInfo> m_dicVirtualBrandInfo;

	private List<uint> m_listSortedBrandID;

	private Dictionary<uint, List<ConditionNode>> m_dicSortedBrandContainConditionIDs;

	private Dictionary<uint, List<uint>> m_dicTabSortedSetID;

	private Dictionary<uint, uint> m_DicSetCollectionValue;

	private readonly Dictionary<uint, VirtualBrandTagDesc> m_DicBrandTagDesc;

	private Dictionary<uint, List<uint>> m_dicBrandSortedTabs;

	private Dictionary<uint, uint> m_dicBrandCachedCollectionValue;

	private Dictionary<uint, uint> m_dicSetCurrentState;

	private readonly Dictionary<uint, List<string>> m_dicBrandResNameList;

	public const uint PropID_Desc_Update = 2u;

	public const uint PropID_Info_Update = 4u;

	public const uint PropID_Get_Condition_Reward = 8u;

	public override void Login(object[] data)
	{
	}

	public uint GetVirtualBrandIDByBundleID(uint bundleID)
	{
		return 0u;
	}

	public uint GetVirtualtBrandBrandIdBySetID(uint setID)
	{
		return 0u;
	}

	public void UpdateVirtualBrandCollectionInfo(List<VirtualBrandTCP> virtualBrandTCPs)
	{
	}

	private void UpdateCachedCollectionValue(bool force)
	{
	}

	public void ManualUpdateCachedCollectionValue(uint brand, uint increasement)
	{
	}

	private uint GetOriginalCollectionValueByBrand(uint brandID)
	{
		return 0u;
	}

	private uint GetCurrentCollectionValueByBrand(uint brandID)
	{
		return 0u;
	}

	public bool IsCollectionValueChangeByBrand(uint brandID, out uint originalValue, out uint currentValue, bool updateAfterRead)
	{
		originalValue = default(uint);
		currentValue = default(uint);
		return false;
	}

	public bool IsCollectionValueItem(uint itemID, out uint brandID, out uint collectionValue)
	{
		brandID = default(uint);
		collectionValue = default(uint);
		return false;
	}

	public uint CalculateTabKey(uint brandID, BrandShowCaseTabType tab)
	{
		return 0u;
	}

	public uint GetTabTypeByItemID(uint itemID)
	{
		return 0u;
	}

	public List<uint> GetSortedTabsByBrand(uint brandID)
	{
		return null;
	}

	public List<uint> GetAllBundleIdsByBrandId(uint brandId)
	{
		return null;
	}

	public string GetVirtualBrandBannerIntroduceByBrandId(uint brandID)
	{
		return null;
	}

	public bool IsDescAndInfoReady()
	{
		return false;
	}

	public List<uint> GetSortedBrandIDs()
	{
		return null;
	}

	public VirtualBrandBannerData GetBannerDataByBrandID(uint brandID)
	{
		return null;
	}

	public VirtualBrandLogoTouch GetEntranceDataByBrandID(uint brandID)
	{
		return null;
	}

	public VirtualBrandGainData GetGainDataByBrandID(uint brandID)
	{
		return null;
	}

	public List<ConditionNode> GetSortedConditionInfoByBrandID(uint brandID)
	{
		return null;
	}

	public bool CheckIsAbleToClaimeAward(uint brandID)
	{
		return false;
	}

	public ConditionNode GetCurConditionNodeByBrandId(uint brandID)
	{
		return null;
	}

	public ConditionNode GetPrevConditionNode(ConditionNode conditionNode)
	{
		return null;
	}

	public VirtualBrandCollectionValueRewardDesc GetPrevConditionInfoByConditionNode(ConditionNode conditionNode)
	{
		return null;
	}

	public List<uint> GetSortedSetIDByBrandTab(uint brandID, BrandShowCaseTabType tab)
	{
		return null;
	}

	public int GetSetOwnerCountBySetID(uint setID)
	{
		return 0;
	}

	public uint GetCollectionValueBySetId(uint setId)
	{
		return 0u;
	}

	public bool IsNewVirtualBrandLogoBrand(uint brandID)
	{
		return false;
	}

	public bool GetSetOwnerBySetID(uint setID)
	{
		return false;
	}

	private uint[] GetSetItemsBySetID(uint setID)
	{
		return null;
	}

	public VirtualBrandInfo GetVirtualBrandInfoByBrandID(uint id)
	{
		return null;
	}

	public string GetVirtualBrandTagSpriteNameByBrandId(uint id)
	{
		return null;
	}

	public VirtualBrandLogoDesc GetVirtualBrandLogoDescByBrandID(uint id)
	{
		return null;
	}

	public VirtualBrandCollectionValueRewardDesc GetVirtualBrandConditionInfoByConditionID(uint id)
	{
		return null;
	}

	public VirtualBrandClothesDesc GetVirtualBrandClothDescBySetID(uint id)
	{
		return null;
	}

	public uint GetBundleIDBySetID(uint setID)
	{
		return 0u;
	}

	public VirtualBrandStoryDesc GetVirtualBrandStoreByBrandID(uint id)
	{
		return null;
	}

	public bool IsItemBelongsVirtualBrand(uint itemID)
	{
		return false;
	}

	public uint GetVirtualtBrandBrandIdByItemID(uint itemID)
	{
		return 0u;
	}

	public bool IsWarmUpVirtualBrandLogo(uint brandID)
	{
		return false;
	}

	public bool IsWarmUpVirtualBrandLogo(VirtualBrandLogoDesc desc)
	{
		return false;
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Init()
	{
	}

	protected override void OnCleanup()
	{
	}

	public GoPos GetVirtualBrandGoPosByBundleID(uint bundleId)
	{
		return null;
	}

	private bool IsWarmUpVirtualBrandClothes(uint setID)
	{
		return false;
	}

	private bool IsNewVirtualBrandClothes(uint setID)
	{
		return false;
	}

	private bool IsPurchaseableVirtualBrandClothes(uint setID)
	{
		return false;
	}

	public uint GetSetStateBySetID(uint setID, bool forceUpdate = false)
	{
		return 0u;
	}

	private void UpdateSetState(HashSet<uint> hs)
	{
	}

	private uint UpdateBrandSetState(uint setID)
	{
		return 0u;
	}

	private bool IsHasItemChannelInfoBySetId(uint setID)
	{
		return false;
	}

	private int CompareVBSetID(uint curID, uint nextID)
	{
		return 0;
	}

	private int CompareCondition(uint curID, uint nextID)
	{
		return 0;
	}

	private int CompareBrandID(uint curID, uint nextID)
	{
		return 0;
	}

	private void InitInfo()
	{
	}

	private void InitDesc()
	{
	}

	private void InitAndSortConditionID()
	{
	}

	private void InitAndSortSetID()
	{
	}

	private void InitAndSortBrandID()
	{
	}

	private void InitCfg()
	{
	}

	public uint GetNextAvailableBrandID(bool next, uint brandID)
	{
		return 0u;
	}

	private int GetNextIDIndex(bool next, int cur)
	{
		return 0;
	}

	private void UpdateLabEntranceRedDot()
	{
	}

	public bool IsVirtualBrandNeedRedDot()
	{
		return false;
	}

	public bool IsBrandNeedRedDot(uint brandID)
	{
		return false;
	}

	public uint GetVirtualBrandSetCnt(uint brandID)
	{
		return 0u;
	}

	public void SetVirtualBrandSetCntKey(uint brandID, uint count)
	{
	}

	public bool IsVirtualBrandNewSetExistInBrand(uint brandID)
	{
		return false;
	}

	public void ReSortSetId()
	{
	}

	public void SetBrandTabReaded(uint brandID, BrandShowCaseTabType tab)
	{
	}

	public uint GetTabSetCnt(uint brandID, BrandShowCaseTabType tab)
	{
		return 0u;
	}

	public void RequestVirtualBrandDesc(LoadingType loadingType = LoadingType.CircleLoading, uint httpOption = 0u, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void RequestVirtualBrandInfo(LoadingType loadingType = LoadingType.CircleLoading, uint httpOption = 0u, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void RequestVirtualBrandReward(uint brandID, uint conditionID, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	public override void Logout(object[] data)
	{
	}

	public uint GetBrandAbTag(uint brandID)
	{
		return 0u;
	}

	public bool IsBrandAbReady(uint brandID)
	{
		return false;
	}

	public void DownloadAllBrandAb(bool skipWarmUp = true)
	{
	}

	public void GetAllClothesResByBrand(uint brandID, List<ResourceID> optionalRes)
	{
	}

	private List<ResourceID> GetResNeedUnload(uint brandID)
	{
		return null;
	}

	private void ClearResByAbTag(uint tag)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void _003CRequestVirtualBrandDesc_003Eb__105_0(HttpErrorCode err, object res)
	{
	}

	private void _003CRequestVirtualBrandInfo_003Eb__106_0(HttpErrorCode err, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_OnCleanup()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
