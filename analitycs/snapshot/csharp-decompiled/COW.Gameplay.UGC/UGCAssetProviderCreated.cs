using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using message;

namespace COW.Gameplay.UGC;

public sealed class UGCAssetProviderCreated : UGCAssetProviderBase
{
	private class LocalFileStamp
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

	private Dictionary<string, LocalFileStamp> _localFileStamps;

	private float _lastEnsureAssetsCheckTime;

	public override EUGCAssetProviderType ProviderId => EUGCAssetProviderType.None;

	public override string DisplayName => null;

	public UGCAssetProviderCreated(EUGCAssetProviderType providerId, Texture2D fallbackIcon)
	{
	}

	public List<FileInfo> GetCreatedFileInfos()
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

	private void ScanSingleFile(FileInfo fileInfo)
	{
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

	private UGCPreview CreatePreview(KCJDEKIJAKH template)
	{
		return null;
	}

	private UGCAssetMetadata BuildAssetMetadata(KCJDEKIJAKH template, FileInfo fileInfo)
	{
		return null;
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

	public override bool TryCreatePreview(string assetId, UGCPreviewOptions options, out UGCPreview preview)
	{
		preview = null;
		return false;
	}

	public override bool IsAssetInUse(UGCAssetRef asset, bool IgnorePackage = false)
	{
		return false;
	}

	public override bool CanAssetUpload(UGCAssetRef asset)
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

	public bool _003C_003EiFixBaseProxy_CanAssetUpload(UGCAssetRef P0)
	{
		return false;
	}
}
