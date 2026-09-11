using System;
using System.Collections;
using System.Collections.Generic;
using UMA;
using UnityEngine;

namespace UMACharacterSystem;

public class DynamicCharacterAvatar : UmaAvatarWithSlots<UMATextRecipe>, IUmaAvatar, IUmaAvatarWithSlots, IUmaAvatarBase
{
	public enum LoadOptions
	{
		useDefaults = 0,
		loadRace = 1,
		loadWardrobe = 4,
		loadBodyColors = 8,
		loadWardrobeColors = 0x10
	}

	public enum SaveOptions
	{
		useDefaults = 0,
		saveWardrobe = 2,
		saveColors = 4,
		saveAnimator = 8
	}

	public enum loadPathTypes
	{
		persistentDataPath,
		Resources,
		FileSystem,
		CharacterSystem,
		String
	}

	public enum savePathTypes
	{
		persistentDataPath,
		Resources,
		FileSystem
	}

	[Serializable]
	public class RaceSetter
	{
		public string name;

		private RaceData _data;

		private RaceData[] _cachedRaceDatas;

		public RaceData data
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public RaceData racedata => null;

		private RaceData Validate()
		{
			return null;
		}
	}

	[Serializable]
	public class WardrobeRecipeListItem
	{
		public string _recipeName;

		public UMATextRecipe _recipe;

		public List<string> _compatibleRaces;

		public WardrobeRecipeListItem()
		{
		}

		public WardrobeRecipeListItem(string recipeName)
		{
		}

		public WardrobeRecipeListItem(UMATextRecipe recipe)
		{
		}
	}

	[Serializable]
	public class WardrobeRecipeList
	{
		public bool loadDefaultRecipes;

		public List<WardrobeRecipeListItem> recipes;

		public List<WardrobeRecipeListItem> Validate(bool allowDownloadables = false, string raceName = "")
		{
			return null;
		}
	}

	[Serializable]
	public class ColorValue : OverlayColorData
	{
		private string _name;

		private Color _color;

		private Color _metallicGloss;

		public bool valuesConverted;

		public string Name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Color Color
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color MetallicGloss
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public ColorValue()
		{
		}

		public ColorValue(int channels)
		{
		}

		public ColorValue(string nameVal, Color colorVal)
		{
		}

		public ColorValue(string nameVal, OverlayColorData color)
		{
		}

		public ColorValue(ColorValue col)
		{
		}

		public ColorValue(OverlayColorData col)
		{
		}

		private void ConvertOldFieldsToNew()
		{
		}
	}

	[Serializable]
	public class ColorValueList
	{
		public List<ColorValue> _colors;

		public List<ColorValue> Colors
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ColorValueList()
		{
		}

		public ColorValueList(OverlayColorData[] colors)
		{
		}

		public ColorValueList(List<ColorValue> colorValueList)
		{
		}

		private ColorValue GetColorValue(string name)
		{
			return null;
		}

		public OverlayColorData[] ToOverlayColors()
		{
			return null;
		}

		public OverlayColorData ToOverlayColorData(ColorValue cv)
		{
			return null;
		}

		public bool GetColor(string Name, out Color c)
		{
			c = default(Color);
			return false;
		}

		public bool GetColor(string Name, out OverlayColorData c)
		{
			c = null;
			return false;
		}

		public void SetColor(string name, Color c)
		{
		}

		public void SetColor(string name, OverlayColorData c)
		{
		}

		public void RemoveColor(string name)
		{
		}
	}

