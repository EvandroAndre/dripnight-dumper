using UMA;
using UnityEngine;

public abstract class UMARecipeBase : ScriptableObject
{
	protected UMAData.UMARecipe umaRecipe;

	protected bool cached;

	public abstract void Load(UMAData.UMARecipe umaRecipe, UMAContext context);

	public abstract void Save(UMAData.UMARecipe umaRecipe, UMAContext context);

	public UMAData.UMARecipe GetCachedRecipe(UMAContext context)
	{
		return null;
	}
}
