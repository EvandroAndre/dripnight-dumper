using System;
using System.Collections.Generic;
using UMACharacterSystem;
using UnityEngine;

namespace UMA.Simple;

public class UmaAvatarSimple : UMAAvatarBase, IUmaAvatar, IUmaAvatarWithSlots, IUmaAvatarBase
{
	private UMAContextSimple m_ContextSimple;

	private UmaRecipeSimpleLibrary m_RecipeLibrary;

	private RaceData m_RaceData;

	private int[] m_Recipes;

	private int m_VisibleSlots;

	private int m_ChangedSlots;

	private bool lastBuildNotFinish;

	private ChangeRaceOptions defaultChangeRaceOptions;

	public string m_RaceName;

	private static int m_DebugIdGen;

	public bool LogDebug;

	public int m_DebugId;

	public bool PreAsyncLoading;

	public bool CountAbRefs;

	public int m_CacheGeneration;

	private bool m_CustomTextureDirty;

	private bool IsVisible;

	private static int[] s_SharedWardrobeSuppressBits;

	private static int[] s_SharedWardrobeBeSuppressBits;

	private static SlotData[] s_SharedOverlayData;

	private static List<KeyValuePair<SlotData, AdditiveInfo>> s_SharedAdditiveSlots;

	public bool AsyncLoadingBaseSlots;

	public bool BuildAfterWardrobeSlotsLoaded;

	public int NoAsyncLoadingWardrobeSlots;

	private int m_LoadingWardrobeSlots;

	private int m_LoadedWardrobeSlots;

	private LinkedList<uint>[] m_LoadingWardrobeTickes;

	private LinkedList<uint> m_LoadingBaseTickes;

	private Action<UnityEngine.Object, uint, int> m_CallbackOnWardrobeSlotLoaded;

	public int DisableAsyncLoadingWardrobeSlots
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public override void Initialize()
	{
	}

	public void InitAsyncLoading(bool pre)
	{
	}

	public override void EnableDebugLog(bool enable)
	{
	}

	public override UMAContextIndividual UseIndividualContextCache(SlotOverlayAssetCache cache)
	{
		return null;
	}

	private void OnDestroy()
	{
	}

	private UmaRecipeSimple GetRecipe(int recipe)
	{
		return default(UmaRecipeSimple);
	}

	private void Log(string s)
	{
	}

	private void LogError(string s)
	{
	}

	private void InitSlots()
	{
	}

	public void SetSlot(int recipe)
	{
	}

	public void SetSlot(int recipe, uint id)
	{
	}

	private void SetSlot(UmaRecipeSimple r)
	{
	}

	private void SetSlot(int slot, int r)
	{
	}

	public void ClearSlot(string ws)
	{
	}

	public void ClearSlots()
	{
	}

	public bool IsSlotVisible(string slot)
	{
		return false;
	}

	public bool HasSlot(string slot)
	{
		return false;
	}

	public bool IsAsyncLoading()
	{
		return false;
	}

	private UmaRecipeSimple GetRecipeForIdx(int idx)
	{
		return default(UmaRecipeSimple);
	}

	public List<uint> GetIds()
	{
		return null;
	}

	public void SetCustomTextureDirty(bool dirty)
	{
	}

	public void InitRace(string racename)
	{
	}

	public void ChangeRace(string racename, ChangeRaceOptions opt = ChangeRaceOptions.useDefaults)
	{
	}

	public void ChangeRace(RaceData race, ChangeRaceOptions opt = ChangeRaceOptions.useDefaults)
	{
	}

	private void InitColor()
	{
	}

	private void LoadRaceBodyColor(RaceData race)
	{
	}

	public void SetColor(string name, OverlayColorData colorData, bool updateTexture = true)
	{
	}

	public void SetColor(string name, Color color, bool updateTexture = true)
	{
	}

	private OverlayColorData GetColor(string name)
	{
		return null;
	}

	public void ForceUpdateColor()
	{
	}

	private void UpdateColors()
	{
	}

	public override void SetVisible(bool visible)
	{
	}

	public void BuildCharacterImmediatly()
	{
	}

	public void BuildCharacter()
	{
	}

	private void DoBuild(bool onWardrobesLoaded, bool onBaseLoaded, bool immediatly)
	{
	}

	private bool InitForBuildInNeed()
	{
		return false;
	}

	private bool IsRaceChanged()
	{
		return false;
	}

	private int CalcWardrobeSlots()
	{
		return 0;
	}

	private int CalcBaseSlots(int wardrobeSlots)
	{
		return 0;
	}

	private void LoadCharacter(int wardrobeSlots, int baseSlots, bool raceChanged)
	{
	}

	private void AddBaseSlots(List<SlotData> dst, RaceData racedata, UMAData.UMARecipe umaRecipe, UMATextRecipe baseRecipe, int baseSlots)
	{
	}

	private void AddWardrobeRecipes(RaceData racedata, UMAData.UMARecipe umaRecipe, List<SlotData> dst, int wardrobeSlots, UMATextRecipe baseRecipe, int baseSlots)
	{
	}

	private void UpdateRaceOnLoad(bool raceChanged)
	{
	}

	private void FixAdditiveSlotInBaseSlots(List<SlotData> slots)
	{
	}

	private void AddAdditiveSlots(List<SlotData> dst, int wardrobeSlots, int baseSlotsEnd, List<KeyValuePair<SlotData, AdditiveInfo>> additiveSlots)
	{
	}

	private void AddAdditiveToBaseSlot(List<SlotData> dst, int baseSlotsEnd, OverlayData srcOverlay, AdditiveInfo additiveInfo)
	{
	}

	private bool HasWardrobeSlotsLoading()
	{
		return false;
	}

	private void UpdateWardrobeSlotsLoading(ref int wardrobeSlots, bool needload)
	{
	}

	private void CancelWardrobeSlotLoading(int slot)
	{
	}

	private void StartWardrobeSlotLoading(int slot)
	{
	}

	private LinkedList<uint> EnsureWardrobeTicketsList(int slot)
	{
		return null;
	}

	private void OnWardrobeSlotLoaded(UnityEngine.Object asset, uint ticket, int slot)
	{
	}

	private void MarkSlotLoadFailed(int slot)
	{
	}

	private void OnAllWardrobeSlotsLoaded()
	{
	}

	private bool HasBaseSlotsLoading()
	{
		return false;
	}

	private void UpdateBaseSlotsLoading(int baseSlots, bool raceChanged)
	{
	}

	private void StartBaseSlotLoading(string name, bool isSlot)
	{
	}

	private void OnBaseSlotLoaded(UnityEngine.Object asset, uint ticket)
	{
	}

	private void OnAllBaseSlotsLoaded()
	{
	}

	private void CancelAllSlotsLoading()
	{
	}

	private void CancelBaseSlotsLoading()
	{
	}

	private void CancelWardrobeSlotsLoading()
	{
	}

	private void CancelSlotsLoading(ref int slots, ICollection<uint>[] slotTickets)
	{
	}

	private void CancelSlotLoading(ICollection<uint>[] slotTickets, int slot)
	{
	}
}
