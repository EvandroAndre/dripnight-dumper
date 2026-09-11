using System;
using System.Collections.Generic;
using COW.Gameplay.UGC;
using UnityEngine;
using message;

namespace COW.GamePlay.UGCRuntime;

internal class UGCPlayerBridge : IBridgingEntity
{
	public class UGCPlayerSkeleton
	{
		private UGCSkeletonBone[] m_SkeletonParts;

		private UGCSkeletonRepItem m_RepItem;

		public Player Owner;

		public bool IgnorePlayerOldScale;

		public UGCPlayerSkeleton(Player player, string entityID)
		{
		}

		private void OnSkeletonPartChangeEvent(UGCSkeletonPartType type, string partEntityID)
		{
		}

		private void _003C_002Ector_003Eb__4_0(string s)
		{
		}

		private void _003C_002Ector_003Eb__4_1(string s)
		{
		}

		private void _003C_002Ector_003Eb__4_2(string s)
		{
		}

		private void _003C_002Ector_003Eb__4_3(string s)
		{
		}

		private void _003C_002Ector_003Eb__4_4(string s)
		{
		}

		private void _003C_002Ector_003Eb__4_5(string s)
		{
		}

		private void _003C_002Ector_003Eb__4_6(string s)
		{
		}

		private void _003C_002Ector_003Eb__4_7(string s)
		{
		}

		private void _003C_002Ector_003Eb__4_8(string s)
		{
		}

		private void _003C_002Ector_003Eb__4_9(string s)
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<object, uint> _003C_003E9__96_0;

		public static Converter<object, uint> _003C_003E9__97_0;

		internal uint _003COnWeaponSkinIDChangeEvent_003Eb__96_0(object value)
		{
			return 0u;
		}

		internal uint _003COnVehicleSkinIDsChangeEvent_003Eb__97_0(object value)
		{
			return 0u;
		}
	}

	private sealed class _003C_003Ec__DisplayClass106_0
	{
		public string emoteClipUUID;

		public UGCPlayerBridge _003C_003E4__this;

		public bool overrideGamePlayControl;

		internal void _003CPlayUGCEmoteClip_003Eb__0(bool succ, UGCResAnimationClip resObj)
		{
		}
	}

	private UGCEntityDataStore m_DataStore;

	private Player m_Player;

	private UGCAimAssistEntityRepItem m_AssistEntityRepItem;

	private UGCAnimationControllerAbleRepItem m_animationAbleRepItem;

	private UGCVisibilityRepItem visibilityRepItem;

	public UGCTransformClothInfoEntity m_transformClothEntity;

	private UGCPlayerAvatarInfoRepItem m_PlayerAvatarInfoRepItem;

	private UGCPlayerRepItem m_PlayerCmpt;

	private UGCPlayerBehaviorRepItem m_PlayerBehaviorCmpt;

	private UGCEntityRepItem m_EntityCmpt;

	public string BehaviorEntityID;

	protected int m_lastSpawnOrReviveTime;

	private UGCHardCodeManager m_UGCHardCodeMgr;

	private int m_ugcGenderFlag;

	private UGCCustomPlayerAvatar m_playerAvatar;

	private string m_curUGCResPlayerUUID;

	public bool m_isCacheAvatarPartVisableMask1;

	public bool m_isCacheAvatarPartVisableMask2;

	public bool m_isCacheAvatarPartVisableMask3;

	public bool m_isCacheAvatarPartVisableMask4;

	public int m_cacheAvatarPartVisableMask1;

	public int m_cacheAvatarPartVisableMask2;

	public int m_cacheAvatarPartVisableMask3;

	public int m_cacheAvatarPartVisableMask4;

	private string chatChannelOldValue;

	private CommonParticleEffect m_CheckPointEffect;

	private const int CONST_FirstCheckPointID = 1;

	private UGCFactionRepItem m_FactionEntity;

	private UGCTeamRepItem m_TeamEntity;

	private string factionEntityOldValue;

