using System;
using UnityEngine;

namespace UMA.PoseTools;

[Serializable]
public class UMABonePose : ScriptableObject
{
	[Serializable]
	public class PoseBone
	{
		public string bone;

		public int hash;

		public Vector3 position;

		public Quaternion rotation;

		public Vector3 scale;
	}

	public PoseBone[] poses;

	public UMABonePose[] tweenPoses;

	public float[] tweenWeights;

	private void Reset()
	{
	}

	private void OnEnable()
	{
	}
}
