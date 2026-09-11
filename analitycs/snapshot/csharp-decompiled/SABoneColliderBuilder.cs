using System;
using UnityEngine;

public class SABoneColliderBuilder : MonoBehaviour
{
	public SABoneColliderCommon.SABoneColliderBuilderProperty boneColliderBuilderProperty;

	[NonSerialized]
	public SABoneColliderCommon.SABoneColliderBuilderProperty edittingBoneColliderBuilderProperty;

	[NonSerialized]
	public bool cleanupModified;

	[NonSerialized]
	public bool isDebug;

	public SABoneColliderCommon.SplitProperty splitProperty => null;

	public SAColliderBuilderCommon.ReducerProperty reducerProperty => null;

	public SAColliderBuilderCommon.ColliderProperty colliderProperty => null;

	public SAColliderBuilderCommon.RigidbodyProperty rigidbodyProperty => null;
}
