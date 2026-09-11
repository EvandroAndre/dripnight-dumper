using System;
using System.Collections.Generic;
using COW.GamePlay;
using UnityEngine;

namespace UMA;

public class UMAData : MonoBehaviour
{
	public enum EffectType
	{
		EFFECTTYPE_NONE,
		EFFECTTYPE_GOD,
		EFFECTTYPE_FROZEN,
		EFFECTTYPE_FREESTYLE,
		EFFECTTYPE_SNOWBALLFROZEN
	}

	public enum DynamicBoneType
	{
		None,
		DynamicBone,
		Flux
	}

	public delegate void CharacterUpdatedDelgate(UMAData umaData);

	public delegate void CharacterBeginCreationDelgate(UMAData umaData);

	[Serializable]
	public class GeneratedMaterials
	{
		public List<GeneratedMaterial> materials;

		public static List<GeneratedMaterial> EmptyMaterials;
	}

	[Serializable]
	public class GeneratedMaterial
	{
		public UMAMaterial umaMaterial;

		public Material material;

		public List<MaterialFragment> materialFragments;

		public Texture[] resultingAtlasList;

		public Vector2 cropResolution;

		public float resolutionScale;

		public string[] textureNameList;

		public float normalHeightRatio;

		public float normalWidthRatio;

		public float textureHeightRatio;

		public float textureWidthRatio;

		public bool noMerge;

		public void Reset()
		{
		}
	}

	[Serializable]
	public class MaterialFragment
	{
		public int size;

		public Color baseColor;

		public UMAMaterial umaMaterial;

		public Rect[] rects;

		public textureData[] overlays;

		public Color32[] overlayColors;

		public Color[][] channelMask;

		public Color[][] channelAdditiveMask;

		public SlotData slotData;

		public OverlayData[] overlayData;

		public Rect atlasRegion;

		public bool isRectShared;

		public List<OverlayData> overlayList;

		public MaterialFragment rectFragment;

		public textureData baseOverlay;

		public int width;

		public int height;

		public float channelTypeNormalWidthRatio;

		public float channelTypeNormalHeightRatio;

		public float channelTypeTextureWidthRatio;

		public float channelTypeTextureHeightRatio;

		public Color GetMultiplier(int overlay, int textureType)
		{
			return default(Color);
		}

		public Color32 GetAdditive(int overlay, int textureType)
		{
			return default(Color32);
		}

		public void Reset()
		{
		}
	}

	[Serializable]
	public class textureData
	{
		public Texture[] textureList;

		public Texture alphaTexture;

		public OverlayDataAsset.OverlayType overlayType;

		public void Reset()
		{
		}
	}

	[Serializable]
	public class UMARecipe
	{
		public RaceData raceData;

		protected Dictionary<string, int> mergedSharedColors;

		public SlotData[] slotDataList;

		public OverlayColorData[] sharedColors;

		public bool Validate()
		{
			return false;
		}

		public void SetRace(RaceData raceData)
		{
		}

		public RaceData GetRace()
		{
			return null;
		}

		public void SetSlot(int index, SlotData slot)
		{
		}

		public void SetSlots(SlotData[] slots)
		{
		}

		public void MergeSlot(SlotData slot, bool dontSerialize)
		{
		}

		public SlotData GetSlot(int index)
		{
			return null;
		}

		public SlotData[] GetAllSlots()
		{
			return null;
		}

		public int GetSlotArraySize()
		{
			return 0;
		}

		public static bool OverlayListsMatch(List<OverlayData> list1, List<OverlayData> list2)
		{
			return false;
		}

		public void MergeMatchingOverlays()
		{
		}

		public UMARecipe Mirror()
		{
			return null;
		}

		public void Merge(UMARecipe recipe, bool dontSerialize)
		{
		}
	}

	public static bool OptimizeMeshMemory;

	public SkinnedMeshRenderer myRenderer;

	public HashSet<Renderer> EffectForceShowRenderers;

	[NonSerialized]
	public uint avatarId;

	[NonSerialized]
	public bool isSharedModel;