	private bool factionShowQuickMessageOldValue;

	private bool factionShowTagOldValue;

	private string teamEntityOldValue;

	private int factionIdxOldValue;

	private List<int> m_ugcDisablePickUpItems;

	private string m_currentUGCEmoteClipUUID;

	private UGCCameraConfigRepItem m_CameraConfig;

	private UGCBasicCameraEntity m_UGCBasicCameraEntity;

	private string m_UGCBasicCameraEntityID;

	private static Dictionary<int, string> ms_partType2BoneNameMap;

	protected UGCSkeletonBoneOwner m_skeletonBoneOwner;

	public IKFIHMAEFEA m_UGCPlayerAnimPort;

	private bool m_UGCEnableAnimReplace;

	protected string m_AnimationControllerEntityID;

	private UGCAnimationControllerEntity m_ugcAnimationControllerEntity;

	private UGCAnimationController m_ugcCacheAC;

	private string m_ugcCacheACResUUID;

	private Dictionary<string, AnimationClip> m_blendTreeOverrideAnimationClips;

	private bool m_isInitOverrideAnimationControllers;

	private Dictionary<uint, string> m_WeaponTypeOverrideAnimCtrlsDic;

	private GameObject m_ugcCacheAnimationObject;

	private bool m_isFFPlayerUMAInited;

	private bool m_lazyCallUMAChanged;

	private UGCPlayerSkeleton m_Skeleton;

	private bool m_IsZombieLowBlood;

	private GameObject m_ZombieLowBloodVFX;

	private int m_constantMoveFrameCnt;

	private int m_constantIdleFrameCnt;

	private bool m_isLastFrameMoving;

	private const float MOVEMENT_THRESHOLD = 1E-06f;

	private string m_PrevAimLogicEntityID;

	private string m_CurAimLogicEntityID;

	private object[] m_EventArgs1;

	private object[] m_EventArgs2;

	public UGCPlayerRepItem PlayerCmpt => null;

	public UGCPlayerBehaviorRepItem PlayerBehaviorCmpt => null;

	public Player OwnerPlayer => null;

	public bool IsUGCCustomPlayerAvatar => false;

	public int UGCFactionIndex => 0;

	public UGCFactionRepItem UGCFactionEntity
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public UGCTeamRepItem UGCTeamEntity
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public UGCCameraConfigRepItem CurrentCameraConfig
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public UGCBasicCameraEntity CurrentUGCCamera
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool UGCEnableAnimReplace
	{
		set
		{
		}
	}

	public Dictionary<string, AnimationClip> BlendTreeOverrideAnimationClips
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool IsOverrideAnimationControllersInitialized => false;

	public GameObject UGCCacheAnimationObject => null;

	public bool UGCIsUsePetAvatar => false;

	public bool UGCIsUsingNewAnimComponent => false;

	public bool LazyCallUMAChange
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsUGCFemale()
	{
		return false;
	}

	public void SetUGCGenderFlag(int flag)
	{
	}

	public UGCPlayerBridge(Player player)
	{
	}

	public void InitEntityInfo()
	{
	}

	public void Update()
	{
	}

	public void OnRecycle()
	{
	}

	public void OnLogicEntityCreated(string entityID)
	{
	}

	public void OnLogicPlayerBehaviorCreated(string entityID)
	{
	}

	private void OnPlayerBagSkinIDChanged(int value)
	{
	}

	private void OnUGCInteractWithHUD(object[] data)
	{
	}

	private void OnKnockDownFlagChange(object[] data)
	{
	}

	public void OnItemEquipedOrUnEquiped(NAELPAAELNO item, bool isEquip)
	{
	}

	private void OnResPlayerUUIDChanged(string resPlayerUUID)
	{
	}

	public void OnSyncUGCEntityProperty(long propertyIndex, UGCSimpleValue newValue)
	{
	}

	private void OnVisibilityChanged(bool visible)
	{
	}

	private void OnVisibilityLayerChanged(int layer)
	{
	}

