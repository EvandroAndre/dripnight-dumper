using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class BloodmoonGPCircleData
{
	public Transform Center;

	public float TriggerRadius;

	public float FadeLerpDistance;

	public int Weight;

	public List<Transform> TotemPositions;
}