	[NonSerialized]
	public bool isUsingSharedTex;

	[NonSerialized]
	public bool isUsingSharedMesh;

	[NonSerialized]
	public bool firstBake;

	[NonSerialized]
	public bool GenerateMeshSkipped;

	[NonSerialized]
	public bool SkipBuildIfNoVisibleChangedSlots;

	public UMAGeneratorBase umaGenerator;

	[NonSerialized]
	public GeneratedMaterials generatedMaterials;

	private LinkedListNode<UMAData> listNode;

	public float atlasResolutionScale;

	public bool atlasRelease;

	public bool meshRelease;

	public bool isMeshDirty;

	public bool isShapeDirty;

	public bool isTextureDirty;

	public bool isAtlasDirty;

	public BHGGAEEHJCO playerid;

	public bool isLocalPlayer;

	public bool isTeammate;

	public bool isCastShadow;

	private bool _isHideHead;

	private bool _isHideHeadChanged;

	public bool noTextureMerge;

	public bool noClothTextureMerge;

	public bool noSkinMergeWithCondition;

	public bool updateTextureSizeByType;

	public bool isBone2;

	[NonSerialized]
	public DynamicBoneType dynamicBoneType;

	[NonSerialized]
	public bool dynamicBoneAnimatePhysicsMode;

	[NonSerialized]
	public HangString.StringType hangStringType;

	public bool ignoreBlendShapes;

	public bool updateWhenOffsceen;

	public EffectType effectType;

	public string m_OverrideShaderName;

	private HELBFMHHPBI m_OverrideMaterialPropertyInfo;

	private Dictionary<int, HELBFMHHPBI> m_DefaultMaterialPropertyInfo;

	private int? m_OverrideRenderQ;

	private bool m_OverrideRenderQIgnoreTransparentLimit;

	private Dictionary<int, int> m_DefaultRenderQ;

	public RuntimeAnimatorController animationController;

	private Dictionary<int, int> animatedBonesTable;

	public Animator mAnimator;

	public bool m_IsLocalPlayerUma;

	public bool m_EnableLocalPlayerCullingModeAlwaysAnim;

	public bool m_ForceAnimatorAlwaysAnimate;

	public bool isThermalView;

	public bool isPlanarShadow;

	public bool isManuallyTickAnimator;

	private bool _003Ccancelled_003Ek__BackingField;

	[NonSerialized]
	public bool dirty;

	[NonSerialized]
	public bool breakUpdate;

	private bool isOfficiallyCreated;

	public CharacterUpdatedDelgate OnCharacterUpdatedFixed;

	public CharacterBeginCreationDelgate OnCharacterBeginCreation;

	public UMADataEvent CharacterCreated;

	public UMADataEvent CharacterDestroyed;

	public UMADataEvent CharacterUpdated;

	public GameObject umaRoot;

	public UMARecipe umaRecipe;

	public Animator animator;

	public UMASkeleton skeleton;

	public float characterHeight;

	public float characterRadius;

	public float characterMass;

	private bool textureReady;

	private bool meshReady;

	public bool enableMipmap;

	public bool usingRendertargetPool;

	public int textureScale;

	public float normalSpecTexScale;

	private bool mIsPausedDuringGenerating;

	public bool needGenerateMesh;

	public bool usingRGB565;

	public static int PauseFrameCount;

	public bool isUseSpecialAnimCtrl;

	public bool isRed;

	private List<Texture> backUpTexture;

	public Color[] maskColors;

	public Color[] maskAdditiveColors;

	private bool m_Hide;

	private bool m_releaseResource;

	private bool m_HasPendingDirtyData;

	private static int m_ColorEffectParamID;

	private static List<Material> m_ChangeShaderMaterialsCached;

	private static List<Material> m_MaterialsCache;

	public bool isHideHead
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool isHideHeadChanged => false;

	public bool cancelled
	{
		get
		{
			return _003Ccancelled_003Ek__BackingField;
		}
		private set
		{
			_003Ccancelled_003Ek__BackingField = value;
		}
	}

