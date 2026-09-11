using System;
using System.Collections.Generic;
using System.IO;
using message;

namespace COW.Gameplay.UGC;

public class UGCAssetMetadata
{
	public FileInfo FileInfo;

	public UGCAssetRef Asset;

	public string Path;

	public UGCLocalizedName DisplayName;

	public IHDACHNBFNG ResourceType;

	public long SizeBytes;

	public string OwnerPackage;

	public List<string> Tags;

	public KCJDEKIJAKH TemplateData;

	public long EstimatedMemoryUsageBytes;

	public long PreviewMemoryUsageBytes;

	public DateTime MemoryEstimationTime;

	public DateTime CreatedAtUtc;

	public DateTime LastModifiedUtc;

	public EUGCAssetProviderType ProviderId => EUGCAssetProviderType.None;

	public string AssetId => null;

	public bool HasTag(string tag)
	{
		return false;
	}

	public bool HasAnyTag(string[] tags)
	{
		return false;
	}

	public bool HasAllTags(string[] tags)
	{
		return false;
	}
}
