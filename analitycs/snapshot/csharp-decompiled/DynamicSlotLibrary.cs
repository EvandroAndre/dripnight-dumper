using System;
using System.Collections.Generic;
using UMA;

public class DynamicSlotLibrary : SlotLibrary
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

	public void UpdateDynamicSlotLibrary(int? nameHash = null)
	{
	}

	public void UpdateDynamicSlotLibrary(string slotName)
	{
	}

	public override SlotDataAsset GetSlotDataAsset(string name)
	{
		return null;
	}

	private void AddSlotAssets(SlotDataAsset[] slots)
	{
	}

	public override SlotData InstantiateSlot(string name)
	{
		return null;
	}

	public override SlotData InstantiateSlot(int nameHash)
	{
		return null;
	}

	public override SlotData InstantiateSlot(string name, List<OverlayData> overlayList)
	{
		return null;
	}

	public override SlotData InstantiateSlot(int nameHash, List<OverlayData> overlayList)
	{
		return null;
	}

	public string GetOriginatingAssetBundle(string slotName)
	{
		return null;
	}
}
