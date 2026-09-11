using System.Collections.Generic;
using UnityEngine;

public class DynamicBoneNet : DynamicBone
{
	private class Particle
	{
		public Transform m_Transform;

		public int m_ParentIndex;

		public float m_Damping;

		public float m_Elasticity;

		public float m_Stiffness;

		public float m_Inert;

		public float m_Radius;

		public float m_BoneLength;

		public Particle m_ColomnParent;

		public Particle m_RowParent;

		public float m_Length2Parent;

		public float m_Length2NetParent;

		public Vector3 m_Position;

		public Vector3 m_PrevPosition;

		public Vector3 m_EndOffset;

		public Vector3 m_InitLocalPosition;

		public Quaternion m_InitLocalRotation;
	}

	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public Transform b;

		internal bool _003CAppendParticles_003Eb__0(Transform temp)
		{
			return false;
		}
	}

	private Dictionary<int, List<Particle>> m_ParticleDic;

	private List<Transform> m_RootChildren;

	private SortedDictionary<string, Transform> m_ChildSortedDic;

	private Vector3 m_currentScale;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void CheckDistance()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnValidate()
	{
	}

	private void UpdateDynamicBones(float t)
	{
	}

	public override void SetupParticles()
	{
	}

	private void AppendParticles(Transform b, int parentIndex, float boneLength, List<Particle> particleList, int listIndex)
	{
	}

	private Vector3 LinePointProjection(Vector3 P, Vector3 A, Vector3 B)
	{
		return default(Vector3);
	}

	public override void InitTransforms()
	{
	}

	public override void ResetParticlesPosition()
	{
	}

	private void UpdateParticles1()
	{
	}

	private void UpdateParticles2(bool useColliderCache = false)
	{
	}

	private void SkipUpdateParticles()
	{
	}

	private void ApplyParticlesToTransforms()
	{
	}
}
