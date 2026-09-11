using System.Collections.Generic;
using COW;
using COW.GamePlay;
using UnityEngine;
using UnityEngine.Playables;

public class AdditiveEffectPlayableBehaviour : PlayableBehaviour
{
	public Material OverideMaterial;

	public GameObject BoundObject;

	public bool IsTransparent;

	public bool EnableTweenMaterialProperty;

	private List<TweenMaterialPropertyConfig> m_TweenConfigs;

	private List<int> m_TweenPropertyIDs;

	private int m_EffectIndex;

	private Player m_TargetPlayer;

	private UIMaleAvatar m_TargetUIAvatar;

	private bool m_IsBoundToUIAvatar;

	private SkinnedMeshRenderer m_TargetRenderer;

	private SkinnedMeshRenderer[] m_TransformRenderers;

	private bool m_EffectsHidden;

	private bool m_TransformEffectHidden;

	private List<SkinnedMeshRenderer> m_EffectHeadRenderers;

	private bool m_BodyHideUsedForceRenderingOff;

	private bool m_OriginalUpdateWhenOffscreen;

	private Bounds m_OriginalLocalBounds;

	private List<bool> m_OriginalTransformUpdateWhenOffscreen;

	private List<Bounds> m_OriginalTransformLocalBounds;

	private List<bool> m_OriginalEffectHeadUpdateWhenOffscreen;

	private List<Bounds> m_OriginalEffectHeadLocalBounds;

	private Animator m_TargetAnimator;

	private AnimatorCullingMode m_OriginalAnimatorCullingMode;

	private List<Material> m_OriginalMaterials;

	private List<int> m_OriginalRenderQueues;

	private static Dictionary<PlayableGraph, int> s_GraphExecuteCount;

	public void SetTweenConfigs(List<TweenMaterialPropertyConfig> configs)
	{
	}

	private bool ShouldHideBodyViaForceRenderingOff()
	{
		return false;
	}

	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	private Camera GetCurrentLobbyCamera()
	{
		return null;
	}

	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	public override void OnGraphStop(Playable playable)
	{
	}

	public override void PrepareFrame(Playable playable, FrameData info)
	{
	}

	private void ApplyTweenValue(TweenMaterialPropertyConfig config, int propertyID, float progress)
	{
	}

	private void OnPriorityRejected(int effectIndex)
	{
	}

	private void RestoreRendererVisibility()
	{
	}

	private void RestoreClothEffectsVisibility()
	{
	}

	private void ApplyForceRenderingOff(SkinnedMeshRenderer renderer, int unused)
	{
	}

	private void RestoreForceRenderingOff(SkinnedMeshRenderer renderer)
	{
	}

	private void ApplyForceRenderingOffTransform(SkinnedMeshRenderer renderer, int index)
	{
	}

	private void RestoreForceRenderingOffTransform(SkinnedMeshRenderer renderer, int index)
	{
	}

	private void ApplyForceRenderingOffEffectHead(SkinnedMeshRenderer renderer, int index)
	{
	}

	private void RestoreForceRenderingOffEffectHead(SkinnedMeshRenderer renderer, int index)
	{
	}

	private void CollectAndModifyRenderQueues(Renderer renderer, int newQueue)
	{
	}

	private void RestoreRenderQueues()
	{
	}
}
