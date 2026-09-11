using System;
using UnityEngine;

namespace UMA;

[Serializable]
public class UMADynamicBoneProperties : ScriptableObject
{
	public float m_UpdateRate;

	public float m_Damping;

	public float m_Elasticity;

	public float m_Stiffness;

	public float m_Inert;

	public float m_Radius;

	public float m_EndLength;

	public Vector3 m_EndOffset;

	public Vector3 m_Gravity;

	public Vector3 m_Force;

	public bool m_AnimationControlled;

	public bool m_useNet;

	public Vector3 m_RandomAcceleration;

	public int m_RandomAccelerationInterval;

	public void ApplyValues(DynamicBone dynamicBone, Transform root)
	{
	}

	public void ApplyValues(DynamicBoneNet dynamicBoneNet, Transform root)
	{
	}

	public void ReadValues(DynamicBone dynamicBone)
	{
	}
}