	private sealed class _003CBuildCharacterWhenReady_003Ed__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DynamicCharacterAvatar _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CBuildCharacterWhenReady_003Ed__68(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CBuildFromComponentSettingsCO_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DynamicCharacterAvatar _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CBuildFromComponentSettingsCO_003Ed__38(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CImportSettingsCO_003Ed__67 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LoadOptions customLoadOptions;

		public DynamicCharacterAvatar _003C_003E4__this;

		public bool forceDCSLoad;

		public UMATextRecipe.DCSUniversalPackRecipe settingsToLoad;

		private LoadOptions _003CthisLoadOptions_003E5__2;

		private bool _003CwasBuildCharacterEnabled_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CImportSettingsCO_003Ed__67(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	public UMADataEvent RecipeUpdated;

	public RaceSetter activeRace;

	public ChangeRaceOptions defaultChangeRaceOptions;

	public ColorValueList characterColors;

	public LoadOptions defaultLoadOptions;

	public bool ensureSharedColors;

	[NonSerialized]
	public List<string> assetBundlesUsedbyCharacter;

	public bool IsAsyncGeneration;

	private bool _buildCharacterEnabled;

	private string cacheStateNull;

	private List<string> HiddenSlots;

	private bool _isFirstSettingsBuild;

	private List<UMATextRecipe> _visibleRecipes;

	private List<KeyValuePair<SlotData, AdditiveInfo>> m_AdditiveSlots;

	private List<int> m_RecipeSlotsStarts;

	private bool m_CustomTextureDirty;

	public string RacePreset
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Dictionary<string, List<UMATextRecipe>> AvailableRecipes => null;

	public List<string> CurrentWardrobeSlots => null;

	public List<ColorValue> ActiveColors => null;

	public bool BuildCharacterEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private bool BuildUsingComponentSettings => false;

	public void AddAvailableRaceRecipesDictionary(string raceName, ref Dictionary<int, UMATextRecipe> availableRecipesDict)
	{
	}

	public override void Awake()
	{
	}

	public void BuildCharacterImmediatly()
	{
	}

	public void SetAnimator(Animator amtr)
	{
	}

	private void BuildFromComponentSettingsCOSync()
	{
	}

	private IEnumerator BuildFromComponentSettingsCO()
	{
		return null;
	}

	private void SetActiveRace(bool allowGenderFallback = false)
	{
	}

	public void ChangeRace(string racename, ChangeRaceOptions customChangeRaceOptions = ChangeRaceOptions.useDefaults)
	{
	}

	public void ChangeRace(RaceData race, ChangeRaceOptions customChangeRaceOptions = ChangeRaceOptions.useDefaults)
	{
	}

	private void PerformRaceChange(RaceData race, ChangeRaceOptions customChangeRaceOptions = ChangeRaceOptions.useDefaults)
	{
	}

	protected UMATextRecipe FindSlotRecipe(string Slotname, int Recipename)
	{
		return null;
	}

	protected override UMATextRecipe FindSlotRecipe(int Recipename)
	{
		return null;
	}

	protected override string GetRecipeSlot(UMATextRecipe recipe)
	{
		return null;
	}

	public string GetWardrobeItemName(string SlotName)
	{
		return null;
	}

	public void SetSlot(UMATextRecipe utr)
	{
	}

	public void SetSlot(string Slotname, int Recipename)
	{
	}

	public override bool IsSlotVisible(string slot)
	{
		return false;
	}

	public void InitAsyncLoading(bool pre)
	{
	}

	public bool IsAsyncLoading()
	{
		return false;
	}

	private void ApplyCurrentWardrobeToNewRace()
	{
	}

	public void LoadWardrobeSet(List<WardrobeSettings> wardrobeSet, bool clearExisting = false)
	{
	}

	public OverlayColorData GetColor(string Name)
	{
		return null;
	}

	public void SetColor(string SharedColorName, Color AlbedoColor, Color MetallicRGB = default(Color), float Gloss = 0f, bool UpdateTexture = false)
	{
	}

	public void SetColor(string Name, OverlayColorData colorData, bool UpdateTexture = true)
	{
	}

	public void ForceUpdateColor()
	{
	}

	public void UpdateColors(bool triggerDirty = false)
	{
	}

	private OverlayColorData[] ImportSharedColors(OverlayColorData[] colorsToLoad, LoadOptions thisLoadOptions)
	{
		return null;
	}

	private List<string> GetBodyColorNames()
	{
		return null;
	}

	public List<OverlayColorData> LoadBodyColors(OverlayColorData[] colorsToLoad, bool apply = false)
	{
		return null;
	}

	public List<OverlayColorData> LoadWardrobeColors(OverlayColorData[] colorsToLoad, bool apply = false)
	{
		return null;
	}

	private List<OverlayColorData> LoadBodyOrWardrobeColors(OverlayColorData[] colorsToLoad, bool loadingBody = true, bool apply = false)
	{
		return null;
	}

	public List<OverlayColorData> RestoreCachedBodyColors(bool apply = false, bool fullRestore = false)
	{
		return null;
	}

	public List<OverlayColorData> RestoreCachedWardrobeColors(bool apply = false, bool fullRestore = false)
	{
		return null;
	}

	private List<OverlayColorData> RestoreCachedBodyOrWardrobeColors(bool restoringBody = true, bool apply = false, bool fullRestore = false)
	{
		return null;
	}

	private IEnumerator ImportSettingsCO(UMATextRecipe.DCSUniversalPackRecipe settingsToLoad, LoadOptions customLoadOptions = LoadOptions.useDefaults, bool forceDCSLoad = false)
	{
		return null;
	}

	private IEnumerator BuildCharacterWhenReady()
	{
		return null;
	}

	public void BuildCharacter()
	{
	}

	private bool LoadCharacter(UMARecipeBase umaRecipe, List<UMAWardrobeRecipe> Replaces, UMATextRecipe[] umaAdditionalSerializedRecipes)
	{
		return false;
	}

	private void UnloadAvatar()
	{
	}

	private void FixAdditiveSlotInBaseSlots(UMAData.UMARecipe umaRecipe)
	{
	}

	private void AddAdditiveToBaseSlot(SlotData[] slotDataList, int start, int end, SlotData slot, AdditiveInfo additiveInfo)
	{
	}

	public void AddAdditionalSerializedRecipes(UMATextRecipe[] umaAdditionalSerializedRecipes)
	{
	}

	private void AddAdditiveSlots(UMATextRecipe[] recipes, List<int> recipeSlotStarts, SlotData[] slots, List<KeyValuePair<SlotData, AdditiveInfo>> additiveSlots)
	{
	}

	private void AddAdditiveToWardrobeSlot(SlotData[] slotDataList, int start, int end, SlotData slot, AdditiveInfo additiveInfo)
	{
	}

	private void UpdateOverlayLimitSize(UMATextRecipe utr, UMAData.UMARecipe cachedRecipe)
	{
	}

	private void RemoveHiddenSlots()
	{
	}

	public void SetCustomTextureDirty(bool dirty)
	{
	}
}
