using UnityEngine;

public class HangCollider_Sphere : HangCollider
{
	public float ColliSphereRadius;

	private Vector3 m_CachedPosition;

	private float m_CachedRadius;

	public void Update()
	{
	}

	public void Collider_Sphere(ref Vector3 Pos, float Rad, Matrix4x4 simulationFromRenderMatrix, bool hasRenderFromSimulationMatrix)
	{
	}

	public override HangColliderType GetColliderType()
	{
		return HangColliderType.eNone;
	}
}
