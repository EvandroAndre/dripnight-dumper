using System;
using System.Collections.Generic;
using UMA;
using UnityEngine;

public class OverlayLibrary : OverlayLibraryBase
{
	protected OverlayDataAsset[] overlayElementList;

	[NonSerialized]
	private Dictionary<int, OverlayDataAsset> overlayDictionary;

	public int scaleAdjust;

	public bool readWrite;

	public bool compress;

	private void Awake()
	{
	}

	public override void UpdateDictionary()
	{
	}

	public override void AddOverlayAsset(OverlayDataAsset overlay)
	{
	}

	public override void ValidateDictionary()
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

	private OverlayData Internal_InstantiateOverlay(int nameHash)
	{
		return null;
	}

	public override OverlayDataAsset[] GetAllOverlayAssets()
	{
		return null;
	}
}
