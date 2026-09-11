using System.Collections.Generic;

namespace UMA.Simple;

public struct UmaRecipeSimple : IUintId
{
	public const int INVALID_VAL = 0;

	public static readonly UmaRecipeSimple INVALID;

	internal int m_Ptr = 0;

	private static List<KeyValuePair<int, bool>> s_SharedSlotOverlayHashList;

	public string Name => null;

	public uint Id
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	private UmaRecipeSimple(int ptr)
	{
	}

	public UmaRecipeSimple(int ptr, string name)
	{
	}

	public override string ToString()
	{
		return null;
	}

	public static implicit operator int(UmaRecipeSimple id)
	{
		return 0;
	}

	public static implicit operator UmaRecipeSimple(int value)
	{
		return default(UmaRecipeSimple);
	}

	public static bool operator ==(UmaRecipeSimple a, UmaRecipeSimple b)
	{
		return false;
	}

	public static bool operator !=(UmaRecipeSimple a, UmaRecipeSimple b)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public EWardrobeSlot GetSlot()
	{
		return EWardrobeSlot.None;
	}

	public int GetSuppressBits()
	{
		return 0;
	}

	public int GetHidesBits()
	{
		return 0;
	}

	private int GetSlotsPtr(out int[] data, out int slotCnt, out int isSkins, out int isAdditive, out int pAdditive)
	{
		data = null;
		slotCnt = default(int);
		isSkins = default(int);
		isAdditive = default(int);
		pAdditive = default(int);
		return 0;
	}

	public List<KeyValuePair<int, bool>> GetSlotOverlaysInSharedListIgnoreNull()
	{
		return null;
	}

	public List<SlotOverlayHashPair> GetSlotOverlaysInSharedList()
	{
		return null;
	}

	private int GetHashPtr(out int[] data)
	{
		data = null;
		return 0;
	}

	public bool MergeTo(UMAContextSimple context, RaceData racedata, UMAData.UMARecipe umaRecipe, List<SlotData> dst, List<KeyValuePair<SlotData, AdditiveInfo>> additiveSlots)
	{
		return false;
	}

	private static SlotData CreateMergeSlotData(UMAData.UMARecipe umaRecipe, UMAContextSimple context, int slotHash, int overlayHash, bool isSkin, int limitSize, bool potensialAdditive)
	{
		return null;
	}

	private static bool MergeSlot(List<SlotData> dst, SlotData slotData)
	{
		return false;
	}

	private void MergeAdditiveSlot(List<SlotData> dst, OverlayData srcOverlay, AdditiveInfo addtiveInfo, int beforeAddSlotCount, int addedSlotCount, int[] data, int pSlots)
	{
	}

	public void MergeAdditiveSlot(List<SlotData> dst, OverlayData srcOverlay, AdditiveInfo addtiveInfo)
	{
	}

	public bool AllSlotOverlaysCached(UMAContextSimple context)
	{
		return false;
	}

	public void GetUnCachedSlotOverlays(UMAContextSimple context, List<int> dst)
	{
	}
}
