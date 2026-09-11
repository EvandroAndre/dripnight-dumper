using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class PreviewAvatarManager
{
	private sealed class _003C_003Ec__DisplayClass28_0
	{
		public FrontEndPreviewComponent frontEndPreviewComponent;

		public uint avatarIndex;

		public UIMaleAvatar avatar;

		public uint clothEffectItemID;

		internal void _003CPreviewClothes_003Eb__0(UIStatedAvatar s)
		{
		}

		internal void _003CPreviewClothes_003Eb__1(UIStatedAvatar s)
		{
		}

		internal void _003CPreviewClothes_003Eb__2()
		{
		}

		internal void _003CPreviewClothes_003Eb__3()
		{
		}

		internal void _003CPreviewClothes_003Eb__4()
		{
		}

		internal void _003CPreviewClothes_003Eb__5()
		{
		}
	}

	public static List<UIMaleAvatar> UImaleAvatarPool;

	public const string FORTUNEIdleAnimId = "INGAME_ANIMATION_COS_FORTUNE_IDLE_MALE";

	public const string PHOENIXAnimId = "INGAME_ANIMATION_COS_PHOENIX_IDLE_FEMALE";

	public const string SanTaGirlSpecialAnimId = "INGAME_ANIMATION_DOUBLEANIM_SANTAGIRL_SPECIAL";

	public const string SanTaGirlIdleAnimId = "INGAME_ANIMATION_DOUBLEANIM_SANTAGIRL_IDLE";

	public const string SanTaBoySpecialAnimId = "INGAME_ANIMATION_DOUBLEANIM_SANTABOY_SPECIAL";

	public const string SanTaBoyIdleAnimId = "INGAME_ANIMATION_DOUBLEANIM_SANTABOY_IDLE";

	private static void AddOptionalClothRes(ResourceID resId, ref List<ResourceID> clothResList, bool needAllClothes)
	{
	}

	public static void GetOptionalClothRes(uint itemID, ref List<ResourceID> cloth_res_list, bool needAllClothes = false)
	{
	}

	public static void GetOptionalClothRes(uint[] item_id_list, ref List<ResourceID> cloth_res_list)
	{
	}

	public static void GetAvatarAllNeedCheckABReadyRes(CSSharedAvatarData aData, List<ResourceID> resList, bool checkIngameResReady = true, bool needAllRes = false)
	{
	}

	public static void GetAvatarAnimationAndClothresRes(CSSharedAvatarData aData, List<ResourceID> resList, bool checkIngameResReady = true, bool needAllRes = false)
	{
	}

	public static bool CheckClothreOptionalResReady(uint clothresId)
	{
		return false;
	}

	public static void GetAvatarFaceRecipeRes(CSSharedAvatarData aData, List<ResourceID> resList, bool checkIngameResReady = true, bool needAllRes = false)
	{
	}

	public static bool CheckAvatarABReady(CSSharedAvatarData aData, EAvatarResCheckPart part = EAvatarResCheckPart.ALL)
	{
		return false;
	}

	public static bool CheckAvatarABReady(uint avatarid, EAvatarResCheckPart part = EAvatarResCheckPart.ALL)
	{
		return false;
	}

	public static bool CheckClothEffectABReady(uint itemID)
	{
		return false;
	}

	public static bool CheckTriggerEffectAnimABReady(ClothTriggerEffectPreviewData data)
	{
		return false;
	}

	public static bool IsClothBundleABReady(uint[] bundles)
	{
		return false;
	}

	public static void ClearAvatarPool()
	{
	}

	public static void RecycleAvatar(UIMaleAvatar avatar)
	{
	}

	private static int GetUsefulAvatarIndex(bool isfemale)
	{
		return 0;
	}

	public static void SetAvatarLightLayer(UIMaleAvatar avatar, string layername, string shadowname)
	{
	}

	public static UIMaleAvatar CreateAvatar(List<uint> idlist, Vector3 scale, Vector3 pos, bool playSpecial, int avatarlighttype = 1, bool changeanim = true, int doubleanimid = 0, string resspecial = "", string residle = "", bool createwithlight = true, uint avatarIndex = 1u, bool playIdleAlternative = false, FrontEndPreviewComponent frontEndPreviewComponent = null, uint clothEffectItemID = 0u, HashSet<uint> unLockClothEffectItemIds = null, Vector3 roation = default(Vector3), bool needAddLobbyCloth = false, uint selectedCloth = 0u, PreviewBackpackParams backpackParams = null, uint? skinColor = null, bool playTriggerEffect = true, ulong accountID = 0uL)
	{
		return null;
	}

	private static void InjectFrontEndPreviewComponent(UIMaleAvatar avatar, FrontEndPreviewComponent frontEndPreviewComponent)
	{
	}

	public static void ResetAvatarDir(UIMaleAvatar avatar)
	{
	}

	public static void SetGameobjectLayer(GameObject avatarobj, int layer)
	{
	}

	public static uint ModifyChangeAvatarId(uint id)
	{
		return 0u;
	}

	public static void PreviewClothes(UIMaleAvatar avatar, uint avatarId, uint selectClothes, uint[] clothes, bool addLobbyClothes, bool playClothesAnim, bool keepHairWhenSameAvatarId, bool changeanim = true, int doubleanimid = 0, bool playTriggerEffect = true, uint avatarIndex = 1u, bool playIdleAlternative = false, FrontEndPreviewComponent frontEndPreviewComponent = null, uint clothEffectItemID = 0u, HashSet<uint> unLockClothEffectItemIds = null, PreviewBackpackParams backpackParams = null, uint? skinColor = null)
	{
	}
}
