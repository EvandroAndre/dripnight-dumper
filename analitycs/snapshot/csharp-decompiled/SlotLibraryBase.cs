using System.Collections.Generic;
using UMA;
using UnityEngine;

public abstract class SlotLibraryBase : MonoBehaviour
{
	public virtual void AddSlotAsset(SlotDataAsset slot)
	{
	}

	public virtual SlotDataAsset[] GetAllSlotAssets()
	{
		return null;
	}

	public abstract SlotData InstantiateSlot(string name);

	public abstract SlotData InstantiateSlot(int nameHash);

	public abstract SlotData InstantiateSlot(string name, List<OverlayData> overlayList);

	public abstract SlotData InstantiateSlot(int nameHash, List<OverlayData> overlayList);

	public virtual bool HasSlot(string name)
	{
		return false;
	}

	public virtual bool HasSlot(int nameHash)
	{
		return false;
	}

	public virtual SlotDataAsset GetSlotDataAsset(string name)
	{
		return null;
	}

	public abstract void UpdateDictionary();

	public abstract void ValidateDictionary();
}
