using System;
using System.Collections.Generic;
using UnityEngine;

namespace UMA;

public class DynamicAssetLoader : MonoBehaviour
{
	private static DynamicAssetLoader _instance;

	public bool isInitialized;

	public RaceData placeholderRace;

	public UMATextRecipe placeholderWardrobeRecipe;

	public SlotDataAsset placeholderSlot;

	public OverlayDataAsset placeholderOverlay;

	public bool debugOnFail;

	public static DynamicAssetLoader Instance
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void StartCO()
	{
	}

	public static DynamicAssetLoader FindInstance()
	{
		return null;
	}

	public virtual bool AddAssets<T>(ref Dictionary<string, List<string>> assetBundlesUsedDict, bool searchResources, bool searchBundles, bool downloadAssetsEnabled, string bundlesToSearch = "", string resourcesFolderPath = "", int? assetNameHash = null, string assetName = "", Action<T[]> callback = null, bool forceDownloadAll = false) where T : UnityEngine.Object
	{
		return false;
	}

	public bool AddAssets<T>(bool searchResources, bool searchBundles, bool downloadAssetsEnabled, string bundlesToSearch = "", string resourcesFolderPath = "", int? assetNameHash = null, string assetName = "", Action<T[]> callback = null, bool forceDownloadAll = false) where T : UnityEngine.Object
	{
		return false;
	}

	public bool AddAssetsFromResourcesIndex<T>(ref List<T> assetsToReturn, string[] resourcesFolderPathArray, int? assetNameHash = null, string assetName = "") where T : UnityEngine.Object
	{
		return false;
	}

	private string[] SearchStringToArray(string searchString = "")
	{
		return null;
	}

	public virtual void AddWardrobeRecipes(Action<UMAWardrobeRecipe[]> callback)
	{
	}
}