	private void ProcessPlayerMuteVoiceChange(bool newValue)
	{
	}

	private void ProcessPlayerMuteQuickChatChange(bool newValue)
	{
	}

	public void ProcessChatChannelChange(string newValue)
	{
	}

	private void ProcessAttackStatusChange(int newValue)
	{
	}

	private void ProcessJumpStatusChange(int newValue)
	{
	}

	private void OnDrivingStatusChangeEvent(int newValue)
	{
	}

	private void OnGetOffVehicleStatusChangeEvent(int newValue)
	{
	}

	private void OnGetOnAsPassengerStatusChangeEvent(int newValue)
	{
	}

	private void OnGetOnAsDriverStatusChangeEvent(int newValue)
	{
	}

	public void ProcessPlayerCurCheckPointIDChange(int oldID, int newID)
	{
	}

	public void PlayerTriggerCheckPointEffect()
	{
	}

	private UGCLevelCheckPoint GetCheckPoint(int id)
	{
		return null;
	}

	public void ProcessPlayerNextCheckPointIDChange(int oldID, int newID)
	{
	}

	private void ProcessFactionEntityChange(string newValue)
	{
	}

	private void ProcessFactionIsShowHudNameChange(bool newValue)
	{
	}

	private void ProcessFactionIsShowMapInfoChange(bool newValue)
	{
	}

	private void ProcessFactionIsShowQuickMessageChange(bool newValue)
	{
	}

	private void ProcessFactionIsShowTagChange(bool newValue)
	{
	}

	public void ProcessTeamEntityChange(string newValue)
	{
	}

	private void ProcessTeamIsShowHudNameChange(bool newValue)
	{
	}

	private void ProcessFactionIdxChange(int newValue)
	{
	}

	private void OnCustomClothSetIDChangeEvent(int newValue)
	{
	}

	private void OnCustomClothHairIDChangeEvent(int newValue)
	{
	}

	private void OnCustomClothHeadAdditiveIDChangeEvent(int newValue)
	{
	}

	private void OnCustomClothChestIDChangeEvent(int newValue)
	{
	}

	private void OnCustomClothFeetIDChangeEvent(int newValue)
	{
	}

	private void OnCustomClothLegsIDChangeEvent(int newValue)
	{
	}

	private void OnCustomClothFaceIDChangeEvent(int newValue)
	{
	}

	private void OnCustomClothChangeEvent(int newValue, UIModelAvatarBase.EWardrobeType type)
	{
	}

	private bool CheckCouldShowWithSet(UIModelAvatarBase.EWardrobeType wardrobeType)
	{
		return false;
	}

	private void OnWeaponSkinIDChangeEvent(List<object> newValue)
	{
	}

	private void OnVehicleSkinIDsChangeEvent(List<object> newValue)
	{
	}

	private void OnDisablePickUpItemsChanged(List<object> disableList)
	{
	}

	public bool IsDisablePickUp(int itemID)
	{
		return false;
	}

	private void OnAnimSkipFallingLandChangeEvent(bool newValue)
	{
	}

	private void OnBonesChangeEvent(string skeletonID)
	{
	}

	private void OnCurrentEmoteClipChanged(string emoteClipUUID)
	{
	}

	private void OnIsCurrentEmoteLoopChanged(bool v)
	{
	}

	public void PlayUGCEmoteClip(string emoteClipUUID, bool isLooping, bool overrideGamePlayControl = false)
	{
	}

	private void OnBindedCustomPlayerChange(string newEntityID)
	{
	}

	private void SwitchCollidersForBindedCustomPlayer(bool val)
	{
	}

	public void OnCameraTypeChanged(int old_type, int new_type)
	{
	}

	public void DeBugModifyCameraType(KMBEHIGOKNF cameraType)
	{
	}

	public void RefreshCameraState()
	{
	}

	private void ProcessCameraConfigChange(string newValue)
	{
	}

	private void ProcessNewUGCCameraChange(string newValue)
	{
	}

	private void OnBasicCameraCreated(GameObject obj)
	{
	}

