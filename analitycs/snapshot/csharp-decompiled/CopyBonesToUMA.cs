using UMA;
using UnityEngine;

public class CopyBonesToUMA : MonoBehaviour
{
	private const string COPY_BONE_PREFIX = "Copy_";

	private Renderer m_umaRenderer;

	public GameObject targetGameObject;

	private SkinnedMeshRenderer[] skinnedRenderers;

	private UMAData m_umaData;

	private void Start()
	{
	}

	private void FindRender()
	{
	}

	private UMAData FindUMAData(GameObject go)
	{
		return null;
	}

	private void OnUMARendererFound()
	{
	}

	private void InitializeSkinnedRenderers()
	{
	}

	private bool RebindAllSkinnedRenderers()
	{
		return false;
	}

	private bool RebindSingleSkinnedRenderer(SkinnedMeshRenderer renderer, Transform boneRoot)
	{
		return false;
	}

	private Transform FindBoneRoot()
	{
		return null;
	}

	private Transform FindBoneInHierarchy(Transform root, string boneName)
	{
		return null;
	}

	private bool RebindBones(SkinnedMeshRenderer renderer)
	{
		return false;
	}
}
