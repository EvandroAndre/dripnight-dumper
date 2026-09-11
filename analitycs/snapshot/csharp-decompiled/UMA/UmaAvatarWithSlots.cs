using System.Collections.Generic;

namespace UMA;

public abstract class UmaAvatarWithSlots<T> : UMAAvatarBase, IUmaAvatarWithSlots, IUmaAvatarBase where T : IUintId
{
	protected Dictionary<string, T> _wardrobeRecipes;

	public Dictionary<string, T> WardrobeRecipes => null;

	protected abstract T FindSlotRecipe(int recipe);

	protected abstract string GetRecipeSlot(T recipe);

	public void SetSlot(int recipe)
	{
	}

	public void SetSlot(int recipe, uint id)
	{
	}

	public virtual void SetSlot(string slot, T utr)
	{
	}

	public void ClearSlot(string ws)
	{
	}

	public void ClearSlots()
	{
	}

	public virtual bool IsSlotVisible(string slot)
	{
		return false;
	}

	public bool HasSlot(string slot)
	{
		return false;
	}

	public List<uint> GetIds()
	{
		return null;
	}
}
