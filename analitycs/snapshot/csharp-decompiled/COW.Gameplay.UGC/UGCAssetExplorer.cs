using System.Collections.Generic;
using UnityEngine;
using message;

namespace COW.Gameplay.UGC;

public sealed class UGCAssetExplorer
{
	private sealed class _003C_003Ec__DisplayClass38_0
	{
		public UGCAssetExplorer _003C_003E4__this;

		public UGCPreview preview;

		internal void _003CGeneratePreviewData_003Eb__0(bool succ, UGCMesh resObj)
		{
		}

		internal void _003CGeneratePreviewData_003Eb__1(bool succ, UGCTexture resObj)
		{
		}
	}

	private readonly Dictionary<string, UGCAssetMetadata> _assetIndex;

	private readonly Dictionary<int, UGCAssetProviderBase> _providerIdToProvider;

	private readonly Dictionary<string, UGCPreview> _previewCache;

	private readonly List<UGCAssetProviderBase> _providers;

	private long _maxPreviewCacheMemoryBytes;

	private long _previewCacheMemoryThresholdBytes;

	private float _memoryCleanupInterval;

	public int _MaxTextureSize;

	private UGCPreviewOptions _previewOptions;

	private long _currentPreviewCacheMemoryBytes;

	private float _lastMemoryCleanupTime;

	private readonly List<KeyValuePair<string, long>> _previewMemoryUsage;

	private Dictionary<int, string> _assetTypeIconResNameMaps;

	private static string _defaultIconResName;

	public static string DefaultIconResName => null;

	public void Initialize(EUGCAssetProviderType providerType)
	{
	}

	public void Destroy()
	{
	}

	public void RegisterAsset(UGCAssetMetadata assetMetadata)
	{
	}

	public void UnregisterAsset(UGCAssetRef asset)
	{
	}

	public void UpdateAsset(UGCAssetMetadata assetMetadata)
	{
	}

	public void RegisterProvider(UGCAssetProviderBase provider)
	{
	}

	public void UnregisterProvider(EUGCAssetProviderType providerId)
	{
	}

	public IEnumerable<UGCAssetProviderBase> GetProviders()
	{
		return null;
	}

	public bool TryGetProvider(EUGCAssetProviderType providerId, out UGCAssetProviderBase provider)
	{
		provider = null;
		return false;
	}

	public bool TryGetProvider<T>(EUGCAssetProviderType providerId, out T provider) where T : UGCAssetProviderBase
	{
		provider = null;
		return false;
	}

	public List<UGCAssetMetadata> Query(UGCQuery query)
	{
		return null;
	}

	public void PreRegisterAssetToUGCResourceManager(UGCAssetRef asset)
	{
	}

	public void PreRegisterAssetsToUGCResourceManager(UGCQuery query)
	{
	}

	public int GetAssetTypeCounts(IHDACHNBFNG assetType, EUGCAssetProviderType providerType)
	{
		return 0;
	}

	public UGCAssetMetadata GetMetadata(UGCAssetRef asset)
	{
		return null;
	}

	public bool IsAssetInUse(UGCAssetRef asset, bool IgnorePackage = false)
	{
		return false;
	}

	public bool CanAssetUpload(UGCAssetRef asset)
	{
		return false;
	}

	public bool DeleteAsset(UGCAssetRef asset)
	{
		return false;
	}

	public bool RenameAsset(UGCAssetRef asset, string newName)
	{
		return false;
	}

	public bool IsPackageAsset(UGCAssetRef asset)
	{
		return false;
	}

	public bool TryGetPreview(UGCAssetRef asset, out UGCPreview preview, bool useCache = true, bool autoCreatePreview = true)
	{
		preview = null;
		return false;
	}

	public UGCAssetProviderBase GetAssetProvider(UGCAssetRef asset)
	{
		return null;
	}

	public UGCPreview GeneratePreviewData(UGCAssetRef asset)
	{
		return null;
	}

	public void SetPreviewAsMesh(UGCPreview preview, Mesh previewMesh)
	{
	}

	public UGCPreview CreatePreview(UGCAssetRef asset)
	{
		return null;
	}

	public void SetPreviewAsGameObject(UGCPreview preview, GameObject previewGameObject)
	{
	}

	private void SetPreviewAsTexture(UGCPreview preview, Texture2D originalTexture)
	{
	}

	private void SetPreviewAsIcon(UGCPreview preview)
	{
	}

	private Texture2D ScaleTexture(Texture2D source, int maxSize)
	{
		return null;
	}

	public List<UGCCustomLevelObjectEditorPackageInfo> GetMergeReourceContentData(HashSet<string> assetIds)
	{
		return null;
	}

	public void ProcessAllProvidersPendingPackageData()
	{
	}

	public int GetTotalAssetCount()
	{
		return 0;
	}

	public int GetProviderAssetCount(EUGCAssetProviderType providerId)
	{
		return 0;
	}

	internal IEnumerable<UGCAssetMetadata> GetAssetsByProvider(EUGCAssetProviderType providerId)
	{
		return null;
	}

	public IEnumerable<string> GetRegisteredAssetIds()
	{
		return null;
	}

	public long GetCurrentPreviewCacheMemoryUsage()
	{
		return 0L;
	}

	public long GetMaxPreviewCacheMemory()
	{
		return 0L;
	}

	public void SetMaxPreviewCacheMemory(long maxMemoryBytes)
	{
	}

	public void ForceMemoryCleanup()
	{
	}

	public Dictionary<string, long> GetPreviewMemoryUsageBreakdown()
	{
		return null;
	}

	public void Tick(float deltaTime)
	{
	}

	public void ClearAllAssets()
	{
	}

	public void ClearPreviewCache()
	{
	}

	private string GetAssetKey(UGCAssetRef asset)
	{
		return null;
	}

	private string GetPreviewCacheKey(UGCAssetRef asset)
	{
		return null;
	}

	private bool MatchesQuery(UGCAssetMetadata asset, UGCQuery query)
	{
		return false;
	}

	private void CleanupPreviewCache(UGCAssetRef asset)
	{
	}

	private void CleanupProviderAssets(EUGCAssetProviderType providerId)
	{
	}

	private void CalculateAssetMemoryEstimation(UGCAssetMetadata assetMetadata)
	{
	}

	private void UpdatePreviewAccessStats(string cacheKey)
	{
	}

	private void CleanupPreviewCacheForMemory()
	{
	}

	private void PerformMemoryCleanup()
	{
	}

	public static string FormatBytes(long bytes)
	{
		return null;
	}
}
