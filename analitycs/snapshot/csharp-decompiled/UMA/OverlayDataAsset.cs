using System;
using UnityEngine;

namespace UMA;

[Serializable]
public class OverlayDataAsset : ScriptableObject, ISerializationCallbackReceiver, INameProvider
{
	public enum OverlayType
	{
		Normal,
		Cutout,
		Additive
	}

	public string overlayName;

	[NonSerialized]
	public int nameHash;

	public OverlayType overlayType;

	public Rect rect;

	public Texture alphaMask;

	public Texture[] textureList;

	public UMAMaterial material;

	public string GetAssetName()
	{
		return null;
	}

	public int GetNameHash()
	{
		return 0;
	}

	public void OnAfterDeserialize()
	{
	}

	public void OnBeforeSerialize()
	{
	}

	public Texture GetAlphaMask()
	{
		return null;
	}
}
