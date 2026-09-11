using UnityEngine;

namespace GCommon;

public class FootPrint : MonoBehaviour
{
	public float RayLength;

	public LayerMask LayerMask;

	public ParticleSystem[] AlignParticles;

	public float ParticleRotate;

	private ParticleSystem.EmissionModule[] m_Emissions;

	private ParticleSystem.MainModule[] m_Mains;

	private Matrix4x4 m_CacheLocalToWorld;

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}

	private void UpdateImp()
	{
	}

	private static float SignedAngle360(Vector3 from, Vector3 to, Vector3 up)
	{
		return 0f;
	}
}
