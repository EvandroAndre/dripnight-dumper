using System.Collections.Generic;
using UnityEngine;

namespace UMA.Simple;

public class SlotOverlayRefsDic : ISlotOverlayRefs
{
	internal readonly Dictionary<SlotDataAsset, short> m_SlotRefCount;

	internal readonly Dictionary<OverlayDataAsset, short> m_OverlayRefCount;

	protected Dictionary<UMAMeshAsset, short> m_MeshRefCount;

	protected Dictionary<Texture, short> m_TextureRefCount;

	public void InitMeshTexRefCounts(bool mesh, bool tex)
	{
	}

	private void InitRefsDic<T>(ref Dictionary<T, short> dic, bool create)
	{
	}

	public bool HasRefs()
	{
		return false;
	}

	public void ClearRefs()
	{
	}

	public void GetRefedAssets(ICollection<SlotDataAsset> slots, ICollection<OverlayDataAsset> overlays)
	{
	}

	public short AddRefCount(bool isSlot, Object asset, short deltaCount)
	{
		return 0;
	}

	private short AddSlotRefCount(SlotDataAsset slot, short deltaCount)
	{
		return 0;
	}

	private short AddOverlayRefCount(OverlayDataAsset overlay, short deltaCount)
	{
		return 0;
	}

	private void AddMeshRefCount(SlotDataAsset slot, short deltaCount)
	{
	}

	private void AddTextureRefCount(OverlayDataAsset overlay, short deltaCount)
	{
	}

	private short AddRefCount<T>(Dictionary<T, short> refs, T asset, short deltaCount) where T : Object
	{
		return 0;
	}

	public bool RemoveRefCount(bool isSlot, Object asset)
	{
		return false;
	}

	public bool RemoveIfNotRefed(UMAMeshAsset asset)
	{
		return false;
	}

	public bool RemoveIfNotRefed(Texture asset)
	{
		return false;
	}

	public bool ContainsTextureRef(Texture asset)
	{
		return false;
	}

	private bool RemoveIfNotRefed<T>(Dictionary<T, short> refs, T asset)
	{
		return false;
	}
}
