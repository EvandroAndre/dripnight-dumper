using GCommon;
using UnityEngine;

namespace COW;

public class UIAvatarTransformer
{
	public GameObject root;

	public bool originalIsFemale;

	private Renderer[] m_renders;

	public AvatarEffect rawAvateaEffect;

	public SkinnedMeshRenderer[] skinnedMeshRenderers;

	public ParticleSystemRenderer[] particleSystems;

	public MeshRenderer[] meshRenderers;

	public UIAvatarInputHandler rawUIAvatarInputHandler;

	public Animator rawPlayerAnimator;

	public ResourceID modelResId;

	public TransformData transformData;

	public uint transformLevel;

	public GameObject rawAvatarGo;

	public void SetVisible(bool value)
	{
	}

	public void MakeAllTransformEffectVisible(bool flag)
	{
	}

	public void Clear()
	{
	}
}