	public event Action<UMAData> OnCharacterCreated
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<UMAData> OnCharacterDestroyed
	{
		add
		{
		}
		remove
		{
		}
	}

	public void SetRendererEnable(bool enable)
	{
	}

	public void MoveToList(LinkedList<UMAData> list)
	{
	}

	public void resetHideHeadChanged()
	{
	}

	public void ResetAnimatedBones()
	{
	}

	public void RegisterAnimatedBone(int hash)
	{
	}

	public void RegisterAnimatedBoneHierarchy(int hash)
	{
	}

	private void Awake()
	{
	}

	private void EnsureGenerator()
	{
	}

	public void SetupOnAwake()
	{
	}

	public bool Validate()
	{
		return false;
	}

	public bool UMAReady()
	{
		return false;
	}

	public void FireUpdatedEvent(bool cancelled)
	{
	}

	public virtual void Dirty()
	{
	}

	private void AddToDirtyUMA()
	{
	}

	public bool NeedGenerateCombinedMesh()
	{
		return false;
	}

	public bool IsVisible()
	{
		return false;
	}

	public void VisibilitySwitch(bool v, bool releaseResource = false)
	{
	}

	public void SetUMARendererActive(bool active)
	{
	}

	public void SetUMARendererMaterial(Material material)
	{
	}

	private void OnDestroy()
	{
	}

	public void ClearSlotOverlays()
	{
	}

	public void ClearGeneratedMaterialsForUnload()
	{
	}

	public void CleanAvatar()
	{
	}

	public void CleanTextureSingle(Texture tempTexture)
	{
	}

	public void CleanTextures()
	{
	}

	public void ClearImplicitTextureRefsBeforeUnload()
	{
	}

	public void CleanMesh(bool destroyRenderer)
	{
	}

	public void ReleaseMesh()
	{
	}

	public void SetMaskColors(Color[] mask, Color[] additive)
	{
	}

	public void backUpTextures()
	{
	}

	public void CleanBackUpTextures()
	{
	}

	public void Dirty(bool dnaDirty, bool textureDirty, bool meshDirty)
	{
	}

	public SlotData GetSlot(int index)
	{
		return null;
	}

	public int GetSlotArraySize()
	{
		return 0;
	}

	public void GotoTPose()
	{
	}

	public void FireCharacterBegunEvents()
	{
	}

	public void FireCharacterCompletedEvents()
	{
	}

	public void AddAdditionalRecipes(UMARecipeBase[] umaAdditionalRecipes, UMAContext context)
	{
	}

	public void SetMeshReady()
	{
	}

	public void SetTextureReady()
	{
	}

	private void OnApplicationPause(bool paused)
	{
	}

	public void SetAnimator(Animator amtr, bool isLocalPlayer = false, bool Enable1PCullingmodeAlwaysAnim = false)
	{
	}

	public void SetForceAnimatorAlwaysAnimate(bool force)
	{
	}

	public void UpdateRenderVisible(bool visible)
	{
	}

	public void SetUpdateWhenOffSceen(bool flag)
	{
	}

	public void SwitchEffect(EffectType effect)
	{
	}

	public static void ChangeRenderEffect(SkinnedMeshRenderer renderer, EffectType effect)
	{
	}

	public void SetAvatartColor(Color color)
	{
	}

	public bool GetMeshBounds(ref Bounds bound)
	{
		return false;
	}

	private void OverrideShaderAfterUMAReady()
	{
	}

	public void SetShader(string shaderPath, HELBFMHHPBI overrideProperty = null, bool force = false, Shader overrideShader = null)
	{
	}

	public void RevertToDefaultShader()
	{
	}

	public void RevertToDefaultShaderInternal(bool clearOverrideShaderInfo)
	{
	}

	public void SetRenderQ(int renderQ, bool force = false, bool ignoreTransparentLimit = false)
	{
	}

	public void RevertToDefaultRenderQ()
	{
	}

	public void RevertToDefaultRenderQInternal(bool clearOverrideInfo)
	{
	}

	public void ClearCallbacks()
	{
	}
}
