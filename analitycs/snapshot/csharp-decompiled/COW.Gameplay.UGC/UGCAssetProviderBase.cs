using System.Collections.Generic;

namespace COW.Gameplay.UGC;

public abstract class UGCAssetProviderBase
{
	protected UGCAssetExplorer _explorer;

	public abstract EUGCAssetProviderType ProviderId { get; }

	public abstract string DisplayName { get; }

	public virtual void Initialize(UGCAssetExplorer explorer)
	{
	}

	public virtual void Shutdown()
	{
	}

	public abstract UGCAssetMetadata GetAssetMetadata(string assetId);

	public abstract void PrepareAssetForLoad(UGCAssetRef asset);

	public abstract bool DeleteAsset(UGCAssetRef asset);

	public abstract bool IsPackageAsset(UGCAssetRef asset);

	public abstract bool IsAssetInUse(UGCAssetRef asset, bool IgnorePackage = false);

	public abstract bool RenameAsset(UGCAssetRef asset, string newName);

	public abstract bool TryCreatePreview(string assetId, UGCPreviewOptions options, out UGCPreview preview);

	public virtual long EstimateAssetMemoryUsage(string assetId)
	{
		return 0L;
	}

	public virtual bool CanAssetUpload(UGCAssetRef asset)
	{
		return false;
	}

	public virtual long EstimatePreviewMemoryUsage(string assetId, UGCPreviewOptions options)
	{
		return 0L;
	}

	public virtual void Tick(float deltaTime)
	{
	}

	public virtual void EnsureAssetsForQuery(UGCQuery query)
	{
	}

	public virtual void ProcessPendingPackageData()
	{
	}

	public virtual List<UGCCustomLevelObjectEditorPackageInfo> GetMergeReourceContentData(HashSet<string> assetIds)
	{
		return null;
	}

	protected void RegisterAsset(UGCAssetMetadata assetMetadata)
	{
	}

	protected void UnregisterAsset(string assetId)
	{
	}
}
