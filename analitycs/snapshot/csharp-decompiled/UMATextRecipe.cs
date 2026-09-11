using System;
using System.Collections.Generic;
using UMA;
using UMACharacterSystem;

public class UMATextRecipe : UMAPackedRecipeBase, IUintId
{
	private class DCSRecipeChecker
	{
		public string packedRecipeType;

		public List<WardrobeSettings> wardrobeRecipesJson;

		public List<WardrobeSettings> wardrobeSet;

		public List<WardrobeSettings> checkedWardrobeSet => null;
	}

	[Serializable]
	public class DCSPackRecipe
	{
		public string packedRecipeType;

		public string name;

		public string race;

		public List<PackedOverlayColorDataV3> characterColors;

		public List<WardrobeSettings> wardrobeSet;

		public string raceAnimatorController;

		private OverlayColorData[] _sharedColors;

		public OverlayColorData[] sharedColors => null;

		public DCSPackRecipe()
		{
		}

		public DCSPackRecipe(DynamicCharacterAvatar dcaToSave, string recipeName, string pRecipeType, DynamicCharacterAvatar.SaveOptions saveOptions, string[] slotsToSave)
		{
		}

		public DCSPackRecipe(UMAPackRecipe umaPackRecipe, string recipeName = "", string pRecipeType = "Standard", List<WardrobeSettings> wardrobeSetToSave = null)
		{
		}
	}

	[Serializable]
	public class DCSUniversalPackRecipe : UMAPackRecipe
	{
		public List<WardrobeSettings> wardrobeSet;

		public string packedRecipeType;

		private OverlayColorData[] _sharedColors;

		public OverlayColorData[] sharedColors => null;

		public DCSUniversalPackRecipe()
		{
		}

		public DCSUniversalPackRecipe(UMAPackRecipe umaPackRecipe, string pRecipeType = "Standard")
		{
		}

		public DCSUniversalPackRecipe(DCSPackRecipe dcsPackRecipe)
		{
		}

		public DCSUniversalPackRecipe(UMAData.UMARecipe recipeToSave, Dictionary<string, UMATextRecipe> wardrobeRecipes = null, string pRecipeType = "DynamicCharacterAvatar")
		{
		}
	}

	public enum ERecipeType : byte
	{
		Standard,
		Wardrobe,
		WardrobeCollection,
		DynamicCharacterAvatar
	}

	[Serializable]
	public class ByteFlags
	{
		public byte flags;

		public bool HasFlag(byte b)
		{
			return false;
		}

		public void SetFlag(byte b)
		{
		}
	}

	[Serializable]
	public class MiniPackRecipe
	{
		public string race;

		public MiniPackedSlotData[] slots;
	}

	[Serializable]
	public class MiniPackedSlotData
	{
		public string id;

		public int scale;

		public int copyIdx;

		public MiniPackedOverlayData overlay;
	}

	[Serializable]
	public class MiniPackedOverlayData : ByteFlags
	{
		public const byte FLAG_SKIN_COLOR = 1;

		public string id;

		public void SetSkinColor()
		{
		}

		public bool HasSkinColor()
		{
			return false;
		}
	}

	private class IntVec2
	{
		public int a;

		public int b;
	}

	[NonSerialized]
	public byte recipeTypeByte;

	public string DisplayValue;

	public List<string> compatibleRaces;

	public string wardrobeSlot;

	public List<string> Hides;

	public List<string> suppressWardrobeSlots;

	public List<string> beSuppressWardrobeSlots;

	private uint _003CId_003Ek__BackingField;

	public const byte RecipeTypeStandard = 0;

	public const byte RecipeTypeWardrobe = 1;

	public const byte RecipeTypeWardrobeCollection = 2;

	public MiniPackRecipe recipeData;

	private static int[] m_DefaultRect;

	public uint Id
	{
		get
		{
			return _003CId_003Ek__BackingField;
		}
		set
		{
			_003CId_003Ek__BackingField = value;
		}
	}

	public string GetWardrobeSlot()
	{
		return null;
	}

	public static List<WardrobeSettings> GenerateWardrobeSet(Dictionary<string, UMATextRecipe> wardrobeRecipes, string[] slotsToSave)
	{
		return null;
	}

	public override void Load(UMAData.UMARecipe umaRecipe, UMAContext context = null)
	{
	}

	protected DCSUniversalPackRecipe PackedLoadDCSInternal(UMAContext context)
	{
		return null;
	}

	public static DCSUniversalPackRecipe PackedLoadDCS(UMAContext context, string recipeToUnpack, UMATextRecipe targetUTR = null)
	{
		return null;
	}

	public static DCSUniversalPackRecipe PackedLoadDCS(UMAContext context, UMATextRecipe recipe, UMATextRecipe targetUTR = null)
	{
		return null;
	}

	public void Save(UMAData.UMARecipe umaRecipe, UMAContext context, Dictionary<string, UMATextRecipe> wardrobeRecipes, bool backwardsCompatible = true)
	{
	}

	public override void Save(UMAData.UMARecipe umaRecipe, UMAContext context)
	{
	}

	public void SaveDCS(DynamicCharacterAvatar dcaToSave, string recipeName, DynamicCharacterAvatar.SaveOptions saveOptions)
	{
	}

	public static string GetRecipesType(string recipeString)
	{
		return null;
	}

	public static bool RecipeHasWardrobeSet(string recipeString)
	{
		return false;
	}

	public static List<WardrobeSettings> GetRecipesWardrobeSet(string recipeString)
	{
		return null;
	}

	public static byte RecipeTypeToByte(ERecipeType t)
	{
		return 0;
	}

	public override UMAPackRecipe PackedLoad(UMAContext context)
	{
		return null;
	}

	private PackedSlotDataV2 ConvertToSlotDataV2(MiniPackedSlotData s, ref bool hasSkinColor)
	{
		return null;
	}

	private PackedOverlayDataV2 ConvertToOverlayDataV2(MiniPackedOverlayData v, ref bool hasSkinColor)
	{
		return null;
	}

	public static PackedOverlayColorDataV3 CreateColorDataV3(string name)
	{
		return null;
	}

	public override void PackedSave(UMAPackRecipe packedRecipe, UMAContext context)
	{
	}

	private int GetSkipCount(int i, LinkedList<IntVec2> skips)
	{
		return 0;
	}

	private MiniPackedSlotData ConvertToSlotDataMini(PackedSlotDataV2 s2, int skinColorIndex, LinkedList<IntVec2> skips)
	{
		return null;
	}

	private MiniPackedOverlayData ConvertToOverlayDataMini(PackedOverlayDataV2 o2, int skinColorIndex)
	{
		return null;
	}

	public void ClearResourceRef()
	{
	}
}
