using System;
using System.Collections.Generic;

namespace UMACharacterSystem;

public class DynamicCharacterSystem : DynamicCharacterSystemBase
{
	public Dictionary<int, UMATextRecipe> RecipeIndex;

	public Dictionary<string, Dictionary<string, List<UMATextRecipe>>> Recipes;

	public Dictionary<string, string> CharacterRecipes;

	public bool initializeOnAwake;

	[NonSerialized]
	public bool initialized;

	private bool isInitializing;

	public bool dynamicallyAddFromResources;

	public string resourcesCharactersFolder;

	public string resourcesRecipesFolder;

	public bool dynamicallyAddFromAssetBundles;

	public string assetBundlesForCharactersToSearch;

	public string assetBundlesForRecipesToSearch;

	public bool addAllRecipesFromDownloadedBundles;

	public UMAContext context;

	public Dictionary<string, List<string>> assetBundlesUsedDict;

	[NonSerialized]
	public bool downloadAssetsEnabled;

	public static bool ManulInit;

	private static DynamicCharacterSystem m_Instance;

	private void OnDestroy()
	{
	}

	public override void Awake()
	{
	}

	public override void Start()
	{
	}

	public static void ResetManualInitAndEnsureInitd()
	{
	}

	public override void Init()
	{
	}

	public void EnsureRaceKey(string race)
	{
	}

	public void RefreshRaceKeys()
	{
	}

	public override void Refresh(bool forceUpdateRaceLibrary = true, string bundleToGather = "")
	{
	}

	private void GatherCharacterRecipes(string filename = "", string bundleToGather = "")
	{
	}

	private void GatherRecipeFiles(int filenamehash = 0, string bundleToGather = "")
	{
	}

	public void AddRecipesFromAB(UMATextRecipe[] uparts)
	{
	}

	public void AddRecipe(UMATextRecipe upart)
	{
	}

	public void AddRecipes(UMATextRecipe[] uparts, int filenamehash = 0)
	{
	}

	public UMATextRecipe GetRecipe(int filenamehash, bool dynamicallyAdd = true)
	{
		return null;
	}

	public string GetOriginatingAssetBundle(string recipeName)
	{
		return null;
	}

	public override List<string> GetRecipeNamesForRaceSlot(string race, string slot)
	{
		return null;
	}

	public override List<UMARecipeBase> GetRecipesForRaceSlot(string race, string slot)
	{
		return null;
	}

	public override bool CheckRecipeAvailability(string recipeName)
	{
		return false;
	}

	public override UMARecipeBase GetBaseRecipe(int filename, bool dynamicallyAdd = true)
	{
		return null;
	}
}
