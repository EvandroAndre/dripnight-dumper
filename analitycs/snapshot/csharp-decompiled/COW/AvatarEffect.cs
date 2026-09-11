using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UMA;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Rendering;

namespace COW;

public class AvatarEffect : MonoBehaviour
{
	public enum EEffectGroup
	{
		Default,
		External,
		IdleSpecial,
		TriggerEffect,
		SkeletonEffect,
		SkeletonTriggerEffect,
		WeaponAnimEffect,
		SpectatorSkyEffect,
		DelayDelete,
		LoopRandomEffect
	}

	public enum EEffectType
	{
		None,
		Emotion,
		GroupAnim,
		Transform,
		LastKillCustom,
		WeaponFire,
		SuperEmote,
		AvatarPose,
		DuoEmotePreview,
		DuoEmote,
		DuoEmoteIdle,
		CollectionAction,
		SkillEffect,
		ClothesVFXPose,
		FlightActionVFX,
		FinishMove,
		CooperateEmotePreview,
		CooperateRandomEffect
	}

	public enum EPlayerLastKillState
	{
		None,
		TeamLastKill,
		MatchLastKill
	}

	private class BoneNameRefOriginalInfo
	{
		public BoneNameRef BoneNameRef;

		public Transform BoneNameRefTrans;

		public Transform OriginalParent;

		public Vector3 OriginalLocalPos;

		public Quaternion OriginalLocalRot;

		public Vector3 OriginalLocalScale;

		public static BoneNameRefOriginalInfo Create(GameObject go, BoneNameRef bf)
		{
			return null;
		}

		public void RecoverToOriginal()
		{
		}
	}

	private class AnimEffectPooledInfo
	{
		public GameObject Go;

		public BoneNameRef[] CachedBoneNameRefs;

		private ResourceID ResId;

		private PlayableDirector Director;

		private Vector3 OriLocalPos;

		private Quaternion OriLocalRot;

		private Vector3 OriLocalScale;

		private List<BoneNameRefOriginalInfo> BoneNameRefOriginalInfos;

		private ReusableObject ReuseableScript;

		private bool ReuseableScriptEnableState;

		public bool HasChangedInVerticalCameraMode;

		public static AnimEffectPooledInfo Acquire(ResourceID resId, Transform parent)
		{
			return null;
		}

		public void Release()
		{
		}

		private bool IsBeingDelayDestroyed()
		{
			return false;
		}

