using System;
using UnityEngine;

namespace UMA;

[Serializable]
public class UMADynamicBoneColliderProperties : ScriptableObject
{
	public string m_RootTransformName;

	public Vector3 m_Center;

	public float m_Radius;

	public float m_Height;

	public DynamicBoneCollider.Direction m_Direction;

	public void ApplyValues(DynamicBoneCollider dynamicBoneCollider)
	{
	}

	public void ReadValues(DynamicBoneCollider dynamicBoneCollider)
	{
	}
}
