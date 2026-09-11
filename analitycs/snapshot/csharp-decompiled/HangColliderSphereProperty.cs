using System;
using UnityEngine;

[Serializable]
public class HangColliderSphereProperty
{
	public string name;

	public string rootName;

	public Vector3 localPosition;

	public Vector3 localEulerAngles;

	public Vector3 localScale;

	public float ColliSphereRadius;

	public void ApplyValues(HangCollider_Sphere collider)
	{
	}
}
