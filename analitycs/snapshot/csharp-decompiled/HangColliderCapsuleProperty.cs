using System;
using UnityEngine;

[Serializable]
public class HangColliderCapsuleProperty
{
	public string name;

	public string rootName;

	public Vector3 localPosition;

	public Vector3 localEulerAngles;

	public Vector3 localScale;

	public float ColliCapsuleRadius;

	public float ColliCapsuleHeight;

	public void ApplyValues(HangCollider_Capsule collider)
	{
	}
}
