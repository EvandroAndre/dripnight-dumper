using UnityEngine;

public class HangCollider_Plane : HangCollider
{
	private Vector3 m_CachedPosition;

	private Vector3 m_CachedForward;

	public void Update()
	{
	}

	public void Collider_Plane(ref Vector3 Pos, float Rad, Matrix4x4 simulationFromRenderMatrix, bool hasRenderFromSimulationMatrix)
	{
	}

	public override HangColliderType GetColliderType()
	{
		return HangColliderType.eNone;
	}
}
