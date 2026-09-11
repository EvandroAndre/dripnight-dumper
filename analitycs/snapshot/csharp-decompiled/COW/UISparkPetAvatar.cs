using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UISparkPetAvatar : Entity
{
	private SparkPetConfig m_SparkPetConfig;

	private Animator m_Animator;

	private UISparkPetInputHandler m_InputHandler;

	private BoxCollider m_BoxCollider;

	private ESparkAvatarType m_SparkAvatarType;

	private ESparkAvatarOrigin m_SparkAvatarOrigin;

	private EFriend.SparkState m_SparkState;

	private SparkPetCosmeticManager m_CosmeticManager;

	private SparkPetAvatarInfoComponent m_SparkPetAvatarInfoComponent;

	private SparkPetEffect m_SparkPetEffect;

	private UISparkPetSocialAreaLightAdjuster m_SparkPetSocialAreaLightAdjuster;

	private float m_BuddySpacing;

	private float m_AnimLoopTimer;

	private string m_CurrentAnimTrigger;

	private bool m_IsAnimLoopInit;

	private bool m_IsAnimLoopEnabled;

	private bool m_IsPlayingLoopAnim;

	private static readonly string[] BABY_ANIM_TRIGGERS;

	private static readonly string[] EVOLUTION_ANIM_TRIGGERS;

	private static readonly string[] ULTIMATE_ANIM_TRIGGERS;

	private UIModelSparkPet m_ModelSparkPet;

	private GameObject m_AnimSoundObj;

	private GameObject m_DyeVFXObject;

	private BoneNameRefManager m_DyeVFXBoneNameRefManager;

	private uint m_DyeVFXStageID;

	private uint m_ColorID;

	private int m_ColorResourceIndex;

	private bool m_HasColorResource;

	private const float VFX_LEVELUP_LIFETIME = 3f;

	private VisualInstanceHolder m_LevelUpVFXHolder;

	public float BuddySpacing
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public BoxCollider SparkPetBoxCollider => null;

	public UISparkPetInputHandler InputHandler => null;

	public uint StageID => 0u;

	public void InitSparkPetAvatar(uint ticket, GameObject petGo, SparkPetConfig sparkPetConfig, Action<uint, UISparkPetAvatar, uint> sparkPetAvatarCreatedCallback, ESparkAvatarType eSparkAvatarType, ESparkAvatarOrigin eSparkAvatarOrigin, uint[] appearanceItemIds = null, EFriend.SparkState sparkState = EFriend.SparkState.SparkState_ACTIVE, bool showBeSummonedAnim = false)
	{
	}

	public void PlaySparkPetIdleAnim()
	{
	}

	public void SetAnimLoopEnabled(bool enable)
	{
	}

	public void ChangeInputHandleEnable(bool isShow)
	{
	}

	public void SwitchToRecoveryActiveState()
	{
	}

	public void ReplaceMaterial(EFriend.SparkState sparkState)
	{
	}

	public void UpdateBoxCollider(EFriend.SparkState sparkState)
	{
	}

	private void InitSparkPetAnimator(Animator sparkPetAnimator, ResourceID sparkPetAnimatorRes)
	{
	}

	public void SetTriggetAnim(string triggerName)
	{
	}

	public void PlaySharePose()
	{
	}

	public void PlaySharePoseFirstFrame()
	{
	}

	public void PlayAnim(string name)
	{
	}

	public void ResetTriggers()
	{
	}

	public void SetOverrideAnim(AnimationClip clip, string clipName)
	{
	}

	private AnimationClip GetAnimClip(RuntimeAnimatorController controller, bool baseClip, string clipName)
	{
		return null;
	}

	public void InitSparkPetAnimClip()
	{
	}

	private void OverrideSparkAnim(ResourceID sparkPetAnimRes, string animationName)
	{
	}

	public void OverrideSummonAnim()
	{
	}

	public void OverrideBeSummonedAnim()
	{
	}

	protected override void OnAwake()
	{
	}

	protected override void OnStart()
	{
	}

	protected override void OnOnDestroy()
	{
	}

	public ESparkAvatarType GetSparkAvatarType()
	{
		return ESparkAvatarType.None;
	}

	public ESparkAvatarOrigin GetSparkAvatarOrigin()
	{
		return ESparkAvatarOrigin.None;
	}

	public void ApplyDyeColor(uint colorID)
	{
	}

	public void SetDyeColor(uint colorID)
	{
	}

	public void UpdateCosmetics(SparkPetCosmeticData cosmeticData)
	{
	}

	public void LoadCosmeticsFromAppearanceItems(uint[] appearanceItemIds)
	{
	}

	public void UpdateCosmeticItem(ESparkPetCosmeticType cosmeticType, ResourceID resourceID)
	{
	}

	public void ClearCosmetics()
	{
	}

	private void ApplyDyeMaterialColor(bool hasColorResource, int colorResourceIndex)
	{
	}

	private void ApplyDyeMaterialColor(bool hasColorResource, int colorResourceIndex, EFriend.SparkState sparkState)
	{
	}

	private void SetMaterialColorIndex(Material material, bool hasColorResource, int colorResourceIndex)
	{
	}

	private void ApplyDyeVFXColor(bool hasColorResource, int colorResourceIndex, bool activeVfx = true)
	{
	}

	public void RefreshDressUpHiddenMaterials()
	{
	}

	private void ApplyDyeVFXBoneRef(GameObject vfxObject)
	{
	}

	private void ReleaseDyeVFXBoneNameRefManager()
	{
	}

	private void Update()
	{
	}

	private void UpdateAnimLoop()
	{
	}

	private void InitAnimLoop()
	{
	}

	private void PlayRandomLoopAnim(ESparkPetStage stage)
	{
	}

	private string[] GetAnimTriggersForStage(ESparkPetStage stage)
	{
		return null;
	}

	public void ResetAnimLoop()
	{
	}

	public void OnAnimStateEnter(string stateName, AnimatorStateInfo stateInfo)
	{
	}

	public void OnAnimStateExit(string stateName, AnimatorStateInfo stateInfo)
	{
	}

	public void ClearAllSparkPetEffects()
	{
	}

	private void ShowDialogueAfterAnim(string stateName)
	{
	}

	private SparkDialogueConfig FindDialogueByConditionAndTemper(string condition, uint temperID, uint stageID)
	{
		return null;
	}

	private List<SparkDialogueConfig> GetAllSparkDialogueConfigs()
	{
		return null;
	}

	public uint GetSparkStage()
	{
		return 0u;
	}

	public EFriend.SparkState GetSparkState()
	{
		return EFriend.SparkState.SparkState_NONE;
	}

	private void PlayAnimSound(string stateName)
	{
	}

	private void StopAnimSound()
	{
	}

	private void OnInGameFilterChanged(object[] datas)
	{
	}

	public void RefreshSocialAreaLight()
	{
	}

	private bool IsCurrentNavigationProfile()
	{
		return false;
	}

	public void UpdateCosmetic(object[] datas)
	{
	}

	public void PlayLevelUpVFX()
	{
	}

	private void OnLevelUpVFXCreated(GameObject vfxInstance)
	{
	}

	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	public void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	public void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}
}
