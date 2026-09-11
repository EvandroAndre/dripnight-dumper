using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCSkeletonControlImpl : MonoBehaviour
{
	public Transform ExtTransform;

	public UGCSkeletonBoneOwner Owner;

	private Transform findBone(Transform t, string name, ref int boneDepth)
	{
		return null;
	}

	public Transform FindBone(string name, ref int boneDepth)
	{
		return null;
	}

	public void LateUpdate()
	{
	}

	private void OnDestroy()
	{
	}
}
