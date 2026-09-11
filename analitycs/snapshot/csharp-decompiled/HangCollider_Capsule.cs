using UnityEngine;

public class HangCollider_Capsule : HangCollider
{
	public float ColliCapsuleRadius;

	public float ColliCapsuleHeight;

	private Vector3 m_CachedPosition;

	private Vector3 m_CachedForward;

	private float m_CachedRadius;

	private float m_CachedHeight;

	public void Update()
	{
	}

	public void Collider_Capsule(ref Vector3 Pos, float Rad, Matrix4x4 simulationFromRenderMatrix, bool hasRenderFromSimulationMatrix)
	{
	}

	public override HangColliderType GetColliderType()
	{
		return HangColliderType.eNone;
	}
}
