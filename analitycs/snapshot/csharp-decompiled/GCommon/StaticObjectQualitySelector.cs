using System;
using System.Collections.Generic;
using UnityEngine;

namespace GCommon;

public class StaticObjectQualitySelector : MonoBehaviour
{
	[Serializable]
	public class DynamicObject
	{
		public string resID;

		public Vector3 position;

		public Quaternion rotation;

		public Vector3 scale;
	}

	public List<DynamicObject> objList;

	private void Start()
	{
	}
}
