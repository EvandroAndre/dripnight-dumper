using System;
using GCommon;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCPreview
{
	public UGCAssetRef Asset;

	public UGCAssetPreviewKind Kind;

	public Texture2D Texture;

	public string IconResName;

	public ResourceID ResourceId;

	public GameObject PreviewGameObject;

	public DateTime CachedAtUtc;

	public string ResolvedDisplayName;

	public long MemoryUsageBytes;

	public DateTime LastAccessTime;

	public int AccessCount;

	public void NotifyChanged()
	{
	}
}
