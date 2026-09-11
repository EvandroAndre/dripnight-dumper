using System;
using System.Collections.Generic;
using GCommon;
using message;

namespace COW.Gameplay.UGC;

public class SceneEditResourceShopManager
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<CSVBaseData, int> _003C_003E9__13_0;

		public static Action _003C_003E9__74_1;

		internal int _003Cget_SubTypeDictionary_003Eb__13_0(CSVBaseData item)
		{
			return 0;
		}

		internal void _003CDownloadResourceBytes_003Eb__74_1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass74_0
	{
		public UGCResourceShopMetaData metaData;

		public SceneEditResourceShopManager _003C_003E4__this;

		internal void _003CDownloadResourceBytes_003Eb__0()
		{
		}
	}

	public readonly string LoadingReason;

	public readonly int LoadingDepth;

	private const int UPLOAD_DAILY_LIMIT_ERROR_CODE = 2031;

	private const int UPLOAD_LOCK_ERROR_CODE = 2036;

	public Dictionary<ulong, UGCResourceShopMetaData> ShopDictionary;

	public Dictionary<ulong, UGCResourceShopMetaData> UploadDictionary;

	public Dictionary<string, ResourceShopRecommendationData> RecommendationDictionary;

	public List<ulong> OwnedList;

	public Dictionary<ulong, ShopAuthorInfo> AuthorInfoDictionary;

	public HashSet<ulong> LikeHashSet;

	private Dictionary<int, List<UGCAssetsStoreType>> m_SubTypeDictionary;

	private List<ResourceShopRecommendationData> m_RecommendationList;

	private Dictionary<int, UGCRSP_UploadData> UploadingDictionary;

	private Dictionary<ulong, byte[]> UploadingDataDictionary;

	public Dictionary<int, ShopStatusData> ShopStatusConfig;

	private UIModelSceneEdit m_ModelSceneEdit;

	public UGCRSP_PersonalLimitResInner PersonalLimit;

	public Dictionary<int, List<UGCAssetsStoreType>> SubTypeDictionary => null;

	public bool IsUploading(ulong resourceId)
	{
		return false;
	}

	public static string GetRecommendationKey(uint typeId, uint eventId)
	{
		return null;
	}

	public List<ResourceShopRecommendationData> GetRecommendationList()
	{
		return null;
	}

	public ResourceShopRecommendationData GetRecommendationData(uint typeId, uint eventId)
	{
		return null;
	}

	private ulong GetUploadUnlockTime()
	{
		return 0uL;
	}

	public bool IsUploadLocked()
	{
		return false;
	}

	public bool TryShowUploadBanToast()
	{
		return false;
	}

	private void ShowUploadBanToast(ulong uploadUnlockTime)
	{
	}

	public int GetUploadTaskId(ulong resourceId)
	{
		return 0;
	}

	public void HandleResourceStoreNickNameResponse(object res)
	{
	}

	public void HandleResourceStoreNotify(UGCRSP_Notify data)
	{
	}

	public void HandleResourceStoreResponse(object resObj, object reqObj, object[] extra)
	{
	}

	public void RequestUploadTemplate(KCJDEKIJAKH data, string name, string desc, int bPublic, int editState, int mainCategory, int subCategory, string path, Action callback)
	{
	}

	private void HandleUploadUrlRes(UGCRSP_UploadRes res, object[] extra)
	{
	}

	private void RequestUploadSuccess(int taskId)
	{
	}

	private void HandleUploadSuccessRes(UGCRSP_UploadSuccessRes res)
	{
	}

	private void RequestUploadFailure(int taskId)
	{
	}

	public void RequestDetail(string code, Action callback)
	{
	}

	private void HandleDetailRes(UGCRSP_DetailRes res, object[] extra)
	{
	}

	public void RequestUploadDetail(ulong resourceId)
	{
	}

	private void HandleUploadDetailRes(UGCRSP_DetailRes res)
	{
	}

	public void RequestUploadList()
	{
	}

	private void HandleUploadListRes(UGCRSP_ResourceListRes res)
	{
	}

	public void RequestLikeList()
	{
	}

	private void HandleLikeListRes(UGCRSP_LikeListRes res)
	{
	}

	public void RequestLikeOrCancel(ulong resourceId, bool bLike)
	{
	}

	private void HandleLikeRes(UGCRSP_OptionRes res, object reqObj)
	{
	}

	private void HandleCancelLikeRes(UGCRSP_OptionRes res, object reqObj)
	{
	}

	public void RequestSearch3D(int page, int size, string searchKey)
	{
	}

	private void HandleSearch3DRes(UGCRSP_ResourceListRes res)
	{
	}

	private void RequestPersonalLimit()
	{
	}

	private void HandlePersonalLimitRes(UGCRSP_PersonalLimitRes res, object reqObj)
	{
	}

	private void RequestRecommendedMenu()
	{
	}

	private void HandleRecommendedMenuRes(UGCRSP_RecommendedMenuRes res)
	{
	}

	private void RequestRecommendedList(uint typeId, uint eventId)
	{
	}

	private void HandleRecommendedListRes(UGCRSP_RecommendedListRes res, object reqObj)
	{
	}

	public void RequestOwnedList()
	{
	}

	private void HandleOwnedListRes(UGCRSP_ResourceListRes res)
	{
	}

	public void RequestShopList(int page, int size, int mainCategory, int subCategory, string sortValue, string searchValue)
	{
	}

	private void HandleShopListRes(UGCRSP_ResourceListRes res, object req)
	{
	}

	private UGCResourceShopMetaData BuildMetaData(UGCRSP_ResourceData resourceData)
	{
		return null;
	}

	public void RequestUploadOffline(ulong resourceId)
	{
	}

	private void HandleUploadOfflineRes(UGCRSP_OptionRes res, object reqObj)
	{
	}

	public void RequestUploadDelete(ulong resourceId)
	{
	}

	private void HandleUploadDeleteRes(UGCRSP_OptionRes res, object reqObj)
	{
	}

	public void RequestBuy(ulong resourceId, string code)
	{
	}

	private void HandleBuyRes(UGCRSP_BuyRes res, object reqObj)
	{
	}

	public void RequestCancelBuy(ulong resourceId)
	{
	}

	private void HandleCancelBuyRes(UGCRSP_BuyRes res, object reqObj)
	{
	}

	public void RequestSearchResourceCode(string code)
	{
	}

	private void HandleSearchResourceCode(UGCRSP_SearchRes res)
	{
	}

	public ShopStatusData GetShopStatusConfig(ulong resourceId)
	{
		return null;
	}

	public void OpenLoadingUI()
	{
	}

	public void CloseLoadingUI()
	{
	}

	public void DownloadResourceBytes(UGCResourceShopMetaData metaData)
	{
	}

	private void LoadStoreAssets(UGCResourceShopMetaData metaData)
	{
	}

	public void LoadCreatedAsset(string assetId, IHDACHNBFNG resourceType)
	{
	}

	private bool TryGetCreatedAssetMeta(UGCAssetExplorer explorer, string assetId, IHDACHNBFNG resourceType, out UGCAssetMetadata metadata)
	{
		metadata = null;
		return false;
	}

	public bool GotoExplorer(UGCResourceShopMetaData metaData)
	{
		return false;
	}

	public bool OpenResourceShopDetail(ulong resourceId, EUGCResourceShopTab mainTab, string searchValue = "", int mainCategory = 0, int subCategory = 0, int index = 0, bool bAISearch = false)
	{
		return false;
	}
}