		private void CleanupRefsAndDestroy()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass104_0
	{
		public GameObject effct;

		internal bool _003CTraverseClothesAndInstantTriggerEffect_003Eb__0(GameObject x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass119_0
	{
		public GameObject effct;

		internal bool _003CProcessSkeletonEffect_003Eb__0(GameObject x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass125_0
	{
		public GameObject effct;

		internal bool _003CProcessSpectatorSkyEffect_003Eb__0(GameObject x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass52_0
	{
		public AvatarEffect _003C_003E4__this;

		public int emoteID;

		internal void _003CCooperateRandomEffect_003Eb__0(uint tid, bool ret, UnityEngine.Object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass56_0
	{
		public AvatarEffect _003C_003E4__this;

		public AnimationEvent evt;

		public EEffectType type;

		public bool needSkip;

		public bool createEffectOnlyOnce;

		public Transform tr;

		internal void _003CPlayAnimEffectInternal_003Eb__0(uint tid, bool ret, UnityEngine.Object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass60_0
	{
		public GameObject sourceCameraGo;

		internal void _003CCopyCameraPanZoomSettings_003Eb__0(bool show)
		{
		}
	}

	private Renderer m_renderer;

	private SkinnedMeshRenderer m_UMARenderer;

	private List<Material> m_UMARendererMat;

	private bool m_FindRenderFlag;

	private List<int> m_avatarMatIDList;

	private List<uint> m_asyncLoadingList;

	private bool m_foundSpecialEffect;

	private Player m_owner;

	private GameObject m_MultiFlightMovePreviewGo;

	private PreviewTeamFlightView m_MultiFlightMovePreviewFlightView;

	private static readonly int s_MatPropIDStretchRatio;

	private UIMaleAvatar m_LobbyAvatar;

	private GameObject m_BackpackTemp;

	private LazyDictionary<int, List<AnimEffectPooledInfo>> m_AnimEffectsPoolGet;

	private LazyDictionary<int, List<GameObject>> m_animEffects;

	private Transform m_TransformerEffect;

	private LazyDictionary<int, List<string>> m_animEffectsNameDict;

	private Dictionary<ResourceID, List<GameObject>> m_lobbyAnimEffectDict;

	private uint m_CooperateRandomEffectCallCount;

	private IUmaAvatar m_Avatar;

	private Entity _003COwnerPlayer_003Ek__BackingField;

	private Transform m_CachedTransform;

	private GameObject m_FinishMoveUIEffect;

	private bool m_isEnableUGCAnimEffectScale;

	private Vector3 m_UGCAnimEffectScale;

	private List<ResourceID> m_PrivilegeList;

	private List<GameObject> m_TriggerObjs;

	private ClothesVFXEffectChange m_Script;

	private const uint MULTI_STATE_TRIGGER_ID_KILL = 3u;

	private const uint MULTI_STATE_TRIGGER_ID_BE_KILLED = 31u;

	private const uint MULTI_STATE_TRIGGER_ID_KILL_AND_BE_KILLED = 37u;

	private const uint MULTI_STATE_BEHAVIOR_KILL = 3u;

	private const uint MULTI_STATE_BEHAVIOR_USE_MEDKIT = 12u;

	private const uint MULTI_STATE_BEHAVIOR_BE_KILLED = 18u;

	private uint m_MultiStateSkeletonClothId;

	private bool m_MultiStateHasLastPreviewState;

	private bool m_LastMultiStateUseSecondaryState;

	private uint[] m_MultiStateSpecialStateIDs;

	private uint[] m_MultiStateSpecial1StateIDs;

	private Dictionary<uint, List<GameObject>> m_MultiStatePrivilegeTriggerObjs;

	private LazyDictionary<int, List<GameObject>> m_AnimEffects => null;

	public Transform TransformerEffect => null;

	private LazyDictionary<int, List<string>> m_AnimEffectsNameDict => null;

	private Dictionary<ResourceID, List<GameObject>> m_LobbyAnimEffectDict => null;

	public IUmaAvatar Avatar => null;

	public Entity OwnerPlayer
	{
		get
		{
			return _003COwnerPlayer_003Ek__BackingField;
		}
		set
		{
			_003COwnerPlayer_003Ek__BackingField = value;
		}
	}

	public Transform CachedTransform => null;

	public void SetInGamePlayer(Entity p)
	{
	}

	public void ClearMultiFlightMovePreview()
	{
	}

	public void ResetCooperateRandomEffectCallCount()
	{
	}

	public void PlayFistAttack(int right)
	{
	}

	public void PlayLobbyAnimEffect(ResourceID id, MNMBLBKENMK quality = MNMBLBKENMK.Total)
	{
	}

	public void PlayEmoteAnimEffect(string ResourceIDName)
	{
	}

	private void PushAsyncLoadingTicket(uint ticket)
	{
	}

	public void Recover3DLobbyBG()
	{
	}

	public void PlayAnimEffectByName(string ResourceIDName)
	{
	}

	public void CooperateRandomEffect(AnimationEvent evt)
	{
	}

	public void PlayCollectionActionEffectByName(string ResourceIDName)
	{
	}

	public void PlayAnimEffectCreateOnce(AnimationEvent evt)
	{
	}

	public void PlayAnimEffect(AnimationEvent evt)
	{
	}

	private void PlayAnimEffectInternal(AnimationEvent evt, bool createEffectOnlyOnce)
	{
	}

	public void PlayAnimEffectWithPrefab(GameObject prefab)
	{
	}

	public void PlayIdleAnimEffect(GameObject prefab)
	{
	}

	public void PlayAnimEffectKeepWorldPositionDelayDelete(GameObject prefab)
	{
	}

	private void CopyCameraPanZoomSettings(Camera sourceCamera, GameObject targetGameObject, EEffectType type)
	{
	}

	private void AddBgCameraToClothesVFXPostEffect(GameObject targetGameObject)
	{
	}

	private ResourceID GetResourceIDByType(EEffectType type, int iID, ref Transform tr, float animFloatParam = 0f)
	{
		return default(ResourceID);
	}

	private EEffectType ResolveDuoEmoteEffectType(EEffectType type)
	{
		return EEffectType.None;
	}

	private EEffectType ResolveCooperateEmoteEffectType(EEffectType type, int iID)
	{
		return EEffectType.None;
	}

	private EDuoEmoteStage GetCurrentDuoEmoteStage()
	{
		return EDuoEmoteStage.None;
	}

	public void SetUGCAnimEffectScale(Vector3 scale)
	{
	}

	public void PlayAnimEffect(GameObject prefab, EEffectGroup group, int iID = 0, EEffectType type = EEffectType.None, bool needSkip = false, bool keepWorldPosition = false, Transform tr = null, bool createEffectOnlyOnece = false, float animFloat = 0f, bool fistAnim = false, Action fistCallBack = null)
	{
	}

	private bool TryHandleMultiFlightMovePreviewEffect(GameObject go, EEffectGroup group)
	{
		return false;
	}

	private void BindMultiFlightMovePreviewAvatar(UIMaleAvatar avatar, PreviewTeamFlightView flightView, GameObject vfxGo)
	{
	}

	private static Transform GetMultiFlightMovePreviewVfxParent(UIMaleAvatar avatar, string boneName)
	{
		return null;
	}

	private void ClearMultiFlightMovePreviewGo()
	{
	}

	private bool IsMultiFlightMovePreviewContext()
	{
		return false;
	}

	private void EnsureLobbyAvatar()
	{
	}

	private void ProcessLastKillCustomGo(uint ID, ResourceID resID, GameObject go)
	{
	}

	public void PlayLobbyAnimEffect(GameObject prefab, ResourceID resId, EEffectGroup group, int iID = 0, EEffectType type = EEffectType.None, int objIdx = 0)
	{
	}

	private void ProcessBoneNameRefsWithNoSave(GameObject go, ResourceID resId)
	{
	}

	public void SetBackpackObj(GameObject obj)
	{
	}

	private void ProcessBoneNameRefsWhenPoolGet(ResourceID resId, AnimEffectPooledInfo pooledInfo, EEffectGroup group, string prefabName, bool keepWorldPosition = false)
	{
	}

	private void ProcessBoneNameRefs(GameObject go, EEffectGroup group, string prefabName, bool keepWorldPosition = false, EEffectType type = EEffectType.None)
	{
	}

	private bool ProcessOneBoneNameRefInternal(GameObject go, BoneNameRef bf, bool keepWorldPosition)
	{
		return false;
	}

	private void ProcessCastShadow(GameObject go, ShadowCastingMode shadowCastingMode)
	{
	}

	public bool ScaleInLocalSpace(GameObject o)
	{
		return false;
	}

	public bool HasEmoteEffect(EEffectGroup group)
	{
		return false;
	}

	public void SetEmoteEffectActive(bool active)
	{
	}

	private void SetEmoteEffectActive(EEffectGroup group, bool active)
	{
	}

	public void ClearEffects(EEffectGroup group)
	{
	}

	public void CopyFrom(AvatarEffect raw)
	{
	}

	public void ResetTransformerEffectParent(Transform parent)
	{
	}

	public void ClearLobbyAnimeEffect()
	{
	}

	public bool DoesLobbyAnimEffectAlreadyExisted(ResourceID resId)
	{
		return false;
	}

	public List<GameObject> GetEffectsByType(EEffectGroup group)
	{
		return null;
	}

	public void EnableSpecialEffect(bool bEnable)
	{
	}

	private void StartSpecialEffect()
	{
	}

	private void StopSpecialEffect()
	{
	}

	private void FindSpecialEffect()
	{
	}

	private void FindUMARendererChild()
	{
	}

	public void BrightnessStretchEffect(float stretchRatio)
	{
	}

	public void ShowPrivilegeTriggerEffect()
	{
	}

	private bool IsNeedShowNormalTriggerEffect(uint effTriggerId, uint triggerEffectAnimID)
	{
		return false;
	}

	public void PlayTriggerEffect()
	{
	}

	private void TraverseClothesAndInstantTriggerEffect(List<uint> clothes, bool isFemale, FrontEndPreviewComponent comp)
	{
	}

	private List<GameObject> ProcessSkeletonEffect(ResourceID res, EEffectGroup group, string slotStr, bool playTriggerImmediately = true)
	{
		return null;
	}

	public void SwitchWeaponSkin()
	{
	}

	public void SendFollowDanceEmoteToGroup(int emoteID)
	{
	}

	public void StopEmoteByEvent(int emoteID)
	{
	}

	private void OnDestroy()
	{
	}

	public void PlayTreasureHuntEffect()
	{
	}

	public void ProcessSpectatorSkyEffect(ResourceID res)
	{
	}

	public void ChangeSpectatorSkyEffectColor(Color color)
	{
	}

	public void HideSpectatorSkyEffect()
	{
	}

	public bool PrepareMultiStateSkeletonEffectForPrivilegePreview()
	{
		return false;
	}

	public bool TryHandleMultiStatePrivilegeStopAnimEffects(EEffectGroup group)
	{
		return false;
	}

	private bool TryPlayMultiStatePrivilegeTrigger(List<uint> clothes, bool isFemale, FrontEndPreviewComponent comp)
	{
		return false;
	}

	private bool PrepareMultiStateSkeletonEffectForPrivilegePreview(List<uint> clothes, bool isFemale)
	{
		return false;
	}

	private void ApplyMultiStatePrivilegePreviewConfig(bool useSecondaryState)
	{
	}

	private bool TryGetCurrentMultiStatePrivilegeUseSecondaryState(out bool useSecondaryState)
	{
		useSecondaryState = default(bool);
		return false;
	}

	private bool TryGetMultiStatePrivilegeUseSecondaryState(List<uint> clothes, FrontEndPreviewComponent comp, out bool useSecondaryState)
	{
		useSecondaryState = default(bool);
		return false;
	}

	private bool IsMultiStatePrivilegePreviewReady()
	{
		return false;
	}

	private List<uint> BuildMultiStatePreviewClothesTempList(List<uint> clothes)
	{
		return null;
	}

	private bool IsMultiStateEventEffectMatchedCurrentPreview(EventClothEffectsData eff, uint effectItemID, FrontEndPreviewComponent comp)
	{
		return false;
	}

	private bool IsMultiStateSpecialPreviewTrigger(uint triggerID)
	{
		return false;
	}

	private bool IsMultiStateSpecial1PreviewTrigger(uint triggerID)
	{
		return false;
	}

	private bool MultiStateEventTriggerContainsBehavior(uint triggerID, uint behaviorType)
	{
		return false;
	}

	private bool ContainsMultiStateID(uint[] ids, uint id)
	{
		return false;
	}

	private void AddMultiStateTriggerObjects(uint stateID, List<GameObject> objects)
	{
	}

	private void ClearMultiStateSkeletonPreviewIfNeeded()
	{
	}

	public bool TryResetMultiStatePrivilegeSkeletonToDefault()
	{
		return false;
	}

	private void _003CPlayEmoteAnimEffect_003Eb__48_0(uint tid, bool ret, UnityEngine.Object res)
	{
	}
}
