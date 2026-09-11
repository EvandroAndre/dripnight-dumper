using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class BodyPartUtilByName : MonoBehaviour
{
	public class BoneInfo
	{
		public int index;

		public string boneName;

		public Vector3 scale;

		public Transform transform;

		public bool enableScale;

		public bool enablePosition;

		public Vector3 worldPosition;

		public bool enableRotation;
	}

	private bool m_updatePerFrame;

	private bool m_updateThisFrame;

	private bool m_isFindBoneTransformThisFrame;

	private List<BoneInfo> m_bones;

	public bool UpdatePerFrame
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void Clear(bool isClearAll = false)
	{
	}

	public BoneInfo GetOrAddBoneControl(string boneName)
	{
		return null;
	}

	public void ControlBoneWorldRotation(int boneIndex, Quaternion worldRotation)
	{
	}

	public void SetBoneDynamicScale(string boneName, Transform bone, Vector3 scale)
	{
	}

	private bool TryGetBone(string boneName, out BoneInfo boneInfo)
	{
		boneInfo = null;
		return false;
	}

	public void ReFindBoneTransform()
	{
	}

	public void AddOrUpdateBoneScale(string boneName, float scale)
	{
	}

	private void LateUpdate()
	{
	}

	private void setAllBoneScale()
	{
	}

	private void searchAllBoneTransform()
	{
	}
}
