using System;
using UMA;
using UnityEngine;

public class RunTimeEffectManager : MonoBehaviour
{
	[Serializable]
	public class EffectElement
	{
		public Transform m_EffectTransForm;

		public string m_TargetRootName;

		public string m_TargetBoneName;

		public bool ScaleWithParent;

		public Transform TargetTransform;
	}

	public EffectElement[] m_EffectElements;

	private void Awake()
	{
	}

	private static bool ScaleInLocalSpace(GameObject o)
	{
		return false;
	}

	public void InitEffectElements()
	{
	}

	private Transform FindTransformByName(Transform root, string name)
	{
		return null;
	}

	public static void ProcessBoneNameRefs(GameObject go, GameObject parentGo)
	{
	}

	public static bool ProcessBoneNameRefsWithAvatar(GameObject vfxGo, GameObject parentGO, IUmaAvatar avatar, bool processForBackPack = false)
	{
		return false;
	}

	private static bool ProcessBoneNameRefsInAvatarPrefab(GameObject vfxGo, GameObject prefab, IUmaAvatar avatar)
	{
		return false;
	}
}
