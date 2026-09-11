using System;
using System.IO;
using UnityEngine;

namespace UMA;

[Serializable]
public class UmaTPose : ScriptableObject
{
	[NonSerialized]
	public SkeletonBone[] boneInfo;

	[NonSerialized]
	public HumanBone[] humanInfo;

	[NonSerialized]
	public float armStretch;

	[NonSerialized]
	public float feetSpacing;

	[NonSerialized]
	public float legStretch;

	[NonSerialized]
	public float lowerArmTwist;

	[NonSerialized]
	public float lowerLegTwist;

	[NonSerialized]
	public float upperArmTwist;

	[NonSerialized]
	public float upperLegTwist;

	[NonSerialized]
	public bool extendedInfo;

	public byte[] serializedChunk;

	public void DeSerialize()
	{
	}

	private SkeletonBone DeSerializeSkeletonBone(BinaryReader br)
	{
		return default(SkeletonBone);
	}

	private Quaternion DeSerializeQuaternion(BinaryReader br)
	{
		return default(Quaternion);
	}

	private HumanBone DeSerializeHumanBone(BinaryReader br)
	{
		return default(HumanBone);
	}

	private HumanLimit DeSerializeHumanLimit(BinaryReader br)
	{
		return default(HumanLimit);
	}

	private Vector3 DeserializeVector3(BinaryReader br)
	{
		return default(Vector3);
	}
}
