using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class FrontEndPreviewAvatarCreator : FrontEndPreviewBaseCreator
{
	private sealed class _003C_003Ec__DisplayClass62_0
	{
		public FrontEndPreviewAvatarCreator _003C_003E4__this;

		public UIMaleAvatar targetavatar;

		public WeaponSkinData lData;

		public AFOLPMOCBOG cData;

		internal void _003CSetWeaponSkinToAvatar_003Eb__0()
		{
		}
	}

	protected UIMaleAvatar m_PreviewCachedAvatar;

	protected UIMaleAvatar m_PreviewAvatar;

	protected UIMaleAvatar m_PreviewAvatar2P;

	protected UIMaleAvatar m_PreviewSpecialAvatar;

	protected FrontEndPreviewAvatarParams m_PreviewAvatarParams;

	private uint _003CCurrentAvatarID_003Ek__BackingField;

	private uint _003CCurrentSelectedClothID_003Ek__BackingField;

	public const float PLAY_ACTION_IDLE_DELTA_TIME = 4f;

	private UIMaleAvatar m_MultiFlightMovePreviewDriverAvatar;

	private bool m_GachaEmoteOverrideApplied;

	public UIMaleAvatar PreviewCachedAvatar => null;

	public UIMaleAvatar PreviewAvatar => null;

	public UIMaleAvatar PreviewAvatar2P => null;

	public UIMaleAvatar PreviewSpecialAvatar => null;

	public uint CurrentAvatarID
	{
		get
		{
			return _003CCurrentAvatarID_003Ek__BackingField;
		}
		private set
		{
			_003CCurrentAvatarID_003Ek__BackingField = value;
		}
	}

	public uint CurrentSelectedClothID
	{
		get
		{
			return _003CCurrentSelectedClothID_003Ek__BackingField;
		}
		private set
		{
			_003CCurrentSelectedClothID_003Ek__BackingField = value;
		}
	}

	public override void Init(FrontEndPreviewComponent comp, UIBaseController parentCtrl, FrontEndPreviewContentCreator creator, GameObject groundShadow)
	{
	}

	public override void OnTempHidePreview()
	{
	}

	public override void OnClosePreview()
	{
	}

	protected override FrontEndPreviewComponent.Cameratype GetPreviewCameratype()
	{
		return FrontEndPreviewComponent.Cameratype.None;
	}

	public void ClearCache(bool clearPreviewCachedAvatar = false, bool clearPreviewAvatar = true)
	{
	}

	public new void ClearPreview3DItem()
	{
	}

	private void ClearPreviewCachedAvatar()
	{
	}

	public void ClearPreviewAvatar()
	{
	}

	public void ClearSpecialAvatar()
	{
	}

	private void ResetAvatar(UIMaleAvatar avatar)
	{
	}

	public void ResetPreviewCachedAvatarDir()
	{
	}

	private void HideAvatar(UIMaleAvatar avatar)
	{
	}

	public void SkipSpecialAnim()
	{
	}

	public void ShowAvatarByClothList(uint avatarID, List<uint> clothList, FrontEndPreviewComponent.AvatarType type = FrontEndPreviewComponent.AvatarType.localAvatar, bool playanim = true, uint weaponID = 0u, bool needCheckClothEffectUnlock = true, uint clothEffectItemID = 0u, HashSet<uint> unLockClothEffectItemIds = null, bool isForceShowDefaultSkin = false, bool needAddLobbyCloth = false, bool needKeepHairWhenSameAvatarId = false, uint selectedClothID = 0u, PreviewBackpackParams backpackParams = null, uint? skinColor = null, ulong accountID = 0uL)
	{
	}

	public void ShowWeaponSkinWithAvatar(List<uint> idlist, uint weaponSkinid)
	{
	}

	public void ShowPreviewAvatarWithCar(List<uint> idlist, GameObject carGo)
	{
	}

	private void ModifyAvatarTransToFitCar(UIMaleAvatar avatar, GameObject carGo)
	{
	}

	public void SetDoubleCharcterRootScaleAndSkinVisble(uint avatarIndex)
	{
	}

	public void ShowAvatarWithItem(uint id, CSSharedItemData itemData, ECollectionLevel level = ECollectionLevel.Lv3, bool needAddLobbyCloth = false)
	{
	}

	public void ShowTransformerWithAnimAvatar(uint id, bool isCheckLowestDisplay = true, bool needShowAnimAvatar = true, bool loop = true, int animIndex = 0, bool isAutoPlayAfterSingleAnim = false)
	{
	}

	public void ShowGroupAnimWithAnimAvatar(uint id, bool isCheckLowestDisplay = true, bool needShowAnimAvatar = true, bool playIdleAlternate = true, bool forceNotPlayIdleAlternate = false, bool showMvpAnim = false)
	{
	}

	public void ShowEmoteWithAnimAvatar(uint id, bool isCheckLowestDisplay = true, bool needShowAnimAvatar = true, bool playIdleAlternate = true, bool showEmoteCameraAnim = false)
	{
	}

	private void ApplyGachaEmoteCameraOverride(uint emoteId)
	{
	}

	public void ShowSuperEmoteWithAnimAvatar(uint id, bool isCheckLowestDisplay = true, bool needShowAnimAvatar = true, bool playIdleAlternate = true)
	{
	}

	public void ShowFinishMoveWithAnimAvatar(uint id, bool isCheckLowestDisplay = true, bool needShowAnimAvatar = true, bool playIdleAlternate = true)
	{
	}

	private void RefreshCameraShow(bool show)
	{
	}

	public void ShowMotionWithAnimAvatar(uint id, bool needShowAnimAvatar = true, bool isCheckLowestDisplay = true, bool playIdleAlternate = true)
	{
	}

	public void ShowEmotionAnimationWithAnimAvatar(uint id, bool needShowAnimAvatar = true, bool isCheckLowestDisplay = true)
	{
	}

	public void ShowParachuteAnimWithAnimAvatar(ResourceID[] resid, bool needShowAnimAvatar = true, bool isCheckLowestDisplay = true, bool playIdleAlternate = true)
	{
	}

	public void ShowFootHaloAnimWithAnimAvatar(ResourceID[] resid, bool needShowAnimAvatar = true, bool isCheckLowestDisplay = true, bool playIdleAlternate = true)
	{
	}

	public void ShowSkillEffectWithAnimAvatar(uint id, bool needShowAnimAvatar = true, bool isCheckLowestDisplay = true)
	{
	}

	public void ShowFlyMoveWithAnimAvatar(uint id, bool needShowAnimAvatar = true, bool isCheckLowestDisplay = true)
	{
	}

	private void ClearMultiFlightMovePreview()
	{
	}

	private bool ShouldDisableMultiFlightMovePreviewInput()
	{
		return false;
	}

	private void ShowAnimAvatar()
	{
	}

	public void ShowAvatarWithLobbyClothes(FrontEndPreviewComponent.AvatarType type = FrontEndPreviewComponent.AvatarType.AvatarWithCache)
	{
	}

	private void ShowWeaponSkinWithAnimAvatar(uint weaponSkinID)
	{
	}

	private void ShowFinalShotWithAnimAvatar(uint finalShotID)
	{
	}

	private void SetWeaponSkinToAvatar(UIMaleAvatar targetavatar, uint weaponSkinID)
	{
	}

	private void FistAnimCallBack(UIMaleAvatar targetavatar, WeaponSkinData lData, AFOLPMOCBOG cData)
	{
	}

	public bool CheckIsDualWield(uint weaponid)
	{
		return false;
	}

	private void RefreshRuntimeAnimatorCtrl(UIMaleAvatar avatar)
	{
	}

	private void CreatePreviewAvatarWithCache(uint avatarID, List<uint> clothList, bool playanim, uint clothEffectItemID, HashSet<uint> unLockClothEffectItemIds, bool needAddLobbyCloth, uint selectedCloth, PreviewBackpackParams backpackParams, uint? skinColor = null, ulong accountId = 0uL)
	{
	}

	private void CreatePreviewAvatarWithNoCache(uint avatarID, List<uint> clothList, bool playAnimation, uint clothEffectItemID, HashSet<uint> unLockClothEffectItemIds, bool needAddLobbyCloth, uint selectedCloth, PreviewBackpackParams backpackParams, uint? skinColor = null)
	{
	}

	private void CreatePreviewSpecialAvatar(uint avatarID, List<uint> clothList, bool playAnimation, uint clothEffectItemID, HashSet<uint> unLockClothEffectItemIds, bool needAddLobbyCloth, uint selectedCloth, PreviewBackpackParams backpackParams, uint? skinColor = null)
	{
	}

	private UIMaleAvatar CreateAvatar(List<uint> idlist, Vector3 scale, Vector3 pos, bool playSpecial, bool changanim = true, int doubleAnimid = 0, string resSpecial = "", string resIdle = "", bool uselight = true, uint avatarIndex = 1u, bool playIdleAlternative = false, uint clothEffectItemID = 0u, HashSet<uint> unLockClothEffectItemIds = null, Vector3 roation = default(Vector3), bool needAddLobbyCloth = false, uint selectedCloth = 0u, PreviewBackpackParams backpackParams = null, uint? skinColor = null, ulong accountID = 0uL)
	{
		return null;
	}

	private void PreviewClothes(uint avatarId, List<uint> clothIDList, uint selectedClothID, UIMaleAvatar avatarmodel, bool playanim, uint clothEffectItemID, HashSet<uint> unlockClothEffectItemIDList, bool needAddLobbyCloth = false, bool needKeepHairWhenSameAvatarId = false, PreviewBackpackParams backpackParams = null, uint? skinColor = null)
	{
	}

	public void ShowBackPackWithAvatar(uint backPackID, ECollectionLevel level = ECollectionLevel.Lv3)
	{
	}

	private void CreateAvatarWithBackPack(List<uint> idlist, uint backPackID, ECollectionLevel level)
	{
	}

	private void ProcessAvatarWithBackpack(ref UIMaleAvatar avatar)
	{
	}

	public void CreatePreviewDoubleAvatarAnim(FullScreenAnimParams animParams)
	{
	}

	public void CreateDoublePreviewAvatar(PlayDoubleAvatarAnimParams param, bool needCheckClothEffectUnlock)
	{
	}

	public void PlayPreviewDoubleAvatarAnim()
	{
	}

	private UIMaleAvatar CreatePreview2PAvatar(List<uint> idlist, Vector3 scale, Vector3 pos, Vector3 quater, int doubleAnimid, string specialAnimid, string idleAnimid, bool uselight, uint avatarIndex, HashSet<uint> unlockEffectItemIds = null)
	{
		return null;
	}

	public List<uint> GetLobbyClothesList()
	{
		return null;
	}

	public UIMaleAvatar GetCreatedAvatar()
	{
		return null;
	}

	public void SetAllPreviewAvatarSpecialIdle()
	{
	}

	public void StopAvatarAnim(bool resetOverrideIdleAnim = true, bool stopForZoomIn = false)
	{
	}

	public void SetPreviewAvatarLightVisble(bool flag)
	{
	}

	public override void OnSwitchCamera(FrontEndPreviewComponent.Cameratype type)
	{
	}

	public void CacheAvatarAnimtorSwitch(bool enabled)
	{
	}

	private void ResetCameraRotation()
	{
	}

	public float GetBoostCameraPosX(Vector3 cameraStartPos, bool isBelow = false)
	{
		return 0f;
	}

	protected override void AutoShift3DPreview(ref GameObject go, float scalex, float scaley, bool useY, bool calcaulateCenterPriviewAnchorPoint = true, float offsetX = 0f)
	{
	}

	public void AutoModifyModelOnPreviewBorderChange()
	{
	}

	private void ForceAutoModifyAvatarPosOnPreviewBorderChange()
	{
	}

	public void ForceAutoModifyDoubleAvatarPos()
	{
	}

	public void ForceAutoModifyDoubleAvatarPos(Vector3 left, Vector3 right)
	{
	}

	protected void AutoModifyPreviewModelAccordingToResolution(ref GameObject go, float scaley, Vector3 pos)
	{
	}

	private void RefreshSpecialBgEffect(List<uint> clothesId)
	{
	}

	public void _003C_003EiFixBaseProxy_Init(FrontEndPreviewComponent P0, UIBaseController P1, FrontEndPreviewContentCreator P2, GameObject P3)
	{
	}

	public void _003C_003EiFixBaseProxy_OnTempHidePreview()
	{
	}

	public void _003C_003EiFixBaseProxy_OnClosePreview()
	{
	}

	public FrontEndPreviewComponent.Cameratype _003C_003EiFixBaseProxy_GetPreviewCameratype()
	{
		return FrontEndPreviewComponent.Cameratype.None;
	}

	public void _003C_003EiFixBaseProxy_OnSwitchCamera(FrontEndPreviewComponent.Cameratype P0)
	{
	}

	public void _003C_003EiFixBaseProxy_AutoShift3DPreview(ref GameObject P0, float P1, float P2, bool P3, bool P4, float P5)
	{
	}
}
