using UnityEngine;

public class DynamicBoneCollider : MonoBehaviour
{
	public enum Direction
	{
		X,
		Y,
		Z
	}

	public enum Bound
	{
		Outside,
		Inside
	}

	public Vector3 m_Center;

	public float m_Radius;

	public float m_Height;

	public Direction m_Direction;

	public Bound m_Bound;

	private int m_CacheFrame;

	private bool m_FrameEnabled;

	private float m_FrameRadius;

	private float m_FrameH;

	private Vector3 m_FrameP0;

	private Vector3 m_FrameP1;

	public bool UpdateFrameCache()
	{
		return false;
	}

	public void GetCachedData(out float radius, out float h, out Vector3 p0, out Vector3 p1)
	{
		radius = default(float);
		h = default(float);
		p0 = default(Vector3);
		p1 = default(Vector3);
	}

	private void OnValidate()
	{
	}

	public void Collide(ref Vector3 particlePosition, float particleRadius)
	{
	}

	public void PostCollide(ref Vector3 particlePosition, ref Vector3 parentParticlePosition, float particleRadius)
	{
	}

	public static void OutsideSphere(ref Vector3 particlePosition, float particleRadius, Vector3 sphereCenter, float sphereRadius)
	{
	}

	public static Vector3 OutsideSphereDelta(Vector3 particlePosition, float particleRadius, Vector3 sphereCenter, float sphereRadius)
	{
		return default(Vector3);
	}

	public static Vector3 OutsideCapsuleDelta(Vector3 particlePosition, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius)
	{
		return default(Vector3);
	}

	private static Vector3 LinePointProjection(Vector3 P, Vector3 A, Vector3 B)
	{
		return default(Vector3);
	}

	public static void InsideSphere(ref Vector3 particlePosition, float particleRadius, Vector3 sphereCenter, float sphereRadius)
	{
	}

	public static void OutsideCapsule(ref Vector3 particlePosition, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius)
	{
	}

	public static void InsideCapsule(ref Vector3 particlePosition, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius)
	{
	}
}
