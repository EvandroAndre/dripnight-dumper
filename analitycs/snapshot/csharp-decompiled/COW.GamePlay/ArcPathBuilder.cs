using System;
using UnityEngine;

namespace COW.GamePlay;

public class ArcPathBuilder : MonoBehaviour
{
	[Serializable]
	public class KeyPoint
	{
		public Vector3 position;

		public Vector3 forward;

		[NonSerialized]
		public NDHLPICFCNG result;

		public void CONPILELJGN()
		{
		}
	}

	public KeyPoint[] points;

	[NonSerialized]
	public bool init;
}
