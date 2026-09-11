using System;
using System.Collections.Generic;
using GCommon;
using UMA;
using UnityEngine;

namespace COW;

public class UIStatedAvatar : UIAnimedAvatar
{
	protected class InternalState : UIAvatarStateBase
	{
		public bool CurrentStateDirty;

		public uint LastSelectClothes;

		public bool LastPlayClothesChangeAnim;

		public bool LastPlayClothesIdleAnim;

		public Dictionary<string, AvatarWardrobeData> SlotClothes;
	}

	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public EffectObject e;

		internal bool _003CPlayLobbyAnimEffect_003Eb__0(EffectObject x)
		{
			return false;
		}
	}

	protected InternalState m_InternalState;

	protected UIAvatarState m_CurrentState;

	protected Transform m_HeadTF;

	protected Transform m_HipTF;

	protected Transform m_RootTF;

	private bool m_IsMatchResult;

	public bool IsMatchResultPosterAvatar;

	private List<uint> m_TriggerInNormalEffects;

	private Dictionary<int, EffectObject> m_TriggerEffectToRedisentEffect;

	private List<uint> m_TriggerWithSkeletonInNormalEffects;

	private Dictionary<uint, EffectObject> m_ResidentEffectForSkeleton;

	private Dictionary<uint, List<EffectObject>> m_TriggerEffectForSkeleton;

	private Dictionary<uint, EventClothEffectsData> m_IdtoLobbyShowClothEffectDic;

	protected uint m_delayCallIDShow;

	protected uint m_delayCallIDHide;

	private uint m_AvatarEffectShowTime;

	private uint m_AvatarEffectHideTime;

	protected bool m_currentEventEffectsVisibility;

	private bool m_IsShowSpecialIdle;

	private bool m_IsPlayingSpecial;

	private bool m_IsPlayEmoteOrGroupAnim;

	private bool m_LockState;

	protected GameObject JerseyNumberCustomGO;

	private CaptureCustomToMaterial JerseyNumberCustomComponent;

	public uint LastCustomCloth;

	public Dictionary<uint, RenderTexture> JerseyNumberTextureDic;

	protected GameObject m_GoFootHalo;

	protected GameObject m_SpotlightGO;

	protected bool IsMatchResult
	{
		private get
		{
			return false;
		}
		set
		{
		}
	}

	public bool HasEventEffectsIntervals => false;

	public bool IsPlayingSpecial
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsPlayEmoteOrGroupAnim
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public UIAvatarState GetCurrentState()
	{
		return null;
	}

	public void ClearAvatarCustomData()
	{
	}

	public bool IsCustomDataDirty()
	{
		return false;
	}

	public void ClearInternalState()
	{
	}

	public override void InitAvatar(bool isLocal, bool isPreview = false, int textureScale = 1, FrontEndPreviewComponent frontEndPreviewComponent = null, bool isTeammate = false)
	{
	}

	protected override void CharacterCreatedCallback(UMAData umaData)
	{
	}

	public Vector3 GetRightLegWorldPos()
	{
		return default(Vector3);
	}

	protected override void OnInitAvatarAfterBuild(bool isLocal)
	{
	}

	protected override void CharacterUpdateCallBack(UMAData umaData)
	{
	}

	public override void UpdateAnimator(CSSharedAvatarData aData, bool female)
	{
	}

	public void ProcessBackpackModelAndEffect()
	{
	}

	public void ProcessClothEffect()
	{
	}

	public void StopClothEffects()
	{
	}

	public void StopAnimEffectsWithoutMandatoryDisplay()
	{
	}

	protected void ProcessMaterialAnimEffect()
	{
	}

	public void ChangeLayer(int layer)
	{
	}

	protected void LoadMaterialAnimEffect()
	{
	}

	public void LoadClothEffectIfNeed()
	{
	}

	protected void PlayLobbyAnimEffect(EEffectType eEffectType, ResourceID effectResID, bool isLoop, bool isTailor, uint clothID, bool clothWithExtraEffect = false, bool vfxMandatoryDisplay = false, bool isSoloEffectTrigger = false, uint multiEffectTrigerType = 0u, bool controlBySkeleton = false, uint effectsTriggerID = 0u)
	{
	}

	protected bool GetNeedCheckTailorUnlock(bool previewEffect)
	{
		return false;
	}

	private void LoadClothesEffect()
	{
	}

	public EffectObject GetResidentEffectByTriggerEffectName(int hashVal)
	{
		return null;
	}

	public EffectObject GetResidentEffectControlBySkeletonByClothId(uint id)
	{
		return null;
	}

	public List<EffectObject> GetTriggerEffectControlBySkeletonByClothId(uint id)
	{
		return null;
	}

	private void ClearMultiStateSkeletonEffectCache(uint clothId, ClothesTriggerData skeletonData)
	{
	}

	private void RemoveTriggerInNormalEffects(uint[] triggerIDs)
	{
	}

	private void LoadClothEffect(AvatarWardrobeData wd, bool needCheckUnlock, bool forceLoadAllTriggerEffect)
	{
	}

	private void ProcessSkeletonEffect(AvatarWardrobeData wd, string slotStr)
	{
	}

	public bool ResetMultiStatePrivilegeSkeletonToDefault()
	{
		return false;
	}

	public bool PrepareMultiStatePrivilegeSkeletonEffectForPrivilegePreview()
	{
		return false;
	}

	private void ProcessNormalEffect(AvatarWardrobeData wd, string slotStr, bool isTailorCloth, bool needCheckUnlock, bool controlBySkeleton = false)
	{
	}

	private void ProcessEventEffect(AvatarWardrobeData wd, string slotStr, bool isTailorCloth, bool needCheckUnlock, bool forceLoadAll, bool hasSkeleton = false)
	{
	}

	private HashSet<ResourceID> BuildMultiStateSkeletonTriggerResources(List<EventClothEffectsData> eventClothesEffects, ClothesTriggerData skeletonData, bool hasSkeleton, bool currentModelFemale)
	{
		return null;
	}

	private bool ShouldSkipMultiStateSkeletonNormalTriggerEffect(ResourceID res, HashSet<ResourceID> multiStateSkeletonTriggerResources)
	{
		return false;
	}

	private bool IsMultiStateSkeletonTriggerID(ClothesTriggerData skeletonData, uint stateID)
	{
		return false;
	}

	private bool ContainsTriggerID(uint[] triggerIDs, uint stateID)
	{
		return false;
	}

	private void AddValidResource(HashSet<ResourceID> resources, ResourceID res)
	{
	}

	public void ShowLobbyEffectIntervals(bool needResetIntervals = false)
	{
	}

	private void _ShowLobbyEffectInterval()
	{
	}

	private void _HideLobbyEffectInterval()
	{
	}

	public void ResetAnimAndEffect()
	{
	}

	public void ResetLobbyAvatarEffect()
	{
	}

	public void ResetChangeIdle()
	{
	}

	public void ResetIdle()
	{
	}

	protected void AddAvatarLobbyEffect(EventClothEffectsData data)
	{
	}

	public void SetEventEffectsVisibilityIfNeed(bool isVisible)
	{
	}

	public void ReProcessMultiStateBoneNameRefsWhenVisibleChange(bool visible)
	{
	}

	public void ResetMultiStateSkeletonRuntimeStateBeforeInvisible()
	{
	}

	public void HideMultiStateSkeletonForSpecialAnim()
	{
	}

	public void ShowMultiStateSkeletonForSpecialAnim()
	{
	}

	protected void CallbackOnce<T>(ref Action<T> callback, T param)
	{
	}

	public override void ResetAvatar()
	{
	}

	public void LockAvatarState()
	{
	}

	public void ReleaseAvatarStateLock()
	{
	}

	public bool GetLockState()
	{
		return false;
	}

	public void UpdateState(UIAvatarState s, bool force = false)
	{
	}

	public void ForceUpdateState(UIAvatarState s)
	{
	}

	public void ClearSlotsTextures()
	{
	}

	public void RefreshJerseyNumber(string name, int jerseyNumber, uint clothId, bool isForSharer = false)
	{
	}

	public void SetJerseyNumberTexture(RenderTexture texture, uint clothId, bool cache = false, bool isForSharer = false)
	{
	}

	public void ClearJerseyNumber()
	{
	}

	public void PlayAnimOneShotEvt(string animationResID)
	{
	}

	public static void UpdateClothes(uint wId, List<uint> cs, ulong accountID, AvatarCustomData avatarCustomData = null)
	{
	}

	public static void UpdateClothes(AvatarWardrobeData wData, List<uint> cs, ulong accountID, AvatarCustomData avatarCustomData = null)
	{
	}

	public static void UpdateClothes(AvatarWardrobeData wData, UIAvatarState cs, bool removeConflictSlot, bool considerHidingTarget)
	{
	}

	public static AvatarWardrobeData FindClothesWithAnimOrEffect(IEnumerable<uint> cs)
	{
		return null;
	}

	public AvatarWardrobeData GetCurrentSlot(string slot)
	{
		return null;
	}

	protected void CheckAndUpdateState(InternalState dst, UIAvatarState src, bool isForce = false)
	{
	}

	private bool IsForceChangeRace()
	{
		return false;
	}

	protected void UpdateSpotLightAndFootHalo()
	{
	}

	protected void UpdateState(InternalState dst, bool faceDirty, bool colorDirty, bool clothesDirty, bool bagDirty, bool avatarAnimDirty, out bool hidingSet, out string hidingSlot, bool forceUpdate = false)
	{
		hidingSet = default(bool);
		hidingSlot = null;
	}

	private void AddDefaultClothesIfNeeded(CSSharedAvatarData aData, uint avatarId, bool faceDirty, bool hasHair, bool hasFace, bool hasHeadAdditive, bool hasChest, bool hasLegs, bool hasFeet, bool hasSet, bool isforce = false, bool forceDefault = false, bool forceDefaultSetNotReady = false)
	{
	}

	private void CheckAndUpdateFaceClothes(InternalState dst, UIAvatarState src, ref bool faceDirty, ref bool colorDirty, ref bool clothesDirty, ref bool bagDirty, ref bool animDirty, bool isForce = false)
	{
	}

	private bool CheckClothesCustomData(uint cloth, UIAvatarState src, InternalState dst)
	{
		return false;
	}

	private bool CheckAndUpdateField(ref bool dst, bool src)
	{
		return false;
	}

	private bool CheckAndUpdateField(ref uint dst, uint src)
	{
		return false;
	}

	private bool CheckAndUpdateField(ref uint dst, UIAvatarStateTriggerValue<uint> src)
	{
		return false;
	}

	private int OriginalClothesAbNotReadyCount(uint avatarId, bool hasSet, bool hasHair, bool hasFace, bool hasHeadAdditive, bool hasChest, bool hasLegs, bool hasFeet)
	{
		return 0;
	}

	public void UpdateLobbyFootHalo()
	{
	}

	public void ClearFootHalo()
	{
	}

	public override void UpdateSpotlight()
	{
	}

	private bool _CheckSpotLightOrder(ref int curOrder, byte checkType)
	{
		return false;
	}

	public void ClearSpotlight()
	{
	}

	public override void SetSpotLightVisible(bool isVisible)
	{
	}

	private void _003C_ShowLobbyEffectInterval_003Eb__61_0()
	{
	}

	private void _003C_HideLobbyEffectInterval_003Eb__62_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_InitAvatar(bool P0, bool P1, int P2, FrontEndPreviewComponent P3, bool P4)
	{
	}

	public new void _003C_003EiFixBaseProxy_CharacterUpdateCallBack(UMAData P0)
	{
	}

	public void _003C_003EiFixBaseProxy_CharacterCreatedCallback(UMAData P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInitAvatarAfterBuild(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_UpdateAnimator(CSSharedAvatarData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_ResetAvatar()
	{
	}

	public void _003C_003EiFixBaseProxy_UpdateSpotlight()
	{
	}

	public void _003C_003EiFixBaseProxy_SetSpotLightVisible(bool P0)
	{
	}
}
