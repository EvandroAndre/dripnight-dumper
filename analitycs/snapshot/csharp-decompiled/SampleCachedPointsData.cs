using System;
using UnityEngine;

public class SampleCachedPointsData : ScriptableObject
{
	[Serializable]
	public struct PointInfo
	{
		public Vector3 Pos;

		public Vector3 Normal;
	}

	public PointInfo[] Points;

	public int Num;
}
