using System.Collections.Generic;
using UMA;
using UMACharacterSystem;
using UnityEngine;

public class UMAContext : MonoBehaviour
{
	public DynamicCharacterSystemBase dynamicCharacterSystem;

	public static UMAContext Instance;

	public RaceLibraryBase raceLibrary;

	public SlotLibraryBase slotLibrary;

	public OverlayLibraryBase overlayLibrary;

	public virtual void Start()
	{
	}

	public virtual void OnDestroy()
	{
	}

	public void ValidateDictionaries()
	{
	}

	public virtual RaceData GetRace(string name)
	{
		return null;
	}

	public RaceData GetRace(int nameHash)
	{
		return null;
	}

	public virtual SlotData InstantiateSlot(string name)
	{
		return null;
	}

	public virtual SlotData InstantiateSlot(int nameHash)
	{
		return null;
	}

	public SlotData InstantiateSlot(string name, List<OverlayData> overlayList)
	{
		return null;
	}

	public SlotData InstantiateSlot(int nameHash, List<OverlayData> overlayList)
	{
		return null;
	}

	public virtual OverlayData InstantiateOverlay(string name)
	{
		return null;
	}

	public virtual OverlayData InstantiateOverlay(int nameHash)
	{
		return null;
	}

	public OverlayData InstantiateOverlay(string name, Color color)
	{
		return null;
	}

	public OverlayData InstantiateOverlay(int nameHash, Color color)
	{
		return null;
	}

	public static UMAContext FindInstance()
	{
		return null;
	}
}
