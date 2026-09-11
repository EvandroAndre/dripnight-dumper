using System;
using System.Collections.Generic;
using UMA;
using UnityEngine;

public class DynamicOverlayLibrary : OverlayLibrary
{
	public bool dynamicallyAddFromResources;

	public string resourcesFolderPath;

	public bool dynamicallyAddFromAssetBundles;

	public string assetBundleNamesToSearch;

	public Dictionary<string, List<string>> assetBundlesUsedDict;

	[NonSerialized]
	public bool downloadAssetsEnabled;

	public void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void ClearEditorAddedAssets()
	{
	}

	public void UpdateDynamicOverlayLibrary(int? nameHash = null)
	{
	}

	public void UpdateDynamicOverlayLibrary(string overlayName)
	{
	}

	private void AddOverlayAssets(OverlayDataAsset[] overlays)
	{
	}

	public override OverlayData InstantiateOverlay(string name)
	{
		return null;
	}

	public override OverlayData InstantiateOverlay(int nameHash)
	{
		return null;
	}

	public override OverlayData InstantiateOverlay(string name, Color color)
	{
		return null;
	}

	public override OverlayData InstantiateOverlay(int nameHash, Color color)
	{
		return null;
	}

	public string GetOriginatingAssetBundle(string overlayName)
	{
		return null;
	}
}
