using System;
using UnityEngine;

public class SABoneCollider : MonoBehaviour
{
	public SABoneColliderCommon.SABoneColliderProperty boneColliderProperty;

	public string defaultName;

	public SABoneColliderCommon.SABoneColliderProperty defaultBoneColliderProperty;

	[NonSerialized]
	public SABoneColliderCommon.SABoneColliderProperty edittingBoneColliderProperty;

	public bool modified;

	public bool modifiedChildren;

	[NonSerialized]
	public bool cleanupModified;

	[NonSerialized]
	public bool isDebug;

	public SABoneColliderCommon.BoneProperty boneProperty => null;

	public SABoneColliderCommon.SplitProperty splitProperty => null;

	public SAColliderBuilderCommon.ReducerProperty reducerProperty => null;

	public SAColliderBuilderCommon.ColliderProperty colliderProperty => null;

	public SAColliderBuilderCommon.RigidbodyProperty rigidbodyProperty => null;

	public bool recursivery => false;

	public bool modifyNameEnalbed => false;

	public void ChangeDefaultName(string defaultName)
	{
	}

	public void ChangeModified(bool modified)
	{
	}

	public void ChangeModifiedChildren(bool modifiedChildren)
	{
	}

	public void ResetModified()
	{
	}

	public void ResetModifyName()
	{
	}

	public string _ComputeModifyName()
	{
		return null;
	}

	public bool _IsModifyName()
	{
		return false;
	}
}
