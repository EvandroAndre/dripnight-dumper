using System;
using UnityEngine;

[Serializable]
public class HangColliderPlaneProperty
{
	public string name;

	public string rootName;

	public Vector3 localPosition;

	public Vector3 localEulerAngles;

	public Vector3 localScale;

	public void ApplyValues(HangCollider_Plane collider)
	{
	}
}
