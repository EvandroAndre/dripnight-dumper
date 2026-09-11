using System;
using System.Collections.Generic;
using UnityEngine;

namespace UMA;

[Serializable]
public class SlotData : IEquatable<SlotData>, ISerializationCallbackReceiver
{
	public SlotDataAsset asset;

	public float overlayScale;

	public int overlayLimitSize;

	public bool dontSerialize;

	private List<OverlayData> overlayList;

	private List<OverlayData> individualOverlayList;

	[NonSerialized]
	public UMAMaterial overrideMaterial;

	[NonSerialized]
	public Texture overrideDecalTexture;

	[NonSerialized]
	public int overrideDecalTextureIndex;

	public string slotName => null;

	public int OverlayCount => 0;

	public SlotData(SlotDataAsset asset)
	{
	}

	public SlotData()
	{
	}

	public void SetAsset(SlotDataAsset asset)
	{
	}

	public void Reset()
	{
	}

	public SlotData Copy()
	{
		return null;
	}

	public OverlayData GetOverlay(int index)
	{
		return null;
	}

	public OverlayData GetEquivalentUsedOverlay(OverlayData overlay)
	{
		return null;
	}

	public void SetOverlayList(List<OverlayData> overlayList)
	{
	}

	private void CopyOverlayList(List<OverlayData> src)
	{
	}

	public void AddOverlay(OverlayData overlayData)
	{
	}

	public List<OverlayData> GetOverlayList()
	{
		return null;
	}

	public List<OverlayData> GetSharedOverlayList()
	{
		return null;
	}

	internal bool Validate()
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}

	public static implicit operator bool(SlotData obj)
	{
		return false;
	}

	public bool Equals(SlotData other)
	{
		return false;
	}

	public override bool Equals(object other)
	{
		return false;
	}

	public static bool operator ==(SlotData slot, SlotData obj)
	{
		return false;
	}

	public static bool operator !=(SlotData slot, SlotData obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public void OnAfterDeserialize()
	{
	}

	public void OnBeforeSerialize()
	{
	}
}
