using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UMA.Simple;
using UnityEngine;
using proto;

namespace COW;

public class UIModelAvatar : UIModelAvatarBase
{
	private enum AbReadyState
	{
		NoResId,
		NoAb,
		AbReady,
		AbNotReady,
		LoadFailed
	}

	private sealed class _003C_003Ec__DisplayClass56_0
	{
		public UIModelAvatar _003C_003E4__this;

		public Action callback;

		public bool uselog;

		public uint slotid;

		public CSChangeClothesReq req;

		internal void _003CRequestChooseClothWithCallback_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass59_0
	{
		public uint avatarID;

		public UIModelAvatar _003C_003E4__this;

		public bool refreshState;

		public bool cloneBeforeRequest;

		public Action callback;

		public CSChangeClothesReq req;

		internal void _003CRequestNewChooseCloth_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass60_0
	{
		public uint avatarID;

		public UIModelAvatar _003C_003E4__this;

		public bool refreshState;

		public bool cloneBeforeRequest;

		public CSChangeClothesReq req;

		internal void _003CRequestChooseCloth_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private static Dictionary<string, List<string>> m_TempDict;

	public static Dictionary<int, bool> CachedRecipeReadyList;

	private Dictionary<int, List<CSSharedAvatarData>> m_DictBackpackAvatar;

	private Dictionary<int, List<InventoryClothInfo>> m_DictBackpackCloth;

	private Dictionary<uint, AvatarData> m_Avatars;

	private AvatarData m_CurrentAvatar;

	private AvatarData m_CachedAvatar;

	private uint m_FemaleDefaultModifyId;

	private uint m_MaleDefaultModifyId;

	private uint m_CacheAvatarId;

	private float m_CacheAvatarColor;

	private UIAvatarWindowController.AvatarSetting m_lobbyAvatarSetting;

	private UIAvatarWindowController.AvatarPetSetting m_lobbyPetSetting;

	public AvatarData CurrentAvatarData => null;

	public override void Login(object[] data)
	{
	}

	public void RefreshDefaultModelId(GetOppositeSexModelRes res)
	{
	}

	public uint GetDefaultModelId(bool isfamale)
	{
		return 0u;
	}

	public override void Logout(object[] data)
	{
	}

	protected override void OnSceneChange(object[] data)
	{
	}

	public static void ClearCachedRecipeReadyDict()
	{
	}

	public Dictionary<int, List<CSSharedAvatarData>> GetBackpackAvatarDict()
	{
		return null;
	}

	public Dictionary<int, List<InventoryClothInfo>> GetBackpackClothDict()
	{
		return null;
	}

	public bool HasCurrentAvatar()
	{
		return false;
	}

	public uint GetAvatarID()
	{
		return 0u;
	}

	public bool IsSelfFemale()
	{
		return false;
	}

	public EHairType SelfHairType()
	{
		return EHairType.HAIRTYPENONE;
	}

	public string GetBaseRaceName()
	{
		return null;
	}

	public static string GetBaseRaceName(EGenderType t, bool useHigh = true)
	{
		return null;
	}

	public float GetSkinColorNormalized()
	{
		return 0f;
	}

	public float GetSkinColorNormalizedByAvatarID(uint avatarID)
	{
		return 0f;
	}

	public float GetDefaultSkinColor()
	{
		return 0f;
	}

	public Dictionary<int, uint> GetCurrentClothDict()
	{
		return null;
	}

	public Dictionary<int, uint> GetCachedClothDict()
	{
		return null;
	}

	public Dictionary<int, uint> GetCurrentClothDict(uint avatarId)
	{
		return null;
	}

	public uint GetCurrentHair()
	{
		return 0u;
	}

	public bool IsClothesIdsTheSameWithCurrent(List<uint> clothesList)
	{
		return false;
	}

	public bool CheckHasClothesSetInCurrentAvatar()
	{
		return false;
	}

	public UIAvatarWindowController.AvatarSetting GetLobbyAvatarSetting()
	{
		return null;
	}

	public UIAvatarWindowController.AvatarPetSetting GetLobbyPetSetting()
	{
		return null;
	}

	public void UpdateAvatarList(proto.AvatarProfile[] avatarList)
	{
	}

	public void UpdateAvatar(proto.AvatarProfile avatar)
	{
	}

	public void AfterGetBackPack(Dictionary<int, List<CSSharedAvatarData>> dictAvatar, Dictionary<int, List<InventoryClothInfo>> dictWardrobe)
	{
	}

	public void UpdateCurAvatarId(uint id)
	{
	}

	public void LocalSaveAvatarColor(uint v)
	{
	}

	public bool RemoveSetSlotInNeed(AvatarWardrobeData data)
	{
		return false;
	}

	public bool CheckHasConFlict(AvatarWardrobeData data, uint targetItemID, bool removeSuppress = true)
	{
		return false;
	}

	public bool RemoveConflictSlotInNeed(AvatarWardrobeData data, bool removeSuppress = false)
	{
		return false;
	}

	public static bool CheckHelmetHide(uint dataId, FrontEndPreviewComponent frontEndPreviewComponent)
	{
		return false;
	}

	public static bool CheckVestHide(uint dataId, FrontEndPreviewComponent frontEndPreviewComponent)
	{
		return false;
	}

	public static bool CheckHasFace(uint dataId, FrontEndPreviewComponent frontEndPreviewComponent)
	{
		return false;
	}

	public void LocalSaveClothData(AvatarWardrobeData data)
	{
	}

	public void LocalSaveClothData(uint avatarID, AvatarWardrobeData data)
	{
	}

	public void LocalClearClothData(uint avatarID)
	{
	}

	public bool CheckClothIsEquipInAvatar(uint clothID)
	{
		return false;
	}

	public void RequestChooseAvatar()
	{
	}

	public void RequestChooseClothWithCallback(Action callback, bool uselog = false, uint slotid = 0u)
	{
	}

	public void RefreshAvatarDataToServer()
	{
	}

	public uint TransfromFakeItemIdToAvatarId(uint id)
	{
		return 0u;
	}

	public void RequestNewChooseCloth(uint avatarID = 0u, bool cloneBeforeRequest = true, bool refreshState = false, Action callback = null)
	{
	}

	public void RequestChooseCloth(uint avatarID = 0u, bool cloneBeforeRequest = true, bool refreshState = false)
	{
	}

	private bool CheckClothesCanChange(uint[] clothes)
	{
		return false;
	}

	private int GetClothesHighestRankUseLevel(uint[] clothes)
	{
		return 0;
	}

	private void SetHighestRankUseLevel(uint clothID, ref int highestRankUseLevel)
	{
	}

	public void CacheAvatarSkinColor(uint avatarID, float color)
	{
	}

	public void SendCacheAvatarSkinColor(bool refresh = false)
	{
	}

	private uint GetOrginSkinColor(uint avatarID)
	{
		return 0u;
	}

	public void SetAvatarSkinColor(uint avatarID, float color)
	{
	}

	private void ShowNotReachRankItemUseLevelTips(int rankLevel)
	{
	}

	public Dictionary<uint, AvatarData> GetAvatars()
	{
		return null;
	}

	public void SetLobbyAvatarSetting(UIAvatarWindowController.AvatarSetting setting)
	{
	}

	public void SetLobbyPetSetting(UIAvatarWindowController.AvatarPetSetting setting)
	{
	}

	public bool IsFemaleInvalid(uint itemId)
	{
		return false;
	}

	public bool CheckIsInvisibleSkill(uint itemid)
	{
		return false;
	}

	public bool CanEquipCloth(CSSharedItemData itemData, uint avatarid = 0u)
	{
		return false;
	}

	public bool CanEquipCloth(uint itemId, uint avatarid = 0u)
	{
		return false;
	}

	private static void LogRecipeAbReadyError(string s)
	{
	}

	private static void LogRecipeAbReadyError(string s, UMATextRecipe recipe)
	{
	}

	public static void GetRecipeResID(int recipe, ref List<ResourceID> not_download_res_list, bool skipDownloadedCheck = false, bool needAll = false)
	{
	}

	public static void GetRecipeResID(UMATextRecipe recipe, ref List<ResourceID> not_download_res_list, bool skipDownloadedCheck = false, bool needAll = false)
	{
	}

	public static void GetRecipeResID(UmaRecipeSimple recipe, ref List<ResourceID> not_download_res_list, bool skipDownloadedCheck = false, bool needAll = false)
	{
	}

	public static void LoadRecipeAssets(int recipe)
	{
	}

	public static bool IsRecipeAbReady(uint itemID, AvatarWardrobeData wData, uint avatarId, bool isFemale, bool highquality, bool checkLoad, UMAContextSimple context = null)
	{
		return false;
	}

	public static bool IsRecipeAbReady(int recipe, bool checkLoad = false, bool forAsync = false, UMAContextSimple context = null)
	{
		return false;
	}

	private static bool CheckRecipeAbReady(UMAContextSimple context, UMATextRecipe recipe, bool checkLoad = false)
	{
		return false;
	}

	private static AbReadyState CheckSlotOrOverlayAbState<T>(UMAContextSimple context, string name, bool checkLoad) where T : UnityEngine.Object
	{
		return AbReadyState.NoResId;
	}

	private static bool CheckRecipeAbReady(UMAContextSimple context, UmaRecipeSimple recipe, bool checkLoad = false, bool forAsync = false)
	{
		return false;
	}

	private static bool IsSlotOverlayInSameAb(int slotHash, int overlayHash)
	{
		return false;
	}

	private static AbReadyState CheckSlotOrOverlayAbState(UMAContextSimple context, int hash, bool isSlot, bool checkLoad)
	{
		return AbReadyState.NoResId;
	}

	public bool WeaponResChange(AFOLPMOCBOG data1, AFOLPMOCBOG data2)
	{
		return false;
	}

	public void AvatarPlayEnterTeamAnim(bool playIdleAlternate = false, bool isCheckLowestDisplay = true)
	{
	}

	public bool CanPlayGroupAnim(UIMaleAvatar avatar, bool isFemale, uint groupAnim, bool checkLowestDisplay, out GroupAnimData animData, out ResourceID resID)
	{
		animData = null;
		resID = default(ResourceID);
		return false;
	}

	public void AvatarPlayEnterTeamAnim(UIMaleAvatar avatar, bool isFemale, uint groupAnim, bool playIdleAlternate = false, bool isCheckLowestDisplay = true, bool inGroupAnim = false, bool forceNotPlayIdleAlternate = false, bool showMvpAnim = false, int teamPos = 0)
	{
	}

	public ResourceID GetEnterTeamAnimByGroupAnimRes(UIMaleAvatar avatar, uint groupAnim, bool isFemale)
	{
		return default(ResourceID);
	}

	public List<uint> GetEquipedItemID()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnSceneChange(object[] P0)
	{
	}
}
