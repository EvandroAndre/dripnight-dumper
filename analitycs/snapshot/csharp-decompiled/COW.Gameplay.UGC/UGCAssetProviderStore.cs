using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using message;

namespace COW.Gameplay.UGC;

public sealed class UGCAssetProviderStore : UGCAssetProviderBase
{
	private struct LocalFileStamp
	{
		public long Size;

		public DateTime LastWriteTimeUtc;
	}

	private readonly EUGCAssetProviderType _providerId;

	private readonly Texture2D _fallbackIcon;

	private readonly Dictionary<string, UGCAssetMetadata> _assetIdToMeta;

	private readonly Dictionary<string, UGCPreview> _uuidToUGCPreview;

	private readonly Dictionary<string, UGCCustomLevelObjectEditorPackageInfo> _uuidToPackageInfo;

	private readonly HashSet<string> _packageAssetIds;

	private readonly Dictionary<string, UGCResourceShopMetaData> _pendingPackageDatas;

	private Dictionary<string, LocalFileStamp> _localFileStamps;

	private Dictionary<string, LocalFileStamp> _nextLocalFileStamps;

	private float _lastEnsureAssetsCheckTime;

	private ResCollectingContext _localFileResRefInProject;

	private int m_lastUpdateResCollectingContextFrameCount;

	public override EUGCAssetProviderType ProviderId => EUGCAssetProviderType.None;

	public override string DisplayName => null;

	public UGCAssetProviderStore(EUGCAssetProviderType providerId, Texture2D fallbackIcon)
	{
	}

	private bool IsAssetTypeInBlockList(UGCCustomLevelObjectEditorPackageInfo packageInfo, string assetUUID, IHDACHNBFNG assetType)
	{
		return false;
	}

	public List<FileInfo> GetStoreFileInfos()
	{
		return null;
	}

	public override void Initialize(UGCAssetExplorer explorer)
	{
	}

	public override void EnsureAssetsForQuery(UGCQuery query)
	{
	}

	private void RefreshAssetsFromLocalFiles(bool useThrottle)
	{
	}

	private void ScanSingleFile(FileInfo fileInfo, UGCResourceIndexEntry entry)
	{
	}

	private bool TryGetStoreIndexEntry(FileInfo fileInfo, out UGCResourceIndexEntry entry)
	{
		entry = null;
		return false;
	}

	private void RemoveAssetsByPath(string filePath)
	{
	}

	public override bool DeleteAsset(UGCAssetRef asset)
	{
		return false;
	}

	public override bool IsPackageAsset(UGCAssetRef asset)
	{
		return false;
	}

	public override bool RenameAsset(UGCAssetRef asset, string newName)
	{
		return false;
	}

	private UGCPreview CreatePreview(UGCVFSFileBaseInfo info)
	{
		return null;
	}

	private UGCPreview CreatePreview(KCJDEKIJAKH uGCTemplate)
	{
		return null;
	}

	private UGCPreview CreatePreview(UGCCustomLevelObjectEditorManifest.LibraryItem item, UGCAssetMetadata metadata, UGCCustomLevelObjectEditorPackageInfo packageInfo)
	{
		return null;
	}

	private UGCStoreMetadata BuildAssetMetadata(KCJDEKIJAKH template, FileInfo fileInfo, UGCResourceIndexEntry entry)
	{
		return null;
	}

	private bool TryParseResourceIdWithVersion(string fileName, out ulong resourceId, out int version)
	{
		resourceId = default(ulong);
		version = default(int);
		return false;
	}

	private void RegisterManifestLibraryItemRecursive(UGCCustomLevelObjectEditorPackageInfo packageInfo, UGCCustomLevelObjectEditorManifest.LibraryItem item, FileInfo fileInfo, UGCResourceIndexEntry entry)
	{
	}

	private bool GetPackageFileSize(PDNPIMFAGEN downloadDesc, string PackageUUID, out int fileSize)
	{
		fileSize = default(int);
		return false;
	}

	private string BuildManifestAssetId(UGCCustomLevelObjectEditorManifest.ManifestData manifest, UGCCustomLevelObjectEditorManifest.LibraryItem item)
	{
		return null;
	}

	private IHDACHNBFNG GetResourceTypeFromManifestItem(UGCCustomLevelObjectEditorManifest.LibraryItem item)
	{
		return IHDACHNBFNG.GameObject;
	}

	public override UGCAssetMetadata GetAssetMetadata(string assetId)
	{
		return null;
	}

	public override void PrepareAssetForLoad(UGCAssetRef asset)
	{
	}

	public override List<UGCCustomLevelObjectEditorPackageInfo> GetMergeReourceContentData(HashSet<string> assetIds)
	{
		return null;
	}

	private void QueueStorePendingPackageDataFromLocalFile(UGCResourceIndexEntry entry)
	{
	}

	public override void ProcessPendingPackageData()
	{
	}

	public override bool TryCreatePreview(string assetId, UGCPreviewOptions options, out UGCPreview preview)
	{
		preview = null;
		return false;
	}

	public ResCollectingContext GetLocalFileResRefInProject()
	{
		return null;
	}

	public override bool IsAssetInUse(UGCAssetRef asset, bool IgnorePackage = false)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_Initialize(UGCAssetExplorer P0)
	{
	}

	public void _003C_003EiFixBaseProxy_EnsureAssetsForQuery(UGCQuery P0)
	{
	}

	public List<UGCCustomLevelObjectEditorPackageInfo> _003C_003EiFixBaseProxy_GetMergeReourceContentData(HashSet<string> P0)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ProcessPendingPackageData()
	{
	}
}
