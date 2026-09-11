using System;
using System.Collections.Generic;
using UMA;

public class DynamicRaceLibrary : RaceLibrary
{
	public bool dynamicallyAddFromResources;

	public string resourcesFolderPath;

	public bool dynamicallyAddFromAssetBundles;

	public string assetBundleNamesToSearch;

	public Dictionary<string, List<string>> assetBundlesUsedDict;

	[NonSerialized]
	private bool allStartingAssetsAdded;

	[NonSerialized]
	public bool downloadAssetsEnabled;

	public void Awake()
	{
	}

	public void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void ClearEditorAddedAssets()
	{
	}

	public void UpdateDynamicRaceLibrary(bool downloadAssets, int? raceHash = null)
	{
	}

	public void UpdateDynamicRaceLibrary(string raceName)
	{
	}

	private void AddRaces(RaceData[] races)
	{
	}

	public override void AddRace(RaceData race)
	{
	}

	public override RaceData GetRace(string raceName)
	{
		return null;
	}

	public RaceData GetRace(string raceName, bool allowUpdate = true)
	{
		return null;
	}

	public override RaceData GetRace(int nameHash)
	{
		return null;
	}

	public RaceData GetRace(int nameHash, bool allowUpdate = true)
	{
		return null;
	}

	public RaceData[] GetAllRacesBase()
	{
		return null;
	}

	public override RaceData[] GetAllRaces()
	{
		return null;
	}

	public string GetOriginatingAssetBundle(string raceName)
	{
		return null;
	}
}
