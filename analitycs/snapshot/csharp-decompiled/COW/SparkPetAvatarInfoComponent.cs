using UnityEngine;
using proto;

namespace COW;

public class SparkPetAvatarInfoComponent : MonoBehaviour
{
	public Animator animator;

	public UISparkPetInputHandler avatarInput;

	public BoxCollider boxCollider;

	public GameObject[] hideMaterialByDressUp;

	public GameObject[] stateEffects;

	public Material replacementMaterialDeath;

	public Material replacementMaterial;

	public GameObject vfxPrefabRef;

	public SkinnedMeshRenderer targetRenderers;

	public int materialIndex;

	private Material m_OriginalMaterial;

	private Material m_InstancedReplacementMaterial;

	private Material m_InstancedReplacementMaterialDeath;

	public void EnsureReplacementMaterialInstances()
	{
	}

	public void ReleaseReplacementMaterialInstances()
	{
	}

	public void ReplaceMaterial(EFriend.SparkState sparkState)
	{
	}

	public void ClearOriginalMaterial()
	{
	}

	public void UpdateStateEffects(EFriend.SparkState sparkState)
	{
	}

	public void UpdateBoxCollider(uint stage, EFriend.SparkState sparkState, SparkPetDisplaySettings displaySettings)
	{
	}
}
