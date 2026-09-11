using System;
using System.Collections.Generic;
using UnityEngine;

namespace UMA;

[Serializable]
public class UMASkeleton
{
	[Serializable]
	public class BoneData
	{
		public int boneNameHash;

		public int parentBoneNameHash;

		public Transform boneTransform;

		public UMATransform umaTransform;

		public Quaternion rotation;

		public Vector3 position;

		public Vector3 scale;

		public int accessedFrame;
	}

	protected bool updating;

	protected int frame;

	private int _003CrootBoneHash_003Ek__BackingField;

	private List<BoneData> boneHashDataBackup;

	private Dictionary<int, BoneData> boneHashDataLookup;

	public int rootBoneHash
	{
		get
		{
			return _003CrootBoneHash_003Ek__BackingField;
		}
		protected set
		{
			_003CrootBoneHash_003Ek__BackingField = value;
		}
	}

	public virtual int boneCount => 0;

	private Dictionary<int, BoneData> boneHashData
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public UMASkeleton(Transform rootBone)
	{
	}

	protected UMASkeleton()
	{
	}

	public virtual void BeginSkeletonUpdate()
	{
	}

	public virtual void EndSkeletonUpdate()
	{
	}

	private void AddBonesRecursive(Transform transform)
	{
	}

	public virtual bool HasBone(int nameHash)
	{
		return false;
	}

	public virtual void AddBone(UMATransform transform)
	{
	}

	public virtual Transform GetBoneTransform(int nameHash)
	{
		return null;
	}

	public virtual GameObject GetBoneGameObject(int nameHash)
	{
		return null;
	}

	public virtual void SetPosition(int nameHash, Vector3 position)
	{
	}

	public virtual void SetScale(int nameHash, Vector3 scale)
	{
	}

	public virtual void SetRotation(int nameHash, Quaternion rotation)
	{
	}

	public virtual void ResetAll()
	{
	}

	public virtual void ResetScales()
	{
	}

	public static int StringToHash(string name)
	{
		return 0;
	}

	public virtual Transform[] HashesToTransforms(int[] boneNameHashes)
	{
		return null;
	}

	public virtual Transform[] HashesToTransforms(List<int> boneNameHashes)
	{
		return null;
	}

	public virtual void EnsureBone(UMATransform umaTransform)
	{
	}

	public virtual void EnsureBoneHierarchy()
	{
	}
}
