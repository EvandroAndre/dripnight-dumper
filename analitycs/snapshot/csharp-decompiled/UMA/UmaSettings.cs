namespace UMA;

public static class UmaSettings
{
	public static bool LogError;

	public static bool LogDetail;

	public static bool LogTimes;

	public static bool UsingAvatarSimple;

	public static bool SkipBuildIfNotVisibleV2;

	public static bool SkipBuildIfNotVisible;

	public static bool SkipBuildIfNoVisibleChange;

	public static bool ReAddBaseSlotsWhenWardrobeLoadFailed;

	public static bool PoolSlotOverlayData;

	public static bool PoolSlotOverlayDataFixMatchOverlay;

	public static bool OptBuildGc;

	public static bool FaceFlow;

	public static bool FixNoClothTextureMergeForAdditive;

	public static bool BRUMAHeadSlotsAsyncLoading;

	public static bool FixTexMergeForColorMask;

	public static bool RGB565ForAllShader;

	public const string StrAvatarAssetsDir = "umas/";

	public static readonly int StrAvatarAssetsDirLength;

	public const bool SkipSlotOverlayesItemNames = true;

	public const bool RenameInApkSlotOverlayFileToHashes = true;

	public static bool UseSharedSbStrForSlotOverlayHashNames;

	public static readonly int SlotOverlayHashNameSbCap;

	public static bool UsingPreAsyncLoading;

	public static bool UsingPostAsyncLoading;

	public static bool BuildAfterWardrobeSlotsLoadedProtect;

	public const int MaxAssetCountPerType = 65535;

	public const int MaxSlotsPerRecipe = 15;

	public const int MaxOverlaysPerSlot = 1;

	public const int MaxAdditiveSlotsPerRecipe = 7;

	public const bool SaveAdditiveInfoInRecipeBytes = false;

	public const bool SortReplaceSlotToFront = true;

	public const bool SortReplaceSlotToTail = true;

	public const int EnumInvalidBits = 1;

	public static bool EnableDecompressDataNoGC;

	public static bool UsingSetBoneWeights;

	public static bool UsingSetBoneWeights2;

	public static bool UsingBindPosesList;

	public static bool UsingUnloadFromGfxDevice;

	public static string[] RaceNames;

	public static string[] RaceRecipes;

	public static string[] BaseSlotNames;

	public static string[] WardrobeSlotNames;

	public static bool UsingAsyncLoading => false;
}
