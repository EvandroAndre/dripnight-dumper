using System;
using System.Collections.Generic;
using UnityEngine;

public class DynamicBone : MonoBehaviour
{
	public enum FreezeAxis
	{
		None,
		X,
		Y,
		Z
	}

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

		public float m_Length2Parent;

		public Vector3 m_Position;

		public Vector3 m_PrevPosition;

		public Vector3 m_EndOffset;

		public Vector3 m_InitLocalPosition;

		public Quaternion m_InitLocalRotation;

		public Vector3 m_TransformPosition;

		public Vector3 m_TransformLocalPosition;

		public Matrix4x4 m_TransformLocalToWorldMatrix;
	}

	protected struct CachedCollider
	{
		public float radius;

		public bool isSphere;

		public bool isOutside;

		public Vector3 p0;

		public Vector3 p1;
	}

	public enum UpdateMode
	{
		Normal,
		AnimatePhysics
	}

	private sealed class _003C_003Ec__DisplayClass75_0
	{
		public Transform b;

		internal bool _003CAppendParticles_003Eb__0(Transform temp)
		{
			return false;
		}
	}

	public Transform m_Root;

	public float m_UpdateRate;

	public float m_Damping;

	public AnimationCurve m_DampingDistrib;

	public float m_Elasticity;

	public AnimationCurve m_ElasticityDistrib;

	public float m_Stiffness;

	public AnimationCurve m_StiffnessDistrib;

	public float m_Inert;

	public AnimationCurve m_InertDistrib;

	public float m_Radius;

	public AnimationCurve m_RadiusDistrib;

	public float m_EndLength;

	public Vector3 m_EndOffset;

	public Vector3 m_Gravity;

	public Vector3 m_Force;

	public List<DynamicBoneCollider> m_Colliders;

	public List<Transform> m_Exclusions;

	public List<Transform> m_ValidBones;

	public bool m_AnimationControlled;

	public bool m_Permanant;

	private float m_DumbTime;

	private float m_OrginalStiffness;

	private bool _003CFullInert_003Ek__BackingField;

	public FreezeAxis m_FreezeAxis;

	public bool m_DistantDisable;

	public Transform m_ReferenceObject;

	public float m_DistanceToObject;

	public Vector3 m_RandomAcceleration;

	public int m_RandomAccelerationInterval;

	protected int m_RAIndex;

	protected int m_RALerpCount;

	protected Vector3 m_LocalGravity;

	protected Vector3 m_ObjectMove;

	protected Vector3 m_ObjectPrevPosition;

	protected int m_RandomAccelerationCount;

	protected float m_BoneTotalLength;

	protected float m_ObjectScale;

	protected float m_Time;

	protected float m_Weight;

	protected bool m_DistantDisabled;

	protected bool m_Rand;

	private Vector3 m_CurrentRandomAcceleration;

	private int m_PreUpdateCount;

	public bool m_UseRandomForce;

	public bool m_RemoveWhenUMARebuild;

	public float m_MaxMoveDelta;

	private List<Particle> m_Particles;

	private float m_DeltaTime;

	protected CachedCollider[] m_CachedColliders;

	protected int m_CachedColliderCount;

	[NonSerialized]
	public UpdateMode m_UpdateMode;

	public bool FullInert
	{
		get
		{
			return _003CFullInert_003Ek__BackingField;
		}
		set
		{
			_003CFullInert_003Ek__BackingField = value;
		}
	}

	private void PreUpdate()
	{
	}

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	private void Update()
	{
	}

	private void Awake()
	{
	}

	public void ResetDumbTime()
	{
	}

	private void LateUpdate()
	{
	}

	private void Prepare()
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

	public void SetWeight(float w)
	{
	}

	public float GetWeight()
	{
		return 0f;
	}

	private void UpdateDynamicBones(float t)
	{
	}

	public virtual void SetupParticles()
	{
	}

	private void AppendParticles(Transform b, int parentIndex, float boneLength)
	{
	}

	public virtual void InitTransforms()
	{
	}

	public virtual void ResetParticlesPosition()
	{
	}

	private void UpdateParticles1(float timeVar, int loopIndex)
	{
	}

	private void UpdateParticles2(float timeVar, bool useColliderCache = false)
	{
	}

	protected void BuildColliderCache()
	{
	}

	private void SkipUpdateParticles()
	{
	}

	private void ApplyParticlesToTransforms()
	{
	}
}
