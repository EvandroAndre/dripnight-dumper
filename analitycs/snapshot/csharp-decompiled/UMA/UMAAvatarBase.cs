using System.Collections.Generic;
using UMA.Simple;
using UnityEngine;

namespace UMA;

public abstract class UMAAvatarBase : MonoBehaviour, IUmaAvatarBase
{
	public UMAContext context;

	public UMAData umaData;

	public UMARecipeBase umaRecipe;

	public UMARecipeBase[] mUmaAdditionalRecipes;

	public UMAGeneratorBase umaGenerator;

	public RuntimeAnimatorController animationController;

	protected RaceData umaRace;

	public UMADataEvent CharacterCreated;

	public UMADataEvent CharacterDestroyed;

	public UMADataEvent CharacterUpdated;

	public bool rebuildSkeleton;

	public static bool ReleaseDataOnRaceChange;

	public string override1PSlotName;

	public UMAMaterial source1PMaterial;

	public UMAMaterial override1PMaterial;

	public bool m_IsForceChangeRace;

	private string overrideDecalPropertyName;

	protected Texture overrideDecalTexture;

	protected uint overrideDecalClothId;

	protected int overrideDecalRecipeHash;

	protected bool m_UpdateWeaponFlag;

	public UMAData UmaData => null;

	public RaceData[] AvailableRaces => null;

	public OverlayColorData[] CurrentSharedColors => null;

	public void SetForceChangeRace()
	{
	}

	public void SetUpdateWeaponFlag(bool flag)
	{
	}

	public bool GetUpdateWeaponFlag()
	{
		return false;
	}

	public virtual void Awake()
	{
	}

	public virtual void Initialize()
	{
	}

	public virtual UMAContextIndividual UseIndividualContextCache(SlotOverlayAssetCache cache)
	{
		return null;
	}

	public GameObject GetGameObject()
	{
		return null;
	}

	public void ForceUpdate(bool DnaDirty, bool TextureDirty = false, bool MeshDirty = false)
	{
	}

	public void UpdateSameRace()
	{
	}

	public void UpdateNewRace()
	{
	}

	public void SetEnableMipMap(bool enableMipMap)
	{
	}

	public void SetEnableRenderTexturePool(bool flag)
	{
	}

	public void SetTextureScaleFactor(int scale)
	{
	}

	public void SetNormalSpecTexScale(float scale)
	{
	}

	public void SetUpdateWhenOffSceen(bool flag)
	{
	}

	public void SetNeedGenerateMesh(bool needMesh)
	{
	}

	public void SetUsingRGB565(bool needMesh)
	{
	}

	public void SetAtlasResolutionScale(float scale)
	{
	}

	public void SetNoMergeTexture(bool noMerge)
	{
	}

	public void SetNoClothMergeTexture(bool noMerge)
	{
	}

	public void SetNoSkinMergeWithCondition(bool noMerge)
	{
	}

	public void SetUpdateTextureSizeByChannelType(bool update)
	{
	}

	protected void SetBaseOverlayLimitSize(RaceData racedata)
	{
	}

	protected void SetOverlayLimitSize(int limitSize, UMAData.UMARecipe cachedRecipe, bool ignoreSkin = false)
	{
	}

	public static void SetOverlayLimitSize(int limitSize, SlotData s, bool ignoreSkin = false)
	{
	}

	public virtual void EnableDebugLog(bool enable)
	{
	}

	public virtual void SetVisible(bool visible)
	{
	}

	public void SetMaskColors(Color[] mask, Color[] additive, bool updateTexture = false)
	{
	}

	protected void Override1PSlotMaterials()
	{
	}

	public void SetOverrideDecalTexture(Texture tex, uint clothId, int recipeHash)
	{
	}

	protected void ApplyDecalOverrideIfAny(IList<SlotData> slots, int slotStart, int slotEnd, uint recipeId)
	{
	}

	protected void CleanMeshForRebuildSkeleton()
	{
	}

	protected void RemoveUGCHidenSlots()
	{
	}
}