	private void OnBasicCameraRemoved(GameObject obj)
	{
	}

	public void OnCameraTypeChanged(int newValue)
	{
	}

	public void OnCameraCullingMaskChanged()
	{
	}

	public void OnCullingMaskChanged(int newValue)
	{
	}

	private static string SkeletonPartType2BoneName(UGCSkeletonPartType type)
	{
		return null;
	}

	private UGCSkeletonBoneOwner getOrCreateSkeletonOwner()
	{
		return null;
	}

	public IKFIHMAEFEA GetOrCreateUGCPlayerAnimPort(GameObject aniObject = null)
	{
		return null;
	}

	public void InitOverrideAnimationControllers(NKNFNFMOFJM overrideAnimCtrlsConfig)
	{
	}

	public void SwitchOverrideAnimationController()
	{
	}

	public void OnBlendTreeOverrideAnimationClipsChanged()
	{
	}

	public UGCAnimationControllerComplex GetUGCAnimationPlayable(bool isCreated = false)
	{
		return null;
	}

	public UGCAnimationController GetUGCAnimationController(bool isCreated = false)
	{
		return null;
	}

	public void UGCOnAnimationControllerResUUIDChanged(string acResUUID)
	{
	}

	private void UGCOnAnimationControllerChanged(string acEntityID)
	{
	}

	private void UGCAttachAnimationController(GameObject mayAnimObject, bool isInit = false)
	{
	}

	public void UGCOnPlayerMeshChangedOrLoaded(bool isLoaded, GameObject mayAnimObject, Transform skeletonObject)
	{
	}

	private void UGCTryLazyCallUMAChanged()
	{
	}

	public int BridgingTypeID()
	{
		return 0;
	}

	public string UGCEntityID()
	{
		return null;
	}

	public IUGCValue BridgingPropGetter(long bridgingProp)
	{
		return null;
	}

	public bool BridgingPropSetter(long bridgingProp, UGCSimpleValue value)
	{
		return false;
	}

	public void CheckInfectionZombieLowBlood()
	{
	}

	private void CheckUGCMovementEvent()
	{
	}

	public void OnUpdateUGCAim(float gameTime, float deltaTime)
	{
	}

	private void CalUGCAimTarget()
	{
	}

	private void HandleAimHighlight()
	{
	}

	public Vector3 GetAttackableOffset()
	{
		return default(Vector3);
	}

	public bool CanAssistByUGC(float camDistance)
	{
		return false;
	}

	public void DispatchPhysXStateEvent(EOGPGNIDOKF prevPose, EOGPGNIDOKF newPose)
	{
	}

	private void _003COnLogicPlayerBehaviorCreated_003Eb__27_0(int newValue)
	{
	}

	private void _003COnLogicPlayerBehaviorCreated_003Eb__27_1(int newValue)
	{
	}

	private void _003Cset_CurrentCameraConfig_003Eb__113_0(float _1)
	{
	}

	private void _003Cset_CurrentCameraConfig_003Eb__113_1(string _1)
	{
	}

	private void _003Cset_CurrentCameraConfig_003Eb__113_2(string _1)
	{
	}

	private void _003Cset_CurrentCameraConfig_003Eb__113_3(Vector3 _1)
	{
	}

	private void _003Cset_CurrentCameraConfig_003Eb__113_4(Vector3 _1)
	{
	}

	private void _003Cset_CurrentCameraConfig_003Eb__113_5(float _1)
	{
	}

	private void _003Cset_CurrentCameraConfig_003Eb__113_6(float _1)
	{
	}

	private void _003Cset_CurrentCameraConfig_003Eb__113_7(int _1)
	{
	}

	private void _003Cset_CurrentCameraConfig_003Eb__113_8(int _1)
	{
	}

	private void _003Cset_CurrentCameraConfig_003Eb__113_9(int _1)
	{
	}

	private void _003Cset_CurrentCameraConfig_003Eb__113_10(int _1)
	{
	}
}
