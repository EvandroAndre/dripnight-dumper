using UnityEngine;

namespace GCommon;

public class AlignNormalV2 : MonoBehaviour
{
	public GameObject Target;

	public float RayLength;

	public LayerMask LayerMask;

	public Vector3 RayCastoffset;

	public Vector3 Rotation;

	public Vector3 Offset;

	public bool IsMovable;

	public bool IgnoreSLevelObject;

	public bool NoGroundSnapping;

	public bool RotateAsTarget;

	public float ParticleRotate;

	private ParticleSystem[] m_AlignParticles;

	private ParticleSystem.MainModule[] m_Mains;

	private Matrix4x4 m_CacheLocalToWorld;

	private RaycastHit[] hitInfos;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void AttachParticle()
	{
	}

	private void RotateParticles()
	{
	}

	private void BubbleSortByDistance(RaycastHit[] hits, int n)
	{
	}

	private bool IsSLevelObject(Collider collider)
	{
		return false;
	}

	private static float SignedAngle360(Vector3 from, Vector3 to, Vector3 up)
	{
		return 0f;
	}

	private void UpdateImp()
	{
	}
}
