using System;

public class SABoneColliderCommon
{
	public enum BoneWeightType
	{
		Bone2,
		Bone4
	}

	public enum BoneTriangleExtent
	{
		Disable,
		Vertex2,
		Vertex1
	}

	[Serializable]
	public class BoneProperty
	{
		public bool recursivery;

		public BoneProperty ShallowCopy()
		{
			return null;
		}
	}

	[Serializable]
	public class SplitProperty
	{
		public BoneWeightType boneWeightType;

		public int boneWeight2;

		public int boneWeight3;

		public int boneWeight4;

		public bool greaterBoneWeight;

		public BoneTriangleExtent boneTriangleExtent;

		public SplitProperty ShallowCopy()
		{
			return null;
		}
	}

	[Serializable]
	public class SABoneColliderProperty
	{
		public BoneProperty boneProperty;

		public SplitProperty splitProperty;

		public SAColliderBuilderCommon.ReducerProperty reducerProperty;

		public SAColliderBuilderCommon.ColliderProperty colliderProperty;

		public SAColliderBuilderCommon.RigidbodyProperty rigidbodyProperty;

		public bool modifyNameEnabled;

		public SABoneColliderProperty Copy()
		{
			return null;
		}
	}

	[Serializable]
	public class SABoneColliderBuilderProperty
	{
		public SplitProperty splitProperty;

		public SAColliderBuilderCommon.ReducerProperty reducerProperty;

		public SAColliderBuilderCommon.ColliderProperty colliderProperty;

		public SAColliderBuilderCommon.RigidbodyProperty rigidbodyProperty;

		public bool modifyNameEnabled;

		public SABoneColliderBuilderProperty Copy()
		{
			return null;
		}

		public SABoneColliderProperty ToSABoneColliderProperty()
		{
			return null;
		}
	}
}
