using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIPetAvatar : Entity
{
	private sealed class _003C_003Ec__DisplayClass26_0
	{
		public Action<uint, UIPetAvatar> petAvatarCreatedCallback;

		public uint petId;

		public uint skinId;

		public bool playPetLoopIdleSound;

		public FrontEndPreviewComponent frontEndPreviewComponent;

		public bool needPlaneShadow;

		internal void _003CCreateAvatar_003Eb__0(uint ticket, bool succeeded, UnityEngine.Object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass58_0
	{
		public PetActionType acition;

		internal bool _003CGetActionSound_003Eb__0(PetActionData temp)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass59_0
	{
		public PetActionType acition;

		internal bool _003CGetActionMoodSound_003Eb__0(PetActionData temp)
		{
			return false;
		}
	}

	private uint m_PetID;

	private uint m_SkinId;

	private Animation m_animator;

	private UIItemInputHandler m_AvatarInput;

	private BoxCollider m_boxCollider;

	private bool m_CanClick;

	private string keep_animation_loop;

	private uint keep_animation_loop_id;

	private bool start_random_play;

	private const float random_time = 8f;

	private float time_conter;

	private static GameObject Effect_Upgrade;

	private static GameObject Effect_Feed;

	private static GameObject Effect_FeedMore;

	private GameObject vfx_pet_lobby;

	private GameObject vfx_petfood;

	private GameObject vfx_petfood_multi;

	private Dictionary<string, List<GameObject>> effect_dic;

	private FeedType food_action_flag;

	private string current_action;

	public Action<bool> IsEmoteChange;

	private bool m_PlayPetLoopIdleSound;

	private AudioResource IdleAudioRes;

	private FrontEndPreviewComponent m_FrontEndPreviewComponent;

	private float OffsetX;

	private float OffsetY;

	private bool m_PlayLoopIdle;

	private float m_LoopIdleCount;

	private Vector3 pressPos;

	private Vector3 releasePos;

	public Animation Animation => null;

	public static uint CreateAvatar(uint petId = 0u, uint skinId = 0u, FrontEndPreviewComponent frontEndPreviewComponent = null, bool playPetLoopIdleSound = false, bool needPlaneShadow = false, Action<uint, UIPetAvatar> petAvatarCreatedCallback = null)
	{
		return 0u;
	}

	private static void OnAsyncLoadPetGameObjectFailed(Action<uint, UIPetAvatar> petAvatarCreatedCallback)
	{
	}

	private static void OnPetGameObjectCreated(uint ticket, GameObject petGo, uint petId, uint skinId, bool playPetLoopIdleSound, FrontEndPreviewComponent frontEndPreviewComponent, bool needPlaneShadow, Action<uint, UIPetAvatar> petAvatarCreatedCallback)
	{
	}

	public BoxCollider GetPetCollider()
	{
		return null;
	}

	private void Awake()
	{
	}

	private static void InitPetAnimClip(UIPetAvatar pet_avatar)
	{
	}

	public uint GetPetID()
	{
		return 0u;
	}

	public uint GetPetSkinId()
	{
		return 0u;
	}

	public void DisActiveLobbyEffect()
	{
	}

	public void SetLobbyEffect(Vector3 position)
	{
	}

	private void UnLoadLobbyEffect()
	{
	}

	public void SetInputEnable(bool inputEnable)
	{
	}

	public void SetClickenabled(bool enabled)
	{
	}

	public void SetBoxColiderenabled()
	{
	}

	public void SetCastShadow(bool castShadow, EFrontendPlannarShadowType ePlannarShadowType = EFrontendPlannarShadowType.Main)
	{
	}

	private void Update()
	{
	}

	private void CheckPlayIdleSound()
	{
	}

	private void CheckPetOnClick()
	{
	}

	private Camera GetCameraByCurrentNavigation()
	{
		return null;
	}

	private void DoPetLobbyClick(Ray ray)
	{
	}

	private void DoPetViewClick(Ray ray)
	{
	}

	private void CheckAnimationPlayState()
	{
	}

	private void CheckNeedRandomPlayAction(float time)
	{
	}

	private uint GetRandomNameInLevelUnlock()
	{
		return 0u;
	}

	private string GetActionNameByType(PetActionType acition)
	{
		return null;
	}

	private string GetActionNameByID(int action_id)
	{
		return null;
	}

	private ResourceID GetActionSound(PetActionType acition)
	{
		return default(ResourceID);
	}

	private ResourceID GetActionMoodSound(PetActionType acition)
	{
		return default(ResourceID);
	}

	public void PlayAnimationRandom()
	{
	}

	public void StopAnimationPlay()
	{
	}

	public void PlayAnimation(PetActionType action, bool loop = false)
	{
	}

	private void GetFoodVFXAnimation(bool is_multi)
	{
	}

	public bool CheckPetActionReady()
	{
		return false;
	}

	public void UGCPlayAnimationLoop(string name)
	{
	}

	public void PlayAnimation(uint id, bool loop = false)
	{
	}

	private void PlayAnimation(PetActionData data)
	{
	}

	private void PlayAnimation(string actionName, PetActionType actionType)
	{
	}

	public void PlayAnimationWithSound(PetActionData data)
	{
	}

	private void SetActionVFX(PetActionData data)
	{
	}

	public static void SetPetEffect(Vector3 position)
	{
	}

	private void ProcessBoneNameRefs(List<GameObject> effect_list)
	{
	}

	private bool ScaleInLocalSpace(GameObject o)
	{
		return false;
	}

	public static void UnLoadPetEffect()
	{
	}

	public static void ShowUpgradeEffect()
	{
	}

	private static void ShowFeedEffect()
	{
	}

	private static void ShowFeedMoreEffect()
	{
	}

	protected override void OnOnDestroy()
	{
	}

	private void OnDisable()
	{
	}

	private void ResetLoopIdleState(bool loopState)
	{
	}

	public void SetRenderLayer(int layer)
	{
	}

	public void SetLightLayer(int layer)
	{
	}

	public void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}
}
