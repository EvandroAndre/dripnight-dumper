using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class FrontEndPreviewComponent : IUIModelDataChangeObserver
{
	public enum ShowPreviewType
	{
		None,
		ID,
		ClothList,
		DoubleAnimationAvatar,
		DoubleAvatar,
		Video
	}

	public enum PetType
	{
		Default,
		Cat,
		Dog,
		Panther,
		Panda,
		ShiBa,
		Fox,
		Robot,
		Poring,
		Otter,
		Hawk,
		PenGuin,
		Raccoon,
		Baboon,
		Dragon,
		Alien,
		Duck,
		Tiger,
		Rabbit
	}

	public enum PreviewConfigType
	{
		Normal
	}

	public enum Cameratype
	{
		None,
		AvatarCamera,
		ItemCamera,
		MixCamera
	}

	public enum AnimType
	{
		SpecialAnim = 1,
		FullCG,
		SkinShowAnim,
		CGVideo
	}

	public enum AvatarType
	{
		localAvatar,
		AvatarWithNoCache,
		AvatarWithCache,
		SpecialAvatar
	}

	public enum CollectionPreviewType
	{
		BackPack,
		BootyBox,
		ParaChute,
		SkyBoard,
		WeaponSkin,
		VehicleSkin,
		WeaponMeleeSkin,
		WeaponGrenadeSkin,
		Emote,
		RedEnvelope,
		PetCat,
		Flight,
		GroupAnim,
		Camera,
		HyperBook,
		WeaponIceWall,
		WeaponSmokeGranede,
		FinalShot,
		FlyingKnife,
		WeaponPrivilegeHitEffect,
		WeaponPrivilegeFireEffect,
		WeaponPrivilegeSpecialSound,
		WeaponPrivilegeKillEffect,
		WeaponPrivilegeGrenadeEffect,
		HorseVehicle,
		Invalid
	}

	public enum PetPreviewType
	{
		PetModel = 0,
		PetSkin = 10,
		PetRation = 7,
		PetAnima = 9
	}

	public delegate bool OnCheckDownloadResourceID(List<ResourceID> OutNeedResourceIDs);

	public delegate void OnAllResourcePrepared();

	private sealed class _003C_003Ec__DisplayClass319_0
	{
		public uint clothId;

		internal bool _003CAddClothToCurrentShowAvatarClothList_003Eb__0(uint o)
		{
			return false;
		}
	}

	protected ECollectionLevel m_CurrentBagpackLevel;

	protected UIBaseController m_ParentController;

	protected GameObject m_ItemCameraGo;

	protected Camera m_ItemCamera;

	protected PreviewCameraMove m_ItemCameraMove;

	protected GameObject m_MixCameraGo;

	protected Camera m_MixCamera;

	protected GameObject m_TouchArea;

	protected UIPetAvatar m_PetAvatar;

	private FrontendPreviewType _003CPreviewType_003Ek__BackingField;

	private string _003CCollectionTrialReturnSubGopos_003Ek__BackingField;

	public bool ForceOptionalDownloadNotAvatar;

	private bool _003CIsPreviewOpen_003Ek__BackingField;

	private bool _003CIsPreviewBeforeHiding_003Ek__BackingField;

	private bool _003CIsPreviewHiding_003Ek__BackingField;

	private bool _003CIsPreviewHidingByPopWind_003Ek__BackingField;

	private bool _003CIsPreviewUIHideing_003Ek__BackingField;

	private UIModelStoreBox m_ModelStoreBox;

	private UIModelHyperBook m_ModelHyperBook;

	protected UIModelTailor m_ModelTailor;

	protected UIModelAvatar m_ModelAvatar;

	private bool _003CIgnoreManualChange_003Ek__BackingField;

	private bool _003CChangedCameraByScript_003Ek__BackingField;

	private List<Action<object[]>> m_DelayInvokeActions;

	private List<object[]> m_DelayInvokeParams;

	protected FrontEndPreviewContentCreator m_ContentCreator;

	protected UIFrontEndPreviewCommonController m_PreviewCommonController;

	protected UIFrontEndPreviewController m_PreviewUIController;

	public static FrontEndPreviewConfig Preconfig;

	protected GameObject m_GroundShadow;

	protected UIFrontEndPreviewWeaponZoomInController m_ZoomInController;

	protected UIFrontEndPreviewZoomInWithCameraController m_ZoomInWithCameraController;

	protected uint m_MarkDoubleAnimCount;

	protected List<GameObject> m_WeaponPreviewShowList;

	protected FrontEndPreviewAvatarParams m_PreviewAvatarParams;

	protected bool m_isShowWeaponNotification;

	protected FrontEndPreviewConfigData m_FrontEndPreviewConfigData;

	protected FrontEndPreviewUIConfigData m_FrontEndPreviewUIConfigData;

	protected ShowPreviewType m_CurrentShowPreviewType;

	protected PreviewShowAvatarParams m_CurrentShowAvatarParams;

	protected PreviewShowItemParams m_CurrentShowIDParams;

	protected PreviewShowDoubleAnimationAvatarParams m_CurrentDoubleAnimatoinAvatarParams;

	protected PreviewShowDoubleAvatarParams m_CurrentDoubleAvatarParams;

	private uint m_CustomAvatarIdF;

	private uint m_CustomAvatarIdM;

	protected uint m_TriggerEffectAnimID;

	private bool m_IsPrivilegeShowContainerTriggerEffectPreviewing;

	private UIWidget m_PreviewBorder;

	private float _003CModelPosX_003Ek__BackingField;

	private float _003CRightExamplePreviewModelPosX_003Ek__BackingField;

	private float _003CModelPosY_003Ek__BackingField;

	private UIFrontEndPreviewHotFixDownloadBaseController m_OptionalDownloadController;

	private bool m_IsEnableOptionalDownloadRefresh;

	private bool m_IsOptionalDownloadShow;

	public List<uint> LastAvatarPreviewList;

	public uint CurrentSelectedClothID;

	public const uint DEFAULTBUNDLEMALE = 102000007u;

	public const uint DEFAULTBUNDLEFEMALE = 101000006u;

	protected const uint ISVISIBLE_COMMON = 1u;

	protected const uint ISVISIBLE_ANIMATION = 2u;

	public const string WEAPON360DEGREENAME = "weaponempty";

	public const uint GRENADEWEAPONID = 601u;

	public const uint FISTWEAPONID = 1u;

	public bool ChangeAvatarTransformForFinalShotPrivilege;

	public static Dictionary<uint, uint> PreviewTypeToEFrontendUITypeDic;

	public static Dictionary<uint, int> PreviewPetIDToPetTypeDic;

	public static Dictionary<int, PreviewPetConfig> PreviewPetAvatarConfigDic;

	public static Dictionary<uint, PreviewWeaponConfig> PreviewWeaponConfigDic;

	public static List<uint> PreviewWeaponNotNeed360Degree;

	private List<uint> m_CurrentShowTailorBasicClothList;

	private List<uint> m_CurrentShowTailorRecommendClothList;

	protected Vector3 m_MixCameraStartPos;

	protected Vector3 m_MixCameraMiddelePos;

	protected Vector3 m_MixCameraEndPos;

	public OnCheckDownloadResourceID onCheckDownloadResourceID;

	public OnAllResourcePrepared onAllResourcePrepared;

	private uint m_BundleIDIamIn;

	private bool m_IsShowDescription;

	private bool m_IsShowOwned;

	private FullScreenAnimParams m_Animdata;

	private bool m_ShowBundleScrollView;

	private bool m_PlayAnimation;

	private bool m_SkipWeaponAnim;

	private HashSet<uint> m_SkipKillNotifyItemIds;

	private bool m_ShowBundleTitle;

	private bool m_NeedResetAvatarDiretion;

	private bool m_IsSelectedBooyahPassPreviewItem;

	private bool m_NeedResetUI;

	private bool m_NeedDownload;

	private BaseItemInfo m_LastItemInfo;

	private DownloadInfoSpecific m_DownloadInfo;

	private bool m_IsHideIPTag;

	private uint m_ClothesSetID;

	private bool m_IsShowTailorUpgradeLevel;

	private PreviewVideoParams m_CurrentVideoParams;

	private Action<GameObject> m_callbackOnPlayerCreated;

	public ECollectionLevel CurrentCollectionLevel => ECollectionLevel.NoLevel;

	public Camera MixCamera => null;

	public Camera ItemCamera => null;

	public Camera CurCamera => null;

	public GameObject Preview3DItem => null;

	public FrontendPreviewType PreviewType
	{
		get
		{
			return _003CPreviewType_003Ek__BackingField;
		}
		private set
		{
			_003CPreviewType_003Ek__BackingField = value;
		}
	}

	public string CollectionTrialReturnSubGopos
	{
		get
		{
			return _003CCollectionTrialReturnSubGopos_003Ek__BackingField;
		}
		set
		{
			_003CCollectionTrialReturnSubGopos_003Ek__BackingField = value;
		}
	}

	public Cameratype MyCameratype => Cameratype.None;

	public bool IsPreviewOpen
	{
		get
		{
			return _003CIsPreviewOpen_003Ek__BackingField;
		}
		private set
		{
			_003CIsPreviewOpen_003Ek__BackingField = value;
		}
	}

	public bool IsPreviewBeforeHiding
	{
		get
		{
			return _003CIsPreviewBeforeHiding_003Ek__BackingField;
		}
		private set
		{
			_003CIsPreviewBeforeHiding_003Ek__BackingField = value;
		}
	}

	public bool IsPreviewHiding
	{
		get
		{
			return _003CIsPreviewHiding_003Ek__BackingField;
		}
		private set
		{
			_003CIsPreviewHiding_003Ek__BackingField = value;
		}
	}

	public bool IsPreviewHidingByPopWind
	{
		get
		{
			return _003CIsPreviewHidingByPopWind_003Ek__BackingField;
		}
		set
		{
			_003CIsPreviewHidingByPopWind_003Ek__BackingField = value;
		}
	}

	public bool IsPreviewUIHideing
	{
		get
		{
			return _003CIsPreviewUIHideing_003Ek__BackingField;
		}
		set
		{
			_003CIsPreviewUIHideing_003Ek__BackingField = value;
		}
	}

	public Quaternion WeaponOriginQuatertion => default(Quaternion);

	public bool IgnoreManualChange
	{
		get
		{
			return _003CIgnoreManualChange_003Ek__BackingField;
		}
		set
		{
			_003CIgnoreManualChange_003Ek__BackingField = value;
		}
	}

	public bool ChangedCameraByScript
	{
		get
		{
			return _003CChangedCameraByScript_003Ek__BackingField;
		}
		set
		{
			_003CChangedCameraByScript_003Ek__BackingField = value;
		}
	}

	public UIFrontEndPreviewController PreviewUIController => null;

	public UIFrontEndPreview2DItemController Preiview2DItemCtrl => null;

	public GameObject PreviewCG => null;

	public GameObject GroundShadow => null;

	public FrontEndPreviewConfigData FrontEndPreviewConfigData => null;

	public FrontEndPreviewUIConfigData FrontEndPreviewUIConfigData => null;

	public ShowPreviewType CurrentShowPreviewType => ShowPreviewType.None;

	public PreviewShowItemParams CurrentShowIDParams => default(PreviewShowItemParams);

	public PreviewShowAvatarParams CurrentShowAvatarParams => default(PreviewShowAvatarParams);

	public uint TriggerEffectAnimID => 0u;

	public uint CustomShowAvatarF
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public uint CustomShowAvatarM
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public UIWidget PreviewBorder
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public float ModelPosX
	{
		get
		{
			return _003CModelPosX_003Ek__BackingField;
		}
		private set
		{
			_003CModelPosX_003Ek__BackingField = value;
		}
	}

	public float RightExamplePreviewModelPosX
	{
		get
		{
			return _003CRightExamplePreviewModelPosX_003Ek__BackingField;
		}
		private set
		{
			_003CRightExamplePreviewModelPosX_003Ek__BackingField = value;
		}
	}

	public float ModelPosY
	{
		get
		{
			return _003CModelPosY_003Ek__BackingField;
		}
		private set
		{
			_003CModelPosY_003Ek__BackingField = value;
		}
	}

	public bool IsOptionalDownloadShow => false;

	public bool IsEnableOptionalDownloadRefresh => false;

	public bool SkipWeaponAnim
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public BaseItemInfo LastItemInfo => null;

	public uint ClothesSetID => 0u;

	public bool IsShowTailorUpgradeLevel => false;

	public void DelayInvoke(Action<object[]> action, object[] param)
	{
	}

	public void OnDelayPreviewFinished()
	{
	}

	public FrontEndPreviewContentCreator ContentCreator()
	{
		return null;
	}

	public void SetPrivilegeShowContainerTriggerEffectPreviewing(bool isPreviewing)
	{
	}

	public bool IsClothPrivilegeTriggerEffectPreviewing()
	{
		return false;
	}

	public virtual void Init()
	{
	}

	public void OpenPreview(UIBaseController parentController, FrontEndPreviewConfigData frontEndPreviewData, UITexture texBg = null)
	{
	}

	public void MoveMixCameraPos(Vector3 offset)
	{
	}

	public void SetPreviewCommonController(UIFrontEndPreviewCommonController ctrl)
	{
	}

	public void SetPreviewUIController(UIFrontEndPreviewController ctrl)
	{
	}

	protected virtual FrontEndPreviewContentCreator CreateContentCreator()
	{
		return null;
	}

	public void SetAvatarParams(Vector3 scale, Vector3 pos, AvatarType type, Vector4 boostparams, Vector4 boostparamsbelow, bool Playpose = true, bool needStopEffect = true, ShowBoostAvatarParams showBoostAvatarParams = null, Vector3 roation = default(Vector3), bool CreateCacheAvatarNeedPlaySpecialAnim = true)
	{
	}

	public FrontEndPreviewAvatarParams GetPreviewAvatarParams()
	{
		return null;
	}

	public bool CheckCanShowWeaponAnim()
	{
		return false;
	}

	public GameObject GetItemCarmea()
	{
		return null;
	}

	public void ClearCurrentShowType()
	{
	}

	public void ClosePreview()
	{
	}

	public void TempHidePreview(bool keepUIContent = false, bool keep3DContent = false)
	{
	}

	public void HidePreviewUI()
	{
	}

	public void ShowPreviewUI()
	{
	}

	public void RecoverPreview(bool needShowCurrentPreview = true, bool needSkipAnim = false, bool needSkipKillNotify = false)
	{
	}

	public void ShowCurrentPreview(bool isRecover, bool needSkipAnim = false, bool needSkipKillNotify = false)
	{
	}

	public bool IsCurrentPreviewAbReady()
	{
		return false;
	}

	public bool UpdateBackPackLevel(ECollectionLevel level)
	{
		return false;
	}

	public bool UpdateAvatarTransformLevel(uint TransformDataID, int index, bool needShowAnimAvatar = true, bool isAutoPlayAfterSingleAnim = false)
	{
		return false;
	}

	private void ProcessTailorBundleOrSet(uint id, List<uint> preview3DList, bool isShowTailorUpgradeLevel = true)
	{
	}

	private void ProcessShowClothesBySetID(uint setID, List<BaseItemInfo> previewUIList, List<uint> preview3DList)
	{
	}

	public virtual BoostState CheckBoostStateDelegate(uint itemID)
	{
		return BoostState.DontChange;
	}

	private uint SelectCustomAvatarID(bool isFemale)
	{
		return 0u;
	}

	public UIPetAvatar GetPetAvatar()
	{
		return null;
	}

	public void SetGroundShadowPos(Vector3 pos)
	{
	}

	public void SetGroundShadowShow(bool show)
	{
	}

	public void SetGroundShadowRoation(Vector3 rotation)
	{
	}

	public void ShowPreviewByIdAccodingToLastParams(uint id, EInventory.AwardType award_type = EInventory.AwardType.AwardType_ITEM, ECollectionLevel level = ECollectionLevel.Lv3, bool isRecover = false, bool needSkipAnim = false, bool needSkipKillNotify = false)
	{
	}

	public void SetPetCreateCallback(Action<GameObject> c)
	{
	}

	public void SetPlayerCreateCallback(Action<GameObject> c)
	{
	}

	public void OnPlayerAvatarUpdated()
	{
	}

	public virtual void ShowPreviewById(uint id, BaseItemInfo itemInfo, EInventory.AwardType award_type = EInventory.AwardType.AwardType_ITEM, bool isShowDescription = true, bool isShowOwned = true, FullScreenAnimParams animdata = null, bool showBundleScrollView = true, bool playAnimation = true, bool showBundleTitle = true, bool needResetAvatarDiretion = false, bool needResetUI = true, bool needRecordeParam = true, uint bundleIDIamIn = 0u, bool playLoopIdleSound = false, bool playPetLoopIdleSound = false, bool isHideIPTag = false, bool skipWeaponAnim = false, bool needRefreshUI = true, ECollectionLevel level = ECollectionLevel.Lv3, Action show3DItemCallback = null, bool isHideBundleTips = false, bool needAddLobbyCloth = false, bool needWeaponAutoChange = false, bool needSkipKillNotify = false, bool isShowTailorUpgradeLevel = true, uint clothesSetID = 0u)
	{
	}

	private bool TryShowOptionalDownloadBeforeCreatePreview(uint itemID, bool isAvatar, out bool isCurrentPreviewAbReady)
	{
		isCurrentPreviewAbReady = default(bool);
		return false;
	}

	private bool IsAvatarFacialResReady(uint itemID)
	{
		return false;
	}

	private DownloadInfoSpecific CreateShowPreviewDownloadInfo(uint itemID)
	{
		return null;
	}

	private void AddExtraNeedDownloadResourceID(ref List<ResourceID> extraNeedDownloadResourceIDs, List<ResourceID> itemNeedDownloadResourceIDs, ResourceID resourceID)
	{
	}

	private void DecideWhatToPreview(CSSharedItemData itemTemp, out List<BaseItemInfo> previewUIList, out List<uint> preview3DList, out bool isSpecial, out bool isAvatar, out bool forceShowBoost, out uint clothEffectItemID, bool forceshowLobbyAvatar = false, bool isShowTailorUpgradeLevel = true, uint clothesSetID = 0u)
	{
		previewUIList = null;
		preview3DList = null;
		isSpecial = default(bool);
		isAvatar = default(bool);
		forceShowBoost = default(bool);
		clothEffectItemID = default(uint);
	}

	private void SetShow3DItemCallback(Action callback)
	{
	}

	public void RefreshPreviewUIOnly(uint id, BaseItemInfo itemInfo, EInventory.AwardType award_type = EInventory.AwardType.AwardType_ITEM, bool isShowDescription = true, bool isShowOwned = true, bool showBundleScrollView = true, bool showBundleTitle = true, bool needResetUI = true, bool isHideIPTag = false, bool isShowDownloadUI = false, ECollectionLevel level = ECollectionLevel.Lv3)
	{
	}

	public void ShowItemByIdList(List<uint> idlist, bool special = false, ECollectionLevel level = ECollectionLevel.Lv3, bool isShow = true, bool showInstallmentInfo = false, bool playAnimation = true, bool needResetAvatarDiretion = false, uint clothEffectItemID = 0u, HashSet<uint> unLockClothEffectItemIds = null, bool needWeaponAutoChange = false)
	{
	}

	private bool TryProcessBundleInsideItems(uint id)
	{
		return false;
	}

	private bool NeedShowHyperBookHiddenVFX(uint itemID)
	{
		return false;
	}

	private void ShowBoostAvatar(uint itemID, ShowBoostAvatarParams showBoostAvatarParams)
	{
	}

	public void ExternalShowBoostAvatar(uint itemID)
	{
	}

	public void StopAvatarAnim(bool resetOverrideIdleAnim = true, bool stopForZoomIn = false)
	{
	}

	public void ShowFullScreenPreview(uint id)
	{
	}

	public void ShowFullScreenVideoPreview(uint id)
	{
	}

	public void ShowZoomItemWithCameraById(uint id)
	{
	}

	public void EnablePetRotate(bool enabled)
	{
	}

	public uint GetPreviewAvatarId(uint clothesID, bool forceshowLobbyAvatar = false)
	{
		return 0u;
	}

	private uint GetPreviewAvatarId(AvatarWardrobeData wData, uint bundleShowFemale, uint bundleShowMale, bool forceshowLobbyAvatar = false)
	{
		return 0u;
	}

	private uint GetPreviewAvatarId(uint bundleShowFemale, uint bundleShowMale)
	{
		return 0u;
	}

	public virtual void Show3dHairStyleModel(uint hairid, int level = 3)
	{
	}

	protected void ShowAvatarInternal(List<uint> idlist, AvatarType type = AvatarType.localAvatar, bool playanim = true, uint weaponID = 0u, bool needCheckClothEffectUnlock = true, uint clothEffectID = 0u, HashSet<uint> unLockClothEffectItemIds = null)
	{
	}

	public virtual void ShowAvatarByClothList(uint avatarID, List<uint> clothList, AvatarType type = AvatarType.localAvatar, bool playanim = true, uint weaponID = 0u, bool needOptionalDownload = false, bool needClearUIData = true, List<uint> checkOptionalIds = null, bool needCheckClothEffectUnlock = true, uint clothEffectItemID = 0u, HashSet<uint> unLockClothEffectItemIds = null, bool isForceShowDefaultSkin = false, bool needRefreshUI = true, bool needAddLobbyCloth = false, bool needKeepHairWhenSameAvatarId = false, uint selectedClothID = 0u, PreviewBackpackParams backpackParams = null, uint? skinColor = null, ulong accountID = 0uL)
	{
	}

	public bool RefreshCheckOptionalResNeedDownload(List<uint> clothList, List<uint> checkOptionalIds, uint clothEffectItemID = 0u, bool isAvatar = false)
	{
		return false;
	}

	protected void ShowAvatar(uint avatarID, List<uint> clothList, AvatarType type = AvatarType.AvatarWithCache, bool playanim = true, uint weaponID = 0u, bool needOptionalDownload = false, bool isInternal = false, bool needClearUI = true, List<uint> checkOptionalIds = null, bool needCheckClothEffectUnlock = true, uint clothEffectItemID = 0u, HashSet<uint> unLockClothEffectItemIds = null, bool isForceShowDefaultSkin = false, bool needAddLobbyCloth = false, bool needKeepHairWhenSameAvatarId = false, uint selectedClothID = 0u, PreviewBackpackParams backpackParams = null, uint? skinColor = null, ulong accountID = 0uL)
	{
	}

	public void SetPrivilegeEffectBtnVisible(bool isVisible)
	{
	}

	public void SetDefaultPetSkin(uint petID, uint skinID)
	{
	}

	public void AutoModifyModelOnPreviewBorderChange(bool needUpdateAvatarBoost = true)
	{
	}

	public void ShowEpicClothModel(uint clothID, int level)
	{
	}

	public void Set3dItemTouchEnable(bool flag)
	{
	}

	public void SkipModelAnim(bool needSkipKillNotify = false)
	{
	}

	public void ShowCachedAvatar(uint avatarid, bool playanim = false)
	{
	}

	public void ShowCurrentBackpackModel(uint id)
	{
	}

	public void Show3DJetpackModel(uint id, ECollectionLevel level)
	{
	}

	private void Show3DWeaponSkinWithAvatar(uint id, WeaponSkinData lData)
	{
	}

	public void ShowEmoteWithCurrentAvatar(uint _eid, bool _special = false, bool isCheckLowestDisplay = true, bool needShowAnimAvatar = true, bool playIdleAlternate = true, bool showEmoteCameraAnim = false)
	{
	}

	public void ShowSuperEmoteWithCurrentAvatar(uint _eid, bool _special = false, bool isCheckLowestDisplay = true, bool needShowAnimAvatar = true, bool playIdleAlternate = true)
	{
	}

	public void ShowMotionWithCurrentAvatar(uint id, bool isCheckLowestDisplay = true, bool needShowAnimAvatar = true, bool playIdleAlternate = true)
	{
	}

	public void ShowEmotionAnimationWithCurrentAvatar(uint id, bool isCheckLowestDisplay = true, bool needShowAnimAvatar = true)
	{
	}

	public void ShowParachuteAnimWithCurrentAvatar(ResourceID[] resid, bool isCheckLowestDisplay = true, bool needShowAnimAvatar = true, bool playIdleAlternate = true)
	{
	}

	public void ShowFootHaloAnimWithCurrentAvatar(ResourceID[] resid, bool isCheckLowestDisplay = true, bool needShowAnimAvatar = true, bool playIdleAlternate = true)
	{
	}

	public void ShowSkillEffectWithCurrentAvatar(uint id, bool needShowAnimAvatar = true, bool isCheckLowestDisplay = true)
	{
	}

	public void ShowFlyMoveWithCurrentAvatar(uint id, bool needShowAnimAvatar = true, bool isCheckLowestDisplay = true)
	{
	}

	public void ShowGroupAnimWithCurrentAvatar(uint iId, bool isCheckLowestDisplay = true, bool needShowAnimAvatar = true, bool needRefreshUI = true, bool playIdleAlternate = true, bool forceNotPlayIdleAlternate = false, bool showMvpAnim = false)
	{
	}

	public void CloseMvpCamera()
	{
	}

	public void ShowTransformerWithCurrentAvatar(uint iId, bool isCheckLowestDisplay = true, bool needShowAnimAvatar = true, bool needRefreshUI = true, bool loop = true)
	{
	}

	public void ShowFinishMoveWithCurrentAvatar(uint _eid, bool _special = false, bool isCheckLowestDisplay = true, bool needShowAnimAvatar = true, bool playIdleAlternate = true)
	{
	}

	public void AutoModifyPreviewModelAccordingToResolution(ref GameObject go, bool calculateYPos = false, float scaley = 0.5f, bool isAvatar = false, bool calcaulateCenterPriviewAnchorPoint = true, float offsetX = 0f)
	{
	}

	public UIMaleAvatar GetCreateAvatar()
	{
		return null;
	}

	public void ForceAutoModifyDoubleAvatarPos()
	{
	}

	public void ShowWeaponSkinFeature(uint weaponSkinID, WeaponSkinFeature weaponSkinFeature, IWeaponSkinFeaturePreviewContext context)
	{
	}

	public void Clear3dModel()
	{
	}

	public void CreatePreview3dModelByResId(ResourceID resID, CollectionPreviewType type = CollectionPreviewType.Invalid, bool skipAnim = false)
	{
	}

	public void SetPreviewAvatarLightVisble(bool flag)
	{
	}

	public void ClearCache(bool closeCG = false, bool clearPreviewAvatar = true, bool clearPreviewCacheAvatar = false, bool clearDesc = false, bool clearUI = true, bool clearSpecialUI = true)
	{
	}

	public void ClearItemOnly(bool closeCG = false)
	{
	}

	public void ClearCacheInternal()
	{
	}

	public void ClearCurrentPreviewType()
	{
	}

	public void CreateDoublePreviewAvatar(PlayDoubleAvatarAnimParams param, bool needCheckClothEffectUnlock)
	{
	}

	public void PlayDoubleAvatarAnim()
	{
	}

	public void MarkDoubleSpecialAnim()
	{
	}

	public void ForceAutoModifyDoubleAvatarPos(Vector3 left, Vector3 right)
	{
	}

	public void SetDoubleCharcterRootScaleAndSkinVisble(uint avatarIndex)
	{
	}

	public void CreatePreviewAvatarWithCar(List<uint> idlist, uint carId)
	{
	}

	public void CreateDoubleWeapon(uint weapon1, uint weapon2, PlayDoubleWeaponParams param1, PlayDoubleWeaponParams param2)
	{
	}

	public void CreatePreviewWeapon(WeaponSkinData lData, bool isShowWeaponNotification = true, bool needAutoChange = false)
	{
	}

	public void SetDragEventListener(CSSharedItemData itemData)
	{
	}

	public void SetDragEventListenerEnable(bool enable)
	{
	}

	public virtual void CreateAvatarWithBackpack(List<uint> idlist, uint collionid)
	{
	}

	public void CreatePreviewAvatarWithWeapon(List<uint> idlist, uint weaponid, bool needRefershShowItemID = true)
	{
	}

	public void CreatePreviewDoubleAvatarAnim(FullScreenAnimParams animParams, bool clearpool = true)
	{
	}

	public bool IsAdvanceTailorCloth(uint itemID, List<uint> preview3DList)
	{
		return false;
	}

	private bool IsBasicTailorCloth(uint bundleID)
	{
		return false;
	}

	private List<uint> TransferToRecommendTailorPreviewList(uint itemID)
	{
		return null;
	}

	public bool IsPreviewingTailorClothEffect()
	{
		return false;
	}

	public uint GetPreviewingTailorClothEffectId()
	{
		return 0u;
	}

	public bool IsPreviewTypeTailorNeedCheckUnlock()
	{
		return false;
	}

	public bool NeedForceLoadAllClothEffect()
	{
		return false;
	}

	public void ShowBasicTailor()
	{
	}

	public void ShowRecommendTailor()
	{
	}

	public void HackShowNB2Transformer()
	{
	}

	public void ShowTriggerEffectAnim(ClothTriggerEffectPreviewData data)
	{
	}

	public void ShowMultipleTriggerEffectAnim(ClothTriggerEffectPreviewData data, ResourceID animId)
	{
	}

	public void AddClothToCurrentShowAvatarClothList(uint clothId)
	{
	}

	public void SetGroundShadowState(bool show)
	{
	}

	public void HideAvatarRoateArea()
	{
	}

	public void CloseAllPreviewUI(bool isclear = false)
	{
	}

	public void HideQuickMessage()
	{
	}

	public void HideIPCollab()
	{
	}

	public bool GetMagnifierState()
	{
		return false;
	}

	public UIFrontEndPreviewController.BackpackSwithType GetBackpackSwitchType()
	{
		return UIFrontEndPreviewController.BackpackSwithType.Backpack;
	}

	public void SetPreviewTweenEnabled(bool enabled)
	{
	}

	public void CloseUIExceptMagn()
	{
	}

	public void ClickDefaultBackPack()
	{
	}

	public void ClickDefaultHairStyle()
	{
	}

	public void ClickDefaultEpicClothStyle()
	{
	}

	public void ClearZoomInfo()
	{
	}

	public void ShowHyperBookHiddenPageVfx(uint itemID)
	{
	}

	public void ShowSpecial2dIcon(AwardDesc awardItem, bool isShow = true, bool isBundle = false, bool refreshdesc = true)
	{
	}

	public void SetBackPackVisble(bool isVisble)
	{
	}

	public void SetHairStyleVisble(bool isVisble)
	{
	}

	protected void SetEpicClothStyleVisble(bool isVisble)
	{
	}

	public void SetMagnifierVisble(bool isVisble)
	{
	}

	public UIFrontEndPreview2DItemController CreatePreview2DItemController()
	{
		return null;
	}

	public UIFrontEndPreviewVideoPlayerController CreateVideoPlayerController()
	{
		return null;
	}

	public void Clear2dItem()
	{
	}

	public void RefreshWeaponNotificationState()
	{
	}

	public void SetTreasureBoxProbabilityState(bool show, uint itemID)
	{
	}

	public void ForceRefreshBundleEffectInfo(uint id)
	{
	}

	protected virtual void SetSpecial2DIcon(BaseItemInfo itemInfo, string descText, bool needSetOriginal = true, bool needSetDepth = false)
	{
	}

	private void SetBundleEffectInfo(List<BaseItemInfo> previewUIList)
	{
	}

	public void SetCommonDescription(uint id)
	{
	}

	public void RefreshSingleDesc(uint id)
	{
	}

	public void ShowIPTag()
	{
	}

	public bool CheckIsNeedSkipKillNotify(uint itemID)
	{
		return false;
	}

	public void ClearSkipKillNotifyItemIds()
	{
	}

	public void AddSkipKillNotifyItemId(uint itemID)
	{
	}

	public void ResetRightPreviewAdaptResidualState()
	{
	}

	public void SetPreivewPanel(UIWidget previewBorder)
	{
	}

	public void OnChangePreviewPanel(UIWidget previewBorder)
	{
	}

	public void CalculateModelPos(UIWidget previewBorder)
	{
	}

	public void SetAutoCalculatePanel(UIWidget previewBorder)
	{
	}

	public void SetHotFixDownload(bool show, DownloadInfoSpecific downloadInfo = null, bool isAvatar = false)
	{
	}

	public bool CheckAbReadyWhenClick()
	{
		return false;
	}

	public void SetOptionalDownloadItemID(uint itemID)
	{
	}

	public Vector2 GetDownLoadBtnWorldPos()
	{
		return default(Vector2);
	}

	public bool GetHotFixShow()
	{
		return false;
	}

	public void EnableOptionalDownloadRefresh(bool enable)
	{
	}

	private void ShowHairStyle(CSSharedItemData item)
	{
	}

	private void ShowEpicClothStyle(CSSharedItemData item)
	{
	}

	private void ShowSpecAward(EInventory.AwardType awardtype, bool refreshDesc = true)
	{
	}

	public void ShowVideo(PreviewVideoParams videoParasms)
	{
	}

	public void StopVideo()
	{
	}

	private void SetNeedDownloadState(bool needDownload, bool isAvatar = false)
	{
	}

	public void ClearMarkDoubleSpecialAnim()
	{
	}

	public void ClearResourceRefCache()
	{
	}

	public CollectionPreviewType GetWeaponType(WeaponSkinData data)
	{
		return CollectionPreviewType.BackPack;
	}

	public bool CheckIsFlyingKnife(uint weaponid)
	{
		return false;
	}

	public bool CheckIsGrenadeWeapon(uint weaponid)
	{
		return false;
	}

	public bool CheckIsSmokeGrenadeWeapon(uint weaponid)
	{
		return false;
	}

	public bool CheckIsIceWallWeapon(uint weaponid)
	{
		return false;
	}

	public List<uint> GetCurrentClothesList()
	{
		return null;
	}

	public void ClearItemData()
	{
	}

	public void ResetWishListNode()
	{
	}

	public void OnBoxItemBtnSelect(uint boxID, List<TreasureBoxShowData> boxList, out List<BaseItemInfo> previewUIList, out List<uint> preview3DList, out bool isSpecial)
	{
		previewUIList = null;
		preview3DList = null;
		isSpecial = default(bool);
	}

	private void OnClothesItemSelect(uint clothesID, out List<uint> preview3DList, out bool isSpecial, bool forceshowLobbyAvatar = false)
	{
		preview3DList = null;
		isSpecial = default(bool);
	}

	private void On3DAvatarItemSelect(uint avatarID, out List<uint> preview3DList, out bool isSpecial)
	{
		preview3DList = null;
		isSpecial = default(bool);
	}

	private void On2DAvatarItemSelect(AvatarInvisbleData data)
	{
	}

	private void OnBundleItemSelect(uint bundleID, List<BundleShowData> bundleList, out List<BaseItemInfo> previewUIList, out List<uint> preview3DList, out bool isSpecial)
	{
		previewUIList = null;
		preview3DList = null;
		isSpecial = default(bool);
	}

	public List<uint> GetBundleClothsItemsIdByBundleId(uint bundleId)
	{
		return null;
	}

	public void OnOptionalBundleItemSelect(uint optionalBundleID, List<OptionalBundleShowData> optionalBundleList, out List<BaseItemInfo> previewUIList, out List<uint> preview3DList, out bool isSpecial)
	{
		previewUIList = null;
		preview3DList = null;
		isSpecial = default(bool);
	}

	public void OnHyperBookItemSelect(uint bookID, List<AwardDesc> bookAwardList, out List<BaseItemInfo> previewUIList, out List<uint> preview3DList)
	{
		previewUIList = null;
		preview3DList = null;
	}

	public bool IsSpecialPreviewBundle(uint itemID, bool checkOwned = false)
	{
		return false;
	}

	public bool IsSpecialPreviewBundle(List<BundleShowData> bundleList, bool checkOwned = false)
	{
		return false;
	}

	public bool IsSpecialPreviewOptionalBundle(uint itemID)
	{
		return false;
	}

	public bool IsSpecialPreviewOptionalBundle(List<OptionalBundleShowData> optionalBundleList)
	{
		return false;
	}

	public bool IsSpecialTreasureBox(uint itemID)
	{
		return false;
	}

	public bool IsSpecialTreasureBox(List<TreasureBoxShowData> boxList)
	{
		return false;
	}

	public void OnBooyahPassPreviewSmallItemClick()
	{
	}

	public bool CheckCameraClick()
	{
		return false;
	}

	public void ChangeCameraMove(bool isBoost)
	{
	}

	public PreviewCameraMove GetMixCameraMoveComp()
	{
		return null;
	}

	public PreviewCameraMove GetAvatarCameraComp()
	{
		return null;
	}

	public void ForceSetCameraType(Cameratype type)
	{
	}

	public void ForceSetItemTouchArea()
	{
	}

	public void RestorePreviewCamera()
	{
	}

	public void SwitchCamera(Cameratype type)
	{
	}

	public void CloseALLCamera()
	{
	}

	public void CloseMixCameraExposed()
	{
	}

	public void ReStoreMixcamera(bool isForce = false)
	{
	}

	public void ResetCamera()
	{
	}

	public void ResetCameraAfterChangeByScript()
	{
	}

	public void SkipSpecialAnim()
	{
	}

	public void SetPreviewCgRotate(bool flag)
	{
	}

	public void CreatePreviewStoryCg(ResourceID cgid, uint uitype, bool isHas = false, bool showFuncBtn = true)
	{
	}

	public void CreatePreviewSkinAnim(uint uitype, ResourceID resid)
	{
	}

	public bool GetCurrentCgSkip()
	{
		return false;
	}

	public void ClosePreviewStoryCg()
	{
	}

	public void CloseCG()
	{
	}

	public void CGCameraChange()
	{
	}

	public void CGCameraResume()
	{
	}

	public void SetCGVisible(bool flag)
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

	public void RrefreshWeaponTimeLine()
	{
	}

	public float GetCurCGTimeStamp()
	{
		return 0f;
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	protected virtual void CheckRefreshPreview()
	{
	}

	private bool ShouldResetMultiStatePrivilegeSkeletonToDefault(uint nextTriggerID)
	{
		return false;
	}
}
