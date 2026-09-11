using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class TransformAvatarEffect : MonoBehaviour
{
	private GameObject m_OwnerAvatar;

	private Transform m_CachedTransform;

	private List<GameObject> m_Effects;

	public void Init(GameObject go)
	{
	}

	public void PlayTransformAvatarAnimEffect(AnimationEvent evt)
	{
	}

	private void PlayAnimEffectInternal(AnimationEvent evt)
	{
	}

	public void ClearEffect()
	{
	}

	private void PlayTransformAvatarEffect(uint id)
	{
	}

	private void PlayTransformAvatarAnimEffect(GameObject prefab, AvatarEffect.EEffectGroup group, int iID = 0, AvatarEffect.EEffectType type = AvatarEffect.EEffectType.None, bool keepWorldPosition = false, Transform tr = null)
	{
	}

	private void ProcessBoneNameRefs(GameObject go, AvatarEffect.EEffectGroup group, string prefabName, bool keepWorldPosition = false)
	{
	}

	public bool ScaleInLocalSpace(GameObject o)
	{
		return false;
	}
}
