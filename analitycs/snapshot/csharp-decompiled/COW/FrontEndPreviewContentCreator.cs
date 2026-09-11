using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class FrontEndPreviewContentCreator
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static ShowBoostAvatarParams.CheckBoostStateDelegate _003C_003E9__78_0;

		internal BoostState _003CShowEpicClothModel_003Eb__78_0(uint id)
		{
			return BoostState.DontChange;
		}
	}

	protected UIBaseController m_ParentController;

	protected FrontEndPreviewComponent m_FrontEndPreviewComponent;

	private FrontEndPreviewAvatarCreator m_AvatarCreator;

	private FrontEndPreviewItemCreator m_ItemCreator;

	protected GameObject m_GroundShadow;

	protected FrontEndPreviewConfigData m_FrontEndPreviewConfigData;

	protected FrontEndPreviewUIConfigData m_FrontEndPreviewUIConfigData;

	protected static FrontEndPreviewConfig m_Preconfig;

	protected FrontEndPreviewAvatarParams m_PreviewAvatarParams;

	protected FrontEndPreviewComponent.Cameratype m_CurrentCameraType;

	private Camera _003CBgCamera_003Ek__BackingField;

	public FrontEndPreviewComponent.Cameratype CurrentCameraType => FrontEndPreviewComponent.Cameratype.None;

	public Camera MixCamera => null;

	public GameObject MixCameraGo => null;

	public Camera ItemCamera => null;

	public GameObject ItemCameraGo => null;

	public Camera BgCamera
	{
		get
		{
			return _003CBgCamera_003Ek__BackingField;
		}
		private set
		{
			_003CBgCamera_003Ek__BackingField = value;
		}
	}

	public GameObject Preview3DItem => null;

	public UIFrontEndPreview2DItemController Preview2DController => null;

	public UIPetAvatar PetAvatar => null;

	public GameObject PreviewCG => null;

	public Quaternion WeaponOriginQuatertion => default(Quaternion);

	public UIMaleAvatar PreviewCachedAvatar => null;

	public UIMaleAvatar PreviewAvatar => null;

	public UIMaleAvatar PreviewAvatar2P => null;

	public GameObject GroundShadow => null;

	public void Init(FrontEndPreviewComponent comp, UIBaseController parentCtrl)
	{
	}

	public void SetPreviewMoveBg(UITexture tex)
	{
	}

	public void SetPreviewBorder(UIWidget border)
	{
	}

	public void SetModelPos(float x, float y)
	{
	}

	public void SetExamplePreviewModelPosX(float x)
	{
	}

	public void ResetExamplePreviewState()
	{
	}

	public void SetItemCreatorExamplePreviewModelPosX(float x)
	{
	}

	public void SetDefaultPetSkin(uint petID, uint skinID)
	{
	}

	public void OnTempHidePreview()
	{
	}

	public void OnClosePreview()
	{
	}

	public void ClearCache(bool closeCG = false, bool clearPreviewCachedAvatar = false, bool clearPreviewAvatar = true)
	{
	}

	public void ClearItemOnly(bool closeCG = false)
	{
	}

	public void Clear3DModel()
	{
	}

	public void ClearResourceRefCache()
	{
	}

	public void SwitchCamera(FrontEndPreviewComponent.Cameratype camType)
	{
	}

	public void ResetAllCamera()
	{
	}

	public void ResetCameraForCameraChangeHelper()
	{
	}

	public void ForceSetCameraType(FrontEndPreviewComponent.Cameratype camType)
	{
	}

	public void CloseAllCamera()
	{
	}

	public void CloseMixCamera()
	{
	}

	public void FocusItemCameraBg()
	{
	}

	public void ReStoreMixcamera()
	{
	}

	public void ShowAvatar(uint avatarID, List<uint> clothList, FrontEndPreviewComponent.AvatarType type = FrontEndPreviewComponent.AvatarType.localAvatar, bool playanim = true, uint weaponID = 0u, bool needCheckClothEffectUnlock = true, uint clothEffectItemID = 0u, HashSet<uint> unLockClothEffectItemIds = null, bool isForceShowDefaultSkin = false, bool needAddLobbyCloth = false, bool needKeepHairWhenSameAvatarId = false, uint selectedClothID = 0u, PreviewBackpackParams backpackParams = null, uint? skinColor = null, ulong accountID = 0uL)
	{
	}

	public void ShowAvatarTransform(uint TransformDataID, int animIndex, bool needShowAnimAvatar = true, bool isAutoPlayAfterSingleAnim = false)
	{
	}

	public void ShowBackPackWithAvatar(uint backpackID, ECollectionLevel level = ECollectionLevel.Lv3)
	{
	}

	public void ShowWeaponSkinWithAvatar(List<uint> idList, uint weaponSkinID)
	{
	}

	public void CacheAvatarAnimtorSwitch(bool enable)
	{
	}

	public void CreateDoublePreviewAvatar(PlayDoubleAvatarAnimParams param, bool needCheckClothEffectUnlock)
	{
	}

	public void CreatePreviewDoubleAvatarAnim(FullScreenAnimParams animParams, bool clearPool = true)
	{
	}

	public void PlayPreviewDoubleAvatarAnim()
	{
	}

	public void StopAvatarAnim(bool resetOverrideIdleAnim = true, bool stopForZoomIn = false)
	{
	}

	public void SetDoubleCharcterRootScaleAndSkinVisble(uint avatarIndex)
	{
	}

	public void SetPreviewAvatarLightVisble(bool flag)
	{
	}

	public UIMaleAvatar GetCreatedAvatar()
	{
		return null;
	}

	public void ShowBoostAvatar(BoostState state, ShowBoostAvatarParams showBoostAvatarParams, bool isBelow = false)
	{
	}

	public void Show3DHairStyleModel(uint avatarId, uint hairID)
	{
	}

	public void ShowEpicClothModel(uint clothID, int level)
	{
	}

	public void ShowEmoteWithCurrentAvatar(uint id, bool isCheckLowestDisplay = true, bool needShowAnimAvatar = true, bool playIdleAlternate = true, bool showEmoteCameraAnim = false)
	{
	}

	public void ShowSuperEmoteWithCurrentAvatar(uint id, bool isCheckLowestDisplay = true, bool needShowAnimAvatar = true, bool playIdleAlternate = true)
	{
	}

	public void ShowMotionWitchCurrentAvatar(uint id, bool isCheckLowestDisplay = true, bool needShowAnimAvatar = true, bool playIdleAlternate = true)
	{
	}

	public void ShowEmotionAnimationWithCurrentAvatar(uint id, bool isCheckLowestDisplay = true, bool needShowAnimAvatar = true)
	{
	}

	public void ShowParachuteAnimWitchCurrentAvatar(ResourceID[] resid, bool isCheckLowestDisplay = true, bool needShowAnimAvatar = true, bool playIdleAlternate = true)
	{
	}

	public void ShowFootHaloAnimWitchCurrentAvatar(ResourceID[] resid, bool isCheckLowestDisplay = true, bool needShowAnimAvatar = true, bool playIdleAlternate = true)
	{
	}

	public void ShowSkillEffectWitchCurrentAvatar(uint id, bool needShowAnimAvatar = true, bool isCheckLowestDisplay = true)
	{
	}

	public void ShowFlyMoveWithCurrentAvatar(uint id, bool needShowAnimAvatar = true, bool isCheckLowestDisplay = true)
	{
	}

	public void ShowGroupAnimWithCurrentAvatar(uint id, bool isCheckLowestDisplay = true, bool needShowAnimAvatar = true, bool playIdleAlternate = true, bool forceNotPlayIdleAlternate = false, bool showMvpAnim = false)
	{
	}

	public void ShowTransformerWithCurrentAvatar(uint id, bool isCheckLowestDisplay = true, bool needShowAnimAvatar = true, bool loop = true, bool isAutoPlayAfterSingleAnim = false)
	{
	}

	public void ShowFinishMoveWithCurrentAvatar(uint id, bool isCheckLowestDisplay = true, bool needShowAnimAvatar = true, bool playIdleAlternate = true)
	{
	}

	public void ShowVechicleSkinWithPreviewAvatar(List<uint> idList, uint carId)
	{
	}

	public void SetPetCreateCallback(Action<GameObject> c)
	{
	}

	public void ShowItems(List<uint> idlist, bool special = false, ECollectionLevel level = ECollectionLevel.Lv3, bool playClothAnimation = true, bool needResetAvatarDiretion = false, bool playPetLoopIdleSound = false, uint clothEffectItemID = 0u, HashSet<uint> unLockClothEffectItemIds = null, bool needAddLobbyCloth = false, bool needWeaponAutoChange = false, bool needSkipKillNotify = false)
	{
	}

	public void SetShow3DItemCallback(Action callback)
	{
	}

	public void ClearShow3DItemCallback()
	{
	}

	public void TransferToAvatarCreator(uint id, CSSharedItemData itemData, ECollectionLevel level = ECollectionLevel.Lv3, bool needAddLobbyCloth = false)
	{
	}

	public void SetTouchAreaEnable(bool enable)
	{
	}

	public void SetPreview3DItemEnabled(bool enanle)
	{
	}

	public void Show2DIcon(uint id, bool needBoost = false)
	{
	}

	public void ShowSpecial2DIcon(BaseItemInfo itemInfo, bool needSetDepth = false)
	{
	}

	public void ShowSpecial2DIcon(AwardDesc awardDesc)
	{
	}

	public void ClearPrevie2DItem()
	{
	}

	public void CreatePreviewWeaponSkin(WeaponSkinData skinData, bool need360DegreeRotation, bool needAutoChange = false)
	{
	}

	public void CreatePreview3dModelInternal(ResourceID resID, FrontEndPreviewComponent.CollectionPreviewType type, bool skipAnim = false)
	{
	}

	public void CreateDoubleWeapon(uint weapon1, uint weapon2, PlayDoubleWeaponParams param1, PlayDoubleWeaponParams param2)
	{
	}

	public void SkipModelAnim(bool needSkipKillNotify = false)
	{
	}

	public void Set3DItemTouchEnable(bool enable)
	{
	}

	public void Show3DVehicleSkin(uint id)
	{
	}

	public void Show3DBackPackModel(uint id, ECollectionLevel level)
	{
	}

	public void EnablePetRotate(bool enabled)
	{
	}

	public void SkipSpecialAnim()
	{
	}

	public void SetPreviewCGRatotable(bool enable)
	{
	}

	public void CreatePreviewStoryCG(ResourceID cgid, uint uitype, bool isHas = false, bool showFuncBtn = true)
	{
	}

	public void CreatePreviewSkinAnim(uint uitype, ResourceID resid)
	{
	}

	public bool GetCurrentCgSkip()
	{
		return false;
	}

	public void SetCGVisible(bool visible)
	{
	}

	public bool HasCG()
	{
		return false;
	}

	public void SetCGLightVisible(bool visible)
	{
	}

	public void ReplayCg()
	{
	}

	public void CloseCG()
	{
	}

	public void RrefreshWeaponTimeLine()
	{
	}

	public float GetCurCGTimeStamp()
	{
		return 0f;
	}

	public void CGCameraChange()
	{
	}

	public void ShowVideo(PreviewVideoParams videoParasms)
	{
	}

	public bool IsVideoPlaying()
	{
		return false;
	}

	public void StopVideo()
	{
	}

	public void ForceRefreshShadow(UIMaleAvatar ava = null)
	{
	}

	public void SetGroundShadowPos(Vector3 pos)
	{
	}

	public void SetGroundShadowRoation(Vector3 roation)
	{
	}

	public void SetGroundShadowShow(bool show)
	{
	}

	protected virtual FrontEndPreviewItemCreator CreateItemCreator()
	{
		return null;
	}

	protected virtual FrontEndPreviewAvatarCreator CreateAvatarCreator()
	{
		return null;
	}

	public PreviewCameraMove GetUI3DCameraMoveComp()
	{
		return null;
	}

	private void ChangePreviewCameraEnable(PreviewCameraMove mixcameraComp, PreviewCameraMove avatarcameraComp, bool enabled)
	{
	}

	public void AutoModifyPreviewModelAccordingToResolution(ref GameObject go, bool calculateYPos = false, float scaley = 0.5f, bool isAvatar = false, bool calcaulateCenterPriviewAnchorPoint = true, float offsetX = 0f)
	{
	}

	public void AutoModifyPreviewModelAccordingToResolution(ref GameObject go, GameObject boxGo, bool calculateYPos = false, float scaley = 0.5f, bool isAvatar = false, bool calcaulateCenterPriviewAnchorPoint = true)
	{
	}

	public void AutoModifyModelOnPreviewBorderChange()
	{
	}

	public void ForceAutoModifyDoubleAvatarPos()
	{
	}

	public void ForceAutoModifyDoubleAvatarPos(Vector3 left, Vector3 right)
	{
	}
}
